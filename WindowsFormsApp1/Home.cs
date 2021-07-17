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
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Admin();
            form.Show();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new User();
            form.Show();
        }
    }
}
