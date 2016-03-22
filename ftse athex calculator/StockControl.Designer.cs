namespace ftse_athex_calculator
{
    partial class StockControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbText = new System.Windows.Forms.Label();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.tbSnapshot = new System.Windows.Forms.TextBox();
            this.tbIndexValueDiff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(3, 3);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(0, 13);
            this.lbText.TabIndex = 0;
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(54, 0);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.ReadOnly = true;
            this.tbCurrent.Size = new System.Drawing.Size(63, 20);
            this.tbCurrent.TabIndex = 1;
            this.tbCurrent.TextChanged += new System.EventHandler(this.tbCurrent_TextChanged);
            // 
            // tbSnapshot
            // 
            this.tbSnapshot.Location = new System.Drawing.Point(123, 0);
            this.tbSnapshot.Name = "tbSnapshot";
            this.tbSnapshot.Size = new System.Drawing.Size(63, 20);
            this.tbSnapshot.TabIndex = 2;
            this.tbSnapshot.TextChanged += new System.EventHandler(this.tbSnapshot_TextChanged);
            // 
            // tbIndexValueDiff
            // 
            this.tbIndexValueDiff.Location = new System.Drawing.Point(192, 0);
            this.tbIndexValueDiff.Name = "tbIndexValueDiff";
            this.tbIndexValueDiff.Size = new System.Drawing.Size(48, 20);
            this.tbIndexValueDiff.TabIndex = 3;
            // 
            // StockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbIndexValueDiff);
            this.Controls.Add(this.tbSnapshot);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.lbText);
            this.Name = "StockControl";
            this.Size = new System.Drawing.Size(315, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.TextBox tbSnapshot;
        private System.Windows.Forms.TextBox tbIndexValueDiff;
    }
}
