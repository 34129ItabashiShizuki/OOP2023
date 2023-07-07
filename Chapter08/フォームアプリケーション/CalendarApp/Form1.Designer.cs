
namespace CalendarApp {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btBeforeYear = new System.Windows.Forms.Button();
            this.btAfterYear = new System.Windows.Forms.Button();
            this.btBeforeDay = new System.Windows.Forms.Button();
            this.btAfterDay = new System.Windows.Forms.Button();
            this.btBeforeMonth = new System.Windows.Forms.Button();
            this.btAfterMonth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.btAge = new System.Windows.Forms.Button();
            this.tmTimeDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(127, 15);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 28);
            this.dtpDate.TabIndex = 1;
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDayCalc.Location = new System.Drawing.Point(41, 130);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(165, 95);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMessage.Location = new System.Drawing.Point(41, 234);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(444, 216);
            this.tbMessage.TabIndex = 3;
            // 
            // btBeforeYear
            // 
            this.btBeforeYear.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBeforeYear.Location = new System.Drawing.Point(212, 179);
            this.btBeforeYear.Name = "btBeforeYear";
            this.btBeforeYear.Size = new System.Drawing.Size(87, 46);
            this.btBeforeYear.TabIndex = 4;
            this.btBeforeYear.Text = "-年";
            this.btBeforeYear.UseVisualStyleBackColor = true;
            this.btBeforeYear.Click += new System.EventHandler(this.btBeforeYear_Click);
            // 
            // btAfterYear
            // 
            this.btAfterYear.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAfterYear.Location = new System.Drawing.Point(212, 130);
            this.btAfterYear.Name = "btAfterYear";
            this.btAfterYear.Size = new System.Drawing.Size(87, 46);
            this.btAfterYear.TabIndex = 5;
            this.btAfterYear.Text = "+年";
            this.btAfterYear.UseVisualStyleBackColor = true;
            this.btAfterYear.Click += new System.EventHandler(this.btAfterYear_Click);
            // 
            // btBeforeDay
            // 
            this.btBeforeDay.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBeforeDay.Location = new System.Drawing.Point(398, 182);
            this.btBeforeDay.Name = "btBeforeDay";
            this.btBeforeDay.Size = new System.Drawing.Size(87, 46);
            this.btBeforeDay.TabIndex = 6;
            this.btBeforeDay.Text = "-日";
            this.btBeforeDay.UseVisualStyleBackColor = true;
            this.btBeforeDay.Click += new System.EventHandler(this.btBeforeDay_Click);
            // 
            // btAfterDay
            // 
            this.btAfterDay.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAfterDay.Location = new System.Drawing.Point(398, 130);
            this.btAfterDay.Name = "btAfterDay";
            this.btAfterDay.Size = new System.Drawing.Size(87, 46);
            this.btAfterDay.TabIndex = 7;
            this.btAfterDay.Text = "+日";
            this.btAfterDay.UseVisualStyleBackColor = true;
            this.btAfterDay.Click += new System.EventHandler(this.btAfterDay_Click);
            // 
            // btBeforeMonth
            // 
            this.btBeforeMonth.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBeforeMonth.Location = new System.Drawing.Point(305, 182);
            this.btBeforeMonth.Name = "btBeforeMonth";
            this.btBeforeMonth.Size = new System.Drawing.Size(87, 46);
            this.btBeforeMonth.TabIndex = 8;
            this.btBeforeMonth.Text = "-月";
            this.btBeforeMonth.UseVisualStyleBackColor = true;
            this.btBeforeMonth.Click += new System.EventHandler(this.btBeforeMonth_Click);
            // 
            // btAfterMonth
            // 
            this.btAfterMonth.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAfterMonth.Location = new System.Drawing.Point(305, 130);
            this.btAfterMonth.Name = "btAfterMonth";
            this.btAfterMonth.Size = new System.Drawing.Size(87, 46);
            this.btAfterMonth.TabIndex = 9;
            this.btAfterMonth.Text = "+月";
            this.btAfterMonth.UseVisualStyleBackColor = true;
            this.btAfterMonth.Click += new System.EventHandler(this.btAfterMonth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(529, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "現在時刻:";
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTime.Location = new System.Drawing.Point(685, 15);
            this.tbTime.Multiline = true;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(336, 29);
            this.tbTime.TabIndex = 11;
            // 
            // btAge
            // 
            this.btAge.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAge.Location = new System.Drawing.Point(526, 133);
            this.btAge.Name = "btAge";
            this.btAge.Size = new System.Drawing.Size(165, 95);
            this.btAge.TabIndex = 12;
            this.btAge.Text = "年齢";
            this.btAge.UseVisualStyleBackColor = true;
            this.btAge.Click += new System.EventHandler(this.btAge_Click);
            // 
            // tmTimeDisp
            // 
            this.tmTimeDisp.Interval = 500;
            this.tmTimeDisp.Tick += new System.EventHandler(this.tmTimeDisp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 570);
            this.Controls.Add(this.btAge);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAfterMonth);
            this.Controls.Add(this.btBeforeMonth);
            this.Controls.Add(this.btAfterDay);
            this.Controls.Add(this.btBeforeDay);
            this.Controls.Add(this.btAfterYear);
            this.Controls.Add(this.btBeforeYear);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "カレンダーアプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btBeforeYear;
        private System.Windows.Forms.Button btAfterYear;
        private System.Windows.Forms.Button btBeforeDay;
        private System.Windows.Forms.Button btAfterDay;
        private System.Windows.Forms.Button btBeforeMonth;
        private System.Windows.Forms.Button btAfterMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Button btAge;
        private System.Windows.Forms.Timer tmTimeDisp;
    }
}

