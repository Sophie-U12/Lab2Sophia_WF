namespace Lab2Sophia_WF
{
    partial class Array1DForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.btnFillArray = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 401);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(391, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "N:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(456, 25);
            this.nudN.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(115, 26);
            this.nudN.TabIndex = 7;
            this.nudN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFillArray
            // 
            this.btnFillArray.Location = new System.Drawing.Point(512, 67);
            this.btnFillArray.Name = "btnFillArray";
            this.btnFillArray.Size = new System.Drawing.Size(168, 30);
            this.btnFillArray.TabIndex = 8;
            this.btnFillArray.Text = "Заповнити масив";
            this.btnFillArray.UseVisualStyleBackColor = true;
            this.btnFillArray.Click += new System.EventHandler(this.btnFillArray_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(456, 383);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(168, 30);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Порахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // x
            // 
            this.x.HeaderText = "Value";
            this.x.Name = "x";
            this.x.Width = 330;
            // 
            // Array1DForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 425);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnFillArray);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Array1DForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array 1D";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Button btnFillArray;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
    }
}