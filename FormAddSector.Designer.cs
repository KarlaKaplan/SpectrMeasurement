namespace SpectMeasure
{
    partial class FormAddSector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSector));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCoordX = new System.Windows.Forms.Label();
            this.labelCoordY = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCoordX = new System.Windows.Forms.TextBox();
            this.tbCoordY = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(29, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 280);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(160, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Населённый пункт";
            // 
            // labelCoordX
            // 
            this.labelCoordX.AutoSize = true;
            this.labelCoordX.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordX.Location = new System.Drawing.Point(178, 280);
            this.labelCoordX.Name = "labelCoordX";
            this.labelCoordX.Size = new System.Drawing.Size(122, 19);
            this.labelCoordX.TabIndex = 2;
            this.labelCoordX.Text = "Координата Х";
            // 
            // labelCoordY
            // 
            this.labelCoordY.AutoSize = true;
            this.labelCoordY.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoordY.Location = new System.Drawing.Point(317, 280);
            this.labelCoordY.Name = "labelCoordY";
            this.labelCoordY.Size = new System.Drawing.Size(121, 19);
            this.labelCoordY.TabIndex = 3;
            this.labelCoordY.Text = "Координата Y";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(12, 311);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 27);
            this.tbName.TabIndex = 4;
            // 
            // tbCoordX
            // 
            this.tbCoordX.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCoordX.Location = new System.Drawing.Point(182, 311);
            this.tbCoordX.Name = "tbCoordX";
            this.tbCoordX.Size = new System.Drawing.Size(118, 27);
            this.tbCoordX.TabIndex = 5;
            // 
            // tbCoordY
            // 
            this.tbCoordY.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCoordY.Location = new System.Drawing.Point(321, 311);
            this.tbCoordY.Name = "tbCoordY";
            this.tbCoordY.Size = new System.Drawing.Size(117, 27);
            this.tbCoordY.TabIndex = 6;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 372);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(93, 31);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(207, 372);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(93, 31);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(321, 372);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 31);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdSector";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NameSector";
            this.Column4.HeaderText = "Населённый пункт";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CoordX";
            this.Column2.HeaderText = "Координата Х";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CoordY";
            this.Column3.HeaderText = "Координата Y";
            this.Column3.Name = "Column3";
            // 
            // FormAddSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 428);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tbCoordY);
            this.Controls.Add(this.tbCoordX);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelCoordY);
            this.Controls.Add(this.labelCoordX);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddSector";
            this.Text = "Добавление участка";
            this.Load += new System.EventHandler(this.FormAddSector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCoordX;
        private System.Windows.Forms.Label labelCoordY;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCoordX;
        private System.Windows.Forms.TextBox tbCoordY;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}