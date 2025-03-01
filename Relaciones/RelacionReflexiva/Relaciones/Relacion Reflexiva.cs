﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conjunto = ObtenerConjunto();
            var relaciones = GenerarRelaciones(conjunto);
            MostrarRelaciones(relaciones);
            bool esReflexiva = EsReflexiva(conjunto, relaciones);
            labelResultado.Text = "La relación es reflexiva: {esReflexiva}";
        }

        private HashSet<string> ObtenerConjunto()
        {
            return new HashSet<string>(textBox1.Text.Split(',').Select<string, string>(x => x.Trim()));
        }

        private List<Tuple<string, string>> GenerarRelaciones(HashSet<string> conjunto)
        {
            var relaciones = new List<Tuple<string, string>>();
            foreach (var a in conjunto)
            {
                foreach (var b in conjunto)
                {
                    relaciones.Add(new Tuple<string, string>(a, b));
                }
            }
            return relaciones;
        }

        private void MostrarRelaciones(List<Tuple<string, string>> relaciones)
        {
            textBox2.Text = string.Join("; ", relaciones.Select(r => string.Format("({0}, {1})", r.Item1, r.Item2)));
        }


        private bool EsReflexiva(HashSet<string> conjunto, List<Tuple<string, string>> relaciones)
        {
            foreach (var elemento in conjunto)
            {
                if (!relaciones.Contains(new Tuple<string, string>(elemento, elemento)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}