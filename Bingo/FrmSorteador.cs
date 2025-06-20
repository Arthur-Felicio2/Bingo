﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class FrmSorteador: Form
    {
        Form anterior;
        int qtd;
        FrmCartela[] cartelas;
        bool[] sorteados;
        public FrmSorteador(Form anterior,int qtd)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.qtd = qtd;
            sorteados = new bool[76];
            for(int i = 0; i < sorteados.Length; i++)
            {
                sorteados[i] = false;
            }

            cartelas = new FrmCartela[qtd];
            for(int i = 0; i < qtd; i++)
            {
                cartelas[i] = new FrmCartela(this, i + 1);
                cartelas[i].Show();
            }


        }

        private void btNext_Click(object sender, EventArgs e)
        {
            int num;
            Random r = new Random();
            do
            {
                num = r.Next(1, 76);
            } while (sorteados[num]);
            sorteados[num] = true;

            foreach(FrmCartela c in cartelas)
            {
                c.ReceiveNumber(num);
            }
            lblNumber.Text = num.ToString();
        }

        public void WinNotify(FrmCartela cartela)
        {
            foreach (FrmCartela c in cartelas)
            {
                if (c != cartela)
                {
                    c.Close();
                }
                btNext.Enabled = false;
            }
        }

        private void FrmSorteador_Load(object sender, EventArgs e)
        {

        }

        private void btHistoric_Click(object sender, EventArgs e)
        {
            frmHistorico f  = new frmHistorico(sorteados);
            f.ShowDialog();
        }

        private void FrmSorteador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fechar esse jogo?","Bingo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach(FrmCartela c in cartelas)
                {
                    c.Close();
                    anterior.Show();
                }

               
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
