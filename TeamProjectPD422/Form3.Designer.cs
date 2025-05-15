namespace TeamProjectPD422
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            CreateLogin = new Button();
            UserName = new TextBox();
            Password = new TextBox();
            Emeil = new TextBox();
            pictureBox4 = new PictureBox();
            Checknotrobot = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaptionText;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(139, 16);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 155);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(179, 217);
            label3.Name = "label3";
            label3.Size = new Size(116, 41);
            label3.TabIndex = 13;
            label3.Text = "LOG IN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(55, 281);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 14;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(51, 381);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 15;
            label2.Text = "Password :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(14, 327);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 4);
            panel1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 287);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 32);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(55, 341);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 18;
            label4.Text = "Email :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 381);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 32);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // CreateLogin
            // 
            CreateLogin.Location = new Point(113, 491);
            CreateLogin.Margin = new Padding(3, 4, 3, 4);
            CreateLogin.Name = "CreateLogin";
            CreateLogin.Size = new Size(239, 33);
            CreateLogin.TabIndex = 20;
            CreateLogin.Text = "Create Login";
            CreateLogin.UseVisualStyleBackColor = true;
            CreateLogin.Click += CreateLogin_Click;
            // 
            // UserName
            // 
            UserName.Location = new Point(161, 284);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Name = "UserName";
            UserName.Size = new Size(275, 27);
            UserName.TabIndex = 21;
            UserName.TextChanged += UserName_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(161, 384);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Name = "Password";
            Password.Size = new Size(275, 27);
            Password.TabIndex = 22;
            Password.TextChanged += Password_TextChanged;
            // 
            // Emeil
            // 
            Emeil.Location = new Point(161, 341);
            Emeil.Margin = new Padding(3, 4, 3, 4);
            Emeil.Name = "Emeil";
            Emeil.Size = new Size(275, 27);
            Emeil.TabIndex = 23;
            Emeil.TextChanged += Emeil_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(21, 339);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 32);
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // Checknotrobot
            // 
            Checknotrobot.AutoSize = true;
            Checknotrobot.BackColor = SystemColors.ActiveCaptionText;
            Checknotrobot.ForeColor = SystemColors.Control;
            Checknotrobot.Location = new Point(21, 437);
            Checknotrobot.Margin = new Padding(3, 4, 3, 4);
            Checknotrobot.Name = "Checknotrobot";
            Checknotrobot.Size = new Size(130, 24);
            Checknotrobot.TabIndex = 25;
            Checknotrobot.Text = "I'm not a robot";
            Checknotrobot.UseVisualStyleBackColor = false;
            Checknotrobot.CheckedChanged += Checknotrobot_CheckedChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(463, 663);
            Controls.Add(Checknotrobot);
            Controls.Add(pictureBox4);
            Controls.Add(Emeil);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(CreateLogin);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label label3;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox pictureBox1;
        private Button CreateLogin;
        private TextBox UserName;
        private TextBox Password;
        private TextBox Emeil;
        private PictureBox pictureBox4;
        private CheckBox Checknotrobot;
    }
}