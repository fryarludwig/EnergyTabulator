namespace EnergyCalculator
{
    partial class ConsumerSelection
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
            this.count_label = new System.Windows.Forms.Label();
            this.IsSelected = new System.Windows.Forms.CheckBox();
            this.ConsumerCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TotalUsage = new System.Windows.Forms.Label();
            this.WattsInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WattsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(149, 11);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(35, 13);
            this.count_label.TabIndex = 0;
            this.count_label.Text = "Count";
            // 
            // IsSelected
            // 
            this.IsSelected.AutoSize = true;
            this.IsSelected.Location = new System.Drawing.Point(18, 11);
            this.IsSelected.Name = "IsSelected";
            this.IsSelected.Size = new System.Drawing.Size(15, 14);
            this.IsSelected.TabIndex = 1;
            this.IsSelected.UseVisualStyleBackColor = true;
            this.IsSelected.Click += new System.EventHandler(this.OnSelectChanged);
            // 
            // ConsumerCount
            // 
            this.ConsumerCount.Location = new System.Drawing.Point(190, 9);
            this.ConsumerCount.Name = "ConsumerCount";
            this.ConsumerCount.Size = new System.Drawing.Size(43, 20);
            this.ConsumerCount.TabIndex = 3;
            this.ConsumerCount.ValueChanged += new System.EventHandler(this.OnCountChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usage: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(39, 11);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(85, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Consumer Name";
            // 
            // TotalUsage
            // 
            this.TotalUsage.AutoSize = true;
            this.TotalUsage.Location = new System.Drawing.Point(459, 11);
            this.TotalUsage.Name = "TotalUsage";
            this.TotalUsage.Size = new System.Drawing.Size(42, 13);
            this.TotalUsage.TabIndex = 7;
            this.TotalUsage.Text = "useage";
            // 
            // WattsInput
            // 
            this.WattsInput.Location = new System.Drawing.Point(320, 9);
            this.WattsInput.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.WattsInput.Name = "WattsInput";
            this.WattsInput.Size = new System.Drawing.Size(65, 20);
            this.WattsInput.TabIndex = 3;
            this.WattsInput.ValueChanged += new System.EventHandler(this.OnWattsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Watts";
            // 
            // ConsumerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.WattsInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalUsage);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConsumerCount);
            this.Controls.Add(this.IsSelected);
            this.Controls.Add(this.count_label);
            this.Name = "ConsumerSelection";
            this.Size = new System.Drawing.Size(527, 35);
            this.DoubleClick += new System.EventHandler(this.OnDoubleClicked);
            ((System.ComponentModel.ISupportInitialize)(this.ConsumerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WattsInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.CheckBox IsSelected;
        private System.Windows.Forms.NumericUpDown ConsumerCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TotalUsage;
        private System.Windows.Forms.NumericUpDown WattsInput;
        private System.Windows.Forms.Label label1;
    }
}
