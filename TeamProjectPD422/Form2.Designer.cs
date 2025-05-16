namespace TeamProjectPD422
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            ChatBox = new TextBox();
            Send = new Button();
            EnterChat = new TextBox();
            ChatList = new ListBox();
            NewClient = new Button();
            SuspendLayout();
            // 
            // ChatBox
            // 
            ChatBox.Location = new Point(337, 16);
            ChatBox.Margin = new Padding(3, 4, 3, 4);
            ChatBox.Multiline = true;
            ChatBox.Name = "ChatBox";
            ChatBox.Size = new Size(465, 499);
            ChatBox.TabIndex = 0;
            // 
            // Send
            // 
            Send.ForeColor = SystemColors.ActiveCaptionText;
            Send.Location = new Point(741, 531);
            Send.Margin = new Padding(3, 4, 3, 4);
            Send.Name = "Send";
            Send.Size = new Size(62, 53);
            Send.TabIndex = 1;
            Send.Text = "Send🚀";
            Send.UseVisualStyleBackColor = true;
            // 
            // EnterChat
            // 
            EnterChat.Location = new Point(337, 523);
            EnterChat.Margin = new Padding(3, 4, 3, 4);
            EnterChat.Multiline = true;
            EnterChat.Name = "EnterChat";
            EnterChat.Size = new Size(396, 57);
            EnterChat.TabIndex = 2;
            // 
            // ChatList
            // 
            ChatList.FormattingEnabled = true;
            ChatList.Location = new Point(14, 16);
            ChatList.Margin = new Padding(3, 4, 3, 4);
            ChatList.Name = "ChatList";
            ChatList.Size = new Size(292, 364);
            ChatList.TabIndex = 3;
            // 
            // NewClient
            // 
            NewClient.ForeColor = SystemColors.ActiveCaptionText;
            NewClient.Location = new Point(14, 523);
            NewClient.Name = "NewClient";
            NewClient.Size = new Size(292, 65);
            NewClient.TabIndex = 4;
            NewClient.Text = "Create New Client";
            NewClient.UseVisualStyleBackColor = true;
            NewClient.Click += NewClient_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(816, 600);
            Controls.Add(NewClient);
            Controls.Add(ChatList);
            Controls.Add(EnterChat);
            Controls.Add(Send);
            Controls.Add(ChatBox);
            ForeColor = SystemColors.Control;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Chat";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ChatBox;
        private Button Send;
        private TextBox EnterChat;
        private ListBox ChatList;
        private Button NewClient;
    }
}