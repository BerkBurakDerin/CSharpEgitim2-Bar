namespace CSharpEgıtım2.PresentationLayer
{
    partial class FrmProduct
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
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtProductStock = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.btnList2 = new System.Windows.Forms.Button();
            this.cmbCategoryId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(115, 477);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(167, 45);
            this.btnGetById.TabIndex = 28;
            this.btnGetById.Text = "ID\'ye Göre Getir";
            this.btnGetById.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(115, 426);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 45);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(115, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 45);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Silme";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(115, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 45);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(115, 61);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(167, 22);
            this.txtProductName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ürün Adı:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(115, 273);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(67, 45);
            this.btnList.TabIndex = 19;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 545);
            this.dataGridView1.TabIndex = 18;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(115, 33);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(167, 22);
            this.txtProductId.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ürün ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 30;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.AutoSize = true;
            this.txtProductPrice.Location = new System.Drawing.Point(29, 120);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(70, 16);
            this.txtProductPrice.TabIndex = 29;
            this.txtProductPrice.Text = "Ürün Fiyat:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 22);
            this.textBox2.TabIndex = 32;
            // 
            // txtProductStock
            // 
            this.txtProductStock.AutoSize = true;
            this.txtProductStock.Location = new System.Drawing.Point(31, 92);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(68, 16);
            this.txtProductStock.TabIndex = 31;
            this.txtProductStock.Text = "Ürün Stok:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 178);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 83);
            this.textBox3.TabIndex = 34;
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoSize = true;
            this.cmbCategory.Location = new System.Drawing.Point(39, 148);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(60, 16);
            this.cmbCategory.TabIndex = 33;
            this.cmbCategory.Text = "Kategori:";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Location = new System.Drawing.Point(33, 181);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(66, 16);
            this.txtDescription.TabIndex = 36;
            this.txtDescription.Text = "Açıklama:";
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(215, 273);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(67, 45);
            this.btnList2.TabIndex = 37;
            this.btnList2.Text = "Listele2";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // cmbCategoryId
            // 
            this.cmbCategoryId.FormattingEnabled = true;
            this.cmbCategoryId.Location = new System.Drawing.Point(115, 148);
            this.cmbCategoryId.Name = "cmbCategoryId";
            this.cmbCategoryId.Size = new System.Drawing.Size(167, 24);
            this.cmbCategoryId.TabIndex = 38;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1009, 579);
            this.Controls.Add(this.cmbCategoryId);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtProductPrice;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtProductStock;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label cmbCategory;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Button btnList2;
        private System.Windows.Forms.ComboBox cmbCategoryId;
    }
}