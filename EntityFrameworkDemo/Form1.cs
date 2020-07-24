using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void SearchProductsByName(string key)
        {
            dgwProducts.DataSource = _productDal.GetByName(key);
        }
        private void SearchProductsByUnitPrice(decimal min,decimal max)
        {
            //decimal min = Convert.ToDecimal(tbxMinPrice.Text);
            //decimal max = Convert.ToDecimal(tbxMaxPrice.Text);
            dgwProducts.DataSource = _productDal.GetByUnitPrice(min,max);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProductsByName(tbxSearchName.Text);
        }
    }
}
