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
            this.bnAdd = new System.Windows.Forms.Button();
            this.rbKlein = new System.Windows.Forms.RadioButton();
            this.rbMiddelgroot = new System.Windows.Forms.RadioButton();
            this.rbGroot = new System.Windows.Forms.RadioButton();
            this.cbCarnivoor = new System.Windows.Forms.CheckBox();
            this.tbTrain = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bnSort = new System.Windows.Forms.Button();
            this.lbWagon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(51, 197);
            this.bnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(101, 40);
            this.bnAdd.TabIndex = 0;
            this.bnAdd.Text = "Add";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // rbKlein
            // 
            this.rbKlein.AutoSize = true;
            this.rbKlein.Location = new System.Drawing.Point(51, 101);
            this.rbKlein.Name = "rbKlein";
            this.rbKlein.Size = new System.Drawing.Size(48, 17);
            this.rbKlein.TabIndex = 1;
            this.rbKlein.TabStop = true;
            this.rbKlein.Tag = "1";
            this.rbKlein.Text = "Klein";
            this.rbKlein.UseVisualStyleBackColor = true;
            // 
            // rbMiddelgroot
            // 
            this.rbMiddelgroot.AutoSize = true;
            this.rbMiddelgroot.Location = new System.Drawing.Point(51, 124);
            this.rbMiddelgroot.Name = "rbMiddelgroot";
            this.rbMiddelgroot.Size = new System.Drawing.Size(80, 17);
            this.rbMiddelgroot.TabIndex = 2;
            this.rbMiddelgroot.TabStop = true;
            this.rbMiddelgroot.Tag = "3";
            this.rbMiddelgroot.Text = "Middelgroot";
            this.rbMiddelgroot.UseVisualStyleBackColor = true;
            // 
            // rbGroot
            // 
            this.rbGroot.AutoSize = true;
            this.rbGroot.Location = new System.Drawing.Point(51, 147);
            this.rbGroot.Name = "rbGroot";
            this.rbGroot.Size = new System.Drawing.Size(51, 17);
            this.rbGroot.TabIndex = 3;
            this.rbGroot.TabStop = true;
            this.rbGroot.Tag = "5";
            this.rbGroot.Text = "Groot";
            this.rbGroot.UseVisualStyleBackColor = true;
            // 
            // cbCarnivoor
            // 
            this.cbCarnivoor.AutoSize = true;
            this.cbCarnivoor.Location = new System.Drawing.Point(51, 78);
            this.cbCarnivoor.Name = "cbCarnivoor";
            this.cbCarnivoor.Size = new System.Drawing.Size(71, 17);
            this.cbCarnivoor.TabIndex = 4;
            this.cbCarnivoor.Text = "Carnivoor";
            this.cbCarnivoor.UseVisualStyleBackColor = true;
            // 
            // tbTrain
            // 
            this.tbTrain.Location = new System.Drawing.Point(293, 26);
            this.tbTrain.Multiline = true;
            this.tbTrain.Name = "tbTrain";
            this.tbTrain.Size = new System.Drawing.Size(218, 248);
            this.tbTrain.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(51, 172);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(109, 20);
            this.tbName.TabIndex = 6;
            // 
            // bnSort
            // 
            this.bnSort.Location = new System.Drawing.Point(171, 197);
            this.bnSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.lbWagon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbWagon.Name = "lbWagon";
            this.lbWagon.Size = new System.Drawing.Size(221, 69);
            this.lbWagon.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 339);
            this.Controls.Add(this.lbWagon);
            this.Controls.Add(this.bnSort);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbTrain);
            this.Controls.Add(this.cbCarnivoor);
            this.Controls.Add(this.rbGroot);
            this.Controls.Add(this.rbMiddelgroot);
            this.Controls.Add(this.rbKlein);
            this.Controls.Add(this.bnAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.RadioButton rbKlein;
        private System.Windows.Forms.RadioButton rbMiddelgroot;
        private System.Windows.Forms.RadioButton rbGroot;
        private System.Windows.Forms.CheckBox cbCarnivoor;
        private System.Windows.Forms.TextBox tbTrain;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button bnSort;
        private System.Windows.Forms.ListBox lbWagon;
    }
}

