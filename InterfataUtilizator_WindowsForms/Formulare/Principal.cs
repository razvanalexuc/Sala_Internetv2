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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }



        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadform(new HomeForm());
        }

        private void btnPersoana_Click(object sender, EventArgs e)
        {
            loadform(new UserForm());
        }

        private void btnComponente_Click(object sender, EventArgs e)
        {
            loadform(new ComponenteForm());
        }

        private void btnPeriferice_Click(object sender, EventArgs e)
        {
            loadform(new PerifericeForm());
        }

        private void btnConfigurare_Click(object sender, EventArgs e)
        {
            loadform(new ConfigurareForm());
        }

        private void labelData_Click(object sender, EventArgs e)
        {

        }

        private void labelTimp_Click(object sender, EventArgs e)
        {

        }

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimp.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        */
    }
}
