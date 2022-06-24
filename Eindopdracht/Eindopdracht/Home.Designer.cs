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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.werknemerToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.database1DataSet = new Eindopdracht.Database1DataSet();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new Eindopdracht.Database2DataSet();
            this.employeeTableAdapter = new Eindopdracht.Database2DataSetTableAdapters.EmployeeTableAdapter();
            this.holidays = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.werknemer_toevoegen = new System.Windows.Forms.TabPage();
            this.errorMSG = new System.Windows.Forms.Label();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OldestEmployee = new System.Windows.Forms.Label();
            this.TotalFreeDays = new System.Windows.Forms.Label();
            this.AVGServiceYears = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            this.holidays.SuspendLayout();
            this.werknemer_toevoegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNumber)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // holidays
            // 
            this.holidays.Controls.Add(this.listBox1);
            this.holidays.Controls.Add(this.label4);
            this.holidays.Controls.Add(this.comboBoxEmployee);
            resources.ApplyResources(this.holidays, "holidays");
            this.holidays.Name = "holidays";
            this.holidays.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxEmployee, "comboBoxEmployee");
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.DropDown += new System.EventHandler(this.comboBoxEmployee_DropDown);
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmployee_SelectedIndexChanged);
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
            // 
            // errorMSG
            // 
            resources.ApplyResources(this.errorMSG, "errorMSG");
            this.errorMSG.Name = "errorMSG";
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
            this.employeeNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
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
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenu;
            this.tabControl1.Controls.Add(this.werknemer_toevoegen);
            this.tabControl1.Controls.Add(this.holidays);
            this.tabControl1.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AVGServiceYears);
            this.tabPage1.Controls.Add(this.TotalFreeDays);
            this.tabPage1.Controls.Add(this.OldestEmployee);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // OldestEmployee
            // 
            resources.ApplyResources(this.OldestEmployee, "OldestEmployee");
            this.OldestEmployee.Name = "OldestEmployee";
            // 
            // TotalFreeDays
            // 
            resources.ApplyResources(this.TotalFreeDays, "TotalFreeDays");
            this.TotalFreeDays.Name = "TotalFreeDays";
            // 
            // AVGServiceYears
            // 
            resources.ApplyResources(this.AVGServiceYears, "AVGServiceYears");
            this.AVGServiceYears.Name = "AVGServiceYears";
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
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            this.holidays.ResumeLayout(false);
            this.holidays.PerformLayout();
            this.werknemer_toevoegen.ResumeLayout(false);
            this.werknemer_toevoegen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNumber)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuClose;
        private System.Windows.Forms.ToolStripMenuItem werknemerToevoegenToolStripMenuItem;
        private Database1DataSet database1DataSet;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database2DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TabPage holidays;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.TabPage werknemer_toevoegen;
        private System.Windows.Forms.Label errorMSG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeEmployment;
        private System.Windows.Forms.NumericUpDown employeeNumber;
        private System.Windows.Forms.Button NewEmployee;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label AVGServiceYears;
        private System.Windows.Forms.Label TotalFreeDays;
        private System.Windows.Forms.Label OldestEmployee;
    }
}

