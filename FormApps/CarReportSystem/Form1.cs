using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private uint mode;
        //設定保存用情報オブジェクト
        Settings settings = new Settings();
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
            if (ofdimageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdimageFileOpen.FileName);
                btImageDelete.Enabled = true;
                btScaleChange.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false; //画像項目非表示
            btModifyReport.Enabled = false; //修正ボタン無効
            btDeleteReport.Enabled = false; //削除ボタン無効
            btImageDelete.Enabled = false;
            btScaleChange.Enabled = false;
            tsInfoText.Text = " "; //情報表示領域のテキストを初期化
            //tsTimeDisp.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            tsTimeDisp.BackColor = Color.Black;
            tsTimeDisp.ForeColor = Color.White;
            tmTimeUpdate.Start(); //時刻更新用のタイマー

            //設定ファイルを逆シリアル化して背景を設定
            using (var reader = XmlReader.Create("settings.xml")) {
                var serializer = new XmlSerializer(typeof(Settings));
                settings = serializer.Deserialize(reader) as Settings;
                BackColor = Color.FromArgb(settings.MainFormColor);
            }
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
            if (dgvCarReports.RowCount != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

                btModifyReport.Enabled = true;     //修正ボタン有効
                btDeleteReport.Enabled = true;     //削除ボタン有効
            }
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
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;

            btModifyReport.Enabled = false; //マスクする
            btDeleteReport.Enabled = false;
            //btImageDelete.Enabled = false;  
            //btScaleChange.Enabled = false;
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if(cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            mode = mode < 4 ? ((mode == 1) ? 3 : ++mode) : 0;   //AutoSize(2)を除外
            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
        }

        private void バージョン情報ToolStripMenuItem_Click_1(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイヤログとして表示
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            //設定ファイルのシリアル化
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void tmTimeUpdate_Tick(object sender, EventArgs e) {
            tsTimeDisp.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH時mm分ss秒");
        }
    }
}
