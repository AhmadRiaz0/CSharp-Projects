namespace PoidsIdeal
{
    partial class CREFF
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
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.dtpNaiss = new System.Windows.Forms.DateTimePicker();
            this.txtPoidsIdeal = new System.Windows.Forms.TextBox();
            this.gpbMorphologie = new System.Windows.Forms.GroupBox();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lblDateNaiss = new System.Windows.Forms.Label();
            this.lblPoidsIdeal = new System.Windows.Forms.Label();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.grbGracile = new System.Windows.Forms.RadioButton();
            this.grbNormale = new System.Windows.Forms.RadioButton();
            this.grbLarge = new System.Windows.Forms.RadioButton();
            this.gpbMorphologie.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(173, 31);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(200, 20);
            this.txtTaille.TabIndex = 0;
            this.txtTaille.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaille.TextChanged += new System.EventHandler(this.txtTaille_TextChanged);
            // 
            // dtpNaiss
            // 
            this.dtpNaiss.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNaiss.Location = new System.Drawing.Point(173, 80);
            this.dtpNaiss.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNaiss.Name = "dtpNaiss";
            this.dtpNaiss.Size = new System.Drawing.Size(200, 20);
            this.dtpNaiss.TabIndex = 1;
            this.dtpNaiss.ValueChanged += new System.EventHandler(this.dtpNaiss_ValueChanged);
            // 
            // txtPoidsIdeal
            // 
            this.txtPoidsIdeal.Enabled = false;
            this.txtPoidsIdeal.Location = new System.Drawing.Point(173, 257);
            this.txtPoidsIdeal.Name = "txtPoidsIdeal";
            this.txtPoidsIdeal.Size = new System.Drawing.Size(200, 20);
            this.txtPoidsIdeal.TabIndex = 2;
            this.txtPoidsIdeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gpbMorphologie
            // 
            this.gpbMorphologie.Controls.Add(this.grbLarge);
            this.gpbMorphologie.Controls.Add(this.grbNormale);
            this.gpbMorphologie.Controls.Add(this.grbGracile);
            this.gpbMorphologie.Location = new System.Drawing.Point(99, 132);
            this.gpbMorphologie.Name = "gpbMorphologie";
            this.gpbMorphologie.Size = new System.Drawing.Size(226, 74);
            this.gpbMorphologie.TabIndex = 3;
            this.gpbMorphologie.TabStop = false;
            this.gpbMorphologie.Text = "Morphologie";
            this.gpbMorphologie.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(86, 38);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(70, 13);
            this.lblTaille.TabIndex = 4;
            this.lblTaille.Text = "Taille (en cm)";
            // 
            // lblDateNaiss
            // 
            this.lblDateNaiss.AutoSize = true;
            this.lblDateNaiss.Location = new System.Drawing.Point(86, 86);
            this.lblDateNaiss.Name = "lblDateNaiss";
            this.lblDateNaiss.Size = new System.Drawing.Size(81, 13);
            this.lblDateNaiss.TabIndex = 5;
            this.lblDateNaiss.Text = "Date naissance";
            // 
            // lblPoidsIdeal
            // 
            this.lblPoidsIdeal.AutoSize = true;
            this.lblPoidsIdeal.Location = new System.Drawing.Point(86, 260);
            this.lblPoidsIdeal.Name = "lblPoidsIdeal";
            this.lblPoidsIdeal.Size = new System.Drawing.Size(59, 13);
            this.lblPoidsIdeal.TabIndex = 6;
            this.lblPoidsIdeal.Text = "Poids Idéal";
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Location = new System.Drawing.Point(173, 221);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcul.TabIndex = 7;
            this.cmdCalcul.Text = "Calculer";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // grbGracile
            // 
            this.grbGracile.AutoSize = true;
            this.grbGracile.Location = new System.Drawing.Point(20, 35);
            this.grbGracile.Name = "grbGracile";
            this.grbGracile.Size = new System.Drawing.Size(58, 17);
            this.grbGracile.TabIndex = 0;
            this.grbGracile.Text = "Gracile";
            this.grbGracile.UseVisualStyleBackColor = true;
            this.grbGracile.CheckedChanged += new System.EventHandler(this.grbGracile_CheckedChanged);
            // 
            // grbNormale
            // 
            this.grbNormale.AutoSize = true;
            this.grbNormale.Checked = true;
            this.grbNormale.Location = new System.Drawing.Point(85, 35);
            this.grbNormale.Name = "grbNormale";
            this.grbNormale.Size = new System.Drawing.Size(64, 17);
            this.grbNormale.TabIndex = 1;
            this.grbNormale.TabStop = true;
            this.grbNormale.Text = "Normale";
            this.grbNormale.UseVisualStyleBackColor = true;
            this.grbNormale.CheckedChanged += new System.EventHandler(this.grbNormale_CheckedChanged);
            // 
            // grbLarge
            // 
            this.grbLarge.AutoSize = true;
            this.grbLarge.Location = new System.Drawing.Point(156, 35);
            this.grbLarge.Name = "grbLarge";
            this.grbLarge.Size = new System.Drawing.Size(52, 17);
            this.grbLarge.TabIndex = 2;
            this.grbLarge.TabStop = true;
            this.grbLarge.Text = "Large";
            this.grbLarge.UseVisualStyleBackColor = true;
            this.grbLarge.CheckedChanged += new System.EventHandler(this.grbLarge_CheckedChanged);
            // 
            // CREFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 293);
            this.Controls.Add(this.cmdCalcul);
            this.Controls.Add(this.lblPoidsIdeal);
            this.Controls.Add(this.lblDateNaiss);
            this.Controls.Add(this.lblTaille);
            this.Controls.Add(this.gpbMorphologie);
            this.Controls.Add(this.txtPoidsIdeal);
            this.Controls.Add(this.dtpNaiss);
            this.Controls.Add(this.txtTaille);
            this.Name = "CREFF";
            this.Text = "CREFF";
            this.Load += new System.EventHandler(this.CREFF_Load);
            this.gpbMorphologie.ResumeLayout(false);
            this.gpbMorphologie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.DateTimePicker dtpNaiss;
        private System.Windows.Forms.TextBox txtPoidsIdeal;
        private System.Windows.Forms.GroupBox gpbMorphologie;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label lblDateNaiss;
        private System.Windows.Forms.Label lblPoidsIdeal;
        private System.Windows.Forms.RadioButton grbLarge;
        private System.Windows.Forms.RadioButton grbNormale;
        private System.Windows.Forms.RadioButton grbGracile;
        private System.Windows.Forms.Button cmdCalcul;
    }
}

