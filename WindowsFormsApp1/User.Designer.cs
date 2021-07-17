namespace WindowsFormsApp1
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.num_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.gotowork_btn = new System.Windows.Forms.Button();
            this.leavingwork_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.home_btn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.Controls.Add(this.num_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.name_txt, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("함초롬돋움 확장", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(95, 237);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 128);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // num_txt
            // 
            this.num_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_txt.Font = new System.Drawing.Font("함초롬돋움", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num_txt.Location = new System.Drawing.Point(173, 67);
            this.num_txt.Name = "num_txt";
            this.num_txt.Size = new System.Drawing.Size(241, 37);
            this.num_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "사원번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // name_txt
            // 
            this.name_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_txt.Font = new System.Drawing.Font("함초롬돋움", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_txt.Location = new System.Drawing.Point(173, 3);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(241, 37);
            this.name_txt.TabIndex = 4;
            // 
            // gotowork_btn
            // 
            this.gotowork_btn.BackColor = System.Drawing.SystemColors.Window;
            this.gotowork_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gotowork_btn.Font = new System.Drawing.Font("함초롬돋움 확장", 18F, System.Drawing.FontStyle.Bold);
            this.gotowork_btn.ForeColor = System.Drawing.Color.Teal;
            this.gotowork_btn.Location = new System.Drawing.Point(69, 386);
            this.gotowork_btn.Name = "gotowork_btn";
            this.gotowork_btn.Size = new System.Drawing.Size(200, 110);
            this.gotowork_btn.TabIndex = 4;
            this.gotowork_btn.Text = "출근";
            this.gotowork_btn.UseVisualStyleBackColor = false;
            this.gotowork_btn.Click += new System.EventHandler(this.gotowork_btn_Click);
            // 
            // leavingwork_btn
            // 
            this.leavingwork_btn.BackColor = System.Drawing.SystemColors.Window;
            this.leavingwork_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leavingwork_btn.Font = new System.Drawing.Font("함초롬돋움 확장", 18F, System.Drawing.FontStyle.Bold);
            this.leavingwork_btn.ForeColor = System.Drawing.Color.Teal;
            this.leavingwork_btn.Location = new System.Drawing.Point(383, 386);
            this.leavingwork_btn.Name = "leavingwork_btn";
            this.leavingwork_btn.Size = new System.Drawing.Size(200, 110);
            this.leavingwork_btn.TabIndex = 5;
            this.leavingwork_btn.Text = "퇴근";
            this.leavingwork_btn.UseVisualStyleBackColor = false;
            this.leavingwork_btn.Click += new System.EventHandler(this.leavingwork_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.SystemColors.Window;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.home_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.Location = new System.Drawing.Point(598, 77);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(47, 48);
            this.home_btn.TabIndex = 6;
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("함초롬돋움 확장", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date.ForeColor = System.Drawing.Color.Teal;
            this.date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.date.Location = new System.Drawing.Point(288, 108);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(75, 36);
            this.date.TabIndex = 7;
            this.date.Text = "date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("함초롬돋움 확장", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.time.ForeColor = System.Drawing.Color.Teal;
            this.time.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time.Location = new System.Drawing.Point(331, 157);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(73, 36);
            this.time.TabIndex = 8;
            this.time.Text = "time";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("함초롬돋움 확장", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(223, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "날짜 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("함초롬돋움 확장", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(223, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "현재시간 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(680, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.leavingwork_btn);
            this.Controls.Add(this.gotowork_btn);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "User";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox num_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button gotowork_btn;
        private System.Windows.Forms.Button leavingwork_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}