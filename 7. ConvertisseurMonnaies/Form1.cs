using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static convertisseurMonnaies.Form1;

namespace convertisseurMonnaies
{
    public partial class Form1 : Form
    {
        //Tableaux de structure 
        public struct sMonnaies
        {
            public string nom;
            public float valeur;
            public string symbole;
        }

        //Déclaration du tableaux de structure 
        private sMonnaies[] tMonnaie = new sMonnaies[6];

        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Initialisation e départ
         * permets d'initialiser le tableaux de structurepour chaque monnaie + afficher la premiere monnaie + txtEuro initialiser a 1
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialisation du tableaux de structure 

            //Dollar américain
            tMonnaie[0].nom = "Dollar américain";
            tMonnaie[0].valeur = 1.0502f;
            tMonnaie[0].symbole = "$";

            //Franc Suisse
            tMonnaie[1].nom = "Franc suisse";
            tMonnaie[1].valeur = 0.9376f;
            tMonnaie[1].symbole = "CHF";

            //Dollar australien
            tMonnaie[2].nom = "Dollar australien";
            tMonnaie[2].valeur = 1.6526f;
            tMonnaie[2].symbole = "$";

            //Roupie pakistanais
            tMonnaie[3].nom = "Roupie pakistanaise";
            tMonnaie[3].valeur = 291.6432f;
            tMonnaie[3].symbole = "Rs";

            //Riyal saoudiens
            tMonnaie[4].nom = "Riyal saoudiens";
            tMonnaie[4].valeur = 3.9417f;
            tMonnaie[4].symbole = "﷼";

            //Livre sterling
            tMonnaie[5].nom = "Livre sterling";
            tMonnaie[5].valeur = 0.8321f;
            tMonnaie[5].symbole = "£";


            //Dans le comboBox remplire les différentes nom des monnaies
            for (int i = 0; i < tMonnaie.Length; i++)
            {
                //Rajout des noms
                cboMonnaie.Items.Add(tMonnaie[i].nom);
            }

            //Selection de la premier monnaies 
            //Verification si une ligne est deja disponible dans le comboBox
            if(cboMonnaie.Items.Count > 0)
            {
                //Selection de la premier monnaies
                cboMonnaie.SelectedIndex = 0; 
            }

            //Initialiser a 1 txtEuro
            txtEuro.Text = "1";
        }

        private void txtMonnaie_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * Changement de valeur sur txtEuro
         * mise a jour du resultat de la conversion
         */
        private void txtEuro_TextChanged(object sender, EventArgs e)
        {
            //Recuperation de la saisie dans le champs txtEuro

            //Verification de la saisie 
            try
            {
                //Recuperation de la saisie dans le champs txtEuro
                float euro = float.Parse(txtEuro.Text);

                //Afficher la conversion 
                txtMonnaie.Text = (euro * float.Parse(txtValeur.Text)).ToString();

            }catch (Exception ex)
            {
                //Si saisie n'est pas bonne vider la zone de saisie 
                txtEuro.Text = "";
                //Remise du curseur dans sa zone
                txtEuro.Focus();
            }


        }

        /**
         * Changement de selection de monnaies cboMonnaies
         * Mettre a jours la valeur + le signe + la conversion
         */
        private void cboMonnaie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Affichage valeur de la monnaie
            txtValeur.Text = (tMonnaie[cboMonnaie.SelectedIndex].valeur).ToString();

            //Affichage du symbole 
            lblMonnaie.Text = (tMonnaie[cboMonnaie.SelectedIndex].symbole);

            //Mise a jour de la conversion 
            txtEuro_TextChanged(null,null);
        }
    }
}
