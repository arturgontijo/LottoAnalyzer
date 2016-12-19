using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LottoAnalyzer
{
    class AnaliseCombinatoria
    {
        public bool MainComb(int opt, int n, int k, int len, out ulong[] iret)
        {
            bool ret = false;
            iret = new ulong[len];
            int[] comb = new int[MainWindow.dezenas_jogadas];
            int z=0;

            try
            {
                switch (opt)
                {
                    case 1:
                        iret[0] = numCombin(n, k);
                        ret = true;
                        break;
                    case 2:
                        for (int i = 0; i < MainWindow.Resultados.Count; i++)
                        {
                            z = 0;
                            for (int j = 0; j < MainWindow.Resultados[i].Dezenas.Count; j++)
                            {
                                comb[z] = MainWindow.Resultados[i].Dezenas[j];
                                z++;
                            }
                            iret[i] = combToCsn(comb, MainWindow.num_dezenas);
                        }
                        ret = true;
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }

                return ret;
            }
            catch { return ret; }
        }
        /// <summary>
        /// Função para calcular o número de combinações de n, k a k.
        /// </summary>
        /// <remarks>Baseado no algoritmo ACM #160 de M. L. Wolfson e H. V. Wright (1963)</remarks>
        /// <param name="n">Tamanho do set</param>
        /// <param name="k">Tamanho do subset</param>
        /// <returns>Número de combinações</returns>
        public static ulong numCombin(int n, int k)
        {
            ulong ulk = (ulong)k;
            ulong uln = (ulong)n;
            ulong dif = uln - ulk;

            if (ulk < dif)
            {
                dif = ulk;
                ulk = uln - dif;
            }

            ulong combs = ulk + 1;
            if (dif == 0)
                combs = 1;
            else if (dif >= 2)
                for (ulong i = 2; i <= dif; i++)
                {
                    combs = (combs * (ulong)(ulk + i)) / i;
                    /* 
                     * Pequeno controle de erros - o C# é bastante tolerante com as operação envolvendo
                     * inteiros, deixando passar em silêncio o overflow, mas colocando o sinal negativo (o
                     * 1º bit fica a 1). Na operação seguinte, como é lógico, volta a ficar positivo
                     */
                    if (combs < 0)
                        throw new OverflowException("As combinações pedidas são superiores ao limite dos números inteiros - " + int.MaxValue);
                    /*
                     * A título de curiosidade, podíamos usar, em vez de int, uint, que dobrava a capacidade.
                     * No entanto, isso representaria um crescimento de, apenas, 2 a 5 lugares no tamanho dos
                     * sets. Muito melhor, seria usar long ou ulong. No entanto, para sistemas operativos de
                     * 32 bits, a função ficaria significativamente mais lenta. Por outro lado, ficaria
                     * bastante mais rápida em sistemas operativos de 64 bits.
                     */
                }

            return combs;
        }        /// <summary>
        /// Método para converter uma combinação em algo mais agradável á vista
        /// </summary>
        /// <param name="comb">Combinação a converter</param>
        /// <returns>Combinação em texto</returns>
        public static string combToString(int[] comb)
        {
            return combToString(comb, " ");
        }

        /// <summary>
        /// Método para converter uma combinação em algo mais agradável á vista
        /// </summary>
        /// <param name="comb">Combinação a converter</param>
        /// <param name="separador">Separador (ex.: " ", "-", ", ", etc.)</param>
        /// <returns>Combinação em texto</returns>
        public static string combToString(int[] comb, string separador)
        {
            string res = "";
            int tam = comb.Length;

            for (int i = 0; i < tam; i++)
            {
                if (i > 0)
                    res += separador;
                res += comb[i].ToString();
            }

            return res;
        }

        /// <summary>
        /// Método para converter um Número de Sequência de Combinação (CSN) para uma combinação
        /// </summary>
        /// <remarks>Baseado no algoritmo ACM #515 de B. P. Buckles e M. Lyabanon (1974)</remarks>
        /// <param name="csn">Número de Sequência de Combinação</param>
        /// <param name="n">Tamanho do set</param>
        /// <param name="k">Tamanho do subset</param>
        /// <returns>Combinação em array</returns>
        public static int[] csnToComb(int csn, int n, int k)
        {
            int lbound = 0;
            int r = 0;
            int[] comb = new int[k];

            for (int i = 0; i < (k - 1); i++)
            {
                // colocar sempre o valor a 0
                comb[i] = 0;
                // se a posição não for a 0, podemos copiar o valor de trás
                // se for... bem, atrás não está nada e, não sei porquê, os computadores gostam pouco disso...
                if (i != 0) comb[i] = comb[i - 1];
                // fazer isto pelo menos uma vez (porque o valor ou está a 0 ou está igual ao precedente)
                do
                {
                    // incrementar o bitxo
                    comb[i]++;

                    /*
                    * E aqui é melhor dar um exemplo prático...
                    * Imaginemos que estamos na chave 1-2-3-4-5 e o nosso número máximo é o 10
                    * Queremos a chave seguinte, isto é, CSN = 2, já estivemos em i=0, 1 e 2, vamos no 3;
                    * chegamos aqui assim: 1-2-3-4-5 (o valor 4 mantém-se porque causa ali do ++);
                    * então, numCombin(10 - 3, (5 - 1) - 3) = 21
                    * depois disto tudo, o lbound ainda está a zero (ver mais abaixo porquê)
                    * aumentamos o lbound para em mais 21 e, como é superior ao pedido (2) seguimos viagem
                    * (continua abaixo)
                    */
                    r = (int)AnaliseCombinatoria.numCombin((n - comb[i]), ((k - 1) - i));
                    lbound += r;
                } while (lbound < csn);
                // (porquê aqui) ao lbound actual, tiramos a última combinação parcial, do exemplo, 21
                lbound -= r;
            }
            // e agora, depois das posições 0, 1, 2 e 3, vamos tratar da última posição
            // que vai ser igual à posição anterior + o CSN pedido - o lbound actual
            // logo, do exemplo, 4 + 2 - 0 = 6
            comb[k - 1] = comb[k - 2] + csn - lbound;

            return (int[])comb.Clone();
        }

        /// <summary>
        /// Método para converter uma combinação num CSN
        /// </summary>
        /// <param name="comb">Combinação</param>
        /// <param name="n">Tamanho do set</param>
        /// <returns>CSN (inteiro)</returns>
        public static ulong combToCsn(int[] comb, int n)
        {
            ulong k = (ulong)comb.Length;
            ulong lbound = 0;
            ulong r = 0;

            // pormenor importante: estritamente, deveria ser (int i = 0; i < k; i++), mas como vamos usar i sozinho várias vezes abaixo, podemos "esquecer" isso...
            for (ulong i = 1; i <= k; i++)
            {
                r = (ulong)(n - comb[k - i]);
                if (r >= i)
                    lbound += AnaliseCombinatoria.numCombin((int)r, (int)i);
            }

            return AnaliseCombinatoria.numCombin((int)n, (int)k) - lbound;
        }

        public bool GeraCombinacoes(out List<StructResultados> Matriz, int[] VDezenas, int s)
        {
            Matriz = new List<StructResultados>();
            StructResultados StrTmp = new StructResultados();
            StrTmp.Dezenas = new List<int>(s);
            int i = 0, j = 0;
	        int n = VDezenas.Length;
            int[] VCombIndex = new int[s];

            int len = (int)AnaliseCombinatoria.numCombin(VDezenas.Length, s);
            if (len >= 252)
            {
                if (System.Windows.Forms.MessageBox.Show("Encontradas " + len.ToString() + " Combinações! Continuar com Processamento?", "TearDown - Imprimir " + MainWindow.NomeLoteria, System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return false;
                }
            }

            // Primeira Combinação
	        for (i = 0; i < s; ++i)
		        VCombIndex[i] = i;

	        // Pega as Dezenas em VDezenas de acordo com os indices da primeira combinação
            for (j = 0; j < VCombIndex.Length; j++) StrTmp.Dezenas.Add(VDezenas[VCombIndex[j]]);
            Matriz.Add(StrTmp);

            int ret = 1;
	        // Pega as outras dezenas em VDezenas de acordo com os indices das outras combinações
            while (ret != 0)
            {
                ret = ProxCombinacao(VCombIndex, s, n);
                if (ret == 0) break;
                StrTmp = new StructResultados();
                StrTmp.Dezenas = new List<int>(s);
                for (j = 0; j < VCombIndex.Length; j++) StrTmp.Dezenas.Add(VDezenas[VCombIndex[j]]);
                Matriz.Add(StrTmp);
            }

            return true;
        }

        // Retorna 0 se n existe mais combinacoes possiveis
        public int ProxCombinacao(int[] VCombIndex, int k, int n)
        {
            int i = k - 1;
            ++VCombIndex[i];
            while ((i > 0) && (VCombIndex[i] >= n - k + 1 + i))
            {
                --i;
                ++VCombIndex[i];
            }

            if (VCombIndex[0] > n - k)
                return 0;

            for (i = i + 1; i < k; ++i)
                VCombIndex[i] = VCombIndex[i - 1] + 1;

            return 1;
        }
    }
}
