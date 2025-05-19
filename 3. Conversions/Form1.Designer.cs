namespace conversions
{
    partial class FormConvertisseur
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
            this.grpBase10 = new System.Windows.Forms.GroupBox();
            this.grpbase2 = new System.Windows.Forms.GroupBox();
            this.txtBase10 = new System.Windows.Forms.TextBox();
            this.txtBase2 = new System.Windows.Forms.TextBox();
            this.grpBase10.SuspendLayout();
            this.grpbase2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBase10
            // 
            this.grpBase10.Controls.Add(this.txtBase10);
            this.grpBase10.Location = new System.Drawing.Point(37, 23);
            this.grpBase10.Name = "grpBase10";
            this.grpBase10.Size = new System.Drawing.Size(327, 59);
            this.grpBase10.TabIndex = 0;
            this.grpBase10.TabStop = false;
            this.grpBase10.Text = "groupBox1";
            // 
            // grpbase2
            // 
            this.grpbase2.Controls.Add(this.txtBase2);
            this.grpbase2.Location = new System.Drawing.Point(37, 96);
            this.grpbase2.Name = "grpbase2";
            this.grpbase2.Size = new System.Drawing.Size(327, 63);
            this.grpbase2.TabIndex = 0;
            this.grpbase2.TabStop = false;
            this.grpbase2.Text = "groupBox2";
            // 
            // txtBase10
            // 
            this.txtBase10.Location = new System.Drawing.Point(6, 20);
            this.txtBase10.Name = "txtBase10";
            this.txtBase10.Size = new System.Drawing.Size(315, 20);
            this.txtBase10.TabIndex = 0;
            this.txtBase10.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBase2
            // 
            this.txtBase2.Location = new System.Drawing.Point(6, 19);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.Size = new System.Drawing.Size(315, 20);
            this.txtBase2.TabIndex = 0;
            this.txtBase2.TextChanged += new System.EventHandler(this.txtBase2_TextChanged);
            // 
            // FormConvertisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 171);
            this.Controls.Add(this.grpbase2);
            this.Controls.Add(this.grpBase10);
            this.Name = "FormConvertisseur";
            this.Text = "Convertisseur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBase10.ResumeLayout(false);
            this.grpBase10.PerformLayout();
            this.grpbase2.ResumeLayout(false);
            this.grpbase2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBase10;
        private System.Windows.Forms.TextBox txtBase10;
        private System.Windows.Forms.GroupBox grpbase2;
        private System.Windows.Forms.TextBox txtBase2;
    }
}

