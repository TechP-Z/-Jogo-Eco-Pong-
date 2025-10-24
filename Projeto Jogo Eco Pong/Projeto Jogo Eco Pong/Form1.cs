using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Jogo_Eco_Pong
{
    public partial class Form1 : Form
    {
        int velocidadeBX = 4;
        int velocidadeBY = 5;
        int velocidade = 2;
        Random rand = new Random();
        bool paraBaixo, paraCima;
        int alterar_vel_comp = 50;
        int pontoPlayer = 0;
        int pontoComputador = 0;
        int velPlayer = 8;
        int[] i = { 5, 6, 8, 9 };
        int[] j = { 10, 9, 8, 11, 12 };
        int tempo;
        int segundos;
        int tempoIntro = 0;


        public Form1()
        {
            InitializeComponent();
            //tmrTimer.Interval = 20;
            progressBarPlayer.Maximum = 5;
            progressBarPlayer.Minimum = 0;
            progressBarPlayer.Value = 5;
            progressBarComputador.Maximum = 5;
            progressBarComputador.Minimum = 0;
            progressBarComputador.Value = 5;
            pbLogo.Visible = true;
            btnJogar.Visible = true;
            btnAjuda.Visible = true;
            pbAjuda.Visible = false;
            btnVoltar.Visible = false;
            lblTituloAjuda.Visible = false;
            lblTextoAjuda1.Visible = false;
            lblInstrucoes.Visible = false;
            lblTextoAjuda2.Visible = false;
            pbImagemCoracao.Visible = false; 
            pbImagemCoracaoCorromp.Visible = false;        
            tmrTimer.Stop();
            tmrTempoJogo.Stop();
            tmrIntro.Start();
        }

        //private bool andamento = false;

        private void tmrTimerEvent(object sender, EventArgs e)
        {
            pbBola.Top -= velocidadeBY;
            pbBola.Left -= velocidadeBX;

            pbPSeguidor.Top = pbPlayer2.Top;
            pbCSeguidor.Top = pbComputador.Top;

            //lblPlantobot.Text = "◄ Plantobot: " + pontoPlayer + " ►";
            //lblSucatobot.Text = "◄ Sucatobot: " + pontoComputador + " ►";

            if (segundos > 100)
            {
                lblTempo.Text = "◄ " + segundos + " ►";
                //this.Text = "Plantobot: " + pontoPlayer + " ◄--- 000 ---► Sucatobot: " + pontoComputador;
            }
            else if (segundos < 100 && segundos > 10)
            {
                lblTempo.Text = "◄ 0" + segundos + " ►";
            }
            else if (segundos < 10 && segundos > 0)
            {
                lblTempo.Text = "◄ 00" + segundos + " ►";
            }
            else if (segundos == 0)
            {
                if (pontoComputador == pontoPlayer && tempo == 150)
                {
                    GameOver("◄ EMPATE! ►");

                }
                else if (pontoComputador > pontoPlayer)
                {
                    GameOver("◄ VOCÊ PERDEU! ►");

                }
                else if (pontoPlayer > pontoComputador)
                {
                    GameOver("◄ VOCÊ GANHOU! ►");
                }
            }


            //REBATER NAS BORDAS (DE CIMA E DE BAIXO)
            if (pbBola.Top < 0 || (pbBola.Bottom > this.ClientSize.Height || pbBola.Bottom > pbCenario.Top))
            {
                velocidadeBY = -velocidadeBY;
            }
            //BATER NA PAREDE DO JOGADOR (MARCAR PONTO PARA COMPUTADOR)
            if (pbBola.Left < -2)
            {
                pbBola.Left = 300;
                velocidadeBX = -velocidadeBX;
                pontoComputador++;
                progressBarPlayer.Value--;
            }
            //BATER NA PAREDE DO COMPUTADOR (MARCAR PONTO PARA JOGADOR)
            if (pbBola.Right > this.ClientSize.Width + 2)
            {
                pbBola.Left = 300;
                velocidadeBX = -velocidadeBX;
                pontoPlayer++;
                progressBarComputador.Value--;
            }

            //DEFININDO CONTENÇÃO DO COMPUTADOR
            if (pbComputador.Top <= 1)
            {
                pbComputador.Top = 0;
            }
            else if ((pbComputador.Bottom >= this.ClientSize.Height) || (pbComputador.Bottom >= pbCenario.Top))
            {
                //pbComputador.Top = this.ClientSize.Height - pbComputador.Height;
                pbComputador.Top = pbCenario.Top - pbComputador.Height;
            }

            //COMPUTADOR SEGUINDO A BOLA

            //ABAIXO
            if (pbBola.Top < pbComputador.Top + (pbComputador.Height / 2) && pbBola.Left > 300)
            {
                pbComputador.Top -= velocidade;
            }
            //ACIMA
            if (pbBola.Top > pbComputador.Top + (pbComputador.Height / 2) && pbBola.Left > 300)
            {
                pbComputador.Top += velocidade;
            }


            //DEFININDO VARIAÇÃO DE VELOCIDADE DO COMPUTADOR
            alterar_vel_comp -= 1;

            if (alterar_vel_comp < 0)
            {
                velocidade = i[rand.Next(i.Length)];
                alterar_vel_comp = 50;
            }



            //DEFININDO CONTENÇÃO DO PLAYER

            //PARA BAIXO
            //if ((paraBaixo && pbPlayer.Top + pbPlayer.Height < this.ClientSize.Height) || ())
            if (paraBaixo && pbPlayer2.Top < pbCenario.Top - 140)
            {
                pbPlayer2.Top += velPlayer;
            }
            //PARA CIMA
            if (paraCima && pbPlayer2.Top > 0)
            {
                pbPlayer2.Top -= velPlayer;
            }

            //DEFININDO MOVIMENTAÇÃO DO CENÁRIO
            //if (paraBaixo && pbPlayer.Top + pbPlayer.Height < this.ClientSize.Height)
            if (paraBaixo && pbPlayer2.Top < pbCenario.Top - 140)
            {
                pbCenario.Top -= velPlayer / 5;
            }
            //PARA CIMA
            if (paraCima && pbPlayer.Top > 0)
            {
                pbCenario.Top += velPlayer / 5;
            }


            //DEFININDO MOVIMENTAÇÃO DAS PARTÍCULAS
            if (paraBaixo && pbPlayer2.Top < pbCenario.Top - 140)
            {
                pbParticula1.Top -= velPlayer / 2;
            }
            //PARA CIMA
            if (paraCima && pbPlayer.Top > 0)
            {
                pbParticula1.Top += velPlayer / 2;
            }

            if (paraBaixo && pbPlayer.Top < pbCenario.Top - 140)
            {
                pbParticula2.Top -= velPlayer / 3;
            }
            //PARA CIMA
            if (paraCima && pbPlayer.Top > 0)
            {
                pbParticula2.Top += velPlayer / 3;
            }

            if (paraBaixo && pbPlayer.Top < pbCenario.Top - 140)
            {
                pbParticula3.Top -= velPlayer / 4;
            }
            //PARA CIMA
            if (paraCima && pbPlayer.Top > 0)
            {
                pbParticula3.Top += velPlayer / 4;
            }



            //EXECUTANDO VERIFICAÇÃO DE COLISÃO

            //PARA O PLAYER
            CheckCollision(pbBola, pbPlayer2, pbPlayer2.Right + 5);
            //PARA O COMPUTADOR
            CheckCollision(pbBola, pbComputador, pbComputador.Left - 35);


            //MOSTRANDO 0 FIM DE JOGO
            if (pontoComputador > 4)
            {
                GameOver("◄ VOCÊ PERDEU! ►");
            }
            else if (pontoPlayer > 4)
            {
                GameOver("◄ VOCÊ GANHOU! ►");
            }

        }


        //QUANDO APERTAR, SE TORNA VERDADEIRO
        private void keyBaixo(object sender, KeyEventArgs e)
        {
            //SETAS
            if (e.KeyCode == Keys.Down)
            {
                paraBaixo = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                paraCima = true;
            }
            //LETRAS
            if (e.KeyCode == Keys.S)
            {
                paraBaixo = true;
            }
            if (e.KeyCode == Keys.W)
            {
                paraCima = true;
            }
        }

        //QUANDO SOLTAR, SE TORNA FALSO
        private void keyCima(object sender, KeyEventArgs e)
        {
            //SETAS
            if (e.KeyCode == Keys.Down)
            {
                paraBaixo = false;
            }
            if(e.KeyCode == Keys.Up)
            {
                paraCima = false;
            }
            //LETRAS
            if (e.KeyCode == Keys.S)
            {
                paraBaixo = false;
            }
            if (e.KeyCode == Keys.W)
            {
                paraCima = false;
            }
        }


        //VERIFICAR COLISÃO DA BOLA COM O PLAYER OU COM O COMPUTADOR
        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        { 
            Console.WriteLine("" + (pbPlayer2.Bounds.X + pbPlayer2.Width).ToString() + " // " + (pbBola.Bounds.X).ToString());
            if (PicOne.Bounds.IntersectsWith(PicTwo.Bounds))
            {
                PicOne.Left = offset;

                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];

                if (pbBola.Bounds.X >= pbPlayer2.Bounds.X) { }


                //DEFININDO A TRAJETÓRIA DA BOLA

                //X
                if (velocidadeBX < 0 && pbBola.Bounds.X >= pbPlayer2.Bounds.X+pbPlayer2.Width)
                {
                    velocidadeBX = x;
                }
                else if (pbBola.Bounds.X >= pbPlayer2.Bounds.X + pbPlayer2.Width)
                {
                    velocidadeBX = -x;
                }

                //Y
                if (velocidadeBY < 0)
                {
                    velocidadeBY = -y;
                }
                else
                {
                    velocidadeBY = y;
                }

            }
        }

        private void tmrTempoJogo_Tick(object sender, EventArgs e)
        {
            tempo++;
            segundos = 150 - tempo;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            tempo = 0;
            segundos = 150 - tempo;
            tmrTimer.Start();
            tmrTempoJogo.Start();
            pbLogo.Visible = false;
            btnJogar.Visible = false;
            btnAjuda.Visible = false;
            pbAjuda.Visible = false;
            //PARA GARANTIR...
            btnVoltar.Visible = false;
            lblTituloAjuda.Visible = false;
            lblTextoAjuda1.Visible = false;
            lblInstrucoes.Visible = false;
            lblTextoAjuda2.Visible = false;
            pbImagemCoracao.Visible = false;

            progressBarComputador.Value = 5;
            progressBarPlayer.Value = 5;
            this.Focus();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            pbAjuda.Visible = false;
            btnVoltar.Visible = false;
            lblTituloAjuda.Visible = false;
            lblTextoAjuda1.Visible = false;
            lblInstrucoes.Visible = false;
            lblTextoAjuda2.Visible = false;
            pbImagemCoracao.Visible = false;
            pbImagemCoracaoCorromp.Visible = false;
            //
            pbLogo.Visible = true;
            btnJogar.Visible = true;
            btnAjuda.Visible = true;
            pbBola.Visible = true;
            this.Focus();
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            pbAjuda.Visible = true;
            btnVoltar.Visible = true;
            lblTituloAjuda.Visible = true;
            lblTextoAjuda1.Visible = true;
            lblInstrucoes.Visible = true;
            lblTextoAjuda2.Visible = true;
            pbImagemCoracao.Visible = true;
            //
            pbLogo.Visible = false;
            btnJogar.Visible = false;
            btnAjuda.Visible = false;
            pbBola.Visible = false;
            this.Focus();
        }

        private void ClicarMouse(object sender, EventArgs e)
        {
            if (pbImagemCoracao.Visible == true)
            {
                pbImagemCoracao.Visible = false;
                pbImagemCoracaoCorromp.Visible = true;
            }
        }

        private void ClicarMouse2(object sender, EventArgs e)
        {
            if (pbImagemCoracaoCorromp.Visible == true)
            {
                pbImagemCoracao.Visible = true;
                pbImagemCoracaoCorromp.Visible = false;
            }
        }

        private void TmrIntro_Tick(object sender, EventArgs e)
        {
            tempoIntro++;

            if (tempoIntro < 70)
            {
                pnlFundoIntro.Visible = true;
            }
            else if (tempoIntro >= 70)
            {
                pnlFundoIntro.Visible = false;
            }


            if (tempoIntro < 30)
            {
                pbLogoIntro.Visible = true;
            }
            else if (tempoIntro >= 30)
            {
                pbLogoIntro.Visible = false;
            }

            if (tempoIntro < 30)
            {
                pbLogoDS.Visible = false;
            }
            else if (tempoIntro < 60)
            {
                pbLogoDS.Visible = true;
            }
            else if (tempoIntro >= 60)
            {
                pbLogoDS.Visible = false;
            }

            if (tempoIntro < 60)
            {
                lblApresenta.Visible = true;
            }
            else if (tempoIntro >= 60)
            {
                lblApresenta.Visible = false;
            }
        }

        //EXIBIR GAME-OVER
        private void GameOver(string massage)
        {
            tmrTimer.Stop();
            tmrTempoJogo.Stop();
            MessageBox.Show(massage,"◄ Fim de Jogo ►");
            pontoComputador = 0;
            pontoPlayer = 0;

            velocidadeBX = velocidadeBY = 4;
            alterar_vel_comp = 50;

            pbLogo.Visible = true;
            btnJogar.Visible = true;
            btnAjuda.Visible = true;

            //progressBarComputador.Value = 5;
            //progressBarPlayer.Value = 5;

            //tmrTimer.Start();
            //tempo = 0;
            //segundos = 150;
            //tmrTempoJogo.Start();

        }
    }
}
