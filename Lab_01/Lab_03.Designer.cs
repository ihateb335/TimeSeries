namespace Lab_01
{
    partial class Lab_03
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
            this.Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yI = new System.Windows.Forms.TextBox();
            this.sI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yII = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sII = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Fisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Quantile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.F1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.F2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SeriesMax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SeriesCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Mediana = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.N1_Val = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.N1_Val)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Calculate.Location = new System.Drawing.Point(0, 0);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(477, 23);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вибіркове середнє I:";
            // 
            // yI
            // 
            this.yI.Location = new System.Drawing.Point(133, 62);
            this.yI.Name = "yI";
            this.yI.ReadOnly = true;
            this.yI.Size = new System.Drawing.Size(100, 20);
            this.yI.TabIndex = 6;
            // 
            // sI
            // 
            this.sI.Location = new System.Drawing.Point(370, 65);
            this.sI.Name = "sI";
            this.sI.ReadOnly = true;
            this.sI.Size = new System.Drawing.Size(100, 20);
            this.sI.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вибіркова дисперсія I:";
            // 
            // yII
            // 
            this.yII.Location = new System.Drawing.Point(133, 115);
            this.yII.Name = "yII";
            this.yII.ReadOnly = true;
            this.yII.Size = new System.Drawing.Size(100, 20);
            this.yII.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вибіркове середнє II:";
            // 
            // sII
            // 
            this.sII.Location = new System.Drawing.Point(370, 115);
            this.sII.Name = "sII";
            this.sII.ReadOnly = true;
            this.sII.Size = new System.Drawing.Size(100, 20);
            this.sII.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вибіркова дисперсія II:";
            // 
            // Fisher
            // 
            this.Fisher.Location = new System.Drawing.Point(370, 166);
            this.Fisher.Name = "Fisher";
            this.Fisher.ReadOnly = true;
            this.Fisher.Size = new System.Drawing.Size(100, 20);
            this.Fisher.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Критерій Фішера";
            // 
            // Student
            // 
            this.Student.Location = new System.Drawing.Point(133, 166);
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            this.Student.Size = new System.Drawing.Size(100, 20);
            this.Student.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Критерій Стьюдента: ";
            // 
            // Quantile
            // 
            this.Quantile.Location = new System.Drawing.Point(185, 205);
            this.Quantile.Name = "Quantile";
            this.Quantile.ReadOnly = true;
            this.Quantile.Size = new System.Drawing.Size(100, 20);
            this.Quantile.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Квантіль розподілу Стьюдента:";
            // 
            // F1
            // 
            this.F1.Location = new System.Drawing.Point(370, 205);
            this.F1.Name = "F1";
            this.F1.ReadOnly = true;
            this.F1.Size = new System.Drawing.Size(100, 20);
            this.F1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "F1:";
            // 
            // F2
            // 
            this.F2.Location = new System.Drawing.Point(370, 231);
            this.F2.Name = "F2";
            this.F2.ReadOnly = true;
            this.F2.Size = new System.Drawing.Size(100, 20);
            this.F2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "F2:";
            // 
            // SeriesMax
            // 
            this.SeriesMax.Location = new System.Drawing.Point(133, 389);
            this.SeriesMax.Name = "SeriesMax";
            this.SeriesMax.ReadOnly = true;
            this.SeriesMax.Size = new System.Drawing.Size(100, 20);
            this.SeriesMax.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 39);
            this.label10.TabIndex = 27;
            this.label10.Text = "Протяжність \r\nнайдовшої серії:\r\n\r\n";
            // 
            // SeriesCount
            // 
            this.SeriesCount.Location = new System.Drawing.Point(133, 335);
            this.SeriesCount.Name = "SeriesCount";
            this.SeriesCount.ReadOnly = true;
            this.SeriesCount.Size = new System.Drawing.Size(100, 20);
            this.SeriesCount.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Загальна \r\nкількість серій:";
            // 
            // Mediana
            // 
            this.Mediana.Location = new System.Drawing.Point(133, 282);
            this.Mediana.Name = "Mediana";
            this.Mediana.ReadOnly = true;
            this.Mediana.Size = new System.Drawing.Size(100, 20);
            this.Mediana.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Вибіркова медіана:";
            // 
            // Result
            // 
            this.Result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Result.Location = new System.Drawing.Point(0, 463);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(477, 20);
            this.Result.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Результат:";
            // 
            // N1_Val
            // 
            this.N1_Val.Dock = System.Windows.Forms.DockStyle.Top;
            this.N1_Val.Location = new System.Drawing.Point(0, 23);
            this.N1_Val.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N1_Val.Name = "N1_Val";
            this.N1_Val.Size = new System.Drawing.Size(477, 20);
            this.N1_Val.TabIndex = 31;
            this.N1_Val.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Lab_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 483);
            this.Controls.Add(this.N1_Val);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SeriesMax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SeriesCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Mediana);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Quantile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Fisher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sII);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yII);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculate);
            this.Name = "Lab_03";
            this.Text = "Lab_03";
            ((System.ComponentModel.ISupportInitialize)(this.N1_Val)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yI;
        private System.Windows.Forms.TextBox sI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yII;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sII;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Student;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Quantile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox F1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox F2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SeriesMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SeriesCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Mediana;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown N1_Val;
    }
}