
namespace InterfataUtilizator_WindowsForms.Formulare
{
    partial class ComponenteForm
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
            this.labelanuntcomp = new System.Windows.Forms.Label();
            this.labelSetComp = new System.Windows.Forms.Label();
            this.labelMOBO = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.labelCooler = new System.Windows.Forms.Label();
            this.labelHDD = new System.Windows.Forms.Label();
            this.labelSSD = new System.Windows.Forms.Label();
            this.textBoxIdSetComp = new System.Windows.Forms.TextBox();
            this.textBoxMOBO = new System.Windows.Forms.TextBox();
            this.textBoxRAM = new System.Windows.Forms.TextBox();
            this.textBoxCPU = new System.Windows.Forms.TextBox();
            this.textBoxGPU = new System.Windows.Forms.TextBox();
            this.textBoxCooler = new System.Windows.Forms.TextBox();
            this.textBoxHDD = new System.Windows.Forms.TextBox();
            this.textBoxSSD = new System.Windows.Forms.TextBox();
            this.listBoxComponente = new System.Windows.Forms.ListBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.buttonStergere = new System.Windows.Forms.Button();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.buttonEditare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelanuntcomp
            // 
            this.labelanuntcomp.AutoSize = true;
            this.labelanuntcomp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.labelanuntcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelanuntcomp.ForeColor = System.Drawing.SystemColors.Control;
            this.labelanuntcomp.Location = new System.Drawing.Point(278, 86);
            this.labelanuntcomp.Name = "labelanuntcomp";
            this.labelanuntcomp.Size = new System.Drawing.Size(561, 25);
            this.labelanuntcomp.TabIndex = 0;
            this.labelanuntcomp.Text = "Bun venit în meniul de configurare a componentelor!";
            this.labelanuntcomp.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSetComp
            // 
            this.labelSetComp.AutoSize = true;
            this.labelSetComp.Location = new System.Drawing.Point(34, 227);
            this.labelSetComp.Name = "labelSetComp";
            this.labelSetComp.Size = new System.Drawing.Size(42, 13);
            this.labelSetComp.TabIndex = 1;
            this.labelSetComp.Text = "ID SET";
            this.labelSetComp.Click += new System.EventHandler(this.labelSetComp_Click);
            // 
            // labelMOBO
            // 
            this.labelMOBO.AutoSize = true;
            this.labelMOBO.Location = new System.Drawing.Point(34, 258);
            this.labelMOBO.Name = "labelMOBO";
            this.labelMOBO.Size = new System.Drawing.Size(75, 13);
            this.labelMOBO.TabIndex = 2;
            this.labelMOBO.Text = "Placa de baza";
            this.labelMOBO.Click += new System.EventHandler(this.labelMOBO_Click);
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Location = new System.Drawing.Point(34, 287);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(31, 13);
            this.labelRam.TabIndex = 3;
            this.labelRam.Text = "RAM";
            this.labelRam.Click += new System.EventHandler(this.labelRam_Click);
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(34, 317);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(49, 13);
            this.labelCPU.TabIndex = 4;
            this.labelCPU.Text = "Procesor";
            this.labelCPU.Click += new System.EventHandler(this.labelCPU_Click);
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.Location = new System.Drawing.Point(34, 346);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(63, 13);
            this.labelGPU.TabIndex = 5;
            this.labelGPU.Text = "Placa video";
            this.labelGPU.Click += new System.EventHandler(this.labelGPU_Click);
            // 
            // labelCooler
            // 
            this.labelCooler.AutoSize = true;
            this.labelCooler.Location = new System.Drawing.Point(34, 375);
            this.labelCooler.Name = "labelCooler";
            this.labelCooler.Size = new System.Drawing.Size(37, 13);
            this.labelCooler.TabIndex = 6;
            this.labelCooler.Text = "Cooler";
            this.labelCooler.Click += new System.EventHandler(this.labelCooler_Click);
            // 
            // labelHDD
            // 
            this.labelHDD.AutoSize = true;
            this.labelHDD.Location = new System.Drawing.Point(34, 402);
            this.labelHDD.Name = "labelHDD";
            this.labelHDD.Size = new System.Drawing.Size(82, 13);
            this.labelHDD.TabIndex = 7;
            this.labelHDD.Text = "Hard-Disk Drive";
            this.labelHDD.Click += new System.EventHandler(this.labelHDD_Click);
            // 
            // labelSSD
            // 
            this.labelSSD.AutoSize = true;
            this.labelSSD.Location = new System.Drawing.Point(34, 431);
            this.labelSSD.Name = "labelSSD";
            this.labelSSD.Size = new System.Drawing.Size(86, 13);
            this.labelSSD.TabIndex = 8;
            this.labelSSD.Text = "Solid State Drive";
            this.labelSSD.Click += new System.EventHandler(this.labelSSD_Click);
            // 
            // textBoxIdSetComp
            // 
            this.textBoxIdSetComp.Location = new System.Drawing.Point(178, 224);
            this.textBoxIdSetComp.Name = "textBoxIdSetComp";
            this.textBoxIdSetComp.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdSetComp.TabIndex = 9;
            this.textBoxIdSetComp.TextChanged += new System.EventHandler(this.textBoxIdSetComp_TextChanged);
            // 
            // textBoxMOBO
            // 
            this.textBoxMOBO.Location = new System.Drawing.Point(178, 255);
            this.textBoxMOBO.Name = "textBoxMOBO";
            this.textBoxMOBO.Size = new System.Drawing.Size(100, 20);
            this.textBoxMOBO.TabIndex = 10;
            this.textBoxMOBO.TextChanged += new System.EventHandler(this.textBoxMOBO_TextChanged);
            // 
            // textBoxRAM
            // 
            this.textBoxRAM.Location = new System.Drawing.Point(178, 284);
            this.textBoxRAM.Name = "textBoxRAM";
            this.textBoxRAM.Size = new System.Drawing.Size(100, 20);
            this.textBoxRAM.TabIndex = 11;
            this.textBoxRAM.TextChanged += new System.EventHandler(this.textBoxRAM_TextChanged);
            // 
            // textBoxCPU
            // 
            this.textBoxCPU.Location = new System.Drawing.Point(178, 314);
            this.textBoxCPU.Name = "textBoxCPU";
            this.textBoxCPU.Size = new System.Drawing.Size(100, 20);
            this.textBoxCPU.TabIndex = 12;
            this.textBoxCPU.TextChanged += new System.EventHandler(this.textBoxCPU_TextChanged);
            // 
            // textBoxGPU
            // 
            this.textBoxGPU.Location = new System.Drawing.Point(178, 343);
            this.textBoxGPU.Name = "textBoxGPU";
            this.textBoxGPU.Size = new System.Drawing.Size(100, 20);
            this.textBoxGPU.TabIndex = 13;
            this.textBoxGPU.TextChanged += new System.EventHandler(this.textBoxGPU_TextChanged);
            // 
            // textBoxCooler
            // 
            this.textBoxCooler.Location = new System.Drawing.Point(178, 372);
            this.textBoxCooler.Name = "textBoxCooler";
            this.textBoxCooler.Size = new System.Drawing.Size(100, 20);
            this.textBoxCooler.TabIndex = 14;
            this.textBoxCooler.TextChanged += new System.EventHandler(this.textBoxCooler_TextChanged);
            // 
            // textBoxHDD
            // 
            this.textBoxHDD.Location = new System.Drawing.Point(178, 399);
            this.textBoxHDD.Name = "textBoxHDD";
            this.textBoxHDD.Size = new System.Drawing.Size(100, 20);
            this.textBoxHDD.TabIndex = 15;
            this.textBoxHDD.TextChanged += new System.EventHandler(this.textBoxHDD_TextChanged);
            // 
            // textBoxSSD
            // 
            this.textBoxSSD.Location = new System.Drawing.Point(178, 428);
            this.textBoxSSD.Name = "textBoxSSD";
            this.textBoxSSD.Size = new System.Drawing.Size(100, 20);
            this.textBoxSSD.TabIndex = 16;
            this.textBoxSSD.TextChanged += new System.EventHandler(this.textBoxSSD_TextChanged);
            // 
            // listBoxComponente
            // 
            this.listBoxComponente.FormattingEnabled = true;
            this.listBoxComponente.Location = new System.Drawing.Point(128, 471);
            this.listBoxComponente.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxComponente.Name = "listBoxComponente";
            this.listBoxComponente.Size = new System.Drawing.Size(856, 108);
            this.listBoxComponente.TabIndex = 22;
            this.listBoxComponente.SelectedIndexChanged += new System.EventHandler(this.listBoxComponente_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(446, 408);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 23;
            this.labelStatus.Text = "Status";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(548, 198);
            this.buttonAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(100, 34);
            this.buttonAdauga.TabIndex = 24;
            this.buttonAdauga.Text = "Adăugare";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Location = new System.Drawing.Point(449, 431);
            this.buttonAfisare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(185, 32);
            this.buttonAfisare.TabIndex = 25;
            this.buttonAfisare.Text = "Afișare componente";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // buttonStergere
            // 
            this.buttonStergere.Location = new System.Drawing.Point(671, 198);
            this.buttonStergere.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStergere.Name = "buttonStergere";
            this.buttonStergere.Size = new System.Drawing.Size(100, 34);
            this.buttonStergere.TabIndex = 26;
            this.buttonStergere.Text = "Ștergere";
            this.buttonStergere.UseVisualStyleBackColor = true;
            this.buttonStergere.Click += new System.EventHandler(this.buttonStergere_Click);
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(548, 251);
            this.buttonCauta.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(100, 34);
            this.buttonCauta.TabIndex = 27;
            this.buttonCauta.Text = "Căutare";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // buttonEditare
            // 
            this.buttonEditare.Location = new System.Drawing.Point(671, 251);
            this.buttonEditare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditare.Name = "buttonEditare";
            this.buttonEditare.Size = new System.Drawing.Size(100, 34);
            this.buttonEditare.TabIndex = 28;
            this.buttonEditare.Text = "Actualizare";
            this.buttonEditare.UseVisualStyleBackColor = true;
            this.buttonEditare.Click += new System.EventHandler(this.buttonEditare_Click);
            // 
            // ComponenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.rzvcomputersfinal;
            this.ClientSize = new System.Drawing.Size(1098, 626);
            this.Controls.Add(this.buttonEditare);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.buttonStergere);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.listBoxComponente);
            this.Controls.Add(this.textBoxSSD);
            this.Controls.Add(this.textBoxHDD);
            this.Controls.Add(this.textBoxCooler);
            this.Controls.Add(this.textBoxGPU);
            this.Controls.Add(this.textBoxCPU);
            this.Controls.Add(this.textBoxRAM);
            this.Controls.Add(this.textBoxMOBO);
            this.Controls.Add(this.textBoxIdSetComp);
            this.Controls.Add(this.labelSSD);
            this.Controls.Add(this.labelHDD);
            this.Controls.Add(this.labelCooler);
            this.Controls.Add(this.labelGPU);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.labelMOBO);
            this.Controls.Add(this.labelSetComp);
            this.Controls.Add(this.labelanuntcomp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponenteForm";
            this.Text = "ComponenteForm";
            this.Load += new System.EventHandler(this.ComponenteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelanuntcomp;
        private System.Windows.Forms.Label labelSetComp;
        private System.Windows.Forms.Label labelMOBO;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labelGPU;
        private System.Windows.Forms.Label labelCooler;
        private System.Windows.Forms.Label labelHDD;
        private System.Windows.Forms.Label labelSSD;
        private System.Windows.Forms.TextBox textBoxIdSetComp;
        private System.Windows.Forms.TextBox textBoxMOBO;
        private System.Windows.Forms.TextBox textBoxRAM;
        private System.Windows.Forms.TextBox textBoxCPU;
        private System.Windows.Forms.TextBox textBoxGPU;
        private System.Windows.Forms.TextBox textBoxCooler;
        private System.Windows.Forms.TextBox textBoxHDD;
        private System.Windows.Forms.TextBox textBoxSSD;
        private System.Windows.Forms.ListBox listBoxComponente;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.Button buttonStergere;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Button buttonEditare;
    }
}