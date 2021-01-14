namespace gestion_malades
{
    partial class FormMalades
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
            System.Windows.Forms.Label numero_ficheLabel;
            System.Windows.Forms.Label date_ficheLabel;
            System.Windows.Forms.Label nom_maladeLabel;
            System.Windows.Forms.Label sexe_maladeLabel;
            System.Windows.Forms.Label telephone_maladeLabel;
            System.Windows.Forms.Label adresse_maladeLabel;
            System.Windows.Forms.Label age_maladeLabel;
            System.Windows.Forms.Label categorie_maladeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMalades));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numero_ficheTextBox = new System.Windows.Forms.TextBox();
            this.fiche_maladeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_maladesDataSet = new gestion_malades.gestion_maladesDataSet();
            this.date_ficheDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nom_maladeTextBox = new System.Windows.Forms.TextBox();
            this.sexe_maladeComboBox = new System.Windows.Forms.ComboBox();
            this.telephone_maladeTextBox = new System.Windows.Forms.TextBox();
            this.adresse_maladeTextBox = new System.Windows.Forms.TextBox();
            this.age_maladeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.categorie_maladeComboBox = new System.Windows.Forms.ComboBox();
            this.fiche_maladeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fiche_maladeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fiche_maladeTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.fiche_maladeTableAdapter();
            this.tableAdapterManager = new gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager();
            this.fiche_maladeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numero_ficheLabel = new System.Windows.Forms.Label();
            date_ficheLabel = new System.Windows.Forms.Label();
            nom_maladeLabel = new System.Windows.Forms.Label();
            sexe_maladeLabel = new System.Windows.Forms.Label();
            telephone_maladeLabel = new System.Windows.Forms.Label();
            adresse_maladeLabel = new System.Windows.Forms.Label();
            age_maladeLabel = new System.Windows.Forms.Label();
            categorie_maladeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiche_maladeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_maladeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiche_maladeBindingNavigator)).BeginInit();
            this.fiche_maladeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiche_maladeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_ficheLabel
            // 
            numero_ficheLabel.AutoSize = true;
            numero_ficheLabel.Location = new System.Drawing.Point(18, 56);
            numero_ficheLabel.Name = "numero_ficheLabel";
            numero_ficheLabel.Size = new System.Drawing.Size(117, 22);
            numero_ficheLabel.TabIndex = 1;
            numero_ficheLabel.Text = "numero fiche:";
            // 
            // date_ficheLabel
            // 
            date_ficheLabel.AutoSize = true;
            date_ficheLabel.Location = new System.Drawing.Point(18, 89);
            date_ficheLabel.Name = "date_ficheLabel";
            date_ficheLabel.Size = new System.Drawing.Size(92, 22);
            date_ficheLabel.TabIndex = 3;
            date_ficheLabel.Text = "date fiche:";
            // 
            // nom_maladeLabel
            // 
            nom_maladeLabel.AutoSize = true;
            nom_maladeLabel.Location = new System.Drawing.Point(18, 121);
            nom_maladeLabel.Name = "nom_maladeLabel";
            nom_maladeLabel.Size = new System.Drawing.Size(108, 22);
            nom_maladeLabel.TabIndex = 5;
            nom_maladeLabel.Text = "nom malade:";
            // 
            // sexe_maladeLabel
            // 
            sexe_maladeLabel.AutoSize = true;
            sexe_maladeLabel.Location = new System.Drawing.Point(18, 152);
            sexe_maladeLabel.Name = "sexe_maladeLabel";
            sexe_maladeLabel.Size = new System.Drawing.Size(108, 22);
            sexe_maladeLabel.TabIndex = 7;
            sexe_maladeLabel.Text = "sexe malade:";
            // 
            // telephone_maladeLabel
            // 
            telephone_maladeLabel.AutoSize = true;
            telephone_maladeLabel.Location = new System.Drawing.Point(434, 53);
            telephone_maladeLabel.Name = "telephone_maladeLabel";
            telephone_maladeLabel.Size = new System.Drawing.Size(149, 22);
            telephone_maladeLabel.TabIndex = 9;
            telephone_maladeLabel.Text = "telephone malade:";
            // 
            // adresse_maladeLabel
            // 
            adresse_maladeLabel.AutoSize = true;
            adresse_maladeLabel.Location = new System.Drawing.Point(434, 85);
            adresse_maladeLabel.Name = "adresse_maladeLabel";
            adresse_maladeLabel.Size = new System.Drawing.Size(132, 22);
            adresse_maladeLabel.TabIndex = 11;
            adresse_maladeLabel.Text = "adresse malade:";
            // 
            // age_maladeLabel
            // 
            age_maladeLabel.AutoSize = true;
            age_maladeLabel.Location = new System.Drawing.Point(434, 116);
            age_maladeLabel.Name = "age_maladeLabel";
            age_maladeLabel.Size = new System.Drawing.Size(102, 22);
            age_maladeLabel.TabIndex = 13;
            age_maladeLabel.Text = "age malade:";
            // 
            // categorie_maladeLabel
            // 
            categorie_maladeLabel.AutoSize = true;
            categorie_maladeLabel.Location = new System.Drawing.Point(434, 147);
            categorie_maladeLabel.Name = "categorie_maladeLabel";
            categorie_maladeLabel.Size = new System.Drawing.Size(148, 22);
            categorie_maladeLabel.TabIndex = 15;
            categorie_maladeLabel.Text = "categorie malade:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(numero_ficheLabel);
            this.panel1.Controls.Add(this.numero_ficheTextBox);
            this.panel1.Controls.Add(date_ficheLabel);
            this.panel1.Controls.Add(this.date_ficheDateTimePicker);
            this.panel1.Controls.Add(nom_maladeLabel);
            this.panel1.Controls.Add(this.nom_maladeTextBox);
            this.panel1.Controls.Add(sexe_maladeLabel);
            this.panel1.Controls.Add(this.sexe_maladeComboBox);
            this.panel1.Controls.Add(telephone_maladeLabel);
            this.panel1.Controls.Add(this.telephone_maladeTextBox);
            this.panel1.Controls.Add(adresse_maladeLabel);
            this.panel1.Controls.Add(this.adresse_maladeTextBox);
            this.panel1.Controls.Add(age_maladeLabel);
            this.panel1.Controls.Add(this.age_maladeNumericUpDown);
            this.panel1.Controls.Add(categorie_maladeLabel);
            this.panel1.Controls.Add(this.categorie_maladeComboBox);
            this.panel1.Controls.Add(this.fiche_maladeBindingNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 221);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Formulaire d\'identification des malades et creation fiches";
            // 
            // numero_ficheTextBox
            // 
            this.numero_ficheTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiche_maladeBindingSource, "numero_fiche", true));
            this.numero_ficheTextBox.Location = new System.Drawing.Point(141, 53);
            this.numero_ficheTextBox.Name = "numero_ficheTextBox";
            this.numero_ficheTextBox.Size = new System.Drawing.Size(251, 26);
            this.numero_ficheTextBox.TabIndex = 2;
            // 
            // fiche_maladeBindingSource
            // 
            this.fiche_maladeBindingSource.DataMember = "fiche_malade";
            this.fiche_maladeBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // gestion_maladesDataSet
            // 
            this.gestion_maladesDataSet.DataSetName = "gestion_maladesDataSet";
            this.gestion_maladesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // date_ficheDateTimePicker
            // 
            this.date_ficheDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fiche_maladeBindingSource, "date_fiche", true));
            this.date_ficheDateTimePicker.Location = new System.Drawing.Point(141, 85);
            this.date_ficheDateTimePicker.Name = "date_ficheDateTimePicker";
            this.date_ficheDateTimePicker.Size = new System.Drawing.Size(251, 26);
            this.date_ficheDateTimePicker.TabIndex = 4;
            // 
            // nom_maladeTextBox
            // 
            this.nom_maladeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiche_maladeBindingSource, "nom_malade", true));
            this.nom_maladeTextBox.Location = new System.Drawing.Point(141, 117);
            this.nom_maladeTextBox.Name = "nom_maladeTextBox";
            this.nom_maladeTextBox.Size = new System.Drawing.Size(251, 26);
            this.nom_maladeTextBox.TabIndex = 6;
            // 
            // sexe_maladeComboBox
            // 
            this.sexe_maladeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiche_maladeBindingSource, "sexe_malade", true));
            this.sexe_maladeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexe_maladeComboBox.FormattingEnabled = true;
            this.sexe_maladeComboBox.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.sexe_maladeComboBox.Location = new System.Drawing.Point(141, 149);
            this.sexe_maladeComboBox.Name = "sexe_maladeComboBox";
            this.sexe_maladeComboBox.Size = new System.Drawing.Size(251, 30);
            this.sexe_maladeComboBox.TabIndex = 8;
            // 
            // telephone_maladeTextBox
            // 
            this.telephone_maladeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiche_maladeBindingSource, "telephone_malade", true));
            this.telephone_maladeTextBox.Location = new System.Drawing.Point(589, 50);
            this.telephone_maladeTextBox.Name = "telephone_maladeTextBox";
            this.telephone_maladeTextBox.Size = new System.Drawing.Size(219, 26);
            this.telephone_maladeTextBox.TabIndex = 10;
            // 
            // adresse_maladeTextBox
            // 
            this.adresse_maladeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiche_maladeBindingSource, "adresse_malade", true));
            this.adresse_maladeTextBox.Location = new System.Drawing.Point(589, 80);
            this.adresse_maladeTextBox.Name = "adresse_maladeTextBox";
            this.adresse_maladeTextBox.Size = new System.Drawing.Size(219, 26);
            this.adresse_maladeTextBox.TabIndex = 12;
            // 
            // age_maladeNumericUpDown
            // 
            this.age_maladeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fiche_maladeBindingSource, "age_malade", true));
            this.age_maladeNumericUpDown.Location = new System.Drawing.Point(589, 112);
            this.age_maladeNumericUpDown.Name = "age_maladeNumericUpDown";
            this.age_maladeNumericUpDown.Size = new System.Drawing.Size(219, 26);
            this.age_maladeNumericUpDown.TabIndex = 14;
            // 
            // categorie_maladeComboBox
            // 
            this.categorie_maladeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fiche_maladeBindingSource, "categorie_malade", true));
            this.categorie_maladeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorie_maladeComboBox.FormattingEnabled = true;
            this.categorie_maladeComboBox.Items.AddRange(new object[] {
            "Abonné",
            "Privé",
            "Agent"});
            this.categorie_maladeComboBox.Location = new System.Drawing.Point(589, 144);
            this.categorie_maladeComboBox.Name = "categorie_maladeComboBox";
            this.categorie_maladeComboBox.Size = new System.Drawing.Size(219, 30);
            this.categorie_maladeComboBox.TabIndex = 16;
            // 
            // fiche_maladeBindingNavigator
            // 
            this.fiche_maladeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fiche_maladeBindingNavigator.BackColor = System.Drawing.Color.White;
            this.fiche_maladeBindingNavigator.BindingSource = this.fiche_maladeBindingSource;
            this.fiche_maladeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fiche_maladeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fiche_maladeBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fiche_maladeBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiche_maladeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fiche_maladeBindingNavigatorSaveItem});
            this.fiche_maladeBindingNavigator.Location = new System.Drawing.Point(0, 193);
            this.fiche_maladeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fiche_maladeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fiche_maladeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fiche_maladeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fiche_maladeBindingNavigator.Name = "fiche_maladeBindingNavigator";
            this.fiche_maladeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fiche_maladeBindingNavigator.Size = new System.Drawing.Size(834, 28);
            this.fiche_maladeBindingNavigator.TabIndex = 1;
            this.fiche_maladeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(51, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // fiche_maladeBindingNavigatorSaveItem
            // 
            this.fiche_maladeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fiche_maladeBindingNavigatorSaveItem.Image")));
            this.fiche_maladeBindingNavigatorSaveItem.Name = "fiche_maladeBindingNavigatorSaveItem";
            this.fiche_maladeBindingNavigatorSaveItem.Size = new System.Drawing.Size(207, 25);
            this.fiche_maladeBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.fiche_maladeBindingNavigatorSaveItem.Click += new System.EventHandler(this.fiche_maladeBindingNavigatorSaveItem_Click_1);
            // 
            // fiche_maladeTableAdapter
            // 
            this.fiche_maladeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bon_analyse_tabTableAdapter = null;
            this.tableAdapterManager.consultation_tabTableAdapter = null;
            this.tableAdapterManager.fiche_maladeTableAdapter = this.fiche_maladeTableAdapter;
            this.tableAdapterManager.infirmier_tabTableAdapter = null;
            this.tableAdapterManager.malade_tabTableAdapter = null;
            this.tableAdapterManager.medecin_tabTableAdapter = null;
            this.tableAdapterManager.ordonnance_tabTableAdapter = null;
            this.tableAdapterManager.prescription_tabTableAdapter = null;
            this.tableAdapterManager.produit_tabTableAdapter = null;
            this.tableAdapterManager.resultats_laboratoire_tabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fiche_maladeDataGridView
            // 
            this.fiche_maladeDataGridView.AutoGenerateColumns = false;
            this.fiche_maladeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fiche_maladeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fiche_maladeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.fiche_maladeDataGridView.DataSource = this.fiche_maladeBindingSource;
            this.fiche_maladeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fiche_maladeDataGridView.Location = new System.Drawing.Point(0, 227);
            this.fiche_maladeDataGridView.Name = "fiche_maladeDataGridView";
            this.fiche_maladeDataGridView.Size = new System.Drawing.Size(834, 212);
            this.fiche_maladeDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numero_fiche";
            this.dataGridViewTextBoxColumn1.HeaderText = "numero_fiche";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date_fiche";
            this.dataGridViewTextBoxColumn2.HeaderText = "date_fiche";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nom_malade";
            this.dataGridViewTextBoxColumn3.HeaderText = "nom_malade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sexe_malade";
            this.dataGridViewTextBoxColumn4.HeaderText = "sexe_malade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telephone_malade";
            this.dataGridViewTextBoxColumn5.HeaderText = "telephone_malade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "adresse_malade";
            this.dataGridViewTextBoxColumn6.HeaderText = "adresse_malade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "age_malade";
            this.dataGridViewTextBoxColumn7.HeaderText = "age_malade";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "categorie_malade";
            this.dataGridViewTextBoxColumn8.HeaderText = "categorie_malade";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // FormMalades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 439);
            this.Controls.Add(this.fiche_maladeDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FormMalades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMalades";
            this.Load += new System.EventHandler(this.FormMalades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiche_maladeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_maladeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiche_maladeBindingNavigator)).EndInit();
            this.fiche_maladeBindingNavigator.ResumeLayout(false);
            this.fiche_maladeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiche_maladeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private gestion_maladesDataSet gestion_maladesDataSet;
        private System.Windows.Forms.BindingSource fiche_maladeBindingSource;
        private gestion_maladesDataSetTableAdapters.fiche_maladeTableAdapter fiche_maladeTableAdapter;
        private gestion_maladesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fiche_maladeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fiche_maladeBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero_ficheTextBox;
        private System.Windows.Forms.DateTimePicker date_ficheDateTimePicker;
        private System.Windows.Forms.TextBox nom_maladeTextBox;
        private System.Windows.Forms.ComboBox sexe_maladeComboBox;
        private System.Windows.Forms.TextBox telephone_maladeTextBox;
        private System.Windows.Forms.TextBox adresse_maladeTextBox;
        private System.Windows.Forms.NumericUpDown age_maladeNumericUpDown;
        private System.Windows.Forms.ComboBox categorie_maladeComboBox;
        private System.Windows.Forms.DataGridView fiche_maladeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}