namespace WindowsFormsApp1
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.user_btn = new System.Windows.Forms.Button();
            this.admin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬돋움 확장", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(84, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "출퇴근 관리 프로그램";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_btn
            // 
            this.user_btn.BackColor = System.Drawing.SystemColors.Window;
            this.user_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_btn.Font = new System.Drawing.Font("함초롬돋움 확장", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_btn.ForeColor = System.Drawing.Color.Teal;
            this.user_btn.Location = new System.Drawing.Point(81, 344);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(200, 110);
            this.user_btn.TabIndex = 5;
            this.user_btn.Text = "사원";
            this.user_btn.UseVisualStyleBackColor = false;
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.SystemColors.Window;
            this.admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_btn.Font = new System.Drawing.Font("함초롬돋움 확장", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.admin_btn.ForeColor = System.Drawing.Color.Teal;
            this.admin_btn.Location = new System.Drawing.Point(387, 344);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(200, 110);
            this.admin_btn.TabIndex = 6;
            this.admin_btn.Text = "관리자";
            this.admin_btn.UseVisualStyleBackColor = false;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 580);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Home";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button user_btn;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Label label1;
    }
}