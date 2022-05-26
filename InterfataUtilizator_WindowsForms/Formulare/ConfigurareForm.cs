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
    public partial class ConfigurareForm : Form
    {
        public ConfigurareForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string id = "ID-ul configurarii este: " + textBoxConfigurare.Text+", iar seturile selectate sunt " + textBoxComponente.Text + " si " + textBoxPeriferice.Text + ".";
            listBoxConfigurare.Items.Add(id);
          
        }

        private void textBoxConfigurare_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxComponente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPeriferice_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxConfigurare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
