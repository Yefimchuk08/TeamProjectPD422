﻿namespace TeamProjectPD422
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            UserName = new TextBox();
            Password = new TextBox();
            Login = new Button();
            CreateLogin = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            Checknotrobot = new CheckBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(24, 319);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 4);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(59, 279);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 1;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(59, 331);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // UserName
            // 
            UserName.Location = new Point(174, 281);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Name = "UserName";
            UserName.Size = new Size(275, 27);
            UserName.TabIndex = 3;
            UserName.TextChanged += UserName_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(174, 331);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.Size = new Size(275, 27);
            Password.TabIndex = 4;
            Password.TextChanged += Password_TextChanged;
            // 
            // Login
            // 
            Login.Location = new Point(111, 511);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(239, 33);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // CreateLogin
            // 
            CreateLogin.Location = new Point(111, 552);
            CreateLogin.Margin = new Padding(3, 4, 3, 4);
            CreateLogin.Name = "CreateLogin";
            CreateLogin.Size = new Size(239, 33);
            CreateLogin.TabIndex = 6;
            CreateLogin.Text = "Create Login";
            CreateLogin.UseVisualStyleBackColor = true;
            CreateLogin.Click += CreateLogin_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "7acb93bc-b069-4a6e-bb4d-2b6e59a7dc48.jpg");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 331);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 32);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 279);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 32);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(161, 212);
            label3.Name = "label3";
            label3.Size = new Size(116, 41);
            label3.TabIndex = 9;
            label3.Text = "LOG IN";
            // 
            // Checknotrobot
            // 
            Checknotrobot.AutoSize = true;
            Checknotrobot.BackColor = SystemColors.ActiveCaptionText;
            Checknotrobot.ForeColor = SystemColors.Control;
            Checknotrobot.Location = new Point(23, 384);
            Checknotrobot.Margin = new Padding(3, 4, 3, 4);
            Checknotrobot.Name = "Checknotrobot";
            Checknotrobot.Size = new Size(130, 24);
            Checknotrobot.TabIndex = 10;
            Checknotrobot.Text = "I'm not a robot";
            Checknotrobot.UseVisualStyleBackColor = false;
            Checknotrobot.CheckedChanged += Checknotrobot_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(130, 11);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 157);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(463, 663);
            Controls.Add(pictureBox3);
            Controls.Add(Checknotrobot);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(CreateLogin);
            Controls.Add(Login);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox UserName;
        private TextBox Password;
        private Button Login;
        private Button CreateLogin;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private CheckBox Checknotrobot;
        private PictureBox pictureBox3;
    }
}
