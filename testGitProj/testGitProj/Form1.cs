using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testGitProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form load..");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //test class 생성
            new Form2(this).Show();
            this.Hide();
        }
    }
}
