namespace 兩院比對EMR
{
    partial class frmCompare
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
            System.Windows.Forms.Label host_nameLabel;
            System.Windows.Forms.Label label1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CompareResult = new System.Windows.Forms.TabPage();
            this.compair_DIFFDataGridView = new System.Windows.Forms.DataGridView();
            this.FileStatus = new System.Windows.Forms.TabPage();
            this.tmpSaveDataGridView = new System.Windows.Forms.DataGridView();
            this.DBdata = new System.Windows.Forms.TabPage();
            this.eMRNDataGridView1 = new System.Windows.Forms.DataGridView();
            this.eMRNDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.TB_Awayhost = new System.Windows.Forms.TextBox();
            this.TB_Mainhost = new System.Windows.Forms.TextBox();
            this.btn_data = new System.Windows.Forms.Button();
            this.btnCompar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtDate1 = new System.Windows.Forms.DateTimePicker();
            this.btn_exit = new System.Windows.Forms.Button();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.btn_clear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bgwauto = new System.ComponentModel.BackgroundWorker();
            this.filenameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compair_DIFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filepathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmpSaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMRNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMRNBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            host_nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.CompareResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compair_DIFFDataGridView)).BeginInit();
            this.FileStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmpSaveDataGridView)).BeginInit();
            this.DBdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMRNDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRNDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compair_DIFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpSaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRNBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // host_nameLabel
            // 
            host_nameLabel.AutoSize = true;
            host_nameLabel.Location = new System.Drawing.Point(8, 29);
            host_nameLabel.Name = "host_nameLabel";
            host_nameLabel.Size = new System.Drawing.Size(90, 24);
            host_nameLabel.TabIndex = 4;
            host_nameLabel.Text = "主要主機:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(301, 29);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 24);
            label1.TabIndex = 7;
            label1.Text = "次要主機:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CompareResult);
            this.tabControl1.Controls.Add(this.FileStatus);
            this.tabControl1.Controls.Add(this.DBdata);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(12, 156);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // CompareResult
            // 
            this.CompareResult.Controls.Add(this.compair_DIFFDataGridView);
            this.CompareResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CompareResult.Location = new System.Drawing.Point(4, 29);
            this.CompareResult.Name = "CompareResult";
            this.CompareResult.Padding = new System.Windows.Forms.Padding(3);
            this.CompareResult.Size = new System.Drawing.Size(857, 550);
            this.CompareResult.TabIndex = 0;
            this.CompareResult.Text = "比對缺失檔案";
            this.CompareResult.UseVisualStyleBackColor = true;
            // 
            // compair_DIFFDataGridView
            // 
            this.compair_DIFFDataGridView.AllowUserToAddRows = false;
            this.compair_DIFFDataGridView.AllowUserToDeleteRows = false;
            this.compair_DIFFDataGridView.AutoGenerateColumns = false;
            this.compair_DIFFDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compair_DIFFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filenameDataGridViewTextBoxColumn1,
            this.filePathDataGridViewTextBoxColumn1,
            this.hostnameDataGridViewTextBoxColumn1,
            this.noteDataGridViewTextBoxColumn1,
            this.datetimeDataGridViewTextBoxColumn});
            this.compair_DIFFDataGridView.DataSource = this.compair_DIFFBindingSource;
            this.compair_DIFFDataGridView.Location = new System.Drawing.Point(6, 6);
            this.compair_DIFFDataGridView.Name = "compair_DIFFDataGridView";
            this.compair_DIFFDataGridView.RowTemplate.Height = 24;
            this.compair_DIFFDataGridView.Size = new System.Drawing.Size(831, 480);
            this.compair_DIFFDataGridView.TabIndex = 0;
            // 
            // FileStatus
            // 
            this.FileStatus.Controls.Add(this.tmpSaveDataGridView);
            this.FileStatus.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FileStatus.Location = new System.Drawing.Point(4, 29);
            this.FileStatus.Name = "FileStatus";
            this.FileStatus.Padding = new System.Windows.Forms.Padding(3);
            this.FileStatus.Size = new System.Drawing.Size(857, 550);
            this.FileStatus.TabIndex = 1;
            this.FileStatus.Text = "檔案狀態";
            this.FileStatus.UseVisualStyleBackColor = true;
            // 
            // tmpSaveDataGridView
            // 
            this.tmpSaveDataGridView.AutoGenerateColumns = false;
            this.tmpSaveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tmpSaveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filenameDataGridViewTextBoxColumn,
            this.hostnameDataGridViewTextBoxColumn,
            this.filepathDataGridViewTextBoxColumn,
            this.saveDateDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.tmpSaveDataGridView.DataSource = this.tmpSaveBindingSource;
            this.tmpSaveDataGridView.Location = new System.Drawing.Point(3, 9);
            this.tmpSaveDataGridView.Name = "tmpSaveDataGridView";
            this.tmpSaveDataGridView.RowTemplate.Height = 24;
            this.tmpSaveDataGridView.Size = new System.Drawing.Size(641, 521);
            this.tmpSaveDataGridView.TabIndex = 0;
            // 
            // DBdata
            // 
            this.DBdata.AutoScroll = true;
            this.DBdata.Controls.Add(this.eMRNDataGridView1);
            this.DBdata.Controls.Add(this.eMRNDataGridView);
            this.DBdata.Location = new System.Drawing.Point(4, 29);
            this.DBdata.Name = "DBdata";
            this.DBdata.Padding = new System.Windows.Forms.Padding(3);
            this.DBdata.Size = new System.Drawing.Size(857, 550);
            this.DBdata.TabIndex = 2;
            this.DBdata.Text = "資料狀態";
            this.DBdata.UseVisualStyleBackColor = true;
            // 
            // eMRNDataGridView1
            // 
            this.eMRNDataGridView1.AutoGenerateColumns = false;
            this.eMRNDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMRNDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genDateDataGridViewTextBoxColumn,
            this.sysDateDataGridViewTextBoxColumn,
            this.transNoDataGridViewTextBoxColumn});
            this.eMRNDataGridView1.DataSource = this.eMRNBindingSource;
            this.eMRNDataGridView1.Location = new System.Drawing.Point(445, 6);
            this.eMRNDataGridView1.Name = "eMRNDataGridView1";
            this.eMRNDataGridView1.RowTemplate.Height = 24;
            this.eMRNDataGridView1.Size = new System.Drawing.Size(402, 538);
            this.eMRNDataGridView1.TabIndex = 1;
            // 
            // eMRNDataGridView
            // 
            this.eMRNDataGridView.AutoGenerateColumns = false;
            this.eMRNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMRNDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genDateDataGridViewTextBoxColumn1,
            this.sysDateDataGridViewTextBoxColumn1,
            this.transNoDataGridViewTextBoxColumn1});
            this.eMRNDataGridView.DataSource = this.eMRNBindingSource2;
            this.eMRNDataGridView.Location = new System.Drawing.Point(8, 6);
            this.eMRNDataGridView.Name = "eMRNDataGridView";
            this.eMRNDataGridView.RowTemplate.Height = 24;
            this.eMRNDataGridView.Size = new System.Drawing.Size(419, 538);
            this.eMRNDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_copy);
            this.groupBox1.Controls.Add(this.btn_excel);
            this.groupBox1.Controls.Add(this.TB_Awayhost);
            this.groupBox1.Controls.Add(this.TB_Mainhost);
            this.groupBox1.Controls.Add(this.btn_data);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.btnCompar);
            this.groupBox1.Controls.Add(host_nameLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtDate2);
            this.groupBox1.Controls.Add(this.dtDate1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "比對範圍";
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_copy.Location = new System.Drawing.Point(600, 79);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(129, 69);
            this.btn_copy.TabIndex = 12;
            this.btn_copy.Text = "  複製缺失      (無自動)";
            this.btn_copy.UseVisualStyleBackColor = false;
            // 
            // btn_excel
            // 
            this.btn_excel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_excel.Location = new System.Drawing.Point(599, 20);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(120, 53);
            this.btn_excel.TabIndex = 7;
            this.btn_excel.Text = "匯出Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            // 
            // TB_Awayhost
            // 
            this.TB_Awayhost.Location = new System.Drawing.Point(397, 26);
            this.TB_Awayhost.Name = "TB_Awayhost";
            this.TB_Awayhost.Size = new System.Drawing.Size(193, 33);
            this.TB_Awayhost.TabIndex = 10;
            // 
            // TB_Mainhost
            // 
            this.TB_Mainhost.Location = new System.Drawing.Point(104, 26);
            this.TB_Mainhost.Name = "TB_Mainhost";
            this.TB_Mainhost.Size = new System.Drawing.Size(193, 33);
            this.TB_Mainhost.TabIndex = 9;
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(474, 79);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(120, 53);
            this.btn_data.TabIndex = 8;
            this.btn_data.Text = "比對資料庫";
            this.btn_data.UseVisualStyleBackColor = true;
            // 
            // btnCompar
            // 
            this.btnCompar.Location = new System.Drawing.Point(360, 79);
            this.btnCompar.Name = "btnCompar";
            this.btnCompar.Size = new System.Drawing.Size(108, 53);
            this.btnCompar.TabIndex = 1;
            this.btnCompar.Text = "兩院比對";
            this.btnCompar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "結束日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "開始日期";
            // 
            // dtDate2
            // 
            this.dtDate2.Location = new System.Drawing.Point(181, 99);
            this.dtDate2.Name = "dtDate2";
            this.dtDate2.Size = new System.Drawing.Size(173, 33);
            this.dtDate2.TabIndex = 2;
            // 
            // dtDate1
            // 
            this.dtDate1.Location = new System.Drawing.Point(10, 99);
            this.dtDate1.Name = "dtDate1";
            this.dtDate1.Size = new System.Drawing.Size(165, 33);
            this.dtDate1.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.LightGray;
            this.btn_exit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(753, 26);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(120, 53);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "離開";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // bgw
            // 
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CompleteWork);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.Location = new System.Drawing.Point(753, 95);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 53);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "清除紀錄";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // bgwauto
            // 
            this.bgwauto.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AutocountDown);
            this.bgwauto.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CompleteAuto);
            // 
            // filenameDataGridViewTextBoxColumn1
            // 
            this.filenameDataGridViewTextBoxColumn1.DataPropertyName = "Filename";
            this.filenameDataGridViewTextBoxColumn1.HeaderText = "檔案名稱";
            this.filenameDataGridViewTextBoxColumn1.Name = "filenameDataGridViewTextBoxColumn1";
            this.filenameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // filePathDataGridViewTextBoxColumn1
            // 
            this.filePathDataGridViewTextBoxColumn1.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn1.HeaderText = "檔按路徑";
            this.filePathDataGridViewTextBoxColumn1.Name = "filePathDataGridViewTextBoxColumn1";
            this.filePathDataGridViewTextBoxColumn1.Width = 150;
            // 
            // hostnameDataGridViewTextBoxColumn1
            // 
            this.hostnameDataGridViewTextBoxColumn1.DataPropertyName = "Hostname";
            this.hostnameDataGridViewTextBoxColumn1.HeaderText = "主機";
            this.hostnameDataGridViewTextBoxColumn1.Name = "hostnameDataGridViewTextBoxColumn1";
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn1.HeaderText = "備註";
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            this.noteDataGridViewTextBoxColumn1.Width = 180;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "Datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "日期";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // compair_DIFFBindingSource
            // 
            this.compair_DIFFBindingSource.DataSource = typeof(兩院比對EMR.Model.Compair_DIFF);
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "Filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "檔案名稱";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // hostnameDataGridViewTextBoxColumn
            // 
            this.hostnameDataGridViewTextBoxColumn.DataPropertyName = "Hostname";
            this.hostnameDataGridViewTextBoxColumn.HeaderText = "主機";
            this.hostnameDataGridViewTextBoxColumn.Name = "hostnameDataGridViewTextBoxColumn";
            // 
            // filepathDataGridViewTextBoxColumn
            // 
            this.filepathDataGridViewTextBoxColumn.DataPropertyName = "Filepath";
            this.filepathDataGridViewTextBoxColumn.HeaderText = "路徑";
            this.filepathDataGridViewTextBoxColumn.Name = "filepathDataGridViewTextBoxColumn";
            this.filepathDataGridViewTextBoxColumn.Width = 180;
            // 
            // saveDateDataGridViewTextBoxColumn
            // 
            this.saveDateDataGridViewTextBoxColumn.DataPropertyName = "SaveDate";
            this.saveDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.saveDateDataGridViewTextBoxColumn.Name = "saveDateDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "備註";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // tmpSaveBindingSource
            // 
            this.tmpSaveBindingSource.DataSource = typeof(兩院比對EMR.Model.TmpSave);
            // 
            // genDateDataGridViewTextBoxColumn
            // 
            this.genDateDataGridViewTextBoxColumn.DataPropertyName = "GenDate";
            this.genDateDataGridViewTextBoxColumn.HeaderText = "GenDate";
            this.genDateDataGridViewTextBoxColumn.Name = "genDateDataGridViewTextBoxColumn";
            // 
            // sysDateDataGridViewTextBoxColumn
            // 
            this.sysDateDataGridViewTextBoxColumn.DataPropertyName = "SysDate";
            this.sysDateDataGridViewTextBoxColumn.HeaderText = "SysDate";
            this.sysDateDataGridViewTextBoxColumn.Name = "sysDateDataGridViewTextBoxColumn";
            // 
            // transNoDataGridViewTextBoxColumn
            // 
            this.transNoDataGridViewTextBoxColumn.DataPropertyName = "TransNo";
            this.transNoDataGridViewTextBoxColumn.HeaderText = "TransNo";
            this.transNoDataGridViewTextBoxColumn.Name = "transNoDataGridViewTextBoxColumn";
            this.transNoDataGridViewTextBoxColumn.Width = 180;
            // 
            // eMRNBindingSource
            // 
            this.eMRNBindingSource.DataSource = typeof(兩院比對EMR.Model.EMRN);
            // 
            // genDateDataGridViewTextBoxColumn1
            // 
            this.genDateDataGridViewTextBoxColumn1.DataPropertyName = "GenDate";
            this.genDateDataGridViewTextBoxColumn1.HeaderText = "GenDate";
            this.genDateDataGridViewTextBoxColumn1.Name = "genDateDataGridViewTextBoxColumn1";
            // 
            // sysDateDataGridViewTextBoxColumn1
            // 
            this.sysDateDataGridViewTextBoxColumn1.DataPropertyName = "SysDate";
            this.sysDateDataGridViewTextBoxColumn1.HeaderText = "SysDate";
            this.sysDateDataGridViewTextBoxColumn1.Name = "sysDateDataGridViewTextBoxColumn1";
            // 
            // transNoDataGridViewTextBoxColumn1
            // 
            this.transNoDataGridViewTextBoxColumn1.DataPropertyName = "TransNo";
            this.transNoDataGridViewTextBoxColumn1.HeaderText = "TransNo";
            this.transNoDataGridViewTextBoxColumn1.Name = "transNoDataGridViewTextBoxColumn1";
            this.transNoDataGridViewTextBoxColumn1.Width = 180;
            // 
            // eMRNBindingSource2
            // 
            this.eMRNBindingSource2.DataSource = typeof(兩院比對EMR.Model.EMRN);
            // 
            // frmCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 745);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCompare";
            this.Text = "EMR比對";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmCompare_Shown);
            this.tabControl1.ResumeLayout(false);
            this.CompareResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compair_DIFFDataGridView)).EndInit();
            this.FileStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tmpSaveDataGridView)).EndInit();
            this.DBdata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eMRNDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRNDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compair_DIFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpSaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMRNBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CompareResult;
        private System.Windows.Forms.TabPage FileStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView compair_DIFFDataGridView;
        private System.Windows.Forms.BindingSource compair_DIFFBindingSource;
        private System.Windows.Forms.BindingSource tmpSaveBindingSource;
        private System.Windows.Forms.DataGridView tmpSaveDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDate2;
        private System.Windows.Forms.DateTimePicker dtDate1;
        private System.Windows.Forms.Button btnCompar;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.TabPage DBdata;
        private System.Windows.Forms.TextBox TB_Awayhost;
        private System.Windows.Forms.TextBox TB_Mainhost;

        private System.Windows.Forms.BindingSource eMRNBindingSource;

        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn chartNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptNameDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.DataGridView eMRNDataGridView1;
        private System.Windows.Forms.BindingSource eMRNBindingSource2;
        private System.Windows.Forms.DataGridView eMRNDataGridView;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filepathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker bgwauto;
    }
}