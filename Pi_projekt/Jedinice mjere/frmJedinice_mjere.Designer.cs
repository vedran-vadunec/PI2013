namespace Pi_projekt
{
    partial class frmJedinice_mjere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJedinice_mjere));
            this.btnObirsi = new System.Windows.Forms.Button();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pIDatabaseDataSet = new Pi_projekt.PIDatabaseDataSet();
            this.jedinica_mjereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jedinica_mjereTableAdapter = new Pi_projekt.PIDatabaseDataSetTableAdapters.Jedinica_mjereTableAdapter();
            this.tableAdapterManager = new Pi_projekt.PIDatabaseDataSetTableAdapters.TableAdapterManager();
            this.jedinica_mjereBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.jedinica_mjereBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.jedinica_mjereDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pIDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinica_mjereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinica_mjereBindingNavigator)).BeginInit();
            this.jedinica_mjereBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jedinica_mjereDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObirsi
            // 
            this.btnObirsi.Location = new System.Drawing.Point(255, 257);
            this.btnObirsi.Name = "btnObirsi";
            this.btnObirsi.Size = new System.Drawing.Size(75, 23);
            this.btnObirsi.TabIndex = 6;
            this.btnObirsi.Text = "Obriši";
            this.btnObirsi.UseVisualStyleBackColor = true;
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Location = new System.Drawing.Point(174, 257);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromijeni.TabIndex = 5;
            this.btnPromijeni.Text = "Promijeni";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(93, 257);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pIDatabaseDataSet
            // 
            this.pIDatabaseDataSet.DataSetName = "PIDatabaseDataSet";
            this.pIDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jedinica_mjereBindingSource
            // 
            this.jedinica_mjereBindingSource.DataMember = "Jedinica_mjere";
            this.jedinica_mjereBindingSource.DataSource = this.pIDatabaseDataSet;
            // 
            // jedinica_mjereTableAdapter
            // 
            this.jedinica_mjereTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GradTableAdapter = null;
            this.tableAdapterManager.Jedinica_mjereTableAdapter = this.jedinica_mjereTableAdapter;
            this.tableAdapterManager.NarudzbaTableAdapter = null;
            this.tableAdapterManager.OtpremincaTableAdapter = null;
            this.tableAdapterManager.Poslovni_partnerTableAdapter = null;
            this.tableAdapterManager.RacunTableAdapter = null;
            this.tableAdapterManager.Stavke_narudzbeTableAdapter = null;
            this.tableAdapterManager.Stavke_otpremniceTableAdapter = null;
            this.tableAdapterManager.Stavke_racunaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pi_projekt.PIDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VoziloTableAdapter = null;
            this.tableAdapterManager.ZaposlenikTableAdapter = null;
            // 
            // jedinica_mjereBindingNavigator
            // 
            this.jedinica_mjereBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jedinica_mjereBindingNavigator.BindingSource = this.jedinica_mjereBindingSource;
            this.jedinica_mjereBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jedinica_mjereBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jedinica_mjereBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.jedinica_mjereBindingNavigatorSaveItem});
            this.jedinica_mjereBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jedinica_mjereBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jedinica_mjereBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jedinica_mjereBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jedinica_mjereBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jedinica_mjereBindingNavigator.Name = "jedinica_mjereBindingNavigator";
            this.jedinica_mjereBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jedinica_mjereBindingNavigator.Size = new System.Drawing.Size(341, 25);
            this.jedinica_mjereBindingNavigator.TabIndex = 7;
            this.jedinica_mjereBindingNavigator.Text = "bindingNavigator1";
            this.jedinica_mjereBindingNavigator.RefreshItems += new System.EventHandler(this.jedinica_mjereBindingNavigator_RefreshItems);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            // jedinica_mjereBindingNavigatorSaveItem
            // 
            this.jedinica_mjereBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jedinica_mjereBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jedinica_mjereBindingNavigatorSaveItem.Image")));
            this.jedinica_mjereBindingNavigatorSaveItem.Name = "jedinica_mjereBindingNavigatorSaveItem";
            this.jedinica_mjereBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.jedinica_mjereBindingNavigatorSaveItem.Text = "Save Data";
            this.jedinica_mjereBindingNavigatorSaveItem.Click += new System.EventHandler(this.jedinica_mjereBindingNavigatorSaveItem_Click);
            // 
            // jedinica_mjereDataGridView
            // 
            this.jedinica_mjereDataGridView.AutoGenerateColumns = false;
            this.jedinica_mjereDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jedinica_mjereDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.jedinica_mjereDataGridView.DataSource = this.jedinica_mjereBindingSource;
            this.jedinica_mjereDataGridView.Location = new System.Drawing.Point(12, 28);
            this.jedinica_mjereDataGridView.Name = "jedinica_mjereDataGridView";
            this.jedinica_mjereDataGridView.Size = new System.Drawing.Size(318, 220);
            this.jedinica_mjereDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_mjere";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_mjere";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmJedinice_mjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 292);
            this.Controls.Add(this.jedinica_mjereDataGridView);
            this.Controls.Add(this.jedinica_mjereBindingNavigator);
            this.Controls.Add(this.btnObirsi);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmJedinice_mjere";
            this.Text = "Jedinice mjere";
            this.Load += new System.EventHandler(this.frmJedinice_mjere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pIDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinica_mjereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinica_mjereBindingNavigator)).EndInit();
            this.jedinica_mjereBindingNavigator.ResumeLayout(false);
            this.jedinica_mjereBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jedinica_mjereDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObirsi;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnDodaj;
        private PIDatabaseDataSet pIDatabaseDataSet;
        private System.Windows.Forms.BindingSource jedinica_mjereBindingSource;
        private PIDatabaseDataSetTableAdapters.Jedinica_mjereTableAdapter jedinica_mjereTableAdapter;
        private PIDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jedinica_mjereBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton jedinica_mjereBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView jedinica_mjereDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    }
}