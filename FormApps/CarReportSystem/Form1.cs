using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //追加ボタンがクリックされた時のイベントハンドラ
        private void btAddReport_Click(object sender, EventArgs e) {
            var carreport = new CarReport();

            carreport.Date = dtpDate.Value;
            carreport.Author = cbAuthor.Text;
            carreport.CarImage = pbCarImage.Image;
            carreport.CarName = cbCarName.Text;
            carreport.Report = tbReport.Text;

            CarReports.Add(carreport);
        }

        //private CarReport.MakerGroup getSelectedMaker() {
        //    var gbMaker = new 
        //    return CarReport.MakerGroup.ダイハツ; 
        //}
    }
}
