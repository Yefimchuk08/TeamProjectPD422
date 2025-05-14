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
            SuspendLayout();
            // 
            // ChatBox
            // 
            ChatBox.Location = new Point(295, 12);
            ChatBox.Multiline = true;
            ChatBox.Name = "ChatBox";
            ChatBox.Size = new Size(407, 360);
            ChatBox.TabIndex = 0;
            // 
            // Send
            // 
            Send.ForeColor = SystemColors.ActiveCaptionText;
            Send.Location = new Point(648, 398);
            Send.Name = "Send";
            Send.Size = new Size(54, 40);
            Send.TabIndex = 1;
            Send.Text = "Send🚀";
            Send.UseVisualStyleBackColor = true;
            // 
            // EnterChat
            // 
            EnterChat.Location = new Point(295, 392);
            EnterChat.Multiline = true;
            EnterChat.Name = "EnterChat";
            EnterChat.Size = new Size(347, 44);
            EnterChat.TabIndex = 2;
            // 
            // ChatList
            // 
            ChatList.FormattingEnabled = true;
            ChatList.Location = new Point(12, 12);
            ChatList.Name = "ChatList";
            ChatList.Size = new Size(256, 424);
            ChatList.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(714, 450);
            Controls.Add(ChatList);
            Controls.Add(EnterChat);
            Controls.Add(Send);
            Controls.Add(ChatBox);
            ForeColor = SystemColors.Control;
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
    }
}