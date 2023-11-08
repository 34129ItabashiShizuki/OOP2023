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

        private void FavReport_Click(object sender, EventArgs e) {
            //String url = FavReport.Items[FavReport.SelectIndex];
            wbBrowser.Url = new Uri(tbUrl.Text);
        }
    }
}
