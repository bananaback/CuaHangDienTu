using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienTu.UI.Product
{
    public partial class ProductCard : UserControl
    {
        string name, des;
        decimal price;
        public ProductCard(string name, string des, decimal price)
        {
            this.name = name;
            this.des = des;
            this.price = price;
            InitializeComponent();
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {
            lb_name.Text = name;
            lb_des.Text = des;
            lb_price.Text = price.ToString();
        }
    }
}
