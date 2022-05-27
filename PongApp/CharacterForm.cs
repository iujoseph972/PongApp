using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongApp
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void trollFacedCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\cgrun\Downloads\Pong_Character_Troll_Face.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void mogCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\cgrun\Downloads\Pong_Character_MOG.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void noCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\cgrun\Downloads\Pong_Character_No.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void foreverAloneCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\cgrun\Downloads\Pong_Character_ForeverAlone.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();

        }
    }
}
