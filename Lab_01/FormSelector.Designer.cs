namespace Lab_01
{
    partial class FormSelector
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
            this.Lab01 = new System.Windows.Forms.Button();
            this.Lab02 = new System.Windows.Forms.Button();
            this.Lab03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lab01
            // 
            this.Lab01.Location = new System.Drawing.Point(22, 25);
            this.Lab01.Name = "Lab01";
            this.Lab01.Size = new System.Drawing.Size(75, 23);
            this.Lab01.TabIndex = 0;
            this.Lab01.Text = "Lab_01";
            this.Lab01.UseVisualStyleBackColor = true;
            this.Lab01.Click += new System.EventHandler(this.Lab01_Click);
            // 
            // Lab02
            // 
            this.Lab02.Location = new System.Drawing.Point(103, 25);
            this.Lab02.Name = "Lab02";
            this.Lab02.Size = new System.Drawing.Size(75, 23);
            this.Lab02.TabIndex = 1;
            this.Lab02.Text = "Lab_02";
            this.Lab02.UseVisualStyleBackColor = true;
            this.Lab02.Click += new System.EventHandler(this.Lab02_Click);
            // 
            // Lab03
            // 
            this.Lab03.Location = new System.Drawing.Point(184, 25);
            this.Lab03.Name = "Lab03";
            this.Lab03.Size = new System.Drawing.Size(75, 23);
            this.Lab03.TabIndex = 2;
            this.Lab03.Text = "Lab_03";
            this.Lab03.UseVisualStyleBackColor = true;
            this.Lab03.Click += new System.EventHandler(this.Lab03_Click);
            // 
            // FormSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 273);
            this.Controls.Add(this.Lab03);
            this.Controls.Add(this.Lab02);
            this.Controls.Add(this.Lab01);
            this.Name = "FormSelector";
            this.Text = "Select Lab";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lab01;
        private System.Windows.Forms.Button Lab02;
        private System.Windows.Forms.Button Lab03;
    }
}