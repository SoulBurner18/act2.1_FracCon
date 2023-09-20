using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Facciones_Continuas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, i = 1;
            String ecuacion = "";
            a = int.Parse(TxtNum1.Text);
            b = int.Parse(TxtNum2.Text);

            while (b != 0)
            {
                
                int temp = b;
                b = a%b;
                if (b == 0)
                {
                    ecuacion = a + "/"+temp +" = " +(a/temp);
                }
                else
                {
                    ecuacion = a + "/" + temp + " = " + (a / temp) + " + 1/" + temp + " / " + b;
                }
                TablaDatos.Rows.Add(i, a+ " divido entre " + temp+" es "+(a/temp)+ " y sobran "+b, ecuacion );
                a = temp;
                i++;
            }
            
        }
    }
}
