namespace GalerieDePhotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstPhoto = new System.Windows.Forms.ListBox();
            this.btnDossier = new System.Windows.Forms.Button();
            this.btnRotation = new System.Windows.Forms.Button();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPhoto
            // 
            this.lstPhoto.FormattingEnabled = true;
            this.lstPhoto.HorizontalScrollbar = true;
            this.lstPhoto.Location = new System.Drawing.Point(12, 12);
            this.lstPhoto.Name = "lstPhoto";
            this.lstPhoto.Size = new System.Drawing.Size(178, 329);
            this.lstPhoto.TabIndex = 0;
            this.lstPhoto.SelectedIndexChanged += new System.EventHandler(this.lstPhoto_SelectedIndexChanged);
            // 
            // btnDossier
            // 
            this.btnDossier.Image = ((System.Drawing.Image)(resources.GetObject("btnDossier.Image")));
            this.btnDossier.Location = new System.Drawing.Point(12, 363);
            this.btnDossier.Name = "btnDossier";
            this.btnDossier.Size = new System.Drawing.Size(80, 80);
            this.btnDossier.TabIndex = 1;
            this.btnDossier.UseVisualStyleBackColor = true;
            this.btnDossier.Click += new System.EventHandler(this.btnDossier_Click);
            // 
            // btnRotation
            // 
            this.btnRotation.Image = ((System.Drawing.Image)(resources.GetObject("btnRotation.Image")));
            this.btnRotation.Location = new System.Drawing.Point(110, 363);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(80, 80);
            this.btnRotation.TabIndex = 2;
            this.btnRotation.UseVisualStyleBackColor = true;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(213, 12);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(431, 431);
            this.pctPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPhoto.TabIndex = 3;
            this.pctPhoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.pctPhoto);
            this.Controls.Add(this.btnRotation);
            this.Controls.Add(this.btnDossier);
            this.Controls.Add(this.lstPhoto);
            this.Name = "Form1";
            this.Text = "Gallerie Photo";
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPhoto;
        private System.Windows.Forms.Button btnDossier;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.PictureBox pctPhoto;
    }
}

