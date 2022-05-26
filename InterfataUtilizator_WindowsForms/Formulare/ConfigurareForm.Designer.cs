
namespace InterfataUtilizator_WindowsForms.Formulare
{
    partial class ConfigurareForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonGaming = new System.Windows.Forms.RadioButton();
            this.radioButtonOffice = new System.Windows.Forms.RadioButton();
            this.radioButtonRender = new System.Windows.Forms.RadioButton();
            this.radioButtonBasic = new System.Windows.Forms.RadioButton();
            this.labelConfig = new System.Windows.Forms.Label();
            this.labelIntroducere = new System.Windows.Forms.Label();
            this.labelidconfigurare = new System.Windows.Forms.Label();
            this.labelidcomponente = new System.Windows.Forms.Label();
            this.labelidperiferice = new System.Windows.Forms.Label();
            this.textBoxConfigurare = new System.Windows.Forms.TextBox();
            this.textBoxComponente = new System.Windows.Forms.TextBox();
            this.textBoxPeriferice = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.listBoxConfigurare = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // radioButtonGaming
            // 
            this.radioButtonGaming.AutoSize = true;
            this.radioButtonGaming.Location = new System.Drawing.Point(100, 192);
            this.radioButtonGaming.Name = "radioButtonGaming";
            this.radioButtonGaming.Size = new System.Drawing.Size(61, 17);
            this.radioButtonGaming.TabIndex = 0;
            this.radioButtonGaming.TabStop = true;
            this.radioButtonGaming.Text = "Gaming";
            this.radioButtonGaming.UseVisualStyleBackColor = true;
            this.radioButtonGaming.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonOffice
            // 
            this.radioButtonOffice.AutoSize = true;
            this.radioButtonOffice.Location = new System.Drawing.Point(204, 192);
            this.radioButtonOffice.Name = "radioButtonOffice";
            this.radioButtonOffice.Size = new System.Drawing.Size(53, 17);
            this.radioButtonOffice.TabIndex = 1;
            this.radioButtonOffice.TabStop = true;
            this.radioButtonOffice.Text = "Office";
            this.radioButtonOffice.UseVisualStyleBackColor = true;
            // 
            // radioButtonRender
            // 
            this.radioButtonRender.AutoSize = true;
            this.radioButtonRender.Location = new System.Drawing.Point(299, 192);
            this.radioButtonRender.Name = "radioButtonRender";
            this.radioButtonRender.Size = new System.Drawing.Size(60, 17);
            this.radioButtonRender.TabIndex = 2;
            this.radioButtonRender.TabStop = true;
            this.radioButtonRender.Text = "Render";
            this.radioButtonRender.UseVisualStyleBackColor = true;
            // 
            // radioButtonBasic
            // 
            this.radioButtonBasic.AutoSize = true;
            this.radioButtonBasic.Location = new System.Drawing.Point(395, 192);
            this.radioButtonBasic.Name = "radioButtonBasic";
            this.radioButtonBasic.Size = new System.Drawing.Size(51, 17);
            this.radioButtonBasic.TabIndex = 3;
            this.radioButtonBasic.TabStop = true;
            this.radioButtonBasic.Text = "Basic";
            this.radioButtonBasic.UseVisualStyleBackColor = true;
            // 
            // labelConfig
            // 
            this.labelConfig.AutoSize = true;
            this.labelConfig.Location = new System.Drawing.Point(97, 147);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(213, 13);
            this.labelConfig.TabIndex = 4;
            this.labelConfig.Text = "Selectati tipul de pachet pentru configurare:";
            // 
            // labelIntroducere
            // 
            this.labelIntroducere.AutoSize = true;
            this.labelIntroducere.Location = new System.Drawing.Point(544, 147);
            this.labelIntroducere.Name = "labelIntroducere";
            this.labelIntroducere.Size = new System.Drawing.Size(364, 13);
            this.labelIntroducere.TabIndex = 5;
            this.labelIntroducere.Text = "Introduceti id-ul configurarii, alaturi de cel al componentelor si al perifericel" +
    "or:";
            // 
            // labelidconfigurare
            // 
            this.labelidconfigurare.AutoSize = true;
            this.labelidconfigurare.Location = new System.Drawing.Point(544, 196);
            this.labelidconfigurare.Name = "labelidconfigurare";
            this.labelidconfigurare.Size = new System.Drawing.Size(102, 13);
            this.labelidconfigurare.TabIndex = 6;
            this.labelidconfigurare.Text = "ID CONFIGURARE:";
            this.labelidconfigurare.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelidcomponente
            // 
            this.labelidcomponente.AutoSize = true;
            this.labelidcomponente.Location = new System.Drawing.Point(544, 224);
            this.labelidcomponente.Name = "labelidcomponente";
            this.labelidcomponente.Size = new System.Drawing.Size(100, 13);
            this.labelidcomponente.TabIndex = 7;
            this.labelidcomponente.Text = "ID COMPONENTE:";
            // 
            // labelidperiferice
            // 
            this.labelidperiferice.AutoSize = true;
            this.labelidperiferice.Location = new System.Drawing.Point(544, 252);
            this.labelidperiferice.Name = "labelidperiferice";
            this.labelidperiferice.Size = new System.Drawing.Size(87, 13);
            this.labelidperiferice.TabIndex = 8;
            this.labelidperiferice.Text = "ID PERIFERICE:";
            // 
            // textBoxConfigurare
            // 
            this.textBoxConfigurare.Location = new System.Drawing.Point(717, 193);
            this.textBoxConfigurare.Name = "textBoxConfigurare";
            this.textBoxConfigurare.Size = new System.Drawing.Size(100, 20);
            this.textBoxConfigurare.TabIndex = 9;
            this.textBoxConfigurare.TextChanged += new System.EventHandler(this.textBoxConfigurare_TextChanged);
            // 
            // textBoxComponente
            // 
            this.textBoxComponente.Location = new System.Drawing.Point(717, 221);
            this.textBoxComponente.Name = "textBoxComponente";
            this.textBoxComponente.Size = new System.Drawing.Size(100, 20);
            this.textBoxComponente.TabIndex = 10;
            this.textBoxComponente.TextChanged += new System.EventHandler(this.textBoxComponente_TextChanged);
            // 
            // textBoxPeriferice
            // 
            this.textBoxPeriferice.Location = new System.Drawing.Point(717, 249);
            this.textBoxPeriferice.Name = "textBoxPeriferice";
            this.textBoxPeriferice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeriferice.TabIndex = 11;
            this.textBoxPeriferice.TextChanged += new System.EventHandler(this.textBoxPeriferice_TextChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(409, 314);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(197, 37);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "SUBMIT CONFIGURARE";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // listBoxConfigurare
            // 
            this.listBoxConfigurare.FormattingEnabled = true;
            this.listBoxConfigurare.Location = new System.Drawing.Point(250, 397);
            this.listBoxConfigurare.Name = "listBoxConfigurare";
            this.listBoxConfigurare.Size = new System.Drawing.Size(567, 95);
            this.listBoxConfigurare.TabIndex = 14;
            this.listBoxConfigurare.SelectedIndexChanged += new System.EventHandler(this.listBoxConfigurare_SelectedIndexChanged);
            // 
            // ConfigurareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.rzvcomputersfinal;
            this.ClientSize = new System.Drawing.Size(1098, 626);
            this.Controls.Add(this.listBoxConfigurare);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxPeriferice);
            this.Controls.Add(this.textBoxComponente);
            this.Controls.Add(this.textBoxConfigurare);
            this.Controls.Add(this.labelidperiferice);
            this.Controls.Add(this.labelidcomponente);
            this.Controls.Add(this.labelidconfigurare);
            this.Controls.Add(this.labelIntroducere);
            this.Controls.Add(this.labelConfig);
            this.Controls.Add(this.radioButtonBasic);
            this.Controls.Add(this.radioButtonRender);
            this.Controls.Add(this.radioButtonOffice);
            this.Controls.Add(this.radioButtonGaming);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigurareForm";
            this.Text = "ConfigurareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonGaming;
        private System.Windows.Forms.RadioButton radioButtonOffice;
        private System.Windows.Forms.RadioButton radioButtonRender;
        private System.Windows.Forms.RadioButton radioButtonBasic;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.Label labelIntroducere;
        private System.Windows.Forms.Label labelidconfigurare;
        private System.Windows.Forms.Label labelidcomponente;
        private System.Windows.Forms.Label labelidperiferice;
        private System.Windows.Forms.TextBox textBoxConfigurare;
        private System.Windows.Forms.TextBox textBoxComponente;
        private System.Windows.Forms.TextBox textBoxPeriferice;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ListBox listBoxConfigurare;
    }
}