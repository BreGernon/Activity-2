namespace Activity_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gramsBox = new System.Windows.Forms.TextBox();
            this.cupsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an ingredient measurement in grams:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gramsBox
            // 
            this.gramsBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gramsBox.Location = new System.Drawing.Point(475, 62);
            this.gramsBox.Name = "gramsBox";
            this.gramsBox.Size = new System.Drawing.Size(125, 28);
            this.gramsBox.TabIndex = 1;
            // 
            // cupsBox
            // 
            this.cupsBox.Enabled = false;
            this.cupsBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cupsBox.Location = new System.Drawing.Point(475, 134);
            this.cupsBox.Name = "cupsBox";
            this.cupsBox.Size = new System.Drawing.Size(125, 28);
            this.cupsBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(113, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingredient measurement in cups:";
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.convertButton.Location = new System.Drawing.Point(488, 198);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(94, 39);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 249);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cupsBox);
            this.Controls.Add(this.gramsBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Baking Companion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox gramsBox;
        private TextBox cupsBox;
        private Label label2;
        private Button convertButton;
    }
}