namespace NetworkProject
{
    partial class PrivateChattingRoom
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
            this.chattingText = new System.Windows.Forms.TextBox();
            this.chattingList = new System.Windows.Forms.ListBox();
            this.sendMsg = new System.Windows.Forms.Button();
            this.startChat = new System.Windows.Forms.Button();
            this.waitState = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chattingText
            // 
            this.chattingText.Location = new System.Drawing.Point(12, 384);
            this.chattingText.Name = "chattingText";
            this.chattingText.Size = new System.Drawing.Size(288, 21);
            this.chattingText.TabIndex = 0;
            this.chattingText.TextChanged += new System.EventHandler(this.chattingText_TextChanged);
            // 
            // chattingList
            // 
            this.chattingList.FormattingEnabled = true;
            this.chattingList.ItemHeight = 12;
            this.chattingList.Location = new System.Drawing.Point(12, 21);
            this.chattingList.Name = "chattingList";
            this.chattingList.Size = new System.Drawing.Size(288, 316);
            this.chattingList.TabIndex = 1;
            // 
            // sendMsg
            // 
            this.sendMsg.Location = new System.Drawing.Point(306, 382);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(75, 23);
            this.sendMsg.TabIndex = 2;
            this.sendMsg.Text = "Send";
            this.sendMsg.UseVisualStyleBackColor = true;
            this.sendMsg.Click += new System.EventHandler(this.sendMsg_Click);
            // 
            // startChat
            // 
            this.startChat.Location = new System.Drawing.Point(306, 91);
            this.startChat.Name = "startChat";
            this.startChat.Size = new System.Drawing.Size(75, 71);
            this.startChat.TabIndex = 4;
            this.startChat.Text = "Start";
            this.startChat.UseVisualStyleBackColor = true;
            this.startChat.Click += new System.EventHandler(this.startChat_Click);
            // 
            // waitState
            // 
            this.waitState.Location = new System.Drawing.Point(306, 21);
            this.waitState.Name = "waitState";
            this.waitState.Size = new System.Drawing.Size(75, 64);
            this.waitState.TabIndex = 5;
            this.waitState.Text = "Wait";
            this.waitState.UseVisualStyleBackColor = true;
            this.waitState.Click += new System.EventHandler(this.waitState_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 7;
            // 
            // PrivateChattingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waitState);
            this.Controls.Add(this.startChat);
            this.Controls.Add(this.sendMsg);
            this.Controls.Add(this.chattingList);
            this.Controls.Add(this.chattingText);
            this.Name = "PrivateChattingRoom";
            this.Text = "PrivateChattingRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrivateChattingRoom_FormClosing);
            this.Load += new System.EventHandler(this.PrivateChattingRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chattingText;
        private System.Windows.Forms.ListBox chattingList;
        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.Button startChat;
        private System.Windows.Forms.Button waitState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}