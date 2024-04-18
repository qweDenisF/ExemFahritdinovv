namespace Exem
{
    partial class Registrat
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
            this.клиентTableAdapter1 = new Exem.BeautyShopFDDataSetTableAdapters.КлиентTableAdapter();
            this.beautyShopFDDataSet1 = new Exem.BeautyShopFDDataSet();
            this.TBfioReg = new System.Windows.Forms.TextBox();
            this.TBphoneReg = new System.Windows.Forms.TextBox();
            this.TBemailReg = new System.Windows.Forms.TextBox();
            this.TBuserReg = new System.Windows.Forms.TextBox();
            this.TBpasswReg = new System.Windows.Forms.TextBox();
            this.RegistrDob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.beautyShopFDDataSet = new Exem.BeautyShopFDDataSet();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.beautyShopFDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyShopFDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // клиентTableAdapter1
            // 
            this.клиентTableAdapter1.ClearBeforeFill = true;
            // 
            // beautyShopFDDataSet1
            // 
            this.beautyShopFDDataSet1.DataSetName = "BeautyShopFDDataSet";
            this.beautyShopFDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBfioReg
            // 
            this.TBfioReg.Location = new System.Drawing.Point(89, 165);
            this.TBfioReg.Name = "TBfioReg";
            this.TBfioReg.Size = new System.Drawing.Size(128, 20);
            this.TBfioReg.TabIndex = 0;
            this.TBfioReg.TextChanged += new System.EventHandler(this.TBfioReg_TextChanged);
            // 
            // TBphoneReg
            // 
            this.TBphoneReg.Location = new System.Drawing.Point(234, 165);
            this.TBphoneReg.Name = "TBphoneReg";
            this.TBphoneReg.Size = new System.Drawing.Size(128, 20);
            this.TBphoneReg.TabIndex = 1;
            // 
            // TBemailReg
            // 
            this.TBemailReg.Location = new System.Drawing.Point(371, 165);
            this.TBemailReg.Name = "TBemailReg";
            this.TBemailReg.Size = new System.Drawing.Size(128, 20);
            this.TBemailReg.TabIndex = 2;
            // 
            // TBuserReg
            // 
            this.TBuserReg.Location = new System.Drawing.Point(89, 243);
            this.TBuserReg.Name = "TBuserReg";
            this.TBuserReg.Size = new System.Drawing.Size(128, 20);
            this.TBuserReg.TabIndex = 3;
            // 
            // TBpasswReg
            // 
            this.TBpasswReg.Location = new System.Drawing.Point(234, 243);
            this.TBpasswReg.Name = "TBpasswReg";
            this.TBpasswReg.PasswordChar = '*';
            this.TBpasswReg.Size = new System.Drawing.Size(128, 20);
            this.TBpasswReg.TabIndex = 4;
            // 
            // RegistrDob
            // 
            this.RegistrDob.Location = new System.Drawing.Point(375, 243);
            this.RegistrDob.Name = "RegistrDob";
            this.RegistrDob.Size = new System.Drawing.Size(124, 20);
            this.RegistrDob.TabIndex = 5;
            this.RegistrDob.Text = "Зарегистрироваться";
            this.RegistrDob.UseVisualStyleBackColor = true;
            this.RegistrDob.Click += new System.EventHandler(this.RegistrDob_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Контактный телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Никнейм";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пароль";
            // 
            // beautyShopFDDataSet
            // 
            this.beautyShopFDDataSet.DataSetName = "BeautyShopFDDataSet";
            this.beautyShopFDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.beautyShopFDDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Возвращение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistrDob);
            this.Controls.Add(this.TBpasswReg);
            this.Controls.Add(this.TBuserReg);
            this.Controls.Add(this.TBemailReg);
            this.Controls.Add(this.TBphoneReg);
            this.Controls.Add(this.TBfioReg);
            this.Name = "Registrat";
            this.Text = "Registrat";
            this.Load += new System.EventHandler(this.Registrat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautyShopFDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyShopFDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BeautyShopFDDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter1;
        private BeautyShopFDDataSet beautyShopFDDataSet1;
        private System.Windows.Forms.TextBox TBfioReg;
        private System.Windows.Forms.TextBox TBphoneReg;
        private System.Windows.Forms.TextBox TBemailReg;
        private System.Windows.Forms.TextBox TBuserReg;
        private System.Windows.Forms.TextBox TBpasswReg;
        private System.Windows.Forms.Button RegistrDob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private BeautyShopFDDataSet beautyShopFDDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private System.Windows.Forms.Button button1;
    }
}