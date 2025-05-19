using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoidsIdeal
{
    public partial class CREFF : Form
    {
        public CREFF()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /**
         * Chargement de la fenetre 
         * fixer la date maximum a aujourd'hui
         */

        private void CREFF_Load(object sender, EventArgs e)
        {
            //Fixer la date max a aujourd'hui
            dtpNaiss.MaxDate = DateTime.Today;
        }
        /**
         * clic sur le boutton calculer
         * calcul du poid ideal
         */

        private void cmdCalcul_Click(object sender, EventArgs e)
        {

            //Etape 1 : recuperer la taille de l'utilisateur 
            //Controle du forma corecte de la taille 
            try
            {
                int taille = int.Parse(txtTaille.Text);

                //Etape 2 : calcule de l'age de l'utilisateur, différence entre date aujourd'hui et date de naissance 
                int nbJours = (DateTime.Today - dtpNaiss.Value.Date).Days; //nombre de jours entre les 2 dates
                int age = nbJours / 365;

                //Etape 3 : calculer le poids ideale
                float poids = (taille - 100 + (age / 10)) * 0.9f;

                //Etape 4 : prendre en compte la morphologie de l'utilisateur
                if (grbGracile.Checked) //Si gracile est selectionner enlever 10% au poid de l'utilisateur
                {
                    poids = poids * 0.9f;
                }
                else
                {
                    if(grbLarge.Checked) //Si large est selectionner rajouter 10% au poid de l'utilisateur
                    {
                        poids = poids * 1.1f;
                    }
                }

                //Etape 5 : affichage du poid ideale 
                txtPoidsIdeal.Text = poids.ToString();
            }
            catch(Exception ex)
            {
                //Erreur du format de saisie de la taille 
                txtTaille.Text = ""; //Effacer le contenue 
                txtTaille.Focus(); //Replacer le cursseur dessus
            }

            
        }
        /**
         * Changement de taille
         * annule le calcule du poid ideal
         */

        private void txtTaille_TextChanged(object sender, EventArgs e)
        {
            txtPoidsIdeal.Text = ""; //Vider le champs
        }

        /**
        * Changement de date
        * annule le calcule du poid ideal
        */
        private void dtpNaiss_ValueChanged(object sender, EventArgs e)
        {
            txtPoidsIdeal.Text = ""; //Vider le champs
        }

        /**
        * Changement de morphologie en gracile
        * annule le calcule du poid ideal
        */
        private void grbGracile_CheckedChanged(object sender, EventArgs e)
        {
            txtPoidsIdeal.Text = ""; //Vider le champs
        }

        /**
        * Changement de morphologie en normale
        * annule le calcule du poid ideal
        */
        private void grbNormale_CheckedChanged(object sender, EventArgs e)
        {
            txtPoidsIdeal.Text = ""; //Vider le champs
        }

        /**
        * Changement de morphologie en large
        * annule le calcule du poid ideal
        */
        private void grbLarge_CheckedChanged(object sender, EventArgs e)
        {
            txtPoidsIdeal.Text = ""; //Vider le champs
        }
    }
}
