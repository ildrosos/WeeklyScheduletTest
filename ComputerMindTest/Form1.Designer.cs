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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new ComputerMindTest.DataSet1();
            this.NewMonthSchedule = new System.Windows.Forms.Button();
            this.delete_buttonm = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.contactsTableAdapter = new ComputerMindTest.DataSet1TableAdapters.contactsTableAdapter();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProgramShifts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "contacts";
            this.contactsBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.EnforceConstraints = false;
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NewMonthSchedule
            // 
            this.NewMonthSchedule.Location = new System.Drawing.Point(85, 104);
            this.NewMonthSchedule.Name = "NewMonthSchedule";
            this.NewMonthSchedule.Size = new System.Drawing.Size(221, 23);
            this.NewMonthSchedule.TabIndex = 0;
            this.NewMonthSchedule.Text = "Νέο Πρόγραμμα";
            this.NewMonthSchedule.UseVisualStyleBackColor = true;
            this.NewMonthSchedule.Click += new System.EventHandler(this.NewMonthSchedule_Click);
            // 
            // delete_buttonm
            // 
            this.delete_buttonm.Location = new System.Drawing.Point(1265, 104);
            this.delete_buttonm.Name = "delete_buttonm";
            this.delete_buttonm.Size = new System.Drawing.Size(174, 23);
            this.delete_buttonm.TabIndex = 2;
            this.delete_buttonm.Text = "Διαγραφή προγράμματος";
            this.delete_buttonm.UseVisualStyleBackColor = true;
            this.delete_buttonm.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(610, 104);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 3;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.contactsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ComputerMindTest.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(85, 133);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1467, 569);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(970, 104);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(189, 23);
            this.progressBar2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1165, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "0 %";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ComputerMindTest.Properties.Resources.ps;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ProgramShifts
            // 
            this.ProgramShifts.AutoSize = true;
            this.ProgramShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProgramShifts.Location = new System.Drawing.Point(605, 33);
            this.ProgramShifts.Name = "ProgramShifts";
            this.ProgramShifts.Size = new System.Drawing.Size(248, 29);
            this.ProgramShifts.TabIndex = 9;
            this.ProgramShifts.Text = "Μηνιαίο Πρόγραμμα";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 714);
            this.Controls.Add(this.ProgramShifts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.delete_buttonm);
            this.Controls.Add(this.NewMonthSchedule);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewMonthSchedule;
        private System.Windows.Forms.Button delete_buttonm;
        private System.Windows.Forms.Button button_refresh;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.contactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProgramShifts;
        /*  private ComputerMindTest.contactsDataSet contactsDataSet;
          private ComputerMindTest.contactsDataSetTableAdapters.contactsTableAdapter contactsTableAdapter;
          private ComputerMindTest.contactsDataSet1 contactsDataSet1;
          private ComputerMindTest.contactsDataSet1TableAdapters.Πίνακας1TableAdapter πίνακας1TableAdapter;
          private ComputerMindTest.contactsDataSet2 contactsDataSet2;
          private ComputerMindTest.contactsDataSet2TableAdapters.Πίνακας1TableAdapter πίνακας1TableAdapter1;
          private ComputerMindTest.contactsDataSet3 contactsDataSet3;
          private ComputerMindTest.contactsDataSet3TableAdapters.contactsTableAdapter contactsTableAdapter1;*/
        //private DataSet2 DataSet2;
    }
}

