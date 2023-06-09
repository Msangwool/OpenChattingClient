namespace NetworkProject
{
    partial class OpenChattingRoom
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
            this.chattingList = new System.Windows.Forms.ListBox();
            this.chattingText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendMsg
            // 
            this.sendMsg.Location = new System.Drawing.Point(324, 369);
            this.sendMsg.Name = "sendMsg";
            this.sendMsg.Size = new System.Drawing.Size(75, 23);
            this.sendMsg.TabIndex = 0;
            this.sendMsg.Text = "Send";
            this.sendMsg.UseVisualStyleBackColor = true;
            this.sendMsg.Click += new System.EventHandler(this.sendMsg_Click);
            // 
            // chattingList
            // 
            this.chattingList.FormattingEnabled = true;
            this.chattingList.ItemHeight = 12;
            this.chattingList.Location = new System.Drawing.Point(23, 25);
            this.chattingList.Name = "chattingList";
            this.chattingList.Size = new System.Drawing.Size(288, 328);
            this.chattingList.TabIndex = 1;
            // 
            // chattingText
            // 
            this.chattingText.Location = new System.Drawing.Point(23, 369);
            this.chattingText.Name = "chattingText";
            this.chattingText.Size = new System.Drawing.Size(288, 21);
            this.chattingText.TabIndex = 2;
            this.chattingText.TextChanged += new System.EventHandler(this.chattingText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // OpenChattingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chattingText);
            this.Controls.Add(this.chattingList);
            this.Controls.Add(this.sendMsg);
            this.Name = "OpenChattingRoom";
            this.Text = "OpenChattingRoom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenChattingRoom_FormClosing);
            this.Load += new System.EventHandler(this.OpenChattingRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMsg;
        private System.Windows.Forms.ListBox chattingList;
        private System.Windows.Forms.TextBox chattingText;
        private System.Windows.Forms.Label label1;
    }
}