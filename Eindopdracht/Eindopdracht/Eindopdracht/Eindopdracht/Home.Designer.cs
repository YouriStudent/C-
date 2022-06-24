namespace Eindopdracht
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.werknemerToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.werknemer_toevoegen = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeEmployment = new System.Windows.Forms.DateTimePicker();
            this.employeeNumber = new System.Windows.Forms.NumericUpDown();
            this.NewEmployee = new System.Windows.Forms.Button();
            this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.vakantieDagen = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.database1DataSet = new Eindopdracht.Database1DataSet();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database2DataSet = new Eindopdracht.Database2DataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Eindopdracht.Database2DataSetTableAdapters.EmployeeTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorMSG = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.werknemer_toevoegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNumber)).BeginInit();
            this.vakantieDagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenu;
            this.tabControl1.Controls.Add(this.werknemer_toevoegen);
            this.tabControl1.Controls.Add(this.vakantieDagen);
            this.tabControl1.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuAbout,
            this.ContextMenuOpen,
            this.ContextMenuClose});
            this.contextMenu.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenu, "contextMenu");
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ContextMenuAbout
            // 
            this.ContextMenuAbout.Name = "ContextMenuAbout";
            resources.ApplyResources(this.ContextMenuAbout, "ContextMenuAbout");
            this.ContextMenuAbout.Click += new System.EventHandler(this.ContextMenuAbout_Click);
            // 
            // ContextMenuOpen
            // 
            this.ContextMenuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.werknemerToevoegenToolStripMenuItem});
            this.ContextMenuOpen.Name = "ContextMenuOpen";
            resources.ApplyResources(this.ContextMenuOpen, "ContextMenuOpen");
            this.ContextMenuOpen.Click += new System.EventHandler(this.ContextMenuOpen_Click);
            // 
            // werknemerToevoegenToolStripMenuItem
            // 
            this.werknemerToevoegenToolStripMenuItem.Name = "werknemerToevoegenToolStripMenuItem";
            resources.ApplyResources(this.werknemerToevoegenToolStripMenuItem, "werknemerToevoegenToolStripMenuItem");
            this.werknemerToevoegenToolStripMenuItem.Click += new System.EventHandler(this.werknemerToevoegenToolStripMenuItem_Click);
            // 
            // ContextMenuClose
            // 
            this.ContextMenuClose.Name = "ContextMenuClose";
            resources.ApplyResources(this.ContextMenuClose, "ContextMenuClose");
            this.ContextMenuClose.Click += new System.EventHandler(this.ContextMenuClose_Click);
            // 
            // werknemer_toevoegen
            // 
            this.werknemer_toevoegen.Controls.Add(this.errorMSG);
            this.werknemer_toevoegen.Controls.Add(this.label6);
            this.werknemer_toevoegen.Controls.Add(this.label5);
            this.werknemer_toevoegen.Controls.Add(this.label3);
            this.werknemer_toevoegen.Controls.Add(this.label2);
            this.werknemer_toevoegen.Controls.Add(this.label1);
            this.werknemer_toevoegen.Controls.Add(this.dateTimeEmployment);
            this.werknemer_toevoegen.Controls.Add(this.employeeNumber);
            this.werknemer_toevoegen.Controls.Add(this.NewEmployee);
            this.werknemer_toevoegen.Controls.Add(this.dateTimeBirthDate);
            this.werknemer_toevoegen.Controls.Add(this.employeeName);
            resources.ApplyResources(this.werknemer_toevoegen, "werknemer_toevoegen");
            this.werknemer_toevoegen.Name = "werknemer_toevoegen";
            this.werknemer_toevoegen.UseVisualStyleBackColor = true;
            this.werknemer_toevoegen.Click += new System.EventHandler(this.werknemer_toevoegen_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dateTimeEmployment
            // 
            resources.ApplyResources(this.dateTimeEmployment, "dateTimeEmployment");
            this.dateTimeEmployment.Name = "dateTimeEmployment";
            this.dateTimeEmployment.Value = new System.DateTime(2022, 6, 14, 8, 45, 0, 0);
            // 
            // employeeNumber
            // 
            resources.ApplyResources(this.employeeNumber, "employeeNumber");
            this.employeeNumber.Name = "employeeNumber";
            // 
            // NewEmployee
            // 
            resources.ApplyResources(this.NewEmployee, "NewEmployee");
            this.NewEmployee.Name = "NewEmployee";
            this.NewEmployee.UseVisualStyleBackColor = true;
            this.NewEmployee.Click += new System.EventHandler(this.NewEmployee_click);
            // 
            // dateTimeBirthDate
            // 
            resources.ApplyResources(this.dateTimeBirthDate, "dateTimeBirthDate");
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.Value = new System.DateTime(1980, 6, 14, 8, 45, 0, 0);
            // 
            // employeeName
            // 
            resources.ApplyResources(this.employeeName, "employeeName");
            this.employeeName.Name = "employeeName";
            this.employeeName.ClientSizeChanged += new System.EventHandler(this.employeeName_ClientSizeChanged);
            // 
            // vakantieDagen
            // 
            this.vakantieDagen.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.vakantieDagen, "vakantieDagen");
            this.vakantieDagen.Name = "vakantieDagen";
            this.vakantieDagen.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenu;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.database2DataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            resources.ApplyResources(this.numberDataGridViewTextBoxColumn, "numberDataGridViewTextBoxColumn");
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            resources.ApplyResources(this.startdateDataGridViewTextBoxColumn, "startdateDataGridViewTextBoxColumn");
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            resources.ApplyResources(this.birthdayDataGridViewTextBoxColumn, "birthdayDataGridViewTextBoxColumn");
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // errorMSG
            // 
            resources.ApplyResources(this.errorMSG, "errorMSG");
            this.errorMSG.Name = "errorMSG";
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.tabControl1.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.werknemer_toevoegen.ResumeLayout(false);
            this.werknemer_toevoegen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNumber)).EndInit();
            this.vakantieDagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage werknemer_toevoegen;
        private System.Windows.Forms.TabPage vakantieDagen;
        private System.Windows.Forms.Button NewEmployee;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeEmployment;
        private System.Windows.Forms.NumericUpDown employeeNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuClose;
        private System.Windows.Forms.ToolStripMenuItem werknemerToevoegenToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database2DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label errorMSG;
    }
}

