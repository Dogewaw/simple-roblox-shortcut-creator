using System.Net;
using System.Net.Http.Json;
using System.Reflection;

namespace WinFormsApp1
{
    public partial class ShortcutCreator : Form
    {
        public static String ImageUrl = "";
        public static long Gameid = 1;
        public static String GameTitle = "";
        string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string desk = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        public ShortcutCreator()
        {
            InitializeComponent();
        }

        private void InputIDBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void ServerIDBox_TextChanged(object sender, EventArgs e)
        {
        }
        public async void PreviewButtonEvent(object sender, EventArgs e)
        {
            if (GameIDBox.Text == "")
            {
                return;
            }
            using HttpClient client = new();

            static async Task<Root> ProcessRepositoriesAsync(HttpClient client, string id, bool iscircular, string size, string format)
            {
                Root product = null;
                string path = ($"https://thumbnails.roblox.com/v1/places/gameicons?placeIds={id}&returnPolicy=PlaceHolder&size={size}&format={format}&isCircular={iscircular}");

                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    product = await response.Content.ReadFromJsonAsync<Root>();
                }
                return product;
            }
            var jsondata = await ProcessRepositoriesAsync(client, GameIDBox.Text, circularBox.Checked, SizeBox.Text, FormatBox.Text);
            if (jsondata != null)
            {
                foreach (var data in jsondata.data)
                {
                    ImageUrl = data.imageUrl;
                    Gameid = data.targetId;
                }
                UpdateImage();
            }
            else
            {
                MessageBox.Show("Invalid Experience ID");
            }
        }

        public void CreateButtonEvent(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(desk + "\\" + $"{ExperienceTitle.Text}.Url"))
            {
                writer.WriteLine("[InternetShortcut]");
                if (ServerIDBox.Text == "")
                {
                    writer.WriteLine($"URL=roblox://placeId={GameIDBox.Text}/");
                }
                else
                {
                    writer.WriteLine($"URL=roblox://placeId={GameIDBox.Text}&linkCode%{ServerIDBox.Text}/");
                }
                writer.WriteLine("IconIndex=0");
            }
        }
        private void UpdateImage()
        {
            using (WebClient client = new WebClient())
            {
                if (File.Exists(executableLocation + $"/{Gameid}.{FormatBox.Text}"))
                {
                    pictureBox1.Image.Dispose();
                    File.Delete(executableLocation + $"/{Gameid}.{FormatBox.Text}");
                }
                client.DownloadFile(ImageUrl, executableLocation + $"/{Gameid}.{FormatBox.Text}");
                Image image1 = Image.FromFile(executableLocation + $"/{Gameid}.{FormatBox.Text}");
                pictureBox1.Image = image1;
            }
        }

        private void circularBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}