using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AULA_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAluno.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtAluno.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, media;
            string nome;
            nome= txtAluno.Text;
            nota1 = double.Parse(txtNota1.Text);
            nota2 = double.Parse(txtNota2.Text);
            media = (nota1 + nota2) / 2;
            MessageBox.Show(nome + " Sua média é:" + media);
        }

    }
}
