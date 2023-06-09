namespace NetworkProject
{
    partial class login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNomal = new System.Windows.Forms.Button();
            this.btnAnonymous = new System.Windows.Forms.Button();
            this.userID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNomal
            // 
            this.btnNomal.Location = new System.Drawing.Point(122, 62);
            this.btnNomal.Name = "btnNomal";
            this.btnNomal.Size = new System.Drawing.Size(85, 23);
            this.btnNomal.TabIndex = 1;
            this.btnNomal.Text = "Nomal";
            this.btnNomal.UseVisualStyleBackColor = true;
            this.btnNomal.Click += new System.EventHandler(this.btnNomal_Click);
            // 
            // btnAnonymous
            // 
            this.btnAnonymous.Location = new System.Drawing.Point(20, 62);
            this.btnAnonymous.Name = "btnAnonymous";
            this.btnAnonymous.Size = new System.Drawing.Size(83, 23);
            this.btnAnonymous.TabIndex = 3;
            this.btnAnonymous.Text = "Anonymous";
            this.btnAnonymous.UseVisualStyleBackColor = true;
            this.btnAnonymous.Click += new System.EventHandler(this.btnAnonymous_Click);
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(22, 26);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(193, 21);
            this.userID.TabIndex = 6;
            this.userID.TextChanged += new System.EventHandler(this.userID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 7;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 122);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 12);
            this.label.TabIndex = 8;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 168);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.btnAnonymous);
            this.Controls.Add(this.btnNomal);
            this.Name = "login";
            this.Text = "로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNomal;
        private System.Windows.Forms.Button btnAnonymous;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
    }
}

