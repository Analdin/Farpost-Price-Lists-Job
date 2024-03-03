namespace FarpostWorker
{
    partial class AllPrices
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
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.RemoveProjectBtn = new System.Windows.Forms.Button();
            this.SetTriggersBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.allPricesOn = new System.Windows.Forms.CheckBox();
            this.allPriceOff = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProjectBtn.Location = new System.Drawing.Point(12, 12);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(154, 53);
            this.addProjectBtn.TabIndex = 0;
            this.addProjectBtn.Text = "Добавить проект";
            this.addProjectBtn.UseVisualStyleBackColor = true;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // RemoveProjectBtn
            // 
            this.RemoveProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveProjectBtn.Location = new System.Drawing.Point(172, 12);
            this.RemoveProjectBtn.Name = "RemoveProjectBtn";
            this.RemoveProjectBtn.Size = new System.Drawing.Size(154, 53);
            this.RemoveProjectBtn.TabIndex = 1;
            this.RemoveProjectBtn.Text = "Удалить проект";
            this.RemoveProjectBtn.UseVisualStyleBackColor = true;
            // 
            // SetTriggersBtn
            // 
            this.SetTriggersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetTriggersBtn.Location = new System.Drawing.Point(332, 12);
            this.SetTriggersBtn.Name = "SetTriggersBtn";
            this.SetTriggersBtn.Size = new System.Drawing.Size(154, 53);
            this.SetTriggersBtn.TabIndex = 2;
            this.SetTriggersBtn.Text = "Настройка триггеров";
            this.SetTriggersBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название проекта";
            // 
            // allPricesOn
            // 
            this.allPricesOn.AutoSize = true;
            this.allPricesOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allPricesOn.Location = new System.Drawing.Point(16, 119);
            this.allPricesOn.Name = "allPricesOn";
            this.allPricesOn.Size = new System.Drawing.Size(369, 20);
            this.allPricesOn.TabIndex = 4;
            this.allPricesOn.Text = "Все прайсы Владивостока - включение ставки 8 руб ";
            this.allPricesOn.UseVisualStyleBackColor = true;
            // 
            // allPriceOff
            // 
            this.allPriceOff.AutoSize = true;
            this.allPriceOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allPriceOff.Location = new System.Drawing.Point(16, 148);
            this.allPriceOff.Name = "allPriceOff";
            this.allPriceOff.Size = new System.Drawing.Size(390, 20);
            this.allPriceOff.TabIndex = 5;
            this.allPriceOff.Text = "Все прайсы Владивостока - отключение прайсов с 21.00";
            this.allPriceOff.UseVisualStyleBackColor = true;
            // 
            // AllPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allPriceOff);
            this.Controls.Add(this.allPricesOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetTriggersBtn);
            this.Controls.Add(this.RemoveProjectBtn);
            this.Controls.Add(this.addProjectBtn);
            this.Name = "AllPrices";
            this.Text = "Управление ставками прайс-листов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProjectBtn;
        private System.Windows.Forms.Button RemoveProjectBtn;
        private System.Windows.Forms.Button SetTriggersBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox allPricesOn;
        private System.Windows.Forms.CheckBox allPriceOff;
    }
}