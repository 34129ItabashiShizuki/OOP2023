using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;
            var ima = DateTime.Now - dtp;

            tbMessage.Text = "生まれてから" + ima.Days + "日経過しました" ;
        }

        //現在時刻表示
        private void Form1_Load(object sender, EventArgs e) {
            var datetime = DateTime.Now;
            tbTime.Text = datetime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            tmTimeDisp.Start(); //タイマースタート
        }

        private void btAfterYear_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddYears(1);
            tbMessage.Text = dtpDate.Value.ToShortDateString();
        }

        private void btBeforeYear_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddYears(-1);
            tbMessage.Text = dtpDate.Value.ToShortDateString();
        }

        private void btAfterMonth_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddMonths(1);
            tbMessage.Text = dtpDate.Value.ToShortDateString();
        }

        private void btBeforeMonth_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddMonths(-1);
            tbMessage.Text = dtpDate.Value.ToShortDateString();
        }

        private void btAfterDay_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddDays(1);
            tbMessage.Text = dtpDate.Value.ToShortDateString();
        }

        private void btBeforeDay_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddDays(-1);
            tbMessage.Text = dtpDate.Value.ToShortDateString();
        }

        private void btAge_Click(object sender, EventArgs e) {
            var age = DateTime.Today.Year - dtpDate.Value.Year;
            //誕生日が来てるかcheckして-
            if (DateTime.Today < dtpDate.Value.AddYears(age)) {
                age--;
            }
            tbMessage.Text = age + "歳";
        }

        //タイマーイベントハンドラ
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            tbTime.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
        }
    }
}
