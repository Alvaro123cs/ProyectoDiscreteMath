﻿namespace TrianguloDePascal
{
    partial class TriPascal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Button calculateButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            nTextBox = new TextBox();
            calculateButton = new Button();
            resultLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // nTextBox
            // 
            nTextBox.Location = new Point(61, 95);
            nTextBox.Margin = new Padding(4, 5, 4, 5);
            nTextBox.Name = "nTextBox";
            nTextBox.Size = new Size(229, 27);
            nTextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(61, 146);
            calculateButton.Margin = new Padding(4, 5, 4, 5);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(229, 51);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calcular";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(336, 95);
            resultLabel.Margin = new Padding(4, 0, 4, 0);
            resultLabel.MaximumSize = new Size(533, 375);
            resultLabel.MinimumSize = new Size(533, 375);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(533, 375);
            resultLabel.TabIndex = 2;
            resultLabel.Text = "Triangulo de Pascal";
            resultLabel.TextAlign = ContentAlignment.TopCenter;
            resultLabel.Click += resultLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(567, 54);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 54);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 4;
            label2.Text = "Ingrese valor de n";
            // 
            // TriPascal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 470);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultLabel);
            Controls.Add(calculateButton);
            Controls.Add(nTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TriPascal";
            Text = "Coeficiente Binomial";
            Load += TriPascal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
    }
}
