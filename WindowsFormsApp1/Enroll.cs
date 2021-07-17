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
    public partial class Enroll : MetroForm
    {
        public Enroll()
        {
            InitializeComponent();
        }
        private void enroll_btn_Click(object sender, EventArgs e)
        {
            // DB파일 이름
            string Dbfilename = "mem_info.db";

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
                string strsql = "CREATE TABLE IF NOT EXISTS mem (name varchar(20), num varchar(20))";
                SQLiteCommand cmd = new SQLiteCommand(strsql, conn);
                cmd.ExecuteNonQuery();

                string name_data = name_txt.Text;
                string num_data = num_txt.Text;
                string strsql2 = "INSERT INTO mem Values" + "('" + name_data + "'," + num_data + ")";
                cmd = new SQLiteCommand(strsql2, conn);
                cmd.ExecuteNonQuery();
            }

            RefreshDataGridView();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            // DB파일 이름
            string Dbfilename = "mem_info.db";

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
                string strsql = "CREATE TABLE IF NOT EXISTS mem (name varchar(20), num varchar(20))";
                SQLiteCommand cmd = new SQLiteCommand(strsql, conn);
                cmd.ExecuteNonQuery();

                string name_data = name_txt.Text;
                string num_data = num_txt.Text;
                string strsql2 = "DELETE FROM mem where num = '" + this.num_txt.Text + "' OR name  = '" + this.name_txt.Text + "' ;";
                cmd = new SQLiteCommand(strsql2, conn);
                cmd.ExecuteNonQuery();
            }

            RefreshDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            // DB파일 이름
            string Dbfilename = "mem_info.db";

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
            mycmd.CommandText = "select * from mem";

            using (SQLiteDataReader sdr = mycmd.ExecuteReader())
            {
                DataTable dt = new DataTable();

                dt.Load(sdr);
                sdr.Close();
                myconn.Close();
                dataGridView1.DataSource = dt;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Admin();
            form.Show();
        }
    }
}