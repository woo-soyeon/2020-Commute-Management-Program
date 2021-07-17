using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SQLite;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class List : MetroForm
    {
        public List()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Admin();
            form.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar1.SelectionRange.Start == monthCalendar1.SelectionRange.End)
                date_txt.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            // DB파일 이름
            string Dbfilename = "work_list.db";

            // DB지정할 경로
            string Dbfilepath = Path.GetDirectoryName(Application.ExecutablePath);

            // DB 정보
            string Dbfile = String.Format(@"{0}\{1}", Dbfilepath, Dbfilename);

            if (!System.IO.File.Exists(Dbfile))
            {
                SQLiteConnection.CreateFile(Dbfile);
            }
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + Dbfile))
            {
                conn.Open();

                string name_data = name_txt.Text;
                string num_data = num_txt.Text;
                string strsql = "SELECT * FROM work_list where 날짜 = '" + this.date_txt.Text + "' OR 이름  = '" + this.name_txt.Text + "' OR 사원번호 = '" + this.num_txt.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(strsql, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void RefreshDataGridView()
        {
            // DB파일 이름
            string Dbfilename = "work_list.db";

            // DB지정할 경로
            string Dbfilepath = Path.GetDirectoryName(Application.ExecutablePath);

            // DB 정보
            string Dbfile = String.Format(@"{0}\{1}", Dbfilepath, Dbfilename);

            if (!System.IO.File.Exists(Dbfile))
            {
                SQLiteConnection.CreateFile(Dbfile);
            }

            // datagridview
            SQLiteConnection myconn = new SQLiteConnection("Data Source=" + Dbfile);
            myconn.Open();

            SQLiteCommand mycmd = new SQLiteCommand();
            mycmd.Connection = myconn;
            mycmd.CommandText = "select * from work_list";

            using (SQLiteDataReader sdr = mycmd.ExecuteReader())
            {
                DataTable dt = new DataTable();

                dt.Load(sdr);
                sdr.Close();
                myconn.Close();
                dataGridView1.DataSource = dt;
            }
        }

        private void showall_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
