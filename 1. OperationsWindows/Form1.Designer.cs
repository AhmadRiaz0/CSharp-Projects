namespace OperationsWondows
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtValeur1 = new System.Windows.Forms.TextBox();
            this.txtValeur2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(303, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 61);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValeur1
            // 
            this.txtValeur1.Location = new System.Drawing.Point(63, 33);
            this.txtValeur1.Name = "txtValeur1";
            this.txtValeur1.Size = new System.Drawing.Size(220, 20);
            this.txtValeur1.TabIndex = 1;
            this.txtValeur1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur1.TextChanged += new System.EventHandler(this.txtValeur1_TextChanged);
            // 
            // txtValeur2
            // 
            this.txtValeur2.Location = new System.Drawing.Point(63, 69);
            this.txtValeur2.Name = "txtValeur2";
            this.txtValeur2.Size = new System.Drawing.Size(219, 20);
            this.txtValeur2.TabIndex = 2;
            this.txtValeur2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur2.TextChanged += new System.EventHandler(this.txtValeur2_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(64, 133);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(219, 20);
            this.txtResult.TabIndex = 3;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(12, 63);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(30, 31);
            this.lblOperation.TabIndex = 5;
            this.lblOperation.Text = "+";
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(303, 107);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 61);
            this.btnMult.TabIndex = 6;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Image = global::OperationsWondows.Properties.Resources.icons8_quitter_48;
            this.btnQuitter.Location = new System.Drawing.Point(384, 107);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 61);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Image = global::OperationsWondows.Properties.Resources.icons8_gomme_40;
            this.btnEffacer.Location = new System.Drawing.Point(384, 33);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 61);
            this.btnEffacer.TabIndex = 7;
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 175);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValeur2);
            this.Controls.Add(this.txtValeur1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Opérations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtValeur1;
        private System.Windows.Forms.TextBox txtValeur2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnQuitter;
    }
}

