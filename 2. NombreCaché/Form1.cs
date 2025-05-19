using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nombre_Caché
{
    public partial class frmNombreCache : Form
    {
        //Déclaration d'une variable globale
        private int valeurAChercher; //Stocker la saisie du nombre a trouver par l'utilisateur 
        private int nbEssai; //Stocker la saisie des essaie par l'utilisateur 
        private int phase; //represente les différents utilisateur (1 : utilisateur qui saisie le nombre // 2 : utilisateur qui saisie les essais)

 

        public frmNombreCache()
        {
            InitializeComponent();
        }

        /**
        * Procedure non événementiel 1 : Permet de vider la zone de saisie et permet de repositionner le cursseur 
        */
        private void efface()
        {
            txtValeur.Text = " "; //Permet d'effacer la zone de saisie
            txtValeur.Focus(); //Le cursseur se positionne sur l'élément graphique (ici la zone de saisie)

        }

        /**
         * Procedure non événementiel 2 : Initialisation d'un nouveau jeux
         */
        private void init()
        {
            phase = 1; //L'utilisateur 1 est en train d'utiliser l'application (il prend la main)
            grpValeur.Text = "Valeur (entre 1 et 100)"; //Le texte du groupe box est initialiser
            grpReponse.Visible = false; //Le second groupeBox est invisible
            grpValeur.Enabled = true; //Permet de pouvoir acceder a nouveaux a la zone de saisie 
            efface(); //Efface la zone de texte + mettre le cursseur dans la zone de texte
        }


        /**
         * Clicque sur le boutton "rejouer" : pour rendre invisible le 2e groupBox + repasser essai a "0" + se repositionner dans la zone de texte + reinitialiser le texte du 1er groupbox
         */

        private void button1_Click(object sender, EventArgs e)
        {
            init(); //Appelle du module pour initialiser le jeux 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValeur_TextChanged(object sender, EventArgs e)
        {

        }

        /**
        * Clique sur le bouton "OK" : soit phase 1 (saisie) ou phase 2 (essai)
        * Phase 1 (saisie) : controle si le nombre saisie est bien entre 1 et 100 + passage en phase 2
        * Phase 2 (essai) :  controle de l'eassai et affichage des messages
        */
        private void btnValider_Click(object sender, EventArgs e)
        {
            //Si utilisateur na pas saisie un nombre 
            try
            {
                int valeur = int.Parse(txtValeur.Text);//Recuperer la valeur saisie 
                //controle de la valeur (entre 1 et 100)
                if(valeur >= 1 && valeur <= 100)
                {
                    //Test sur la phase du jeux 
                    if(phase == 1)
                    {
                        //Le premier joueur a saisie la valeur 
                        valeurAChercher = valeur; // Tous les teste on était effectuer donc on peut stocker la valeur saisie dans la variable globale 
                        phase = 2; // Passage au joueur 2 (essai)
                        nbEssai = 0; //Contient le nombre d'essai
                        grpValeur.Text = "Essai (entre 1 et 100)"; //Modification du message du textbox
                        efface(); //Supprimer et repositionner le curseur dans la zone de texte

                    }
                    else
                    {
                        //Le seconde joueur a saisie un essai
                        if (valeur == valeurAChercher) //Test Si le joueur a trouver la bonne valeur 
                        {
                            lblMessage.Text = "Bravo ! c'était bien : " + valeurAChercher; //Affichage du message de victoire dans le 2e groupBox
                            efface();//Saisie incorecte : effacer la zone de texte et remettre le cursseur dans la zone de texte
                            btnRejouer.Focus(); //mettre le focus sur le boutton rejouer
                            grpValeur.Enabled = false; // La zone de saisie ne peu plus être utiliser


                        }
                        else
                        {
                            if(valeur > valeurAChercher) //Test de comparaison de la valeur saisie 
                            {
                                lblMessage.Text = "La valeur saisie est " + valeur + " : Trop grand ! "; //Si la valeur est trop grande
                            }
                            else
                            {
                                lblMessage.Text = "La valeur saisie est " + valeur + " : Trop petit ! "; //Si la valeur est trop petite
                            }

                            efface();//Saisie incorecte : effacer la zone de texte et remettre le cursseur dans la zone de texte

                        }

                        //Affichage du message finale et du nombre d'essai
                        nbEssai++; //A chaque essai on incrémente le nombre d'eesai
                        grpReponse.Text = "Essai n° : " + nbEssai; //Affichage du nombre d'essai réaliser par l'utilisateur
                        grpReponse.Visible = true; //Affichage du second groupBox
                    }
                }
                else
                {
                   efface();//Saisie incorecte : effacer la zone de texte et remettre le cursseur dans la zone de texte
                }

                //efface(); //Supprimer et repositionner le curseur dans la zone de texte

            }
            catch (Exception ex)
            {
                efface();//Saisie incorecte : effacer la zone de texte et remettre le cursseur dans la zone de texte
            }

        }

        /**
         *Modification du texte afficher sur le groupeBox Valeur pour demander de saisir un nombre entre 1 et 100
         */
        private void grpValeur_Enter(object sender, EventArgs e)
        {
        }

        /**
        * Chargement de la fenetre : initialisation des élément pour le démarrage de la phase 1 (utilisateur 1)
        */

        private void frmNombreCache_Load(object sender, EventArgs e)
        {
            init(); //Appelle du module pour initialiser le jeux 
        }


        /**
        * Appuier sur boutton "quitter" pour fermer la fenetre
        */
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Permet de fermer la fenetre 
        }

        /**
         * Saisie d'une touche dans la zone de saisie : idem que clique sur "ok" si validation
         */
        private void txtValeur_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Le paramètre "e" de "KeyPressEventArgs" contient le code de la touche présser
            if(e.KeyChar == (char)Keys.Return) //Si la touche presser du clavier est "Entrer" + transtipage de la touche presser en "char"
            {
                //Applle d'une procédure (non événementiel) depuis une autre procédure (événementiel)
                btnValider_Click(null, null); // appelle du module lorsque je clique sur "ok" qui va être executer lorsque je vais appuier sur "Entrer"
            }
        }
    }
}
