namespace Shuart_TheBoxOffice
{
    partial class BuyTickets
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
            this.comboMovieSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTickets = new System.Windows.Forms.NumericUpDown();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnCountSales = new System.Windows.Forms.Button();
            this.txtAvailable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMovieSelect
            // 
            this.comboMovieSelect.FormattingEnabled = true;
            this.comboMovieSelect.Location = new System.Drawing.Point(15, 29);
            this.comboMovieSelect.Name = "comboMovieSelect";
            this.comboMovieSelect.Size = new System.Drawing.Size(271, 24);
            this.comboMovieSelect.TabIndex = 0;
            this.comboMovieSelect.SelectedIndexChanged += new System.EventHandler(this.comboMovieSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Movie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Tickets?:";
            // 
            // numTickets
            // 
            this.numTickets.Location = new System.Drawing.Point(354, 29);
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(74, 22);
            this.numTickets.TabIndex = 3;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(555, 20);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(125, 33);
            this.btnBuy.TabIndex = 4;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnCountSales
            // 
            this.btnCountSales.Location = new System.Drawing.Point(511, 63);
            this.btnCountSales.Name = "btnCountSales";
            this.btnCountSales.Size = new System.Drawing.Size(189, 34);
            this.btnCountSales.TabIndex = 5;
            this.btnCountSales.Text = "Count Sales (Staff Only)";
            this.btnCountSales.UseVisualStyleBackColor = true;
            this.btnCountSales.Click += new System.EventHandler(this.btnCountSales_Click);
            // 
            // txtAvailable
            // 
            this.txtAvailable.AutoSize = true;
            this.txtAvailable.Location = new System.Drawing.Point(434, 32);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(32, 17);
            this.txtAvailable.TabIndex = 6;
            this.txtAvailable.Text = "/ 30";
            // 
            // BuyTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 109);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.btnCountSales);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.numTickets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMovieSelect);
            this.Name = "BuyTickets";
            this.Text = "The Box Office: All the perks of \"Going Out\" but none of the socializing";
            this.Load += new System.EventHandler(this.BuyTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMovieSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTickets;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnCountSales;
        private System.Windows.Forms.Label txtAvailable;
    }
}