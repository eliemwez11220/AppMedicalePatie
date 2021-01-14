﻿namespace gestion_malades
{
    partial class FormulairePrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulairePrescription));
            System.Windows.Forms.Label ordonnance_numeroLabel;
            System.Windows.Forms.Label produit_idLabel;
            System.Windows.Forms.Label qte_prescriteLabel;
            System.Windows.Forms.Label mode_emploiLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gestion_maladesDataSet = new gestion_malades.gestion_maladesDataSet();
            this.prescription_tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescription_tabTableAdapter = new gestion_malades.gestion_maladesDataSetTableAdapters.prescription_tabTableAdapter();
            this.tableAdapterManager = new gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager();
            this.prescription_tabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prescription_tabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ordonnance_numeroComboBox = new System.Windows.Forms.ComboBox();
            this.produit_idComboBox = new System.Windows.Forms.ComboBox();
            this.qte_prescriteTextBox = new System.Windows.Forms.TextBox();
            this.mode_emploiTextBox = new System.Windows.Forms.TextBox();
            this.prescription_tabDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ordonnance_numeroLabel = new System.Windows.Forms.Label();
            produit_idLabel = new System.Windows.Forms.Label();
            qte_prescriteLabel = new System.Windows.Forms.Label();
            mode_emploiLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_tabBindingNavigator)).BeginInit();
            this.prescription_tabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_tabDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(ordonnance_numeroLabel);
            this.panel1.Controls.Add(this.ordonnance_numeroComboBox);
            this.panel1.Controls.Add(produit_idLabel);
            this.panel1.Controls.Add(this.produit_idComboBox);
            this.panel1.Controls.Add(qte_prescriteLabel);
            this.panel1.Controls.Add(this.qte_prescriteTextBox);
            this.panel1.Controls.Add(mode_emploiLabel);
            this.panel1.Controls.Add(this.mode_emploiTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 231);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prescription Médicale\r\n";
            // 
            // gestion_maladesDataSet
            // 
            this.gestion_maladesDataSet.DataSetName = "gestion_maladesDataSet";
            this.gestion_maladesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescription_tabBindingSource
            // 
            this.prescription_tabBindingSource.DataMember = "prescription_tab";
            this.prescription_tabBindingSource.DataSource = this.gestion_maladesDataSet;
            // 
            // prescription_tabTableAdapter
            // 
            this.prescription_tabTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.prescription_tabTableAdapter = this.prescription_tabTableAdapter;
            this.tableAdapterManager.produit_tabTableAdapter = null;
            this.tableAdapterManager.resultats_laboratoire_tabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = gestion_malades.gestion_maladesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prescription_tabBindingNavigator
            // 
            this.prescription_tabBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prescription_tabBindingNavigator.BackColor = System.Drawing.Color.Black;
            this.prescription_tabBindingNavigator.BindingSource = this.prescription_tabBindingSource;
            this.prescription_tabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prescription_tabBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prescription_tabBindingNavigator.Font = new System.Drawing.Font("MS Reference Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescription_tabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prescription_tabBindingNavigatorSaveItem});
            this.prescription_tabBindingNavigator.Location = new System.Drawing.Point(0, 231);
            this.prescription_tabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prescription_tabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prescription_tabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prescription_tabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prescription_tabBindingNavigator.Name = "prescription_tabBindingNavigator";
            this.prescription_tabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prescription_tabBindingNavigator.Size = new System.Drawing.Size(625, 25);
            this.prescription_tabBindingNavigator.TabIndex = 1;
            this.prescription_tabBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(56, 22);
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
            // prescription_tabBindingNavigatorSaveItem
            // 
            this.prescription_tabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prescription_tabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prescription_tabBindingNavigatorSaveItem.Image")));
            this.prescription_tabBindingNavigatorSaveItem.Name = "prescription_tabBindingNavigatorSaveItem";
            this.prescription_tabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prescription_tabBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.prescription_tabBindingNavigatorSaveItem.Click += new System.EventHandler(this.prescription_tabBindingNavigatorSaveItem_Click);
            // 
            // ordonnance_numeroLabel
            // 
            ordonnance_numeroLabel.AutoSize = true;
            ordonnance_numeroLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ordonnance_numeroLabel.Location = new System.Drawing.Point(24, 59);
            ordonnance_numeroLabel.Name = "ordonnance_numeroLabel";
            ordonnance_numeroLabel.Size = new System.Drawing.Size(169, 22);
            ordonnance_numeroLabel.TabIndex = 1;
            ordonnance_numeroLabel.Text = "ordonnance numero:";
            // 
            // ordonnance_numeroComboBox
            // 
            this.ordonnance_numeroComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescription_tabBindingSource, "ordonnance_numero", true));
            this.ordonnance_numeroComboBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordonnance_numeroComboBox.FormattingEnabled = true;
            this.ordonnance_numeroComboBox.Location = new System.Drawing.Point(199, 63);
            this.ordonnance_numeroComboBox.Name = "ordonnance_numeroComboBox";
            this.ordonnance_numeroComboBox.Size = new System.Drawing.Size(277, 30);
            this.ordonnance_numeroComboBox.TabIndex = 2;
            // 
            // produit_idLabel
            // 
            produit_idLabel.AutoSize = true;
            produit_idLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            produit_idLabel.Location = new System.Drawing.Point(24, 107);
            produit_idLabel.Name = "produit_idLabel";
            produit_idLabel.Size = new System.Drawing.Size(90, 22);
            produit_idLabel.TabIndex = 3;
            produit_idLabel.Text = "produit id:";
            // 
            // produit_idComboBox
            // 
            this.produit_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescription_tabBindingSource, "produit_id", true));
            this.produit_idComboBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produit_idComboBox.FormattingEnabled = true;
            this.produit_idComboBox.Location = new System.Drawing.Point(199, 99);
            this.produit_idComboBox.Name = "produit_idComboBox";
            this.produit_idComboBox.Size = new System.Drawing.Size(277, 30);
            this.produit_idComboBox.TabIndex = 4;
            // 
            // qte_prescriteLabel
            // 
            qte_prescriteLabel.AutoSize = true;
            qte_prescriteLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qte_prescriteLabel.Location = new System.Drawing.Point(24, 156);
            qte_prescriteLabel.Name = "qte_prescriteLabel";
            qte_prescriteLabel.Size = new System.Drawing.Size(113, 22);
            qte_prescriteLabel.TabIndex = 5;
            qte_prescriteLabel.Text = "qte prescrite:";
            // 
            // qte_prescriteTextBox
            // 
            this.qte_prescriteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescription_tabBindingSource, "qte_prescrite", true));
            this.qte_prescriteTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte_prescriteTextBox.Location = new System.Drawing.Point(199, 152);
            this.qte_prescriteTextBox.Name = "qte_prescriteTextBox";
            this.qte_prescriteTextBox.Size = new System.Drawing.Size(277, 26);
            this.qte_prescriteTextBox.TabIndex = 6;
            // 
            // mode_emploiLabel
            // 
            mode_emploiLabel.AutoSize = true;
            mode_emploiLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mode_emploiLabel.Location = new System.Drawing.Point(24, 196);
            mode_emploiLabel.Name = "mode_emploiLabel";
            mode_emploiLabel.Size = new System.Drawing.Size(114, 22);
            mode_emploiLabel.TabIndex = 7;
            mode_emploiLabel.Text = "mode emploi:";
            // 
            // mode_emploiTextBox
            // 
            this.mode_emploiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescription_tabBindingSource, "mode_emploi", true));
            this.mode_emploiTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode_emploiTextBox.Location = new System.Drawing.Point(199, 196);
            this.mode_emploiTextBox.Name = "mode_emploiTextBox";
            this.mode_emploiTextBox.Size = new System.Drawing.Size(277, 26);
            this.mode_emploiTextBox.TabIndex = 8;
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
            this.prescription_tabDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.prescription_tabDataGridView.Location = new System.Drawing.Point(0, 256);
            this.prescription_tabDataGridView.Name = "prescription_tabDataGridView";
            this.prescription_tabDataGridView.Size = new System.Drawing.Size(625, 270);
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
            // FormulairePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 511);
            this.Controls.Add(this.prescription_tabDataGridView);
            this.Controls.Add(this.prescription_tabBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FormulairePrescription";
            this.Text = "FormulairePrescription";
            this.Load += new System.EventHandler(this.FormulairePrescription_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_maladesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_tabBindingNavigator)).EndInit();
            this.prescription_tabBindingNavigator.ResumeLayout(false);
            this.prescription_tabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescription_tabDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private gestion_maladesDataSet gestion_maladesDataSet;
        private System.Windows.Forms.BindingSource prescription_tabBindingSource;
        private gestion_maladesDataSetTableAdapters.prescription_tabTableAdapter prescription_tabTableAdapter;
        private gestion_maladesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prescription_tabBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prescription_tabBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox ordonnance_numeroComboBox;
        private System.Windows.Forms.ComboBox produit_idComboBox;
        private System.Windows.Forms.TextBox qte_prescriteTextBox;
        private System.Windows.Forms.TextBox mode_emploiTextBox;
        private System.Windows.Forms.DataGridView prescription_tabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}