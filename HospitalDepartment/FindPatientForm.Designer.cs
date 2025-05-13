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
            this.dataGridViewPatient.Size = new System.Drawing.Size(674, 260);
            this.dataGridViewPatient.TabIndex = 0;
            // 
            // choosePatientButton
            // 
            this.choosePatientButton.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosePatientButton.Location = new System.Drawing.Point(469, 13);
            this.choosePatientButton.Name = "choosePatientButton";
            this.choosePatientButton.Size = new System.Drawing.Size(217, 57);
            this.choosePatientButton.TabIndex = 43;
            this.choosePatientButton.Text = "Выбрать";
            this.choosePatientButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(229, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Отсортировать по:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(233, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 24);
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
            // 
            // nameCreatePatientBox
            // 
            this.nameCreatePatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCreatePatientBox.Location = new System.Drawing.Point(233, 78);
            this.nameCreatePatientBox.Name = "nameCreatePatientBox";
            this.nameCreatePatientBox.Size = new System.Drawing.Size(177, 30);
            this.nameCreatePatientBox.TabIndex = 47;
            // 
            // FindPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(698, 467);
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
    }
}