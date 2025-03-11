    using CSharpEgıtım2.BusinessLayer.Abstract;
    using CSharpEgıtım2.BusinessLayer.Concrete;
    using CSharpEgıtım2.DataAccessLayer.EntityFramework;
    using CSharpEgıtım2.EntityLayer.Concrete;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace CSharpEgıtım2.PresentationLayer
    {
        public partial class FrmProduct: Form
        {
            private readonly IProductService _productService;
            public FrmProduct()
            {
                InitializeComponent();
                _productService = new ProductManager(new EFProductDal());
            }

        
            private void btnList_Click(object sender, EventArgs e)
            {
                var values = _productService.TGetAll();
                dataGridView1.DataSource = values;
            }
            private void btnList2_Click(object sender, EventArgs e)
            {
                var values = _productService.TGetProductsWithCategory();
                dataGridView1.DataSource = values;

            }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.ProductStock =int.Parse(txtProductStock.Text);
            product.ProductPrice = decimal.Parse(txtProductPrice.Text);
            product.ProductDescription = txtDescription.Text;
            product.CategoryId = int.Parse(cmbCategoryId.Text);
            _productService.TInsert(product);
        }
    }
    }
