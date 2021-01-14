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
    public partial class FormulaireOrdonnance : Form
    {
        public FormulaireOrdonnance()
        {
            InitializeComponent();
        }

        private void ordonnance_tabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordonnance_tabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_maladesDataSet);

        }

        private void FormulaireOrdonnance_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.ordonnance_medicale'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ordonnance_medicaleTableAdapter.Fill(this.gestion_maladesDataSet.ordonnance_medicale);
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.medecin_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.medecin_tabTableAdapter.Fill(this.gestion_maladesDataSet.medecin_tab);
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.produit_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.produit_tabTableAdapter.Fill(this.gestion_maladesDataSet.produit_tab);
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.prescription_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.prescription_tabTableAdapter.Fill(this.gestion_maladesDataSet.prescription_tab);
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.prescription_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.prescription_tabTableAdapter.Fill(this.gestion_maladesDataSet.prescription_tab);
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.ordonnance_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ordonnance_tabTableAdapter.Fill(this.gestion_maladesDataSet.ordonnance_tab);

        }

        private void date_ordonnanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ordonnance_tabTableAdapter.Insert(numero_ordonnanceTextBox.Text,
                    Convert.ToDateTime(date_ordonnanceDateTimePicker.Text),
                    Convert.ToInt32(medecin_idComboBox.Text));
                prescription_tabTableAdapter.Insert(numero_ordonnanceTextBox.Text, produit_idComboBox.Text,
                    Convert.ToInt32(qte_prescriteTextBox.Text), mode_emploiTextBox.Text);
                this.prescription_tabTableAdapter.Fill(this.gestion_maladesDataSet.prescription_tab);
                // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.ordonnance_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
                this.ordonnance_tabTableAdapter.Fill(this.gestion_maladesDataSet.ordonnance_tab);
                MessageBox.Show("Enregistrement effectué avec succès");
            }
            catch (Exception erreur)
            {
                MessageBox.Show("Erreur de données introduites" + erreur.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            
                prescription_tabTableAdapter.Insert(ordonnance_numeroComboBox.Text, produit_idComboBox.Text,
                    Convert.ToInt32(qte_prescriteTextBox.Text), mode_emploiTextBox.Text);
                this.prescription_tabTableAdapter.Fill(this.gestion_maladesDataSet.prescription_tab);
                // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.ordonnance_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
                this.ordonnance_tabTableAdapter.Fill(this.gestion_maladesDataSet.ordonnance_tab);
                MessageBox.Show("Ajout effectué avec succès");
            }
            catch (Exception erreur)
            {
                MessageBox.Show("Erreur de données introduites" + erreur.Message);
            }
        }
    }
}
