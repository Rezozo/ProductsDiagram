namespace ProductsDiagram
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.productChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.infoLabel = new System.Windows.Forms.Label();
            this.graphBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.costBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).BeginInit();
            this.SuspendLayout();
            // 
            // productChart
            // 
            chartArea2.Name = "ChartArea1";
            this.productChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.productChart.Legends.Add(legend2);
            this.productChart.Location = new System.Drawing.Point(12, 165);
            this.productChart.Name = "productChart";
            this.productChart.Size = new System.Drawing.Size(883, 391);
            this.productChart.TabIndex = 0;
            this.productChart.Text = "chart1";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.infoLabel.Location = new System.Drawing.Point(7, 27);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(497, 25);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Укажите ценовой диапазон для постоения графика";
            // 
            // graphBtn
            // 
            this.graphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.graphBtn.Location = new System.Drawing.Point(12, 116);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(404, 43);
            this.graphBtn.TabIndex = 5;
            this.graphBtn.Text = "Построить график по ценовым категориям";
            this.graphBtn.UseVisualStyleBackColor = true;
            this.graphBtn.Click += new System.EventHandler(this.graphBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backBtn.Location = new System.Drawing.Point(754, 20);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(141, 43);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "<- Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // costBox
            // 
            this.costBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.costBox.FormattingEnabled = true;
            this.costBox.Items.AddRange(new object[] {
            "100",
            "500",
            "1000",
            "2000",
            "5000",
            "10000"});
            this.costBox.Location = new System.Drawing.Point(12, 66);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(346, 28);
            this.costBox.TabIndex = 7;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 597);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.graphBtn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.productChart);
            this.MaximumSize = new System.Drawing.Size(925, 644);
            this.MinimumSize = new System.Drawing.Size(925, 644);
            this.Name = "ChartForm";
            this.Text = "Распределение товаров";
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart productChart;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button graphBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox costBox;
    }
}