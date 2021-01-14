namespace gestion_malades
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerFicheMaladeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerUneConsultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajouterMedecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ajouterInfirmierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etablirUneOrdonnanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ajouterProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(837, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel.Text = "État";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.receptionToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.prescriptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 45);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(102, 41);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // receptionToolStripMenuItem
            // 
            this.receptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerFicheMaladeToolStripMenuItem});
            this.receptionToolStripMenuItem.Name = "receptionToolStripMenuItem";
            this.receptionToolStripMenuItem.Size = new System.Drawing.Size(158, 41);
            this.receptionToolStripMenuItem.Text = "Reception";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerUneConsultationToolStripMenuItem,
            this.toolStripSeparator1,
            this.ajouterMedecinToolStripMenuItem,
            this.toolStripSeparator2,
            this.ajouterInfirmierToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(193, 41);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etablirUneOrdonnanceToolStripMenuItem,
            this.toolStripSeparator3,
            this.ajouterProduitToolStripMenuItem});
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(185, 41);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            // 
            // créerFicheMaladeToolStripMenuItem
            // 
            this.créerFicheMaladeToolStripMenuItem.Name = "créerFicheMaladeToolStripMenuItem";
            this.créerFicheMaladeToolStripMenuItem.Size = new System.Drawing.Size(334, 42);
            this.créerFicheMaladeToolStripMenuItem.Text = "Créer fiche malade";
            this.créerFicheMaladeToolStripMenuItem.Click += new System.EventHandler(this.créerFicheMaladeToolStripMenuItem_Click);
            // 
            // enregistrerUneConsultationToolStripMenuItem
            // 
            this.enregistrerUneConsultationToolStripMenuItem.Name = "enregistrerUneConsultationToolStripMenuItem";
            this.enregistrerUneConsultationToolStripMenuItem.Size = new System.Drawing.Size(456, 42);
            this.enregistrerUneConsultationToolStripMenuItem.Text = "Enregistrer une consultation";
            this.enregistrerUneConsultationToolStripMenuItem.Click += new System.EventHandler(this.enregistrerUneConsultationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(453, 6);
            // 
            // ajouterMedecinToolStripMenuItem
            // 
            this.ajouterMedecinToolStripMenuItem.Name = "ajouterMedecinToolStripMenuItem";
            this.ajouterMedecinToolStripMenuItem.Size = new System.Drawing.Size(456, 42);
            this.ajouterMedecinToolStripMenuItem.Text = "Ajouter Medecin";
            this.ajouterMedecinToolStripMenuItem.Click += new System.EventHandler(this.ajouterMedecinToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(453, 6);
            // 
            // ajouterInfirmierToolStripMenuItem
            // 
            this.ajouterInfirmierToolStripMenuItem.Name = "ajouterInfirmierToolStripMenuItem";
            this.ajouterInfirmierToolStripMenuItem.Size = new System.Drawing.Size(456, 42);
            this.ajouterInfirmierToolStripMenuItem.Text = "Ajouter Infirmier";
            this.ajouterInfirmierToolStripMenuItem.Click += new System.EventHandler(this.ajouterInfirmierToolStripMenuItem_Click);
            // 
            // etablirUneOrdonnanceToolStripMenuItem
            // 
            this.etablirUneOrdonnanceToolStripMenuItem.Name = "etablirUneOrdonnanceToolStripMenuItem";
            this.etablirUneOrdonnanceToolStripMenuItem.Size = new System.Drawing.Size(392, 42);
            this.etablirUneOrdonnanceToolStripMenuItem.Text = "Etablir une ordonnance";
            this.etablirUneOrdonnanceToolStripMenuItem.Click += new System.EventHandler(this.etablirUneOrdonnanceToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(389, 6);
            // 
            // ajouterProduitToolStripMenuItem
            // 
            this.ajouterProduitToolStripMenuItem.Name = "ajouterProduitToolStripMenuItem";
            this.ajouterProduitToolStripMenuItem.Size = new System.Drawing.Size(392, 42);
            this.ajouterProduitToolStripMenuItem.Text = "Ajouter produit";
            this.ajouterProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterProduitToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(186, 42);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerFicheMaladeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerUneConsultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ajouterMedecinToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ajouterInfirmierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etablirUneOrdonnanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ajouterProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    }
}



