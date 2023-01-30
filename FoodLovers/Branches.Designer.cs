namespace FoodLovers
{
    partial class Branches
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.dtpOpenDate = new System.Windows.Forms.DateTimePicker();
            this.dgvBranches = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnImportJson = new System.Windows.Forms.Button();
            this.btnImportXml = new System.Windows.Forms.Button();
            this.btnImportCsv = new System.Windows.Forms.Button();
            this.btnExportXml = new System.Windows.Forms.Button();
            this.btnExportJson = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "OpenDate";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(619, 105);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(178, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(619, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(619, 165);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(178, 20);
            this.txtTelephone.TabIndex = 7;
            // 
            // dtpOpenDate
            // 
            this.dtpOpenDate.Location = new System.Drawing.Point(619, 206);
            this.dtpOpenDate.Name = "dtpOpenDate";
            this.dtpOpenDate.Size = new System.Drawing.Size(178, 20);
            this.dtpOpenDate.TabIndex = 8;
            // 
            // dgvBranches
            // 
            this.dgvBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBranches.Location = new System.Drawing.Point(12, 105);
            this.dgvBranches.Name = "dgvBranches";
            this.dgvBranches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBranches.Size = new System.Drawing.Size(494, 236);
            this.dgvBranches.TabIndex = 9;
            this.dgvBranches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBranches_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(542, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(722, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(632, 261);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(234, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(431, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Location = new System.Drawing.Point(234, 376);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(75, 23);
            this.btnExportCsv.TabIndex = 15;
            this.btnExportCsv.Text = "Export CSV";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            this.btnExportCsv.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImportJson
            // 
            this.btnImportJson.Location = new System.Drawing.Point(419, 347);
            this.btnImportJson.Name = "btnImportJson";
            this.btnImportJson.Size = new System.Drawing.Size(85, 23);
            this.btnImportJson.TabIndex = 16;
            this.btnImportJson.Text = "Import JSON";
            this.btnImportJson.UseVisualStyleBackColor = true;
            this.btnImportJson.Click += new System.EventHandler(this.btnImportJson_Click);
            // 
            // btnImportXml
            // 
            this.btnImportXml.Location = new System.Drawing.Point(315, 347);
            this.btnImportXml.Name = "btnImportXml";
            this.btnImportXml.Size = new System.Drawing.Size(86, 23);
            this.btnImportXml.TabIndex = 17;
            this.btnImportXml.Text = "Import XML";
            this.btnImportXml.UseVisualStyleBackColor = true;
            // 
            // btnImportCsv
            // 
            this.btnImportCsv.Location = new System.Drawing.Point(234, 347);
            this.btnImportCsv.Name = "btnImportCsv";
            this.btnImportCsv.Size = new System.Drawing.Size(75, 23);
            this.btnImportCsv.TabIndex = 18;
            this.btnImportCsv.Text = "Import CSV";
            this.btnImportCsv.UseVisualStyleBackColor = true;
            this.btnImportCsv.Click += new System.EventHandler(this.btnImportCsv_Click);
            // 
            // btnExportXml
            // 
            this.btnExportXml.Location = new System.Drawing.Point(315, 376);
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(86, 23);
            this.btnExportXml.TabIndex = 19;
            this.btnExportXml.Text = "Export XML";
            this.btnExportXml.UseVisualStyleBackColor = true;
            this.btnExportXml.Click += new System.EventHandler(this.btnExportXml_Click);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Location = new System.Drawing.Point(419, 376);
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(85, 23);
            this.btnExportJson.TabIndex = 20;
            this.btnExportJson.Text = "Export JSON";
            this.btnExportJson.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 347);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(216, 20);
            this.txtFilePath.TabIndex = 21;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Branches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 404);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnExportJson);
            this.Controls.Add(this.btnExportXml);
            this.Controls.Add(this.btnImportCsv);
            this.Controls.Add(this.btnImportXml);
            this.Controls.Add(this.btnImportJson);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBranches);
            this.Controls.Add(this.dtpOpenDate);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Branches";
            this.Text = "Branches";
            this.Load += new System.EventHandler(this.Branches_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBranches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.DateTimePicker dtpOpenDate;
        private System.Windows.Forms.DataGridView dgvBranches;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnImportJson;
        private System.Windows.Forms.Button btnImportXml;
        private System.Windows.Forms.Button btnImportCsv;
        private System.Windows.Forms.Button btnExportXml;
        private System.Windows.Forms.Button btnExportJson;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}