using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_malades
{
    public partial class ForulaireProduit : Form
    {
        public ForulaireProduit()
        {
            InitializeComponent();
        }

        private void produit_tabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produit_tabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_maladesDataSet);

        }

        private void ForulaireProduit_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.produit_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produit_tabTableAdapter.Fill(this.gestion_maladesDataSet.produit_tab);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                produit_tabTableAdapter.Insert(designation_produitTextBox.Text, 
                    Convert.ToDouble(prix_produitTextBox.Text), Convert.ToInt32(qte_stock_produitTextBox.Text));
                this.produit_tabTableAdapter.Fill(this.gestion_maladesDataSet.produit_tab);
                MessageBox.Show("Ajout du produit effectué");
            }
            catch(Exception err)
            {
                MessageBox.Show("Erreur de sauvegarde du produit" +err.Message);
            }
        }
    }
}
