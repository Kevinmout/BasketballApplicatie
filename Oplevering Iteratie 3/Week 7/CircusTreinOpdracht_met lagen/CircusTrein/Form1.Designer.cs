namespace CircusTrein
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnSort = new System.Windows.Forms.Button();
            this.lbWagon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bnSort
            // 
            this.bnSort.Location = new System.Drawing.Point(206, 270);
            this.bnSort.Name = "bnSort";
            this.bnSort.Size = new System.Drawing.Size(112, 34);
            this.bnSort.TabIndex = 0;
            this.bnSort.Text = "Sort";
            this.bnSort.UseVisualStyleBackColor = true;
            this.bnSort.Click += new System.EventHandler(this.bnSort_Click);
            // 
            // lbWagon
            // 
            this.lbWagon.FormattingEnabled = true;
            this.lbWagon.ItemHeight = 25;
            this.lbWagon.Location = new System.Drawing.Point(515, 126);
            this.lbWagon.Name = "lbWagon";
            this.lbWagon.Size = new System.Drawing.Size(180, 129);
            this.lbWagon.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 484);
            this.Controls.Add(this.lbWagon);
            this.Controls.Add(this.bnSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnSort;
        private System.Windows.Forms.ListBox lbWagon;
    }
}

