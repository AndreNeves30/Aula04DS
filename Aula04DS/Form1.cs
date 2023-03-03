using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04DS
{
    public partial class FormPersonagens : Form
    {
        public FormPersonagens()
        {
            InitializeComponent();
        }
        private void mudarPersonagem()
        {
            if (comboBoxPersonagem.SelectedIndex == 0 || listBoxPersonagem.SelectedIndex == 0)
            {
                pictureBoxPersonagem.Image = Properties.Resources.goku;
                this.BackColor = Color.Orange;
            }
            else if (comboBoxPersonagem.SelectedIndex == 1 || listBoxPersonagem.SelectedIndex == 1)
            {
                pictureBoxPersonagem.Image = Properties.Resources.vegeta;
                this.BackColor = Color.Blue;
            }
            else if(comboBoxPersonagem.SelectedIndex == 2 || listBoxPersonagem.SelectedIndex == 2)
            {
                pictureBoxPersonagem.Image = Properties.Resources.inuyasha;
                this.BackColor = Color.Red;
            }
            else if(comboBoxPersonagem.SelectedIndex == 3 || listBoxPersonagem.SelectedIndex == 3)
            {
                pictureBoxPersonagem.Image = Properties.Resources.sesshoumaru;
                this.BackColor = Color.Gray;
            }
            else if(comboBoxPersonagem.SelectedIndex == 4 || listBoxPersonagem.SelectedIndex == 4)
            {
                pictureBoxPersonagem.Image = Properties.Resources.knight;
                this.BackColor = Color.Black;
            }
            else if(comboBoxPersonagem.SelectedIndex == 5 || listBoxPersonagem.SelectedIndex == 5)
            {
                pictureBoxPersonagem.Image = Properties.Resources.sanji;
                this.BackColor = Color.Purple;
            }
            else if(comboBoxPersonagem.SelectedIndex == 6 || listBoxPersonagem.SelectedIndex == 6)
            {
                pictureBoxPersonagem.Image = Properties.Resources.kaneki;
                this.BackColor = Color.IndianRed;
            }
            else if(comboBoxPersonagem.SelectedIndex == 7 || listBoxPersonagem.SelectedIndex == 7)
            {
                pictureBoxPersonagem.Image = Properties.Resources.ban;
                this.BackColor = Color.DarkRed;
            }
            else if(comboBoxPersonagem.SelectedIndex == 8 || listBoxPersonagem.SelectedIndex == 8)
            {
                pictureBoxPersonagem.Image = Properties.Resources.violet;
                this.BackColor = Color.Violet;
            }
            else if(comboBoxPersonagem.SelectedIndex == 9 || listBoxPersonagem.SelectedIndex == 9)
            {
                pictureBoxPersonagem.Image = Properties.Resources.howl;
                this.BackColor = Color.MediumPurple;
            }
           
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mudarPersonagem();
        }

        private void listBoxPersonagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            mudarPersonagem();
        }
    }
}
