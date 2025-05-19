using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalerieDePhotos
{
    public partial class Form1 : Form
    {
        //Variable globale qui pourra être utiliser a dans plusieur modules
        //Propriété 
        private string dossier; //Permet de recuperer le chemin pour acceder au dossier 

        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Clic sur btnDossier
         * Permet de selectionner un dossier sur le disque et remplire la liste avec les fichier du dossier 
         */

        private void btnDossier_Click(object sender, EventArgs e)
        {
            //Boite de dialogue pour selection du dossier 
            FolderBrowserDialog rechercheDossier = new FolderBrowserDialog();

            //Changer le titre de la fenetre qui va s'ouvrire
            rechercheDossier.Description = "Selectionner un dossier de photo"; 

            //Affiche la fenetre + la possibiliter de choisir un dossier + Recuperer le resultat de la selection de l'utilisateur dans une variable de type "DialogueResult"
            DialogResult choix = rechercheDossier.ShowDialog();

            //Dans la fenetre qui s'affiche l'utilisateur peut selectionner "Ok" ou "Annuler"
            //Verification si un dossier est selectionner, on verifier si l'utilisateur a clique sur "OK"
            if (choix == DialogResult.OK) 
            {
                //Recuperer le chemin pour acceder au dossier et le stocke dans la variable globale dossier
                dossier = rechercheDossier.SelectedPath;

                //Boucle sur les fichier contenue dans le dossier selectionner par l'utilisateur afin de les recuperer un par un et les mettre dans ma liste 
                lstPhoto.Items.Clear(); //Vider la liste des précédent éléments 

                //Boucle sur une collection, un ensemble de fichier contenue dans un dossier ...
                foreach (string fichier in System.IO.Directory.GetFiles(dossier)) //A chaque tour de boucle on recupere dans une variable string le nom du fichier + "in" permettant d'indiquer ou rezcherche les éléments 
                { 
                    string nom = System.IO.Path.GetFileName(fichier); // Recupere le nom du fichier 
                    lstPhoto.Items.Add(nom); //Ajoute le nom du fichier dans la liste 
                }

                //La liste est maintenant remplis des nom des fichier contenue dans le dossier 

                //Selectrion et afficher par défaut du premiere éléments de la liste 
                if(lstPhoto.Items.Count > 0)//Verification si le dosssier contient bien des fichier 
                {
                    lstPhoto.SelectedIndex = 0; //Selection du premier éléments de la liste 

                    //Appelle de la fonction ci-dessous permettant d'afficher l'image si le fichier selectionner est bien une image (lstPhoto_SelectedIndexChanged) 
                    lstPhoto_SelectedIndexChanged(null, null); 
                }



            }
        }

        /**
         * Changement de selection dans lstPhoto
         * Afficher la photo si possible 
         */
        private void lstPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verification que le fichier selectionner est une image ou non
            try
            {
                //Recuperer le nom du fichier et le chemin 
                string fichier = dossier + "\\" + lstPhoto.SelectedItem;

                //Affichage de l'image dans le champs de l'image de pctPhoto
                pctPhoto.Image = Image.FromFile(fichier);
            }
            catch (Exception ex)
            {
                //Si fichier selectionner n'est pas une image, vider le champs de l'image 
                pctPhoto.Image = null; 
            }

        }

        /**
         * Clic de btnRotation
         * Permets de faire pivoter l'image 
         */

        private void btnRotation_Click(object sender, EventArgs e)
        {
            //Verifier si la rotation est possible
            try
            {
                //Rotation de l'image 
                pctPhoto.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

                //Rafraichire l'affichage
                pctPhoto.Refresh();
            }
            catch (Exception ex) 
            {
                //Si la rotation est impossible ne rien faire
            }
        }
    }
}
