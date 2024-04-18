namespace Exem
{
    partial class Ohas
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "\"BeautyShop\" - это современный салон красоты, в котором каждый клиент может полно" +
                "стью расслабиться и ",
            "насладиться профессиональными услугами.",
            " Мы предлагаем широкий спектр услуг, включая парикмахерские услуги, педикюр, мани" +
                "кюр, массаж и солярий.",
            "",
            "Наши опытные специалисты по уходу за вами с большим вниманием и",
            " заботой, используя только качественные продукты.",
            " Мы всегда следим за новыми тенденциями в мире красоты и стараемся предложить наш" +
                "им клиентам самые передовые методики и техники.",
            "",
            "В \"BeautyShop\" вы можете насладиться уютной атмосферой, профессиональным обслужив" +
                "анием и индивидуальным подходом.",
            " Мы стремимся к тому, чтобы каждый наш клиент чувствовал себя особенным и уходил " +
                "от нас",
            " с улучшенным настроением и уверенностью в себе.",
            "",
            "Доверьте свою красоту профессионалам в \"BeautyShop\" и наслаждайтесь отличными рез" +
                "ультатами!",
            "",
            "",
            ""});
            this.listBox1.Location = new System.Drawing.Point(12, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(766, 342);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ohas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Ohas";
            this.Text = "Ohas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}