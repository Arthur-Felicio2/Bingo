using System;
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
    public partial class FrmCartela: Form
    {
        FrmSorteador sorteador;
        int id;

        int[][] numbers;
        Label[][] positions;
        int drawn;


        public FrmCartela(FrmSorteador sorteador ,  int id)
        {
            InitializeComponent();
            this.sorteador = sorteador;
            this.id = id;

            numbers = new int[5][]
            {
                new int[5],
                new int[5],
                new int[5],
                new int[5],
                new int[5]
            };
            positions = new Label[5][]
            {
                new Label[5] {lbl1_1,lbl1_2,lbl1_3,lbl1_4,lbl1_5},
                new Label[5] { lbl2_1, lbl2_2, lbl2_3, lbl2_4, lbl2_5 },
                new Label[5] { lbl3_1, lbl3_2, lbl3_3, lbl3_4, lbl3_5 },
                new Label[5] { lbl4_1, lbl4_2, lbl4_3, lbl4_4, lbl4_5 },
                new Label[5] { lbl5_1, lbl5_2, lbl5_3, lbl5_4, lbl5_5 }
            };

            drawn = 0;

            CreateCarton();
            

        }

        void CreateCarton()
        {
            Random r = new Random();
            for(int i =0; i<5; i++)
            {

                for(int j= 0; j < 5; j++)
                {
                   // if (i == j && i == 2) continue;
                    int num = r.Next(1,16) + (15*i);
                    numbers[i][j] = num;
                    positions[i][j].Text = num.ToString();
                }
            }
        }
        public void ReceiveNumber(int num)
        {
            int i = (num - 1) / 15;

            for(int j = 0; j < 5; j++)
            {
                if (numbers[i][j] == num)
                {
                    positions[i][j].ForeColor = Color.White;
                    positions[i][j].BackColor = Color.Black;
                    drawn++;


                    if (drawn ==25)
                    {
                        lblWin.Visible = true;
                        sorteador.WinNotify(this);

                    }


                }
            }
        }

        private void FrmCartela_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
