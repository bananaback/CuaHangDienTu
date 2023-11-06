namespace CuaHangDienTu.UI.Main
{
    partial class MainForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn__home = new Guna.UI2.WinForms.Guna2Button();
            btn__product = new Guna.UI2.WinForms.Guna2Button();
            btn__logout = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btn__home
            // 
            btn__home.CustomizableEdges = customizableEdges1;
            btn__home.DisabledState.BorderColor = Color.DarkGray;
            btn__home.DisabledState.CustomBorderColor = Color.DarkGray;
            btn__home.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn__home.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn__home.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn__home.ForeColor = Color.White;
            btn__home.Location = new Point(3, 12);
            btn__home.Name = "btn__home";
            btn__home.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn__home.Size = new Size(135, 43);
            btn__home.TabIndex = 2;
            btn__home.Text = "Home";
            btn__home.Click += btn__home_Click;
            // 
            // btn__product
            // 
            btn__product.CustomizableEdges = customizableEdges3;
            btn__product.DisabledState.BorderColor = Color.DarkGray;
            btn__product.DisabledState.CustomBorderColor = Color.DarkGray;
            btn__product.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn__product.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn__product.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn__product.ForeColor = Color.White;
            btn__product.Location = new Point(3, 61);
            btn__product.Name = "btn__product";
            btn__product.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn__product.Size = new Size(135, 43);
            btn__product.TabIndex = 3;
            btn__product.Text = "Product";
            btn__product.Click += btn__product_Click;
            // 
            // btn__logout
            // 
            btn__logout.CustomizableEdges = customizableEdges5;
            btn__logout.DisabledState.BorderColor = Color.DarkGray;
            btn__logout.DisabledState.CustomBorderColor = Color.DarkGray;
            btn__logout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn__logout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn__logout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn__logout.ForeColor = Color.White;
            btn__logout.Location = new Point(3, 630);
            btn__logout.Name = "btn__logout";
            btn__logout.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn__logout.Size = new Size(135, 43);
            btn__logout.TabIndex = 4;
            btn__logout.Text = "LogOut";
            btn__logout.Click += btn__logout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Right;
            panel1.ForeColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(181, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 750);
            panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 750);
            Controls.Add(btn__logout);
            Controls.Add(btn__product);
            Controls.Add(btn__home);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button logoutButton;
        private Button view1Button;
        private Button view2Button;
        private Guna.UI2.WinForms.Guna2Button btn__home;
        private Guna.UI2.WinForms.Guna2Button btn__product;
        private Guna.UI2.WinForms.Guna2Button btn__logout;
        private Panel panel1;
    }
}