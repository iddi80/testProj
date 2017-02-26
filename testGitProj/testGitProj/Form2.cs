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
    public partial class Form2 : Form
    {
        Form pForm;
        public Form2(Form _p)
        {
            pForm = _p;
            InitializeComponent();
        }


        protected override void OnClosed(EventArgs e)
        {
            pForm.Show();
            base.OnClosed(e);            
        }
    }
}
