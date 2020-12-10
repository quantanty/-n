using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testing
{
    public class Brick
    {
        public class point
        {
            int x;
            int y;
            public point(int x,int y)
            {
                this.x = x;
                this.y = y;
            }
            public int X { get => x; }
            public int Y { get => y; }
        }
        int[,] hinhDang = new int[4, 4];
        private int trenCung = 3;
        public List<point> vienTrai = new List<point>();
        public List<point> vienPhai = new List<point>();
        public List<point> vienDuoi = new List<point>();
        public int[,] HinhDang
        {
            get => hinhDang;
        }
        public int TrenCung
        {
            get => trenCung;
        }
        public Brick(int kieu, int mau, int chieu)
        {
            int[,] goc = null;

            // cai dat hinh goc
            switch (kieu)
            {
                case 1:
                    int[,] goc1 = {
                        { 0,1,0,0},
                        { 0,1,0,0},
                        { 0,1,0,0},
                        { 0,1,0,0}
                    };
                    goc = goc1;
                    break;
                case 2:
                    int[,] goc2 = {
                        { 0,1,0,0},
                        { 0,1,0,0},
                        { 0,1,1,0},
                        { 0,0,0,0}
                    };
                    goc = goc2;
                    break;
                case 3:
                    int[,] goc3 = {
                        { 0,0,1,0},
                        { 0,0,1,0},
                        { 0,1,1,0},
                        { 0,0,0,0}
                    };
                    goc = goc3;
                    break;
                case 4:
                    int[,] goc4 = {
                        { 0,1,0,0},
                        { 0,1,1,0},
                        { 0,1,0,0},
                        { 0,0,0,0}
                    };
                    goc = goc4;
                    break;
                case 5:
                    int[,] goc5 = {
                        { 0,1,0,0},
                        { 0,1,1,0},
                        { 0,0,1,0},
                        { 0,0,0,0}
                    };
                    goc = goc5;
                    break;
                case 6:
                    int[,] goc6 = {
                        { 0,0,1,0},
                        { 0,1,1,0},
                        { 0,1,0,0},
                        { 0,0,0,0}
                    };
                    goc = goc6;
                    break;
                case 7:
                    int[,] goc7 = {
                        { 0,0,0,0},
                        { 0,1,1,0},
                        { 0,1,1,0},
                        { 0,0,0,0}
                    };
                    goc = goc7;
                    break;
                default:
                    break;
            }
            DatChieu datChieu = null;
            switch (chieu)
            {
                case 0:
                    datChieu = chieu0;
                    break;
                case 1:
                    datChieu = chieu1;
                    break;
                case 2:
                    datChieu = chieu2;
                    break;
                case 3:
                    datChieu = chieu3;
                    break;
                default:
                    break;
            }

            // cai dat hinh dang cuoi cung
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (goc[i, j] == 1)
                        datChieu(i, j, mau);
                    else
                        datChieu(i, j, 0);
                }
            }

            // xac dinh vien
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (hinhDang[i, j] != 0)
                    {
                        if (j < trenCung)
                            trenCung = j;
                        if (i == 0 || hinhDang[i - 1, j] == 0)
                            vienTrai.Add(new point(i, j));
                        if (i == 3 || hinhDang[i + 1, j] == 0)
                            vienPhai.Add(new point(i, j));
                        if (j == 3 || hinhDang[i, j + 1] == 0)
                            vienDuoi.Add(new point(i, j));
                    } 
                }
            }
        }
        private delegate void DatChieu(int x, int y,int giaTri);
        private void chieu0(int x, int y,int giaTri) //xoay phai 0 do
        {
            hinhDang[x, y] = giaTri;
        }
        private void chieu1(int x, int y, int giaTri) //xoay phai 90 do
        {
            hinhDang[3 - y, x] = giaTri;
        }
        private void chieu2(int x, int y, int giaTri) // xoay phai 180 do
        {
            hinhDang[3 - x, 3 - y] = giaTri;
        }
        private void chieu3(int x, int y, int giaTri) // xoay phai 269 do
        {
            hinhDang[y, 3 - x] = giaTri;
        }
    }
}