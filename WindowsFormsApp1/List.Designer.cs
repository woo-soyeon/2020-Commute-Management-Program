namespace WindowsFormsApp1
{
    partial class List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.showall_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.num_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Honeydew;
            this.monthCalendar1.Font = new System.Drawing.Font("함초롬돋움 확장", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.Teal;
            this.monthCalendar1.Location = new System.Drawing.Point(28, 78);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.LightCoral;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // showall_btn
            // 
            this.showall_btn.BackColor = System.Drawing.SystemColors.Window;
            this.showall_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showall_btn.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Bold);
            this.showall_btn.ForeColor = System.Drawing.Color.Teal;
            this.showall_btn.Location = new System.Drawing.Point(550, 136);
            this.showall_btn.Name = "showall_btn";
            this.showall_btn.Size = new System.Drawing.Size(100, 50);
            this.showall_btn.TabIndex = 3;
            this.showall_btn.Text = "전체 보기";
            this.showall_btn.UseVisualStyleBackColor = false;
            this.showall_btn.Click += new System.EventHandler(this.showall_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.Window;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Bold);
            this.search_btn.ForeColor = System.Drawing.Color.Teal;
            this.search_btn.Location = new System.Drawing.Point(550, 207);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(100, 50);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.Controls.Add(this.num_txt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.name_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.date_txt, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("함초롬돋움 확장", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(278, 123);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(247, 146);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // num_txt
            // 
            this.num_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_txt.Font = new System.Drawing.Font("함초롬돋움 확장", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num_txt.Location = new System.Drawing.Point(93, 99);
            this.num_txt.Name = "num_txt";
            this.num_txt.Size = new System.Drawing.Size(152, 37);
            this.num_txt.TabIndex = 5;
            // 
            // name_txt
            // 
            this.name_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_txt.Font = new System.Drawing.Font("함초롬돋움 확장", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_txt.Location = new System.Drawing.Point(93, 51);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(152, 37);
            this.name_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "날짜";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "사원번호";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // date_txt
            // 
            this.date_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_txt.Font = new System.Drawing.Font("함초롬돋움 확장", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date_txt.Location = new System.Drawing.Point(93, 3);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(152, 37);
            this.date_txt.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(28, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(621, 257);
            this.dataGridView1.TabIndex = 2;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.Window;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Bold);
            this.back_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(598, 63);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(51, 30);
            this.back_btn.TabIndex = 3;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 580);
            this.Controls.Add(this.showall_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "List";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox num_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button showall_btn;
    }
}