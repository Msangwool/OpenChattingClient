namespace NetworkProject
{
    partial class GroupChattingRoom
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
            this.sendMsg = new System.Windows.Forms.Button();
            this.chattingText = new System.Windows.Forms.TextBox();
            this.chattingList = new System.Windows.Forms.ListBox();
            this.showList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.silenceChat = new System.Windows.Forms.ListBox();
            this.userID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendMsg
            // 
            this.sendMsg.Location = new System.Drawing.Point(318, 485);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(75, 23);
            this.sendMsg.TabIndex = 0;
            this.sendMsg.Text = "Send";
            this.sendMsg.UseVisualStyleBackColor = true;
            this.sendMsg.Click += new System.EventHandler(this.sendMsg_Click);
            // 
            // chattingText
            // 
            this.chattingText.Location = new System.Drawing.Point(12, 487);
            this.chattingText.Name = "chattingText";
            this.chattingText.Size = new System.Drawing.Size(296, 21);
            this.chattingText.TabIndex = 2;
            // 
            // chattingList
            // 
            this.chattingList.FormattingEnabled = true;
            this.chattingList.ItemHeight = 12;
            this.chattingList.Location = new System.Drawing.Point(12, 23);
            this.chattingList.Name = "chattingList";
            this.chattingList.Size = new System.Drawing.Size(295, 292);
            this.chattingList.TabIndex = 3;
            this.chattingList.SelectedIndexChanged += new System.EventHandler(this.chattingList_SelectedIndexChanged);
            // 
            // showList
            // 
            this.showList.FormattingEnabled = true;
            this.showList.ItemHeight = 12;
            this.showList.Location = new System.Drawing.Point(319, 23);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(120, 184);
            this.showList.TabIndex = 4;
            this.showList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.showList_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "귓속말 채팅";
            // 
            // silenceChat
            // 
            this.silenceChat.FormattingEnabled = true;
            this.silenceChat.ItemHeight = 12;
            this.silenceChat.Location = new System.Drawing.Point(12, 323);
            this.silenceChat.Name = "silenceChat";
            this.silenceChat.Size = new System.Drawing.Size(427, 136);
            this.silenceChat.TabIndex = 6;
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Location = new System.Drawing.Point(13, 5);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(0, 12);
            this.userID.TabIndex = 7;
            // 
            // GroupChattingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 520);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.silenceChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.chattingList);
            this.Controls.Add(this.chattingText);
            this.Controls.Add(this.sendMsg);
            this.Name = "GroupChattingRoom";
            this.Text = "GroupChattingRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GroupChattingRoom_FormClosing);
            this.Load += new System.EventHandler(this.GroupChattingRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.TextBox chattingText;
        private System.Windows.Forms.ListBox chattingList;
        private System.Windows.Forms.ListBox showList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox silenceChat;
        private System.Windows.Forms.Label userID;
    }
}