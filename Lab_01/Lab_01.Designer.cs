namespace Lab_01
{
    partial class Lab_01
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DisplayLevelsButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CorrelationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MY = new System.Windows.Forms.TextBox();
            this.DY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(13, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(775, 378);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // DisplayLevelsButton
            // 
            this.DisplayLevelsButton.Location = new System.Drawing.Point(606, 415);
            this.DisplayLevelsButton.Name = "DisplayLevelsButton";
            this.DisplayLevelsButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayLevelsButton.TabIndex = 1;
            this.DisplayLevelsButton.Text = "Levels";
            this.DisplayLevelsButton.UseVisualStyleBackColor = true;
            this.DisplayLevelsButton.Click += new System.EventHandler(this.DisplayLevelsButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(13, 414);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(118, 414);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CorrelationButton
            // 
            this.CorrelationButton.Location = new System.Drawing.Point(713, 415);
            this.CorrelationButton.Name = "CorrelationButton";
            this.CorrelationButton.Size = new System.Drawing.Size(75, 23);
            this.CorrelationButton.TabIndex = 4;
            this.CorrelationButton.Text = "Correlation";
            this.CorrelationButton.UseVisualStyleBackColor = true;
            this.CorrelationButton.Click += new System.EventHandler(this.CorrelationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "M(Y):";
            // 
            // MY
            // 
            this.MY.Location = new System.Drawing.Point(271, 415);
            this.MY.Name = "MY";
            this.MY.ReadOnly = true;
            this.MY.Size = new System.Drawing.Size(100, 20);
            this.MY.TabIndex = 6;
            // 
            // DY
            // 
            this.DY.Location = new System.Drawing.Point(441, 416);
            this.DY.Name = "DY";
            this.DY.ReadOnly = true;
            this.DY.Size = new System.Drawing.Size(100, 20);
            this.DY.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "D(Y):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorrelationButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.DisplayLevelsButton);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Lab 01";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button DisplayLevelsButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CorrelationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MY;
        private System.Windows.Forms.TextBox DY;
        private System.Windows.Forms.Label label2;
    }
}

