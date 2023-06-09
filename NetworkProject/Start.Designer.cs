namespace NetworkProject
{
    partial class Start
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
            this.startRandom = new System.Windows.Forms.Button();
            this.openChatting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startRandom
            // 
            this.startRandom.Location = new System.Drawing.Point(12, 50);
            this.startRandom.Name = "startRandom";
            this.startRandom.Size = new System.Drawing.Size(111, 23);
            this.startRandom.TabIndex = 0;
            this.startRandom.Text = "RandomChatting";
            this.startRandom.UseVisualStyleBackColor = true;
            this.startRandom.Click += new System.EventHandler(this.startRandom_Click);
            // 
            // openChatting
            // 
            this.openChatting.Location = new System.Drawing.Point(12, 152);
            this.openChatting.Name = "openChatting";
            this.openChatting.Size = new System.Drawing.Size(100, 23);
            this.openChatting.TabIndex = 1;
            this.openChatting.Text = "OpenChatting";
            this.openChatting.UseVisualStyleBackColor = true;
            this.openChatting.Click += new System.EventHandler(this.openChatting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "랜덤 1대1 채팅을 할 수 있습니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "익명으로 멀티 채팅이 가능합니다.";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openChatting);
            this.Controls.Add(this.startRandom);
            this.Name = "Start";
            this.Text = "Start";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startRandom;
        private System.Windows.Forms.Button openChatting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}