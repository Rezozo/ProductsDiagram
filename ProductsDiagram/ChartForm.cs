using ProductsDiagram.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProductsDiagram
{
    public partial class ChartForm : Form
    {
        private List<Product> _products = new List<Product>();
        public List<Product> products
        {
            get { return _products; }
            set { _products = value; }
        }

        public ChartForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide(); 
            AllProducts chartForm = new AllProducts();
            chartForm.FormClosed += (s, args) => Close();
            chartForm.ShowDialog();
            Hide();
        }

        private void graphBtn_Click(object sender, EventArgs e)
        {
            if (costBox.Text == "")
            {
                MessageBox.Show("Сначала укажите диапазон цен");
                return;
            }
            productChart.ChartAreas.Clear();
            productChart.Series.Clear();

            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Ценовые категории";
            chartArea.AxisY.Title = "Количество продуктов";
            productChart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Name = "Ценовые категории";

            int categorySize = Convert.ToInt32(costBox.Text);
            int maxPrice = Convert.ToInt32(_products.Cast<Product>().Max(p => p.Cost));
            int numberOfCategories = (maxPrice / categorySize) + 1;

            int[] categoryCounts = new int[numberOfCategories];
            foreach (Product product in products)
            {
                int categoryIndex = (int)Math.Ceiling((double)product.Cost / categorySize);
                categoryCounts[categoryIndex - 1]++;
            }

            for (int i = 0; i < numberOfCategories; i++)
            {
                series.Points.AddXY($"Категория {i + 1}", categoryCounts[i]);
            }

            productChart.Series.Add(series);
            productChart.ChartAreas[0].AxisY.Interval = 1;
        }
    }
}
