
namespace InterfataUtilizator_WindowsForms.Formulare
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            this.labelBunVenit = new System.Windows.Forms.Label();
            this.labelAlege = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelTimp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelBunVenit
            // 
            this.labelBunVenit.AutoSize = true;
            this.labelBunVenit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.labelBunVenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBunVenit.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBunVenit.Location = new System.Drawing.Point(450, 263);
            this.labelBunVenit.Name = "labelBunVenit";
            this.labelBunVenit.Size = new System.Drawing.Size(154, 33);
            this.labelBunVenit.TabIndex = 5;
            this.labelBunVenit.Text = "Bun venit!";
            // 
            // labelAlege
            // 
            this.labelAlege.AutoSize = true;
            this.labelAlege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.labelAlege.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlege.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAlege.Location = new System.Drawing.Point(186, 343);
            this.labelAlege.Name = "labelAlege";
            this.labelAlege.Size = new System.Drawing.Size(774, 20);
            this.labelAlege.TabIndex = 6;
            this.labelAlege.Text = "Alegeți unul din butoanele amplasate în partea stângă, configurând computerul dum" +
    "neavoastră.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(726, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Copyright © 2022 RZV COMPUTERS Toate drepturile rezervate.";
            // 
            // labelData
            // 
            this.labelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.SystemColors.Control;
            this.labelData.Location = new System.Drawing.Point(0, 82);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(522, 48);
            this.labelData.TabIndex = 8;
            this.labelData.Text = "Data";
            this.labelData.Click += new System.EventHandler(this.labelData_Click);
            // 
            // labelTimp
            // 
            this.labelTimp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.labelTimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimp.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTimp.Location = new System.Drawing.Point(0, 130);
            this.labelTimp.Name = "labelTimp";
            this.labelTimp.Size = new System.Drawing.Size(525, 60);
            this.labelTimp.TabIndex = 9;
            this.labelTimp.Text = "Timp";
            this.labelTimp.Click += new System.EventHandler(this.labelTimp_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.rzvcomputersfinal;
            this.ClientSize = new System.Drawing.Size(1098, 626);
            this.Controls.Add(this.labelTimp);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAlege);
            this.Controls.Add(this.labelBunVenit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBunVenit;
        private System.Windows.Forms.Label labelAlege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelTimp;
        private System.Windows.Forms.Timer timer1;
    }
}