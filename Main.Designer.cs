namespace HW_4
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
            this.lblHead = new System.Windows.Forms.Label();
            this.lblHeadSickChart = new System.Windows.Forms.Label();
            this.lblHeadHealthChart = new System.Windows.Forms.Label();
            this.lblHeadChart = new System.Windows.Forms.Label();
            this.btnAddSickAnimal = new System.Windows.Forms.Button();
            this.btnRemoveSickAnimal = new System.Windows.Forms.Button();
            this.btnAddHealthAnimal = new System.Windows.Forms.Button();
            this.btnRemoveHealthAnimal = new System.Windows.Forms.Button();
            this.lstbxHealthAnimalsChart = new System.Windows.Forms.ListBox();
            this.lstbxSickAnimalsChart = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(561, 9);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(138, 20);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "גן חיות- כפיר גיסמן";
            this.lblHead.Click += new System.EventHandler(this.lblHead_Click);
            // 
            // lblHeadSickChart
            // 
            this.lblHeadSickChart.AutoSize = true;
            this.lblHeadSickChart.Location = new System.Drawing.Point(823, 167);
            this.lblHeadSickChart.Name = "lblHeadSickChart";
            this.lblHeadSickChart.Size = new System.Drawing.Size(86, 20);
            this.lblHeadSickChart.TabIndex = 3;
            this.lblHeadSickChart.Text = "חיות חולות:";
            // 
            // lblHeadHealthChart
            // 
            this.lblHeadHealthChart.AutoSize = true;
            this.lblHeadHealthChart.Location = new System.Drawing.Point(1065, 167);
            this.lblHeadHealthChart.Name = "lblHeadHealthChart";
            this.lblHeadHealthChart.Size = new System.Drawing.Size(91, 20);
            this.lblHeadHealthChart.TabIndex = 4;
            this.lblHeadHealthChart.Text = "חיות בריאות";
            // 
            // lblHeadChart
            // 
            this.lblHeadChart.AutoSize = true;
            this.lblHeadChart.Location = new System.Drawing.Point(949, 118);
            this.lblHeadChart.Name = "lblHeadChart";
            this.lblHeadChart.Size = new System.Drawing.Size(0, 20);
            this.lblHeadChart.TabIndex = 5;
            // 
            // btnAddSickAnimal
            // 
            this.btnAddSickAnimal.Location = new System.Drawing.Point(39, 80);
            this.btnAddSickAnimal.Name = "btnAddSickAnimal";
            this.btnAddSickAnimal.Size = new System.Drawing.Size(254, 38);
            this.btnAddSickAnimal.TabIndex = 6;
            this.btnAddSickAnimal.Text = "הוסף חיה חולה לתור של ג\'ורג";
            this.btnAddSickAnimal.UseVisualStyleBackColor = true;
            this.btnAddSickAnimal.Click += new System.EventHandler(this.btnAddSickAnimal_Click);
            // 
            // btnRemoveSickAnimal
            // 
            this.btnRemoveSickAnimal.Location = new System.Drawing.Point(38, 133);
            this.btnRemoveSickAnimal.Name = "btnRemoveSickAnimal";
            this.btnRemoveSickAnimal.Size = new System.Drawing.Size(253, 39);
            this.btnRemoveSickAnimal.TabIndex = 7;
            this.btnRemoveSickAnimal.Text = "קח חיה לטיפול במרפאה ";
            this.btnRemoveSickAnimal.UseVisualStyleBackColor = true;
            // 
            // btnAddHealthAnimal
            // 
            this.btnAddHealthAnimal.Location = new System.Drawing.Point(39, 187);
            this.btnAddHealthAnimal.Name = "btnAddHealthAnimal";
            this.btnAddHealthAnimal.Size = new System.Drawing.Size(252, 47);
            this.btnAddHealthAnimal.TabIndex = 8;
            this.btnAddHealthAnimal.Text = "הוסף חיה בריאה להשגחה של קרקו";
            this.btnAddHealthAnimal.UseVisualStyleBackColor = true;
            // 
            // btnRemoveHealthAnimal
            // 
            this.btnRemoveHealthAnimal.Location = new System.Drawing.Point(39, 240);
            this.btnRemoveHealthAnimal.Name = "btnRemoveHealthAnimal";
            this.btnRemoveHealthAnimal.Size = new System.Drawing.Size(254, 38);
            this.btnRemoveHealthAnimal.TabIndex = 9;
            this.btnRemoveHealthAnimal.Text = "הסר חיה בריאה מהתור";
            this.btnRemoveHealthAnimal.UseVisualStyleBackColor = true;
            // 
            // lstbxHealthAnimalsChart
            // 
            this.lstbxHealthAnimalsChart.FormattingEnabled = true;
            this.lstbxHealthAnimalsChart.ItemHeight = 20;
            this.lstbxHealthAnimalsChart.Location = new System.Drawing.Point(1012, 205);
            this.lstbxHealthAnimalsChart.Name = "lstbxHealthAnimalsChart";
            this.lstbxHealthAnimalsChart.Size = new System.Drawing.Size(183, 324);
            this.lstbxHealthAnimalsChart.TabIndex = 10;
            // 
            // lstbxSickAnimalsChart
            // 
            this.lstbxSickAnimalsChart.FormattingEnabled = true;
            this.lstbxSickAnimalsChart.ItemHeight = 20;
            this.lstbxSickAnimalsChart.Location = new System.Drawing.Point(761, 205);
            this.lstbxSickAnimalsChart.Name = "lstbxSickAnimalsChart";
            this.lstbxSickAnimalsChart.Size = new System.Drawing.Size(188, 324);
            this.lstbxSickAnimalsChart.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 547);
            this.Controls.Add(this.lstbxSickAnimalsChart);
            this.Controls.Add(this.lstbxHealthAnimalsChart);
            this.Controls.Add(this.btnRemoveHealthAnimal);
            this.Controls.Add(this.btnAddHealthAnimal);
            this.Controls.Add(this.btnRemoveSickAnimal);
            this.Controls.Add(this.btnAddSickAnimal);
            this.Controls.Add(this.lblHeadChart);
            this.Controls.Add(this.lblHeadHealthChart);
            this.Controls.Add(this.lblHeadSickChart);
            this.Controls.Add(this.lblHead);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblHeadSickChart;
        private System.Windows.Forms.Label lblHeadHealthChart;
        private System.Windows.Forms.Label lblHeadChart;
        private System.Windows.Forms.Button btnAddSickAnimal;
        private System.Windows.Forms.Button btnRemoveSickAnimal;
        private System.Windows.Forms.Button btnAddHealthAnimal;
        private System.Windows.Forms.Button btnRemoveHealthAnimal;
        private System.Windows.Forms.ListBox lstbxHealthAnimalsChart;
        private System.Windows.Forms.ListBox lstbxSickAnimalsChart;
    }
}

