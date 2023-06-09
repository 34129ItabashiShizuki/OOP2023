﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    //抽象クラス
    abstract class Obj {

        //フィールド
        private Image image; //画像データ
        private double posX;  //x座標C
        private double posY;  //x座標C
        protected double moveX = 10.0;   //移動量(x方向)
        protected double moveY = 10.0;   //移動量(y方向)

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }
        public double MoveX { get => moveX; set => moveX = value; }
        public double MoveY { get => moveY; set => moveY = value; }


        //コンストラクタ
        public Obj(double PosX, double PosY,string Path) {
            this.posX = PosX;
            this.posY = PosY;
            Image = Image.FromFile(Path);

            //後ほど追加あり
        }

        //移動メソッド(抽象メソッド)
        public abstract void Move(PictureBox pbBar,PictureBox pbBall);
        public abstract void Move(Keys direction);
    }
}
