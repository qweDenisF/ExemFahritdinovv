namespace Exem
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
            this.Avtor = new System.Windows.Forms.Button();
            this.Regist = new System.Windows.Forms.Button();
            this.TbUserAvt = new System.Windows.Forms.TextBox();
            this.TbPasAvt = new System.Windows.Forms.TextBox();
            this.LabelInf = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.beautyShopFDDataSet = new Exem.BeautyShopFDDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyShopFDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Avtor
            // 
            this.Avtor.Location = new System.Drawing.Point(123, 192);
            this.Avtor.Name = "Avtor";
            this.Avtor.Size = new System.Drawing.Size(75, 23);
            this.Avtor.TabIndex = 0;
            this.Avtor.Text = "Авторизация";
            this.Avtor.UseVisualStyleBackColor = true;
            this.Avtor.Click += new System.EventHandler(this.Avtor_Click);
            // 
            // Regist
            // 
            this.Regist.Location = new System.Drawing.Point(223, 192);
            this.Regist.Name = "Regist";
            this.Regist.Size = new System.Drawing.Size(81, 23);
            this.Regist.TabIndex = 1;
            this.Regist.Text = "Регистрация";
            this.Regist.UseVisualStyleBackColor = true;
            this.Regist.Click += new System.EventHandler(this.Regist_Click);
            // 
            // TbUserAvt
            // 
            this.TbUserAvt.Location = new System.Drawing.Point(153, 98);
            this.TbUserAvt.Name = "TbUserAvt";
            this.TbUserAvt.Size = new System.Drawing.Size(100, 20);
            this.TbUserAvt.TabIndex = 2;
            // 
            // TbPasAvt
            // 
            this.TbPasAvt.Location = new System.Drawing.Point(153, 144);
            this.TbPasAvt.Name = "TbPasAvt";
            this.TbPasAvt.Size = new System.Drawing.Size(100, 20);
            this.TbPasAvt.TabIndex = 3;
            // 
            // LabelInf
            // 
            this.LabelInf.AutoSize = true;
            this.LabelInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInf.Location = new System.Drawing.Point(12, 19);
            this.LabelInf.Name = "LabelInf";
            this.LabelInf.Size = new System.Drawing.Size(406, 33);
            this.LabelInf.TabIndex = 4;
            this.LabelInf.Text = "Салон красоты \"BeautyShop\"";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.beautyShopFDDataSet;
            this.bindingSource1.Position = 0;
            // 
            // beautyShopFDDataSet
            // 
            this.beautyShopFDDataSet.DataSetName = "BeautyShopFDDataSet";
            this.beautyShopFDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 243);
            this.Controls.Add(this.LabelInf);
            this.Controls.Add(this.TbPasAvt);
            this.Controls.Add(this.TbUserAvt);
            this.Controls.Add(this.Regist);
            this.Controls.Add(this.Avtor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyShopFDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Avtor;
        private System.Windows.Forms.Button Regist;
        private System.Windows.Forms.TextBox TbUserAvt;
        private System.Windows.Forms.TextBox TbPasAvt;
        private System.Windows.Forms.Label LabelInf;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BeautyShopFDDataSet beautyShopFDDataSet;
    }
}

