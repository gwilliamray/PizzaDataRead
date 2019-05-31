namespace ReadPizzaInvoice
{
    partial class Form1
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
            this.lstAllInvoices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstAllInvoices
            // 
            this.lstAllInvoices.FormattingEnabled = true;
            this.lstAllInvoices.ItemHeight = 20;
            this.lstAllInvoices.Location = new System.Drawing.Point(44, 49);
            this.lstAllInvoices.Name = "lstAllInvoices";
            this.lstAllInvoices.ScrollAlwaysVisible = true;
            this.lstAllInvoices.Size = new System.Drawing.Size(822, 724);
            this.lstAllInvoices.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 826);
            this.Controls.Add(this.lstAllInvoices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllInvoices;
    }
}

