
namespace InterfataUtilizator_WindowsForms.Formulare
{
    partial class PerifericeForm
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
            this.labeltitluperif = new System.Windows.Forms.Label();
            this.labelidperif = new System.Windows.Forms.Label();
            this.textBoxIdPerif = new System.Windows.Forms.TextBox();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.textBoxMonitor = new System.Windows.Forms.TextBox();
            this.labelMouse = new System.Windows.Forms.Label();
            this.textBoxMouse = new System.Windows.Forms.TextBox();
            this.labelTastatura = new System.Windows.Forms.Label();
            this.textBoxTastatura = new System.Windows.Forms.TextBox();
            this.labelCasti = new System.Windows.Forms.Label();
            this.textBoxCasti = new System.Windows.Forms.TextBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonEditare = new System.Windows.Forms.Button();
            this.buttonStergere = new System.Windows.Forms.Button();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.listBoxPeriferice = new System.Windows.Forms.ListBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeltitluperif
            // 
            this.labeltitluperif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.labeltitluperif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitluperif.ForeColor = System.Drawing.SystemColors.Control;
            this.labeltitluperif.Location = new System.Drawing.Point(300, 88);
            this.labeltitluperif.Name = "labeltitluperif";
            this.labeltitluperif.Size = new System.Drawing.Size(620, 35);
            this.labeltitluperif.TabIndex = 0;
            this.labeltitluperif.Text = "Bun venit în meniul de configurare a perifericelor!";
            this.labeltitluperif.Click += new System.EventHandler(this.labeltitluperif_Click);
            // 
            // labelidperif
            // 
            this.labelidperif.AutoSize = true;
            this.labelidperif.Location = new System.Drawing.Point(37, 165);
            this.labelidperif.Name = "labelidperif";
            this.labelidperif.Size = new System.Drawing.Size(42, 13);
            this.labelidperif.TabIndex = 1;
            this.labelidperif.Text = "ID SET";
            this.labelidperif.Click += new System.EventHandler(this.labelidperif_Click);
            // 
            // textBoxIdPerif
            // 
            this.textBoxIdPerif.Location = new System.Drawing.Point(120, 162);
            this.textBoxIdPerif.Name = "textBoxIdPerif";
            this.textBoxIdPerif.Size = new System.Drawing.Size(156, 20);
            this.textBoxIdPerif.TabIndex = 2;
            this.textBoxIdPerif.TextChanged += new System.EventHandler(this.textBoxIdPerif_TextChanged);
            // 
            // labelMonitor
            // 
            this.labelMonitor.AutoSize = true;
            this.labelMonitor.Location = new System.Drawing.Point(37, 196);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(42, 13);
            this.labelMonitor.TabIndex = 3;
            this.labelMonitor.Text = "Monitor";
            this.labelMonitor.Click += new System.EventHandler(this.labelMonitor_Click);
            // 
            // textBoxMonitor
            // 
            this.textBoxMonitor.Location = new System.Drawing.Point(120, 193);
            this.textBoxMonitor.Name = "textBoxMonitor";
            this.textBoxMonitor.Size = new System.Drawing.Size(156, 20);
            this.textBoxMonitor.TabIndex = 4;
            this.textBoxMonitor.TextChanged += new System.EventHandler(this.textBoxMonitor_TextChanged);
            // 
            // labelMouse
            // 
            this.labelMouse.AutoSize = true;
            this.labelMouse.Location = new System.Drawing.Point(37, 225);
            this.labelMouse.Name = "labelMouse";
            this.labelMouse.Size = new System.Drawing.Size(39, 13);
            this.labelMouse.TabIndex = 5;
            this.labelMouse.Text = "Mouse";
            this.labelMouse.Click += new System.EventHandler(this.labelMouse_Click);
            // 
            // textBoxMouse
            // 
            this.textBoxMouse.Location = new System.Drawing.Point(120, 222);
            this.textBoxMouse.Name = "textBoxMouse";
            this.textBoxMouse.Size = new System.Drawing.Size(156, 20);
            this.textBoxMouse.TabIndex = 6;
            this.textBoxMouse.TextChanged += new System.EventHandler(this.textBoxMouse_TextChanged);
            // 
            // labelTastatura
            // 
            this.labelTastatura.AutoSize = true;
            this.labelTastatura.Location = new System.Drawing.Point(37, 253);
            this.labelTastatura.Name = "labelTastatura";
            this.labelTastatura.Size = new System.Drawing.Size(52, 13);
            this.labelTastatura.TabIndex = 7;
            this.labelTastatura.Text = "Tastatura";
            this.labelTastatura.Click += new System.EventHandler(this.labelTastatura_Click);
            // 
            // textBoxTastatura
            // 
            this.textBoxTastatura.Location = new System.Drawing.Point(120, 250);
            this.textBoxTastatura.Name = "textBoxTastatura";
            this.textBoxTastatura.Size = new System.Drawing.Size(156, 20);
            this.textBoxTastatura.TabIndex = 8;
            this.textBoxTastatura.TextChanged += new System.EventHandler(this.textBoxTastatura_TextChanged);
            // 
            // labelCasti
            // 
            this.labelCasti.AutoSize = true;
            this.labelCasti.Location = new System.Drawing.Point(37, 283);
            this.labelCasti.Name = "labelCasti";
            this.labelCasti.Size = new System.Drawing.Size(30, 13);
            this.labelCasti.TabIndex = 9;
            this.labelCasti.Text = "Casti";
            this.labelCasti.Click += new System.EventHandler(this.labelCasti_Click);
            // 
            // textBoxCasti
            // 
            this.textBoxCasti.Location = new System.Drawing.Point(120, 280);
            this.textBoxCasti.Name = "textBoxCasti";
            this.textBoxCasti.Size = new System.Drawing.Size(156, 20);
            this.textBoxCasti.TabIndex = 10;
            this.textBoxCasti.TextChanged += new System.EventHandler(this.textBoxCasti_TextChanged);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(441, 151);
            this.buttonAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(100, 34);
            this.buttonAdauga.TabIndex = 11;
            this.buttonAdauga.Text = "Adăugare";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // buttonEditare
            // 
            this.buttonEditare.Location = new System.Drawing.Point(598, 196);
            this.buttonEditare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditare.Name = "buttonEditare";
            this.buttonEditare.Size = new System.Drawing.Size(100, 34);
            this.buttonEditare.TabIndex = 15;
            this.buttonEditare.Text = "Actualizare";
            this.buttonEditare.UseVisualStyleBackColor = true;
            this.buttonEditare.Click += new System.EventHandler(this.buttonEditare_Click);
            // 
            // buttonStergere
            // 
            this.buttonStergere.Location = new System.Drawing.Point(598, 151);
            this.buttonStergere.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStergere.Name = "buttonStergere";
            this.buttonStergere.Size = new System.Drawing.Size(100, 34);
            this.buttonStergere.TabIndex = 16;
            this.buttonStergere.Text = "Ștergere";
            this.buttonStergere.UseVisualStyleBackColor = true;
            this.buttonStergere.Click += new System.EventHandler(this.buttonStergere_Click);
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Location = new System.Drawing.Point(441, 421);
            this.buttonAfisare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(185, 32);
            this.buttonAfisare.TabIndex = 17;
            this.buttonAfisare.Text = "Afișare periferice";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // listBoxPeriferice
            // 
            this.listBoxPeriferice.FormattingEnabled = true;
            this.listBoxPeriferice.Location = new System.Drawing.Point(147, 461);
            this.listBoxPeriferice.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPeriferice.Name = "listBoxPeriferice";
            this.listBoxPeriferice.Size = new System.Drawing.Size(755, 108);
            this.listBoxPeriferice.TabIndex = 21;
            this.listBoxPeriferice.SelectedIndexChanged += new System.EventHandler(this.listBoxPeriferice_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(438, 393);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 22;
            this.labelStatus.Text = "Status";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(441, 196);
            this.buttonCauta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(100, 34);
            this.buttonCauta.TabIndex = 23;
            this.buttonCauta.Text = "Căutare";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // PerifericeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.rzvcomputersfinal;
            this.ClientSize = new System.Drawing.Size(1098, 626);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.listBoxPeriferice);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.buttonStergere);
            this.Controls.Add(this.buttonEditare);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.textBoxCasti);
            this.Controls.Add(this.labelCasti);
            this.Controls.Add(this.textBoxTastatura);
            this.Controls.Add(this.labelTastatura);
            this.Controls.Add(this.textBoxMouse);
            this.Controls.Add(this.labelMouse);
            this.Controls.Add(this.textBoxMonitor);
            this.Controls.Add(this.labelMonitor);
            this.Controls.Add(this.textBoxIdPerif);
            this.Controls.Add(this.labelidperif);
            this.Controls.Add(this.labeltitluperif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerifericeForm";
            this.Text = "PerifericeForm";
            this.Load += new System.EventHandler(this.PerifericeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitluperif;
        private System.Windows.Forms.Label labelidperif;
        private System.Windows.Forms.TextBox textBoxIdPerif;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.TextBox textBoxMonitor;
        private System.Windows.Forms.Label labelMouse;
        private System.Windows.Forms.TextBox textBoxMouse;
        private System.Windows.Forms.Label labelTastatura;
        private System.Windows.Forms.TextBox textBoxTastatura;
        private System.Windows.Forms.Label labelCasti;
        private System.Windows.Forms.TextBox textBoxCasti;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonEditare;
        private System.Windows.Forms.Button buttonStergere;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.ListBox listBoxPeriferice;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonCauta;
    }
}