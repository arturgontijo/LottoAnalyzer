using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LottoAnalyzer
{
    class Funcionalidades
    {
        public bool ParesImpares(out decimal pares, out decimal impares)
        {
            pares = 0;
            impares = 0;
            try
            {
                foreach (var jogo in MainWindow.Resultados)
                {
                    foreach (var dezena in jogo.Dezenas)
                    {
                        if (dezena % 2 == 0) pares++;
                        else impares++;
                    }
                }
                
            }
            catch { return false; }

            return true;
        }

        public bool NumParImpar(out decimal[] Vpares, int num_dezenas, int range)
        {

            Vpares = new decimal[num_dezenas+1];
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < Vpares.Length; i++) Vpares[i] = 0;

            try
            {
                foreach (var jogo in MainWindow.Resultados)
                {
                    foreach (var dezena in jogo.Dezenas)
                    {
                        if (dezena % 2 == 0) pares++;
                        else impares++;
                    }
                    Vpares[pares]++;
                    impares = 0;
                    pares = 0;
                }

            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool MapIntervalos(out decimal[] VRet, int[] VMin, int[] VMax)
        {

            VRet = new decimal[VMin.Length];

            for (int i = 0; i < VRet.Length; i++) VRet[i] = 0;

            try
            {
                foreach (var jogo in MainWindow.Resultados)
                {
                    foreach (var dezena in jogo.Dezenas)
                    {
                        for (int k = 0; k < VMin.Length; k++)
                        {
                            if (dezena >= VMin[k] && dezena <= VMax[k]) VRet[k]++;
                        }
                    }
                }

            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool MapDezenas(out decimal[] Vdezenas, int dezena_final, int dezena_inicial)
        {

            Vdezenas = new decimal[dezena_final + 1];

            for (int i = 0; i < Vdezenas.Length; i++) Vdezenas[i] = 0;

            try
            {
                foreach (var jogo in MainWindow.Resultados)
                {
                    foreach (var dezena in jogo.Dezenas)
                    {
                        Vdezenas[dezena - dezena_inicial]++;
                    }
                }

            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool UltOcorrencias(out decimal[] Vdezenas, int dezena_final, int dezena_inicial)
        {

            Vdezenas = new decimal[dezena_final + 1];

            for (int i = 0; i < Vdezenas.Length; i++) Vdezenas[i] = 0;

            try
            {
                foreach (var jogo in MainWindow.Resultados)
                {
                    foreach (var dezena in jogo.Dezenas)
                    {
                        Vdezenas[dezena - dezena_inicial] = jogo.Sorteio;
                    }
                }

            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool MaxAtraso(out decimal[] Vdezenas, int num_dezenas, int dezena_final, int dezena_inicial)
        {

            decimal[] Vtmp = new decimal[dezena_final+1];
            Vdezenas = new decimal[dezena_final+1];

            for (int i = 0; i < Vdezenas.Length; i++){
                Vdezenas[i] = 0;
                Vtmp[i] = 0;
            }

            try
            {
                foreach (var jogo in MainWindow.Resultados)
                {
                    foreach (var dezena in jogo.Dezenas)
                    {
                        if (Vdezenas[dezena - dezena_inicial] <= ((jogo.Sorteio - Vtmp[dezena - dezena_inicial]) - 1))
                        {
                            Vdezenas[dezena - dezena_inicial] = ((jogo.Sorteio - Vtmp[dezena - dezena_inicial]) - 1);
                        }
                        Vtmp[dezena - dezena_inicial] = jogo.Sorteio;
                    }
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool SomaDezenas(out decimal[] VSomas)
        {
            VSomas = new decimal[MainWindow.Resultados.Count + 1];
            int soma = 0;
            int i = 0;
            try
            {
                foreach (var jogo in MainWindow.Resultados)
                {
                    foreach (var dezena in jogo.Dezenas)
                    {
                        soma += dezena;
                    }
                    VSomas[i] = soma;
                    i++;
                    soma = 0;
                }
            }
            catch { return false; }

            return true;
        }

        public bool CombinarDezenas(out decimal Sorteios, out List<Tuple<int, int>> ListaSorteios, out List<StructResultados> Matriz, int[] VDezenas, decimal s)
        {
            Sorteios = 0;
            int found = 0;
            AnaliseCombinatoria AnComb = new AnaliseCombinatoria();
            ulong[] iret;
            bool ret = AnComb.MainComb(1, VDezenas.Length, (int)s, 1, out iret);
            int[] Combinacoes = new int[iret[0]];
            Matriz = new List<StructResultados>();
            ListaSorteios = new List<Tuple<int,int>>();

            try
            {
                ret = AnComb.GeraCombinacoes(out Matriz, VDezenas, (int)s);
                if (ret)
                {
                    for (int j = 0; j < Matriz.Count; j++)
                    {
                        foreach (var jogo in MainWindow.Resultados)
                        {
                            found = 0;
                            for (int k = 0; k < Matriz[j].Dezenas.Count; k++)
                            {
                                foreach (var dezena in jogo.Dezenas)
                                {
                                    if (dezena == Matriz[j].Dezenas[k]) found++;
                                }
                                if (found == Matriz[j].Dezenas.Count)
                                {
                                    var tup = new Tuple<int, int>(j, jogo.Sorteio);
                                    ListaSorteios.Add(tup);
                                    Sorteios++;
                                }
                            }
                        }
                    }
                    return true;
                }
                else return false;
            }
            catch { return false; }
        }

        public bool SimularSorteios(decimal qtd_sorteios)
        {

            StructResultados Str_tmp =  new StructResultados();
            Str_tmp.Dezenas = new List<int>();
            int dezena = 0;
            bool achou = true;
            Random rnd = new Random(DateTime.Now.Millisecond);

            try
            {
                for (int i=0; i< qtd_sorteios;i++)
                {
                    for (int j = 0; j < MainWindow.dezenas_sorteadas; j++)
                    {
                        achou = false;
                        dezena = rnd.Next(MainWindow.dezena_inicial, MainWindow.dezena_final + 1);
                        for (int k = 0; k < Str_tmp.Dezenas.Count; k++)
                        {
                            if (Str_tmp.Dezenas[k] == dezena)
                            {
                                achou = true;
                                break;
                            }
                            else achou = false;
                        }
                        while (achou)
                        {
                            dezena = rnd.Next(MainWindow.dezena_inicial, MainWindow.dezena_final + 1);
                            for (int k = 0; k < Str_tmp.Dezenas.Count; k++)
                            {
                                if (Str_tmp.Dezenas[k] == dezena)
                                {
                                    achou = true;
                                    break;
                                }
                                else achou = false;
                            }
                        }
                        Str_tmp.Dezenas.Add(dezena);
                    }
                    Str_tmp.Sorteio = MainWindow.Resultados[MainWindow.Resultados.Count - 1].Sorteio + 1;
                    Str_tmp.Dezenas.Sort();
                    MainWindow.Resultados.Add(Str_tmp);
                    Str_tmp = new StructResultados();
                    Str_tmp.Dezenas = new List<int>();
                }
                return true;
            }
            catch { return false; }
        }

        public bool VerificaAntPos(int nAnt, int nSorteio, int nPos, out decimal[] vAnt, out decimal[] vPos, out List<List<int>> vDezenas)
        {
            try
            {
                int i = 0, j = 0, k = 0, y = 0;
                int delta = 0;
                int contador = 0;
                List<int> DezenasSorteio = new List<int>();
                vDezenas = new List<List<int>>();

                // Valida o intervalo Anteriores
                for (i = nAnt; i >= 0; i--)
                {
                    delta = (nSorteio + 1) - i;
                    if (delta >= 1) break;
                }
                nAnt = i;
                vAnt = new decimal[nAnt];

                // Valida o intervalo Posteiores
                for (i = nPos; i >= 0; i--)
                {
                    delta = (nSorteio + 1) + i;
                    if (delta <= MainWindow.total_jogos) break;
                }
                nPos = i;
                vPos = new decimal[nPos];


                for (i = 0; i < (nAnt + nPos); i++)
                    vDezenas.Add(new List<int>());

                // Copia as dezenas do Sorteio fornecido
                for (i = 0; i < MainWindow.dezenas_sorteadas; i++)
                    DezenasSorteio.Add(MainWindow.Resultados[nSorteio].Dezenas[i]);

                // Grava as % dos Sorteios Anteriores
                k = 0;
                y = 0;
                for (i = (nSorteio - nAnt); i < nSorteio; i++)
                {
                    contador = 0;
                    foreach (var Dezena in MainWindow.Resultados[i].Dezenas)
                    {
                        for (j = 0; j < DezenasSorteio.Count; j++)
                        {
                            if (DezenasSorteio[j] == Dezena)
                            {
                                vDezenas[y].Add(Dezena);
                                contador++;
                            }
                        }
                    }
                    vAnt[k] = (((decimal)contador * 100) / (decimal)MainWindow.dezenas_sorteadas);
                    k++;
                    y++;
                }

                // Grava as % dos Sorteios Posteriores
                k = 0;
                for (i = nSorteio + 1; i <= (nSorteio + nPos); i++)
                {
                    contador = 0;
                    foreach (var Dezena in MainWindow.Resultados[i].Dezenas)
                    {
                        for (j = 0; j < DezenasSorteio.Count; j++)
                        {
                            if (DezenasSorteio[j] == Dezena)
                            {
                                vDezenas[y].Add(Dezena);
                                contador++;
                            }
                        }
                    }
                    vPos[k] = ((decimal)(contador * 100) / (decimal)MainWindow.dezenas_sorteadas);
                    k++;
                    y++;
                }

                return true;
            }
            catch
            {
                vPos = new decimal[nPos];
                vAnt = new decimal[nAnt];
                vDezenas = new List<List<int>>();
                return false;
            }
        }
    }
}
