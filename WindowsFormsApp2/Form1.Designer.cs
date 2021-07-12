
namespace WindowsFormsApp2
{
    partial class Калькулятор
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Калькулятор));
            this.numstartcount = new System.Windows.Forms.NumericUpDown();
            this.numpercent = new System.Windows.Forms.NumericUpDown();
            this.numyears = new System.Windows.Forms.NumericUpDown();
            this.comboprocess = new System.Windows.Forms.ComboBox();
            this.total = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numstartcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            this.SuspendLayout();
            // 
            // numstartcount
            // 
            this.numstartcount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numstartcount.DecimalPlaces = 2;
            this.numstartcount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numstartcount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numstartcount.Location = new System.Drawing.Point(227, 36);
            this.numstartcount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numstartcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numstartcount.Name = "numstartcount";
            this.numstartcount.Size = new System.Drawing.Size(181, 22);
            this.numstartcount.TabIndex = 0;
            this.numstartcount.ThousandsSeparator = true;
            this.numstartcount.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // numpercent
            // 
            this.numpercent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numpercent.DecimalPlaces = 2;
            this.numpercent.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numpercent.Location = new System.Drawing.Point(227, 78);
            this.numpercent.Name = "numpercent";
            this.numpercent.Size = new System.Drawing.Size(181, 22);
            this.numpercent.TabIndex = 1;
            // 
            // numyears
            // 
            this.numyears.BackColor = System.Drawing.SystemColors.Window;
            this.numyears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numyears.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numyears.Location = new System.Drawing.Point(227, 119);
            this.numyears.Name = "numyears";
            this.numyears.Size = new System.Drawing.Size(181, 22);
            this.numyears.TabIndex = 2;
            // 
            // comboprocess
            // 
            this.comboprocess.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboprocess.FormattingEnabled = true;
            this.comboprocess.Items.AddRange(new object[] {
            "Ежедневно ",
            "Ежемесячно",
            "Ежеквартально",
            "По полугодиям",
            "Ежегодно"});
            this.comboprocess.Location = new System.Drawing.Point(227, 164);
            this.comboprocess.Name = "comboprocess";
            this.comboprocess.Size = new System.Drawing.Size(180, 22);
            this.comboprocess.TabIndex = 3;
            this.comboprocess.SelectedIndexChanged += new System.EventHandler(this.comboprocess_SelectedIndexChanged);
            // 
            // total
            // 
            this.total.Cursor = System.Windows.Forms.Cursors.Hand;
            this.total.DecimalPlaces = 2;
            this.total.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total.ForeColor = System.Drawing.Color.RoyalBlue;
            this.total.Location = new System.Drawing.Point(203, 275);
            this.total.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(188, 22);
            this.total.TabIndex = 4;
            this.total.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Изначальная сумма:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Процентная ставка (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество лет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Процесс начисления:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(72, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ИТОГО:";
            // 
            // Калькулятор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(426, 348);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.comboprocess);
            this.Controls.Add(this.numyears);
            this.Controls.Add(this.numpercent);
            this.Controls.Add(this.numstartcount);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Калькулятор";
            this.Text = "Калькулятор";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Калькулятор_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numstartcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numstartcount;
        private System.Windows.Forms.NumericUpDown numpercent;
        private System.Windows.Forms.NumericUpDown numyears;
        private System.Windows.Forms.ComboBox comboprocess;
        private System.Windows.Forms.NumericUpDown total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

