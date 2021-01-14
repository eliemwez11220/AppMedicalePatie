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
    public partial class FormulaireOrdonnanceMedicale : Form
    {
        public FormulaireOrdonnanceMedicale()
        {
            InitializeComponent();
        }

        private void FormulaireOrdonnanceMedicale_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.ordonnance_medicale'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ordonnance_medicaleTableAdapter.Fill(this.gestion_maladesDataSet.ordonnance_medicale);

        }
    }
}
