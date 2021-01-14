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
    public partial class FormulaireResultatLabo : Form
    {
        public FormulaireResultatLabo()
        {
            InitializeComponent();
        }

        private void resultats_laboratoire_tabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resultats_laboratoire_tabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_maladesDataSet);

        }

        private void FormulaireResultatLabo_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.resultats_laboratoire_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.resultats_laboratoire_tabTableAdapter.Fill(this.gestion_maladesDataSet.resultats_laboratoire_tab);

        }

        private void date_resultatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultats_laboratoire_tabDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
