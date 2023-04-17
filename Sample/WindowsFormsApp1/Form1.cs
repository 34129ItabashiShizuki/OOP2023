using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            //tbAns.Text = ans.ToString();
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            tbAns.Text = sum.ToString();

        }

        //イベントハンドラ
        private void btPow_Click(object sender, EventArgs e) {

            //double result = Math.Pow((double)nudX.Value, (double)nudY.Value);
            //tbResult.Text = result.ToString();
            //１行
            //tbResult.Text = (Math.Pow((double)nudX.Value, (double)nudY.Value)).toString();
            int res = 1;
            
            for (int i = 0; i < nudY.Value; i++)
            {
                res *= (int)nudX.Value;
            }
            tbResult.Text = res.ToString();
        }

    }
}
