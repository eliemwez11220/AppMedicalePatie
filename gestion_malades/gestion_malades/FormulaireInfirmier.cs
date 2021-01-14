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
    public partial class FormulaireInfirmier : Form
    {
        public FormulaireInfirmier()
        {
            InitializeComponent();
        }

        private void infirmier_tabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.infirmier_tabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_maladesDataSet);

        }

        private void FormulaireInfirmier_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.infirmier_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.infirmier_tabTableAdapter.Fill(this.gestion_maladesDataSet.infirmier_tab);

        }

        private void infirmier_tabDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                infirmier_tabTableAdapter.Insert(nom_infirmierTextBox.Text, grade_infirmierTextBox.Text);
                this.infirmier_tabTableAdapter.Fill(this.gestion_maladesDataSet.infirmier_tab);
                MessageBox.Show("Données de l'infirmier enregistrées avec succès");
            }
            catch (Exception erreur)
            {
                MessageBox.Show("Erreur de données introduites"+erreur.Message);
            }
        }
    }
}
