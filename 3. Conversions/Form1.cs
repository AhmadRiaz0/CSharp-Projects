using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversions
{
    public partial class FormConvertisseur : Form
    {
        public FormConvertisseur()
        {
            InitializeComponent();
        }

        //Methode non evenementiel

        /**
         * Methode non evenementiel 1 : savoir si le nombre est binaire ou non
         * return "True" si le paramètre de la méthode contient que des "0" ou "1"
         * return "false" si le paramètre de la méthode contient un autre nombre 
         
        private bool isBinaire(string texte) 
        {
            string binaire1 = "1";
            string binaire0 = "0";
            
            bool estBinaire = true;

            for(int i = 0; i < texte.Length; i++)
            {
                string leTexte = texte.Substring(i, 1); //Extraire un caractère a la fois 

                if(leTexte != binaire1 || leTexte != binaire0)
                {
                    estBinaire = false;
                }
            }
            return estBinaire;
        }

      */

        /**
         * Controle si le paramètre est binaire
         */
        private bool isBinaire(string texte)
        {
            //Boucle non deterministe
            int k = 0;
            while (k < texte.Length && (texte.Substring(k, 1) == "0" || texte.Substring(k, 1) == "1")) //Boucle : Condition 1 arriver en bout chaine Condition 2 : trouver que des caractère "0" ou "1"
            {
                k++; //Incémentation pour tester tous les caractère
            }
            
            //Verification de la condition de sortie de la boucle : ici on verifie la condition 1 si on est parseque on est arriver en bout de chaine 
            if (k == texte.Length) 
            { 
                return true; //Arriver en bout de chaine donc que des "0" ou "1" donc binaire
            }
            else
            {
                return false; //Pas arriver en bout de chaine donc pas binaire
            }

        }


        /**
        * Methode non evenementiel 2 : pour convertire depuis la base 10 vers la base 2
        * return la base 2 du nombre recu en paramètre 
        */ 
        private string conversionBase10ToBase2(int base10)
        {
            int binaire;
            string binnaireAffichage = " ";
            

            while (base10 != 0) 
            {
                binaire = base10 % 2;
                binnaireAffichage = binaire + binnaireAffichage;
                base10 = base10 / 2;
            }

            //cas particulier ou base 10 continent "0"
            if(binnaireAffichage == " ")
            {
                binnaireAffichage = "0";
            }
            return binnaireAffichage;
        }


        /**
        * Methode non evenementiel 3 : controle si le nombre du paramètre est bien au format binaire (""isBinaire()") + conversion en base 10
        * return la base -1 si le nombre recu en paramètre n'est pas binaire 
        */
        private int conversionBase2ToBase10(string base2)
        {
            //test si le base2 et bien binaire
            if(isBinaire(base2) == true)
            {
                //converssion possible par puissance de 2
                int base10 = 0;
                for (int i = 0; i < base2.Length; i++)
                {
                    base10 += int.Parse(base2.Substring(base2.Length - 1 - i,1)) * (int)Math.Pow(2, i); //commence par la fin
                }
                return base10;
            }
            else
            {
                //conversion impossible
                return -1;
            }
        }





        /**
         * Methode lorsque on saisie dans le textBox de la base 10 : qui retourne le nombre en base 10
         */

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Verification que c'est bien un nombre qui est saisie 
            try
            {
                //recuperation du contenu 
                int base10 = int.Parse(txtBase10.Text);
                //Affichage en base 2
                txtBase2.Text = conversionBase10ToBase2(base10);
            } 
            catch (Exception ex)
            {
                txtBase10.Text = " ";
                txtBase2.Text = " ";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /**
         * Methode lorsque on saisie dans le textBox de la base 2 : qui retourne le nombre en base 2
         */

        private void txtBase2_TextChanged(object sender, EventArgs e)
        {
            //recuperation du contenu de converti en base10
            int base10 = conversionBase2ToBase10(txtBase2.Text); //appele de la methode de conversion vers base 10
            //verification si la conversion a marche
            if(base10 != -1)
            {
                txtBase10.Text = base10.ToString(); //conversion + affichage
            }
            else //si erreur on vide tous les champs
            {
                txtBase10.Text = " ";
                txtBase2.Text = " ";
            }

        }
    }
}
