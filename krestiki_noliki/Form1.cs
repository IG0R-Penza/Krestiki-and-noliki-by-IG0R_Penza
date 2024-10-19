using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace krestiki_noliki
{
    public partial class Form1 : Form
    {
        private string move(int x, int y)
        {
            if (DataBank.Field[x, y] == "")
            {
                DataBank.Field[x, y] = DataBank.Figure[DataBank.Move % 2];
                DataBank.Move += 1;
                message.Text = "Ходит " + DataBank.Figure[DataBank.Move % 2];
                return DataBank.Field[x, y];
            }
            else { return DataBank.Field[x, y]; }
        }
        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e) { }

        private void button00_Click(object sender, EventArgs e) { button00.Text = move(0, 0); }
        private void button01_Click(object sender, EventArgs e) { button01.Text = move(0, 1); }
        private void button02_Click(object sender, EventArgs e) { button02.Text = move(0, 2); }
        private void button10_Click(object sender, EventArgs e) { button10.Text = move(1, 0); }
        private void button11_Click(object sender, EventArgs e) { button11.Text = move(1, 1); }
        private void button12_Click(object sender, EventArgs e) { button12.Text = move(1, 2); }
        private void button20_Click(object sender, EventArgs e) { button20.Text = move(2, 0); }
        private void button21_Click(object sender, EventArgs e) { button21.Text = move(2, 1); }
        private void button22_Click(object sender, EventArgs e) { button22.Text = move(2, 2); }
    }
}