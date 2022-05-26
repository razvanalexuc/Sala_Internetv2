using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase;
using Administrare_Fisier;
using System.Collections;
using System.IO;
using System.Configuration;


namespace InterfataUtilizator_WindowsForms.Formulare
{

    public partial class PerifericeForm : Form
    {

        public PerifericeForm()
        {
          
            InitializeComponent();
        }

        private void labeltitluperif_Click(object sender, EventArgs e)
        {

        }

        private void labelidperif_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIdPerif_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMonitor_Click(object sender, EventArgs e)
        {

        }

        private void labelMouse_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMouse_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMonitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {

            string Fisier_Periferice = ConfigurationManager.AppSettings["Periferice"];
            string locatiefisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier1 = locatiefisierSolutie1 + "\\" + Fisier_Periferice;
            AdministrarePeriferice_FisierText administrarePeriferice = new AdministrarePeriferice_FisierText(caleCompletaFisier1);
            Periferice perifericnew = new Periferice();
            int nrPerif = 0;
            administrarePeriferice.GetPeriferice(out nrPerif);

            if(dataValide() == true)
            {
                perifericnew.IdSetPerif = Convert.ToInt32(textBoxIdPerif.Text);
                perifericnew.Monitor = textBoxMonitor.Text;
                perifericnew.Mouse = textBoxMouse.Text;
                perifericnew.Tastatura = textBoxTastatura.Text;
                perifericnew.Casti = textBoxCasti.Text;
                administrarePeriferice.AddPeriferice(perifericnew);

                labelidperif.BackColor = Color.WhiteSmoke;
                labelMonitor.BackColor = Color.WhiteSmoke;
                labelMouse.BackColor = Color.WhiteSmoke;
                labelTastatura.BackColor = Color.WhiteSmoke;
                labelCasti.BackColor = Color.WhiteSmoke;

                labelStatus.Text = "Setul de periferice a fost adaugat cu succes!";
            }
            else 
            {
                labelStatus.Text = "Setul de periferice a esuat la adaugare!";
            }
            buttonAdauga.Visible = true;
            FreeData();
        }

        private void FreeData()
        {
            textBoxIdPerif.Text = string.Empty;
            textBoxMonitor.Text = string.Empty;
            textBoxMouse.Text = string.Empty;
            textBoxTastatura.Text = string.Empty;
            textBoxCasti.Text = string.Empty;


        }

        private void afisarePeriferice()
        {

            string Fisier_Periferice = ConfigurationManager.AppSettings["Periferice"];
            string locatiefisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier1 = locatiefisierSolutie1 + "\\" + Fisier_Periferice;
            AdministrarePeriferice_FisierText administrarePeriferice = new AdministrarePeriferice_FisierText(caleCompletaFisier1);

            ArrayList periferice = administrarePeriferice.GetPeriferice();
            listBoxPeriferice.Items.Clear();
            foreach(Periferice perif in periferice)
            {
                listBoxPeriferice.Items.Add(((Periferice)perif).ConversieLaSir_PentruAfisare());
            }
        }

		private bool dataValide()
		{

			bool isInt = Int32.TryParse(textBoxMonitor.Text, out int result);
			if (!isInt && textBoxMonitor.Text != string.Empty)
			{
                labelMonitor.BackColor = Color.Green;
			}
			else
			{
                labelMonitor.BackColor = Color.Red;
				return false;
			}

            isInt = Int32.TryParse(textBoxIdPerif.Text, out result);
			if (isInt && textBoxIdPerif.Text != string.Empty)
			{
                labelidperif.BackColor = Color.Green;
			}
			else
			{
                labelidperif.BackColor = Color.Red;
				return false;
			}

			isInt = Int32.TryParse(textBoxMouse.Text, out result);
			if (!isInt && textBoxMouse.Text != string.Empty)
			{
				labelMouse.BackColor = Color.Green;
			}
			else
			{
				labelMouse.BackColor = Color.Red;
				return false;
			}

            isInt = Int32.TryParse(textBoxTastatura.Text, out result);
            if (!isInt && textBoxTastatura.Text != string.Empty)
            {
                labelTastatura.BackColor = Color.Green;
            }
            else
            {
                labelTastatura.BackColor = Color.Red;
                return false;
            }

            isInt = Int32.TryParse(textBoxCasti.Text, out result);
            if (!isInt && textBoxCasti.Text != string.Empty)
            {
                labelCasti.BackColor = Color.Green;
            }
            else
            {
                labelCasti.BackColor = Color.Red;
                return false;
            }

            return true;
		}

        private void textBoxTastatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTastatura_Click(object sender, EventArgs e)
        {

        }

        private void labelCasti_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCasti_TextChanged(object sender, EventArgs e)
        {

        }

        private void PerifericeForm_Load(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            afisarePeriferice();
            FreeData();
        }

