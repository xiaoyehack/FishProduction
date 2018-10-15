namespace FishProduction
{
    partial class FromProductInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SofeEdti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthSelect = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butDisplayAll = new System.Windows.Forms.Button();
            this.txtSimIdSearch = new System.Windows.Forms.TextBox();
            this.txtBoardidSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butExport = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.butDelect = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtSoftCombox = new System.Windows.Forms.ComboBox();
            this.txtProdate = new System.Windows.Forms.TextBox();
            this.txtSimIdAdd = new System.Windows.Forms.TextBox();
            this.txtBoardAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.boardid,
            this.SimId,
            this.SofeEdti,
            this.prodate,
            this.OtherOne,
            this.OtherTwo});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 17);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle4.NullValue = null;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(745, 476);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // boardid
            // 
            this.boardid.DataPropertyName = "boardid";
            this.boardid.HeaderText = "板子ID";
            this.boardid.Name = "boardid";
            this.boardid.ReadOnly = true;
            // 
            // SimId
            // 
            this.SimId.DataPropertyName = "SimId";
            this.SimId.HeaderText = "Sim卡号";
            this.SimId.Name = "SimId";
            this.SimId.ReadOnly = true;
            // 
            // SofeEdti
            // 
            this.SofeEdti.DataPropertyName = "SofeEdti";
            this.SofeEdti.HeaderText = "软件版本";
            this.SofeEdti.Name = "SofeEdti";
            this.SofeEdti.ReadOnly = true;
            // 
            // prodate
            // 
            this.prodate.DataPropertyName = "prodate";
            this.prodate.HeaderText = "生产日期";
            this.prodate.Name = "prodate";
            this.prodate.ReadOnly = true;
            // 
            // OtherOne
            // 
            this.OtherOne.DataPropertyName = "OtherOne";
            this.OtherOne.HeaderText = "OtherOne";
            this.OtherOne.Name = "OtherOne";
            this.OtherOne.ReadOnly = true;
            // 
            // OtherTwo
            // 
            this.OtherTwo.DataPropertyName = "OtherTwo";
            this.OtherTwo.HeaderText = "OtherTwo";
            this.OtherTwo.Name = "OtherTwo";
            this.OtherTwo.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthSelect);
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 496);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // monthSelect
            // 
            this.monthSelect.Location = new System.Drawing.Point(528, 280);
            this.monthSelect.Name = "monthSelect";
            this.monthSelect.TabIndex = 17;
            this.monthSelect.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthSelect_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butDisplayAll);
            this.groupBox2.Controls.Add(this.txtSimIdSearch);
            this.groupBox2.Controls.Add(this.txtBoardidSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(769, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索";
            // 
            // butDisplayAll
            // 
            this.butDisplayAll.Location = new System.Drawing.Point(59, 95);
            this.butDisplayAll.Name = "butDisplayAll";
            this.butDisplayAll.Size = new System.Drawing.Size(117, 23);
            this.butDisplayAll.TabIndex = 4;
            this.butDisplayAll.Text = "显示全部";
            this.butDisplayAll.UseVisualStyleBackColor = true;
            this.butDisplayAll.Click += new System.EventHandler(this.butDisplayAll_Click);
            // 
            // txtSimIdSearch
            // 
            this.txtSimIdSearch.Location = new System.Drawing.Point(59, 61);
            this.txtSimIdSearch.Name = "txtSimIdSearch";
            this.txtSimIdSearch.Size = new System.Drawing.Size(117, 21);
            this.txtSimIdSearch.TabIndex = 2;
            this.txtSimIdSearch.TextChanged += new System.EventHandler(this.txtSimIdSearch_TextChanged);
            // 
            // txtBoardidSearch
            // 
            this.txtBoardidSearch.Location = new System.Drawing.Point(59, 29);
            this.txtBoardidSearch.Name = "txtBoardidSearch";
            this.txtBoardidSearch.Size = new System.Drawing.Size(117, 21);
            this.txtBoardidSearch.TabIndex = 2;
            this.txtBoardidSearch.TextChanged += new System.EventHandler(this.txtBoardidSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sim卡号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "板子ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butExport);
            this.groupBox3.Controls.Add(this.butClear);
            this.groupBox3.Controls.Add(this.butSave);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.butDelect);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtNote);
            this.groupBox3.Controls.Add(this.txtOther);
            this.groupBox3.Controls.Add(this.txtSoftCombox);
            this.groupBox3.Controls.Add(this.txtProdate);
            this.groupBox3.Controls.Add(this.txtSimIdAdd);
            this.groupBox3.Controls.Add(this.txtBoardAdd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(769, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 360);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加\\修改";
            // 
            // butExport
            // 
            this.butExport.Location = new System.Drawing.Point(59, 330);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(96, 23);
            this.butExport.TabIndex = 21;
            this.butExport.Text = "导出到Excel";
            this.butExport.UseVisualStyleBackColor = true;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(115, 247);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 20;
            this.butClear.Text = "取消";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(18, 247);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 19;
            this.butSave.Text = "添加";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(64, 22);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(126, 21);
            this.txtId.TabIndex = 18;
            this.txtId.Text = "添加时无编号";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "编号：";
            // 
            // butDelect
            // 
            this.butDelect.Location = new System.Drawing.Point(18, 301);
            this.butDelect.Name = "butDelect";
            this.butDelect.Size = new System.Drawing.Size(168, 23);
            this.butDelect.TabIndex = 15;
            this.butDelect.Text = "删除选中行";
            this.butDelect.UseVisualStyleBackColor = true;
            this.butDelect.Click += new System.EventHandler(this.butDelect_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(27, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "提示：双击表格修改或添加";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(64, 201);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(126, 21);
            this.txtNote.TabIndex = 13;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(64, 171);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(126, 21);
            this.txtOther.TabIndex = 12;
            // 
            // txtSoftCombox
            // 
            this.txtSoftCombox.FormattingEnabled = true;
            this.txtSoftCombox.ItemHeight = 12;
            this.txtSoftCombox.Items.AddRange(new object[] {
            "V1.0",
            "V2.0",
            "V2.01"});
            this.txtSoftCombox.Location = new System.Drawing.Point(64, 111);
            this.txtSoftCombox.Name = "txtSoftCombox";
            this.txtSoftCombox.Size = new System.Drawing.Size(126, 20);
            this.txtSoftCombox.TabIndex = 11;
            this.txtSoftCombox.Text = "V1.0";
            // 
            // txtProdate
            // 
            this.txtProdate.Location = new System.Drawing.Point(64, 144);
            this.txtProdate.Name = "txtProdate";
            this.txtProdate.Size = new System.Drawing.Size(126, 21);
            this.txtProdate.TabIndex = 12;
            this.txtProdate.Enter += new System.EventHandler(this.txtProdate_Enter);
            this.txtProdate.Leave += new System.EventHandler(this.txtProdate_Leave);
            // 
            // txtSimIdAdd
            // 
            this.txtSimIdAdd.Location = new System.Drawing.Point(64, 80);
            this.txtSimIdAdd.Name = "txtSimIdAdd";
            this.txtSimIdAdd.Size = new System.Drawing.Size(126, 21);
            this.txtSimIdAdd.TabIndex = 9;
            // 
            // txtBoardAdd
            // 
            this.txtBoardAdd.Location = new System.Drawing.Point(64, 53);
            this.txtBoardAdd.Name = "txtBoardAdd";
            this.txtBoardAdd.Size = new System.Drawing.Size(126, 21);
            this.txtBoardAdd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "备注：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "其他：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "生产日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "软件版本：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sim卡号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "板子ID：";
            // 
            // FromProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 509);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FromProductInfo";
            this.Text = "产品信息";
            this.Load += new System.EventHandler(this.FromProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SimId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SofeEdti;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherTwo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSimIdSearch;
        private System.Windows.Forms.TextBox txtBoardidSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDisplayAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butDelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.ComboBox txtSoftCombox;
        private System.Windows.Forms.TextBox txtProdate;
        private System.Windows.Forms.TextBox txtSimIdAdd;
        private System.Windows.Forms.TextBox txtBoardAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar monthSelect;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butExport;
    }
}