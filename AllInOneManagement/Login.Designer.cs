namespace FactoryManagementSystem
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            piclogo = new PictureBox();
            txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            lblLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = false;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(425, 61);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(302, 52);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back";
            lblWelcome.TextAlignment = ContentAlignment.MiddleCenter;
            lblWelcome.UseGdiPlusTextRendering = true;
            lblWelcome.UseSystemCursors = true;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Animated = true;
            txtName.AutoRoundedCorners = true;
            txtName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtName.BorderColor = Color.Silver;
            txtName.BorderRadius = 31;
            txtName.BorderThickness = 2;
            txtName.CustomizableEdges = customizableEdges1;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FillColor = Color.WhiteSmoke;
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Black;
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(403, 131);
            txtName.Margin = new Padding(5, 6, 5, 6);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.DimGray;
            txtName.PlaceholderText = "User Name";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtName.Size = new Size(347, 65);
            txtName.TabIndex = 1;
            txtName.Tag = "Enter Your Username";
            // 
            // piclogo
            // 
            piclogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            piclogo.BackColor = Color.Transparent;
            piclogo.BackgroundImageLayout = ImageLayout.None;
            piclogo.Image = (Image)resources.GetObject("piclogo.Image");
            piclogo.Location = new Point(12, 12);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(389, 377);
            piclogo.SizeMode = PictureBoxSizeMode.Zoom;
            piclogo.TabIndex = 3;
            piclogo.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPass.Animated = true;
            txtPass.AutoRoundedCorners = true;
            txtPass.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtPass.BorderColor = Color.Silver;
            txtPass.BorderRadius = 31;
            txtPass.BorderThickness = 2;
            txtPass.CustomizableEdges = customizableEdges3;
            txtPass.DefaultText = "";
            txtPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPass.FillColor = Color.WhiteSmoke;
            txtPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = Color.Black;
            txtPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPass.Location = new Point(403, 231);
            txtPass.Margin = new Padding(5, 6, 5, 6);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '●';
            txtPass.PlaceholderForeColor = Color.DimGray;
            txtPass.PlaceholderText = "Password";
            txtPass.SelectedText = "";
            txtPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPass.Size = new Size(347, 65);
            txtPass.TabIndex = 2;
            txtPass.Tag = "Enter Your Password";
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.BorderRadius = 30;
            lblLogin.CustomBorderColor = Color.FromArgb(0, 0, 192);
            lblLogin.CustomBorderThickness = new Padding(1);
            lblLogin.CustomizableEdges = customizableEdges5;
            lblLogin.DisabledState.BorderColor = Color.DarkGray;
            lblLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            lblLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lblLogin.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            lblLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lblLogin.FillColor = Color.Blue;
            lblLogin.FillColor2 = Color.DodgerBlue;
            lblLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            lblLogin.IndicateFocus = true;
            lblLogin.Location = new Point(625, 318);
            lblLogin.Name = "lblLogin";
            lblLogin.PressedColor = SystemColors.MenuHighlight;
            lblLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            lblLogin.Size = new Size(125, 61);
            lblLogin.TabIndex = 3;
            lblLogin.Tag = "Login ";
            lblLogin.Text = "Login";
            lblLogin.Click += lblLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLogin);
            Controls.Add(txtPass);
            Controls.Add(piclogo);
            Controls.Add(txtName);
            Controls.Add(lblWelcome);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private PictureBox piclogo;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2GradientButton lblLogin;
    }
}
