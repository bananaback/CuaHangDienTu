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
            logoutButton = new Button();
            panel1 = new Panel();
            view1Button = new Button();
            view2Button = new Button();
            SuspendLayout();
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(21, 380);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(75, 23);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "Đăng xuất";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.ForeColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(128, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 426);
            panel1.TabIndex = 1;
            // 
            // view1Button
            // 
            view1Button.Location = new Point(12, 12);
            view1Button.Name = "view1Button";
            view1Button.Size = new Size(75, 23);
            view1Button.TabIndex = 2;
            view1Button.Text = "View 1";
            view1Button.UseVisualStyleBackColor = true;
            view1Button.Click += button1_Click;
            // 
            // view2Button
            // 
            view2Button.Location = new Point(12, 55);
            view2Button.Name = "view2Button";
            view2Button.Size = new Size(75, 23);
            view2Button.TabIndex = 3;
            view2Button.Text = "View 2";
            view2Button.UseVisualStyleBackColor = true;
            view2Button.Click += view2Button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(view2Button);
            Controls.Add(view1Button);
            Controls.Add(panel1);
            Controls.Add(logoutButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button logoutButton;
        private Panel panel1;
        private Button view1Button;
        private Button view2Button;
    }
}