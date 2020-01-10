namespace Invoice_Application
{
    partial class frmInvoice
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
            this.lblPriceSub = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblDisPercent = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDisAmount = new System.Windows.Forms.Label();
            this.txtPriceSub = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisPercentResult = new System.Windows.Forms.Label();
            this.lblDisAmountResult = new System.Windows.Forms.Label();
            this.lblTotalResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPriceSub
            // 
            this.lblPriceSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceSub.Location = new System.Drawing.Point(26, 37);
            this.lblPriceSub.Name = "lblPriceSub";
            this.lblPriceSub.Size = new System.Drawing.Size(167, 50);
            this.lblPriceSub.TabIndex = 0;
            this.lblPriceSub.Text = "PRICE (SUBTOTAL)";
            this.lblPriceSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Image = global::Invoice_Application.Properties.Resources.Project;
            this.picImage.Location = new System.Drawing.Point(512, 42);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(167, 174);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // lblDisPercent
            // 
            this.lblDisPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisPercent.Location = new System.Drawing.Point(26, 86);
            this.lblDisPercent.Name = "lblDisPercent";
            this.lblDisPercent.Size = new System.Drawing.Size(167, 50);
            this.lblDisPercent.TabIndex = 2;
            this.lblDisPercent.Text = "DISCOUNT PERCENT";
            this.lblDisPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(26, 181);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(167, 50);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "TOTAL";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisAmount
            // 
            this.lblDisAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisAmount.Location = new System.Drawing.Point(26, 132);
            this.lblDisAmount.Name = "lblDisAmount";
            this.lblDisAmount.Size = new System.Drawing.Size(167, 50);
            this.lblDisAmount.TabIndex = 3;
            this.lblDisAmount.Text = "DISCOUNT AMOUNT";
            this.lblDisAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPriceSub
            // 
            this.txtPriceSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceSub.Location = new System.Drawing.Point(199, 52);
            this.txtPriceSub.Name = "txtPriceSub";
            this.txtPriceSub.Size = new System.Drawing.Size(100, 22);
            this.txtPriceSub.TabIndex = 5;
            this.txtPriceSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPriceSub.TextChanged += new System.EventHandler(this.txtPriceSub_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(372, 50);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 24);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(372, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 24);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(372, 145);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 24);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisPercentResult
            // 
            this.lblDisPercentResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisPercentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisPercentResult.Location = new System.Drawing.Point(199, 99);
            this.lblDisPercentResult.Name = "lblDisPercentResult";
            this.lblDisPercentResult.Size = new System.Drawing.Size(100, 22);
            this.lblDisPercentResult.TabIndex = 12;
            this.lblDisPercentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisAmountResult
            // 
            this.lblDisAmountResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisAmountResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisAmountResult.Location = new System.Drawing.Point(199, 150);
            this.lblDisAmountResult.Name = "lblDisAmountResult";
            this.lblDisAmountResult.Size = new System.Drawing.Size(100, 22);
            this.lblDisAmountResult.TabIndex = 13;
            this.lblDisAmountResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResult.Location = new System.Drawing.Point(199, 193);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(100, 22);
            this.lblTotalResult.TabIndex = 14;
            this.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 268);
            this.Controls.Add(this.lblTotalResult);
            this.Controls.Add(this.lblDisAmountResult);
            this.Controls.Add(this.lblDisPercentResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPriceSub);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDisAmount);
            this.Controls.Add(this.lblDisPercent);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblPriceSub);
            this.Name = "frmInvoice";
            this.Text = "INVOICE TOTAL ";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPriceSub;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblDisPercent;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDisAmount;
        private System.Windows.Forms.TextBox txtPriceSub;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisPercentResult;
        private System.Windows.Forms.Label lblDisAmountResult;
        private System.Windows.Forms.Label lblTotalResult;
    }
}

