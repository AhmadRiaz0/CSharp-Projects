namespace tablesMultiplication
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
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.txtNb1 = new System.Windows.Forms.TextBox();
            this.txtNb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReponse = new System.Windows.Forms.TextBox();
            this.lblBonneReponse = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.grpNote = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxNote = new System.Windows.Forms.TextBox();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.grpQuestion.SuspendLayout();
            this.grpNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.btnSuivant);
            this.grpQuestion.Controls.Add(this.lblBonneReponse);
            this.grpQuestion.Controls.Add(this.txtReponse);
            this.grpQuestion.Controls.Add(this.label2);
            this.grpQuestion.Controls.Add(this.label1);
            this.grpQuestion.Controls.Add(this.txtNb2);
            this.grpQuestion.Controls.Add(this.txtNb1);
            this.grpQuestion.Location = new System.Drawing.Point(12, 12);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(232, 100);
            this.grpQuestion.TabIndex = 0;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "Question n°";
            // 
            // txtNb1
            // 
            this.txtNb1.Enabled = false;
            this.txtNb1.Location = new System.Drawing.Point(23, 37);
            this.txtNb1.Name = "txtNb1";
            this.txtNb1.Size = new System.Drawing.Size(37, 20);
            this.txtNb1.TabIndex = 0;
            this.txtNb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNb2
            // 
            this.txtNb2.Enabled = false;
            this.txtNb2.Location = new System.Drawing.Point(86, 37);
            this.txtNb2.Name = "txtNb2";
            this.txtNb2.Size = new System.Drawing.Size(37, 20);
            this.txtNb2.TabIndex = 1;
            this.txtNb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // txtReponse
            // 
            this.txtReponse.Location = new System.Drawing.Point(148, 37);
            this.txtReponse.Name = "txtReponse";
            this.txtReponse.Size = new System.Drawing.Size(58, 20);
            this.txtReponse.TabIndex = 4;
            this.txtReponse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReponse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReponse_KeyPress);
            // 
            // lblBonneReponse
            // 
            this.lblBonneReponse.AutoSize = true;
            this.lblBonneReponse.Location = new System.Drawing.Point(25, 73);
            this.lblBonneReponse.Name = "lblBonneReponse";
            this.lblBonneReponse.Size = new System.Drawing.Size(35, 13);
            this.lblBonneReponse.TabIndex = 5;
            this.lblBonneReponse.Text = "label3";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(148, 68);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 6;
            this.btnSuivant.Text = "Suivante";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpNote
            // 
            this.grpNote.Controls.Add(this.txtMaxNote);
            this.grpNote.Controls.Add(this.label4);
            this.grpNote.Controls.Add(this.txtNote);
            this.grpNote.Location = new System.Drawing.Point(12, 135);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new System.Drawing.Size(142, 63);
            this.grpNote.TabIndex = 1;
            this.grpNote.TabStop = false;
            this.grpNote.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(23, 25);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(37, 20);
            this.txtNote.TabIndex = 0;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "/";
            // 
            // txtMaxNote
            // 
            this.txtMaxNote.Enabled = false;
            this.txtMaxNote.Location = new System.Drawing.Point(86, 24);
            this.txtMaxNote.Name = "txtMaxNote";
            this.txtMaxNote.Size = new System.Drawing.Size(37, 20);
            this.txtMaxNote.TabIndex = 2;
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(160, 135);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(84, 63);
            this.btnRecommencer.TabIndex = 2;
            this.btnRecommencer.Text = "Refaire le test";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 207);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.grpNote);
            this.Controls.Add(this.grpQuestion);
            this.Name = "Form1";
            this.Text = "Table de multiplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            this.grpNote.ResumeLayout(false);
            this.grpNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Label lblBonneReponse;
        private System.Windows.Forms.TextBox txtReponse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNb2;
        private System.Windows.Forms.TextBox txtNb1;
        private System.Windows.Forms.GroupBox grpNote;
        private System.Windows.Forms.TextBox txtMaxNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnRecommencer;
    }
}

