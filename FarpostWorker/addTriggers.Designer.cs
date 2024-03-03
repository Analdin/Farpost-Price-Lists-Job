namespace FarpostWorker
{
    partial class addTriggers
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
            this.addTriggersBtn = new System.Windows.Forms.Button();
            this.deleteTriggersBtn = new System.Windows.Forms.Button();
            this.editTriggersBtn = new System.Windows.Forms.Button();
            this.AddedTriggersList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // addTriggersBtn
            // 
            this.addTriggersBtn.Location = new System.Drawing.Point(471, 12);
            this.addTriggersBtn.Name = "addTriggersBtn";
            this.addTriggersBtn.Size = new System.Drawing.Size(117, 43);
            this.addTriggersBtn.TabIndex = 1;
            this.addTriggersBtn.Text = "Добавить";
            this.addTriggersBtn.UseVisualStyleBackColor = true;
            this.addTriggersBtn.Click += new System.EventHandler(this.addTriggersBtn_Click);
            // 
            // deleteTriggersBtn
            // 
            this.deleteTriggersBtn.Location = new System.Drawing.Point(471, 61);
            this.deleteTriggersBtn.Name = "deleteTriggersBtn";
            this.deleteTriggersBtn.Size = new System.Drawing.Size(117, 43);
            this.deleteTriggersBtn.TabIndex = 2;
            this.deleteTriggersBtn.Text = "Удалить";
            this.deleteTriggersBtn.UseVisualStyleBackColor = true;
            // 
            // editTriggersBtn
            // 
            this.editTriggersBtn.Location = new System.Drawing.Point(471, 110);
            this.editTriggersBtn.Name = "editTriggersBtn";
            this.editTriggersBtn.Size = new System.Drawing.Size(117, 43);
            this.editTriggersBtn.TabIndex = 3;
            this.editTriggersBtn.Text = "Редактировать";
            this.editTriggersBtn.UseVisualStyleBackColor = true;
            //this.editTriggersBtn.Click += new System.EventHandler(this.editTriggersBtn_Click);
            // 
            // AddedTriggersList
            // 
            this.AddedTriggersList.FormattingEnabled = true;
            this.AddedTriggersList.Location = new System.Drawing.Point(12, 10);
            this.AddedTriggersList.Name = "AddedTriggersList";
            this.AddedTriggersList.Size = new System.Drawing.Size(453, 424);
            this.AddedTriggersList.TabIndex = 4;
            this.AddedTriggersList.SelectedIndexChanged += new System.EventHandler(this.AddedTriggersList_SelectedIndexChanged);
            // 
            // addTriggers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.AddedTriggersList);
            this.Controls.Add(this.editTriggersBtn);
            this.Controls.Add(this.deleteTriggersBtn);
            this.Controls.Add(this.addTriggersBtn);
            this.Name = "addTriggers";
            this.Text = "Список триггеров";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addTriggersBtn;
        private System.Windows.Forms.Button deleteTriggersBtn;
        private System.Windows.Forms.Button editTriggersBtn;
        private System.Windows.Forms.CheckedListBox AddedTriggersList;
    }
}