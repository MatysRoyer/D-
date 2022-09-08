using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DÉ
{
    public partial class Form1 : Form
    {
        private readonly Controller controleurDé;
       

        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

     public void button1_Click(object sender, EventArgs e)
        {
           
            Dé_Ordinaire dé_Ordinaire = new Dé_Ordinaire(6);
            Dé_Pipé dé_Pipé = new Dé_Pipé(6);





            if (controller.GenererDéEtNombreAleatoire(dé_Pipé, dé_Ordinaire) == dé_Pipé)
            {
                MessageBox.Show("dé pipé");
                int valeurPipé = dé_Pipé.Brasser(controller.random, 10);
                int valeurAdditionPipé = controller.ValeurTotal += dé_Pipé.Valeur;

                MessageBox.Show(valeurPipé.ToString());

                MessageBox.Show(valeurAdditionPipé.ToString());

            }
            else
            {

                MessageBox.Show("dé ordinaire");

                int valeurOrdinaire = dé_Ordinaire.Brasser(controller.random, 6);

                int valeurAdditionOrdinaire = controller.ValeurTotal += dé_Ordinaire.Valeur;
                MessageBox.Show(valeurOrdinaire.ToString());

                MessageBox.Show(valeurAdditionOrdinaire.ToString());
                





            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
