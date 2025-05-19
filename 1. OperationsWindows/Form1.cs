using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationsWondows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
        * Clique sur le bouton "+" et permets de rejouter les nombres
        */

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (float.Parse(txtValeur1.Text) + float.Parse(txtValeur2.Text)).ToString(); //Convertire les valeur en float et addition + tous convertire en string
                lblOperation.Text = "+"; //Lors de l'appuis sur le boutton "+" le label affiche "+" 
            }
            catch(Exception exception)
            {
                // .... //Code a effectuer si on trouve une erreur dans le try, si aucun code le programme ne plante pas
            }
        }
        /**
         * Changement de txtValeur1
         * Vider le resultat
         */

        private void txtValeur1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        /**
        * Changement de txtValeur2
        * Vider le resultat
        */
        private void txtValeur2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        /**
        * Clique sur le bouton "x" et permets de rejouter les nombres
        */

        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (float.Parse(txtValeur1.Text) * float.Parse(txtValeur2.Text)).ToString(); //Convertire les valeur en float et multiplication + tous convertire en string
            lblOperation.Text = "x"; //Lors de l'appuis dur le boutton "x" le label affiche "x" 
            }
            catch (Exception exception)
            {
                // .... //Code a effectuer si on trouve une erreur dans le try, si aucun code le programme ne plante pas
            }
        }

        /**
         *Clique sur le bouton "gomme" et permets d'effacer les nombres
         */

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtValeur1.Text = ""; //Remplace les champs par un espace vide
            txtValeur2.Text = ""; //Remplace les champs par un espace vide
            txtResult.Text = ""; //Remplace les champs par un espace vide

        }

        /**
         * Clique sur le bouton "quitter" et permets de quitter l'application
         */

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Permets de quitter application
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
