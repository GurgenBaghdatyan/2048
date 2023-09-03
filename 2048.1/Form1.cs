using System.IO;

namespace _2048._1
{
    public partial class Form1 : Form
    {
        public int[,] map = new int[4, 4];
        public bool move = false;
        public Random rnd1 = new Random();
        public Random rnd2 = new Random();
        public bool b = true;
        public int score = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(_keyboardEvent);
            map[0, 0] = 2;
        }
        private void _keyboardEvent(object? sender, KeyEventArgs e)
        {
            Elements Number0 = new Elements();
            Number0.number = 0;
            Number0.color = Color.White;
            Elements Number2 = new Elements();
            Number2.number = 2;
            Number2.color = Color.LightGreen;
            Elements Number4 = new Elements();
            Number4.number = 4;
            Number4.color = Color.LightBlue;
            Elements Number8 = new Elements();
            Number8.number = 8;
            Number8.color = Color.IndianRed;
            Elements Number16 = new Elements();
            Number16.number = 16;
            Number16.color = Color.LightPink;
            Elements Number32 = new Elements();
            Number32.number = 32;
            Number32.color = Color.LightSalmon;
            Elements Number64 = new Elements();
            Number64.number = 64;
            Number64.color = Color.LightSlateGray;
            Elements Number128 = new Elements();
            Number128.number = 128;
            Number128.color = Color.LightYellow;
            Elements Number256 = new Elements();
            Number256.number = 256;
            Number256.color = Color.LightCoral;
            Elements Number512 = new Elements();
            Number512.number = 512;
            Number512.color = Color.LightGray;
            Elements Number1024 = new Elements();
            Number1024.number = 1024;
            Number1024.color = Color.LightGoldenrodYellow;
            Elements Number2048 = new Elements();
            Number2048.number = 2048;
            Number2048.color = Color.Gold;
            b = true;
            switch (e.KeyCode.ToString())
            {
                
                case "Right":
                    move = false;
                    for (int i = 0; i < 4; i++)
                    {
                        if (map[3, i] == 0 && map[2, i] != 0)
                        {
                            map[3, i] = map[2, i];
                            map[2, i] = 0;
                            move = true;
                        }
                        if (map[3, i] == map[2, i] && map[2, i] != 0)
                        {
                            map[3, i] *= 2;
                            map[2, i] = 0;
                            move = true;
                            score += map[3, i];
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        if (map[2, i] == 0 && map[1, i] != 0)
                        {
                            map[2, i] = map[1, i];
                            map[1, i] = 0;
                            move = true;
                        }
                        if (map[2, i] == map[1, i] && map[1, i] != 0)
                        {
                            map[2, i] *= 2;
                            map[1, i] = 0;
                            move = true;
                            score += map[2, i];
                        }
                        if (map[3, i] == 0 && map[2, i] != 0)
                        {
                            map[3, i] = map[2, i];
                            map[2, i] = 0;
                            move = true;
                        }
                        if (map[3, i] == map[2, i] && map[2, i] != 0 )
                        {
                            map[3, i] *= 2;
                            map[2, i] = 0;
                            move = true;
                            score += map[2, i];
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        if (map[1, i] == 0 && map[0, i] != 0)
                        {
                            map[1, i] = map[0, i];
                            map[0, i] = 0;
                            move = true;
                        }
                        if (map[1, i] == map[0, i] && map[0, i] != 0)
                        {
                            map[1, i] *= 2;
                            map[0, i] = 0;
                            move = true;
                            score += map[1, i];
                        }
                        if (map[2, i] == 0 && map[1, i] != 0)
                        {
                            map[2, i] = map[1, i];
                            map[1, i] = 0;
                            move = true;

                        }
                        if (map[2, i] == map[1, i] && map[1, i] != 0)
                        {
                            map[2, i] *= 2;
                            map[1, i] = 0;
                            move = true;
                            score += map[2, i];
                        }
                        if (map[3, i] == 0 && map[2, i] != 0)
                        {
                            map[3, i] = map[2, i];
                            map[2, i] = 0;
                            move = true;
                        }
                        if (map[3, i] == map[2, i] && map[2, i] != 0)
                        {
                            map[3, i] *= 2;
                            map[2, i] = 0;
                            move = true;
                            score += map[3, i];
                        }
                    }
                    if (move)
                    {
                        while (b)
                        {
                            int x = rnd1.Next(0, 4);
                            int y = rnd2.Next(0, 4);
                            if (map[x, y] == 0)
                            {
                                map[x, y] = 2;
                                b = false;
                            }
                        }

                    }

                    break;



                case "Up":
                    move= false;
                    for (int i = 3; i >= 0; i--)
                    {
                        if (map[i, 0] == 0 && map[i, 1] != 0)
                        {
                            map[i, 0] = map[i, 1];
                            map[i, 1] = 0;
                            move = true;
                        }
                        if (map[i, 0] == map[i, 1] && map[i, 1] != 0)
                        {
                            map[i, 0] *= 2;
                            map[i, 1] = 0;
                            move = true;
                            score += map[i,0];
                        }
                    }
                    for (int i = 3; i >= 0; i--)
                    {
                        if (map[i, 1] == 0 && map[i, 2] != 0)
                        {
                            map[i, 1] = map[i, 2];
                            map[i, 2] = 0;
                            move = true;
                        }
                        if (map[i, 1] == map[i, 2] && map[i, 2] != 0)
                        {
                            map[i, 1] *= 2;
                            map[i, 2] = 0;
                            move = true;
                            score += map[i, 1];
                        }
                        if (map[i, 0] == 0 && map[i, 1] != 0)
                        {
                            map[i, 0] = map[i, 1];
                            map[i, 1] = 0;
                            move = true;
                        }
                        if (map[i, 0] == map[i, 1] && map[i, 1] != 0)
                        {
                            map[i, 0] *= 2;
                            map[i, 1] = 0;
                            move = true;
                            score += map[i, 0];
                        }
                    }
                    for (int i = 3; i >= 0; i--)
                    {
                        if (map[i, 2] == 0 && map[i, 3] != 0)
                        {
                            map[i, 2] = map[i, 3];
                            map[i, 3] = 0;
                            move = true;
                        }
                        if (map[i, 2] == map[i, 3] && map[i, 3] != 0)
                        {
                            map[i, 2] *= 2;
                            map[i, 3] = 0;
                            move = true;
                            score += map[i, 2];
                        }
                        if (map[i, 1] == 0 && map[i, 2] != 0)
                        {
                            map[i, 1] = map[i, 2];
                            map[i, 2] = 0;
                            move = true;
                        }
                        if (map[i, 1] == map[i, 2] && map[i, 2] != 0)
                        {
                            map[i, 1] *= 2;
                            map[i, 2] = 0;
                            move = true;
                            score += map[i, 1];
                        }
                        if (map[i, 0] == 0 && map[i, 1] != 0)
                        {
                            map[i, 0] = map[i, 1];
                            map[i, 1] = 0;
                            move = true;
                        }
                        if (map[i, 0] == map[i, 1] && map[i, 1] != 0)
                        {
                            map[i, 0] *= 2;
                            map[i, 1] = 0;
                            move = true;
                            score += map[i, 0];
                        }
                    }
                    if (move)
                    {
                        while (b)
                        {
                            int x = rnd1.Next(0, 4);
                            int y = rnd2.Next(0, 4);
                            if (map[x, y] == 0)
                            {
                                map[x, y] = 2;
                                b = false;
                            }
                        }

                    }
                    break;

                case "Down":
                    move = false;
                    for (int i = 0; i < 4; i++)
                    {
                        if (map[i, 3] == 0 && map[i, 2] != 0)
                        {
                            map[i, 3] = map[i, 2];
                            map[i, 2] = 0;
                            move = true;
                        }
                        if (map[i, 3] == map[i, 2] && map[i, 2] != 0)
                        {
                            map[i, 3] *= 2;
                            map[i, 2] = 0;
                            move = true;
                            score += map[i, 3];
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        if (map[i, 2] == 0 && map[i, 1] != 0)
                        {
                            map[i, 2] = map[i, 1];
                            map[i, 1] = 0;
                            move = true;
                            score += map[i, 2];
                        }
                        if (map[i, 2] == map[i, 1] && map[i, 1] != 0)
                        {
                            map[i, 2] *= 2;
                            map[i, 1] = 0;
                            move = true;
                            score += map[i, 2];
                        }
                        if (map[i, 3] == 0 && map[i, 2] != 0)
                        {
                            map[i, 3] = map[i, 2];
                            map[i, 2] = 0;
                            move = true;
                        }
                        if (map[i, 3] == map[i, 2] && map[i, 2] != 0)
                        {
                            map[i, 3] *= 2;
                            map[i, 2] = 0;
                            move = true;
                            score += map[i, 2];
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        if (map[i, 1] == 0 && map[i, 0] != 0)
                        {
                            map[i, 1] = map[i, 0];
                            map[i, 0] = 0;
                            move = true;
                        }
                        if (map[i, 1] == map[i, 0] && map[i, 0] != 0)
                        {
                            map[i, 1] *= 2;
                            map[i, 0] = 0;
                            move = true;
                            score += map[i, 1];
                        }
                        if (map[i, 2] == 0 && map[i, 1] != 0)
                        {
                            map[i, 2] = map[i, 1];
                            map[i, 1] = 0;
                            move = true;
                        }
                        if (map[i, 2] == map[i, 1] && map[i, 1] != 0)
                        {
                            map[i, 2] *= 2;
                            map[i, 1] = 0;
                            move = true;
                            score += map[i, 2];
                        }
                        if (map[i, 3] == 0 && map[i, 2] != 0)
                        {
                            map[i, 3] = map[i, 2];
                            map[i, 2] = 0;
                            move = true;
                        }
                        if (map[i, 3] == map[i, 2] && map[i, 2] != 0)
                        {
                            map[i, 3] *= 2;
                            map[i, 2] = 0;
                            move = true;
                            score += map[i, 3];
                        }
                    }
                    if (move)
                    {
                        while (b)
                        {
                            int x = rnd1.Next(0, 4);
                            int y = rnd2.Next(0, 4);
                            if (map[x, y] == 0)
                            {
                                map[x, y] = 2;
                                b = false;
                            }
                        }
                    }
                    break;

                case "Left":
                    move= false;
                    for (int i = 3; i >= 0; i--)
                    {
                        if (map[0, i] == 0 && map[1, i] != 0)
                        {
                            map[0, i] = map[1, i];
                            map[1, i] = 0;
                            move = true;
                        }
                        if (map[0, i] == map[1, i] && map[1, i] != 0)
                        {
                            map[0, i] *= 2;
                            map[1, i] = 0;
                            move = true;
                            score += map[0,i];
                        }
                    }
                    for (int i = 3; i >= 0; i--)
                    {
                        if (map[1, i] == 0 && map[2, i] != 0)
                        {
                            map[1, i] = map[2, i];
                            map[2, i] = 0;
                            move = true;
                        }
                        if (map[1, i] == map[2, i] && map[2, i] != 0)
                        {
                            map[1, i] *= 2;
                            map[2, i] = 0;
                            move = true;
                            score += map[1, i];
                        }
                        if (map[0, i] == 0 && map[1, i] != 0)
                        {
                            map[0, i] = map[1, i];
                            map[1, i] = 0;
                            move = true;
                        }
                        if (map[0, i] == map[1, i] && map[1, i] != 0)
                        {
                            map[0, i] *= 2;
                            map[1, i] = 0;
                            move = true;
                            score += map[0, i];
                        }
                    }
                    for (int i = 3; i >= 0; i--)
                    {
                        if (map[2, i] == 0 && map[3, i] != 0)
                        {
                            map[2, i] = map[3, i];
                            map[3, i] = 0;
                            move = true;
                        }
                        if (map[2, i] == map[3, i] && map[3, i] != 0)
                        {
                            map[2, i] *= 2;
                            map[3, i] = 0;
                            move = true;
                            score += map[2, i];
                        }
                        if (map[1, i] == 0 && map[2, i] != 0)
                        {
                            map[1, i] = map[2, i];
                            map[2, i] = 0;
                            move = true;
                        }
                        if (map[1, i] == map[2, i] && map[2, i] != 0)
                        {
                            map[1, i] *= 2;
                            map[2, i] = 0;
                            move = true;
                            score += map[1, i];
                        }
                        if (map[0, i] == 0 && map[1, i] != 0)
                        {
                            map[0, i] = map[1, i];
                            map[1, i] = 0;
                            move = true;
                        }
                        if (map[0, i] == map[1, i] && map[1, i] != 0)
                        {
                            map[0, i] *= 2;
                            map[1, i] = 0;
                            move = true;
                            score += map[0, i];
                        }
                    }
                    if (move)
                    {
                        while (b)
                        {
                            int x = rnd1.Next(0, 4);
                            int y = rnd2.Next(0, 4);
                            if (map[x, y] == 0)
                            {
                                map[x, y] = 2;
                                b = false;
                            }
                        }

                    }
                    break;
            }





            switch (map[0, 0])
            {
                case 0:
                    Element0_0.Text = "";
                    Element0_0.BackColor = Number0.color;
                    break;
                case 2:
                    Element0_0.Text = "2";
                    Element0_0.BackColor = Number2.color;
                    break;
                case 4:
                    Element0_0.Text = "4";
                    Element0_0.BackColor = Number4.color;
                    break;
                case 8:
                    Element0_0.Text = "8";
                    Element0_0.BackColor = Number8.color;
                    break;
                case 16:
                    Element0_0.Text = "16";
                    Element0_0.BackColor = Number16.color;
                    break;
                case 32:
                    Element0_0.Text = "32";
                    Element0_0.BackColor = Number32.color;
                    break;
                case 64:
                    Element0_0.Text = "64";
                    Element0_0.BackColor = Number64.color;
                    break;
                case 128:
                    Element0_0.Text = "128";
                    Element0_0.BackColor = Number128.color;
                    break;
                case 256:
                    Element0_0.Text = "256";
                    Element0_0.BackColor = Number256.color;
                    break;
                case 512:
                    Element0_0.Text = "512";
                    Element0_0.BackColor = Number512.color;
                    break;
                case 1024:
                    Element0_0.Text = "1024";
                    Element0_0.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element0_0.Text = "2048";
                    Element0_0.BackColor = Number2048.color;
                    break;
            }
            switch (map[0, 1])
            {
                case 0:
                    Element0_1.Text = "";
                    Element0_1.BackColor = Number0.color;
                    break;
                case 2:
                    Element0_1.Text = "2";
                    Element0_1.BackColor = Number2.color;
                    break;
                case 4:
                    Element0_1.Text = "4";
                    Element0_1.BackColor = Number4.color;
                    break;
                case 8:
                    Element0_1.Text = "8";
                    Element0_1.BackColor = Number8.color;
                    break;
                case 16:
                    Element0_1.Text = "16";
                    Element0_1.BackColor = Number16.color;
                    break;
                case 32:
                    Element0_1.Text = "32";
                    Element0_1.BackColor = Number32.color;
                    break;
                case 64:
                    Element0_1.Text = "64";
                    Element0_1.BackColor = Number64.color;
                    break;
                case 128:
                    Element0_1.Text = "128";
                    Element0_1.BackColor = Number128.color;
                    break;
                case 256:
                    Element0_1.Text = "256";
                    Element0_1.BackColor = Number256.color;
                    break;
                case 512:
                    Element0_1.Text = "512";
                    Element0_1.BackColor = Number512.color;
                    break;
                case 1024:
                    Element0_1.Text = "1024";
                    Element0_1.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element0_1.Text = "2048";
                    Element0_1.BackColor = Number2048.color;
                    break;

            }
            switch (map[0, 2])
            {
                case 0:
                    Element0_2.Text = "";
                    Element0_2.BackColor = Number0.color;
                    break;
                case 2:
                    Element0_2.Text = "2";
                    Element0_2.BackColor = Number2.color;
                    break;
                case 4:
                    Element0_2.Text = "4";
                    Element0_2.BackColor = Number4.color;
                    break;
                case 8:
                    Element0_2.Text = "8";
                    Element0_2.BackColor = Number8.color;
                    break;
                case 16:
                    Element0_2.Text = "16";
                    Element0_2.BackColor = Number16.color;
                    break;
                case 32:
                    Element0_2.Text = "32";
                    Element0_2.BackColor = Number32.color;
                    break;
                case 64:
                    Element0_2.Text = "64";
                    Element0_2.BackColor = Number64.color;
                    break;
                case 128:
                    Element0_2.Text = "128";
                    Element0_2.BackColor = Number128.color;
                    break;
                case 256:
                    Element0_2.Text = "256";
                    Element0_2.BackColor = Number256.color;
                    break;
                case 512:
                    Element0_2.Text = "512";
                    Element0_2.BackColor = Number512.color;
                    break;
                case 1024:
                    Element0_2.Text = "1024";
                    Element0_2.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element0_2.Text = "2048";
                    Element0_2.BackColor = Number2048.color;
                    break;
            }
            switch (map[0, 3])
            {
                case 0:
                    Element0_3.Text = "";
                    Element0_3.BackColor = Number0.color;
                    break;
                case 2:
                    Element0_3.Text = "2";
                    Element0_3.BackColor = Number2.color;
                    break;
                case 4:
                    Element0_3.Text = "4";
                    Element0_3.BackColor = Number4.color;
                    break;
                case 8:
                    Element0_3.Text = "8";
                    Element0_3.BackColor = Number8.color;
                    break;
                case 16:
                    Element0_3.Text = "16";
                    Element0_3.BackColor = Number16.color;
                    break;
                case 32:
                    Element0_3.Text = "32";
                    Element0_3.BackColor = Number32.color;
                    break;
                case 64:
                    Element0_3.Text = "64";
                    Element0_3.BackColor = Number64.color;
                    break;
                case 128:
                    Element0_3.Text = "128";
                    Element0_3.BackColor = Number128.color;
                    break;
                case 256:
                    Element0_3.Text = "256";
                    Element0_3.BackColor = Number256.color;
                    break;
                case 512:
                    Element0_3.Text = "512";
                    Element0_3.BackColor = Number512.color;
                    break;
                case 1024:
                    Element0_3.Text = "1024";
                    Element0_3.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element0_3.Text = "2048";
                    Element0_3.BackColor = Number2048.color;
                    break;
            }
            switch (map[1, 0])
            {
                case 0:
                    Element1_0.Text = "";
                    Element1_0.BackColor = Number0.color;
                    break;
                case 2:
                    Element1_0.Text = "2";
                    Element1_0.BackColor = Number2.color;
                    break;
                case 4:
                    Element1_0.Text = "4";
                    Element1_0.BackColor = Number4.color;
                    break;
                case 8:
                    Element1_0.Text = "8";
                    Element1_0.BackColor = Number8.color;
                    break;
                case 16:
                    Element1_0.Text = "16";
                    Element1_0.BackColor = Number16.color;
                    break;
                case 32:
                    Element1_0.Text = "32";
                    Element1_0.BackColor = Number32.color;
                    break;
                case 64:
                    Element1_0.Text = "64";
                    Element1_0.BackColor = Number64.color;
                    break;
                case 128:
                    Element1_0.Text = "128";
                    Element1_0.BackColor = Number128.color;
                    break;
                case 256:
                    Element1_0.Text = "256";
                    Element1_0.BackColor = Number256.color;
                    break;
                case 512:
                    Element1_0.Text = "512";
                    Element1_0.BackColor = Number512.color;
                    break;
                case 1024:
                    Element1_0.Text = "1024";
                    Element1_0.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element1_0.Text = "2048";
                    Element1_0.BackColor = Number2048.color;
                    break;
            }
            switch (map[1, 1])
            {
                case 0:
                    Element1_1.Text = "";
                    Element1_1.BackColor = Number0.color;
                    break;
                case 2:
                    Element1_1.Text = "2";
                    Element1_1.BackColor = Number2.color;
                    break;
                case 4:
                    Element1_1.Text = "4";
                    Element1_1.BackColor = Number4.color;
                    break;
                case 8:
                    Element1_1.Text = "8";
                    Element1_1.BackColor = Number8.color;
                    break;
                case 16:
                    Element1_1.Text = "16";
                    Element1_1.BackColor = Number16.color;
                    break;
                case 32:
                    Element1_1.Text = "32";
                    Element1_1.BackColor = Number32.color;
                    break;
                case 64:
                    Element1_1.Text = "64";
                    Element1_1.BackColor = Number64.color;
                    break;
                case 128:
                    Element1_1.Text = "128";
                    Element1_1.BackColor = Number128.color;
                    break;
                case 256:
                    Element1_1.Text = "256";
                    Element1_1.BackColor = Number256.color;
                    break;
                case 512:
                    Element1_1.Text = "512";
                    Element1_1.BackColor = Number512.color;
                    break;
                case 1024:
                    Element1_1.Text = "1024";
                    Element1_1.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element1_1.Text = "2048";
                    Element1_1.BackColor = Number2048.color;
                    break;

            }
            switch (map[1, 2])
            {
                case 0:
                    Element1_2.Text = "";
                    Element1_2.BackColor = Number0.color;
                    break;
                case 2:
                    Element1_2.Text = "2";
                    Element1_2.BackColor = Number2.color;
                    break;
                case 4:
                    Element1_2.Text = "4";
                    Element1_2.BackColor = Number4.color;
                    break;
                case 8:
                    Element1_2.Text = "8";
                    Element1_2.BackColor = Number8.color;
                    break;
                case 16:
                    Element1_2.Text = "16";
                    Element1_2.BackColor = Number16.color;
                    break;
                case 32:
                    Element1_2.Text = "32";
                    Element1_2.BackColor = Number32.color;
                    break;
                case 64:
                    Element1_2.Text = "64";
                    Element1_2.BackColor = Number64.color;
                    break;
                case 128:
                    Element1_2.Text = "128";
                    Element1_2.BackColor = Number128.color;
                    break;
                case 256:
                    Element1_2.Text = "256";
                    Element1_2.BackColor = Number256.color;
                    break;
                case 512:
                    Element1_2.Text = "512";
                    Element1_2.BackColor = Number512.color;
                    break;
                case 1024:
                    Element1_2.Text = "1024";
                    Element1_2.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element1_2.Text = "2048";
                    Element1_2.BackColor = Number2048.color;
                    break;
            }
            switch (map[1, 3])
            {
                case 0:
                    Element1_3.Text = "";
                    Element1_3.BackColor = Number0.color;
                    break;
                case 2:
                    Element1_3.Text = "2";
                    Element1_3.BackColor = Number2.color;
                    break;
                case 4:
                    Element1_3.Text = "4";
                    Element1_3.BackColor = Number4.color;
                    break;
                case 8:
                    Element1_3.Text = "8";
                    Element1_3.BackColor = Number8.color;
                    break;
                case 16:
                    Element1_3.Text = "16";
                    Element1_3.BackColor = Number16.color;
                    break;
                case 32:
                    Element1_3.Text = "32";
                    Element1_3.BackColor = Number32.color;
                    break;
                case 64:
                    Element1_3.Text = "64";
                    Element1_3.BackColor = Number64.color;
                    break;
                case 128:
                    Element1_3.Text = "128";
                    Element1_3.BackColor = Number128.color;
                    break;
                case 256:
                    Element1_3.Text = "256";
                    Element1_3.BackColor = Number256.color;
                    break;
                case 512:
                    Element1_3.Text = "512";
                    Element1_3.BackColor = Number512.color;
                    break;
                case 1024:
                    Element1_3.Text = "1024";
                    Element1_3.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element1_3.Text = "2048";
                    Element1_3.BackColor = Number2048.color;
                    break;
            }
            switch (map[2, 0])
            {
                case 0:
                    Element2_0.Text = "";
                    Element2_0.BackColor = Number0.color;
                    break;
                case 2:
                    Element2_0.Text = "2";
                    Element2_0.BackColor = Number2.color;
                    break;
                case 4:
                    Element2_0.Text = "4";
                    Element2_0.BackColor = Number4.color;
                    break;
                case 8:
                    Element2_0.Text = "8";
                    Element2_0.BackColor = Number8.color;
                    break;
                case 16:
                    Element2_0.Text = "16";
                    Element2_0.BackColor = Number16.color;
                    break;
                case 32:
                    Element2_0.Text = "32";
                    Element2_0.BackColor = Number32.color;
                    break;
                case 64:
                    Element2_0.Text = "64";
                    Element2_0.BackColor = Number64.color;
                    break;
                case 128:
                    Element2_0.Text = "128";
                    Element2_0.BackColor = Number128.color;
                    break;
                case 256:
                    Element2_0.Text = "256";
                    Element2_0.BackColor = Number256.color;
                    break;
                case 512:
                    Element2_0.Text = "512";
                    Element2_0.BackColor = Number512.color;
                    break;
                case 1024:
                    Element2_0.Text = "1024";
                    Element2_0.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element2_0.Text = "2048";
                    Element2_0.BackColor = Number2048.color;
                    break;
            }
            switch (map[2, 1])
            {
                case 0:
                    Element2_1.Text = "";
                    Element2_1.BackColor = Number0.color;
                    break;
                case 2:
                    Element2_1.Text = "2";
                    Element2_1.BackColor = Number2.color;
                    break;
                case 4:
                    Element2_1.Text = "4";
                    Element2_1.BackColor = Number4.color;
                    break;
                case 8:
                    Element2_1.Text = "8";
                    Element2_1.BackColor = Number8.color;
                    break;
                case 16:
                    Element2_1.Text = "16";
                    Element2_1.BackColor = Number16.color;
                    break;
                case 32:
                    Element2_1.Text = "32";
                    Element2_1.BackColor = Number32.color;
                    break;
                case 64:
                    Element2_1.Text = "64";
                    Element2_1.BackColor = Number64.color;
                    break;
                case 128:
                    Element2_1.Text = "128";
                    Element2_1.BackColor = Number128.color;
                    break;
                case 256:
                    Element2_1.Text = "256";
                    Element2_1.BackColor = Number256.color;
                    break;
                case 512:
                    Element2_1.Text = "512";
                    Element2_1.BackColor = Number512.color;
                    break;
                case 1024:
                    Element2_1.Text = "1024";
                    Element2_1.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element2_1.Text = "2048";
                    Element2_1.BackColor = Number2048.color;
                    break;

            }
            switch (map[2, 2])
            {
                case 0:
                    Element2_2.Text = "";
                    Element2_2.BackColor = Number0.color;
                    break;
                case 2:
                    Element2_2.Text = "2";
                    Element2_2.BackColor = Number2.color;
                    break;
                case 4:
                    Element2_2.Text = "4";
                    Element2_2.BackColor = Number4.color;
                    break;
                case 8:
                    Element2_2.Text = "8";
                    Element2_2.BackColor = Number8.color;
                    break;
                case 16:
                    Element2_2.Text = "16";
                    Element2_2.BackColor = Number16.color;
                    break;
                case 32:
                    Element2_2.Text = "32";
                    Element2_2.BackColor = Number32.color;
                    break;
                case 64:
                    Element2_2.Text = "64";
                    Element2_2.BackColor = Number64.color;
                    break;
                case 128:
                    Element2_2.Text = "128";
                    Element2_2.BackColor = Number128.color;
                    break;
                case 256:
                    Element2_2.Text = "256";
                    Element2_2.BackColor = Number256.color;
                    break;
                case 512:
                    Element2_2.Text = "512";
                    Element2_2.BackColor = Number512.color;
                    break;
                case 1024:
                    Element2_2.Text = "1024";
                    Element2_2.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element2_2.Text = "2048";
                    Element2_2.BackColor = Number2048.color;
                    break;
            }
            switch (map[2, 3])
            {
                case 0:
                    Element2_3.Text = "";
                    Element2_3.BackColor = Number0.color;
                    break;
                case 2:
                    Element2_3.Text = "2";
                    Element2_3.BackColor = Number2.color;
                    break;
                case 4:
                    Element2_3.Text = "4";
                    Element2_3.BackColor = Number4.color;
                    break;
                case 8:
                    Element2_3.Text = "8";
                    Element2_3.BackColor = Number8.color;
                    break;
                case 16:
                    Element2_3.Text = "16";
                    Element2_3.BackColor = Number16.color;
                    break;
                case 32:
                    Element2_3.Text = "32";
                    Element2_3.BackColor = Number32.color;
                    break;
                case 64:
                    Element2_3.Text = "64";
                    Element2_3.BackColor = Number64.color;
                    break;
                case 128:
                    Element2_3.Text = "128";
                    Element2_3.BackColor = Number128.color;
                    break;
                case 256:
                    Element2_3.Text = "256";
                    Element2_3.BackColor = Number256.color;
                    break;
                case 512:
                    Element2_3.Text = "512";
                    Element2_3.BackColor = Number512.color;
                    break;
                case 1024:
                    Element2_3.Text = "1024";
                    Element2_3.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element2_3.Text = "2048";
                    Element2_3.BackColor = Number2048.color;
                    break;
            }
            switch (map[3, 0])
            {
                case 0:
                    Element3_0.Text = "";
                    Element3_0.BackColor = Number0.color;
                    break;
                case 2:
                    Element3_0.Text = "2";
                    Element3_0.BackColor = Number2.color;
                    break;
                case 4:
                    Element3_0.Text = "4";
                    Element3_0.BackColor = Number4.color;
                    break;
                case 8:
                    Element3_0.Text = "8";
                    Element3_0.BackColor = Number8.color;
                    break;
                case 16:
                    Element3_0.Text = "16";
                    Element3_0.BackColor = Number16.color;
                    break;
                case 32:
                    Element3_0.Text = "32";
                    Element3_0.BackColor = Number32.color;
                    break;
                case 64:
                    Element3_0.Text = "64";
                    Element3_0.BackColor = Number64.color;
                    break;
                case 128:
                    Element3_0.Text = "128";
                    Element3_0.BackColor = Number128.color;
                    break;
                case 256:
                    Element3_0.Text = "256";
                    Element3_0.BackColor = Number256.color;
                    break;
                case 512:
                    Element3_0.Text = "512";
                    Element3_0.BackColor = Number512.color;
                    break;
                case 1024:
                    Element3_0.Text = "1024";
                    Element3_0.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element3_0.Text = "2048";
                    Element3_0.BackColor = Number2048.color;
                    break;
            }
            switch (map[3, 1])
            {
                case 0:
                    Element3_1.Text = "";
                    Element3_1.BackColor = Number0.color;

                    break;
                case 2:
                    Element3_1.Text = "2";
                    Element3_1.BackColor = Number2.color;
                    break;
                case 4:
                    Element3_1.Text = "4";
                    Element3_1.BackColor = Number4.color;
                    break;
                case 8:
                    Element3_1.Text = "8";
                    Element3_1.BackColor = Number8.color;
                    break;
                case 16:
                    Element3_1.Text = "16";
                    Element3_1.BackColor = Number16.color;
                    break;
                case 32:
                    Element3_1.Text = "32";
                    Element3_1.BackColor = Number32.color;
                    break;
                case 64:
                    Element3_1.Text = "64";
                    Element3_1.BackColor = Number64.color;
                    break;
                case 128:
                    Element3_1.Text = "128";
                    Element3_1.BackColor = Number128.color;
                    break;
                case 256:
                    Element3_1.Text = "256";
                    Element3_1.BackColor = Number256.color;
                    break;
                case 512:
                    Element3_1.Text = "512";
                    Element3_1.BackColor = Number512.color;
                    break;
                case 1024:
                    Element3_1.Text = "1024";
                    Element3_1.BackColor = Number1024.color;
                    break;
                case 2048:
                    Element3_1.Text = "2048";
                    Element3_1.BackColor = Number2048.color;
                    break;

            }
            switch (map[3, 2])
            {
                case 0:
                    Element3_2.BackColor = Number0.color;
                    Element3_2.Text = "";
                    break;
                case 2:
                    Element3_2.BackColor = Number2.color;
                    Element3_2.Text = "2";
                    break;
                case 4:
                    Element3_2.BackColor = Number4.color;
                    Element3_2.Text = "4";
                    break;
                case 8:
                    Element3_2.BackColor = Number8.color;
                    Element3_2.Text = "8";
                    break;
                case 16:
                    Element3_2.BackColor = Number16.color;
                    Element3_2.Text = "16";
                    break;
                case 32:
                    Element3_2.BackColor = Number32.color;
                    Element3_2.Text = "32";
                    break;
                case 64:
                    Element3_2.BackColor = Number64.color;
                    Element3_2.Text = "64";
                    break;
                case 128:
                    Element3_2.BackColor = Number128.color;
                    Element3_2.Text = "128";
                    break;
                case 256:
                    Element3_2.BackColor = Number256.color;
                    Element3_2.Text = "256";
                    break;
                case 512:
                    Element3_2.BackColor = Number512.color;
                    Element3_2.Text = "512";
                    break;
                case 1024:
                    Element3_2.BackColor = Number1024.color;
                    Element3_2.Text = "1024";
                    break;
                case 2048:
                    Element3_2.BackColor = Number2048.color;
                    Element3_2.Text = "2048";
                    break;
            }
            switch (map[3, 3])
            {
                case 0:
                    Element3_3.Text = "";
                    Element3_3.BackColor = Number0.color;
                    break;
                case 2:
                    Element3_3.BackColor = Number2.color;
                    Element3_3.Text = "2";
                    break;
                case 4:
                    Element3_3.BackColor = Number4.color;
                    Element3_3.Text = "4";
                    break;
                case 8:
                    Element3_3.BackColor = Number8.color;
                    Element3_3.Text = "8";
                    break;
                case 16:
                    Element3_3.BackColor = Number16.color;
                    Element3_3.Text = "16";
                    break;
                case 32:
                    Element3_3.BackColor = Number32.color;
                    Element3_3.Text = "32";
                    break;
                case 64:
                    Element3_3.BackColor = Number64.color;
                    Element3_3.Text = "64";
                    break;
                case 128:
                    Element3_3.BackColor = Number128.color;
                    Element3_3.Text = "128";
                    break;
                case 256:
                    Element3_3.BackColor = Number256.color;
                    Element3_3.Text = "256";
                    break;
                case 512:
                    Element3_3.BackColor = Number512.color;
                    Element3_3.Text = "512";
                    break;
                case 1024:
                    Element3_3.BackColor = Number1024.color;
                    Element3_3.Text = "1024";
                    break;
                case 2048:
                    Element3_3.BackColor = Number2048.color;
                    Element3_3.Text = "2048";
                    break;
            }

            label1.Text = $"Score: {score}";







        }
        public class Elements
        {
            public int number;
            public Color color;
        }

        private void Element0_0_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}