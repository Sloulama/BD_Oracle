using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kkkk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login_click

            this.Hide();
            Form1 main = new Form1();
            main.Show();
             


        }
    }
}
