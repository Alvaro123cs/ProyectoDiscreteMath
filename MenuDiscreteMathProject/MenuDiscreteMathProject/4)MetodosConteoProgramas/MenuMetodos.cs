﻿using Combinatoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace MenuDiscreteMathProject._4_MetodosConteoProgramas
{
    public partial class MenuMetodos : Form
    {
        public MenuMetodos()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combinacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Combi combiForm = new Combi();
            combiForm.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora calculadoraForm = new Calculadora();
            calculadoraForm.Show();
        }
    }
}
