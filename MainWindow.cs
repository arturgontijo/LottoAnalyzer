using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LottoAnalyzer
{
    public partial class MainWindow : Form
    {

        public static List<StructResultados> Resultados = new List<StructResultados>();
        public static bool dic_ok = false;
        public static int dezena_inicial = 0, dezena_final = 0, dezenas_sorteadas = 15, num_dezenas = 0, dezenas_jogadas = 0;
        public static int total_dezenas = 0, total_jogos = 0;
        public static String NomeLoteria;
        public static String APP_NAME = "LottoAnalyzer";

        public MainWindow()
        {
            InitializeComponent();

            // Impede que o user redefina as dimensoes da janela
            this.MaximumSize = this.MinimumSize = this.Size;
        }
        
        private void UpdateFuncionalidades(RichTextBox LOG, int option)
        {
            decimal pares = 0, impares = 0;
            int i = 0, k = 0;
            bool ret = false;
            decimal[] Vret;
            Funcionalidades func = new Funcionalidades();

            total_dezenas = Resultados.Count * dezenas_sorteadas;
            total_jogos = Resultados.Count;

            // Limpa o Campo LOG
            LOG.Text = "";

            switch (option)
            {
                // Imprime relacao Pares/Impares %
                case (0):
                    ret = func.ParesImpares(out pares, out impares);
                    if (ret)
                    {
                        LOG.Text += "Pares: \t" + pares.ToString() + "\t[" + ((pares) * 100 / total_dezenas).ToString("0.000") + " %]" + "\n" +
                                    "Ímpares: \t" + impares.ToString() + "\t[" + ((impares) * 100 / total_dezenas).ToString("0.000") + " %]" + "\n" +
                                    "Total: \t" + total_dezenas + "\t[" + ((total_dezenas / total_dezenas) * 100).ToString("0.000") + " %]";
                    }
                    break;

                // Imprime Quantidade de pares e impares por sorteio
                case (1):
                    ret = func.NumParImpar(out Vret, dezenas_sorteadas, 25);
                    if (ret)
                    {
                        LOG.Text += "Pares\t\tImpares\t\t[%]\n";
                        for (i = 0; i <= dezenas_sorteadas; i++)
                        {
                            LOG.Text += (dezenas_sorteadas - i).ToString() + "\t\t  " + i.ToString() + "\t\t" + 
                                ((Vret[(dezenas_sorteadas - i)] * 100) / total_jogos).ToString("0.000") + "\n";
                        }
                    }
                    break;

                // Imprime a % de acerto de cada dezena
                case (2):
                    ret = func.MapDezenas(out Vret, dezena_final, dezena_inicial);
                    if (ret)
                    {
                        LOG.Text += "Dezena\t\tJogos\t\t[% de " + total_dezenas.ToString() + "]\t[% de " + total_jogos.ToString() + "]\n";
                        k = 0;
                        for (i = dezena_inicial; i <= dezena_final; i++)
                        {
                            LOG.Text += i.ToString("00") + "\t\t" + (Vret[k]).ToString() + "\t\t" + ((Vret[k] * 100) / total_dezenas).ToString("0.000") +
                                "\t\t" + ((Vret[k] * 100) / total_jogos).ToString("0.000") + "\n";
                            k++;
                        }
                    }
                    break;

                // Imprime o atraso de cada dezena
                case (3):
                    ret = func.UltOcorrencias(out Vret, dezena_final, dezena_inicial);
                    if (ret)
                    {
                        LOG.Text += "Dezena\t\t[Atraso]\n";
                        k = 0;
                        for (i = dezena_inicial; i <= dezena_final; i++)
                        {
                            LOG.Text += "    " + i.ToString("00") + "\t\t" + (total_jogos - Vret[k]).ToString() + "\n";
                            k++;
                        }
                    }
                    break;

                // Imprime o atraso máximo de cada dezena
                case (4):
                    ret = func.MaxAtraso(out Vret, dezenas_sorteadas, dezena_final, dezena_inicial);
                    if (ret)
                    {
                        LOG.Text += "Dezena\t\t[MaxAtraso]\n";
                        k = 0;
                        for (i = dezena_inicial; i <= dezena_final; i++)
                        {
                            LOG.Text += "    " + i.ToString("00") + "\t\t" + (Vret[k]).ToString() + "\n";
                            k++;
                        }
                    }
                    break;

                // Imprime a Soma das dezenas de cada sorteio
                case (5):
                    ret = func.SomaDezenas(out Vret);
                    if (ret)
                    {
                        LOG.Text += "Sorteio\t\t[Soma]\n";
                        k = 0;
                        for (i = 0; i < Vret.Length-1; i++)
                        {
                            LOG.Text += (i+1).ToString("0000") + "\t\t" + (Vret[i]).ToString() + "\n";
                        }
                    }
                    break;
            }
        }
        
        private void bAbrir_Click(object sender, EventArgs e)
        {
            bool ret = false;
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Abrir Arquivo de Resultados...";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                Parser parser = new Parser();
                ret = parser.PegaNome(openfile.FileName);
                InicializaVariaveis();
                dic_ok = parser.ResultExtractor(openfile.FileName, dezenas_sorteadas);

                if (dic_ok)
                {
                    tbFile.Text = openfile.FileName;
                    tbJogosCarregados.Text = Resultados.Count.ToString();
                    total_dezenas = Resultados.Count * dezenas_sorteadas;
                    total_jogos = Resultados.Count;
                    tbLOG.Text = "";
                    tbLoteria.Text = NomeLoteria;
                }
            }
            else
            {
                dic_ok = false;
                tbJogosCarregados.Text = "";
                Resultados.Clear();
                MessageBox.Show("Arquivo Inválido.", APP_NAME);
                tbLOG.Text = "";
                tbFile.Text = "";
                tbLoteria.Text = "";
            }
        }

        private void InicializaVariaveis()
        {
            if (NomeLoteria == "Lotofácil")
            {
                dezena_inicial = 1;
                dezena_final = 25;
                dezenas_sorteadas = 15;
                dezenas_jogadas = 15;
                num_dezenas = 25;
                dic_ok = false;
                tbJogosCarregados.Text = "VAZIO";
                tbFile.Text = "";
                tbLOG.Text = "";
                Resultados.Clear();
            }
            if (NomeLoteria == "Lotomania")
            {
                dezena_inicial = 0;
                dezena_final = 99;
                dezenas_sorteadas = 20;
                dezenas_jogadas = 50;
                num_dezenas = 100;
                dic_ok = false;
                tbJogosCarregados.Text = "VAZIO";
                tbFile.Text = "";
                tbLOG.Text = "";
                Resultados.Clear();
            }
            if (NomeLoteria == "Mega-sena")
            {
                dezena_inicial = 1;
                dezena_final = 60;
                dezenas_sorteadas = 6;
                dezenas_jogadas = 6;
                num_dezenas = 60;
                dic_ok = false;
                tbJogosCarregados.Text = "VAZIO";
                tbFile.Text = "";
                tbLOG.Text = "";
                Resultados.Clear();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// LOTOFÁCIL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void bAnalisador_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                NewWindows newWind = new NewWindows();
                newWind.NewWindowAnalisador(tbLOG, APP_NAME + " - Analisador LotoFácil");
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bParImpar_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                UpdateFuncionalidades(tbLOG, 0);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bQParImp_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                UpdateFuncionalidades(tbLOG, 1);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bMapeamento_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                NewWindows newWind = new NewWindows();
                newWind.NewWindowMapear(tbLOG);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bDezenas_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                UpdateFuncionalidades(tbLOG, 2);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bAtrasos_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                UpdateFuncionalidades(tbLOG, 3);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bAtrasosMax_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                UpdateFuncionalidades(tbLOG, 4);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bCombinar_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                NewWindows newWind = new NewWindows();
                newWind.NewWindowCombinar(tbLOG);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bSimular_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                NewWindows newWind = new NewWindows();
                newWind.NewWindowSimular(tbLOG, tbJogosCarregados);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bAnaliseCombinatoria_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                NewWindows newWind = new NewWindows();
                newWind.NewWindowAnaliseCombinatoria(tbLOG, tbJogosCarregados);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bAntPos_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                NewWindows newWind = new NewWindows();
                newWind.NewWindowAntPos(tbLOG);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void bSoma_Click(object sender, EventArgs e)
        {
            if (dic_ok)
            {
                UpdateFuncionalidades(tbLOG, 5);
            }
            else
            {
                MessageBox.Show("Carregue os jogos primeiro.", APP_NAME);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão: 1.0\nArtur Gontijo", APP_NAME);
        }
    }
}
