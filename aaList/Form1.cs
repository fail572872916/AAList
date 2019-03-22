using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aaList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //22222222222222
        int n = 1;
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            n = n + 1;
            int count = 15 * n;
            for (int i = 1 + 15 * (n - 1); i <= count; i++)
            {
                MyControl mcl = new MyControl();
                mcl.groupBox1.Text = i.ToString();
                mcl.DataLoad(i);
                this.flowLayoutPanel1.Controls.Add(mcl);
            }
        }
    }
}
