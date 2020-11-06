namespace CircusTreinOpdracht
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
            this.tbTrain = new System.Windows.Forms.TextBox();
            this.bnSort = new System.Windows.Forms.Button();
            this.lbWagon = new System.Windows.Forms.ListBox();
            this.bnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTrain
            // 
            this.tbTrain.Location = new System.Drawing.Point(293, 26);
            this.tbTrain.Multiline = true;
            this.tbTrain.Name = "tbTrain";
            this.tbTrain.Size = new System.Drawing.Size(218, 248);
            this.tbTrain.TabIndex = 5;
            // 
            // bnSort
            // 
            this.bnSort.Location = new System.Drawing.Point(171, 197);
            this.bnSort.Margin = new System.Windows.Forms.Padding(2);
            this.bnSort.Name = "bnSort";
            this.bnSort.Size = new System.Drawing.Size(101, 40);
            this.bnSort.TabIndex = 7;
            this.bnSort.Text = "Sort";
            this.bnSort.UseVisualStyleBackColor = true;
            this.bnSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbWagon
            // 
            this.lbWagon.FormattingEnabled = true;
            this.lbWagon.Location = new System.Drawing.Point(51, 259);
            this.lbWagon.Margin = new System.Windows.Forms.Padding(2);
            this.lbWagon.Name = "lbWagon";
            this.lbWagon.Size = new System.Drawing.Size(221, 69);
            this.lbWagon.TabIndex = 8;
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(51, 197);
            this.bnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(101, 40);
            this.bnAdd.TabIndex = 0;
            this.bnAdd.Text = "Add";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 339);
            this.Controls.Add(this.lbWagon);
            this.Controls.Add(this.bnSort);
            this.Controls.Add(this.tbTrain);
            this.Controls.Add(this.bnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTrain;
        private System.Windows.Forms.Button bnSort;
        private System.Windows.Forms.ListBox lbWagon;
        private System.Windows.Forms.Button bnAdd;
    }
}

