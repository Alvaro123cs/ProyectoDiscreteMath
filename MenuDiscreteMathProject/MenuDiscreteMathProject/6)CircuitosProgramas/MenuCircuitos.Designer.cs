﻿namespace MenuDiscreteMathProject._6_CircuitosProgramas
{
    partial class MenuCircuitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCircuitos));
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            coeficientesBinomialesToolStripMenuItem = new ToolStripMenuItem();
            combinacionesToolStripMenuItem = new ToolStripMenuItem();
            trianguloDePascalToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(769, 9);
            label6.Name = "label6";
            label6.Size = new Size(19, 20);
            label6.TabIndex = 23;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { coeficientesBinomialesToolStripMenuItem, combinacionesToolStripMenuItem, trianguloDePascalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // coeficientesBinomialesToolStripMenuItem
            // 
            coeficientesBinomialesToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            coeficientesBinomialesToolStripMenuItem.Name = "coeficientesBinomialesToolStripMenuItem";
            coeficientesBinomialesToolStripMenuItem.Size = new Size(213, 27);
            coeficientesBinomialesToolStripMenuItem.Text = "Coeficientes Binomiales";
            coeficientesBinomialesToolStripMenuItem.Click += coeficientesBinomialesToolStripMenuItem_Click;
            // 
            // combinacionesToolStripMenuItem
            // 
            combinacionesToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            combinacionesToolStripMenuItem.Name = "combinacionesToolStripMenuItem";
            combinacionesToolStripMenuItem.Size = new Size(145, 27);
            combinacionesToolStripMenuItem.Text = "Combinaciones";
            combinacionesToolStripMenuItem.Click += combinacionesToolStripMenuItem_Click;
            // 
            // trianguloDePascalToolStripMenuItem
            // 
            trianguloDePascalToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            trianguloDePascalToolStripMenuItem.Name = "trianguloDePascalToolStripMenuItem";
            trianguloDePascalToolStripMenuItem.Size = new Size(178, 27);
            trianguloDePascalToolStripMenuItem.Text = "Triangulo de Pascal";
            trianguloDePascalToolStripMenuItem.Click += trianguloDePascalToolStripMenuItem_Click;
            // 
            // MenuCircuitos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuCircuitos";
            Text = "MenuCircuitos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem coeficientesBinomialesToolStripMenuItem;
        private ToolStripMenuItem combinacionesToolStripMenuItem;
        private ToolStripMenuItem trianguloDePascalToolStripMenuItem;
    }
}