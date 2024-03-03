namespace FarpostWorker
{
    partial class ConditionsEdit
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
            this.ComboActionChoose = new System.Windows.Forms.ComboBox();
            this.CheckListDays = new System.Windows.Forms.CheckedListBox();
            this.SaveListBtn = new System.Windows.Forms.Button();
            this.CancelListBtn = new System.Windows.Forms.Button();
            this.PickDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ComboActionChoose
            // 
            this.ComboActionChoose.FormattingEnabled = true;
            this.ComboActionChoose.Items.AddRange(new object[] {
            "Запуск по времени",
            "Запуск по дням"});
            this.ComboActionChoose.Location = new System.Drawing.Point(12, 12);
            this.ComboActionChoose.Name = "ComboActionChoose";
            this.ComboActionChoose.Size = new System.Drawing.Size(412, 21);
            this.ComboActionChoose.TabIndex = 0;
            // 
            // CheckListDays
            // 
            this.CheckListDays.FormattingEnabled = true;
            this.CheckListDays.HorizontalScrollbar = true;
            this.CheckListDays.Location = new System.Drawing.Point(12, 39);
            this.CheckListDays.Name = "CheckListDays";
            this.CheckListDays.Size = new System.Drawing.Size(412, 289);
            this.CheckListDays.TabIndex = 1;
            // 
            // SaveListBtn
            // 
            this.SaveListBtn.Location = new System.Drawing.Point(105, 334);
            this.SaveListBtn.Name = "SaveListBtn";
            this.SaveListBtn.Size = new System.Drawing.Size(110, 39);
            this.SaveListBtn.TabIndex = 2;
            this.SaveListBtn.Text = "Сохранить";
            this.SaveListBtn.UseVisualStyleBackColor = true;
            // 
            // CancelListBtn
            // 
            this.CancelListBtn.Location = new System.Drawing.Point(221, 334);
            this.CancelListBtn.Name = "CancelListBtn";
            this.CancelListBtn.Size = new System.Drawing.Size(110, 39);
            this.CancelListBtn.TabIndex = 3;
            this.CancelListBtn.Text = "Отменить";
            this.CancelListBtn.UseVisualStyleBackColor = true;
            // 
            // PickDateTime
            // 
            this.PickDateTime.Location = new System.Drawing.Point(150, 48);
            this.PickDateTime.Name = "PickDateTime";
            this.PickDateTime.Size = new System.Drawing.Size(200, 20);
            this.PickDateTime.TabIndex = 4;
            // 
            // ConditionsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 383);
            this.Controls.Add(this.PickDateTime);
            this.Controls.Add(this.CancelListBtn);
            this.Controls.Add(this.SaveListBtn);
            this.Controls.Add(this.CheckListDays);
            this.Controls.Add(this.ComboActionChoose);
            this.Name = "ConditionsEdit";
            this.Text = "Условия";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboActionChoose;
        private System.Windows.Forms.Button SaveListBtn;
        private System.Windows.Forms.Button CancelListBtn;
        private System.Windows.Forms.DateTimePicker PickDateTime;
        public System.Windows.Forms.CheckedListBox CheckListDays;
    }
}