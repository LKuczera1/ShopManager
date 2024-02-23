namespace ShopManager
{
    partial class LoginWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LogInButton = new Button();
            SettingsButton = new Button();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 1;
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(128, 228);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(148, 23);
            LogInButton.TabIndex = 2;
            LogInButton.Text = "Login";
            LogInButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            SettingsButton.Image = Properties.Resources.settingsIcon;
            SettingsButton.Location = new Point(9, 7);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(40, 39);
            SettingsButton.TabIndex = 3;
            SettingsButton.UseVisualStyleBackColor = true;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(127, 121);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(37, 15);
            LoginLabel.TabIndex = 4;
            LoginLabel.Text = "Login";
            LoginLabel.Click += label1_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(127, 165);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 417);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(SettingsButton);
            Controls.Add(LogInButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button LogInButton;
        private Button SettingsButton;
        private Label LoginLabel;
        private Label PasswordLabel;
    }
}
