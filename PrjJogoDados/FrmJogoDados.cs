using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace PrjJogoDados
{
    public partial class FrmJogoDados : Form
    {

        Sortea sort = new Sortea();

        int y;
        int x;
        
        public FrmJogoDados()
        {
            InitializeComponent();
        }

        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\som.wav"); //definir diretorio do som .wav
            simpleSound.Play();
        }


        private void btnSortear_Click(object sender, EventArgs e)
        {

            // Random rand = new Random();
            //int randX = rand.Next(6);

            //randY = sort.sortear();

            x = sort.sortear();
            

            if (x == 0)
                pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado1.png"); //definir o diretorio das imagens
            if (x == 1)
                pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado2.png"); //definir o diretorio das imagens
            if (x == 2)
                pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado3.png"); //definir o diretorio das imagens
            if (x == 3)
                pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado4.png"); //definir o diretorio das imagens
            if (x == 4)
                pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado5.png"); //definir o diretorio das imagens
            if (x == 5)
                pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado6.png"); //definir o diretorio das imagens

            if (x == y)
            {
                lstBox.Items.Add("Igual!");
                playSimpleSound();
            }

        }

        private void rdoMan_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if(rdoMan.Checked == true)
            {
                btnSortear.Visible = true;
                btnSortear2.Visible = true;
            }
            else
            {
                btnSortear.Visible = false;
                btnSortear2.Visible = true;
            }
        }

        private void rdoAut_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnSortear2_Click(object sender, EventArgs e)
        {
            y = sort.sortear();

            if (y == 0)
                pctBoxDado2.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado1.png"); //definir o diretorio das imagens
            if (y == 1)
                pctBoxDado2.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado2.png"); //definir o diretorio das imagens
            if (y == 2)
                pctBoxDado2.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado3.png"); //definir o diretorio das imagens
            if (y == 3)
                pctBoxDado2.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado4.png"); //definir o diretorio das imagens
            if (y == 4)
                pctBoxDado2.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado5.png"); //definir o diretorio das imagens
            if (y == 5)
                pctBoxDado2.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado6.png"); //definir o diretorio das imagens

            if (x == y)
            {
                lstBox.Items.Add("Igual!");
                playSimpleSound();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            x = sort.sortear();

            

            if (x == 0)
                    pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado1.png"); //definir o diretorio das imagens
                if (x == 1)
                    pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado2.png"); //definir o diretorio das imagens
            if (x == 2)
                    pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado3.png"); //definir o diretorio das imagens
            if (x == 3)
                    pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado4.png"); //definir o diretorio das imagens
            if (x == 4)
                    pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado5.png"); //definir o diretorio das imagens
            if (x == 5)
                    pctboxDado.Image = Image.FromFile(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\dado6.png"); //definir o diretorio das imagens


            if (x == y)
            {
                lstBox.Items.Add("Igual!");
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\jemer\Desktop\ETEC\C#\PrjJogoDados\PrjJogoDados\Img\som.wav"); //definir diretorio do som .wav
                simpleSound.Play();
            }

            

        }

        


    }
}
