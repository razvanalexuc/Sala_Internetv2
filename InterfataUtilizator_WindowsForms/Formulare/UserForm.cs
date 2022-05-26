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
    public partial class UserForm : Form
    {
        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;

        private Label lblInformatii;

        private Label lblId;
        private Label lblsId;
        private Label[] lbliId;
        private TextBox txtId;

        private Label lblNume;
        private Label lblsNume;
        private Label[] lbliNume;
        private TextBox txtNume;

        private Label lblPrenume;
        private Label lblsPrenume;
        private Label[] lbliPrenume;
        private TextBox txtPrenume;

        private Label lblnrOre;
        private Label lblsnrOre;
        private Label[] lblinrOre;
        private TextBox txtnrOre;

        private Label lblVarsta;
        private Label lblsVarsta;
        private Label[] lbliVarsta;
        private TextBox txtVarsta;



        int nrPers = 0;
        AdministrarePersoane_FisierText AdministrarePersoane;
        
        public UserForm()
        {
            string Fisier_Persoane = ConfigurationManager.AppSettings["Persoane"];
            string locatiefisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatiefisierSolutie + "\\" + Fisier_Persoane;
            AdministrarePersoane = new AdministrarePersoane_FisierText(caleCompletaFisier);
            AdministrarePersoane.GetPersoane(out nrPers);
            
            InitializeComponent();

            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.Text = "Persoane";

            lblInformatii = new Label();
            lblInformatii.Text = "Configurarea user-ului";
            this.Controls.Add(lblInformatii);
            lblInformatii.Width = 3 * LATIME_CONTROL;
            lblInformatii.Font = new Font("Arial", 10, FontStyle.Bold);
            lblInformatii.ForeColor = Color.Purple;
            lblInformatii.Left = 3 * DIMENSIUNE_PAS_X;

            lblId = new Label();
            lblId.Text = "ID";
            this.Controls.Add(lblId);
            lblId.ForeColor = Color.Blue;
            lblId.Left = DIMENSIUNE_PAS_X;
            lblId.Top = 2 * DIMENSIUNE_PAS_Y;

            lblNume = new Label();
            lblNume.Text = "Nume ";
            this.Controls.Add(lblNume);
            lblNume.ForeColor = Color.Blue;
            lblNume.Left = 2 * DIMENSIUNE_PAS_X;
            lblNume.Top = 2 * DIMENSIUNE_PAS_Y;

            lblPrenume = new Label();
            lblPrenume.Text = "Prenume ";
            this.Controls.Add(lblPrenume);
            lblPrenume.ForeColor = Color.Blue;
            lblPrenume.Left = 3 * DIMENSIUNE_PAS_X;
            lblPrenume.Top = 2 * DIMENSIUNE_PAS_Y;

            lblVarsta = new Label();
            lblVarsta.Text = "Varsta ";
            this.Controls.Add(lblVarsta);
            lblVarsta.ForeColor = Color.Blue;
            lblVarsta.Left = 4 * DIMENSIUNE_PAS_X;
            lblVarsta.Top = 2 * DIMENSIUNE_PAS_Y;

            lblnrOre = new Label();
            lblnrOre.Text = "Numar Ore ";
            this.Controls.Add(lblnrOre);
            lblnrOre.ForeColor = Color.Blue;
            lblnrOre.Left = 5 * DIMENSIUNE_PAS_X;
            lblnrOre.Top = 2 * DIMENSIUNE_PAS_Y;

            txtId = new TextBox();
            txtId.Width = LATIME_CONTROL;
            txtId.Left = DIMENSIUNE_PAS_X;
            txtId.Top = 13 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtId);

            lblsId = new Label();
            lblsId.Text = "ID";
            this.Controls.Add(lblsId);
            lblsId.ForeColor = Color.Blue;
            lblsId.Width = LATIME_CONTROL;
            lblsId.Left = DIMENSIUNE_PAS_X / 2;
            lblsId.Top = 13 * DIMENSIUNE_PAS_Y;

            txtNume = new TextBox();
            txtNume.Width = LATIME_CONTROL;
            txtNume.Left = DIMENSIUNE_PAS_X;
            txtNume.Top = 14 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtNume);

            lblsNume = new Label();
            lblsNume.Text = "Nume";
            this.Controls.Add(lblsNume);
            lblsNume.ForeColor = Color.Blue;
            lblsNume.Width = LATIME_CONTROL;
            lblsNume.Left = DIMENSIUNE_PAS_X / 2;
            lblsNume.Top = 14 * DIMENSIUNE_PAS_Y;

            txtPrenume = new TextBox();
            txtPrenume.Width = LATIME_CONTROL;
            txtPrenume.Left = DIMENSIUNE_PAS_X;
            txtPrenume.Top = 15 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtPrenume);

            lblsPrenume = new Label();
            lblsPrenume.Text = "Prenume";
            this.Controls.Add(lblsPrenume);
            lblsPrenume.ForeColor = Color.Blue;
            lblsPrenume.Width = LATIME_CONTROL;
            lblsPrenume.Left = DIMENSIUNE_PAS_X / 2;
            lblsPrenume.Top = 15 * DIMENSIUNE_PAS_Y;

            txtVarsta = new TextBox();
            txtVarsta.Width = LATIME_CONTROL;
            txtVarsta.Left = DIMENSIUNE_PAS_X;
            txtVarsta.Top = 16 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtVarsta);

            lblsVarsta = new Label();
            lblsVarsta.Text = "Varsta";
            this.Controls.Add(lblsVarsta);
            lblsVarsta.ForeColor = Color.Blue;
            lblsVarsta.Width = LATIME_CONTROL;
            lblsVarsta.Left = DIMENSIUNE_PAS_X / 2;
            lblsVarsta.Top = 16 * DIMENSIUNE_PAS_Y;

            txtnrOre = new TextBox();
            txtnrOre.Width = LATIME_CONTROL;
            txtnrOre.Left = DIMENSIUNE_PAS_X;
            txtnrOre.Top = 17 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtnrOre);

            lblsnrOre = new Label();
            lblsnrOre.Text = "Numar ore";
            this.Controls.Add(lblsnrOre);
            lblsnrOre.ForeColor = Color.Blue;
            lblsnrOre.Width = LATIME_CONTROL;
            lblsnrOre.Left = DIMENSIUNE_PAS_X / 2;
            lblsnrOre.Top = 17 * DIMENSIUNE_PAS_Y;


        }

        private void AfisarePersoane()
        {
            this.Font = new Font("Arial", 9, FontStyle.Bold);

            ArrayList persoane = AdministrarePersoane.GetPersoane();
            int NrPersoane = persoane.Count;
            lbliNume = new Label[NrPersoane];
            lbliPrenume = new Label[NrPersoane];
            lbliVarsta = new Label[NrPersoane];
            lbliId = new Label[NrPersoane];
            lblinrOre = new Label[NrPersoane];

            int i = 0;

            foreach (Persoana persoana in persoane)
            {
                lbliId[i] = new Label();
                lbliId[i].Text = persoana.IdPers.ToString();
                this.Controls.Add(lbliId[i]);
                lbliId[i].BackColor = Color.AliceBlue;
                lbliId[i].Left = DIMENSIUNE_PAS_X;
                lbliId[i].Top = (i + 4) * DIMENSIUNE_PAS_Y;


                lbliNume[i] = new Label();
                lbliNume[i].Text = persoana.Nume;
                this.Controls.Add(lbliNume[i]);
                lbliNume[i].BackColor = Color.AliceBlue;
                lbliNume[i].Left = 2 * DIMENSIUNE_PAS_X;
                lbliNume[i].Top = (i + 4) * DIMENSIUNE_PAS_Y;

                lbliPrenume[i] = new Label();
                lbliPrenume[i].Text = persoana.Prenume;
                this.Controls.Add(lbliPrenume[i]);
                lbliPrenume[i].BackColor = Color.AliceBlue;
                lbliPrenume[i].Left = 3 * DIMENSIUNE_PAS_X;
                lbliPrenume[i].Top = (i + 4) * DIMENSIUNE_PAS_Y;

                lbliVarsta[i] = new Label();
                lbliVarsta[i].Text = persoana.Varsta.ToString();
                this.Controls.Add(lbliVarsta[i]);
                lbliVarsta[i].BackColor = Color.AliceBlue;
                lbliVarsta[i].Left = 4 * DIMENSIUNE_PAS_X;
                lbliVarsta[i].Top = (i + 4) * DIMENSIUNE_PAS_Y;

                lblinrOre[i] = new Label();
                lblinrOre[i].Text = persoana.Nr_ore.ToString();
                this.Controls.Add(lblinrOre[i]);
                lblinrOre[i].BackColor = Color.AliceBlue;
                lblinrOre[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblinrOre[i].Top = (i + 4) * DIMENSIUNE_PAS_Y;


                i++;
            }
        }

        

        private bool DateIntrareValide()
        {
            Int32.TryParse(txtVarsta.Text, out int Varsta);
            string id = txtId.Text;
            if (id.Length <= 3 && Varsta <= 25)
            {
                return true;
            }
            return false;

        }

        private void ResetareControale()
        {
            txtId.Text = txtNume.Text = txtPrenume.Text = txtVarsta.Text = txtnrOre.Text = string.Empty;

        }

        private void Adaugare_Click(object sender, EventArgs e)
        {
            if (!DateIntrareValide())
            {
                lblsId.ForeColor = Color.Red;
                lblsVarsta.ForeColor = Color.Red;


                return;
            }
            Int32.TryParse(txtId.Text, out int Id);
            Int32.TryParse(txtVarsta.Text, out int Varsta);
            Int32.TryParse(txtnrOre.Text, out int nrOre);

            Persoana persoananew = new Persoana(Id, txtNume.Text, txtPrenume.Text, Varsta, nrOre);

            nrPers = nrPers + 1;
            AdministrarePersoane.AddPersoane(persoananew);

            ResetareControale();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AfisarePersoane();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
