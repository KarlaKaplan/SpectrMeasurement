namespace SpectMeasure
{
    partial class FormAddMeas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMeas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tbIdProfile = new System.Windows.Forms.TextBox();
            this.labelIdProfile = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.labelCom = new System.Windows.Forms.Label();
            this.tbCom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column2,
            this.Column1,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(29, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 245);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IdMeasurement";
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DateMeas";
            this.Column2.HeaderText = "Дата измерения";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdProfile";
            this.Column1.HeaderText = "Id профиля";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Сomment";
            this.Column3.HeaderText = "Комментарий";
            this.Column3.Name = "Column3";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(16, 375);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(93, 31);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(190, 375);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(113, 31);
            this.buttonNext.TabIndex = 14;
            this.buttonNext.Text = "На главную";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(321, 375);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 31);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tbIdProfile
            // 
            this.tbIdProfile.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIdProfile.Location = new System.Drawing.Point(163, 313);
            this.tbIdProfile.Name = "tbIdProfile";
            this.tbIdProfile.Size = new System.Drawing.Size(107, 27);
            this.tbIdProfile.TabIndex = 17;
            // 
            // labelIdProfile
            // 
            this.labelIdProfile.AutoSize = true;
            this.labelIdProfile.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdProfile.Location = new System.Drawing.Point(169, 282);
            this.labelIdProfile.Name = "labelIdProfile";
            this.labelIdProfile.Size = new System.Drawing.Size(101, 19);
            this.labelIdProfile.TabIndex = 18;
            this.labelIdProfile.Text = "Id профиля";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(12, 282);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(139, 19);
            this.labelDate.TabIndex = 19;
            this.labelDate.Text = "Дата измерения";
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDate.Location = new System.Drawing.Point(12, 313);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(135, 27);
            this.tbDate.TabIndex = 20;
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCom.Location = new System.Drawing.Point(308, 282);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(121, 19);
            this.labelCom.TabIndex = 21;
            this.labelCom.Text = "Комментарий";
            // 
            // tbCom
            // 
            this.tbCom.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCom.Location = new System.Drawing.Point(290, 313);
            this.tbCom.Name = "tbCom";
            this.tbCom.Size = new System.Drawing.Size(148, 27);
            this.tbCom.TabIndex = 22;
            // 
            // FormAddMeas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 428);
            this.Controls.Add(this.tbCom);
            this.Controls.Add(this.labelCom);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelIdProfile);
            this.Controls.Add(this.tbIdProfile);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddMeas";
            this.Text = "Добавление измерений";
            this.Load += new System.EventHandler(this.FormAddMeas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox tbIdProfile;
        private System.Windows.Forms.Label labelIdProfile;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox tbCom;
    }
}