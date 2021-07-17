namespace WindowsFormsApp1
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.enroll_page = new System.Windows.Forms.Button();
            this.list_page = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enroll_page
            // 
            this.enroll_page.BackColor = System.Drawing.SystemColors.Window;
            this.enroll_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enroll_page.Font = new System.Drawing.Font("함초롬돋움 확장", 18F, System.Drawing.FontStyle.Bold);
            this.enroll_page.ForeColor = System.Drawing.Color.Teal;
            this.enroll_page.Location = new System.Drawing.Point(81, 344);
            this.enroll_page.Name = "enroll_page";
            this.enroll_page.Size = new System.Drawing.Size(200, 110);
            this.enroll_page.TabIndex = 1;
            this.enroll_page.Text = "회원 등록";
            this.enroll_page.UseVisualStyleBackColor = false;
            this.enroll_page.Click += new System.EventHandler(this.enroll_page_Click);
            // 
            // list_page
            // 
            this.list_page.BackColor = System.Drawing.SystemColors.Window;
            this.list_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list_page.Font = new System.Drawing.Font("함초롬돋움 확장", 18F, System.Drawing.FontStyle.Bold);
            this.list_page.ForeColor = System.Drawing.Color.Teal;
            this.list_page.Location = new System.Drawing.Point(387, 344);
            this.list_page.Name = "list_page";
            this.list_page.Size = new System.Drawing.Size(200, 110);
            this.list_page.TabIndex = 3;
            this.list_page.Text = "출퇴근 현황";
            this.list_page.UseVisualStyleBackColor = false;
            this.list_page.Click += new System.EventHandler(this.list_page_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.SystemColors.Window;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Bold);
            this.home_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.Location = new System.Drawing.Point(598, 77);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(47, 48);
            this.home_btn.TabIndex = 4;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬돋움 확장", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(84, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 78);
            this.label1.TabIndex = 5;
            this.label1.Text = "출퇴근 관리 프로그램";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.list_page);
            this.Controls.Add(this.enroll_page);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enroll_page;
        private System.Windows.Forms.Button list_page;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Label label1;
    }
}