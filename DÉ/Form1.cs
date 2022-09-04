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



           MessageBox.Show(controller.GenererDéAleatoire(dé_Pipé, dé_Ordinaire).ToString());

            if (controller.GenererDéAleatoire(dé_Pipé, dé_Ordinaire) == dé_Pipé)
            {
                MessageBox.Show("salut");
              int valeurPipé =  dé_Pipé.Brasser(controller.random,6);
                MessageBox.Show(valeurPipé.ToString());
            }
            else if (controller.GenererDéAleatoire(dé_Pipé, dé_Ordinaire) == dé_Ordinaire) 
            {
               
                MessageBox.Show("allo");
               int valeurOrdinaire = dé_Ordinaire.Brasser(controller.random, 6);
                MessageBox.Show(valeurOrdinaire.ToString());
            }
           
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
