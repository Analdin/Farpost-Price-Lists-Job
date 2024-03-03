namespace FarpostWorker
{
    partial class TriggersEdit
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
            this.conditionBtn = new System.Windows.Forms.Button();
            this.actionsBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // conditionBtn
            // 
            this.conditionBtn.Location = new System.Drawing.Point(12, 39);
            this.conditionBtn.Name = "conditionBtn";
            this.conditionBtn.Size = new System.Drawing.Size(121, 38);
            this.conditionBtn.TabIndex = 0;
            this.conditionBtn.Text = "Условия";
            this.conditionBtn.UseVisualStyleBackColor = true;
            // 
            // actionsBtn
            // 
            this.actionsBtn.Location = new System.Drawing.Point(139, 39);
            this.actionsBtn.Name = "actionsBtn";
            this.actionsBtn.Size = new System.Drawing.Size(121, 38);
            this.actionsBtn.TabIndex = 1;
            this.actionsBtn.Text = "Действия";
            this.actionsBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 110);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(121, 38);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(139, 110);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(121, 38);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(248, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // TriggersEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 165);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.actionsBtn);
            this.Controls.Add(this.conditionBtn);
            this.Name = "TriggersEdit";
            this.Text = "Редактирование триггеров";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button conditionBtn;
        private System.Windows.Forms.Button actionsBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}