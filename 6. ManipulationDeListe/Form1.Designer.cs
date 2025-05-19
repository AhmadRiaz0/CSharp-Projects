namespace manipulationDeListe
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
            this.lstFichier = new System.Windows.Forms.ListBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSelection = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNbFichiers = new System.Windows.Forms.Label();
            this.lblNbSelection = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTousFichierSelectionner = new System.Windows.Forms.Button();
            this.btnFichierSelectionner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFichier
            // 
            this.lstFichier.FormattingEnabled = true;
            this.lstFichier.Location = new System.Drawing.Point(12, 90);
            this.lstFichier.Name = "lstFichier";
            this.lstFichier.Size = new System.Drawing.Size(253, 303);
            this.lstFichier.TabIndex = 0;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(144, 61);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(121, 23);
            this.btnRechercher.TabIndex = 1;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fichiers du dossier : ";
            // 
            // lstSelection
            // 
            this.lstSelection.FormattingEnabled = true;
            this.lstSelection.Location = new System.Drawing.Point(361, 90);
            this.lstSelection.Name = "lstSelection";
            this.lstSelection.Size = new System.Drawing.Size(253, 303);
            this.lstSelection.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fichiers selectionnés :";
            this.label2.Click += new System.EventHandler(this.lblFichier_Click);
            // 
            // lblNbFichiers
            // 
            this.lblNbFichiers.AutoSize = true;
            this.lblNbFichiers.Location = new System.Drawing.Point(12, 413);
            this.lblNbFichiers.Name = "lblNbFichiers";
            this.lblNbFichiers.Size = new System.Drawing.Size(35, 13);
            this.lblNbFichiers.TabIndex = 5;
            this.lblNbFichiers.Text = "label1";
            // 
            // lblNbSelection
            // 
            this.lblNbSelection.AutoSize = true;
            this.lblNbSelection.Location = new System.Drawing.Point(361, 413);
            this.lblNbSelection.Name = "lblNbSelection";
            this.lblNbSelection.Size = new System.Drawing.Size(35, 13);
            this.lblNbSelection.TabIndex = 6;
            this.lblNbSelection.Text = "label1";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::manipulationDeListe.Properties.Resources.effacer;
            this.btnClear.Location = new System.Drawing.Point(620, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 59);
            this.btnClear.TabIndex = 10;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::manipulationDeListe.Properties.Resources.supprimer;
            this.btnDelete.Location = new System.Drawing.Point(620, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 59);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTousFichierSelectionner
            // 
            this.btnTousFichierSelectionner.Image = global::manipulationDeListe.Properties.Resources.avance_rapide;
            this.btnTousFichierSelectionner.Location = new System.Drawing.Point(271, 218);
            this.btnTousFichierSelectionner.Name = "btnTousFichierSelectionner";
            this.btnTousFichierSelectionner.Size = new System.Drawing.Size(84, 59);
            this.btnTousFichierSelectionner.TabIndex = 8;
            this.btnTousFichierSelectionner.UseVisualStyleBackColor = true;
            this.btnTousFichierSelectionner.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFichierSelectionner
            // 
            this.btnFichierSelectionner.Image = global::manipulationDeListe.Properties.Resources.fleche_droite;
            this.btnFichierSelectionner.Location = new System.Drawing.Point(271, 140);
            this.btnFichierSelectionner.Name = "btnFichierSelectionner";
            this.btnFichierSelectionner.Size = new System.Drawing.Size(84, 59);
            this.btnFichierSelectionner.TabIndex = 7;
            this.btnFichierSelectionner.UseVisualStyleBackColor = true;
            this.btnFichierSelectionner.Click += new System.EventHandler(this.btnFichierSelectionner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTousFichierSelectionner);
            this.Controls.Add(this.btnFichierSelectionner);
            this.Controls.Add(this.lblNbSelection);
            this.Controls.Add(this.lblNbFichiers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.lstFichier);
            this.Name = "Form1";
            this.Text = "Fichier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFichier;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNbFichiers;
        private System.Windows.Forms.Label lblNbSelection;
        private System.Windows.Forms.Button btnFichierSelectionner;
        private System.Windows.Forms.Button btnTousFichierSelectionner;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}

