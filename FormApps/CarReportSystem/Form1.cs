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
            var carreport = new CarReport() {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarImage = pbCarImage.Image,
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Maker = setSelectedMaker(),
            };
            CarReports.Add(carreport);
        }

        private CarReport.MakerGroup setSelectedMaker() {
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked){
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;
            //if (rbDaihatu.Checked) {
            //    return CarReport.MakerGroup.ダイハツ;
            //}
            //else if (rbHonda.Checked) {
            //    return CarReport.MakerGroup.ホンダ;
            //}
            //else if (rbNissan.Checked) {
            //    return CarReport.MakerGroup.日産;
            //}
            //else if (rbSubaru.Checked) {
            //    return CarReport.MakerGroup.スバル;
            //}
            //else if (rbSuzuki.Checked) {
            //    return CarReport.MakerGroup.スズキ;
            //}
            //else if (rbToyota.Checked) {
            //    return CarReport.MakerGroup.トヨタ;
            //}
            //else if (rbImported.Checked) {
            //    return CarReport.MakerGroup.輸入車;
            //}
            //return CarReport.MakerGroup.その他;
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdimageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdimageFileOpen.FileName);
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false; //画像項目非表示
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--) {
                dgvCarReports.Rows.RemoveAt(src[i].Index);
            }
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[2].Value = setSelectedMaker();
            dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
        }

        private void dgvCarReports_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }

        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatu.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }
    }
}
