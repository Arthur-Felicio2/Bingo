﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class frmHistorico: Form
    {
        
        public frmHistorico(bool[]historic)
        {
            InitializeComponent();
            for(int i =1; i < historic.Length; i++)
            {
                string getOut = historic[i] ? "X":" ";
                lbxHistoric.Items.Add($"{i}\t: [{getOut}]");

            }
        }

        private void lbxHistoric_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
