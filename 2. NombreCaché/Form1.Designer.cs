namespace Nombre_Caché
{
    partial class frmNombreCache
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpValeur = new System.Windows.Forms.GroupBox();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.grpReponse = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpValeur.SuspendLayout();
            this.grpReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Image = global::Nombre_Caché.Properties.Resources.icons8_off_48;
            this.btnQuitter.Location = new System.Drawing.Point(297, 102);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 64);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = global::Nombre_Caché.Properties.Resources.icons8_redémarrer_48;
            this.btnRejouer.Location = new System.Drawing.Point(297, 32);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(75, 64);
            this.btnRejouer.TabIndex = 0;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(205, 20);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(39, 37);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "OK";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // grpValeur
            // 
            this.grpValeur.Controls.Add(this.txtValeur);
            this.grpValeur.Controls.Add(this.btnValider);
            this.grpValeur.Location = new System.Drawing.Point(30, 32);
            this.grpValeur.Name = "grpValeur";
            this.grpValeur.Size = new System.Drawing.Size(261, 64);
            this.grpValeur.TabIndex = 0;
            this.grpValeur.TabStop = false;
            this.grpValeur.Enter += new System.EventHandler(this.grpValeur_Enter);
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(6, 29);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(184, 20);
            this.txtValeur.TabIndex = 0;
            this.txtValeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur.TextChanged += new System.EventHandler(this.txtValeur_TextChanged);
            this.txtValeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValeur_KeyPress);
            // 
            // grpReponse
            // 
            this.grpReponse.Controls.Add(this.lblMessage);
            this.grpReponse.Location = new System.Drawing.Point(30, 102);
            this.grpReponse.Name = "grpReponse";
            this.grpReponse.Size = new System.Drawing.Size(261, 64);
            this.grpReponse.TabIndex = 6;
            this.grpReponse.TabStop = false;
            this.grpReponse.Text = "Essai n°1";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(26, 26);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            this.lblMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmNombreCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 205);
            this.Controls.Add(this.grpReponse);
            this.Controls.Add(this.grpValeur);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRejouer);
            this.Name = "frmNombreCache";
            this.Text = "Nombre caché";
            this.Load += new System.EventHandler(this.frmNombreCache_Load);
            this.grpValeur.ResumeLayout(false);
            this.grpValeur.PerformLayout();
            this.grpReponse.ResumeLayout(false);
            this.grpReponse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox grpValeur;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.GroupBox grpReponse;
        private System.Windows.Forms.Label lblMessage;
    }
}

