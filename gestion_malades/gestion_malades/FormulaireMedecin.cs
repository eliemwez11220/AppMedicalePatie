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
    public partial class FormulaireMedecin : Form
    {
        public FormulaireMedecin()
        {
            InitializeComponent();
        }

        private void medecin_tabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*this.Validate();
            this.medecin_tabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_maladesDataSet);
             */
            try
            {
                medecin_tabTableAdapter.Insert(nom_medecinTextBox.Text, spec_medecinTextBox.Text);
                this.medecin_tabTableAdapter.Fill(this.gestion_maladesDataSet.medecin_tab);
                MessageBox.Show("Enregistrement effectué du medecin");
            }
            catch (Exception erreur)
            {
                MessageBox.Show("Erreur de données introduites" + erreur.Message);
            }
        }

        private void FormulaireMedecin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.medecin_tab'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.medecin_tabTableAdapter.Fill(this.gestion_maladesDataSet.medecin_tab);

        }
    }
}
