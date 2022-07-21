
namespace coursework.Forms
{
    partial class AuthForm
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
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.lasswordLoginLabel = new System.Windows.Forms.Label();
            this.loginLoginLabel = new System.Windows.Forms.Label();
            this.passwordLoginTextBox = new System.Windows.Forms.TextBox();
            this.loginLoginTextBox = new System.Windows.Forms.TextBox();
            this.registrationGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordRegistrationLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.loginRegistrationLabel = new System.Windows.Forms.Label();
            this.loginRegistrationTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegistrationTextBox = new System.Windows.Forms.TextBox();
            this.errorWarnLabel = new System.Windows.Forms.Label();
            this.loginGroupBox.SuspendLayout();
            this.registrationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.lasswordLoginLabel);
            this.loginGroupBox.Controls.Add(this.loginLoginLabel);
            this.loginGroupBox.Controls.Add(this.passwordLoginTextBox);
            this.loginGroupBox.Controls.Add(this.loginLoginTextBox);
            this.loginGroupBox.Location = new System.Drawing.Point(13, 103);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(433, 335);
            this.loginGroupBox.TabIndex = 0;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Войти в систему";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(145, 277);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 46);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // lasswordLoginLabel
            // 
            this.lasswordLoginLabel.AutoSize = true;
            this.lasswordLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lasswordLoginLabel.Location = new System.Drawing.Point(177, 122);
            this.lasswordLoginLabel.Name = "lasswordLoginLabel";
            this.lasswordLoginLabel.Size = new System.Drawing.Size(80, 25);
            this.lasswordLoginLabel.TabIndex = 3;
            this.lasswordLoginLabel.Text = "Пароль";
            // 
            // loginLoginLabel
            // 
            this.loginLoginLabel.AutoSize = true;
            this.loginLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLoginLabel.Location = new System.Drawing.Point(163, 39);
            this.loginLoginLabel.Name = "loginLoginLabel";
            this.loginLoginLabel.Size = new System.Drawing.Size(68, 25);
            this.loginLoginLabel.TabIndex = 2;
            this.loginLoginLabel.Text = "Логин";
            // 
            // passwordLoginTextBox
            // 
            this.passwordLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLoginTextBox.Location = new System.Drawing.Point(7, 172);
            this.passwordLoginTextBox.Name = "passwordLoginTextBox";
            this.passwordLoginTextBox.Size = new System.Drawing.Size(420, 30);
            this.passwordLoginTextBox.TabIndex = 1;
            // 
            // loginLoginTextBox
            // 
            this.loginLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLoginTextBox.Location = new System.Drawing.Point(6, 76);
            this.loginLoginTextBox.Name = "loginLoginTextBox";
            this.loginLoginTextBox.Size = new System.Drawing.Size(420, 30);
            this.loginLoginTextBox.TabIndex = 0;
            // 
            // registrationGroupBox
            // 
            this.registrationGroupBox.Controls.Add(this.passwordRegistrationLabel);
            this.registrationGroupBox.Controls.Add(this.registrationButton);
            this.registrationGroupBox.Controls.Add(this.loginRegistrationLabel);
            this.registrationGroupBox.Controls.Add(this.loginRegistrationTextBox);
            this.registrationGroupBox.Controls.Add(this.passwordRegistrationTextBox);
            this.registrationGroupBox.Location = new System.Drawing.Point(503, 103);
            this.registrationGroupBox.Name = "registrationGroupBox";
            this.registrationGroupBox.Size = new System.Drawing.Size(444, 335);
            this.registrationGroupBox.TabIndex = 1;
            this.registrationGroupBox.TabStop = false;
            this.registrationGroupBox.Text = "Зарегистрироваться";
            // 
            // passwordRegistrationLabel
            // 
            this.passwordRegistrationLabel.AutoSize = true;
            this.passwordRegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegistrationLabel.Location = new System.Drawing.Point(185, 122);
            this.passwordRegistrationLabel.Name = "passwordRegistrationLabel";
            this.passwordRegistrationLabel.Size = new System.Drawing.Size(80, 25);
            this.passwordRegistrationLabel.TabIndex = 8;
            this.passwordRegistrationLabel.Text = "Пароль";
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrationButton.Location = new System.Drawing.Point(107, 277);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(234, 46);
            this.registrationButton.TabIndex = 5;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // loginRegistrationLabel
            // 
            this.loginRegistrationLabel.AutoSize = true;
            this.loginRegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegistrationLabel.Location = new System.Drawing.Point(188, 39);
            this.loginRegistrationLabel.Name = "loginRegistrationLabel";
            this.loginRegistrationLabel.Size = new System.Drawing.Size(68, 25);
            this.loginRegistrationLabel.TabIndex = 7;
            this.loginRegistrationLabel.Text = "Логин";
            // 
            // loginRegistrationTextBox
            // 
            this.loginRegistrationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginRegistrationTextBox.Location = new System.Drawing.Point(8, 76);
            this.loginRegistrationTextBox.Name = "loginRegistrationTextBox";
            this.loginRegistrationTextBox.Size = new System.Drawing.Size(430, 30);
            this.loginRegistrationTextBox.TabIndex = 5;
            // 
            // passwordRegistrationTextBox
            // 
            this.passwordRegistrationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRegistrationTextBox.Location = new System.Drawing.Point(6, 172);
            this.passwordRegistrationTextBox.Name = "passwordRegistrationTextBox";
            this.passwordRegistrationTextBox.Size = new System.Drawing.Size(432, 30);
            this.passwordRegistrationTextBox.TabIndex = 6;
            // 
            // errorWarnLabel
            // 
            this.errorWarnLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.errorWarnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorWarnLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.errorWarnLabel.Location = new System.Drawing.Point(12, 32);
            this.errorWarnLabel.Name = "errorWarnLabel";
            this.errorWarnLabel.Size = new System.Drawing.Size(935, 42);
            this.errorWarnLabel.TabIndex = 5;
            this.errorWarnLabel.Visible = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.errorWarnLabel);
            this.Controls.Add(this.registrationGroupBox);
            this.Controls.Add(this.loginGroupBox);
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.registrationGroupBox.ResumeLayout(false);
            this.registrationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.GroupBox registrationGroupBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label lasswordLoginLabel;
        private System.Windows.Forms.Label loginLoginLabel;
        private System.Windows.Forms.TextBox passwordLoginTextBox;
        private System.Windows.Forms.TextBox loginLoginTextBox;
        private System.Windows.Forms.Label passwordRegistrationLabel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label loginRegistrationLabel;
        private System.Windows.Forms.TextBox loginRegistrationTextBox;
        private System.Windows.Forms.TextBox passwordRegistrationTextBox;
        private System.Windows.Forms.Label errorWarnLabel;
    }
}