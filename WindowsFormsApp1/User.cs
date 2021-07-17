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
    public partial class User : MetroForm
    {
        public User()
        {
            InitializeComponent();

            timer1.Start();
            date.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Home();
            form.Show();
        }

        private void gotowork_btn_Click(object sender, EventArgs e)
        {
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

                string name_data = name_txt.Text;
                string num_data = num_txt.Text;
                string strsql = "SELECT * FROM mem where num = '" + this.num_txt.Text + "' AND name  = '" + this.name_txt.Text + "' ;";
                SQLiteCommand cmd = new SQLiteCommand(strsql, conn);
                cmd.ExecuteNonQuery();

                SQLiteDataAdapter da = new SQLiteDataAdapter(strsql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    string Dbfilename_1 = "work_list.db";

                    // DB지정할 경로
                    string Dbfilepath_1 = Path.GetDirectoryName(Application.ExecutablePath);

                    // DB 정보
                    string Dbfile_1 = String.Format(@"{0}\{1}", Dbfilepath_1, Dbfilename_1);

                    if (!System.IO.File.Exists(Dbfile_1))
                    {
                        SQLiteConnection.CreateFile(Dbfile_1);
                    }
                    using (SQLiteConnection conn_1 = new SQLiteConnection("DataSource=" + Dbfile_1))
                    {
                        conn_1.Open();
                        string strsql_1 = "CREATE TABLE IF NOT EXISTS work_list (날짜 varchar(30),이름 varchar(20), 사원번호 varchar(20), 출근시간 varchar(30),퇴근시간 varchar(30))";
                        SQLiteCommand cmd_1 = new SQLiteCommand(strsql_1, conn_1);
                        cmd_1.ExecuteNonQuery();

                        string name_data_user = name_txt.Text;
                        string num_data_user = num_txt.Text;
                        string date_user = date.Text;
                        string time_user = time.Text;
                        string time_user_1 = time.Text;
                        string strsql2 = "INSERT INTO work_list Values" + "('" + date_user + "','" + name_data_user + "','" + num_data_user + "','" + time_user + "', null)";
                        cmd_1 = new SQLiteCommand(strsql2, conn_1);
                        cmd_1.ExecuteNonQuery();
                    }
               }
                else
                {
                    MessageBox.Show("이름 또는 사원번호를 확인하세요.");
                }
            }
        }
       
        private void leavingwork_btn_Click(object sender, EventArgs e)
        {
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

                string name_data = name_txt.Text;
                string num_data = num_txt.Text;
                string strsql = "SELECT * FROM mem where num = '" + this.num_txt.Text + "' AND name  = '" + this.name_txt.Text + "' ;";
                SQLiteCommand cmd = new SQLiteCommand(strsql, conn);
                cmd.ExecuteNonQuery();

                SQLiteDataAdapter da = new SQLiteDataAdapter(strsql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    string Dbfilename_1 = "work_list.db";

                    // DB지정할 경로
                    string Dbfilepath_1 = Path.GetDirectoryName(Application.ExecutablePath);

                    // DB 정보
                    string Dbfile_1 = String.Format(@"{0}\{1}", Dbfilepath_1, Dbfilename_1);

                    if (!System.IO.File.Exists(Dbfile_1))
                    {
                        SQLiteConnection.CreateFile(Dbfile_1);
                    }
                    using (SQLiteConnection conn_1 = new SQLiteConnection("DataSource=" + Dbfile_1))
                    {
                        conn_1.Open();
                        string strsql_1 = "CREATE TABLE IF NOT EXISTS work_list (날짜 varchar(30),이름 varchar(20), 사원번호 varchar(20), 출근시간 varchar(30),퇴근시간 varchar(30))";
                        SQLiteCommand cmd_1 = new SQLiteCommand(strsql_1, conn_1);
                        cmd_1.ExecuteNonQuery();

                        string name_data_user = name_txt.Text;
                        string num_data_user = num_txt.Text;
                        string date_user = date.Text;
                        string time_user = time.Text;
                        string time_user_1 = time.Text;
                        string strsql2 = "UPDATE work_list SET 퇴근시간 = '" + this.time.Text + "' WHERE 퇴근시간 is null";
                        cmd_1 = new SQLiteCommand(strsql2, conn_1);
                        cmd_1.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("이름 또는 사원번호를 확인하세요.");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = System.DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
