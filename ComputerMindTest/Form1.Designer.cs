namespace ComputerMindTest
{
    partial class Form1
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
            this.NewMonthSchedule = new System.Windows.Forms.Button();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.contactsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactsDataSet3 = new ComputerMindTest.contactsDataSet3();
            this.contactsDataSet = new ComputerMindTest.contactsDataSet();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter = new ComputerMindTest.contactsDataSetTableAdapters.contactsTableAdapter();
            this.contactsDataSet1 = new ComputerMindTest.contactsDataSet1();
            this.πίνακας1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.πίνακας1TableAdapter = new ComputerMindTest.contactsDataSet1TableAdapters.Πίνακας1TableAdapter();
            this.contactsDataSet2 = new ComputerMindTest.contactsDataSet2();
            this.πίνακας1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.πίνακας1TableAdapter1 = new ComputerMindTest.contactsDataSet2TableAdapters.Πίνακας1TableAdapter();
            this.contactsTableAdapter1 = new ComputerMindTest.contactsDataSet3TableAdapters.contactsTableAdapter();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_buttonm = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.πίνακας1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.πίνακας1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewMonthSchedule
            // 
            this.NewMonthSchedule.Location = new System.Drawing.Point(44, 50);
            this.NewMonthSchedule.Name = "NewMonthSchedule";
            this.NewMonthSchedule.Size = new System.Drawing.Size(221, 23);
            this.NewMonthSchedule.TabIndex = 0;
            this.NewMonthSchedule.Text = "NewMonthSchedule";
            this.NewMonthSchedule.UseVisualStyleBackColor = true;
            this.NewMonthSchedule.Click += new System.EventHandler(this.NewMonthSchedule_Click);
            // 
            // grid1
            // 
            this.grid1.AllowUserToOrderColumns = true;
            this.grid1.AutoGenerateColumns = false;
            this.grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.personDataGridViewTextBoxColumn});
            this.grid1.DataSource = this.contactsBindingSource1;
            this.grid1.Location = new System.Drawing.Point(44, 105);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(1171, 375);
            this.grid1.TabIndex = 1;
            this.grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentClick);
            // 
            // contactsBindingSource1
            // 
            this.contactsBindingSource1.DataMember = "contacts";
            this.contactsBindingSource1.DataSource = this.contactsDataSet3;
            // 
            // contactsDataSet3
            // 
            this.contactsDataSet3.DataSetName = "contactsDataSet3";
            this.contactsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsDataSet
            // 
            this.contactsDataSet.DataSetName = "contactsDataSet";
            this.contactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "contacts";
            this.contactsBindingSource.DataSource = this.contactsDataSet;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // contactsDataSet1
            // 
            this.contactsDataSet1.DataSetName = "contactsDataSet1";
            this.contactsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // πίνακας1BindingSource
            // 
            this.πίνακας1BindingSource.DataMember = "Πίνακας1";
            this.πίνακας1BindingSource.DataSource = this.contactsDataSet1;
            // 
            // πίνακας1TableAdapter
            // 
            this.πίνακας1TableAdapter.ClearBeforeFill = true;
            // 
            // contactsDataSet2
            // 
            this.contactsDataSet2.DataSetName = "contactsDataSet2";
            this.contactsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // πίνακας1BindingSource1
            // 
            this.πίνακας1BindingSource1.DataMember = "Πίνακας1";
            this.πίνακας1BindingSource1.DataSource = this.contactsDataSet2;
            // 
            // πίνακας1TableAdapter1
            // 
            this.πίνακας1TableAdapter1.ClearBeforeFill = true;
            // 
            // contactsTableAdapter1
            // 
            this.contactsTableAdapter1.ClearBeforeFill = true;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.Width = 51;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.Width = 53;
            // 
            // personDataGridViewTextBoxColumn
            // 
            this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            this.personDataGridViewTextBoxColumn.HeaderText = "Person";
            this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            this.personDataGridViewTextBoxColumn.Width = 65;
            // 
            // delete_buttonm
            // 
            this.delete_buttonm.Location = new System.Drawing.Point(1140, 50);
            this.delete_buttonm.Name = "delete_buttonm";
            this.delete_buttonm.Size = new System.Drawing.Size(75, 23);
            this.delete_buttonm.TabIndex = 2;
            this.delete_buttonm.Text = "Delete";
            this.delete_buttonm.UseVisualStyleBackColor = true;
            this.delete_buttonm.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(589, 49);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 3;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 552);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.delete_buttonm);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.NewMonthSchedule);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.πίνακας1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.πίνακας1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewMonthSchedule;
        private System.Windows.Forms.DataGridView grid1;
        private contactsDataSet contactsDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private contactsDataSetTableAdapters.contactsTableAdapter contactsTableAdapter;
        private contactsDataSet1 contactsDataSet1;
        private System.Windows.Forms.BindingSource πίνακας1BindingSource;
        private contactsDataSet1TableAdapters.Πίνακας1TableAdapter πίνακας1TableAdapter;
        private contactsDataSet2 contactsDataSet2;
        private System.Windows.Forms.BindingSource πίνακας1BindingSource1;
        private contactsDataSet2TableAdapters.Πίνακας1TableAdapter πίνακας1TableAdapter1;
        private contactsDataSet3 contactsDataSet3;
        private System.Windows.Forms.BindingSource contactsBindingSource1;
        private contactsDataSet3TableAdapters.contactsTableAdapter contactsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delete_buttonm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_refresh;
    }
}

