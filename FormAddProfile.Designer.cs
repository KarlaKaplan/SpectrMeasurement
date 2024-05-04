namespace SpectMeasure
{
    partial class FormAddProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddProfile));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelIdSector = new System.Windows.Forms.Label();
            this.labelEquip = new System.Windows.Forms.Label();
            this.tbIdSector = new System.Windows.Forms.TextBox();
            this.tbIdEquip = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(34, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 245);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdProfile";
            this.Column1.HeaderText = "Id профиля";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IdSector";
            this.Column2.HeaderText = "Id участка";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IdEquipment";
            this.Column3.HeaderText = "Id оборудования";
            this.Column3.Name = "Column3";
            // 
            // labelIdSector
            // 
            this.labelIdSector.AutoSize = true;
            this.labelIdSector.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdSector.Location = new System.Drawing.Point(47, 284);
            this.labelIdSector.Name = "labelIdSector";
            this.labelIdSector.Size = new System.Drawing.Size(90, 19);
            this.labelIdSector.TabIndex = 3;
            this.labelIdSector.Text = "Id участка";
            // 
            // labelEquip
            // 
            this.labelEquip.AutoSize = true;
            this.labelEquip.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEquip.Location = new System.Drawing.Point(269, 284);
            this.labelEquip.Name = "labelEquip";
            this.labelEquip.Size = new System.Drawing.Size(143, 19);
            this.labelEquip.TabIndex = 4;
            this.labelEquip.Text = "Id оборудования";
            // 
            // tbIdSector
            // 
            this.tbIdSector.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIdSector.Location = new System.Drawing.Point(34, 317);
            this.tbIdSector.Name = "tbIdSector";
            this.tbIdSector.Size = new System.Drawing.Size(127, 27);
            this.tbIdSector.TabIndex = 8;
            // 
            // tbIdEquip
            // 
            this.tbIdEquip.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIdEquip.Location = new System.Drawing.Point(273, 317);
            this.tbIdEquip.Name = "tbIdEquip";
            this.tbIdEquip.Size = new System.Drawing.Size(139, 27);
            this.tbIdEquip.TabIndex = 9;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(21, 369);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(93, 31);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(311, 369);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 31);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(198, 369);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(93, 31);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormAddProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 428);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tbIdEquip);
            this.Controls.Add(this.tbIdSector);
            this.Controls.Add(this.labelEquip);
            this.Controls.Add(this.labelIdSector);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddProfile";
            this.Text = "Добавление профиля";
            this.Load += new System.EventHandler(this.FormAddProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label labelIdSector;
        private System.Windows.Forms.Label labelEquip;
        private System.Windows.Forms.TextBox tbIdSector;
        private System.Windows.Forms.TextBox tbIdEquip;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNext;
    }
}