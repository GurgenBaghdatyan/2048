
namespace _2048
{
    public partial class Form1 : Form
    {
        private int[,] map = new int[4, 4];
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(_keyboardEvent);
            map[0, 0] = 2;
        }
        

        private void _keyboardEvent(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    for (int i = 1; i < 4; i++)
                    {
                        if (map[0, i] == 0)
                        {
                            Part1.Location = new Point(Part1.Location.X + 56, Part1.Location.Y);

                        }

                    }
                    break;
            }
        }
    }
}