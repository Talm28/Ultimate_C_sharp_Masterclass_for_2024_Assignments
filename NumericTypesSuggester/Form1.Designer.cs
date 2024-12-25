
namespace NumericTypesSuggester
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
            this.MinValueLabel = new System.Windows.Forms.Label();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.IntegralOnlyLabel = new System.Windows.Forms.Label();
            this.MinValueTextBox = new System.Windows.Forms.TextBox();
            this.MaxValueTextBox = new System.Windows.Forms.TextBox();
            this.IntegralOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.SuggestedTypeLabel = new System.Windows.Forms.Label();
            this.PreciseCheckBox = new System.Windows.Forms.CheckBox();
            this.PreciseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.AutoSize = true;
            this.MinValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MinValueLabel.Location = new System.Drawing.Point(120, 58);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Size = new System.Drawing.Size(145, 32);
            this.MinValueLabel.TabIndex = 0;
            this.MinValueLabel.Text = "Min value:";
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.AutoSize = true;
            this.MaxValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MaxValueLabel.Location = new System.Drawing.Point(113, 116);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(152, 32);
            this.MaxValueLabel.TabIndex = 1;
            this.MaxValueLabel.Text = "Max value:";
            // 
            // IntegralOnlyLabel
            // 
            this.IntegralOnlyLabel.AutoSize = true;
            this.IntegralOnlyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IntegralOnlyLabel.Location = new System.Drawing.Point(79, 186);
            this.IntegralOnlyLabel.Name = "IntegralOnlyLabel";
            this.IntegralOnlyLabel.Size = new System.Drawing.Size(186, 32);
            this.IntegralOnlyLabel.TabIndex = 2;
            this.IntegralOnlyLabel.Text = "Integral only?";
            // 
            // MinValueTextBox
            // 
            this.MinValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MinValueTextBox.Location = new System.Drawing.Point(271, 55);
            this.MinValueTextBox.Name = "MinValueTextBox";
            this.MinValueTextBox.Size = new System.Drawing.Size(578, 39);
            this.MinValueTextBox.TabIndex = 3;
            this.MinValueTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.MinValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.MinValueTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // MaxValueTextBox
            // 
            this.MaxValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MaxValueTextBox.Location = new System.Drawing.Point(271, 113);
            this.MaxValueTextBox.Name = "MaxValueTextBox";
            this.MaxValueTextBox.Size = new System.Drawing.Size(578, 39);
            this.MaxValueTextBox.TabIndex = 4;
            this.MaxValueTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.MaxValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.MaxValueTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // IntegralOnlyCheckBox
            // 
            this.IntegralOnlyCheckBox.AutoSize = true;
            this.IntegralOnlyCheckBox.Location = new System.Drawing.Point(282, 197);
            this.IntegralOnlyCheckBox.Name = "IntegralOnlyCheckBox";
            this.IntegralOnlyCheckBox.Size = new System.Drawing.Size(22, 21);
            this.IntegralOnlyCheckBox.TabIndex = 5;
            this.IntegralOnlyCheckBox.UseVisualStyleBackColor = true;
            this.IntegralOnlyCheckBox.CheckedChanged += new System.EventHandler(this.IntegralOnlyCheckBox_CheckedChanged);
            // 
            // SuggestedTypeLabel
            // 
            this.SuggestedTypeLabel.AutoSize = true;
            this.SuggestedTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SuggestedTypeLabel.Location = new System.Drawing.Point(60, 353);
            this.SuggestedTypeLabel.Name = "SuggestedTypeLabel";
            this.SuggestedTypeLabel.Size = new System.Drawing.Size(465, 32);
            this.SuggestedTypeLabel.TabIndex = 6;
            this.SuggestedTypeLabel.Text = "Suggested type: not enough data";
            // 
            // PreciseCheckBox
            // 
            this.PreciseCheckBox.AutoSize = true;
            this.PreciseCheckBox.Location = new System.Drawing.Point(282, 262);
            this.PreciseCheckBox.Name = "PreciseCheckBox";
            this.PreciseCheckBox.Size = new System.Drawing.Size(22, 21);
            this.PreciseCheckBox.TabIndex = 8;
            this.PreciseCheckBox.UseVisualStyleBackColor = true;
            this.PreciseCheckBox.CheckedChanged += new System.EventHandler(this.PreciseCheckBox_CheckedChanged);
            // 
            // PreciseLabel
            // 
            this.PreciseLabel.AutoSize = true;
            this.PreciseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PreciseLabel.Location = new System.Drawing.Point(35, 251);
            this.PreciseLabel.Name = "PreciseLabel";
            this.PreciseLabel.Size = new System.Drawing.Size(230, 32);
            this.PreciseLabel.TabIndex = 7;
            this.PreciseLabel.Text = "Must be precise?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.PreciseCheckBox);
            this.Controls.Add(this.PreciseLabel);
            this.Controls.Add(this.SuggestedTypeLabel);
            this.Controls.Add(this.IntegralOnlyCheckBox);
            this.Controls.Add(this.MaxValueTextBox);
            this.Controls.Add(this.MinValueTextBox);
            this.Controls.Add(this.IntegralOnlyLabel);
            this.Controls.Add(this.MaxValueLabel);
            this.Controls.Add(this.MinValueLabel);
            this.Name = "Form1";
            this.Text = "Numeric type suggester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MinValueLabel;
        private System.Windows.Forms.Label MaxValueLabel;
        private System.Windows.Forms.Label IntegralOnlyLabel;
        private System.Windows.Forms.TextBox MinValueTextBox;
        private System.Windows.Forms.TextBox MaxValueTextBox;
        private System.Windows.Forms.CheckBox IntegralOnlyCheckBox;
        private System.Windows.Forms.Label SuggestedTypeLabel;
        private System.Windows.Forms.CheckBox PreciseCheckBox;
        private System.Windows.Forms.Label PreciseLabel;
    }
}

