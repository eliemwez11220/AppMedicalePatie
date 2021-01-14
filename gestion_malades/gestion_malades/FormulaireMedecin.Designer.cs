namespace gestion_malades
{
    partial class FormulaireMedecin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label num_medecinLabel;
            System.Windows.Forms.Label nom_medecinLabel;
            System.Windows.Forms.Label spec_medecinLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireMedecin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.num_medecinTextBox = new System.Windows.Forms.TextBox();
            this.medecin_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_maladesDataSet = new gestion_malades.gestion_maladesDataSet();
            this.nom_medecinTextBox = new System.Windows.Forms.TextBox();
            this.spec_medecinTextBox = new System.Windows.Forms.TextBox();
            this.medecin_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.medecin_tabTableAdapter();
            this.tableAdapterManager = new gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager();
            this.medecin_tabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.medecin_tabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medecin_tabDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            num_medecinLabel = new System.Windows.Forms.Label();
            nom_medecinLabel = new System.Windows.Forms.Label();
            spec_medecinLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medecin_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecin_tabBindingNavigator)).BeginInit();
            this.medecin_tabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medecin_tabDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // num_medecinLabel
            // 
            num_medecinLabel.AutoSize = true;
            num_medecinLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_medecinLabel.Location = new System.Drawing.Point(19, 68);
            num_medecinLabel.Name = "num_medecinLabel";
            num_medecinLabel.Size = new System.Drawing.Size(117, 22);
            num_medecinLabel.TabIndex = 0;
            num_medecinLabel.Text = "num medecin:";
            // 
            // nom_medecinLabel
            // 
            nom_medecinLabel.AutoSize = true;
            nom_medecinLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_medecinLabel.Location = new System.Drawing.Point(19, 104);
            nom_medecinLabel.Name = "nom_medecinLabel";
            nom_medecinLabel.Size = new System.Drawing.Size(118, 22);
            nom_medecinLabel.TabIndex = 2;
            nom_medecinLabel.Text = "nom medecin:";
            // 
            // spec_medecinLabel
            // 
            spec_medecinLabel.AutoSize = true;
            spec_medecinLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            spec_medecinLabel.Location = new System.Drawing.Point(19, 142);
            spec_medecinLabel.Name = "spec_medecinLabel";
            spec_medecinLabel.Size = new System.Drawing.Size(119, 22);
            spec_medecinLabel.TabIndex = 4;
            spec_medecinLabel.Text = "spec medecin:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(num_medecinLabel);
            this.panel1.Controls.Add(this.num_medecinTextBox);
            this.panel1.Controls.Add(nom_medecinLabel);
            this.panel1.Controls.Add(this.nom_medecinTextBox);
            this.panel1.Controls.Add(spec_medecinLabel);
            this.panel1.Controls.Add(this.spec_medecinTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 181);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(238, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fiche de médecin";
            // 
            // num_medecinTextBox
            // 
            this.num_medecinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecin_tabBindingSource, "num_medecin", true));
            this.num_medecinTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_medecinTextBox.Location = new System.Drawing.Point(169, 64);
            this.num_medecinTextBox.Name = "num_medecinTextBox";
            this.num_medecinTextBox.Size = new System.Drawing.Size(342, 26);
            this.num_medecinTextBox.TabIndex = 1;
            // 
            // medecin_tabBindingSource
            // 
            this.medecin_tabBindingSource.DataMember = "medecin_tab";
            this.medecin_tabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // gestion_maladesDataSet
            // 
            this.gestion_maladesDataSet.DataSetName = "gestion_maladesDataSet";
            this.gestion_maladesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nom_medecinTextBox
            // 
            this.nom_medecinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecin_tabBindingSource, "nom_medecin", true));
            this.nom_medecinTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_medecinTextBox.Location = new System.Drawing.Point(169, 104);
            this.nom_medecinTextBox.Name = "nom_medecinTextBox";
            this.nom_medecinTextBox.Size = new System.Drawing.Size(342, 26);
            this.nom_medecinTextBox.TabIndex = 3;
            // 
            // spec_medecinTextBox
            // 
            this.spec_medecinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecin_tabBindingSource, "spec_medecin", true));
            this.spec_medecinTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spec_medecinTextBox.Location = new System.Drawing.Point(169, 142);
            this.spec_medecinTextBox.Name = "spec_medecinTextBox";
            this.spec_medecinTextBox.Size = new System.Drawing.Size(342, 26);
            this.spec_medecinTextBox.TabIndex = 5;
            // 
            // medecin_tabTableAdapter
            // 
            this.medecin_tabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bon_analyse_tabTableAdapter = null;
            this.tableAdapterManager.consultation_tabTableAdapter = null;
            this.tableAdapterManager.fiche_maladeTableAdapter = null;
            this.tableAdapterManager.infirmier_tabTableAdapter = null;
            this.tableAdapterManager.malade_tabTableAdapter = null;
            this.tableAdapterManager.medecin_tabTableAdapter = this.medecin_tabTableAdapter;
            this.tableAdapterManager.ordonnance_tabTableAdapter = null;
            this.tableAdapterManager.prescription_tabTableAdapter = null;
            this.tableAdapterManager.produit_tabTableAdapter = null;
            this.tableAdapterManager.resultats_laboratoire_tabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medecin_tabBindingNavigator
            // 
            this.medecin_tabBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medecin_tabBindingNavigator.BackColor = System.Drawing.Color.Black;
            this.medecin_tabBindingNavigator.BindingSource = this.medecin_tabBindingSource;
            this.medecin_tabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medecin_tabBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medecin_tabBindingNavigator.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecin_tabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medecin_tabBindingNavigatorSaveItem});
            this.medecin_tabBindingNavigator.Location = new System.Drawing.Point(0, 181);
            this.medecin_tabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medecin_tabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medecin_tabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medecin_tabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medecin_tabBindingNavigator.Name = "medecin_tabBindingNavigator";
            this.medecin_tabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medecin_tabBindingNavigator.Size = new System.Drawing.Size(676, 25);
            this.medecin_tabBindingNavigator.TabIndex = 1;
            this.medecin_tabBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(47, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // medecin_tabBindingNavigatorSaveItem
            // 
            this.medecin_tabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medecin_tabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medecin_tabBindingNavigatorSaveItem.Image")));
            this.medecin_tabBindingNavigatorSaveItem.Name = "medecin_tabBindingNavigatorSaveItem";
            this.medecin_tabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medecin_tabBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.medecin_tabBindingNavigatorSaveItem.Click += new System.EventHandler(this.medecin_tabBindingNavigatorSaveItem_Click);
            // 
            // medecin_tabDataGridView
            // 
            this.medecin_tabDataGridView.AutoGenerateColumns = false;
            this.medecin_tabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medecin_tabDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.medecin_tabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medecin_tabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.medecin_tabDataGridView.DataSource = this.medecin_tabBindingSource;
            this.medecin_tabDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.medecin_tabDataGridView.Location = new System.Drawing.Point(0, 209);
            this.medecin_tabDataGridView.Name = "medecin_tabDataGridView";
            this.medecin_tabDataGridView.Size = new System.Drawing.Size(676, 173);
            this.medecin_tabDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "num_medecin";
            this.dataGridViewTextBoxColumn1.FillWeight = 46.4455F;
            this.dataGridViewTextBoxColumn1.HeaderText = "num_medecin";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom_medecin";
            this.dataGridViewTextBoxColumn2.FillWeight = 101.3249F;
            this.dataGridViewTextBoxColumn2.HeaderText = "nom_medecin";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "spec_medecin";
            this.dataGridViewTextBoxColumn3.FillWeight = 152.2296F;
            this.dataGridViewTextBoxColumn3.HeaderText = "spec_medecin";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormulaireMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 382);
            this.Controls.Add(this.medecin_tabDataGridView);
            this.Controls.Add(this.medecin_tabBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FormulaireMedecin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireMedecin";
            this.Load += new System.EventHandler(this.FormulaireMedecin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medecin_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecin_tabBindingNavigator)).EndInit();
            this.medecin_tabBindingNavigator.ResumeLayout(false);
            this.medecin_tabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medecin_tabDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private gestion_maladesDataSet gestion_maladesDataSet;
        private System.Windows.Forms.BindingSource medecin_tabBindingSource;
        private gestion_maladesDataSetTableAdapters.medecin_tabTableAdapter medecin_tabTableAdapter;
        private gestion_maladesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medecin_tabBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medecin_tabBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox num_medecinTextBox;
        private System.Windows.Forms.TextBox nom_medecinTextBox;
        private System.Windows.Forms.TextBox spec_medecinTextBox;
        private System.Windows.Forms.DataGridView medecin_tabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
    }
}