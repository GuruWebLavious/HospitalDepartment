namespace HospitalDepartment
{
    partial class ExportDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportDataForm));
            this.comboBoxExport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ExportBackButton = new System.Windows.Forms.Button();
            this.ExportExcelradioButton = new System.Windows.Forms.RadioButton();
            this.ExportHTMLradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxExport
            // 
            this.comboBoxExport.FormattingEnabled = true;
            this.comboBoxExport.Items.AddRange(new object[] {
            "Пациенты",
            "Врачи",
            "Встречи"});
            this.comboBoxExport.Location = new System.Drawing.Point(75, 62);
            this.comboBoxExport.Name = "comboBoxExport";
            this.comboBoxExport.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(41, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Экспорт данных";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExportHTMLradioButton);
            this.groupBox1.Controls.Add(this.ExportExcelradioButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(39, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите формат";
            // 
            // ExportButton
            // 
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportButton.Location = new System.Drawing.Point(11, 202);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(105, 48);
            this.ExportButton.TabIndex = 58;
            this.ExportButton.Text = "Экспорт";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ExportBackButton
            // 
            this.ExportBackButton.BackColor = System.Drawing.Color.PeachPuff;
            this.ExportBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportBackButton.Location = new System.Drawing.Point(156, 202);
            this.ExportBackButton.Name = "ExportBackButton";
            this.ExportBackButton.Size = new System.Drawing.Size(104, 48);
            this.ExportBackButton.TabIndex = 57;
            this.ExportBackButton.Text = "Назад";
            this.ExportBackButton.UseVisualStyleBackColor = false;
            this.ExportBackButton.Click += new System.EventHandler(this.ExportBackButton_Click);
            // 
            // ExportExcelradioButton
            // 
            this.ExportExcelradioButton.AutoSize = true;
            this.ExportExcelradioButton.Location = new System.Drawing.Point(6, 26);
            this.ExportExcelradioButton.Name = "ExportExcelradioButton";
            this.ExportExcelradioButton.Size = new System.Drawing.Size(63, 23);
            this.ExportExcelradioButton.TabIndex = 0;
            this.ExportExcelradioButton.TabStop = true;
            this.ExportExcelradioButton.Text = "Excel";
            this.ExportExcelradioButton.UseVisualStyleBackColor = true;
            // 
            // ExportHTMLradioButton
            // 
            this.ExportHTMLradioButton.AutoSize = true;
            this.ExportHTMLradioButton.Location = new System.Drawing.Point(7, 56);
            this.ExportHTMLradioButton.Name = "ExportHTMLradioButton";
            this.ExportHTMLradioButton.Size = new System.Drawing.Size(68, 23);
            this.ExportHTMLradioButton.TabIndex = 1;
            this.ExportHTMLradioButton.TabStop = true;
            this.ExportHTMLradioButton.Text = "HTML";
            this.ExportHTMLradioButton.UseVisualStyleBackColor = true;
            // 
            // ExportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(281, 277);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ExportBackButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxExport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportDataForm";
            this.Text = "ExportDataForm";
            this.Load += new System.EventHandler(this.ExportDataForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ExportBackButton;
        private System.Windows.Forms.RadioButton ExportExcelradioButton;
        private System.Windows.Forms.RadioButton ExportHTMLradioButton;
    }
}