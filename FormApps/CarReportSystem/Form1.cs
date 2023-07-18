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

        //ステータスラベルのテキスト表示・非表示（引数なしはメッセージ非表示）
        private void statusLabelDisp(string msg = "") {
            //MessageBox.Show(msg);
            tsInfoText.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラ
        private void btAddReport_Click(object sender, EventArgs e) {

            if (cbAuthor.Text == "") {
                statusLabelDisp("記録者を入力してください");
                return;
            }
            else if (cbCarName.Text == "") {
                statusLabelDisp("車名を入力してください");
                return;
            }
            else {
                statusLabelDisp();
            }

            var carreport = new CarReport() {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                CarImage = pbCarImage.Image,
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Maker = getSelectedMaker(),
            };
            CarReports.Add(carreport);

            setCbAuthor(cbAuthor.Text); //記録者コンボボックスの履歴登録処理

            setCbCarName(cbCarName.Text);   //車名コンボボックスの履歴登録処理

            Clear();    //項目クリア処理
        }

        //記録者コンボボックスの履歴登録処理
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }

        //車名コンボボックスの履歴登録処理
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
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
            btModifyReport.Enabled = false; //修正ボタン無効
            btDeleteReport.Enabled = false; //削除ボタン無効
        }

        //削除ボタンイベントハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection src = dgvCarReports.SelectedRows;
            for (int i = src.Count - 1; i >= 0; i--) {
                dgvCarReports.Rows.RemoveAt(src[i].Index);
            }
            Clear();
        }

        //修正ボタンイベントハンドラ
        private void btModifyReport_Click(object sender, EventArgs e) {
            dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[2].Value = getSelectedMaker();
            dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;
            dgvCarReports.Refresh();    //一覧更新
        }

        //レコードの選択時
        private void dgvCarReports_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

            btModifyReport.Enabled = true;     //修正ボタン有効
            btDeleteReport.Enabled = true;     //削除ボタン有効
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

        //項目クリア処理
        private void Clear() {
            //cbAuthor.SelectedIndex = -1;
            //cbCarName.SelectedIndex = -1;
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;

            btModifyReport.Enabled = false; //マスクする
            btDeleteReport.Enabled = false;
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイヤログとして表示
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if(cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
            }
        }
    }
}
