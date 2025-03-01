﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MenuDiscreteMathProject.AcercaDe_Ayuda
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        //Este metodo sirve para que presionando los picturebox pueda reenviar a un enlace
        private void OpenUrl(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el enlace: {ex.Message}");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenUrl("https://github.com/Alvaro123cs/ProyectoDiscreteMath");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenUrl("https://chat.whatsapp.com/Ik4QaA8Dy4lBUotOrCON1A");
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.youtube.com/watch?v=iVLDfJihoTs");
        }

      
    }
}
