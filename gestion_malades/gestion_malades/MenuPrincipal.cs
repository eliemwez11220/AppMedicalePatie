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
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void créerFicheMaladeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMalades malade = new FormMalades();
            malade.MdiParent = this;
            malade.Show();
        }

        private void enregistrerUneConsultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaireConsultation malade = new FormulaireConsultation();
            malade.MdiParent = this;
            malade.Show();
        }

        private void ajouterMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaireMedecin medecin = new FormulaireMedecin();
            medecin.MdiParent = this;
            medecin.Show();
        }

        private void ajouterInfirmierToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormulaireInfirmier infirmier = new FormulaireInfirmier();
            infirmier.MdiParent = this;
            infirmier.Show();
        }

        private void etablirUneOrdonnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormulaireOrdonnance ordonance = new FormulaireOrdonnance();
            ordonance.MdiParent=this;
            ordonance.Show ();
        }

        private void ajouterProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForulaireProduit produit = new ForulaireProduit();
            produit.MdiParent = this;
            produit.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
