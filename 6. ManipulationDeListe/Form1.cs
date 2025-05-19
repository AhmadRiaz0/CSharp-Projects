using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manipulationDeListe
{
    public partial class Form1 : Form
    {
        //Déclaration de variable globale 
        private string dossier;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblFichier_Click(object sender, EventArgs e)
        {

        }

        /**
         * Clic sur le boutton double >>
         * copier de tous les noms depuis les fichier vers la selection
         */

        private void button1_Click(object sender, EventArgs e)
        {
            //Vider la liste de selection 
            lstSelection.Items.Clear();

            //Copie du nom des fichier depuis la liste de fichier vers la liste des selection 
            foreach (string ligne in lstFichier.Items)
            {
                //Rajout du nom dans la liste de selection
                lstSelection.Items.Add(ligne);
            }

            //Mise a jour des labels
            majLabelNb(); 

        }

        /*
         * Mise a jour des label des nombres 
         * Pour la gestion des label, elle aurat lieu a pliseur reprise donc on met en place une procédure spécifique pour leurs gestion
         */

        private void majLabelNb()
        { 
            //Message en dessous de la liste des fichier 
            lblNbFichiers.Text = lstFichier.Items.Count + " fichier(s) dans le dossier";

            //Message en dessous de la liste des selection 
            lblNbSelection.Text = lstSelection.Items.Count + " fichier(s) sélectionné(s)";
        }

        /**
         * Chargement de la fenetre principale 
         * mettre a jours les label 
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mise a jours des labels au chargement de départ 
            majLabelNb();
        }

        /**
         * clic sur le bontoun "Rechercher"
         * selectionner un dossier et remplire lstFichier avec le nom des fichier 
         */
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //Ouvrir une boite de dialogue pour recuperer un dossier 
            FolderBrowserDialog rechercheDossier; 

            //Création d'un objet de la boite de dialogue
            rechercheDossier = new System.Windows.Forms.FolderBrowserDialog();

            //Modification de la description 
            rechercheDossier.Description = "Selectionner un dossier";

            //Affichage de la fenetre de dilogue
            DialogResult choix = rechercheDossier.ShowDialog();

            //Si l'utilisateur a clicer sur "Ok"
            if (choix == DialogResult.OK)
            {
                //Recuperation du chemin dans "dossier"
                dossier = rechercheDossier.SelectedPath;

                //Vider lstFichier
                lstFichier.Items.Clear();

                //Faire une boucle pour remplire la liste "lstFichier"
                foreach (string fichier in System.IO.Directory.GetFiles(dossier)) // Recuperation du nom + chemin complet
                {
                    string nom = System.IO.Path.GetFileName(fichier); // Recuperation uniquement du nom du fichier
                    lstFichier.Items.Add(nom); //Affichage du nom du fichier dans la liste
                }

                // Mettre a jour le labels sous la liste des fichiers
                majLabelNb(); 
            }

        }

        /**
         * clic sur le >
         * copie du nom du fichier selectionner
         */
        private void btnFichierSelectionner_Click(object sender, EventArgs e)
        {
            //Controle si un nom est bien selectionner

            //Element selectionner dans la liste
            if (lstFichier.SelectedIndex >= 0) 
            {
                //Element deja present dans la liste de selection
                if (lstSelection.FindStringExact(lstFichier.SelectedItem.ToString()) < 0)
                {
                    //Ajout du nom du fichier dans la liste de selection
                    lstSelection.Items.Add(lstFichier.SelectedItem);

                    // Mettre a jour le labels sous la liste des fichiers
                    majLabelNb();
                }
            }
        }

        /**
         * Clic sur le boutton del
         * permet de supprimer du nom selctionner dans la liste de selection
         */

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Controle si un nom est bien selectionner 
            if(lstSelection.SelectedIndex >= 0)
            {
                //Supprimer le fichier selectionner 
                lstSelection.Items.RemoveAt(lstSelection.SelectedIndex);

                // Mettre a jour le labels sous la liste des fichiers
                majLabelNb();

            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        /**
        * Clic sur le boutton clear all
        * permet de vider toute la liste de selection
        */
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Vide la toutes la liste de selction
            lstSelection.Items.Clear();

            // Mettre a jour le labels sous la liste des fichiers
            majLabelNb();
        }
    }
}
