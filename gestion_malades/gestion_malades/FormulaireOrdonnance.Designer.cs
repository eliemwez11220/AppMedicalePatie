namespace gestion_malades
{
    partial class FormulaireOrdonnance
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
            System.Windows.Forms.Label numero_ordonnanceLabel;
            System.Windows.Forms.Label date_ordonnanceLabel;
            System.Windows.Forms.Label medecin_idLabel;
            System.Windows.Forms.Label ordonnance_numeroLabel;
            System.Windows.Forms.Label produit_idLabel;
            System.Windows.Forms.Label qte_prescriteLabel;
            System.Windows.Forms.Label mode_emploiLabel;
            System.Windows.Forms.Label designation_produitLabel;
            System.Windows.Forms.Label nom_medecinLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireOrdonnance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nom_medecinTextBox = new System.Windows.Forms.TextBox();
            this.medecin_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_maladesDataSet = new gestion_malades.gestion_maladesDataSet();
            this.medecin_idComboBox = new System.Windows.Forms.ComboBox();
            this.ordonnance_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designation_produitTextBox = new System.Windows.Forms.TextBox();
            this.produittabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ordonnance_numeroComboBox = new System.Windows.Forms.ComboBox();
            this.prescription_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produit_idComboBox = new System.Windows.Forms.ComboBox();
            this.qte_prescriteTextBox = new System.Windows.Forms.TextBox();
            this.mode_emploiTextBox = new System.Windows.Forms.TextBox();
            this.numero_ordonnanceTextBox = new System.Windows.Forms.TextBox();
            this.date_ordonnanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ordonnance_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.ordonnance_tabTableAdapter();
            this.tableAdapterManager = new gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager();
            this.ordonnance_tabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ordonnance_tabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prescription_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.prescription_tabTableAdapter();
            this.produit_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.produit_tabTableAdapter();
            this.medecin_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.medecin_tabTableAdapter();
            this.ordonnance_medicaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordonnance_medicaleTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.ordonnance_medicaleTableAdapter();
            this.prescription_tabDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numero_ordonnanceLabel = new System.Windows.Forms.Label();
            date_ordonnanceLabel = new System.Windows.Forms.Label();
            medecin_idLabel = new System.Windows.Forms.Label();
            ordonnance_numeroLabel = new System.Windows.Forms.Label();
            produit_idLabel = new System.Windows.Forms.Label();
            qte_prescriteLabel = new System.Windows.Forms.Label();
            mode_emploiLabel = new System.Windows.Forms.Label();
            designation_produitLabel = new System.Windows.Forms.Label();
            nom_medecinLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medecin_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnance_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produittabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnance_tabBindingNavigator)).BeginInit();
            this.ordonnance_tabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnance_medicaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_tabDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_ordonnanceLabel
            // 
            numero_ordonnanceLabel.AutoSize = true;
            numero_ordonnanceLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_ordonnanceLabel.Location = new System.Drawing.Point(21, 19);
            numero_ordonnanceLabel.Name = "numero_ordonnanceLabel";
            numero_ordonnanceLabel.Size = new System.Drawing.Size(169, 22);
            numero_ordonnanceLabel.TabIndex = 0;
            numero_ordonnanceLabel.Text = "numero ordonnance:";
            // 
            // date_ordonnanceLabel
            // 
            date_ordonnanceLabel.AutoSize = true;
            date_ordonnanceLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_ordonnanceLabel.Location = new System.Drawing.Point(21, 73);
            date_ordonnanceLabel.Name = "date_ordonnanceLabel";
            date_ordonnanceLabel.Size = new System.Drawing.Size(144, 22);
            date_ordonnanceLabel.TabIndex = 2;
            date_ordonnanceLabel.Text = "date ordonnance:";
            date_ordonnanceLabel.Click += new System.EventHandler(this.date_ordonnanceLabel_Click);
            // 
            // medecin_idLabel
            // 
            medecin_idLabel.AutoSize = true;
            medecin_idLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medecin_idLabel.Location = new System.Drawing.Point(21, 129);
            medecin_idLabel.Name = "medecin_idLabel";
            medecin_idLabel.Size = new System.Drawing.Size(166, 22);
            medecin_idLabel.TabIndex = 4;
            medecin_idLabel.Text = "medecin établisseur:";
            // 
            // ordonnance_numeroLabel
            // 
            ordonnance_numeroLabel.AutoSize = true;
            ordonnance_numeroLabel.Location = new System.Drawing.Point(469, 39);
            ordonnance_numeroLabel.Name = "ordonnance_numeroLabel";
            ordonnance_numeroLabel.Size = new System.Drawing.Size(105, 13);
            ordonnance_numeroLabel.TabIndex = 7;
            ordonnance_numeroLabel.Text = "ordonnance numero:";
            // 
            // produit_idLabel
            // 
            produit_idLabel.AutoSize = true;
            produit_idLabel.Location = new System.Drawing.Point(469, 66);
            produit_idLabel.Name = "produit_idLabel";
            produit_idLabel.Size = new System.Drawing.Size(53, 13);
            produit_idLabel.TabIndex = 9;
            produit_idLabel.Text = "produit id:";
            // 
            // qte_prescriteLabel
            // 
            qte_prescriteLabel.AutoSize = true;
            qte_prescriteLabel.Location = new System.Drawing.Point(469, 132);
            qte_prescriteLabel.Name = "qte_prescriteLabel";
            qte_prescriteLabel.Size = new System.Drawing.Size(68, 13);
            qte_prescriteLabel.TabIndex = 11;
            qte_prescriteLabel.Text = "qte prescrite:";
            // 
            // mode_emploiLabel
            // 
            mode_emploiLabel.AutoSize = true;
            mode_emploiLabel.Location = new System.Drawing.Point(469, 158);
            mode_emploiLabel.Name = "mode_emploiLabel";
            mode_emploiLabel.Size = new System.Drawing.Size(69, 13);
            mode_emploiLabel.TabIndex = 13;
            mode_emploiLabel.Text = "mode emploi:";
            // 
            // designation_produitLabel
            // 
            designation_produitLabel.AutoSize = true;
            designation_produitLabel.Location = new System.Drawing.Point(475, 93);
            designation_produitLabel.Name = "designation_produitLabel";
            designation_produitLabel.Size = new System.Drawing.Size(99, 13);
            designation_produitLabel.TabIndex = 17;
            designation_produitLabel.Text = "designation produit:";
            // 
            // nom_medecinLabel
            // 
            nom_medecinLabel.AutoSize = true;
            nom_medecinLabel.Location = new System.Drawing.Point(108, 161);
            nom_medecinLabel.Name = "nom_medecinLabel";
            nom_medecinLabel.Size = new System.Drawing.Size(73, 13);
            nom_medecinLabel.TabIndex = 19;
            nom_medecinLabel.Text = "nom medecin:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(nom_medecinLabel);
            this.panel1.Controls.Add(this.nom_medecinTextBox);
            this.panel1.Controls.Add(this.medecin_idComboBox);
            this.panel1.Controls.Add(designation_produitLabel);
            this.panel1.Controls.Add(this.designation_produitTextBox);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(ordonnance_numeroLabel);
            this.panel1.Controls.Add(this.ordonnance_numeroComboBox);
            this.panel1.Controls.Add(produit_idLabel);
            this.panel1.Controls.Add(this.produit_idComboBox);
            this.panel1.Controls.Add(qte_prescriteLabel);
            this.panel1.Controls.Add(this.qte_prescriteTextBox);
            this.panel1.Controls.Add(mode_emploiLabel);
            this.panel1.Controls.Add(this.mode_emploiTextBox);
            this.panel1.Controls.Add(numero_ordonnanceLabel);
            this.panel1.Controls.Add(this.numero_ordonnanceTextBox);
            this.panel1.Controls.Add(date_ordonnanceLabel);
            this.panel1.Controls.Add(this.date_ordonnanceDateTimePicker);
            this.panel1.Controls.Add(medecin_idLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 242);
            this.panel1.TabIndex = 0;
            // 
            // nom_medecinTextBox
            // 
            this.nom_medecinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecin_tabBindingSource, "nom_medecin", true));
            this.nom_medecinTextBox.Location = new System.Drawing.Point(187, 158);
            this.nom_medecinTextBox.Name = "nom_medecinTextBox";
            this.nom_medecinTextBox.Size = new System.Drawing.Size(121, 20);
            this.nom_medecinTextBox.TabIndex = 20;
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
            // medecin_idComboBox
            // 
            this.medecin_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordonnance_tabBindingSource, "medecin_id", true));
            this.medecin_idComboBox.DataSource = this.medecin_tabBindingSource;
            this.medecin_idComboBox.DisplayMember = "num_medecin";
            this.medecin_idComboBox.FormattingEnabled = true;
            this.medecin_idComboBox.Location = new System.Drawing.Point(187, 130);
            this.medecin_idComboBox.Name = "medecin_idComboBox";
            this.medecin_idComboBox.Size = new System.Drawing.Size(121, 21);
            this.medecin_idComboBox.TabIndex = 19;
            this.medecin_idComboBox.ValueMember = "num_medecin";
            // 
            // ordonnance_tabBindingSource
            // 
            this.ordonnance_tabBindingSource.DataMember = "ordonnance_tab";
            this.ordonnance_tabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // designation_produitTextBox
            // 
            this.designation_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produittabBindingSource, "designation_produit", true));
            this.designation_produitTextBox.Location = new System.Drawing.Point(580, 90);
            this.designation_produitTextBox.Name = "designation_produitTextBox";
            this.designation_produitTextBox.ReadOnly = true;
            this.designation_produitTextBox.Size = new System.Drawing.Size(184, 20);
            this.designation_produitTextBox.TabIndex = 18;
            // 
            // produittabBindingSource
            // 
            this.produittabBindingSource.DataMember = "produit_tab";
            this.produittabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(580, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ajouter produit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(313, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Créer ordonnance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordonnance_numeroComboBox
            // 
            this.ordonnance_numeroComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescription_tabBindingSource, "ordonnance_numero", true));
            this.ordonnance_numeroComboBox.DataSource = this.ordonnance_tabBindingSource;
            this.ordonnance_numeroComboBox.DisplayMember = "numero_ordonnance";
            this.ordonnance_numeroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ordonnance_numeroComboBox.FormattingEnabled = true;
            this.ordonnance_numeroComboBox.Location = new System.Drawing.Point(580, 36);
            this.ordonnance_numeroComboBox.Name = "ordonnance_numeroComboBox";
            this.ordonnance_numeroComboBox.Size = new System.Drawing.Size(184, 21);
            this.ordonnance_numeroComboBox.TabIndex = 8;
            this.ordonnance_numeroComboBox.ValueMember = "numero_ordonnance";
            // 
            // prescription_tabBindingSource
            // 
            this.prescription_tabBindingSource.DataMember = "prescription_tab";
            this.prescription_tabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // produit_idComboBox
            // 
            this.produit_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescription_tabBindingSource, "produit_id", true));
            this.produit_idComboBox.DataSource = this.produittabBindingSource;
            this.produit_idComboBox.DisplayMember = "num_produit";
            this.produit_idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produit_idComboBox.FormattingEnabled = true;
            this.produit_idComboBox.Location = new System.Drawing.Point(580, 63);
            this.produit_idComboBox.Name = "produit_idComboBox";
            this.produit_idComboBox.Size = new System.Drawing.Size(184, 21);
            this.produit_idComboBox.TabIndex = 10;
            this.produit_idComboBox.ValueMember = "num_produit";
            // 
            // qte_prescriteTextBox
            // 
            this.qte_prescriteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescription_tabBindingSource, "qte_prescrite", true));
            this.qte_prescriteTextBox.Location = new System.Drawing.Point(580, 129);
            this.qte_prescriteTextBox.Name = "qte_prescriteTextBox";
            this.qte_prescriteTextBox.Size = new System.Drawing.Size(184, 20);
            this.qte_prescriteTextBox.TabIndex = 12;
            // 
            // mode_emploiTextBox
            // 
            this.mode_emploiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescription_tabBindingSource, "mode_emploi", true));
            this.mode_emploiTextBox.Location = new System.Drawing.Point(580, 155);
            this.mode_emploiTextBox.Name = "mode_emploiTextBox";
            this.mode_emploiTextBox.Size = new System.Drawing.Size(184, 20);
            this.mode_emploiTextBox.TabIndex = 14;
            // 
            // numero_ordonnanceTextBox
            // 
            this.numero_ordonnanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordonnance_tabBindingSource, "numero_ordonnance", true));
            this.numero_ordonnanceTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_ordonnanceTextBox.Location = new System.Drawing.Point(25, 44);
            this.numero_ordonnanceTextBox.Name = "numero_ordonnanceTextBox";
            this.numero_ordonnanceTextBox.Size = new System.Drawing.Size(283, 26);
            this.numero_ordonnanceTextBox.TabIndex = 1;
            // 
            // date_ordonnanceDateTimePicker
            // 
            this.date_ordonnanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordonnance_tabBindingSource, "date_ordonnance", true));
            this.date_ordonnanceDateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ordonnanceDateTimePicker.Location = new System.Drawing.Point(25, 98);
            this.date_ordonnanceDateTimePicker.Name = "date_ordonnanceDateTimePicker";
            this.date_ordonnanceDateTimePicker.Size = new System.Drawing.Size(283, 26);
            this.date_ordonnanceDateTimePicker.TabIndex = 3;
            // 
            // ordonnance_tabTableAdapter
            // 
            this.ordonnance_tabTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ordonnance_tabTableAdapter = this.ordonnance_tabTableAdapter;
            this.tableAdapterManager.prescription_tabTableAdapter = null;
            this.tableAdapterManager.produit_tabTableAdapter = null;
            this.tableAdapterManager.resultats_laboratoire_tabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordonnance_tabBindingNavigator
            // 
            this.ordonnance_tabBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordonnance_tabBindingNavigator.BackColor = System.Drawing.Color.Black;
            this.ordonnance_tabBindingNavigator.BindingSource = this.ordonnance_tabBindingSource;
            this.ordonnance_tabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordonnance_tabBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordonnance_tabBindingNavigator.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordonnance_tabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ordonnance_tabBindingNavigatorSaveItem});
            this.ordonnance_tabBindingNavigator.Location = new System.Drawing.Point(0, 242);
            this.ordonnance_tabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordonnance_tabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordonnance_tabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordonnance_tabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordonnance_tabBindingNavigator.Name = "ordonnance_tabBindingNavigator";
            this.ordonnance_tabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordonnance_tabBindingNavigator.Size = new System.Drawing.Size(837, 25);
            this.ordonnance_tabBindingNavigator.TabIndex = 1;
            this.ordonnance_tabBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 22);
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
            // ordonnance_tabBindingNavigatorSaveItem
            // 
            this.ordonnance_tabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordonnance_tabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordonnance_tabBindingNavigatorSaveItem.Image")));
            this.ordonnance_tabBindingNavigatorSaveItem.Name = "ordonnance_tabBindingNavigatorSaveItem";
            this.ordonnance_tabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordonnance_tabBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.ordonnance_tabBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordonnance_tabBindingNavigatorSaveItem_Click);
            // 
            // prescription_tabTableAdapter
            // 
            this.prescription_tabTableAdapter.ClearBeforeFill = true;
            // 
            // produit_tabTableAdapter
            // 
            this.produit_tabTableAdapter.ClearBeforeFill = true;
            // 
            // medecin_tabTableAdapter
            // 
            this.medecin_tabTableAdapter.ClearBeforeFill = true;
            // 
            // ordonnance_medicaleBindingSource
            // 
            this.ordonnance_medicaleBindingSource.DataMember = "ordonnance_medicale";
            this.ordonnance_medicaleBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // ordonnance_medicaleTableAdapter
            // 
            this.ordonnance_medicaleTableAdapter.ClearBeforeFill = true;
            // 
            // prescription_tabDataGridView
            // 
            this.prescription_tabDataGridView.AutoGenerateColumns = false;
            this.prescription_tabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prescription_tabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescription_tabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.prescription_tabDataGridView.DataSource = this.prescription_tabBindingSource;
            this.prescription_tabDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prescription_tabDataGridView.Location = new System.Drawing.Point(0, 276);
            this.prescription_tabDataGridView.Name = "prescription_tabDataGridView";
            this.prescription_tabDataGridView.Size = new System.Drawing.Size(837, 220);
            this.prescription_tabDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ordonnance_numero";
            this.dataGridViewTextBoxColumn1.HeaderText = "ordonnance_numero";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "produit_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "produit_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "qte_prescrite";
            this.dataGridViewTextBoxColumn3.HeaderText = "qte_prescrite";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mode_emploi";
            this.dataGridViewTextBoxColumn4.HeaderText = "mode_emploi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormulaireOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 496);
            this.Controls.Add(this.prescription_tabDataGridView);
            this.Controls.Add(this.ordonnance_tabBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FormulaireOrdonnance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireOrdonnance";
            this.Load += new System.EventHandler(this.FormulaireOrdonnance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medecin_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnance_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produittabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnance_tabBindingNavigator)).EndInit();
            this.ordonnance_tabBindingNavigator.ResumeLayout(false);
            this.ordonnance_tabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordonnance_medicaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_tabDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private gestion_maladesDataSet gestion_maladesDataSet;
        private System.Windows.Forms.BindingSource ordonnance_tabBindingSource;
        private gestion_maladesDataSetTableAdapters.ordonnance_tabTableAdapter ordonnance_tabTableAdapter;
        private gestion_maladesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordonnance_tabBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ordonnance_tabBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numero_ordonnanceTextBox;
        private System.Windows.Forms.DateTimePicker date_ordonnanceDateTimePicker;
        private System.Windows.Forms.BindingSource prescription_tabBindingSource;
        private gestion_maladesDataSetTableAdapters.prescription_tabTableAdapter prescription_tabTableAdapter;
        private System.Windows.Forms.ComboBox ordonnance_numeroComboBox;
        private System.Windows.Forms.ComboBox produit_idComboBox;
        private System.Windows.Forms.TextBox qte_prescriteTextBox;
        private System.Windows.Forms.TextBox mode_emploiTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource produittabBindingSource;
        private gestion_maladesDataSetTableAdapters.produit_tabTableAdapter produit_tabTableAdapter;
        private System.Windows.Forms.ComboBox medecin_idComboBox;
        private System.Windows.Forms.TextBox designation_produitTextBox;
        private System.Windows.Forms.BindingSource medecin_tabBindingSource;
        private gestion_maladesDataSetTableAdapters.medecin_tabTableAdapter medecin_tabTableAdapter;
        private System.Windows.Forms.TextBox nom_medecinTextBox;
        private System.Windows.Forms.BindingSource ordonnance_medicaleBindingSource;
        private gestion_maladesDataSetTableAdapters.ordonnance_medicaleTableAdapter ordonnance_medicaleTableAdapter;
        private System.Windows.Forms.DataGridView prescription_tabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}