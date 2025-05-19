namespace PolymorphismeAbstraction
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
            this.grpPersonnage = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.rdoXmen = new System.Windows.Forms.RadioButton();
            this.rdoHumain = new System.Windows.Forms.RadioButton();
            this.cboPouvoir = new System.Windows.Forms.ComboBox();
            this.nudVie = new System.Windows.Forms.NumericUpDown();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblVie = new System.Windows.Forms.Label();
            this.lblPouvoir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPersonnage = new System.Windows.Forms.ListBox();
            this.grpPersonnage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVie)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonnage
            // 
            this.grpPersonnage.Controls.Add(this.btnAjouter);
            this.grpPersonnage.Controls.Add(this.rdoXmen);
            this.grpPersonnage.Controls.Add(this.rdoHumain);
            this.grpPersonnage.Controls.Add(this.cboPouvoir);
            this.grpPersonnage.Controls.Add(this.nudVie);
            this.grpPersonnage.Controls.Add(this.txtLogin);
            this.grpPersonnage.Controls.Add(this.lblVie);
            this.grpPersonnage.Controls.Add(this.lblPouvoir);
            this.grpPersonnage.Controls.Add(this.label1);
            this.grpPersonnage.Location = new System.Drawing.Point(13, 13);
            this.grpPersonnage.Name = "grpPersonnage";
            this.grpPersonnage.Size = new System.Drawing.Size(437, 158);
            this.grpPersonnage.TabIndex = 0;
            this.grpPersonnage.TabStop = false;
            this.grpPersonnage.Text = "Créer un personnage :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(294, 97);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // rdoXmen
            // 
            this.rdoXmen.AutoSize = true;
            this.rdoXmen.Location = new System.Drawing.Point(294, 71);
            this.rdoXmen.Name = "rdoXmen";
            this.rdoXmen.Size = new System.Drawing.Size(55, 17);
            this.rdoXmen.TabIndex = 8;
            this.rdoXmen.TabStop = true;
            this.rdoXmen.Text = "X-men";
            this.rdoXmen.UseVisualStyleBackColor = true;
            this.rdoXmen.CheckedChanged += new System.EventHandler(this.rdoXmen_CheckedChanged);
            // 
            // rdoHumain
            // 
            this.rdoHumain.AutoSize = true;
            this.rdoHumain.Location = new System.Drawing.Point(294, 36);
            this.rdoHumain.Name = "rdoHumain";
            this.rdoHumain.Size = new System.Drawing.Size(61, 17);
            this.rdoHumain.TabIndex = 7;
            this.rdoHumain.TabStop = true;
            this.rdoHumain.Text = "Humain";
            this.rdoHumain.UseVisualStyleBackColor = true;
            this.rdoHumain.CheckedChanged += new System.EventHandler(this.rdoHumain_CheckedChanged);
            // 
            // cboPouvoir
            // 
            this.cboPouvoir.FormattingEnabled = true;
            this.cboPouvoir.Items.AddRange(new object[] {
            "Télépathie",
            "Télékinésie",
            "Métamorphose",
            "Magnétisme",
            "Force",
            "Electrokinésie "});
            this.cboPouvoir.Location = new System.Drawing.Point(84, 68);
            this.cboPouvoir.Name = "cboPouvoir";
            this.cboPouvoir.Size = new System.Drawing.Size(100, 21);
            this.cboPouvoir.TabIndex = 6;
            // 
            // nudVie
            // 
            this.nudVie.Location = new System.Drawing.Point(84, 101);
            this.nudVie.Name = "nudVie";
            this.nudVie.Size = new System.Drawing.Size(100, 20);
            this.nudVie.TabIndex = 5;
            this.nudVie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(84, 34);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVie
            // 
            this.lblVie.AutoSize = true;
            this.lblVie.Location = new System.Drawing.Point(9, 101);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(31, 13);
            this.lblVie.TabIndex = 2;
            this.lblVie.Text = "Vie : ";
            // 
            // lblPouvoir
            // 
            this.lblPouvoir.AutoSize = true;
            this.lblPouvoir.Location = new System.Drawing.Point(7, 68);
            this.lblPouvoir.Name = "lblPouvoir";
            this.lblPouvoir.Size = new System.Drawing.Size(52, 13);
            this.lblPouvoir.TabIndex = 1;
            this.lblPouvoir.Text = "Pouvoir : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // lstPersonnage
            // 
            this.lstPersonnage.FormattingEnabled = true;
            this.lstPersonnage.Location = new System.Drawing.Point(13, 177);
            this.lstPersonnage.Name = "lstPersonnage";
            this.lstPersonnage.Size = new System.Drawing.Size(437, 251);
            this.lstPersonnage.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.lstPersonnage);
            this.Controls.Add(this.grpPersonnage);
            this.Name = "Form1";
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPersonnage.ResumeLayout(false);
            this.grpPersonnage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonnage;
        private System.Windows.Forms.NumericUpDown nudVie;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblVie;
        private System.Windows.Forms.Label lblPouvoir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.RadioButton rdoXmen;
        private System.Windows.Forms.RadioButton rdoHumain;
        private System.Windows.Forms.ComboBox cboPouvoir;
        private System.Windows.Forms.ListBox lstPersonnage;
    }
}

