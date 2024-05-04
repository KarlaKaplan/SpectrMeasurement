namespace SpectMeasure
{
    partial class FormAddData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddData));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelIdProfile = new System.Windows.Forms.Label();
            this.tbIdProfile = new System.Windows.Forms.TextBox();
            this.labelDepth = new System.Windows.Forms.Label();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.labelSoil = new System.Windows.Forms.Label();
            this.tbSoil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(32, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 245);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IdData";
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdProfile";
            this.Column1.HeaderText = "Id профиля";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Depth";
            this.Column2.HeaderText = "Глубина";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoilType";
            this.Column3.HeaderText = "Тип почвы";
            this.Column3.Name = "Column3";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(22, 375);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(93, 31);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(227, 375);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(93, 31);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(326, 375);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 31);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelIdProfile
            // 
            this.labelIdProfile.AutoSize = true;
            this.labelIdProfile.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdProfile.Location = new System.Drawing.Point(18, 285);
            this.labelIdProfile.Name = "labelIdProfile";
            this.labelIdProfile.Size = new System.Drawing.Size(101, 19);
            this.labelIdProfile.TabIndex = 15;
            this.labelIdProfile.Text = "Id профиля";
            // 
            // tbIdProfile
            // 
            this.tbIdProfile.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIdProfile.Location = new System.Drawing.Point(22, 307);
            this.tbIdProfile.Name = "tbIdProfile";
            this.tbIdProfile.Size = new System.Drawing.Size(107, 27);
            this.tbIdProfile.TabIndex = 16;
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepth.Location = new System.Drawing.Point(172, 285);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(74, 19);
            this.labelDepth.TabIndex = 17;
            this.labelDepth.Text = "Глубина";
            // 
            // tbDepth
            // 
            this.tbDepth.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDepth.Location = new System.Drawing.Point(155, 307);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(116, 27);
            this.tbDepth.TabIndex = 18;
            // 
            // labelSoil
            // 
            this.labelSoil.AutoSize = true;
            this.labelSoil.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSoil.Location = new System.Drawing.Point(322, 285);
            this.labelSoil.Name = "labelSoil";
            this.labelSoil.Size = new System.Drawing.Size(95, 19);
            this.labelSoil.TabIndex = 19;
            this.labelSoil.Text = "Тип почвы";
            // 
            // tbSoil
            // 
            this.tbSoil.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSoil.Location = new System.Drawing.Point(304, 307);
            this.tbSoil.Name = "tbSoil";
            this.tbSoil.Size = new System.Drawing.Size(127, 27);
            this.tbSoil.TabIndex = 20;
            // 
            // FormAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 428);
            this.Controls.Add(this.tbSoil);
            this.Controls.Add(this.labelSoil);
            this.Controls.Add(this.tbDepth);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.tbIdProfile);
            this.Controls.Add(this.labelIdProfile);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddData";
            this.Text = "Добавление данных профиля";
            this.Load += new System.EventHandler(this.FormAddData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelIdProfile;
        private System.Windows.Forms.TextBox tbIdProfile;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.Label labelSoil;
        private System.Windows.Forms.TextBox tbSoil;
    }
}