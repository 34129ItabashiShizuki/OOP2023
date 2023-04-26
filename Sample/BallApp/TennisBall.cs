﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class TennisBall : Obj {

        private static int count;

        public static int Count { get => count; set => count = value; }

        //コンストラクタ
        public TennisBall(double xp, double yp) : base(xp, yp, @"pic\tennis_ball.png") {

            Random random = new System.Random();
            int rndX = random.Next(-25, 25);
            MoveX = (rndX != 0 ? rndX : 1);   //乱数で移動量を設定

            int rndY = random.Next(-25, 25);
            MoveY = (rndY != 0 ? rndY : 1);   //乱数で移動量を設定
            Count++;
        }

        //メソッド
        public override void Move() {

            //Console.WriteLine("X座標 = {0},Y座標 = {1}", PosX, PosY);

            if (PosY > 500 || PosY < 0)
            {
                MoveY = -MoveY;
            }
            if (PosX > 730 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            PosX += MoveX;
            PosY += MoveY;
        }
    }
}
