namespace ProductsDiagram
{
    partial class AllProducts
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoLabel = new System.Windows.Forms.Label();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBtn = new System.Windows.Forms.Button();
            this.graphBtn = new System.Windows.Forms.Button();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(300, 25);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Форма вывода всех продуктов";
            // 
            // productDataGrid
            // 
            this.productDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.productDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.productDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.titleColumn,
            this.CostColumn,
            this.articleColumn});
            this.productDataGrid.Location = new System.Drawing.Point(12, 139);
            this.productDataGrid.MaximumSize = new System.Drawing.Size(883, 437);
            this.productDataGrid.MinimumSize = new System.Drawing.Size(883, 437);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.RowHeadersWidth = 51;
            this.productDataGrid.RowTemplate.Height = 24;
            this.productDataGrid.Size = new System.Drawing.Size(883, 437);
            this.productDataGrid.TabIndex = 1;
            this.productDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGrid_CellEndEdit);
            this.productDataGrid.SelectionChanged += new System.EventHandler(this.productDataGrid_SelectionChanged);
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.infoLabel2.Location = new System.Drawing.Point(14, 34);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(562, 36);
            this.infoLabel2.TabIndex = 2;
            this.infoLabel2.Text = "Вы можете обновить данные после изменения с помощью кнопки \"Сохранить\"\r\nДля удале" +
    "ния строки нажмите на пространство слева от неё";
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Номер";
            this.IdColumn.MinimumWidth = 6;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 125;
            // 
            // titleColumn
            // 
            this.titleColumn.HeaderText = "Название";
            this.titleColumn.MaxInputLength = 150;
            this.titleColumn.MinimumWidth = 6;
            this.titleColumn.Name = "titleColumn";
            this.titleColumn.Width = 250;
            // 
            // CostColumn
            // 
            this.CostColumn.HeaderText = "Цена";
            this.CostColumn.MaxInputLength = 12;
            this.CostColumn.MinimumWidth = 6;
            this.CostColumn.Name = "CostColumn";
            this.CostColumn.Width = 175;
            // 
            // articleColumn
            // 
            this.articleColumn.HeaderText = "Артикул";
            this.articleColumn.MaxInputLength = 15;
            this.articleColumn.MinimumWidth = 6;
            this.articleColumn.Name = "articleColumn";
            this.articleColumn.Width = 175;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveBtn.Location = new System.Drawing.Point(12, 90);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(232, 43);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить изменения";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // graphBtn
            // 
            this.graphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.graphBtn.Location = new System.Drawing.Point(255, 90);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(404, 43);
            this.graphBtn.TabIndex = 4;
            this.graphBtn.Text = "Построить график по ценовым категориям";
            this.graphBtn.UseVisualStyleBackColor = true;
            this.graphBtn.Click += new System.EventHandler(this.graphBtn_Click);
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // AllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 597);
            this.Controls.Add(this.graphBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.infoLabel);
            this.Name = "AllProducts";
            this.Text = "Все продукты";
            this.Load += new System.EventHandler(this.AllProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleColumn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button graphBtn;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
    }
}

