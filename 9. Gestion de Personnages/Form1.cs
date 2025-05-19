using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public class Personnage
        {
            //Attribut
            private string login;
            private int vie;

            /**
             * Construteur 
             * Valorise le login et initialise la vie aléatoirement
             */
            public Personnage(string login) 
            {
                //Valorise le login 
                this.login = login;

                //Initialise la vie aléatoirement
                Random vieAleatoire = new Random();
                this.vie = vieAleatoire.Next(0,5);
            }

            /**
             * GETTER sur attribut vie
             */
            public int getVie()
            {
                return vie;
            }

            /**
             * SETTER sur attribut vie
             */
            public void setVie(int vie)
            {
                this.vie = vie; 
            }

            /**
             * GETTER sur attributs login
             */
            public string getLogin()
            {
                return login;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        //Tableaux de personnages
        private Personnage[] lesPersonnages = new Personnage[100];

        //Connaitre le nombre de personnage stocker dans le tableaux 
        private int nbPerso = 0;

        /**
         * Affichage login suivie de la vie ou "est mort"
         */

        private void afficheMessagePerso(Personnage unPersonnage)
        {
            if (unPersonnage.getVie() == 0)
            {
                txtPersonnageSelctionner.Text = unPersonnage.getLogin() + " est mort !";
            }
            else
            {
                txtPersonnageSelctionner.Text = unPersonnage.getLogin() + " : " + unPersonnage.getVie();
            }
        }

        /**
         * Mise a jour de la liste des perssonnage 
         */
        private void majListePerso(int ligneActive)
        {
            //Vider la liste 
            lstPersonnage.Items.Clear();    

            //Remplire la liste avec le tableaux de personnage 
            for(int i = 0; i < nbPerso; i++)
            {
                //Rajoute du login et de la vie pour chaque personnage 
                lstPersonnage.Items.Add(lesPersonnages[i].getLogin() + " (" + lesPersonnages[i].getVie() + ")" );
            }

            //Positionnement sur la ligne du personnage active
            if(lstPersonnage.Items.Count > 0 && ligneActive < nbPerso)
            {
                lstPersonnage.SelectedIndex = ligneActive;
            }
        }

        /**
         * Recherche du login correspondant a la vie max
         */
        private void recherchePersoMaxVie()
        {
            //Verifier s'il y a au moin un personnage
            if(nbPerso == 0)
            {
                txtPersonnagePlusVie.Text = "";
            }
            else
            {
                //Recherche l'indice ou se trouve la vie maximum
                int max = 0; //Permet de mémoriser l'indice

                //Recherche de la position du personnage ayant la vie la plus éléver dans le tableaux de Personnage
                for(int i = 1; i < nbPerso; i++)
                {
                    if (lesPersonnages[i].getVie() > lesPersonnages[max].getVie())
                    {
                        max = i;
                    }
                }

                txtPersonnagePlusVie.Text = lesPersonnages[max].getLogin() + " (" + lesPersonnages[max].getVie() + ")";
            }
        }
        
        /**
         * Changement de vie
         */

        private void changeViePerso(int index)
        {
            //Affichage du message perso
            afficheMessagePerso(lesPersonnages[index]);
            //Mise a jour de la liste des personnage
            majListePerso(index);
            //Affichage du personnage qui a la vie max
            recherchePersoMaxVie();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        /**
        * Saisie du login 
        * Controle de la validation, création d'un nouveaux personnage
        */
        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verification si validation 
            if(e.KeyChar == (char)Keys.Enter)
            {
                //Incrémentation du nombre de personnage 
                nbPerso++;
                //création du personnage 
                Personnage unPersonnage = new Personnage(txtLogin.Text);
                //Ajout du personnage dans le tableaux
                lesPersonnages[nbPerso - 1] = unPersonnage;
                //Mettre a jour tous les autres affichage 
                changeViePerso(nbPerso-1);
                //vider la zone de saisie et se repositionner dessus
                txtLogin.Text = "";
                txtLogin.Focus();
            }
        }

        /**
         * Selection d'une ligne dans la liste de personnage 
         */
        private void lstPersonnage_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudVie.Value = lesPersonnages[lstPersonnage.SelectedIndex].getVie();
        }

        /**
         * Changement de la vie sur nudVie
         */
        private void nudVie_ValueChanged(object sender, EventArgs e)
        {
            //Controle si une ligne est selectionner
            if (lstPersonnage.SelectedIndex >= 0)
            {
                //Recuperation du personnage selectionner
                Personnage unPersonnage = lesPersonnages[lstPersonnage.SelectedIndex];

                //Modification de la vie 
                unPersonnage.setVie((int)nudVie.Value);

                changeViePerso(lstPersonnage.SelectedIndex);
            }

        }
    }
}
