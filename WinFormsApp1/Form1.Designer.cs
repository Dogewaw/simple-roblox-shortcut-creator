namespace WinFormsApp1
{
    partial class ShortcutCreator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            GameIDBox = new TextBox();
            CreateButton = new Button();
            ServerIDBox = new TextBox();
            ExperienceTitle = new TextBox();
            PreviewButton = new Button();
            circularBox = new CheckBox();
            SizeBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            FormatBox = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.ImageLocation = "Untitled.Png";
            pictureBox1.Location = new Point(191, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // GameIDBox
            // 
            GameIDBox.Cursor = Cursors.IBeam;
            GameIDBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            GameIDBox.Location = new Point(191, 179);
            GameIDBox.Name = "GameIDBox";
            GameIDBox.PlaceholderText = "Experience ID";
            GameIDBox.Size = new Size(128, 25);
            GameIDBox.TabIndex = 2;
            GameIDBox.TextChanged += InputIDBox_TextChanged;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.FromArgb(34, 56, 67);
            CreateButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateButton.ForeColor = Color.FromArgb(255, 224, 192);
            CreateButton.Location = new Point(191, 239);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(128, 23);
            CreateButton.TabIndex = 5;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButtonEvent;
            // 
            // ServerIDBox
            // 
            ServerIDBox.Cursor = Cursors.IBeam;
            ServerIDBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ServerIDBox.Location = new Point(191, 208);
            ServerIDBox.Name = "ServerIDBox";
            ServerIDBox.PlaceholderText = "Private Server ID";
            ServerIDBox.Size = new Size(128, 25);
            ServerIDBox.TabIndex = 3;
            ServerIDBox.TextChanged += ServerIDBox_TextChanged;
            // 
            // ExperienceTitle
            // 
            ExperienceTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExperienceTitle.Location = new Point(191, 146);
            ExperienceTitle.Name = "ExperienceTitle";
            ExperienceTitle.PlaceholderText = "[Insert Experience Title Here]";
            ExperienceTitle.Size = new Size(128, 29);
            ExperienceTitle.TabIndex = 1;
            ExperienceTitle.Text = "[Experience Title]";
            // 
            // PreviewButton
            // 
            PreviewButton.BackColor = Color.FromArgb(34, 56, 67);
            PreviewButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PreviewButton.ForeColor = Color.FromArgb(255, 255, 192);
            PreviewButton.Location = new Point(32, 146);
            PreviewButton.Name = "PreviewButton";
            PreviewButton.Size = new Size(128, 24);
            PreviewButton.TabIndex = 4;
            PreviewButton.Text = "Download";
            PreviewButton.UseVisualStyleBackColor = false;
            PreviewButton.Click += PreviewButtonEvent;
            // 
            // circularBox
            // 
            circularBox.AutoSize = true;
            circularBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            circularBox.Location = new Point(85, 42);
            circularBox.Name = "circularBox";
            circularBox.Size = new Size(80, 21);
            circularBox.TabIndex = 6;
            circularBox.Text = "isCircular";
            circularBox.UseVisualStyleBackColor = true;
            circularBox.CheckedChanged += circularBox_CheckedChanged;
            // 
            // SizeBox
            // 
            SizeBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SizeBox.FormattingEnabled = true;
            SizeBox.Items.AddRange(new object[] { "50x50", "128x128", "150x150", "256x256", "420x420", "512x512" });
            SizeBox.Location = new Point(85, 69);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(75, 25);
            SizeBox.TabIndex = 7;
            SizeBox.Text = "50x50";
            SizeBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 12);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 8;
            label1.Text = "Image Settings";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 42);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 9;
            label2.Text = "Shape";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 72);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 10;
            label3.Text = "Size";
            // 
            // FormatBox
            // 
            FormatBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormatBox.FormattingEnabled = true;
            FormatBox.Items.AddRange(new object[] { "Png", "Jpeg" });
            FormatBox.Location = new Point(85, 100);
            FormatBox.Name = "FormatBox";
            FormatBox.Size = new Size(75, 25);
            FormatBox.TabIndex = 11;
            FormatBox.Text = "Png";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 103);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 12;
            label4.Text = "Format";
            // 
            // ShortcutCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 56, 67);
            ClientSize = new Size(331, 315);
            Controls.Add(label4);
            Controls.Add(FormatBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SizeBox);
            Controls.Add(circularBox);
            Controls.Add(PreviewButton);
            Controls.Add(ExperienceTitle);
            Controls.Add(ServerIDBox);
            Controls.Add(CreateButton);
            Controls.Add(GameIDBox);
            Controls.Add(pictureBox1);
            ForeColor = Color.FromArgb(239, 241, 243);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ShortcutCreator";
            Text = "Simple Roblox Shortcut Creator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox GameIDBox;
        private Button CreateButton;
        private TextBox ServerIDBox;
        private TextBox ExperienceTitle;
        private Button PreviewButton;
        private CheckBox circularBox;
        private ComboBox SizeBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox FormatBox;
        private Label label4;
    }
}