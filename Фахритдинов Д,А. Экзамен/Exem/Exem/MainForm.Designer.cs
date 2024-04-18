namespace Exem
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelInf = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.beautyShopFDDataSet = new Exem.BeautyShopFDDataSet();
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеTableAdapter = new Exem.BeautyShopFDDataSetTableAdapters.РасписаниеTableAdapter();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneSotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasp2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyShopFDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Услуги";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelInf
            // 
            this.LabelInf.AutoSize = true;
            this.LabelInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInf.Location = new System.Drawing.Point(140, 9);
            this.LabelInf.Name = "LabelInf";
            this.LabelInf.Size = new System.Drawing.Size(483, 39);
            this.LabelInf.TabIndex = 2;
            this.LabelInf.Text = "Салон красоты \"BeautyShop\"";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(59, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(633, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "О нас";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.phoneSotDataGridViewTextBoxColumn,
            this.dolgDataGridViewTextBoxColumn,
            this.raspDataGridViewTextBoxColumn,
            this.rasp2DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.расписаниеBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(59, 235);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(564, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // beautyShopFDDataSet
            // 
            this.beautyShopFDDataSet.DataSetName = "BeautyShopFDDataSet";
            this.beautyShopFDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.beautyShopFDDataSet;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneSotDataGridViewTextBoxColumn
            // 
            this.phoneSotDataGridViewTextBoxColumn.DataPropertyName = "PhoneSot";
            this.phoneSotDataGridViewTextBoxColumn.HeaderText = "PhoneSot";
            this.phoneSotDataGridViewTextBoxColumn.Name = "phoneSotDataGridViewTextBoxColumn";
            this.phoneSotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dolgDataGridViewTextBoxColumn
            // 
            this.dolgDataGridViewTextBoxColumn.DataPropertyName = "Dolg";
            this.dolgDataGridViewTextBoxColumn.HeaderText = "Dolg";
            this.dolgDataGridViewTextBoxColumn.Name = "dolgDataGridViewTextBoxColumn";
            this.dolgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raspDataGridViewTextBoxColumn
            // 
            this.raspDataGridViewTextBoxColumn.DataPropertyName = "Rasp";
            this.raspDataGridViewTextBoxColumn.HeaderText = "Rasp";
            this.raspDataGridViewTextBoxColumn.Name = "raspDataGridViewTextBoxColumn";
            this.raspDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rasp2DataGridViewTextBoxColumn
            // 
            this.rasp2DataGridViewTextBoxColumn.DataPropertyName = "Rasp2";
            this.rasp2DataGridViewTextBoxColumn.HeaderText = "Rasp2";
            this.rasp2DataGridViewTextBoxColumn.Name = "rasp2DataGridViewTextBoxColumn";
            this.rasp2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Расписание";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LabelInf);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyShopFDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelInf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BeautyShopFDDataSet beautyShopFDDataSet;
        private System.Windows.Forms.BindingSource расписаниеBindingSource;
        private BeautyShopFDDataSetTableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneSotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rasp2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}