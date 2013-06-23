namespace Pi_projekt
{
    partial class frmPoslovni_partneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoslovni_partneri));
            this.btnObirsi = new System.Windows.Forms.Button();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pIDatabaseDataSet = new Pi_projekt.PIDatabaseDataSet();
            this.poslovni_partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poslovni_partnerTableAdapter = new Pi_projekt.PIDatabaseDataSetTableAdapters.Poslovni_partnerTableAdapter();
            this.tableAdapterManager = new Pi_projekt.PIDatabaseDataSetTableAdapters.TableAdapterManager();
            this.poslovni_partnerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.poslovni_partnerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.poslovni_partnerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pIDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovni_partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovni_partnerBindingNavigator)).BeginInit();
            this.poslovni_partnerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poslovni_partnerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObirsi
            // 
            this.btnObirsi.Location = new System.Drawing.Point(481, 254);
            this.btnObirsi.Name = "btnObirsi";
            this.btnObirsi.Size = new System.Drawing.Size(75, 23);
            this.btnObirsi.TabIndex = 12;
            this.btnObirsi.Text = "Obriši";
            this.btnObirsi.UseVisualStyleBackColor = true;
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Location = new System.Drawing.Point(400, 254);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromijeni.TabIndex = 11;
            this.btnPromijeni.Text = "Promijeni";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(319, 254);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pIDatabaseDataSet
            // 
            this.pIDatabaseDataSet.DataSetName = "PIDatabaseDataSet";
            this.pIDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poslovni_partnerBindingSource
            // 
            this.poslovni_partnerBindingSource.DataMember = "Poslovni_partner";
            this.poslovni_partnerBindingSource.DataSource = this.pIDatabaseDataSet;
            // 
            // poslovni_partnerTableAdapter
            // 
            this.poslovni_partnerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GradTableAdapter = null;
            this.tableAdapterManager.Jedinica_mjereTableAdapter = null;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.OtpremincaTableAdapter = null;
            this.tableAdapterManager.Poslovni_partnerTableAdapter = this.poslovni_partnerTableAdapter;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavke_narudzbeTableAdapter = null;
            this.tableAdapterManager.Stavke_otpremniceTableAdapter = null;
            this.tableAdapterManager.Stavke_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pi_projekt.PIDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VoziloTableAdapter = null;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // poslovni_partnerBindingNavigator
            // 
            this.poslovni_partnerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.poslovni_partnerBindingNavigator.BindingSource = this.poslovni_partnerBindingSource;
            this.poslovni_partnerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.poslovni_partnerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.poslovni_partnerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.poslovni_partnerBindingNavigatorSaveItem});
            this.poslovni_partnerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.poslovni_partnerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.poslovni_partnerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.poslovni_partnerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.poslovni_partnerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.poslovni_partnerBindingNavigator.Name = "poslovni_partnerBindingNavigator";
            this.poslovni_partnerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.poslovni_partnerBindingNavigator.Size = new System.Drawing.Size(567, 25);
            this.poslovni_partnerBindingNavigator.TabIndex = 13;
            this.poslovni_partnerBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // poslovni_partnerBindingNavigatorSaveItem
            // 
            this.poslovni_partnerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.poslovni_partnerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("poslovni_partnerBindingNavigatorSaveItem.Image")));
            this.poslovni_partnerBindingNavigatorSaveItem.Name = "poslovni_partnerBindingNavigatorSaveItem";
            this.poslovni_partnerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.poslovni_partnerBindingNavigatorSaveItem.Text = "Save Data";
            this.poslovni_partnerBindingNavigatorSaveItem.Click += new System.EventHandler(this.poslovni_partnerBindingNavigatorSaveItem_Click);
            // 
            // poslovni_partnerDataGridView
            // 
            this.poslovni_partnerDataGridView.AutoGenerateColumns = false;
            this.poslovni_partnerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poslovni_partnerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.poslovni_partnerDataGridView.DataSource = this.poslovni_partnerBindingSource;
            this.poslovni_partnerDataGridView.Location = new System.Drawing.Point(12, 28);
            this.poslovni_partnerDataGridView.Name = "poslovni_partnerDataGridView";
            this.poslovni_partnerDataGridView.Size = new System.Drawing.Size(544, 220);
            this.poslovni_partnerDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OIB_partnera";
            this.dataGridViewTextBoxColumn1.HeaderText = "OIB_partnera";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Broj_telefona";
            this.dataGridViewTextBoxColumn5.HeaderText = "Broj_telefona";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmPoslovni_partneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 282);
            this.Controls.Add(this.poslovni_partnerDataGridView);
            this.Controls.Add(this.poslovni_partnerBindingNavigator);
            this.Controls.Add(this.btnObirsi);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmPoslovni_partneri";
            this.Text = "Poslovni_partneri";
            this.Load += new System.EventHandler(this.frmPoslovni_partneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pIDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovni_partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovni_partnerBindingNavigator)).EndInit();
            this.poslovni_partnerBindingNavigator.ResumeLayout(false);
            this.poslovni_partnerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poslovni_partnerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObirsi;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnDodaj;
        private PIDatabaseDataSet pIDatabaseDataSet;
        private System.Windows.Forms.BindingSource poslovni_partnerBindingSource;
        private PIDatabaseDataSetTableAdapters.Poslovni_partnerTableAdapter poslovni_partnerTableAdapter;
        private PIDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator poslovni_partnerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton poslovni_partnerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView poslovni_partnerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}