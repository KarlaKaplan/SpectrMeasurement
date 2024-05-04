namespace SpectMeasure
{
    partial class FormAuth
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
            this.labelEnter = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Constantia", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnter.Location = new System.Drawing.Point(345, 88);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(101, 42);
            this.labelEnter.TabIndex = 0;
            this.labelEnter.Text = "Вход";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(274, 183);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(243, 29);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(274, 149);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(68, 23);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Constantia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass.Location = new System.Drawing.Point(274, 229);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(80, 23);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "Пароль";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(278, 270);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(243, 29);
            this.textBoxPass.TabIndex = 4;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(333, 355);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(148, 45);
            this.buttonEnter.TabIndex = 5;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelEnter);
            this.Name = "FormAuth";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuth_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonEnter;
    }
}