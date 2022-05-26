using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms.Formulare
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void labelData_Click(object sender, EventArgs e)
        {

        }

        private void labelTimp_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToLongDateString();
            labelTimp.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimp.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
