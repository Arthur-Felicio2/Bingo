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
        int[][] range;
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

            range = new int[5][]
            {
                new int[] { 1, 15 },
                new int[] { 16, 30 },
                new int[] { 31, 45 },
                new int[] { 46, 60 },
                new int[
                    ] { 61, 75 }
            };
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
                    int num = r.Next(range[i][0], range[i][1] + 1);
                    numbers[i][j] = num;
                    positions[i][j].Text = num.ToString();
                }
            }
        }
        public void ReceiveNumber(int num)
        {
            int i;
            for ( i = 0; i < 5 && !(num >= range[i][0] && num <= range[i][1]); i++) ;

            for(int j = 0; j < 5; j++)
            {
                if (numbers[i][j] == num)
                {
                    positions[i][j].ForeColor = Color.White;
                    positions[i][j].BackColor = Color.Black;
                    
                }
            }
        }

        
    }
}
