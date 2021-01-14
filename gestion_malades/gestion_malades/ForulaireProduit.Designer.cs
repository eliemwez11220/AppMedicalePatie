namespace gestion_malades
{
    partial class ForulaireProduit
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
            System.Windows.Forms.Label num_produitLabel;
            System.Windows.Forms.Label designation_produitLabel;
            System.Windows.Forms.Label prix_produitLabel;
            System.Windows.Forms.Label qte_stock_produitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForulaireProduit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.num_produitTextBox = new System.Windows.Forms.TextBox();
            this.produit_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_maladesDataSet = new gestion_malades.gestion_maladesDataSet();
            this.designation_produitTextBox = new System.Windows.Forms.TextBox();
            this.prix_produitTextBox = new System.Windows.Forms.TextBox();
            this.qte_stock_produitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.produit_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.produit_tabTableAdapter();
            this.tableAdapterManager = new gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager();
            this.produit_tabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produit_tabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produit_tabDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            num_produitLabel = new System.Windows.Forms.Label();
            designation_produitLabel = new System.Windows.Forms.Label();
            prix_produitLabel = new System.Windows.Forms.Label();
            qte_stock_produitLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produit_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produit_tabBindingNavigator)).BeginInit();
            this.produit_tabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produit_tabDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // num_produitLabel
            // 
            num_produitLabel.AutoSize = true;
            num_produitLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_produitLabel.Location = new System.Drawing.Point(91, 55);
            num_produitLabel.Name = "num_produitLabel";
            num_produitLabel.Size = new System.Drawing.Size(108, 22);
            num_produitLabel.TabIndex = 1;
            num_produitLabel.Text = "num produit:";
            // 
            // designation_produitLabel
            // 
            designation_produitLabel.AutoSize = true;
            designation_produitLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            designation_produitLabel.Location = new System.Drawing.Point(36, 90);
            designation_produitLabel.Name = "designation_produitLabel";
            designation_produitLabel.Size = new System.Drawing.Size(163, 22);
            designation_produitLabel.TabIndex = 3;
            designation_produitLabel.Text = "designation produit:";
            // 
            // prix_produitLabel
            // 
            prix_produitLabel.AutoSize = true;
            prix_produitLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prix_produitLabel.Location = new System.Drawing.Point(94, 122);
            prix_produitLabel.Name = "prix_produitLabel";
            prix_produitLabel.Size = new System.Drawing.Size(105, 22);
            prix_produitLabel.TabIndex = 5;
            prix_produitLabel.Text = "prix produit:";
            // 
            // qte_stock_produitLabel
            // 
            qte_stock_produitLabel.AutoSize = true;
            qte_stock_produitLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qte_stock_produitLabel.Location = new System.Drawing.Point(53, 155);
            qte_stock_produitLabel.Name = "qte_stock_produitLabel";
            qte_stock_produitLabel.Size = new System.Drawing.Size(146, 22);
            qte_stock_produitLabel.TabIndex = 7;
            qte_stock_produitLabel.Text = "qte stock produit:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(num_produitLabel);
            this.panel1.Controls.Add(this.num_produitTextBox);
            this.panel1.Controls.Add(designation_produitLabel);
            this.panel1.Controls.Add(this.designation_produitTextBox);
            this.panel1.Controls.Add(prix_produitLabel);
            this.panel1.Controls.Add(this.prix_produitTextBox);
            this.panel1.Controls.Add(qte_stock_produitLabel);
            this.panel1.Controls.Add(this.qte_stock_produitTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 231);
            this.panel1.TabIndex = 0;
            // 
            // num_produitTextBox
            // 
            this.num_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produit_tabBindingSource, "num_produit", true));
            this.num_produitTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_produitTextBox.Location = new System.Drawing.Point(220, 55);
            this.num_produitTextBox.Name = "num_produitTextBox";
            this.num_produitTextBox.Size = new System.Drawing.Size(310, 26);
            this.num_produitTextBox.TabIndex = 2;
            // 
            // produit_tabBindingSource
            // 
            this.produit_tabBindingSource.DataMember = "produit_tab";
            this.produit_tabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // gestion_maladesDataSet
            // 
            this.gestion_maladesDataSet.DataSetName = "gestion_maladesDataSet";
            this.gestion_maladesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // designation_produitTextBox
            // 
            this.designation_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produit_tabBindingSource, "designation_produit", true));
            this.designation_produitTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation_produitTextBox.Location = new System.Drawing.Point(220, 87);
            this.designation_produitTextBox.Name = "designation_produitTextBox";
            this.designation_produitTextBox.Size = new System.Drawing.Size(310, 26);
            this.designation_produitTextBox.TabIndex = 4;
            // 
            // prix_produitTextBox
            // 
            this.prix_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produit_tabBindingSource, "prix_produit", true));
            this.prix_produitTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix_produitTextBox.Location = new System.Drawing.Point(220, 119);
            this.prix_produitTextBox.Name = "prix_produitTextBox";
            this.prix_produitTextBox.Size = new System.Drawing.Size(310, 26);
            this.prix_produitTextBox.TabIndex = 6;
            // 
            // qte_stock_produitTextBox
            // 
            this.qte_stock_produitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produit_tabBindingSource, "qte_stock_produit", true));
            this.qte_stock_produitTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_stock_produitTextBox.Location = new System.Drawing.Point(220, 151);
            this.qte_stock_produitTextBox.Name = "qte_stock_produitTextBox";
            this.qte_stock_produitTextBox.Size = new System.Drawing.Size(310, 26);
            this.qte_stock_produitTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulaire des produits";
            // 
            // produit_tabTableAdapter
            // 
            this.produit_tabTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.produit_tabTableAdapter = this.produit_tabTableAdapter;
            this.tableAdapterManager.resultats_laboratoire_tabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produit_tabBindingNavigator
            // 
            this.produit_tabBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produit_tabBindingNavigator.BackColor = System.Drawing.Color.Black;
            this.produit_tabBindingNavigator.BindingSource = this.produit_tabBindingSource;
            this.produit_tabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produit_tabBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produit_tabBindingNavigator.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit_tabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produit_tabBindingNavigatorSaveItem});
            this.produit_tabBindingNavigator.Location = new System.Drawing.Point(0, 231);
            this.produit_tabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produit_tabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produit_tabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produit_tabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produit_tabBindingNavigator.Name = "produit_tabBindingNavigator";
            this.produit_tabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produit_tabBindingNavigator.Size = new System.Drawing.Size(555, 25);
            this.produit_tabBindingNavigator.TabIndex = 1;
            this.produit_tabBindingNavigator.Text = "bindingNavigator1";
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
            // produit_tabBindingNavigatorSaveItem
            // 
            this.produit_tabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produit_tabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produit_tabBindingNavigatorSaveItem.Image")));
            this.produit_tabBindingNavigatorSaveItem.Name = "produit_tabBindingNavigatorSaveItem";
            this.produit_tabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produit_tabBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.produit_tabBindingNavigatorSaveItem.Click += new System.EventHandler(this.produit_tabBindingNavigatorSaveItem_Click);
            // 
            // produit_tabDataGridView
            // 
            this.produit_tabDataGridView.AutoGenerateColumns = false;
            this.produit_tabDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produit_tabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produit_tabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.produit_tabDataGridView.DataSource = this.produit_tabBindingSource;
            this.produit_tabDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.produit_tabDataGridView.Location = new System.Drawing.Point(0, 259);
            this.produit_tabDataGridView.Name = "produit_tabDataGridView";
            this.produit_tabDataGridView.Size = new System.Drawing.Size(555, 161);
            this.produit_tabDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "num_produit";
            this.dataGridViewTextBoxColumn1.HeaderText = "num_produit";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "designation_produit";
            this.dataGridViewTextBoxColumn2.HeaderText = "designation_produit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prix_produit";
            this.dataGridViewTextBoxColumn3.HeaderText = "prix_produit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qte_stock_produit";
            this.dataGridViewTextBoxColumn4.HeaderText = "qte_stock_produit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(290, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sauvegarder produit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForulaireProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 420);
            this.Controls.Add(this.produit_tabDataGridView);
            this.Controls.Add(this.produit_tabBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "ForulaireProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForulaireProduit";
            this.Load += new System.EventHandler(this.ForulaireProduit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produit_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produit_tabBindingNavigator)).EndInit();
            this.produit_tabBindingNavigator.ResumeLayout(false);
            this.produit_tabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produit_tabDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private gestion_maladesDataSet gestion_maladesDataSet;
        private System.Windows.Forms.BindingSource produit_tabBindingSource;
        private gestion_maladesDataSetTableAdapters.produit_tabTableAdapter produit_tabTableAdapter;
        private gestion_maladesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produit_tabBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produit_tabBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox num_produitTextBox;
        private System.Windows.Forms.TextBox designation_produitTextBox;
        private System.Windows.Forms.TextBox prix_produitTextBox;
        private System.Windows.Forms.TextBox qte_stock_produitTextBox;
        private System.Windows.Forms.DataGridView produit_tabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}