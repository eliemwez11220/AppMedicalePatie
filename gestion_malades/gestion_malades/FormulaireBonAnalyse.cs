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
    public partial class FormulaireBonAnalyse : Form
    {
        public FormulaireBonAnalyse()
        {
            InitializeComponent();
        }

        private void bon_analyse_tabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bon_analyse_tabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_maladesDataSet);

        }

        private void FormulaireBonAnalyse_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.bon_analyse_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.bon_analyse_tabTableAdapter.Fill(this.gestion_maladesDataSet.bon_analyse_tab);

        }
    }
}
