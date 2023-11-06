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
            lb_name = new Label();
            lb_des = new Label();
            lb_price = new Label();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 328);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 372);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 1;
            label2.Text = "Mô tả sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 417);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 2;
            label3.Text = "Giá";
            // 
            // productDetailsButton
            // 
            productDetailsButton.Location = new Point(20, 468);
            productDetailsButton.Margin = new Padding(4, 5, 4, 5);
            productDetailsButton.Name = "productDetailsButton";
            productDetailsButton.Size = new Size(133, 38);
            productDetailsButton.TabIndex = 3;
            productDetailsButton.Text = "Xem chi tiết";
            productDetailsButton.UseVisualStyleBackColor = true;
            // 
            // addToCartButton
            // 
            addToCartButton.Location = new Point(161, 468);
            addToCartButton.Margin = new Padding(4, 5, 4, 5);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(133, 38);
            addToCartButton.TabIndex = 4;
            addToCartButton.Text = "Thêm vào giỏ hàng";
            addToCartButton.UseVisualStyleBackColor = true;
            // 
            // productPictureBox
            // 
            productPictureBox.BorderStyle = BorderStyle.Fixed3D;
            productPictureBox.InitialImage = null;
            productPictureBox.Location = new Point(20, 40);
            productPictureBox.Margin = new Padding(4, 5, 4, 5);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(274, 257);
            productPictureBox.TabIndex = 5;
            productPictureBox.TabStop = false;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(162, 328);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(56, 25);
            lb_name.TabIndex = 6;
            lb_name.Text = "name";
            // 
            // lb_des
            // 
            lb_des.AutoSize = true;
            lb_des.Location = new Point(162, 372);
            lb_des.Name = "lb_des";
            lb_des.Size = new Size(40, 25);
            lb_des.TabIndex = 7;
            lb_des.Text = "des";
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Location = new Point(162, 417);
            lb_price.Name = "lb_price";
            lb_price.Size = new Size(50, 25);
            lb_price.TabIndex = 8;
            lb_price.Text = "price";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_price);
            Controls.Add(lb_des);
            Controls.Add(lb_name);
            Controls.Add(productPictureBox);
            Controls.Add(addToCartButton);
            Controls.Add(productDetailsButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductCard";
            Size = new Size(314, 538);
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
        private Label lb_name;
        private Label lb_des;
        private Label lb_price;
    }
}
