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
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.som); //definir diretorio do som .wav
            simpleSound.Play();
        }


        private void btnSortear_Click(object sender, EventArgs e)
        {

            // Random rand = new Random();
            //int randX = rand.Next(6);

            //randY = sort.sortear();

            x = sort.sortear();
            

            if (x == 0)
                pctboxDado.Image = Properties.Resources.dado1;
            if (x == 1)
                pctboxDado.Image = Properties.Resources.dado2; //definir o diretorio das imagens
            if (x == 2)
                pctboxDado.Image = Properties.Resources.dado3; //definir o diretorio das imagens
            if (x == 3)
                pctboxDado.Image = Properties.Resources.dado4; //definir o diretorio das imagens
            if (x == 4)
                pctboxDado.Image = Properties.Resources.dado5; //definir o diretorio das imagens
            if (x == 5)
                pctboxDado.Image = Properties.Resources.dado6; //definir o diretorio das imagens

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
                pctBoxDado2.Image = Properties.Resources.dado1; //definir o diretorio das imagens
            if (y == 1)
                pctBoxDado2.Image = Properties.Resources.dado2; //definir o diretorio das imagens
            if (y == 2)
                pctBoxDado2.Image = Properties.Resources.dado3; //definir o diretorio das imagens
            if (y == 3)
                pctBoxDado2.Image = Properties.Resources.dado4; //definir o diretorio das imagens
            if (y == 4)
                pctBoxDado2.Image = Properties.Resources.dado5; //definir o diretorio das imagens
            if (y == 5)
                pctBoxDado2.Image = Properties.Resources.dado6; //definir o diretorio das imagens

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
                    pctboxDado.Image = Properties.Resources.dado1; //definir o diretorio das imagens
                if (x == 1)
                    pctboxDado.Image = Properties.Resources.dado2; //definir o diretorio das imagens
            if (x == 2)
                    pctboxDado.Image = Properties.Resources.dado3; //definir o diretorio das imagens
            if (x == 3)
                    pctboxDado.Image = Properties.Resources.dado4; //definir o diretorio das imagens
            if (x == 4)
                    pctboxDado.Image = Properties.Resources.dado5; //definir o diretorio das imagens
            if (x == 5)
                pctboxDado.Image = Properties.Resources.dado6;
            //pctboxDado.Image = Image.FromFile(@"C:\Users\Desktop\C#\PrjJogoDados\Img\imagem.png"); //definir o diretorio das imagens local
                    


            if (x == y)
            {
                lstBox.Items.Add("Igual!");
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.som);
                //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Desktop\C#\PrjJogoDados\Img\som.wav"); //definir diretorio do som .wav local
                simpleSound.Play();
            }

            

        }

        


    }
}
