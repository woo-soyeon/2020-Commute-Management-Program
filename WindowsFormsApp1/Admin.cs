using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : MetroForm
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void enroll_page_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Enroll();
            form.Show();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Home();
            form.Show();
        }

        private void list_page_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new List();
            form.Show();
        }
    }
}
