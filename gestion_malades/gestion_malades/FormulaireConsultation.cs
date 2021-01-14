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
    public partial class FormulaireConsultation : Form
    {
        public FormulaireConsultation()
        {
            InitializeComponent();
        }

        private void consultation_tabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultation_tabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_maladesDataSet);

        }

        private void consultation_tabBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.consultation_tabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_maladesDataSet);

        }

        private void FormulaireConsultation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.fiche_malade'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.fiche_maladeTableAdapter.Fill(this.gestion_maladesDataSet.fiche_malade);
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.malade_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.malade_tabTableAdapter.Fill(this.gestion_maladesDataSet.malade_tab);
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.medecin_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.medecin_tabTableAdapter.Fill(this.gestion_maladesDataSet.medecin_tab);
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.consultation_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.consultation_tabTableAdapter.Fill(this.gestion_maladesDataSet.consultation_tab);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                consultation_tabTableAdapter.Insert(Convert.ToInt32(medecin_idComboBox.Text),
                Convert.ToInt32(malade_idComboBox.Text), symptomeTextBox.Text, tension_arterielleTextBox.Text,
                temperatureTextBox.Text, Convert.ToDateTime(date_consultationDateTimePicker.Text),
                details_diagnosticTextBox.Text);
                this.consultation_tabTableAdapter.Fill(this.gestion_maladesDataSet.consultation_tab);
                MessageBox.Show("Données de consultation sauvegardées avec succès");
            }
            catch (Exception erreur)
            {
                MessageBox.Show("Erreur de données introduites" + erreur.Message);
            }
        }
    }
}
