using Npgsql;
using ProductsDiagram.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProductsDiagram
{
    public partial class AllProducts : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Products;User Id=postgres;Password=0987");
        private List<Product> products = new List<Product>();

        public AllProducts()
        {
            InitializeComponent();
            UpdateProducts();
        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            connection.Open();
            var command = new NpgsqlCommand("Select id, title, cost, article_number from product", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var product = new Product();
                product.Id = (int)reader["id"];
                product.Title = (string)reader["title"];
                product.Cost = (decimal)reader["cost"];
                product.Article = (string)reader["article_number"];
                products.Add(product);
            }
            reader.Close();
            connection.Close();

            UpdateProducts();
        }

        private void UpdateProducts()
        {
            productDataGrid.Rows.Clear();
            foreach(Product product in products)
            {
                int index = productDataGrid.Rows.Add(product.Id, product.Title, product.Cost, product.Article);
                productDataGrid.Rows[index].Tag = "OLD";
            }
        }

        private void productDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (productDataGrid.SelectedRows.Count > 0) 
            {
                if (productDataGrid.SelectedRows[0].Cells["IdColumn"].Value == null)
                {
                    MessageBox.Show("Выберите полностью заполненную строку");
                    return;
                }
                int selectedId = (int)productDataGrid.SelectedRows[0].Cells["IdColumn"].Value;
                productDataGrid.SelectedRows[0].Visible = false;
                Product productToRemove = products.Find(p => p.Id == selectedId);
                if (productToRemove != null)
                {
                    products.Remove(productToRemove);
                }

                connection.Open();
                var command = new NpgsqlCommand("DELETE FROM product WHERE id=@id", connection);
                command.Parameters.AddWithValue("id", selectedId);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsWithEmptyTag = productDataGrid.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Tag == null && !row.IsNewRow)
                .ToList();

            if (rowsWithEmptyTag.Count > 0)
            {
                foreach(DataGridViewRow row in rowsWithEmptyTag)
                {
                    Product product = new Product();
                    var titleVal = row.Cells["TitleColumn"].Value;
                    var costVal = row.Cells["CostColumn"].Value;
                    var articleVal = row.Cells["articleColumn"].Value;

                    if (!isValidData(titleVal, costVal, articleVal))
                    {
                        return;
                    }

                    product.Title = (string)titleVal;
                    product.Cost = Convert.ToDecimal(costVal);
                    product.Article = (string)articleVal;

                    connection.Open();
                    var command = new NpgsqlCommand("INSERT INTO product Values (nextval('product_seq'), @title, @cost, @article) RETURNING id", connection);
                    command.Parameters.AddWithValue("title", product.Title);
                    command.Parameters.AddWithValue("cost", product.Cost);
                    command.Parameters.AddWithValue("article", product.Article);
                    int insertedId = (int)command.ExecuteScalar();
                    connection.Close();

                    product.Id = insertedId;
                    products.Add(product);
                }
            }

            List<DataGridViewRow> updatedRows = productDataGrid.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Tag == "UPDATED")
                .ToList();

            if (updatedRows.Count > 0)
            {
                foreach(DataGridViewRow row in updatedRows)
                {
                    Product product = new Product();
                    var titleVal = row.Cells["TitleColumn"].Value;
                    var costVal = row.Cells["CostColumn"].Value;
                    var articleVal = row.Cells["articleColumn"].Value;

                    if (!isValidData(titleVal, costVal, articleVal))
                    {
                        return;
                    }

                    product.Id = (int)row.Cells["IdColumn"].Value;
                    product.Title = (string)titleVal;
                    product.Cost = Convert.ToDecimal(costVal);
                    product.Article = (string)articleVal;

                    connection.Open();
                    var command = new NpgsqlCommand("update product set title=@title, cost=@cost, article_number=@article where id = @id", connection);
                    command.Parameters.AddWithValue("id", product.Id);
                    command.Parameters.AddWithValue("title", product.Title);
                    command.Parameters.AddWithValue("cost", product.Cost);
                    command.Parameters.AddWithValue("article", product.Article);
                    command.ExecuteNonQuery();
                    connection.Close();

                    int index = products.FindIndex(p => p.Id == product.Id);

                    products[index] = product;
                }
            }

            UpdateProducts();
        }

        private void productDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = productDataGrid.Rows[e.RowIndex];
            if (row.Tag != null)
            {
                var titleVal = row.Cells["TitleColumn"].Value;
                var costVal = row.Cells["CostColumn"].Value;
                var articleVal = row.Cells["articleColumn"].Value;

                if (!isValidData(titleVal, costVal, articleVal))
                {
                    return;
                }

                row.Tag = "UPDATED";
            }
        }

        private bool isValidData(object titleVal, object costVal, object articleVal)
        {
            if (titleVal == null)
            {
                MessageBox.Show("Название не должно быть пустым");
                return false;
            }
            if (costVal == null)
            {
                MessageBox.Show("Стоимость не должна быть пустой");
                return false;
            }
            try
            {
                decimal cost = Convert.ToDecimal(costVal);
                if (cost < 0)
                {
                    MessageBox.Show("Стоимость должна быть положительным числом");
                    return false;
                }
            } catch
            {
                MessageBox.Show("Стоимость должна состоять только из цифр");
                return false;
            }
            if (articleVal == null)
            {
                MessageBox.Show("Артикул не должен быть пустым");
                return false;
            }
            return true;
        }

        private void graphBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ChartForm chartForm = new ChartForm();
            chartForm.products = products;
            chartForm.FormClosed += (s, args) => Close();
            chartForm.ShowDialog();
        }
    }
}
