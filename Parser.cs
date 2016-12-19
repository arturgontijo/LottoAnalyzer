using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Windows.Forms;

namespace LottoAnalyzer
{
    class Parser
    {

        public bool PegaNome(String filename)
        {
            var web = new HtmlWeb();
            var doc = web.Load(filename);
            var nodes = doc.DocumentNode.SelectNodes("//title");
            string[] nome;

            try
            {

                foreach (var node in nodes)
                {
                    nome = Regex.Split(node.InnerText, " ");
                    for (int i = 0; i < nome.Length; i++)
                    {
                        if (Regex.IsMatch(nome[i], "Lotofácil") ||
                            Regex.IsMatch(nome[i], "Lotomania") ||
                            Regex.IsMatch(nome[i], "Mega-sena"))
                        {
                            MainWindow.NomeLoteria = nome[i];
                            return true;
                        }
                    }
                }

                return false;
            }
            catch { return false; }
        }

        public bool ResultExtractor(String filename, int range)
        {

            bool grava = false;
            int jog_ind = 1, dic_ind = 1;
            bool name_ok = false;
            var web = new HtmlWeb();
            var doc = web.Load(filename);
            string[] nome;

            StructResultados StructJogos = null;

            try
            {

                // Verifica o nome da Loteria
                var nodes = doc.DocumentNode.SelectNodes("//title");

                foreach (var node in nodes)
                {
                    nome = Regex.Split(node.InnerText, " ");
                    for (int i = 0; i < nome.Length; i++)
                    {
                        if (Regex.IsMatch(nome[i], "Lotofácil") ||
                            Regex.IsMatch(nome[i], "Lotomania") ||
                            Regex.IsMatch(nome[i], "Mega-sena"))
                        {
                            MainWindow.NomeLoteria = nome[i];
                            name_ok = true;
                            break;
                        }
                    }
                }

                if (name_ok)
                {

                    nodes = doc.DocumentNode.SelectNodes("//td");

                    MainWindow.Resultados.Clear();

                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {

                            if (node == null) continue;

                            if (Regex.IsMatch(node.InnerText, "([0-9][0-9])/([0-9][0-9])/([0-9][0-9])([0-9][0-9])"))
                            {
                                grava = true;
                                StructJogos = new StructResultados();
                                StructJogos.Dezenas = new List<int>();
                                continue;
                            }

                            if (grava)
                            {
                                StructJogos.Dezenas.Add(Convert.ToInt32(node.InnerText));
                                jog_ind++;
                                if (jog_ind > range)
                                {
                                    StructJogos.Sorteio = dic_ind;
                                    StructJogos.flag = false;
                                    StructJogos.Dezenas.Sort();
                                    MainWindow.Resultados.Add(StructJogos);
                                    grava = false;
                                    jog_ind = 1;
                                    dic_ind++;
                                }
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo Inválido.");
                    return false;
                }
            }
            catch { return false; }

            return true;
        }
    }
}
