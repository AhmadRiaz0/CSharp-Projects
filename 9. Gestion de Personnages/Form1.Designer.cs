namespace Encapsulation
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudVie = new System.Windows.Forms.NumericUpDown();
            this.txtPersonnageSelctionner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPersonnage = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonnagePlusVie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudVie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(53, 13);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(198, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vie :";
            // 
            // nudVie
            // 
            this.nudVie.Location = new System.Drawing.Point(53, 45);
            this.nudVie.Name = "nudVie";
            this.nudVie.Size = new System.Drawing.Size(78, 20);
            this.nudVie.TabIndex = 3;
            this.nudVie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVie.ValueChanged += new System.EventHandler(this.nudVie_ValueChanged);
            // 
            // txtPersonnageSelctionner
            // 
            this.txtPersonnageSelctionner.Location = new System.Drawing.Point(18, 86);
            this.txtPersonnageSelctionner.Name = "txtPersonnageSelctionner";
            this.txtPersonnageSelctionner.Size = new System.Drawing.Size(236, 20);
            this.txtPersonnageSelctionner.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personnages";
            // 
            // lstPersonnage
            // 
            this.lstPersonnage.FormattingEnabled = true;
            this.lstPersonnage.Location = new System.Drawing.Point(18, 142);
            this.lstPersonnage.Name = "lstPersonnage";
            this.lstPersonnage.Size = new System.Drawing.Size(236, 199);
            this.lstPersonnage.TabIndex = 6;
            this.lstPersonnage.SelectedIndexChanged += new System.EventHandler(this.lstPersonnage_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Personnage ayant le plus de vie : ";
            // 
            // txtPersonnagePlusVie
            // 
            this.txtPersonnagePlusVie.Location = new System.Drawing.Point(18, 364);
            this.txtPersonnagePlusVie.Name = "txtPersonnagePlusVie";
            this.txtPersonnagePlusVie.Size = new System.Drawing.Size(233, 20);
            this.txtPersonnagePlusVie.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 394);
            this.Controls.Add(this.txtPersonnagePlusVie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPersonnage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPersonnageSelctionner);
            this.Controls.Add(this.nudVie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudVie;
        private System.Windows.Forms.TextBox txtPersonnageSelctionner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPersonnage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonnagePlusVie;
    }
}

