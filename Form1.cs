using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JogoDaVelhaTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int vez = 0; // VARIAVEL QUE DETERMINA QUEM DEVERÁ JOGAR
        string[,] jogoDaVelha = new string[3, 3];
        int tentativas = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // ATRIBUIDO VALORES "DEFAULTS" PARA A MATRIZ

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    jogoDaVelha[linha, coluna] = "-";
                }
            }

            // MOSTRANDO O MODO "DEFAULT" DA MATRIZ

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    lblMatriz.Text += jogoDaVelha[linha, coluna] + " ";
                }
                lblMatriz.Text += "\n";
            }

            // DETERMINANDO A VEZ DO JOGADOR


            if (vez == 0)
            {
                lblVez.Text = "Vez de X";
                vez = 1;
            }
            else
            {
                lblVez.Text = "Vez de O";
                vez = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            lblMatriz.Text = "";

            int linhaPosi = int.Parse(txtLinha.Text) - 1;
            int colunaPosi = int.Parse(txtColuna.Text) - 1;


            // Variaveis da bolinha

            int contLinhaBolinha = 0;
            int contColBolinha = 0;
            int contDpBolinha = 0;

            // Variaveis do xis

            int contLinhaXis = 0;
            int contColXis = 0;
            int contDpXis = 0;

            tentativas++;


            // CONDIÇÕES DA BOLINHA


            if (vez == 0)
            {
                jogoDaVelha[linhaPosi, colunaPosi] = "O";

                // Conferiu se existem mais bolinhas na linha (TUDO CERTO)

                for (int i = 0; i < 3; i++)
                {

                    if (jogoDaVelha[linhaPosi, i] == "O")
                    {
                        contLinhaBolinha++;

                        if (contLinhaBolinha == 3)
                        {
                            lblVitoria.Text = "BOLINHA VENCEU";

                            txtColuna.Enabled = false;
                            txtLinha.Enabled = false;
                            button1.Enabled = false;

                            btnRejogar.Visible = true;

                            // Variaveis da bolinha

                            contLinhaBolinha = 0;
                            contColBolinha = 0;
                            contDpBolinha = 0;

                            // Variaveis do xis

                            contLinhaXis = 0;
                            contColXis = 0;
                            contDpXis = 0;
                        }
                    }
                }

                // Fim do conferimento de se existem mais bolinhas na linha (TUDO CERTO)




                // Conferiu se existem mais bolinhas na coluna (TUDO CERTO)

                for (int i = 0; i < 3; i++)
                {

                    if (jogoDaVelha[i, colunaPosi] == "O")
                    {
                        contColBolinha++;

                        if (contColBolinha == 3)
                        {
                            lblVitoria.Text = "BOLINHA VENCEU";


                            txtColuna.Enabled = false;
                            txtLinha.Enabled = false;
                            button1.Enabled = false;

                            btnRejogar.Visible = true;

                            // Variaveis da bolinha

                            contLinhaBolinha = 0;
                            contColBolinha = 0;
                            contDpBolinha = 0;

                            // Variaveis do xis

                            contLinhaXis = 0;
                            contColXis = 0;
                            contDpXis = 0;
                        }
                    }
                }

                // Fim do conferimento de se existem mais bolinhas na coluna (TUDO CERTO)




                // Conferiu se existem mais bolinhas na diagonal principal

                for (int i = 0; i < 3; i++)
                {

                    if (jogoDaVelha[i, i] == "O")
                    {
                        contDpBolinha++;

                        if (contDpBolinha == 3)
                        {
                            lblVitoria.Text = "BOLINHA VENCEU";


                            txtColuna.Enabled = false;
                            txtLinha.Enabled = false;
                            button1.Enabled = false;

                            btnRejogar.Visible = true;

                            // Variaveis da bolinha

                            contLinhaBolinha = 0;
                            contColBolinha = 0;
                            contDpBolinha = 0;

                            // Variaveis do xis

                            contLinhaXis = 0;
                            contColXis = 0;
                            contDpXis = 0;
                        }
                    }
                }

                // Fim do conferimento de se existem mais bolinhas na na diagonal principal (TUDO CERTO)




                // Conferiu se existem mais bolinhas na diagonal secundaria

                if (linhaPosi + colunaPosi == 2)
                {
                    if (jogoDaVelha[0, 2] == "O" && jogoDaVelha[1, 1] == "O" && jogoDaVelha[2, 0] == "O")
                    {

                        lblVitoria.Text = "BOLINHA VENCEU";


                        txtColuna.Enabled = false;
                        txtLinha.Enabled = false;
                        button1.Enabled = false;

                        btnRejogar.Visible = true;

                        // Variaveis da bolinha

                        contLinhaBolinha = 0;
                        contColBolinha = 0;
                        contDpBolinha = 0;

                        // Variaveis do xis

                        contLinhaXis = 0;
                        contColXis = 0;
                        contDpXis = 0;

                    }
                }

                // Fim do conferimento de se existem mais bolinhas na na diagonal principal (TUDO CERTO)


            }

            // CONDIÇÕES DO XIS

            else
            {
                jogoDaVelha[linhaPosi, colunaPosi] = "X";

                // Conferiu se existem mais xis na linha (TUDO CERTO)

                for (int i = 0; i < 3; i++)
                {

                    if (jogoDaVelha[linhaPosi, i] == "X")
                    {
                        contLinhaXis++;

                        if (contLinhaXis == 3)
                        {
                            lblVitoria.Text = "X VENCEU";

                            txtColuna.Enabled = false;
                            txtLinha.Enabled = false;
                            button1.Enabled = false;

                            btnRejogar.Visible = true;

                            // Variaveis da bolinha

                            contLinhaBolinha = 0;
                            contColBolinha = 0;
                            contDpBolinha = 0;

                            // Variaveis do xis

                            contLinhaXis = 0;
                            contColXis = 0;
                            contDpXis = 0;
                        }
                    }
                }

                // Fim do conferimento de se existem mais xis na linha (TUDO CERTO)


                // Conferiu se existem mais xis na coluna (TUDO CERTO)

                for (int i = 0; i < 3; i++)
                {

                    if (jogoDaVelha[i, colunaPosi] == "X")
                    {
                        contColXis++;

                        if (contColXis == 3)
                        {
                            lblVitoria.Text = "X VENCEU";

                            txtColuna.Enabled = false;
                            txtLinha.Enabled = false;
                            button1.Enabled = false;

                            btnRejogar.Visible = true;

                            // Variaveis da bolinha

                            contLinhaBolinha = 0;
                            contColBolinha = 0;
                            contDpBolinha = 0;

                            // Variaveis do xis

                            contLinhaXis = 0;
                            contColXis = 0;
                            contDpXis = 0;
                        }
                    }
                }


                // Fim do conferimento de se existem mais xis na coluna (TUDO CERTO)




                // Conferiu se existem mais xis na diagonal principal

                for (int i = 0; i < 3; i++)
                {

                    if (jogoDaVelha[i, i] == "X")
                    {
                        contDpXis++;

                        if (contDpXis == 3)
                        {
                            lblVitoria.Text = "X VENCEU";

                            txtColuna.Enabled = false;
                            txtLinha.Enabled = false;
                            button1.Enabled = false;

                            btnRejogar.Visible = true;

                            // Variaveis da bolinha

                            contLinhaBolinha = 0;
                            contColBolinha = 0;
                            contDpBolinha = 0;

                            // Variaveis do xis

                            contLinhaXis = 0;
                            contColXis = 0;
                            contDpXis = 0;
                        }
                    }
                }

                // Fim do conferimento de se existem mais xis na na diagonal principal

                // Conferiu se existem mais bolinhas na diagonal secundaria

                if (linhaPosi + colunaPosi == 2)
                {
                    if (jogoDaVelha[0, 2] == "X" && jogoDaVelha[1, 1] == "X" && jogoDaVelha[2, 0] == "X")
                    {

                        lblVitoria.Text = "X VENCEU";

                        txtColuna.Enabled = false;
                        txtLinha.Enabled = false;
                        button1.Enabled = false;

                        btnRejogar.Visible = true;

                        // Variaveis da bolinha

                        contLinhaBolinha = 0;
                        contColBolinha = 0;
                        contDpBolinha = 0;

                        // Variaveis do xis

                        contLinhaXis = 0;
                        contColXis = 0;
                        contDpXis = 0;


                    }
                }

                // Fim do conferimento de se existem mais bolinhas na na diagonal principal (TUDO CERTO)


            }

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    lblMatriz.Text += jogoDaVelha[linha, coluna] + " ";
                }
                lblMatriz.Text += "\n";
            }

            if (vez == 0)
            {
                lblVez.Text = "Vez de X";
                vez = 1;
            }
            else
            {
                lblVez.Text = "Vez de O";
                vez = 0;
            }


    
            if (tentativas == 9)
            {
                txtColuna.Enabled = false;
                txtLinha.Enabled = false;
                button1.Enabled = false;

                lblVitoria.ForeColor = Color.Red;
                lblVitoria.Text = "DEU VELHA";
                btnRejogar.Visible = true;

                // Variaveis da bolinha

                contLinhaBolinha = 0;
                contColBolinha = 0;
                contDpBolinha = 0;

                // Variaveis do xis

                contLinhaXis = 0;
                contColXis = 0;
                contDpXis = 0;



            }





            txtColuna.Clear();
            txtLinha.Clear();

        }

        private void btnRejogar_Click(object sender, EventArgs e)
        {
            txtColuna.Enabled = true;
            txtLinha.Enabled = true;
            button1.Enabled = true;
            lblVitoria.Text = "";
            tentativas = 0;

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    jogoDaVelha[linha, coluna] = "-";
                }
            }

            lblMatriz.Text = "";

            // MOSTRANDO O MODO "DEFAULT" DA MATRIZ

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    lblMatriz.Text += jogoDaVelha[linha, coluna] + " ";
                }
                lblMatriz.Text += "\n";
            }

            btnRejogar.Visible = false;
        }


    }
}
