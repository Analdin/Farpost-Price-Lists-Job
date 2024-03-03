namespace FarpostWorker
{
    partial class AddPriceLists
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pricesNamesDataView = new System.Windows.Forms.DataGridView();
            this.pricesList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectTriggers = new System.Windows.Forms.Button();
            this.saveTriggers = new System.Windows.Forms.Button();
            this.addPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pricesNamesDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название проекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id прайс-листов";
            // 
            // pricesNamesDataView
            // 
            this.pricesNamesDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricesNamesDataView.Location = new System.Drawing.Point(15, 41);
            this.pricesNamesDataView.Name = "pricesNamesDataView";
            this.pricesNamesDataView.Size = new System.Drawing.Size(433, 36);
            this.pricesNamesDataView.TabIndex = 2;
            this.pricesNamesDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pricesNamesDataView_CellContentClick);
            // 
            // pricesList
            // 
            this.pricesList.FormattingEnabled = true;
            this.pricesList.Location = new System.Drawing.Point(17, 117);
            this.pricesList.Name = "pricesList";
            this.pricesList.Size = new System.Drawing.Size(201, 186);
            this.pricesList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Триггеры";
            // 
            // selectTriggers
            // 
            this.selectTriggers.Location = new System.Drawing.Point(16, 344);
            this.selectTriggers.Name = "selectTriggers";
            this.selectTriggers.Size = new System.Drawing.Size(121, 38);
            this.selectTriggers.TabIndex = 5;
            this.selectTriggers.Text = "Выбрать триггеры";
            this.selectTriggers.UseVisualStyleBackColor = true;
            // 
            // saveTriggers
            // 
            this.saveTriggers.Location = new System.Drawing.Point(180, 465);
            this.saveTriggers.Name = "saveTriggers";
            this.saveTriggers.Size = new System.Drawing.Size(121, 38);
            this.saveTriggers.TabIndex = 6;
            this.saveTriggers.Text = "Сохранить";
            this.saveTriggers.UseVisualStyleBackColor = true;
            // 
            // addPrice
            // 
            this.addPrice.Location = new System.Drawing.Point(224, 117);
            this.addPrice.Name = "addPrice";
            this.addPrice.Size = new System.Drawing.Size(121, 38);
            this.addPrice.TabIndex = 7;
            this.addPrice.Text = "Добавить прайс-лист";
            this.addPrice.UseVisualStyleBackColor = true;
            this.addPrice.Click += new System.EventHandler(this.addPrice_Click);
            // 
            // AddPriceLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 515);
            this.Controls.Add(this.addPrice);
            this.Controls.Add(this.saveTriggers);
            this.Controls.Add(this.selectTriggers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricesList);
            this.Controls.Add(this.pricesNamesDataView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPriceLists";
            this.Text = "Добавление прайс-листа";
            ((System.ComponentModel.ISupportInitialize)(this.pricesNamesDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView pricesNamesDataView;
        private System.Windows.Forms.ListBox pricesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectTriggers;
        private System.Windows.Forms.Button saveTriggers;
        private System.Windows.Forms.Button addPrice;
    }
}