namespace iut_dbm_lw4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.crewsDataGridView = new System.Windows.Forms.DataGridView();
            this.CrewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewsDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crewsLabel = new System.Windows.Forms.Label();
            this.positionsLable = new System.Windows.Forms.Label();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesLabel = new System.Windows.Forms.Label();
            this.positionsDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.positionsDataGridView = new System.Windows.Forms.DataGridView();
            this.PositionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.crewsDataGridView)).BeginInit();
            this.crewsDataGridViewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.positionsDataGridViewContextMenuStrip.SuspendLayout();
            this.employeesDataGridViewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // crewsDataGridView
            // 
            this.crewsDataGridView.AllowUserToDeleteRows = false;
            this.crewsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crewsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CrewId,
            this.CrewName});
            this.crewsDataGridView.Location = new System.Drawing.Point(12, 25);
            this.crewsDataGridView.Name = "crewsDataGridView";
            this.crewsDataGridView.Size = new System.Drawing.Size(193, 150);
            this.crewsDataGridView.TabIndex = 0;
            this.crewsDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.crewsDataGridView_CellMouseUp);
            this.crewsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.crewsDataGridView_CellValueChanged);
            this.crewsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.crewsDataGridView_UserDeletingRow);
            // 
            // CrewId
            // 
            this.CrewId.Frozen = true;
            this.CrewId.HeaderText = "Id";
            this.CrewId.Name = "CrewId";
            this.CrewId.ReadOnly = true;
            this.CrewId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CrewId.Width = 50;
            // 
            // CrewName
            // 
            this.CrewName.Frozen = true;
            this.CrewName.HeaderText = "Name";
            this.CrewName.Name = "CrewName";
            // 
            // crewsDataGridViewContextMenuStrip
            // 
            this.crewsDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.crewsDataGridViewContextMenuStrip.Name = "crewsDataGridViewContextMenuStrip";
            this.crewsDataGridViewContextMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // crewsLabel
            // 
            this.crewsLabel.AutoSize = true;
            this.crewsLabel.Location = new System.Drawing.Point(9, 9);
            this.crewsLabel.Name = "crewsLabel";
            this.crewsLabel.Size = new System.Drawing.Size(36, 13);
            this.crewsLabel.TabIndex = 1;
            this.crewsLabel.Text = "Crews";
            // 
            // positionsLable
            // 
            this.positionsLable.AutoSize = true;
            this.positionsLable.Location = new System.Drawing.Point(208, 9);
            this.positionsLable.Name = "positionsLable";
            this.positionsLable.Size = new System.Drawing.Size(49, 13);
            this.positionsLable.TabIndex = 3;
            this.positionsLable.Text = "Positions";
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.employeeFio});
            this.employeesDataGridView.Location = new System.Drawing.Point(411, 26);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.Size = new System.Drawing.Size(193, 150);
            this.employeesDataGridView.TabIndex = 4;
            this.employeesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employeesDataGridView_CellMouseDoubleClick);
            this.employeesDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employeesDataGridView_CellMouseUp);
            // 
            // EmployeeId
            // 
            this.EmployeeId.Frozen = true;
            this.EmployeeId.HeaderText = "Id";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Width = 50;
            // 
            // employeeFio
            // 
            this.employeeFio.Frozen = true;
            this.employeeFio.HeaderText = "FIO";
            this.employeeFio.Name = "employeeFio";
            this.employeeFio.ReadOnly = true;
            // 
            // employeesLabel
            // 
            this.employeesLabel.AutoSize = true;
            this.employeesLabel.Location = new System.Drawing.Point(408, 9);
            this.employeesLabel.Name = "employeesLabel";
            this.employeesLabel.Size = new System.Drawing.Size(58, 13);
            this.employeesLabel.TabIndex = 5;
            this.employeesLabel.Text = "Employees";
            // 
            // positionsDataGridViewContextMenuStrip
            // 
            this.positionsDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.positionsDataGridViewContextMenuStrip.Name = "crewsDataGridViewContextMenuStrip";
            this.positionsDataGridViewContextMenuStrip.Size = new System.Drawing.Size(108, 26);
            this.positionsDataGridViewContextMenuStrip.Click += new System.EventHandler(this.positionsDataGridViewContextMenuStrip_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Delete";
            // 
            // employeesDataGridViewContextMenuStrip
            // 
            this.employeesDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.employeesDataGridViewContextMenuStrip.Name = "crewsDataGridViewContextMenuStrip";
            this.employeesDataGridViewContextMenuStrip.Size = new System.Drawing.Size(181, 48);
            this.employeesDataGridViewContextMenuStrip.Click += new System.EventHandler(this.employeesDataGridViewContextMenuStrip_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Delete";
            // 
            // positionsDataGridView
            // 
            this.positionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionId,
            this.PositionName});
            this.positionsDataGridView.Location = new System.Drawing.Point(212, 26);
            this.positionsDataGridView.Name = "positionsDataGridView";
            this.positionsDataGridView.Size = new System.Drawing.Size(193, 150);
            this.positionsDataGridView.TabIndex = 6;
            this.positionsDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.positionsDataGridView_CellMouseUp);
            this.positionsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.positionsDataGridView_CellValueChanged);
            // 
            // PositionId
            // 
            this.PositionId.HeaderText = "Id";
            this.PositionId.Name = "PositionId";
            this.PositionId.ReadOnly = true;
            this.PositionId.Width = 50;
            // 
            // PositionName
            // 
            this.PositionName.HeaderText = "Name";
            this.PositionName.Name = "PositionName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 189);
            this.Controls.Add(this.positionsDataGridView);
            this.Controls.Add(this.employeesLabel);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(this.positionsLable);
            this.Controls.Add(this.crewsLabel);
            this.Controls.Add(this.crewsDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crewsDataGridView)).EndInit();
            this.crewsDataGridViewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.positionsDataGridViewContextMenuStrip.ResumeLayout(false);
            this.employeesDataGridViewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.positionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView crewsDataGridView;
        private System.Windows.Forms.ContextMenuStrip crewsDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrewName;
        private System.Windows.Forms.Label crewsLabel;
        private System.Windows.Forms.Label positionsLable;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFio;
        private System.Windows.Forms.Label employeesLabel;
        private System.Windows.Forms.ContextMenuStrip positionsDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip employeesDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView positionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionName;
    }
}

