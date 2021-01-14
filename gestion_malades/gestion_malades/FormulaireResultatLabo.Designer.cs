namespace gestion_malades
{
    partial class FormulaireResultatLabo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireResultatLabo));
            System.Windows.Forms.Label bon_numeroLabel;
            System.Windows.Forms.Label malade_idLabel;
            System.Windows.Forms.Label type_examenLabel;
            System.Windows.Forms.Label resultat_examenLabel;
            System.Windows.Forms.Label date_resultatLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gestion_maladesDataSet = new gestion_malades.gestion_maladesDataSet();
            this.resultats_laboratoire_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultats_laboratoire_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.resultats_laboratoire_tabTableAdapter();
            this.tableAdapterManager = new gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager();
            this.resultats_laboratoire_tabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.resultats_laboratoire_tabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bon_numeroTextBox = new System.Windows.Forms.TextBox();
            this.malade_idComboBox = new System.Windows.Forms.ComboBox();
            this.type_examenTextBox = new System.Windows.Forms.TextBox();
            this.resultat_examenTextBox = new System.Windows.Forms.TextBox();
            this.date_resultatDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resultats_laboratoire_tabDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bon_numeroLabel = new System.Windows.Forms.Label();
            malade_idLabel = new System.Windows.Forms.Label();
            type_examenLabel = new System.Windows.Forms.Label();
            resultat_examenLabel = new System.Windows.Forms.Label();
            date_resultatLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultats_laboratoire_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultats_laboratoire_tabBindingNavigator)).BeginInit();
            this.resultats_laboratoire_tabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultats_laboratoire_tabDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(bon_numeroLabel);
            this.panel1.Controls.Add(this.bon_numeroTextBox);
            this.panel1.Controls.Add(malade_idLabel);
            this.panel1.Controls.Add(this.malade_idComboBox);
            this.panel1.Controls.Add(type_examenLabel);
            this.panel1.Controls.Add(this.type_examenTextBox);
            this.panel1.Controls.Add(resultat_examenLabel);
            this.panel1.Controls.Add(this.resultat_examenTextBox);
            this.panel1.Controls.Add(date_resultatLabel);
            this.panel1.Controls.Add(this.date_resultatDateTimePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 249);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Résultat Labo";
            // 
            // gestion_maladesDataSet
            // 
            this.gestion_maladesDataSet.DataSetName = "gestion_maladesDataSet";
            this.gestion_maladesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultats_laboratoire_tabBindingSource
            // 
            this.resultats_laboratoire_tabBindingSource.DataMember = "resultats_laboratoire_tab";
            this.resultats_laboratoire_tabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // resultats_laboratoire_tabTableAdapter
            // 
            this.resultats_laboratoire_tabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bon_analyse_tabTableAdapter = null;
            this.tableAdapterManager.consultation_tabTableAdapter = null;
            this.tableAdapterManager.fiche_maladeTableAdapter = null;
            this.tableAdapterManager.infirmier_tabTableAdapter = null;
            this.tableAdapterManager.malade_tabTableAdapter = null;
            this.tableAdapterManager.medecin_tabTableAdapter = null;
            this.tableAdapterManager.ordonnance_tabTableAdapter = null;
            this.tableAdapterManager.prescription_tabTableAdapter = null;
            this.tableAdapterManager.produit_tabTableAdapter = null;
            this.tableAdapterManager.resultats_laboratoire_tabTableAdapter = this.resultats_laboratoire_tabTableAdapter;
            this.tableAdapterManager.UpdateOrder = gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // resultats_laboratoire_tabBindingNavigator
            // 
            this.resultats_laboratoire_tabBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.resultats_laboratoire_tabBindingNavigator.BackColor = System.Drawing.Color.Black;
            this.resultats_laboratoire_tabBindingNavigator.BindingSource = this.resultats_laboratoire_tabBindingSource;
            this.resultats_laboratoire_tabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.resultats_laboratoire_tabBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.resultats_laboratoire_tabBindingNavigator.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultats_laboratoire_tabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.resultats_laboratoire_tabBindingNavigatorSaveItem});
            this.resultats_laboratoire_tabBindingNavigator.Location = new System.Drawing.Point(0, 249);
            this.resultats_laboratoire_tabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.resultats_laboratoire_tabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.resultats_laboratoire_tabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.resultats_laboratoire_tabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.resultats_laboratoire_tabBindingNavigator.Name = "resultats_laboratoire_tabBindingNavigator";
            this.resultats_laboratoire_tabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.resultats_laboratoire_tabBindingNavigator.Size = new System.Drawing.Size(610, 25);
            this.resultats_laboratoire_tabBindingNavigator.TabIndex = 1;
            this.resultats_laboratoire_tabBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // resultats_laboratoire_tabBindingNavigatorSaveItem
            // 
            this.resultats_laboratoire_tabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resultats_laboratoire_tabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("resultats_laboratoire_tabBindingNavigatorSaveItem.Image")));
            this.resultats_laboratoire_tabBindingNavigatorSaveItem.Name = "resultats_laboratoire_tabBindingNavigatorSaveItem";
            this.resultats_laboratoire_tabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.resultats_laboratoire_tabBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.resultats_laboratoire_tabBindingNavigatorSaveItem.Click += new System.EventHandler(this.resultats_laboratoire_tabBindingNavigatorSaveItem_Click);
            // 
            // bon_numeroLabel
            // 
            bon_numeroLabel.AutoSize = true;
            bon_numeroLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bon_numeroLabel.Location = new System.Drawing.Point(22, 56);
            bon_numeroLabel.Name = "bon_numeroLabel";
            bon_numeroLabel.Size = new System.Drawing.Size(107, 22);
            bon_numeroLabel.TabIndex = 1;
            bon_numeroLabel.Text = "bon numero:";
            // 
            // bon_numeroTextBox
            // 
            this.bon_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultats_laboratoire_tabBindingSource, "bon_numero", true));
            this.bon_numeroTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bon_numeroTextBox.Location = new System.Drawing.Point(213, 52);
            this.bon_numeroTextBox.Name = "bon_numeroTextBox";
            this.bon_numeroTextBox.Size = new System.Drawing.Size(309, 26);
            this.bon_numeroTextBox.TabIndex = 2;
            // 
            // malade_idLabel
            // 
            malade_idLabel.AutoSize = true;
            malade_idLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            malade_idLabel.Location = new System.Drawing.Point(22, 99);
            malade_idLabel.Name = "malade_idLabel";
            malade_idLabel.Size = new System.Drawing.Size(89, 22);
            malade_idLabel.TabIndex = 3;
            malade_idLabel.Text = "malade id:";
            // 
            // malade_idComboBox
            // 
            this.malade_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultats_laboratoire_tabBindingSource, "malade_id", true));
            this.malade_idComboBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malade_idComboBox.FormattingEnabled = true;
            this.malade_idComboBox.Location = new System.Drawing.Point(213, 91);
            this.malade_idComboBox.Name = "malade_idComboBox";
            this.malade_idComboBox.Size = new System.Drawing.Size(309, 30);
            this.malade_idComboBox.TabIndex = 4;
            // 
            // type_examenLabel
            // 
            type_examenLabel.AutoSize = true;
            type_examenLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            type_examenLabel.Location = new System.Drawing.Point(22, 135);
            type_examenLabel.Name = "type_examenLabel";
            type_examenLabel.Size = new System.Drawing.Size(111, 22);
            type_examenLabel.TabIndex = 5;
            type_examenLabel.Text = "type examen:";
            // 
            // type_examenTextBox
            // 
            this.type_examenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultats_laboratoire_tabBindingSource, "type_examen", true));
            this.type_examenTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_examenTextBox.Location = new System.Drawing.Point(213, 131);
            this.type_examenTextBox.Name = "type_examenTextBox";
            this.type_examenTextBox.Size = new System.Drawing.Size(309, 26);
            this.type_examenTextBox.TabIndex = 6;
            // 
            // resultat_examenLabel
            // 
            resultat_examenLabel.AutoSize = true;
            resultat_examenLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resultat_examenLabel.Location = new System.Drawing.Point(22, 173);
            resultat_examenLabel.Name = "resultat_examenLabel";
            resultat_examenLabel.Size = new System.Drawing.Size(136, 22);
            resultat_examenLabel.TabIndex = 7;
            resultat_examenLabel.Text = "resultat examen:";
            // 
            // resultat_examenTextBox
            // 
            this.resultat_examenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultats_laboratoire_tabBindingSource, "resultat_examen", true));
            this.resultat_examenTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultat_examenTextBox.Location = new System.Drawing.Point(213, 169);
            this.resultat_examenTextBox.Name = "resultat_examenTextBox";
            this.resultat_examenTextBox.Size = new System.Drawing.Size(309, 26);
            this.resultat_examenTextBox.TabIndex = 8;
            // 
            // date_resultatLabel
            // 
            date_resultatLabel.AutoSize = true;
            date_resultatLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_resultatLabel.Location = new System.Drawing.Point(22, 214);
            date_resultatLabel.Name = "date_resultatLabel";
            date_resultatLabel.Size = new System.Drawing.Size(111, 22);
            date_resultatLabel.TabIndex = 9;
            date_resultatLabel.Text = "date resultat:";
            // 
            // date_resultatDateTimePicker
            // 
            this.date_resultatDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.resultats_laboratoire_tabBindingSource, "date_resultat", true));
            this.date_resultatDateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_resultatDateTimePicker.Location = new System.Drawing.Point(213, 210);
            this.date_resultatDateTimePicker.Name = "date_resultatDateTimePicker";
            this.date_resultatDateTimePicker.Size = new System.Drawing.Size(309, 26);
            this.date_resultatDateTimePicker.TabIndex = 10;
            // 
            // resultats_laboratoire_tabDataGridView
            // 
            this.resultats_laboratoire_tabDataGridView.AutoGenerateColumns = false;
            this.resultats_laboratoire_tabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultats_laboratoire_tabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultats_laboratoire_tabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.resultats_laboratoire_tabDataGridView.DataSource = this.resultats_laboratoire_tabBindingSource;
            this.resultats_laboratoire_tabDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultats_laboratoire_tabDataGridView.Location = new System.Drawing.Point(0, 274);
            this.resultats_laboratoire_tabDataGridView.Name = "resultats_laboratoire_tabDataGridView";
            this.resultats_laboratoire_tabDataGridView.Size = new System.Drawing.Size(610, 228);
            this.resultats_laboratoire_tabDataGridView.TabIndex = 2;
            this.resultats_laboratoire_tabDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultats_laboratoire_tabDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bon_numero";
            this.dataGridViewTextBoxColumn1.HeaderText = "bon_numero";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "malade_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "malade_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "type_examen";
            this.dataGridViewTextBoxColumn3.HeaderText = "type_examen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "resultat_examen";
            this.dataGridViewTextBoxColumn4.HeaderText = "resultat_examen";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date_resultat";
            this.dataGridViewTextBoxColumn5.HeaderText = "date_resultat";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FormulaireResultatLabo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 547);
            this.Controls.Add(this.resultats_laboratoire_tabDataGridView);
            this.Controls.Add(this.resultats_laboratoire_tabBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FormulaireResultatLabo";
            this.Text = "FormulaireResultatLabo";
            this.Load += new System.EventHandler(this.FormulaireResultatLabo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultats_laboratoire_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultats_laboratoire_tabBindingNavigator)).EndInit();
            this.resultats_laboratoire_tabBindingNavigator.ResumeLayout(false);
            this.resultats_laboratoire_tabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultats_laboratoire_tabDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private gestion_maladesDataSet gestion_maladesDataSet;
        private System.Windows.Forms.BindingSource resultats_laboratoire_tabBindingSource;
        private gestion_maladesDataSetTableAdapters.resultats_laboratoire_tabTableAdapter resultats_laboratoire_tabTableAdapter;
        private gestion_maladesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator resultats_laboratoire_tabBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton resultats_laboratoire_tabBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bon_numeroTextBox;
        private System.Windows.Forms.ComboBox malade_idComboBox;
        private System.Windows.Forms.TextBox type_examenTextBox;
        private System.Windows.Forms.TextBox resultat_examenTextBox;
        private System.Windows.Forms.DateTimePicker date_resultatDateTimePicker;
        private System.Windows.Forms.DataGridView resultats_laboratoire_tabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}