namespace Shuart_TheBoxOffice
{
    partial class Report
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
            this.txtTotalSales = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.comboTheatreSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalTickets = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Sales:";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.AutoSize = true;
            this.txtTotalSales.Location = new System.Drawing.Point(113, 9);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(43, 17);
            this.txtTotalSales.TabIndex = 1;
            this.txtTotalSales.Text = "count";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDetails);
            this.panel1.Controls.Add(this.comboTheatreSelect);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 305);
            this.panel1.TabIndex = 2;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(17, 44);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(597, 250);
            this.txtDetails.TabIndex = 3;
            // 
            // comboTheatreSelect
            // 
            this.comboTheatreSelect.FormattingEnabled = true;
            this.comboTheatreSelect.Location = new System.Drawing.Point(240, 14);
            this.comboTheatreSelect.Name = "comboTheatreSelect";
            this.comboTheatreSelect.Size = new System.Drawing.Size(211, 24);
            this.comboTheatreSelect.TabIndex = 2;
            this.comboTheatreSelect.SelectedIndexChanged += new System.EventHandler(this.comboTheatreSelect_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Theatre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Details:";
            // 
            // txtTotalTickets
            // 
            this.txtTotalTickets.AutoSize = true;
            this.txtTotalTickets.Location = new System.Drawing.Point(125, 26);
            this.txtTotalTickets.Name = "txtTotalTickets";
            this.txtTotalTickets.Size = new System.Drawing.Size(43, 17);
            this.txtTotalTickets.TabIndex = 4;
            this.txtTotalTickets.Text = "count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Tickets:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(497, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close for the day...";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 432);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTotalTickets);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "The Box Office: All the perks of \"Going Out\" but none of the socializing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTotalSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.ComboBox comboTheatreSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTotalTickets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
    }
}