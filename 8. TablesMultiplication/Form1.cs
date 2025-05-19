using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tablesMultiplication
{
    public partial class Form1 : Form
    {
        //Attributs de la classe
        private int nbQuestion = 20; //Nombre de question total
        private int numQuestion; //Numero de la question en cour
        private int note; // Note qui évolue au fure et a mesure de la question

        public Form1()
        {
            InitializeComponent();
        }

        //Procédure non événementiel pour lancer une nouvelle question 
        private void nouvelleQuestion()
        {
            //Desactiver le boutton "Suivante"
            btnSuivant.Enabled = false;

            //Incrémentation du compteur de question 
            numQuestion ++;

            //Affichage du compteur de question au nioveau du texteBox Question 
            grpQuestion.Text = "Question n° : " + numQuestion.ToString() + " / " + nbQuestion.ToString();

            //Vider la zone de saisie
            txtReponse.Text = "";

            //Mettre la couleur de la zone de saisie a "blanc" vide
            txtReponse.BackColor = Color.Empty;
            
            //Fair disparaitre la bonne reponse precedentes
            lblBonneReponse.Visible = false;

            //Initialisation des 2 nombren aléatoires entre 1 et 9
            Random nbAlea = new Random();
            
            //Mise en place du nombre aléatoire dans le txtnb1
            txtNb1.Text = nbAlea.Next(1, 9).ToString();

            //Mise en place du nombre aléatoire dans le txtnb2
            txtNb2.Text = nbAlea.Next(1, 9).ToString();

            //Position du cursseur pour saisir la reponse
            txtReponse.Focus();


        }


        //Procédure non événementiel pour recommencer le test 
        private void nouveauTest()
        {
            //Initialisation des attributs
            numQuestion = 0;
            note = 0;

            //Initialisation des éléments graphique txtNote
            txtNote.Text = note.ToString();

            //Initialisation des éléments graphique txtMaxNote
            txtMaxNote.Text = numQuestion.ToString();

            //Lancer une nouvelle question 
            nouvelleQuestion();
        }

        /**
         * Chargement de la fenetre principale 
         * Demmarrage d'un nouveaux teste 
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            //Procédure non événementiel pour recommencer un test
            nouveauTest();
        }

        /**
         * Clique sur button "Refair un test"
         * Demmarrage d'un nouveaux test
         */
        private void button2_Click(object sender, EventArgs e)
        {
            //Procédure non événementiel pour recommencer un test
            nouveauTest();
        }

        /**
         * Clic sur le boutton "Suivante"
         * permet de lancer une nouvelle question
         */
        private void button1_Click(object sender, EventArgs e)
        {
            //Lancer une nouvelle question 
            nouvelleQuestion();
        }

        /**
         * Toucher presser sur la reponse 
         * si validation , on controle la reponse  et passage a la question suivante
         */
        private void txtReponse_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifier si la toucher "valider" est utilisée
            if(e.KeyChar == (char)Keys.Enter)
            {
                //calcul de la bonne reponse pour la comparer avec la saisie de l'utilisateur 
                int bonneReponse = int.Parse(txtNb1.Text) * int.Parse(txtNb2.Text);

                //Verification de la reponse
                //Bonne reponse
                if(txtReponse.Text == bonneReponse.ToString())
                {
                    //Passage a la couleur verte
                    txtReponse.BackColor = Color.LightGreen;

                    //Incrementer la note 
                    note++;
                }
                //Mauvaise reponse
                else
                {
                    //Passage a la couleur rouge
                    txtReponse.BackColor = Color.LightSalmon;

                    //Affichage de la bonne reponse
                    lblBonneReponse.Text = txtNb1.Text + " x " +  txtNb2.Text + " = " + bonneReponse;

                    lblBonneReponse.Visible = true;
                }

                //Mise a jour de la note 
                txtNote.Text = note.ToString();
                txtMaxNote.Text = numQuestion.ToString();

                //Arriver a la fin de series 
                if(numQuestion == nbQuestion)
                {
                    //Mettre le crusseur sur le boutton recommencer
                    btnRecommencer.Focus(); 
                }
                else
                {
                    //Boutton suivant accessible
                    btnSuivant.Enabled = true;

                    //Le focus sur le boutton suivant
                    btnSuivant.Focus();
                }

            }
        }
    }
}
