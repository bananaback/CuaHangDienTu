namespace CuaHangDienTu.UI.Product
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            productDetailsButton = new Button();
            addToCartButton = new Button();
            productPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 197);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 223);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Mô tả sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 250);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "Giá";
            // 
            // productDetailsButton
            // 
            productDetailsButton.Location = new Point(14, 281);
            productDetailsButton.Name = "productDetailsButton";
            productDetailsButton.Size = new Size(93, 23);
            productDetailsButton.TabIndex = 3;
            productDetailsButton.Text = "Xem chi tiết";
            productDetailsButton.UseVisualStyleBackColor = true;
            // 
            // addToCartButton
            // 
            addToCartButton.Location = new Point(113, 281);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(93, 23);
            addToCartButton.TabIndex = 4;
            addToCartButton.Text = "Thêm vào giỏ hàng";
            addToCartButton.UseVisualStyleBackColor = true;
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(14, 24);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(192, 154);
            productPictureBox.TabIndex = 5;
            productPictureBox.TabStop = false;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productPictureBox);
            Controls.Add(addToCartButton);
            Controls.Add(productDetailsButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductCard";
            Size = new Size(220, 323);
            Load += ProductCard_Load;
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button productDetailsButton;
        private Button addToCartButton;
        private PictureBox productPictureBox;
    }
}
