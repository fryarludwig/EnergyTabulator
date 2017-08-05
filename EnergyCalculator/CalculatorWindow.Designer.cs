namespace EnergyCalculator
{
    partial class CalculatorWindow
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
            this.ConsumerTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalConsumption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCountInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.count_label = new System.Windows.Forms.Label();
            this.AddWattsInput = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddWattsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsumerTable
            // 
            this.ConsumerTable.AutoScroll = true;
            this.ConsumerTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConsumerTable.ColumnCount = 1;
            this.ConsumerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsumerTable.Location = new System.Drawing.Point(12, 47);
            this.ConsumerTable.Name = "ConsumerTable";
            this.ConsumerTable.RowCount = 1;
            this.ConsumerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsumerTable.Size = new System.Drawing.Size(534, 434);
            this.ConsumerTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalConsumption);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 59);
            this.panel1.TabIndex = 1;
            // 
            // TotalConsumption
            // 
            this.TotalConsumption.AutoSize = true;
            this.TotalConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalConsumption.Location = new System.Drawing.Point(199, 19);
            this.TotalConsumption.Name = "TotalConsumption";
            this.TotalConsumption.Size = new System.Drawing.Size(45, 24);
            this.TotalConsumption.TabIndex = 1;
            this.TotalConsumption.Text = "0 / 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Consumption: ";
            // 
            // AddNameInput
            // 
            this.AddNameInput.Location = new System.Drawing.Point(52, 13);
            this.AddNameInput.Name = "AddNameInput";
            this.AddNameInput.Size = new System.Drawing.Size(153, 20);
            this.AddNameInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // AddCountInput
            // 
            this.AddCountInput.Location = new System.Drawing.Point(268, 12);
            this.AddCountInput.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.AddCountInput.Name = "AddCountInput";
            this.AddCountInput.Size = new System.Drawing.Size(63, 20);
            this.AddCountInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Watts";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(227, 16);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(35, 13);
            this.count_label.TabIndex = 9;
            this.count_label.Text = "Count";
            // 
            // AddWattsInput
            // 
            this.AddWattsInput.Location = new System.Drawing.Point(395, 13);
            this.AddWattsInput.Name = "AddWattsInput";
            this.AddWattsInput.Size = new System.Drawing.Size(86, 20);
            this.AddWattsInput.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnAddConsumerClicked);
            // 
            // CalculatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddWattsInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.count_label);
            this.Controls.Add(this.AddCountInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddNameInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConsumerTable);
            this.Name = "CalculatorWindow";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddWattsInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsumerTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalConsumption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AddCountInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.NumericUpDown AddWattsInput;
        private System.Windows.Forms.Button button1;
    }
}

