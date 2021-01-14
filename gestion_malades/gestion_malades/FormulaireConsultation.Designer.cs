namespace gestion_malades
{
    partial class FormulaireConsultation
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
            System.Windows.Forms.Label medecin_idLabel;
            System.Windows.Forms.Label malade_idLabel;
            System.Windows.Forms.Label symptomeLabel;
            System.Windows.Forms.Label tension_arterielleLabel;
            System.Windows.Forms.Label temperatureLabel;
            System.Windows.Forms.Label date_consultationLabel;
            System.Windows.Forms.Label details_diagnosticLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireConsultation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.medecin_idComboBox = new System.Windows.Forms.ComboBox();
            this.consultation_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_maladesDataSet = new gestion_malades.gestion_maladesDataSet();
            this.malade_idComboBox = new System.Windows.Forms.ComboBox();
            this.symptomeTextBox = new System.Windows.Forms.TextBox();
            this.tension_arterielleTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.date_consultationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.details_diagnosticTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.consultation_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.consultation_tabTableAdapter();
            this.tableAdapterManager = new gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager();
            this.consultation_tabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultation_tabDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecintabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecin_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.medecin_tabTableAdapter();
            this.maladetabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.malade_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.malade_tabTableAdapter();
            this.fichemaladeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fiche_maladeTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.fiche_maladeTableAdapter();
            this.nom_maladeTextBox = new System.Windows.Forms.TextBox();
            this.nom_medecinTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            medecin_idLabel = new System.Windows.Forms.Label();
            malade_idLabel = new System.Windows.Forms.Label();
            symptomeLabel = new System.Windows.Forms.Label();
            tension_arterielleLabel = new System.Windows.Forms.Label();
            temperatureLabel = new System.Windows.Forms.Label();
            date_consultationLabel = new System.Windows.Forms.Label();
            details_diagnosticLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultation_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultation_tabBindingNavigator)).BeginInit();
            this.consultation_tabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultation_tabDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecintabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maladetabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichemaladeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // medecin_idLabel
            // 
            medecin_idLabel.AutoSize = true;
            medecin_idLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medecin_idLabel.Location = new System.Drawing.Point(25, 53);
            medecin_idLabel.Name = "medecin_idLabel";
            medecin_idLabel.Size = new System.Drawing.Size(99, 22);
            medecin_idLabel.TabIndex = 1;
            medecin_idLabel.Text = "medecin id:";
            // 
            // malade_idLabel
            // 
            malade_idLabel.AutoSize = true;
            malade_idLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            malade_idLabel.Location = new System.Drawing.Point(25, 97);
            malade_idLabel.Name = "malade_idLabel";
            malade_idLabel.Size = new System.Drawing.Size(89, 22);
            malade_idLabel.TabIndex = 3;
            malade_idLabel.Text = "malade id:";
            // 
            // symptomeLabel
            // 
            symptomeLabel.AutoSize = true;
            symptomeLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            symptomeLabel.Location = new System.Drawing.Point(112, 129);
            symptomeLabel.Name = "symptomeLabel";
            symptomeLabel.Size = new System.Drawing.Size(93, 22);
            symptomeLabel.TabIndex = 5;
            symptomeLabel.Text = "symptome:";
            // 
            // tension_arterielleLabel
            // 
            tension_arterielleLabel.AutoSize = true;
            tension_arterielleLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tension_arterielleLabel.Location = new System.Drawing.Point(60, 161);
            tension_arterielleLabel.Name = "tension_arterielleLabel";
            tension_arterielleLabel.Size = new System.Drawing.Size(145, 22);
            tension_arterielleLabel.TabIndex = 7;
            tension_arterielleLabel.Text = "tension arterielle:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            temperatureLabel.Location = new System.Drawing.Point(95, 193);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(110, 22);
            temperatureLabel.TabIndex = 9;
            temperatureLabel.Text = "temperature:";
            // 
            // date_consultationLabel
            // 
            date_consultationLabel.AutoSize = true;
            date_consultationLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_consultationLabel.Location = new System.Drawing.Point(60, 225);
            date_consultationLabel.Name = "date_consultationLabel";
            date_consultationLabel.Size = new System.Drawing.Size(147, 22);
            date_consultationLabel.TabIndex = 11;
            date_consultationLabel.Text = "date consultation:";
            // 
            // details_diagnosticLabel
            // 
            details_diagnosticLabel.AutoSize = true;
            details_diagnosticLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            details_diagnosticLabel.Location = new System.Drawing.Point(60, 258);
            details_diagnosticLabel.Name = "details_diagnosticLabel";
            details_diagnosticLabel.Size = new System.Drawing.Size(148, 22);
            details_diagnosticLabel.TabIndex = 13;
            details_diagnosticLabel.Text = "details diagnostic:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nom_medecinTextBox);
            this.panel1.Controls.Add(this.nom_maladeTextBox);
            this.panel1.Controls.Add(medecin_idLabel);
            this.panel1.Controls.Add(this.medecin_idComboBox);
            this.panel1.Controls.Add(malade_idLabel);
            this.panel1.Controls.Add(this.malade_idComboBox);
            this.panel1.Controls.Add(symptomeLabel);
            this.panel1.Controls.Add(this.symptomeTextBox);
            this.panel1.Controls.Add(tension_arterielleLabel);
            this.panel1.Controls.Add(this.tension_arterielleTextBox);
            this.panel1.Controls.Add(temperatureLabel);
            this.panel1.Controls.Add(this.temperatureTextBox);
            this.panel1.Controls.Add(date_consultationLabel);
            this.panel1.Controls.Add(this.date_consultationDateTimePicker);
            this.panel1.Controls.Add(details_diagnosticLabel);
            this.panel1.Controls.Add(this.details_diagnosticTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 341);
            this.panel1.TabIndex = 0;
            // 
            // medecin_idComboBox
            // 
            this.medecin_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultation_tabBindingSource, "medecin_id", true));
            this.medecin_idComboBox.DataSource = this.medecintabBindingSource;
            this.medecin_idComboBox.DisplayMember = "num_medecin";
            this.medecin_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medecin_idComboBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecin_idComboBox.FormattingEnabled = true;
            this.medecin_idComboBox.Location = new System.Drawing.Point(211, 45);
            this.medecin_idComboBox.Name = "medecin_idComboBox";
            this.medecin_idComboBox.Size = new System.Drawing.Size(171, 30);
            this.medecin_idComboBox.TabIndex = 2;
            this.medecin_idComboBox.ValueMember = "num_medecin";
            // 
            // consultation_tabBindingSource
            // 
            this.consultation_tabBindingSource.DataMember = "consultation_tab";
            this.consultation_tabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // gestion_maladesDataSet
            // 
            this.gestion_maladesDataSet.DataSetName = "gestion_maladesDataSet";
            this.gestion_maladesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // malade_idComboBox
            // 
            this.malade_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultation_tabBindingSource, "malade_id", true));
            this.malade_idComboBox.DataSource = this.fichemaladeBindingSource;
            this.malade_idComboBox.DisplayMember = "numero_fiche";
            this.malade_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.malade_idComboBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malade_idComboBox.FormattingEnabled = true;
            this.malade_idComboBox.Location = new System.Drawing.Point(211, 89);
            this.malade_idComboBox.Name = "malade_idComboBox";
            this.malade_idComboBox.Size = new System.Drawing.Size(171, 30);
            this.malade_idComboBox.TabIndex = 4;
            this.malade_idComboBox.ValueMember = "numero_fiche";
            // 
            // symptomeTextBox
            // 
            this.symptomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultation_tabBindingSource, "symptome", true));
            this.symptomeTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomeTextBox.Location = new System.Drawing.Point(211, 125);
            this.symptomeTextBox.Name = "symptomeTextBox";
            this.symptomeTextBox.Size = new System.Drawing.Size(378, 26);
            this.symptomeTextBox.TabIndex = 6;
            // 
            // tension_arterielleTextBox
            // 
            this.tension_arterielleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultation_tabBindingSource, "tension_arterielle", true));
            this.tension_arterielleTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tension_arterielleTextBox.Location = new System.Drawing.Point(211, 157);
            this.tension_arterielleTextBox.Name = "tension_arterielleTextBox";
            this.tension_arterielleTextBox.Size = new System.Drawing.Size(378, 26);
            this.tension_arterielleTextBox.TabIndex = 8;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultation_tabBindingSource, "temperature", true));
            this.temperatureTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureTextBox.Location = new System.Drawing.Point(211, 189);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(378, 26);
            this.temperatureTextBox.TabIndex = 10;
            // 
            // date_consultationDateTimePicker
            // 
            this.date_consultationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultation_tabBindingSource, "date_consultation", true));
            this.date_consultationDateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_consultationDateTimePicker.Location = new System.Drawing.Point(211, 221);
            this.date_consultationDateTimePicker.Name = "date_consultationDateTimePicker";
            this.date_consultationDateTimePicker.Size = new System.Drawing.Size(378, 26);
            this.date_consultationDateTimePicker.TabIndex = 12;
            // 
            // details_diagnosticTextBox
            // 
            this.details_diagnosticTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultation_tabBindingSource, "details_diagnostic", true));
            this.details_diagnosticTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_diagnosticTextBox.Location = new System.Drawing.Point(211, 258);
            this.details_diagnosticTextBox.Name = "details_diagnosticTextBox";
            this.details_diagnosticTextBox.Size = new System.Drawing.Size(378, 26);
            this.details_diagnosticTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultation Malade";
            // 
            // consultation_tabTableAdapter
            // 
            this.consultation_tabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bon_analyse_tabTableAdapter = null;
            this.tableAdapterManager.consultation_tabTableAdapter = this.consultation_tabTableAdapter;
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
            // consultation_tabBindingNavigator
            // 
            this.consultation_tabBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultation_tabBindingNavigator.BackColor = System.Drawing.Color.Black;
            this.consultation_tabBindingNavigator.BindingSource = this.consultation_tabBindingSource;
            this.consultation_tabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultation_tabBindingNavigator.DeleteItem = null;
            this.consultation_tabBindingNavigator.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultation_tabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.consultation_tabBindingNavigator.Location = new System.Drawing.Point(0, 341);
            this.consultation_tabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultation_tabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultation_tabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultation_tabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultation_tabBindingNavigator.Name = "consultation_tabBindingNavigator";
            this.consultation_tabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultation_tabBindingNavigator.Size = new System.Drawing.Size(737, 25);
            this.consultation_tabBindingNavigator.TabIndex = 1;
            this.consultation_tabBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // consultation_tabDataGridView
            // 
            this.consultation_tabDataGridView.AutoGenerateColumns = false;
            this.consultation_tabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consultation_tabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultation_tabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.consultation_tabDataGridView.DataSource = this.consultation_tabBindingSource;
            this.consultation_tabDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.consultation_tabDataGridView.Location = new System.Drawing.Point(0, 366);
            this.consultation_tabDataGridView.Name = "consultation_tabDataGridView";
            this.consultation_tabDataGridView.Size = new System.Drawing.Size(737, 220);
            this.consultation_tabDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "medecin_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "medecin_id";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "symptome";
            this.dataGridViewTextBoxColumn3.HeaderText = "symptome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tension_arterielle";
            this.dataGridViewTextBoxColumn4.HeaderText = "tension_arterielle";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "temperature";
            this.dataGridViewTextBoxColumn5.HeaderText = "temperature";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "date_consultation";
            this.dataGridViewTextBoxColumn6.HeaderText = "date_consultation";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "details_diagnostic";
            this.dataGridViewTextBoxColumn7.HeaderText = "details_diagnostic";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // medecintabBindingSource
            // 
            this.medecintabBindingSource.DataMember = "medecin_tab";
            this.medecintabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // medecin_tabTableAdapter
            // 
            this.medecin_tabTableAdapter.ClearBeforeFill = true;
            // 
            // maladetabBindingSource
            // 
            this.maladetabBindingSource.DataMember = "malade_tab";
            this.maladetabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // malade_tabTableAdapter
            // 
            this.malade_tabTableAdapter.ClearBeforeFill = true;
            // 
            // fichemaladeBindingSource
            // 
            this.fichemaladeBindingSource.DataMember = "fiche_malade";
            this.fichemaladeBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // fiche_maladeTableAdapter
            // 
            this.fiche_maladeTableAdapter.ClearBeforeFill = true;
            // 
            // nom_maladeTextBox
            // 
            this.nom_maladeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichemaladeBindingSource, "nom_malade", true));
            this.nom_maladeTextBox.Location = new System.Drawing.Point(388, 95);
            this.nom_maladeTextBox.Name = "nom_maladeTextBox";
            this.nom_maladeTextBox.ReadOnly = true;
            this.nom_maladeTextBox.Size = new System.Drawing.Size(201, 20);
            this.nom_maladeTextBox.TabIndex = 16;
            // 
            // nom_medecinTextBox
            // 
            this.nom_medecinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecintabBindingSource, "nom_medecin", true));
            this.nom_medecinTextBox.Location = new System.Drawing.Point(388, 51);
            this.nom_medecinTextBox.Name = "nom_medecinTextBox";
            this.nom_medecinTextBox.ReadOnly = true;
            this.nom_medecinTextBox.Size = new System.Drawing.Size(201, 20);
            this.nom_medecinTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Sauvegarder données";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormulaireConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(737, 645);
            this.Controls.Add(this.consultation_tabDataGridView);
            this.Controls.Add(this.consultation_tabBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FormulaireConsultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireConsultation";
            this.Load += new System.EventHandler(this.FormulaireConsultation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultation_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultation_tabBindingNavigator)).EndInit();
            this.consultation_tabBindingNavigator.ResumeLayout(false);
            this.consultation_tabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultation_tabDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecintabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maladetabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichemaladeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private gestion_maladesDataSet gestion_maladesDataSet;
        private System.Windows.Forms.BindingSource consultation_tabBindingSource;
        private gestion_maladesDataSetTableAdapters.consultation_tabTableAdapter consultation_tabTableAdapter;
        private gestion_maladesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultation_tabBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ComboBox medecin_idComboBox;
        private System.Windows.Forms.ComboBox malade_idComboBox;
        private System.Windows.Forms.TextBox symptomeTextBox;
        private System.Windows.Forms.TextBox tension_arterielleTextBox;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.DateTimePicker date_consultationDateTimePicker;
        private System.Windows.Forms.TextBox details_diagnosticTextBox;
        private System.Windows.Forms.DataGridView consultation_tabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource medecintabBindingSource;
        private gestion_maladesDataSetTableAdapters.medecin_tabTableAdapter medecin_tabTableAdapter;
        private System.Windows.Forms.BindingSource maladetabBindingSource;
        private gestion_maladesDataSetTableAdapters.malade_tabTableAdapter malade_tabTableAdapter;
        private System.Windows.Forms.BindingSource fichemaladeBindingSource;
        private gestion_maladesDataSetTableAdapters.fiche_maladeTableAdapter fiche_maladeTableAdapter;
        private System.Windows.Forms.TextBox nom_medecinTextBox;
        private System.Windows.Forms.TextBox nom_maladeTextBox;
        private System.Windows.Forms.Button button1;
    }
}