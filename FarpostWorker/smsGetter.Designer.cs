namespace FarpostWorker
{
    partial class smsGetter
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
            this.smsGet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendSms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smsGet
            // 
            this.smsGet.Location = new System.Drawing.Point(12, 56);
            this.smsGet.Name = "smsGet";
            this.smsGet.Size = new System.Drawing.Size(107, 20);
            this.smsGet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите смс";
            // 
            // sendSms
            // 
            this.sendSms.Location = new System.Drawing.Point(15, 87);
            this.sendSms.Name = "sendSms";
            this.sendSms.Size = new System.Drawing.Size(105, 36);
            this.sendSms.TabIndex = 2;
            this.sendSms.Text = "OK";
            this.sendSms.UseVisualStyleBackColor = true;
            this.sendSms.Click += new System.EventHandler(this.sendSms_Click);
            // 
            // smsGetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 135);
            this.Controls.Add(this.sendSms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.smsGet);
            this.Name = "smsGetter";
            this.Text = "smsGetter";
            this.Load += new System.EventHandler(this.smsGetter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox smsGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendSms;
    }
}