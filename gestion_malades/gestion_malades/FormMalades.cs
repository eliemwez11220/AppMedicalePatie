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
    public partial class FormMalades : Form
    {
        public FormMalades()
        {
            InitializeComponent();
        }

        private void fiche_maladeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fiche_maladeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_maladesDataSet);

        }

        private void fiche_maladeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try 
            { 
                fiche_maladeTableAdapter.Insert(Convert.ToInt32(numero_ficheTextBox.Text), 
                    Convert.ToDateTime(date_ficheDateTimePicker.Text), nom_maladeTextBox.Text, 
                    sexe_maladeComboBox.Text, telephone_maladeTextBox.Text, adresse_maladeTextBox.Text, 
                    age_maladeNumericUpDown.Value.ToString(), categorie_maladeComboBox.Text);
                this.fiche_maladeTableAdapter.Fill(this.gestion_maladesDataSet.fiche_malade);
                MessageBox.Show("Enregistrement effectué avec succès");
            }catch(Exception erreur)
            {
                MessageBox.Show("Erreur de données " + erreur.Message);
            }
            /*
             * 
             * this.Validate();
            this.fiche_maladeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestion_maladesDataSet);
             */
        }

        private void FormMalades_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_maladesDataSet.fiche_malade'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.fiche_maladeTableAdapter.Fill(this.gestion_maladesDataSet.fiche_malade);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                fiche_maladeTableAdapter.Delete(Convert.ToInt32(numero_ficheTextBox.Text),
                    Convert.ToDateTime(date_ficheDateTimePicker.Text), nom_maladeTextBox.Text,
                    sexe_maladeComboBox.Text, telephone_maladeTextBox.Text, adresse_maladeTextBox.Text,
                    age_maladeNumericUpDown.Value.ToString(), categorie_maladeComboBox.Text);
                MessageBox.Show("supprression effectué avec succès");
            }
            catch (Exception erreur)
            {
                MessageBox.Show("Erreur de données " + erreur.Message);
            }
        }
    }
}
