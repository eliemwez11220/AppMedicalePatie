namespace gestion_malades
{
    partial class FormulaireBonAnalyse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireBonAnalyse));
            System.Windows.Forms.Label num_bonLabel;
            System.Windows.Forms.Label date_bonLabel;
            System.Windows.Forms.Label type_examenLabel;
            System.Windows.Forms.Label medecin_idLabel;
            System.Windows.Forms.Label malade_idLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gestion_maladesDataSet = new gestion_malades.gestion_maladesDataSet();
            this.bon_analyse_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bon_analyse_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.bon_analyse_tabTableAdapter();
            this.tableAdapterManager = new gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager();
            this.bon_analyse_tabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bon_analyse_tabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.num_bonTextBox = new System.Windows.Forms.TextBox();
            this.date_bonDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.type_examenTextBox = new System.Windows.Forms.TextBox();
            this.medecin_idComboBox = new System.Windows.Forms.ComboBox();
            this.malade_idComboBox = new System.Windows.Forms.ComboBox();
            this.bon_analyse_tabDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            num_bonLabel = new System.Windows.Forms.Label();
            date_bonLabel = new System.Windows.Forms.Label();
            type_examenLabel = new System.Windows.Forms.Label();
            medecin_idLabel = new System.Windows.Forms.Label();
            malade_idLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bon_analyse_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bon_analyse_tabBindingNavigator)).BeginInit();
            this.bon_analyse_tabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bon_analyse_tabDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(num_bonLabel);
            this.panel1.Controls.Add(this.num_bonTextBox);
            this.panel1.Controls.Add(date_bonLabel);
            this.panel1.Controls.Add(this.date_bonDateTimePicker);
            this.panel1.Controls.Add(type_examenLabel);
            this.panel1.Controls.Add(this.type_examenTextBox);
            this.panel1.Controls.Add(medecin_idLabel);
            this.panel1.Controls.Add(this.medecin_idComboBox);
            this.panel1.Controls.Add(malade_idLabel);
            this.panel1.Controls.Add(this.malade_idComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 284);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bon de l\'Analyse du Labo";
            // 
            // gestion_maladesDataSet
            // 
            this.gestion_maladesDataSet.DataSetName = "gestion_maladesDataSet";
            this.gestion_maladesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bon_analyse_tabBindingSource
            // 
            this.bon_analyse_tabBindingSource.DataMember = "bon_analyse_tab";
            this.bon_analyse_tabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // bon_analyse_tabTableAdapter
            // 
            this.bon_analyse_tabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bon_analyse_tabTableAdapter = this.bon_analyse_tabTableAdapter;
            this.tableAdapterManager.consultation_tabTableAdapter = null;
            this.tableAdapterManager.fiche_maladeTableAdapter = null;
            this.tableAdapterManager.infirmier_tabTableAdapter = null;
            this.tableAdapterManager.malade_tabTableAdapter = null;
            this.tableAdapterManager.medecin_tabTableAdapter = null;
            this.tableAdapterManager.ordonnance_tabTableAdapter = null;
            this.tableAdapterManager.prescription_tabTableAdapter = null;
            this.tableAdapterManager.produit_tabTableAdapter = null;
            this.tableAdapterManager.resultats_laboratoire_tabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bon_analyse_tabBindingNavigator
            // 
            this.bon_analyse_tabBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bon_analyse_tabBindingNavigator.BackColor = System.Drawing.Color.Black;
            this.bon_analyse_tabBindingNavigator.BindingSource = this.bon_analyse_tabBindingSource;
            this.bon_analyse_tabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bon_analyse_tabBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bon_analyse_tabBindingNavigator.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bon_analyse_tabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bon_analyse_tabBindingNavigatorSaveItem});
            this.bon_analyse_tabBindingNavigator.Location = new System.Drawing.Point(0, 284);
            this.bon_analyse_tabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bon_analyse_tabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bon_analyse_tabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bon_analyse_tabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bon_analyse_tabBindingNavigator.Name = "bon_analyse_tabBindingNavigator";
            this.bon_analyse_tabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bon_analyse_tabBindingNavigator.Size = new System.Drawing.Size(643, 25);
            this.bon_analyse_tabBindingNavigator.TabIndex = 1;
            this.bon_analyse_tabBindingNavigator.Text = "bindingNavigator1";
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
            // bon_analyse_tabBindingNavigatorSaveItem
            // 
            this.bon_analyse_tabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bon_analyse_tabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bon_analyse_tabBindingNavigatorSaveItem.Image")));
            this.bon_analyse_tabBindingNavigatorSaveItem.Name = "bon_analyse_tabBindingNavigatorSaveItem";
            this.bon_analyse_tabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bon_analyse_tabBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.bon_analyse_tabBindingNavigatorSaveItem.Click += new System.EventHandler(this.bon_analyse_tabBindingNavigatorSaveItem_Click);
            // 
            // num_bonLabel
            // 
            num_bonLabel.AutoSize = true;
            num_bonLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_bonLabel.Location = new System.Drawing.Point(29, 64);
            num_bonLabel.Name = "num_bonLabel";
            num_bonLabel.Size = new System.Drawing.Size(81, 22);
            num_bonLabel.TabIndex = 1;
            num_bonLabel.Text = "num bon:";
            // 
            // num_bonTextBox
            // 
            this.num_bonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bon_analyse_tabBindingSource, "num_bon", true));
            this.num_bonTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_bonTextBox.Location = new System.Drawing.Point(264, 60);
            this.num_bonTextBox.Name = "num_bonTextBox";
            this.num_bonTextBox.Size = new System.Drawing.Size(320, 26);
            this.num_bonTextBox.TabIndex = 2;
            // 
            // date_bonLabel
            // 
            date_bonLabel.AutoSize = true;
            date_bonLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_bonLabel.Location = new System.Drawing.Point(29, 104);
            date_bonLabel.Name = "date_bonLabel";
            date_bonLabel.Size = new System.Drawing.Size(82, 22);
            date_bonLabel.TabIndex = 3;
            date_bonLabel.Text = "date bon:";
            // 
            // date_bonDateTimePicker
            // 
            this.date_bonDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bon_analyse_tabBindingSource, "date_bon", true));
            this.date_bonDateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_bonDateTimePicker.Location = new System.Drawing.Point(264, 100);
            this.date_bonDateTimePicker.Name = "date_bonDateTimePicker";
            this.date_bonDateTimePicker.Size = new System.Drawing.Size(320, 26);
            this.date_bonDateTimePicker.TabIndex = 4;
            // 
            // type_examenLabel
            // 
            type_examenLabel.AutoSize = true;
            type_examenLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            type_examenLabel.Location = new System.Drawing.Point(29, 145);
            type_examenLabel.Name = "type_examenLabel";
            type_examenLabel.Size = new System.Drawing.Size(111, 22);
            type_examenLabel.TabIndex = 5;
            type_examenLabel.Text = "type examen:";
            // 
            // type_examenTextBox
            // 
            this.type_examenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bon_analyse_tabBindingSource, "type_examen", true));
            this.type_examenTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_examenTextBox.Location = new System.Drawing.Point(264, 141);
            this.type_examenTextBox.Name = "type_examenTextBox";
            this.type_examenTextBox.Size = new System.Drawing.Size(320, 26);
            this.type_examenTextBox.TabIndex = 6;
            // 
            // medecin_idLabel
            // 
            medecin_idLabel.AutoSize = true;
            medecin_idLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medecin_idLabel.Location = new System.Drawing.Point(29, 197);
            medecin_idLabel.Name = "medecin_idLabel";
            medecin_idLabel.Size = new System.Drawing.Size(99, 22);
            medecin_idLabel.TabIndex = 7;
            medecin_idLabel.Text = "medecin id:";
            // 
            // medecin_idComboBox
            // 
            this.medecin_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bon_analyse_tabBindingSource, "medecin_id", true));
            this.medecin_idComboBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecin_idComboBox.FormattingEnabled = true;
            this.medecin_idComboBox.Location = new System.Drawing.Point(264, 189);
            this.medecin_idComboBox.Name = "medecin_idComboBox";
            this.medecin_idComboBox.Size = new System.Drawing.Size(320, 30);
            this.medecin_idComboBox.TabIndex = 8;
            // 
            // malade_idLabel
            // 
            malade_idLabel.AutoSize = true;
            malade_idLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            malade_idLabel.Location = new System.Drawing.Point(29, 243);
            malade_idLabel.Name = "malade_idLabel";
            malade_idLabel.Size = new System.Drawing.Size(89, 22);
            malade_idLabel.TabIndex = 9;
            malade_idLabel.Text = "malade id:";
            // 
            // malade_idComboBox
            // 
            this.malade_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bon_analyse_tabBindingSource, "malade_id", true));
            this.malade_idComboBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malade_idComboBox.FormattingEnabled = true;
            this.malade_idComboBox.Location = new System.Drawing.Point(264, 235);
            this.malade_idComboBox.Name = "malade_idComboBox";
            this.malade_idComboBox.Size = new System.Drawing.Size(320, 30);
            this.malade_idComboBox.TabIndex = 10;
            // 
            // bon_analyse_tabDataGridView
            // 
            this.bon_analyse_tabDataGridView.AutoGenerateColumns = false;
            this.bon_analyse_tabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bon_analyse_tabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bon_analyse_tabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bon_analyse_tabDataGridView.DataSource = this.bon_analyse_tabBindingSource;
            this.bon_analyse_tabDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.bon_analyse_tabDataGridView.Location = new System.Drawing.Point(0, 309);
            this.bon_analyse_tabDataGridView.Name = "bon_analyse_tabDataGridView";
            this.bon_analyse_tabDataGridView.Size = new System.Drawing.Size(643, 220);
            this.bon_analyse_tabDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "num_bon";
            this.dataGridViewTextBoxColumn1.HeaderText = "num_bon";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date_bon";
            this.dataGridViewTextBoxColumn2.HeaderText = "date_bon";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "medecin_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "medecin_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "malade_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "malade_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FormulaireBonAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(643, 578);
            this.Controls.Add(this.bon_analyse_tabDataGridView);
            this.Controls.Add(this.bon_analyse_tabBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FormulaireBonAnalyse";
            this.Text = "FormulaireBonAnalyse";
            this.Load += new System.EventHandler(this.FormulaireBonAnalyse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bon_analyse_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bon_analyse_tabBindingNavigator)).EndInit();
            this.bon_analyse_tabBindingNavigator.ResumeLayout(false);
            this.bon_analyse_tabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bon_analyse_tabDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private gestion_maladesDataSet gestion_maladesDataSet;
        private System.Windows.Forms.BindingSource bon_analyse_tabBindingSource;
        private gestion_maladesDataSetTableAdapters.bon_analyse_tabTableAdapter bon_analyse_tabTableAdapter;
        private gestion_maladesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bon_analyse_tabBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bon_analyse_tabBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox num_bonTextBox;
        private System.Windows.Forms.DateTimePicker date_bonDateTimePicker;
        private System.Windows.Forms.TextBox type_examenTextBox;
        private System.Windows.Forms.ComboBox medecin_idComboBox;
        private System.Windows.Forms.ComboBox malade_idComboBox;
        private System.Windows.Forms.DataGridView bon_analyse_tabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}