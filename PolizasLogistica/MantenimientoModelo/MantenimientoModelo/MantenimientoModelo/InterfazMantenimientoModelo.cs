﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace MantenimientoModelo
{
    public partial class InterfazMantenimientoModelos : Form
    {
        Navegador nv2 = new Navegador();
        public InterfazMantenimientoModelos(DataGridView dataGridView1)
        {
            InitializeComponent();
            nv2.nombreForm(this);
            nv2.dgv_datos(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InterfazMantenimientoModelos_Load(object sender, EventArgs e)
        {
            nv2.ingresarTabla("TBL_Modelo");
        }

        private void navegador2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}