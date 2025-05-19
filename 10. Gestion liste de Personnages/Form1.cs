using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PolymorphismeAbstraction.Form1;

namespace PolymorphismeAbstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Attribut
        //Création d'un tableaux de type Personnage
        private Personnage[] lesPersonnages = new Personnage[100];
        //Savoir combien de case sont remplie 
        private int nbPerso = 0;


        /**
         * Super-Classe Personnage abstraite
         */
        public abstract class Personnage
        {
            //Attributs
            protected string login = "inconnu";

            //Constructeur 1 : vide
            public Personnage()
            {

            }

            //Constructeur 2 : Initialise le login
            public Personnage(string login)
            {
                this.login = login;
            }

            //Méthode abstraite : qui doit être définis dans les Sous-Classe
            public abstract string info();
        }



        /**
         * Sous-CLasse Humain qui hérite de la Super-Classe Personnage
         */
        public class Humain : Personnage
        {
            //Attributs
            private int vie;

            //Constructeur 1 : initialise la vie
            public Humain(int vie)
            {
                this.vie = vie;
            }

            //Constructeur 2 : qui fait appeller au constructeur "Constructeur 2 : Personnage(string login)" du constructeur + initialise la vie
            public Humain(string login, int vie) : base(login)
            {
                this.vie=vie;
            }

            //Overreading : definition de la méthode abstraite présente dans la Super-Classe, pour retourner le login + la vie
            public override string info()
            {
                return "Humain : " + login + " (" + vie + ")";
            }
        }


        /**
         * Sous-CLasse Xmen qui hérite de la Super-Classe Personnage
         */
        public class Xmen : Personnage
        {
            //Attribue 
            private string pouvoir;

            //Constructeur 1 : intialise le pouvoir 
            public Xmen(string pouvoir) 
            { 
                this.pouvoir = pouvoir;
            }

            //Constructeur 2 : qui fait appeller au constructeur "Constructeur 2 : Personnage(string login)" du constructeur + initialise le pouvoir
            public Xmen(string login, string pouvoir) : base(login)
            {
                this.pouvoir=pouvoir;
            }


            //Overreading : definition de la méthode abstraite présente dans la Super-Classe, pour retourner le login + le pouvoir
            public override string info()
            {
                return "X-men : " + login + " (" + pouvoir + ")";
            }

        }


        //Méthode non événementiel : pour la gestion de la visibilité des éléments selon le choix entre "Humain" et "Xmen"
        public void changeVisible(bool humain)
        {
            //Disparition de lblPouvoir
            lblPouvoir.Visible = !humain;

            //Disparition de cmbPouvoir
            cboPouvoir.Visible = !humain;

            //Visibilité de lblVie
            lblVie.Visible = humain;

            //Visibilité de nudVie
            nudVie.Visible = humain;
        }

        //Méthode non événementiel : mise a jour de la liste a partire du tableaux 
        private void majListe()
        {
            //Vider la liste
            lstPersonnage.Items.Clear();

            //remplire la liste avec la méthode info()
            for(int k = 0; k < nbPerso; k++)
            {
                lstPersonnage.Items.Add(lesPersonnages[k].info());
            }
        }


        /**
         * Selection du Radio Button Humain 
         * Disparition de : lblPouvoir + cmbPouvoir 
         */
        private void rdoHumain_CheckedChanged(object sender, EventArgs e)
        {
            changeVisible(true);
        }


        /**
        * Selection du Radio Button Xmen 
        * Disparition de : lblPouvoir + cmbPouvoir 
        */
        private void rdoXmen_CheckedChanged(object sender, EventArgs e)
        {
            changeVisible(false);
        }

        /**
         * Chargement de la fnetre principale
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            //Selection du boutton humain par defaut
            rdoHumain.Checked = true;
            //Affichage des éléments graphique en cnséquence du clic sur le boutton humain
            changeVisible(true);
            //Selection d'un éléments dans le combot pardefaut
            cboPouvoir.SelectedIndex = 0;
            //Positionner sur la zone de texte du login 
            txtLogin.Focus();
        }

        /**
         * clic sur boutton ajouter
         */

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //Incrémentation du nombre de personnage 
            nbPerso++;

            //Savoir si le personnage est un humain ou un xmen
            //Le personnage est un humain
            if (rdoHumain.Checked)
            {
                //Verification si un login est saisie par utilisateur 
                if(txtLogin.Text == "") 
                {
                    //Login non saisie : utisation Constructeur 1
                    lesPersonnages[nbPerso - 1] = new Humain((int)nudVie.Value);
                }
                else
                {
                    //Login saisie : utisation Constructeur 2
                    lesPersonnages[nbPerso - 1] = new Humain(txtLogin.Text, (int)nudVie.Value);
                }
            }
            //Le personnage est un Xmen
            else
            {
                //Verification si un login est saisie par utilisateur 
                if(txtLogin.Text == "") 
                {
                    //Login non saisie : : utisation Constructeur 1
                    lesPersonnages[nbPerso - 1] = new Xmen(cboPouvoir.SelectedItem.ToString());
                }
                else
                {
                    //Login saisie : : utisation Constructeur 2
                    lesPersonnages[nbPerso - 1] = new Xmen(txtLogin.Text, cboPouvoir.SelectedItem.ToString());
                }
            }

            //Mise a jour de la liste des personnage
            majListe();

            //Repositionnement sur login
            txtLogin.Text = "";
            txtLogin.Focus();



        }
    }
}
