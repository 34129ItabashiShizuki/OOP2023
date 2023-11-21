
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btBack = new System.Windows.Forms.Button();
            this.btGo = new System.Windows.Forms.Button();
            this.FavReport = new System.Windows.Forms.Button();
            this.rbFav1 = new System.Windows.Forms.RadioButton();
            this.rbFav2 = new System.Windows.Forms.RadioButton();
            this.rbFav3 = new System.Windows.Forms.RadioButton();
            this.rbFav4 = new System.Windows.Forms.RadioButton();
            this.gbFav = new System.Windows.Forms.GroupBox();
            this.cbFavList = new System.Windows.Forms.ComboBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.tbFavName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btFavDelete = new System.Windows.Forms.Button();
            this.gbFav.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(199, 29);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(572, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(777, 29);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(97, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(34, 81);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(943, 136);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(34, 237);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1248, 428);
            this.wbBrowser.TabIndex = 3;
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBack.Location = new System.Drawing.Point(34, 29);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(49, 31);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "←";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btGo
            // 
            this.btGo.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGo.Location = new System.Drawing.Point(89, 29);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(49, 31);
            this.btGo.TabIndex = 5;
            this.btGo.Text = "→";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // FavReport
            // 
            this.FavReport.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FavReport.Location = new System.Drawing.Point(1081, 128);
            this.FavReport.Name = "FavReport";
            this.FavReport.Size = new System.Drawing.Size(120, 31);
            this.FavReport.TabIndex = 6;
            this.FavReport.Text = "お気に入り登録";
            this.FavReport.UseVisualStyleBackColor = true;
            this.FavReport.Click += new System.EventHandler(this.FavReport_Click);
            // 
            // rbFav1
            // 
            this.rbFav1.AutoSize = true;
            this.rbFav1.Location = new System.Drawing.Point(17, 28);
            this.rbFav1.Name = "rbFav1";
            this.rbFav1.Size = new System.Drawing.Size(99, 17);
            this.rbFav1.TabIndex = 7;
            this.rbFav1.TabStop = true;
            this.rbFav1.Text = "文春オンライン";
            this.rbFav1.UseVisualStyleBackColor = true;
            this.rbFav1.CheckedChanged += new System.EventHandler(this.rbFav1_CheckedChanged);
            // 
            // rbFav2
            // 
            this.rbFav2.AutoSize = true;
            this.rbFav2.Location = new System.Drawing.Point(128, 28);
            this.rbFav2.Name = "rbFav2";
            this.rbFav2.Size = new System.Drawing.Size(107, 17);
            this.rbFav2.TabIndex = 8;
            this.rbFav2.TabStop = true;
            this.rbFav2.Text = "乗りものニュース";
            this.rbFav2.UseVisualStyleBackColor = true;
            this.rbFav2.CheckedChanged += new System.EventHandler(this.rbFav2_CheckedChanged);
            // 
            // rbFav3
            // 
            this.rbFav3.AutoSize = true;
            this.rbFav3.Location = new System.Drawing.Point(17, 63);
            this.rbFav3.Name = "rbFav3";
            this.rbFav3.Size = new System.Drawing.Size(87, 17);
            this.rbFav3.TabIndex = 9;
            this.rbFav3.TabStop = true;
            this.rbFav3.Text = "ねこのきもち";
            this.rbFav3.UseVisualStyleBackColor = true;
            this.rbFav3.CheckedChanged += new System.EventHandler(this.rbFav3_CheckedChanged);
            // 
            // rbFav4
            // 
            this.rbFav4.AutoSize = true;
            this.rbFav4.Location = new System.Drawing.Point(128, 63);
            this.rbFav4.Name = "rbFav4";
            this.rbFav4.Size = new System.Drawing.Size(87, 17);
            this.rbFav4.TabIndex = 10;
            this.rbFav4.TabStop = true;
            this.rbFav4.Text = "釣りビジョン ";
            this.rbFav4.UseVisualStyleBackColor = true;
            this.rbFav4.CheckedChanged += new System.EventHandler(this.rbFav4_CheckedChanged);
            // 
            // gbFav
            // 
            this.gbFav.Controls.Add(this.rbFav1);
            this.gbFav.Controls.Add(this.rbFav4);
            this.gbFav.Controls.Add(this.rbFav2);
            this.gbFav.Controls.Add(this.rbFav3);
            this.gbFav.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbFav.Location = new System.Drawing.Point(1014, 29);
            this.gbFav.Name = "gbFav";
            this.gbFav.Size = new System.Drawing.Size(268, 93);
            this.gbFav.TabIndex = 11;
            this.gbFav.TabStop = false;
            this.gbFav.Text = "トピックス一覧";
            // 
            // cbFavList
            // 
            this.cbFavList.FormattingEnabled = true;
            this.cbFavList.Location = new System.Drawing.Point(1013, 197);
            this.cbFavList.Name = "cbFavList";
            this.cbFavList.Size = new System.Drawing.Size(269, 20);
            this.cbFavList.TabIndex = 12;
            this.cbFavList.SelectedIndexChanged += new System.EventHandler(this.cbFavList_SelectedIndexChanged);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(880, 29);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(97, 31);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRefresh.Location = new System.Drawing.Point(144, 29);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(49, 31);
            this.btRefresh.TabIndex = 14;
            this.btRefresh.Text = "🔁";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // tbFavName
            // 
            this.tbFavName.Location = new System.Drawing.Point(1013, 172);
            this.tbFavName.Name = "tbFavName";
            this.tbFavName.Size = new System.Drawing.Size(269, 19);
            this.tbFavName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(994, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "名前を入力";
            // 
            // btFavDelete
            // 
            this.btFavDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFavDelete.Location = new System.Drawing.Point(1207, 128);
            this.btFavDelete.Name = "btFavDelete";
            this.btFavDelete.Size = new System.Drawing.Size(75, 31);
            this.btFavDelete.TabIndex = 17;
            this.btFavDelete.Text = "削除";
            this.btFavDelete.UseVisualStyleBackColor = true;
            this.btFavDelete.Click += new System.EventHandler(this.btFavDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 677);
            this.Controls.Add(this.btFavDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFavName);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.cbFavList);
            this.Controls.Add(this.gbFav);
            this.Controls.Add(this.FavReport);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "RssReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Load);
            this.gbFav.ResumeLayout(false);
            this.gbFav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Button FavReport;
        private System.Windows.Forms.RadioButton rbFav1;
        private System.Windows.Forms.RadioButton rbFav2;
        private System.Windows.Forms.RadioButton rbFav3;
        private System.Windows.Forms.RadioButton rbFav4;
        private System.Windows.Forms.GroupBox gbFav;
        private System.Windows.Forms.ComboBox cbFavList;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.TextBox tbFavName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFavDelete;
    }
}

