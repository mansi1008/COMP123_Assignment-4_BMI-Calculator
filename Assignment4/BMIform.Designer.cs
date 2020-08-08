namespace Assignment4
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <mm name="disposing">true if managed resources should be disposed; otherwise, false.</mm>
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bmilabel = new System.Windows.Forms.Label();
            this.imperialradiobutton = new System.Windows.Forms.RadioButton();
            this.metricradiobutton = new System.Windows.Forms.RadioButton();
            this.weightlabel = new System.Windows.Forms.Label();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.weight = new System.Windows.Forms.NumericUpDown();
            this.calculatedbmi = new System.Windows.Forms.TextBox();
            this.multilinetextbox = new System.Windows.Forms.TextBox();
            this.heightlabel = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bmilabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imperialradiobutton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metricradiobutton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.weightlabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.calculatebutton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.weight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.calculatedbmi, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.multilinetextbox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.heightlabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.height, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.183675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.183675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.26531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.30612F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.32653F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bmilabel
            // 
            this.bmilabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.bmilabel, 2);
            this.bmilabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmilabel.Font = new System.Drawing.Font("Castellar", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmilabel.ForeColor = System.Drawing.Color.Black;
            this.bmilabel.Location = new System.Drawing.Point(7, 0);
            this.bmilabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.bmilabel.Name = "bmilabel";
            this.bmilabel.Size = new System.Drawing.Size(256, 81);
            this.bmilabel.TabIndex = 0;
            this.bmilabel.Text = "BMI Calculator";
            this.bmilabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imperialradiobutton
            // 
            this.imperialradiobutton.AutoSize = true;
            this.imperialradiobutton.Checked = true;
            this.imperialradiobutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imperialradiobutton.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imperialradiobutton.ForeColor = System.Drawing.Color.Black;
            this.imperialradiobutton.Location = new System.Drawing.Point(7, 88);
            this.imperialradiobutton.Margin = new System.Windows.Forms.Padding(7);
            this.imperialradiobutton.Name = "imperialradiobutton";
            this.imperialradiobutton.Size = new System.Drawing.Size(121, 51);
            this.imperialradiobutton.TabIndex = 1;
            this.imperialradiobutton.TabStop = true;
            this.imperialradiobutton.Text = "Imperial (in,pd)";
            this.imperialradiobutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imperialradiobutton.UseVisualStyleBackColor = true;
            // 
            // metricradiobutton
            // 
            this.metricradiobutton.AutoSize = true;
            this.metricradiobutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metricradiobutton.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold);
            this.metricradiobutton.ForeColor = System.Drawing.Color.Black;
            this.metricradiobutton.Location = new System.Drawing.Point(142, 88);
            this.metricradiobutton.Margin = new System.Windows.Forms.Padding(7);
            this.metricradiobutton.Name = "metricradiobutton";
            this.metricradiobutton.Size = new System.Drawing.Size(121, 51);
            this.metricradiobutton.TabIndex = 2;
            this.metricradiobutton.Text = "Metric (cm,kg)";
            this.metricradiobutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metricradiobutton.UseVisualStyleBackColor = true;
            // 
            // weightlabel
            // 
            this.weightlabel.AutoSize = true;
            this.weightlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weightlabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold);
            this.weightlabel.ForeColor = System.Drawing.Color.Black;
            this.weightlabel.Location = new System.Drawing.Point(7, 182);
            this.weightlabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.weightlabel.Name = "weightlabel";
            this.weightlabel.Size = new System.Drawing.Size(121, 36);
            this.weightlabel.TabIndex = 4;
            this.weightlabel.Text = "Weight";
            this.weightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatebutton
            // 
            this.calculatebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculatebutton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.tableLayoutPanel1.SetColumnSpan(this.calculatebutton, 2);
            this.calculatebutton.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold);
            this.calculatebutton.ForeColor = System.Drawing.Color.Black;
            this.calculatebutton.Location = new System.Drawing.Point(7, 225);
            this.calculatebutton.Margin = new System.Windows.Forms.Padding(7);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(256, 39);
            this.calculatebutton.TabIndex = 5;
            this.calculatebutton.Text = "CALCULATE BMI\r\n";
            this.calculatebutton.UseVisualStyleBackColor = false;
            this.calculatebutton.Click += new System.EventHandler(this.calculatebutton_Click);
            // 
            // weight
            // 
            this.weight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weight.BackColor = System.Drawing.Color.Azure;
            this.weight.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold);
            this.weight.Location = new System.Drawing.Point(142, 189);
            this.weight.Margin = new System.Windows.Forms.Padding(7);
            this.weight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(121, 25);
            this.weight.TabIndex = 8;
            // 
            // calculatedbmi
            // 
            this.calculatedbmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculatedbmi.BackColor = System.Drawing.Color.Plum;
            this.tableLayoutPanel1.SetColumnSpan(this.calculatedbmi, 2);
            this.calculatedbmi.Enabled = false;
            this.calculatedbmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedbmi.ForeColor = System.Drawing.Color.DarkGreen;
            this.calculatedbmi.Location = new System.Drawing.Point(3, 288);
            this.calculatedbmi.Name = "calculatedbmi";
            this.calculatedbmi.ReadOnly = true;
            this.calculatedbmi.Size = new System.Drawing.Size(264, 27);
            this.calculatedbmi.TabIndex = 9;
            this.calculatedbmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // multilinetextbox
            // 
            this.multilinetextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multilinetextbox.BackColor = System.Drawing.Color.Plum;
            this.tableLayoutPanel1.SetColumnSpan(this.multilinetextbox, 2);
            this.multilinetextbox.Enabled = false;
            this.multilinetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multilinetextbox.Location = new System.Drawing.Point(3, 335);
            this.multilinetextbox.Multiline = true;
            this.multilinetextbox.Name = "multilinetextbox";
            this.multilinetextbox.ReadOnly = true;
            this.multilinetextbox.Size = new System.Drawing.Size(264, 63);
            this.multilinetextbox.TabIndex = 10;
            // 
            // heightlabel
            // 
            this.heightlabel.AutoSize = true;
            this.heightlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightlabel.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold);
            this.heightlabel.ForeColor = System.Drawing.Color.Black;
            this.heightlabel.Location = new System.Drawing.Point(7, 146);
            this.heightlabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.heightlabel.Name = "heightlabel";
            this.heightlabel.Size = new System.Drawing.Size(121, 36);
            this.heightlabel.TabIndex = 3;
            this.heightlabel.Text = "Height";
            this.heightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // height
            // 
            this.height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.height.BackColor = System.Drawing.Color.Azure;
            this.height.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold);
            this.height.Location = new System.Drawing.Point(142, 153);
            this.height.Margin = new System.Windows.Forms.Padding(7);
            this.height.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(121, 25);
            this.height.TabIndex = 7;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label bmilabel;
        private System.Windows.Forms.RadioButton imperialradiobutton;
        private System.Windows.Forms.RadioButton metricradiobutton;
        private System.Windows.Forms.Label heightlabel;
        private System.Windows.Forms.Label weightlabel;
        private System.Windows.Forms.Button calculatebutton;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.NumericUpDown weight;
        private System.Windows.Forms.TextBox calculatedbmi;
        private System.Windows.Forms.TextBox multilinetextbox;
    }
}

