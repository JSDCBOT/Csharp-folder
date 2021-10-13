using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1button2actions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }
        static bool isActive = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (isActive == true) { pictureBox1.Visible = false; pictureBox2.Visible = true; isActive = false; } else { pictureBox1.Visible = true; pictureBox2.Visible = false; isActive = true; }
            //if (isActive == true) { *ACTION* isActive = false; } else { *ACTION* isActive = true; }
        }
    }
}
