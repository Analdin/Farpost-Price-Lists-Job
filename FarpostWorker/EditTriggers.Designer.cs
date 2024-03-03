namespace FarpostWorker
{
    partial class EditTriggers
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addTgBtn = new System.Windows.Forms.Button();
            this.delBtntg = new System.Windows.Forms.Button();
            this.editTgBtn = new System.Windows.Forms.Button();
            this.ActionsBtntg = new System.Windows.Forms.Button();
            this.conditionsTg = new System.Windows.Forms.Button();
            this.conditionsOn = new System.Windows.Forms.CheckBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 20);
            this.textBox1.TabIndex = 0;
            // 
            // addTgBtn
            // 
            this.addTgBtn.Location = new System.Drawing.Point(666, 107);
            this.addTgBtn.Name = "addTgBtn";
            this.addTgBtn.Size = new System.Drawing.Size(122, 47);
            this.addTgBtn.TabIndex = 1;
            this.addTgBtn.Text = "Добавить";
            this.addTgBtn.UseVisualStyleBackColor = true;
            // 
            // delBtntg
            // 
            this.delBtntg.Location = new System.Drawing.Point(666, 160);
            this.delBtntg.Name = "delBtntg";
            this.delBtntg.Size = new System.Drawing.Size(122, 47);
            this.delBtntg.TabIndex = 2;
            this.delBtntg.Text = "Удалить";
            this.delBtntg.UseVisualStyleBackColor = true;
            // 
            // editTgBtn
            // 
            this.editTgBtn.Location = new System.Drawing.Point(666, 213);
            this.editTgBtn.Name = "editTgBtn";
            this.editTgBtn.Size = new System.Drawing.Size(122, 47);
            this.editTgBtn.TabIndex = 3;
            this.editTgBtn.Text = "Редактировать";
            this.editTgBtn.UseVisualStyleBackColor = true;
            // 
            // ActionsBtntg
            // 
            this.ActionsBtntg.Location = new System.Drawing.Point(140, 38);
            this.ActionsBtntg.Name = "ActionsBtntg";
            this.ActionsBtntg.Size = new System.Drawing.Size(122, 47);
            this.ActionsBtntg.TabIndex = 4;
            this.ActionsBtntg.Text = "Действия";
            this.ActionsBtntg.UseVisualStyleBackColor = true;
            // 
            // conditionsTg
            // 
            this.conditionsTg.Location = new System.Drawing.Point(12, 38);
            this.conditionsTg.Name = "conditionsTg";
            this.conditionsTg.Size = new System.Drawing.Size(122, 47);
            this.conditionsTg.TabIndex = 5;
            this.conditionsTg.Text = "Условия";
            this.conditionsTg.UseVisualStyleBackColor = true;
            // 
            // conditionsOn
            // 
            this.conditionsOn.AutoSize = true;
            this.conditionsOn.Location = new System.Drawing.Point(12, 91);
            this.conditionsOn.Name = "conditionsOn";
            this.conditionsOn.Size = new System.Drawing.Size(211, 17);
            this.conditionsOn.TabIndex = 6;
            this.conditionsOn.Text = "Включить ставки в8:00 в будние дни";
            this.conditionsOn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(421, 391);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(122, 47);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(293, 391);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(122, 47);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // EditTriggers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.conditionsOn);
            this.Controls.Add(this.conditionsTg);
            this.Controls.Add(this.ActionsBtntg);
            this.Controls.Add(this.editTgBtn);
            this.Controls.Add(this.delBtntg);
            this.Controls.Add(this.addTgBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "EditTriggers";
            this.Text = "EditTriggers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addTgBtn;
        private System.Windows.Forms.Button delBtntg;
        private System.Windows.Forms.Button editTgBtn;
        private System.Windows.Forms.Button ActionsBtntg;
        private System.Windows.Forms.Button conditionsTg;
        private System.Windows.Forms.CheckBox conditionsOn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}