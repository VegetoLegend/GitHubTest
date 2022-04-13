namespace DemoProject11_ReCreateLeaveForm_
{
    partial class Frm_LeavePortal
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_EmpName = new System.Windows.Forms.Label();
            this.lbl_leaveType = new System.Windows.Forms.Label();
            this.lbl_FromDate = new System.Windows.Forms.Label();
            this.lbl_ToDate = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.richTb_Des = new System.Windows.Forms.RichTextBox();
            this.cmbBx_EmpName = new System.Windows.Forms.ComboBox();
            this.cmbBx_LeaveType = new System.Windows.Forms.ComboBox();
            this.dtpicker_from = new System.Windows.Forms.DateTimePicker();
            this.dtpicker_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_imageLoader = new System.Windows.Forms.Label();
            this.picBox_LeaveForm = new System.Windows.Forms.PictureBox();
            this.btn_picLoader = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_imageName = new System.Windows.Forms.TextBox();
            this.gridControl_LeavePortal = new DevExpress.XtraGrid.GridControl();
            this.gridView_LeavePortal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_LeaveForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LeavePortal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LeavePortal)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_EmpName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_leaveType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_FromDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ToDate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_description, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.richTb_Des, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbBx_EmpName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbBx_LeaveType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpicker_from, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpicker_to, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_imageLoader, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.picBox_LeaveForm, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_picLoader, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Submit, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_imageName, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 317);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_EmpName
            // 
            this.lbl_EmpName.AutoSize = true;
            this.lbl_EmpName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmpName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_EmpName.Location = new System.Drawing.Point(43, 0);
            this.lbl_EmpName.Name = "lbl_EmpName";
            this.lbl_EmpName.Size = new System.Drawing.Size(116, 32);
            this.lbl_EmpName.TabIndex = 0;
            this.lbl_EmpName.Text = "Employee Name:";
            // 
            // lbl_leaveType
            // 
            this.lbl_leaveType.AutoSize = true;
            this.lbl_leaveType.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_leaveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leaveType.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_leaveType.Location = new System.Drawing.Point(76, 32);
            this.lbl_leaveType.Name = "lbl_leaveType";
            this.lbl_leaveType.Size = new System.Drawing.Size(83, 33);
            this.lbl_leaveType.TabIndex = 1;
            this.lbl_leaveType.Text = "Leave Type:";
            // 
            // lbl_FromDate
            // 
            this.lbl_FromDate.AutoSize = true;
            this.lbl_FromDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_FromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FromDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_FromDate.Location = new System.Drawing.Point(115, 65);
            this.lbl_FromDate.Name = "lbl_FromDate";
            this.lbl_FromDate.Size = new System.Drawing.Size(44, 33);
            this.lbl_FromDate.TabIndex = 2;
            this.lbl_FromDate.Text = "From:";
            // 
            // lbl_ToDate
            // 
            this.lbl_ToDate.AutoSize = true;
            this.lbl_ToDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_ToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_ToDate.Location = new System.Drawing.Point(455, 65);
            this.lbl_ToDate.Name = "lbl_ToDate";
            this.lbl_ToDate.Size = new System.Drawing.Size(27, 33);
            this.lbl_ToDate.TabIndex = 3;
            this.lbl_ToDate.Text = "To:";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_description.Location = new System.Drawing.Point(75, 98);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(84, 122);
            this.lbl_description.TabIndex = 4;
            this.lbl_description.Text = "Desciptrion:";
            // 
            // richTb_Des
            // 
            this.richTb_Des.BackColor = System.Drawing.Color.Olive;
            this.richTb_Des.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTb_Des.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTb_Des.Location = new System.Drawing.Point(165, 101);
            this.richTb_Des.Name = "richTb_Des";
            this.richTb_Des.Size = new System.Drawing.Size(156, 116);
            this.richTb_Des.TabIndex = 5;
            this.richTb_Des.Text = "";
            // 
            // cmbBx_EmpName
            // 
            this.cmbBx_EmpName.BackColor = System.Drawing.Color.Olive;
            this.cmbBx_EmpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBx_EmpName.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbBx_EmpName.FormattingEnabled = true;
            this.cmbBx_EmpName.Location = new System.Drawing.Point(165, 3);
            this.cmbBx_EmpName.Name = "cmbBx_EmpName";
            this.cmbBx_EmpName.Size = new System.Drawing.Size(156, 21);
            this.cmbBx_EmpName.TabIndex = 6;
            this.cmbBx_EmpName.SelectedIndexChanged += new System.EventHandler(this.cmbBx_EmpName_SelectedIndexChanged);
            this.cmbBx_EmpName.Click += new System.EventHandler(this.cmbBx_EmpName_Click);
            // 
            // cmbBx_LeaveType
            // 
            this.cmbBx_LeaveType.BackColor = System.Drawing.Color.Olive;
            this.cmbBx_LeaveType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBx_LeaveType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbBx_LeaveType.FormattingEnabled = true;
            this.cmbBx_LeaveType.Location = new System.Drawing.Point(165, 35);
            this.cmbBx_LeaveType.Name = "cmbBx_LeaveType";
            this.cmbBx_LeaveType.Size = new System.Drawing.Size(156, 21);
            this.cmbBx_LeaveType.TabIndex = 7;
            this.cmbBx_LeaveType.Click += new System.EventHandler(this.cmbBx_LeaveType_Click);
            // 
            // dtpicker_from
            // 
            this.dtpicker_from.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpicker_from.CalendarMonthBackground = System.Drawing.Color.Olive;
            this.dtpicker_from.CustomFormat = "dd-MMM-yyyy";
            this.dtpicker_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_from.Location = new System.Drawing.Point(165, 68);
            this.dtpicker_from.Name = "dtpicker_from";
            this.dtpicker_from.Size = new System.Drawing.Size(156, 20);
            this.dtpicker_from.TabIndex = 8;
            // 
            // dtpicker_to
            // 
            this.dtpicker_to.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpicker_to.CalendarMonthBackground = System.Drawing.Color.Olive;
            this.dtpicker_to.CustomFormat = "dd-MMM-yyyy";
            this.dtpicker_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_to.Location = new System.Drawing.Point(488, 68);
            this.dtpicker_to.Name = "dtpicker_to";
            this.dtpicker_to.Size = new System.Drawing.Size(146, 20);
            this.dtpicker_to.TabIndex = 9;
            // 
            // lbl_imageLoader
            // 
            this.lbl_imageLoader.AutoSize = true;
            this.lbl_imageLoader.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_imageLoader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imageLoader.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_imageLoader.Location = new System.Drawing.Point(376, 98);
            this.lbl_imageLoader.Name = "lbl_imageLoader";
            this.lbl_imageLoader.Size = new System.Drawing.Size(106, 122);
            this.lbl_imageLoader.TabIndex = 12;
            this.lbl_imageLoader.Text = "Upload Picture:";
            // 
            // picBox_LeaveForm
            // 
            this.picBox_LeaveForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.picBox_LeaveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_LeaveForm.Location = new System.Drawing.Point(488, 101);
            this.picBox_LeaveForm.Name = "picBox_LeaveForm";
            this.picBox_LeaveForm.Size = new System.Drawing.Size(146, 116);
            this.picBox_LeaveForm.TabIndex = 13;
            this.picBox_LeaveForm.TabStop = false;
            // 
            // btn_picLoader
            // 
            this.btn_picLoader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_picLoader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_picLoader.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_picLoader.Location = new System.Drawing.Point(640, 101);
            this.btn_picLoader.Name = "btn_picLoader";
            this.btn_picLoader.Size = new System.Drawing.Size(138, 25);
            this.btn_picLoader.TabIndex = 14;
            this.btn_picLoader.Text = "Upload";
            this.btn_picLoader.UseVisualStyleBackColor = true;
            this.btn_picLoader.Click += new System.EventHandler(this.btn_picLoader_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(488, 254);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(146, 25);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_Submit.Location = new System.Drawing.Point(640, 254);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(138, 25);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_imageName
            // 
            this.txt_imageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_imageName.Location = new System.Drawing.Point(488, 223);
            this.txt_imageName.Name = "txt_imageName";
            this.txt_imageName.Size = new System.Drawing.Size(146, 20);
            this.txt_imageName.TabIndex = 15;
            // 
            // gridControl_LeavePortal
            // 
            this.gridControl_LeavePortal.Location = new System.Drawing.Point(9, 335);
            this.gridControl_LeavePortal.MainView = this.gridView_LeavePortal;
            this.gridControl_LeavePortal.Name = "gridControl_LeavePortal";
            this.gridControl_LeavePortal.Size = new System.Drawing.Size(781, 200);
            this.gridControl_LeavePortal.TabIndex = 1;
            this.gridControl_LeavePortal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_LeavePortal});
            // 
            // gridView_LeavePortal
            // 
            this.gridView_LeavePortal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView_LeavePortal.GridControl = this.gridControl_LeavePortal;
            this.gridView_LeavePortal.Name = "gridView_LeavePortal";
            this.gridView_LeavePortal.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "From Date";
            this.gridColumn1.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn1.FieldName = "FromDate";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "To Date";
            this.gridColumn2.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn2.FieldName = "ToDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "Days";
            this.gridColumn3.FieldName = "Days";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "Hours";
            this.gridColumn4.FieldName = "hours";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "Leave Type";
            this.gridColumn5.FieldName = "Description";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Description";
            this.gridColumn6.FieldName = "desci";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Status";
            this.gridColumn7.FieldName = "Status";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // Frm_LeavePortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(805, 547);
            this.Controls.Add(this.gridControl_LeavePortal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_LeavePortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Portal";
            this.Load += new System.EventHandler(this.Frm_LeavePortal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_LeaveForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_LeavePortal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_LeavePortal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_EmpName;
        private System.Windows.Forms.Label lbl_leaveType;
        private System.Windows.Forms.Label lbl_FromDate;
        private System.Windows.Forms.Label lbl_ToDate;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.RichTextBox richTb_Des;
        private System.Windows.Forms.ComboBox cmbBx_EmpName;
        private System.Windows.Forms.ComboBox cmbBx_LeaveType;
        private System.Windows.Forms.DateTimePicker dtpicker_from;
        private System.Windows.Forms.DateTimePicker dtpicker_to;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancel;
        private DevExpress.XtraGrid.GridControl gridControl_LeavePortal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_LeavePortal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.Label lbl_imageLoader;
        private System.Windows.Forms.PictureBox picBox_LeaveForm;
        private System.Windows.Forms.Button btn_picLoader;
        private System.Windows.Forms.TextBox txt_imageName;

    }
}