        private void listBoxPeriferice_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Fisier_Periferice = ConfigurationManager.AppSettings["Periferice"];
            string locatiefisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier1 = locatiefisierSolutie1 + "\\" + Fisier_Periferice;
            AdministrarePeriferice_FisierText administrarePeriferice = new AdministrarePeriferice_FisierText(caleCompletaFisier1);

            if (listBoxPeriferice.SelectedIndex != -1)
            {
                buttonAdauga.Visible = true;
                buttonEditare.Visible = true;
                buttonStergere.Visible = true;

                ArrayList perifericele = administrarePeriferice.GetPeriferice();
                Periferice perifericSelectat = (Periferice)perifericele[listBoxPeriferice.SelectedIndex];

                textBoxIdPerif.Text = Convert.ToString(perifericSelectat.IdSetPerif);
                textBoxMonitor.Text = perifericSelectat.Monitor;
                textBoxMouse.Text = perifericSelectat.Mouse;
                textBoxTastatura.Text = perifericSelectat.Tastatura;
                textBoxCasti.Text = perifericSelectat.Casti;

            }
        }

        private void buttonEditare_Click(object sender, EventArgs e)
        {
            string Fisier_Periferice = ConfigurationManager.AppSettings["Periferice"];
            string locatiefisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier1 = locatiefisierSolutie1 + "\\" + Fisier_Periferice;
            AdministrarePeriferice_FisierText administrarePeriferice = new AdministrarePeriferice_FisierText(caleCompletaFisier1);

            buttonStergere.Visible = true;
            buttonCauta.Visible = true;
            buttonAdauga.Visible = true;

            int index = listBoxPeriferice.SelectedIndex;
            if (listBoxPeriferice.SelectedIndex != -1)
            {
                ArrayList periferice = administrarePeriferice.GetPeriferice();
                foreach (Periferice perifericEditat in periferice)
                {
                    if (dataValide() == true && periferice[index] == perifericEditat)
                    {
                        perifericEditat.IdSetPerif = Convert.ToInt32(textBoxIdPerif.Text);
                        perifericEditat.Monitor = textBoxMonitor.Text;
                        perifericEditat.Mouse = textBoxMouse.Text;
                        perifericEditat.Tastatura = textBoxTastatura.Text;
                        perifericEditat.Casti = textBoxCasti.Text;


                        administrarePeriferice.EditarePeriferic(index, perifericEditat);

                        labelStatus.Text = "Setul de periferice a fost editat cu succes!";
                        continue;
                    }
                    else
                    {
                        labelStatus.Text = "Setul de periferice a fost editat cu succes!";
                        continue;
                    }
                }
            }
            buttonEditare.Visible = true;
            FreeData();
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {

            string Fisier_Periferice = ConfigurationManager.AppSettings["Periferice"];
            string locatiefisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier1 = locatiefisierSolutie1 + "\\" + Fisier_Periferice;
            AdministrarePeriferice_FisierText administrarePeriferice = new AdministrarePeriferice_FisierText(caleCompletaFisier1);

            buttonEditare.Visible = true;
            buttonStergere.Visible = true;
            buttonAdauga.Visible = true;

            bool isInt = Int32.TryParse(textBoxIdPerif.Text, out int result);
            if (isInt && textBoxIdPerif.Text != string.Empty)
            {

                Periferice setperifCautat = administrarePeriferice.GetPeriferic(Convert.ToInt32(textBoxIdPerif.Text));
                if (setperifCautat != null)
                {
                    listBoxPeriferice.Items.Clear();
                    listBoxPeriferice.Items.Add(setperifCautat.ConversieLaSir_PentruAfisare());
                    labelStatus.Text = "Setul de periferice căutat a fost găsit cu succes!";
                }
                else
                {
                    labelStatus.Text = "Setul de periferice căutat nu există!";
                }

            }
            else
            {
                labelidperif.BackColor = Color.Red;
            }
            buttonAdauga.Visible = true;
            FreeData();

        }

        private void buttonStergere_Click(object sender, EventArgs e)
        {

            string Fisier_Periferice = ConfigurationManager.AppSettings["Periferice"];
            string locatiefisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier1 = locatiefisierSolutie1 + "\\" + Fisier_Periferice;
            AdministrarePeriferice_FisierText administrarePeriferice = new AdministrarePeriferice_FisierText(caleCompletaFisier1);

            buttonEditare.Visible = true;
            buttonCauta.Visible = true;
            buttonAdauga.Visible = true;

            int index = listBoxPeriferice.SelectedIndex;
            if (listBoxPeriferice.SelectedIndex != -1)
            {
                FreeData();
                DialogResult res = MessageBox.Show("Sunteți sigur că doriți să ștergeți setul de periferice selectat?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    if (administrarePeriferice.StergerePeriferic(index) == true)
                    {
                        labelStatus.Text = "Setul de periferice a fost șters cu succes!";
                        afisarePeriferice();
                    }
                }
                else
                {
                    labelStatus.Text = "Setul de periferice nu a fost șters cu succes!";
                }
            }
            buttonStergere.Visible = true;
            FreeData();

        }
    }
}
