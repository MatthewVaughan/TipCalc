namespace Project01
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mealAmount = new System.Windows.Forms.Label();
            this.lblPoor = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblExcellent = new System.Windows.Forms.Label();
            this.txtMealAmount = new System.Windows.Forms.TextBox();
            this.txtPoor = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtExcellent = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtPoorTip = new System.Windows.Forms.TextBox();
            this.txtAverageTip = new System.Windows.Forms.TextBox();
            this.txtExcellentTip = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(181, 26);
            this.menuAbout.Text = "About...";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(181, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // mealAmount
            // 
            this.mealAmount.AutoSize = true;
            this.mealAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealAmount.Location = new System.Drawing.Point(30, 68);
            this.mealAmount.Name = "mealAmount";
            this.mealAmount.Size = new System.Drawing.Size(217, 38);
            this.mealAmount.TabIndex = 1;
            this.mealAmount.Text = "Meal Amount:";
            // 
            // lblPoor
            // 
            this.lblPoor.AutoSize = true;
            this.lblPoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoor.Location = new System.Drawing.Point(167, 227);
            this.lblPoor.Name = "lblPoor";
            this.lblPoor.Size = new System.Drawing.Size(130, 25);
            this.lblPoor.TabIndex = 2;
            this.lblPoor.Text = "Poor Service:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(167, 263);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(163, 25);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average Service:";
            // 
            // lblExcellent
            // 
            this.lblExcellent.AutoSize = true;
            this.lblExcellent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcellent.Location = new System.Drawing.Point(167, 299);
            this.lblExcellent.Name = "lblExcellent";
            this.lblExcellent.Size = new System.Drawing.Size(168, 25);
            this.lblExcellent.TabIndex = 4;
            this.lblExcellent.Text = "Excellent Service:";
            // 
            // txtMealAmount
            // 
            this.txtMealAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealAmount.Location = new System.Drawing.Point(276, 61);
            this.txtMealAmount.Name = "txtMealAmount";
            this.txtMealAmount.Size = new System.Drawing.Size(100, 45);
            this.txtMealAmount.TabIndex = 5;
            this.txtMealAmount.Leave += new System.EventHandler(this.txtMealAmount_Leave);
            // 
            // txtPoor
            // 
            this.txtPoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoor.Location = new System.Drawing.Point(510, 230);
            this.txtPoor.Name = "txtPoor";
            this.txtPoor.Size = new System.Drawing.Size(100, 30);
            this.txtPoor.TabIndex = 6;
            // 
            // txtAverage
            // 
            this.txtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.Location = new System.Drawing.Point(510, 266);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 30);
            this.txtAverage.TabIndex = 7;
            // 
            // txtExcellent
            // 
            this.txtExcellent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcellent.Location = new System.Drawing.Point(510, 302);
            this.txtExcellent.Name = "txtExcellent";
            this.txtExcellent.Size = new System.Drawing.Size(100, 30);
            this.txtExcellent.TabIndex = 8;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(495, 202);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(129, 25);
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(396, 202);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(40, 25);
            this.lblTip.TabIndex = 10;
            this.lblTip.Text = "Tip";
            // 
            // txtPoorTip
            // 
            this.txtPoorTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoorTip.ForeColor = System.Drawing.Color.Green;
            this.txtPoorTip.Location = new System.Drawing.Point(365, 230);
            this.txtPoorTip.Name = "txtPoorTip";
            this.txtPoorTip.Size = new System.Drawing.Size(100, 30);
            this.txtPoorTip.TabIndex = 11;
            // 
            // txtAverageTip
            // 
            this.txtAverageTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverageTip.ForeColor = System.Drawing.Color.Green;
            this.txtAverageTip.Location = new System.Drawing.Point(365, 266);
            this.txtAverageTip.Name = "txtAverageTip";
            this.txtAverageTip.Size = new System.Drawing.Size(100, 30);
            this.txtAverageTip.TabIndex = 12;
            // 
            // txtExcellentTip
            // 
            this.txtExcellentTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcellentTip.ForeColor = System.Drawing.Color.Green;
            this.txtExcellentTip.Location = new System.Drawing.Point(365, 302);
            this.txtExcellentTip.Name = "txtExcellentTip";
            this.txtExcellentTip.Size = new System.Drawing.Size(100, 30);
            this.txtExcellentTip.TabIndex = 13;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 447);
            this.Controls.Add(this.txtExcellentTip);
            this.Controls.Add(this.txtAverageTip);
            this.Controls.Add(this.txtPoorTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtExcellent);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtPoor);
            this.Controls.Add(this.txtMealAmount);
            this.Controls.Add(this.lblExcellent);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblPoor);
            this.Controls.Add(this.mealAmount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.TextBox txtMealAmount;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtExcellent;
        private System.Windows.Forms.TextBox txtPoor;
        private System.Windows.Forms.Label lblExcellent;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblPoor;
        private System.Windows.Forms.Label mealAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPoorTip;
        private System.Windows.Forms.TextBox txtAverageTip;
        private System.Windows.Forms.TextBox txtExcellentTip;
    }
}

