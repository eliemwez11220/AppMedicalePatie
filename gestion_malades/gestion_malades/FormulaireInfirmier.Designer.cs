namespace gestion_malades
{
    partial class FormulaireInfirmier
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
            System.Windows.Forms.Label num_infirmierLabel;
            System.Windows.Forms.Label nom_infirmierLabel;
            System.Windows.Forms.Label grade_infirmierLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireInfirmier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.num_infirmierTextBox = new System.Windows.Forms.TextBox();
            this.infirmier_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_maladesDataSet = new gestion_malades.gestion_maladesDataSet();
            this.nom_infirmierTextBox = new System.Windows.Forms.TextBox();
            this.grade_infirmierTextBox = new System.Windows.Forms.TextBox();
            this.infirmier_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.infirmier_tabTableAdapter();
            this.tableAdapterManager = new gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager();
            this.infirmier_tabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.infirmier_tabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.infirmier_tabDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            num_infirmierLabel = new System.Windows.Forms.Label();
            nom_infirmierLabel = new System.Windows.Forms.Label();
            grade_infirmierLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infirmier_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infirmier_tabBindingNavigator)).BeginInit();
            this.infirmier_tabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infirmier_tabDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // num_infirmierLabel
            // 
            num_infirmierLabel.AutoSize = true;
            num_infirmierLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            num_infirmierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_infirmierLabel.Location = new System.Drawing.Point(23, 73);
            num_infirmierLabel.Name = "num_infirmierLabel";
            num_infirmierLabel.Size = new System.Drawing.Size(117, 20);
            num_infirmierLabel.TabIndex = 0;
            num_infirmierLabel.Text = "num infirmier:";
            // 
            // nom_infirmierLabel
            // 
            nom_infirmierLabel.AutoSize = true;
            nom_infirmierLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            nom_infirmierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_infirmierLabel.Location = new System.Drawing.Point(23, 105);
            nom_infirmierLabel.Name = "nom_infirmierLabel";
            nom_infirmierLabel.Size = new System.Drawing.Size(117, 20);
            nom_infirmierLabel.TabIndex = 2;
            nom_infirmierLabel.Text = "nom infirmier:";
            // 
            // grade_infirmierLabel
            // 
            grade_infirmierLabel.AutoSize = true;
            grade_infirmierLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            grade_infirmierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grade_infirmierLabel.Location = new System.Drawing.Point(23, 138);
            grade_infirmierLabel.Name = "grade_infirmierLabel";
            grade_infirmierLabel.Size = new System.Drawing.Size(129, 20);
            grade_infirmierLabel.TabIndex = 4;
            grade_infirmierLabel.Text = "grade infirmier:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(num_infirmierLabel);
            this.panel1.Controls.Add(this.num_infirmierTextBox);
            this.panel1.Controls.Add(nom_infirmierLabel);
            this.panel1.Controls.Add(this.nom_infirmierTextBox);
            this.panel1.Controls.Add(grade_infirmierLabel);
            this.panel1.Controls.Add(this.grade_infirmierTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 214);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fiche d\'Infirmière";
            // 
            // num_infirmierTextBox
            // 
            this.num_infirmierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infirmier_tabBindingSource, "num_infirmier", true));
            this.num_infirmierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_infirmierTextBox.Location = new System.Drawing.Point(158, 67);
            this.num_infirmierTextBox.Name = "num_infirmierTextBox";
            this.num_infirmierTextBox.Size = new System.Drawing.Size(331, 26);
            this.num_infirmierTextBox.TabIndex = 1;
            // 
            // infirmier_tabBindingSource
            // 
            this.infirmier_tabBindingSource.DataMember = "infirmier_tab";
            this.infirmier_tabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // gestion_maladesDataSet
            // 
            this.gestion_maladesDataSet.DataSetName = "gestion_maladesDataSet";
            this.gestion_maladesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nom_infirmierTextBox
            // 
            this.nom_infirmierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infirmier_tabBindingSource, "nom_infirmier", true));
            this.nom_infirmierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_infirmierTextBox.Location = new System.Drawing.Point(158, 99);
            this.nom_infirmierTextBox.Name = "nom_infirmierTextBox";
            this.nom_infirmierTextBox.Size = new System.Drawing.Size(331, 26);
            this.nom_infirmierTextBox.TabIndex = 3;
            // 
            // grade_infirmierTextBox
            // 
            this.grade_infirmierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infirmier_tabBindingSource, "grade_infirmier", true));
            this.grade_infirmierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_infirmierTextBox.Location = new System.Drawing.Point(158, 138);
            this.grade_infirmierTextBox.Name = "grade_infirmierTextBox";
            this.grade_infirmierTextBox.Size = new System.Drawing.Size(331, 26);
            this.grade_infirmierTextBox.TabIndex = 5;
            // 
            // infirmier_tabTableAdapter
            // 
            this.infirmier_tabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bon_analyse_tabTableAdapter = null;
            this.tableAdapterManager.consultation_tabTableAdapter = null;
            this.tableAdapterManager.fiche_maladeTableAdapter = null;
            this.tableAdapterManager.infirmier_tabTableAdapter = this.infirmier_tabTableAdapter;
            this.tableAdapterManager.malade_tabTableAdapter = null;
            this.tableAdapterManager.medecin_tabTableAdapter = null;
            this.tableAdapterManager.ordonnance_tabTableAdapter = null;
            this.tableAdapterManager.prescription_tabTableAdapter = null;
            this.tableAdapterManager.produit_tabTableAdapter = null;
            this.tableAdapterManager.resultats_laboratoire_tabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // infirmier_tabBindingNavigator
            // 
            this.infirmier_tabBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.infirmier_tabBindingNavigator.BackColor = System.Drawing.Color.Black;
            this.infirmier_tabBindingNavigator.BindingSource = this.infirmier_tabBindingSource;
            this.infirmier_tabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.infirmier_tabBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.infirmier_tabBindingNavigator.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infirmier_tabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.infirmier_tabBindingNavigatorSaveItem});
            this.infirmier_tabBindingNavigator.Location = new System.Drawing.Point(0, 214);
            this.infirmier_tabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.infirmier_tabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.infirmier_tabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.infirmier_tabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.infirmier_tabBindingNavigator.Name = "infirmier_tabBindingNavigator";
            this.infirmier_tabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.infirmier_tabBindingNavigator.Size = new System.Drawing.Size(659, 25);
            this.infirmier_tabBindingNavigator.TabIndex = 1;
            this.infirmier_tabBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 22);
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
            // infirmier_tabBindingNavigatorSaveItem
            // 
            this.infirmier_tabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infirmier_tabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("infirmier_tabBindingNavigatorSaveItem.Image")));
            this.infirmier_tabBindingNavigatorSaveItem.Name = "infirmier_tabBindingNavigatorSaveItem";
            this.infirmier_tabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.infirmier_tabBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.infirmier_tabBindingNavigatorSaveItem.Click += new System.EventHandler(this.infirmier_tabBindingNavigatorSaveItem_Click);
            // 
            // infirmier_tabDataGridView
            // 
            this.infirmier_tabDataGridView.AutoGenerateColumns = false;
            this.infirmier_tabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.infirmier_tabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infirmier_tabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.infirmier_tabDataGridView.DataSource = this.infirmier_tabBindingSource;
            this.infirmier_tabDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.infirmier_tabDataGridView.Location = new System.Drawing.Point(0, 239);
            this.infirmier_tabDataGridView.Name = "infirmier_tabDataGridView";
            this.infirmier_tabDataGridView.Size = new System.Drawing.Size(659, 306);
            this.infirmier_tabDataGridView.TabIndex = 2;
            this.infirmier_tabDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infirmier_tabDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "num_infirmier";
            this.dataGridViewTextBoxColumn1.HeaderText = "num_infirmier";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom_infirmier";
            this.dataGridViewTextBoxColumn2.HeaderText = "nom_infirmier";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "grade_infirmier";
            this.dataGridViewTextBoxColumn3.HeaderText = "grade_infirmier";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enregistrer infirmier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormulaireInfirmier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(659, 463);
            this.Controls.Add(this.infirmier_tabDataGridView);
            this.Controls.Add(this.infirmier_tabBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FormulaireInfirmier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormulaireInfirmier";
            this.Load += new System.EventHandler(this.FormulaireInfirmier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infirmier_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infirmier_tabBindingNavigator)).EndInit();
            this.infirmier_tabBindingNavigator.ResumeLayout(false);
            this.infirmier_tabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infirmier_tabDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private gestion_maladesDataSet gestion_maladesDataSet;
        private System.Windows.Forms.BindingSource infirmier_tabBindingSource;
        private gestion_maladesDataSetTableAdapters.infirmier_tabTableAdapter infirmier_tabTableAdapter;
        private gestion_maladesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator infirmier_tabBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton infirmier_tabBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox num_infirmierTextBox;
        private System.Windows.Forms.TextBox nom_infirmierTextBox;
        private System.Windows.Forms.TextBox grade_infirmierTextBox;
        private System.Windows.Forms.DataGridView infirmier_tabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}