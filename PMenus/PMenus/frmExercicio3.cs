﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenus
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int posicao = 0;
            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();
            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (posicao >= 0) // a busca do indexof inicia em zero
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();

            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text,
                "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string auxiliar = txtPalavra1.Text;
            char[] arr = auxiliar.ToCharArray(); //joga a string pra um array
            Array.Reverse(arr); //invertendo o array

            auxiliar = "";

            foreach (char cara in arr)
            {
                auxiliar = auxiliar + cara.ToString();
            }

            MessageBox.Show(auxiliar);
        }
    }
}
