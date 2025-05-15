namespace HospitalDepartment
{
    partial class FindPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindPatientForm));
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.choosePatientButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.findPatientBackButton = new System.Windows.Forms.Button();
            this.nameCreatePatientBox = new System.Windows.Forms.TextBox();
            this.curPagePatient = new System.Windows.Forms.TextBox();
            this.NextPagePatient = new System.Windows.Forms.LinkLabel();
            this.PreviousPagePatient = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.AllowUserToAddRows = false;
            this.dataGridViewPatient.AllowUserToDeleteRows = false;
            this.dataGridViewPatient.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Location = new System.Drawing.Point(12, 195);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.ReadOnly = true;
            this.dataGridViewPatient.RowHeadersWidth = 51;
            this.dataGridViewPatient.RowTemplate.Height = 24;
            this.dataGridViewPatient.Size = new System.Drawing.Size(941, 260);
            this.dataGridViewPatient.TabIndex = 0;
            // 
            // choosePatientButton
            // 
            this.choosePatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choosePatientButton.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosePatientButton.Location = new System.Drawing.Point(736, 12);
            this.choosePatientButton.Name = "choosePatientButton";
            this.choosePatientButton.Size = new System.Drawing.Size(217, 57);
            this.choosePatientButton.TabIndex = 43;
            this.choosePatientButton.Text = "Выбрать";
            this.choosePatientButton.UseVisualStyleBackColor = true;
            this.choosePatientButton.Click += new System.EventHandler(this.choosePatientButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(243, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Отсортировать по:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(454, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 45;
            // 
            // findPatientBackButton
            // 
            this.findPatientBackButton.BackColor = System.Drawing.Color.PeachPuff;
            this.findPatientBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findPatientBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findPatientBackButton.Location = new System.Drawing.Point(12, 13);
            this.findPatientBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.findPatientBackButton.Name = "findPatientBackButton";
            this.findPatientBackButton.Size = new System.Drawing.Size(172, 59);
            this.findPatientBackButton.TabIndex = 46;
            this.findPatientBackButton.Text = "Назад";
            this.findPatientBackButton.UseVisualStyleBackColor = false;
            this.findPatientBackButton.Click += new System.EventHandler(this.findPatientBackButton_Click);
            // 
            // nameCreatePatientBox
            // 
            this.nameCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCreatePatientBox.Location = new System.Drawing.Point(454, 42);
            this.nameCreatePatientBox.Name = "nameCreatePatientBox";
            this.nameCreatePatientBox.Size = new System.Drawing.Size(177, 30);
            this.nameCreatePatientBox.TabIndex = 47;
            // 
            // curPagePatient
            // 
            this.curPagePatient.Location = new System.Drawing.Point(454, 158);
            this.curPagePatient.Name = "curPagePatient";
            this.curPagePatient.Size = new System.Drawing.Size(59, 22);
            this.curPagePatient.TabIndex = 48;
            this.curPagePatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NextPagePatient
            // 
            this.NextPagePatient.AutoSize = true;
            this.NextPagePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPagePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextPagePatient.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.NextPagePatient.Location = new System.Drawing.Point(519, 146);
            this.NextPagePatient.Name = "NextPagePatient";
            this.NextPagePatient.Size = new System.Drawing.Size(60, 46);
            this.NextPagePatient.TabIndex = 49;
            this.NextPagePatient.TabStop = true;
            this.NextPagePatient.Text = "→";
            this.NextPagePatient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextPagePatient_LinkClicked);
            // 
            // PreviousPagePatient
            // 
            this.PreviousPagePatient.AutoSize = true;
            this.PreviousPagePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPagePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousPagePatient.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.PreviousPagePatient.Location = new System.Drawing.Point(388, 146);
            this.PreviousPagePatient.Name = "PreviousPagePatient";
            this.PreviousPagePatient.Size = new System.Drawing.Size(60, 46);
            this.PreviousPagePatient.TabIndex = 50;
            this.PreviousPagePatient.TabStop = true;
            this.PreviousPagePatient.Text = "\t←";
            this.PreviousPagePatient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PreviousPagePatient_LinkClicked);
            // 
            // FindPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(965, 467);
            this.Controls.Add(this.PreviousPagePatient);
            this.Controls.Add(this.NextPagePatient);
            this.Controls.Add(this.curPagePatient);
            this.Controls.Add(this.nameCreatePatientBox);
            this.Controls.Add(this.findPatientBackButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choosePatientButton);
            this.Controls.Add(this.dataGridViewPatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindPatientForm";
            this.Text = "FindPatientForm";
            this.Load += new System.EventHandler(this.FindPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.Button choosePatientButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button findPatientBackButton;
        private System.Windows.Forms.TextBox nameCreatePatientBox;
        private System.Windows.Forms.TextBox curPagePatient;
        private System.Windows.Forms.LinkLabel NextPagePatient;
        private System.Windows.Forms.LinkLabel PreviousPagePatient;
    }
}