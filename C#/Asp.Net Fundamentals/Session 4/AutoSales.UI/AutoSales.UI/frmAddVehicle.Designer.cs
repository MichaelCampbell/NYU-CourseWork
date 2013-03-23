namespace AutoSales.UI
{
    partial class frmAddVehicle
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textMake = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.textColor = new System.Windows.Forms.TextBox();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.masktxtPrice = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a Vehicle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textMake
            // 
            this.textMake.Location = new System.Drawing.Point(67, 51);
            this.textMake.Name = "textMake";
            this.textMake.Size = new System.Drawing.Size(100, 20);
            this.textMake.TabIndex = 0;
            this.textMake.TextChanged += new System.EventHandler(this.textMake_TextChanged);
            // 
            // textModel
            // 
            this.textModel.Location = new System.Drawing.Point(67, 77);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(100, 20);
            this.textModel.TabIndex = 1;
            this.textModel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(16, 51);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(42, 13);
            this.lblMake.TabIndex = 5;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(16, 77);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(45, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model:";
            this.lblModel.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(16, 100);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(37, 13);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(16, 130);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(16, 162);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 13);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color:";
            this.lblColor.Click += new System.EventHandler(this.label6_Click);
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(67, 162);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(100, 20);
            this.textColor.TabIndex = 4;
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorPicker.Location = new System.Drawing.Point(173, 162);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(34, 23);
            this.btnColorPicker.TabIndex = 5;
            this.btnColorPicker.Text = "...";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(67, 100);
            this.numericYear.Maximum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.numericYear.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(64, 20);
            this.numericYear.TabIndex = 2;
            this.numericYear.Value = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            // 
            // masktxtPrice
            // 
            this.masktxtPrice.Location = new System.Drawing.Point(67, 130);
            this.masktxtPrice.Mask = "#####";
            this.masktxtPrice.Name = "masktxtPrice";
            this.masktxtPrice.Size = new System.Drawing.Size(100, 20);
            this.masktxtPrice.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(91, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add to Inventory";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.masktxtPrice);
            this.Controls.Add(this.numericYear);
            this.Controls.Add(this.btnColorPicker);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.textMake);
            this.Controls.Add(this.label1);
            this.Name = "frmAddVehicle";
            this.Text = "Add Vehicle to Inventory";
            this.Load += new System.EventHandler(this.frmAddVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMake;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.MaskedTextBox masktxtPrice;
        private System.Windows.Forms.Button btnAdd;
    }
}