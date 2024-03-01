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
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LogInButton = new Button();
            SettingsButton = new Button();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(125, 139);
            LoginTextBox.MaxLength = 32;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(150, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(124, 183);
            PasswordTextBox.MaxLength = 32;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(151, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(124, 231);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(151, 23);
            LogInButton.TabIndex = 2;
            LogInButton.Text = "Login";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
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
            LoginLabel.Location = new Point(124, 121);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(37, 15);
            LoginLabel.TabIndex = 4;
            LoginLabel.Text = "Login";
            LoginLabel.Click += label1_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(124, 165);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 416);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(SettingsButton);
            Controls.Add(LogInButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

            userDefinedInitialization();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button LogInButton;
        private Button SettingsButton;
        private Label LoginLabel;
        private Label PasswordLabel;


        DatabaseConnector _connector;


        void userDefinedInitialization()
        {
            _connector = new DatabaseConnector("DESKTOP-25RR54T", "shop_database");
        }
    }
}
