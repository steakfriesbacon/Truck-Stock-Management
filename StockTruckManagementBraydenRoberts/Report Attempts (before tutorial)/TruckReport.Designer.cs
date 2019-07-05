namespace StockTruckManagementBraydenRoberts
{
    partial class TruckReport
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
            this.btnSortbyTop5 = new System.Windows.Forms.Button();
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.btnSortByLeast5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSortbyTop5
            // 
            this.btnSortbyTop5.Location = new System.Drawing.Point(62, 34);
            this.btnSortbyTop5.Name = "btnSortbyTop5";
            this.btnSortbyTop5.Size = new System.Drawing.Size(140, 47);
            this.btnSortbyTop5.TabIndex = 0;
            this.btnSortbyTop5.Text = "Sort By Top 5";
            this.btnSortbyTop5.UseVisualStyleBackColor = true;
            this.btnSortbyTop5.Click += new System.EventHandler(this.btnSortbyTop5_Click);
            // 
            // dataListBox
            // 
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.ItemHeight = 20;
            this.dataListBox.Location = new System.Drawing.Point(234, 34);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(356, 204);
            this.dataListBox.TabIndex = 1;
            // 
            // btnSortByLeast5
            // 
            this.btnSortByLeast5.Location = new System.Drawing.Point(62, 105);
            this.btnSortByLeast5.Name = "btnSortByLeast5";
            this.btnSortByLeast5.Size = new System.Drawing.Size(140, 47);
            this.btnSortByLeast5.TabIndex = 2;
            this.btnSortByLeast5.Text = "Sort By Least 5";
            this.btnSortByLeast5.UseVisualStyleBackColor = true;
            // 
            // TruckReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortByLeast5);
            this.Controls.Add(this.dataListBox);
            this.Controls.Add(this.btnSortbyTop5);
            this.Name = "TruckReport";
            this.Text = "TruckReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSortbyTop5;
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.Button btnSortByLeast5;
    }
}