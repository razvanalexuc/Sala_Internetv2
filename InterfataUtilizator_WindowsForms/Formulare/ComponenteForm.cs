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
    public partial class ComponenteForm : Form
    {
        public ComponenteForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            string Fisier_Componente = ConfigurationManager.AppSettings["Componente"];
            string locatiefisierSolutie2 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier2 = locatiefisierSolutie2 + "\\" + Fisier_Componente;
            AdministrareComponente_FisierText administrareComponente = new AdministrareComponente_FisierText(caleCompletaFisier2);
            int nrComp = 0;
            Componente componentanew = new Componente();
            administrareComponente.GetComponente(out nrComp);

            if (dataValide() == true)
            {
                componentanew.IdSetComp = Convert.ToInt32(textBoxIdSetComp.Text);
                componentanew.Mobo = textBoxMOBO.Text;
                componentanew.Ram = Convert.ToInt32(textBoxRAM.Text);
                componentanew.Cpu = textBoxCPU.Text;
                componentanew.Gpu = textBoxGPU.Text;
                componentanew.Cooler = textBoxCooler.Text;
                componentanew.Hdd = textBoxHDD.Text;
                componentanew.Ssd = textBoxSSD.Text;
                administrareComponente.AddComponente(componentanew);

                labelSetComp.BackColor = Color.WhiteSmoke;
                labelMOBO.BackColor = Color.WhiteSmoke;
                labelRam.BackColor = Color.WhiteSmoke;
                labelCPU.BackColor = Color.WhiteSmoke;
                labelGPU.BackColor = Color.WhiteSmoke;
                labelCooler.BackColor = Color.WhiteSmoke;
                labelHDD.BackColor = Color.WhiteSmoke;
                labelSSD.BackColor = Color.WhiteSmoke;

                labelStatus.Text = "Setul de componente a fost adaugat cu succes!";
            }
            else
            {
                labelStatus.Text = "Setul de componente a esuat la adaugare!";
            }
            buttonAdauga.Visible = true;
            FreeData();
        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            afisareComponente();
            FreeData();
        }

        private void textBoxIdSetComp_TextChanged(object sender, EventArgs e)
        {

        }

        private void FreeData()
        {
            textBoxIdSetComp.Text = string.Empty;
            textBoxMOBO.Text = string.Empty;
            textBoxRAM.Text = string.Empty;
            textBoxCPU.Text = string.Empty;
            textBoxGPU.Text = string.Empty;
            textBoxCooler.Text = string.Empty;
            textBoxHDD.Text = string.Empty;
            textBoxSSD.Text = string.Empty;
        }

        private void textBoxMOBO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRAM_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCPU_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGPU_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCooler_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHDD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSetComp_Click(object sender, EventArgs e)
        {

        }

        private void labelMOBO_Click(object sender, EventArgs e)
        {

        }

        private void labelRam_Click(object sender, EventArgs e)
        {

        }

        private void labelCPU_Click(object sender, EventArgs e)
        {

        }

        private void labelGPU_Click(object sender, EventArgs e)
        {

        }

        private void labelCooler_Click(object sender, EventArgs e)
        {

        }

        private void ComponenteForm_Load(object sender, EventArgs e)
        {

        }

        private void labelHDD_Click(object sender, EventArgs e)
        {

        }

        private void labelSSD_Click(object sender, EventArgs e)
        {

        }

        private bool dataValide()
        {

            bool isInt = Int32.TryParse(textBoxMOBO.Text, out int result);
            if (!isInt && textBoxMOBO.Text != string.Empty)
            {
                labelMOBO.BackColor = Color.Green;
            }
            else
            {
                labelMOBO.BackColor = Color.Red;
                return false;
            }

            isInt = Int32.TryParse(textBoxIdSetComp.Text, out result);
            if (isInt && textBoxIdSetComp.Text != string.Empty)
            {
                labelSetComp.BackColor = Color.Green;
            }
            else
            {
                labelSetComp.BackColor = Color.Red;
                return false;
            }

            isInt = Int32.TryParse(textBoxRAM.Text, out result);
            if (isInt && textBoxRAM.Text != string.Empty)
            {
                labelRam.BackColor = Color.Green;
            }
            else
            {
                labelRam.BackColor = Color.Red;
                return false;
            }

            isInt = Int32.TryParse(textBoxCPU.Text, out result);
            if (!isInt && textBoxCPU.Text != string.Empty)
            {
                labelCPU.BackColor = Color.Green;
            }
            else
            {
                labelCPU.BackColor = Color.Red;
                return false;
            }

            isInt = Int32.TryParse(textBoxGPU.Text, out result);
            if (!isInt && textBoxGPU.Text != string.Empty)
            {
                labelGPU.BackColor = Color.Green;
            }
            else
            {
                labelGPU.BackColor = Color.Red;
                return false;
            }

            isInt = Int32.TryParse(textBoxCooler.Text, out result);
            if (!isInt && textBoxCooler.Text != string.Empty)
            {
                labelCooler.BackColor = Color.Green;
            }
            else
            {
                labelCooler.BackColor = Color.Red;
                return false;
            }

            isInt = Int32.TryParse(textBoxHDD.Text, out result);
            if (!isInt && textBoxHDD.Text != string.Empty)
            {
                labelHDD.BackColor = Color.Green;
            }
            else
            {
                labelHDD.BackColor = Color.Red;
                return false;
            }

            isInt = Int32.TryParse(textBoxSSD.Text, out result);
            if (!isInt && textBoxHDD.Text != string.Empty)
            {
                labelSSD.BackColor = Color.Green;
            }
            else
            {
                labelSSD.BackColor = Color.Red;
                return false;
            }

            return true;
        }

        private void afisareComponente()
        {
            string Fisier_Componente = ConfigurationManager.AppSettings["Componente"];
            string locatiefisierSolutie2 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier2 = locatiefisierSolutie2 + "\\" + Fisier_Componente;
            AdministrareComponente_FisierText administrareComponente = new AdministrareComponente_FisierText(caleCompletaFisier2);

            ArrayList componente = administrareComponente.GetComponente();

            listBoxComponente.Items.Clear();
            foreach (Componente c in componente)
            {
                listBoxComponente.Items.Add(((Componente)c).ConversieLaSir_PentruAfisare());
            }
        }

        private void buttonStergere_Click(object sender, EventArgs e)
        {
            
            buttonAdauga.Visible = true;

            string Fisier_Componente = ConfigurationManager.AppSettings["Componente"];
            string locatiefisierSolutie2 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier2 = locatiefisierSolutie2 + "\\" + Fisier_Componente;
            AdministrareComponente_FisierText administrareComponente = new AdministrareComponente_FisierText(caleCompletaFisier2);

            int index = listBoxComponente.SelectedIndex;
            if (listBoxComponente.SelectedIndex != -1)
            {
                FreeData();
                DialogResult res = MessageBox.Show("Sunteți sigur că doriți să ștergeți setul de componente selectat?", "Confirmare", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    if (administrareComponente.StergereComponenta(index) == true)
                    {
                        labelStatus.Text = "Setul de componente a fost șters cu succes!";
                        afisareComponente();

                    }
                }
                else
                {
                    labelStatus.Text = "Setul de componente nu a fost șters cu succes!";
                }
            }
            buttonStergere.Visible = true;
            FreeData();
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            string Fisier_Componente = ConfigurationManager.AppSettings["Componente"];
            string locatiefisierSolutie2 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier2 = locatiefisierSolutie2 + "\\" + Fisier_Componente;
            AdministrareComponente_FisierText administrareComponente = new AdministrareComponente_FisierText(caleCompletaFisier2);

            buttonStergere.Visible = true;
            buttonAdauga.Visible = true;

            bool isInt = Int32.TryParse(textBoxIdSetComp.Text, out int result);
            if (isInt && textBoxIdSetComp.Text != string.Empty)
            {

                Componente setcompCautat = administrareComponente.GetComponent(Convert.ToInt32(textBoxIdSetComp.Text));
                if (setcompCautat != null)
                {
                    listBoxComponente.Items.Clear();
                    listBoxComponente.Items.Add(setcompCautat.ConversieLaSir_PentruAfisare());
                    labelStatus.Text = "Setul de periferice căutat a fost găsit cu succes!";
                }
                else
                {
                    labelStatus.Text = "Setul de periferice căutat nu există!";
                }

            }
            else
            {
                labelSetComp.BackColor = Color.Red;
            }
            buttonAdauga.Visible = true;
            FreeData();

        }

        private void buttonEditare_Click(object sender, EventArgs e)
        {
            string Fisier_Componente = ConfigurationManager.AppSettings["Componente"];
            string locatiefisierSolutie2 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier2 = locatiefisierSolutie2 + "\\" + Fisier_Componente;
            AdministrareComponente_FisierText administrareComponente = new AdministrareComponente_FisierText(caleCompletaFisier2);
            buttonStergere.Visible = true;
            buttonCauta.Visible = true;
            buttonAdauga.Visible = true;

            int index = listBoxComponente.SelectedIndex;
            if (listBoxComponente.SelectedIndex != -1)
            {
                ArrayList componente = administrareComponente.GetComponente();
                foreach (Componente componentaEditata in componente)
                {
                    if (dataValide() == true && componente[index] == componentaEditata)
                    {
                        componentaEditata.IdSetComp = Convert.ToInt32(textBoxIdSetComp.Text);
                        componentaEditata.Mobo = textBoxMOBO.Text;
                        componentaEditata.Ram = Convert.ToInt32(textBoxRAM.Text);
                        componentaEditata.Cpu = textBoxCPU.Text;
                        componentaEditata.Gpu = textBoxGPU.Text;
                        componentaEditata.Cooler = textBoxCooler.Text;
                        componentaEditata.Hdd = textBoxHDD.Text;
                        componentaEditata.Ssd = textBoxSSD.Text;



                        administrareComponente.EditareComponenta(index, componentaEditata);

                        labelStatus.Text = "Setul de periferice a fost editat cu succes!";
                        continue;
                    }
                    else
                    {
                        labelStatus.Text = "Setul de periferice nu a fost editat cu succes!";
                        continue;
                    }
                }
            }
            buttonEditare.Visible = true;
            FreeData();

        }

        private void listBoxComponente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Fisier_Componente = ConfigurationManager.AppSettings["Componente"];
            string locatiefisierSolutie2 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier2 = locatiefisierSolutie2 + "\\" + Fisier_Componente;
            AdministrareComponente_FisierText administrareComponente = new AdministrareComponente_FisierText(caleCompletaFisier2);

            if (listBoxComponente.SelectedIndex != -1)
            {
                buttonAdauga.Visible = true;
                buttonEditare.Visible = true;
                buttonStergere.Visible = true;

                ArrayList componentele = administrareComponente.GetComponente();
                Componente componentaSelectata = (Componente)componentele[listBoxComponente.SelectedIndex];

                textBoxIdSetComp.Text = Convert.ToString(componentaSelectata.IdSetComp);
                textBoxMOBO.Text = componentaSelectata.Mobo;
                textBoxRAM.Text = Convert.ToString(componentaSelectata.Ram);
                textBoxCPU.Text = componentaSelectata.Cpu;
                textBoxGPU.Text = componentaSelectata.Gpu;
                textBoxCooler.Text = componentaSelectata.Cooler;
                textBoxHDD.Text = componentaSelectata.Hdd;
                textBoxSSD.Text = componentaSelectata.Ssd;

            }
        }
    }
}
