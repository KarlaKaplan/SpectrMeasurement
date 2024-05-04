namespace SpectMeasure
{
    partial class FormAddEquip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEquip));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSerNum = new System.Windows.Forms.Label();
            this.tbSerNum = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(31, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 245);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelSerNum
            // 
            this.labelSerNum.AutoSize = true;
            this.labelSerNum.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSerNum.Location = new System.Drawing.Point(27, 276);
            this.labelSerNum.Name = "labelSerNum";
            this.labelSerNum.Size = new System.Drawing.Size(153, 19);
            this.labelSerNum.TabIndex = 2;
            this.labelSerNum.Text = "Серийный номер ";
            // 
            // tbSerNum
            // 
            this.tbSerNum.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSerNum.Location = new System.Drawing.Point(245, 308);
            this.tbSerNum.Name = "tbSerNum";
            this.tbSerNum.Size = new System.Drawing.Size(188, 27);
            this.tbSerNum.TabIndex = 5;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModel.Location = new System.Drawing.Point(296, 276);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(71, 19);
            this.labelModel.TabIndex = 6;
            this.labelModel.Text = "Модель";
            this.labelModel.Click += new System.EventHandler(this.labelModel_Click);
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbModel.Location = new System.Drawing.Point(22, 308);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(183, 27);
            this.tbModel.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdEquipment";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Model";
            this.Column2.HeaderText = "Серийный номер";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SerialNumber";
            this.Column3.HeaderText = "Модель";
            this.Column3.Name = "Column3";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 368);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(93, 31);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(193, 368);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(93, 31);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(316, 368);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 31);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormAddEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 428);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.tbSerNum);
            this.Controls.Add(this.labelSerNum);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddEquip";
            this.Text = "Добавление оборудования";
            this.Load += new System.EventHandler(this.FormAddEquip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSerNum;
        private System.Windows.Forms.TextBox tbSerNum;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSave;
    }
}