using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        //取得データ保存用
        List<ItemData> ItemDatas = new　List<ItemData>();
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.Text == "") {
                return;
            }
            lbRssTitle.Items.Clear();
            using(var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                ItemDatas = xdoc.Root.Descendants("item")
                                                .Select(x => new ItemData {
                                                    Title = (string)x.Element("title"),
                                                    Link = (string)x.Element("link")
                                                }).ToList();

                foreach (var item in ItemDatas) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        public void BtGet() {
            if (tbUrl.Text == "") {
                return;
            }
            lbRssTitle.Items.Clear();
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                ItemDatas = xdoc.Root.Descendants("item")
                                                .Select(x => new ItemData {
                                                    Title = (string)x.Element("title"),
                                                    Link = (string)x.Element("link")
                                                }).ToList();

                foreach (var item in ItemDatas) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            var indexnum = lbRssTitle.SelectedIndex;
            wbBrowser.Navigate(ItemDatas[indexnum].Link);
        }

        private void btBack_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }

        private void btGo_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e) {
            

        }

        private void rbFav1_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/bunshun/all.xml";
            BtGet();
        }

        private void rbFav2_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/norimono/all.xml";
            BtGet();
        }

        private void rbFav3_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/nekomag/all.xml";
            BtGet();
        }

        private void rbFav4_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/fvision/all.xml";
            BtGet();
        }

        private void FavReport_Click(object sender, EventArgs e) {
            try {
                FavData favData = new FavData(ItemDatas[lbRssTitle.SelectedIndex].Link, tbFavName.Text);
                cbFavList.Items.Add(favData);
                tbFavName.Text = "";
            }
            catch (System.ArgumentOutOfRangeException) {
                return;
            }
            
        }

        private void cbFavList_SelectedIndexChanged(object sender, EventArgs e) {
            FavData favData = (FavData)cbFavList.SelectedItem;
            wbBrowser.Navigate(favData.Link);
        }

        private void btClear_Click(object sender, EventArgs e) {
            tbUrl.Text = "";
            cbFavList.Text = "";
            lbRssTitle.Items.Clear();
            wbBrowser.DocumentText = "";
            cbFavList.Items.Clear();
        }

        private void btRefresh_Click(object sender, EventArgs e) {
            wbBrowser.Refresh();
        }

        private void btFavDelete_Click(object sender, EventArgs e) {
            try {
                cbFavList.Items.RemoveAt(cbFavList.SelectedIndex);
            }
            catch (System.ArgumentOutOfRangeException) {
                return;
            }
        }
        //ラジオボタン選択解除
    }
}
