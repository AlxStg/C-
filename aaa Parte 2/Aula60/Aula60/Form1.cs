using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            lb_Main.Text = tb_Main.Text;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            lb_Main.Text = "SANTIAGO CULTURAS SUSTENTÁVEIS";
        }
    }
}
