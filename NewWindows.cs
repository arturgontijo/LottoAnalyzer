using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LottoAnalyzer
{
    class NewWindows
    {
        public static Form Janela;
        public static List<NumericUpDown> ListaNUP = new List<NumericUpDown>();
        public static List<CheckBox> ListaCB = new List<CheckBox>();
        public static RichTextBox LOG;
        public static TextBox tbTmp;
        public static NumericUpDown nupTmp;
        public static int num1 = 0, num2 = 0, contadorChecked = 1;

        public void NewWindowAnalisador(RichTextBox LOG_tmp, String title)
        {
            // Verifica se a janela já está aberta.
            if (Janela != null)          
            {
                Janela.Close();
            }

            Button bTestar = new System.Windows.Forms.Button();
            NumericUpDown nup11 = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nup12 = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nup13 = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nup14 = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nup15 = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nupJogos = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nupDezenas = new System.Windows.Forms.NumericUpDown();
            TextBox tbListaFixes = new System.Windows.Forms.TextBox();
            TextBox tbNFixas = new System.Windows.Forms.TextBox();
            TextBox tbNSoltas = new System.Windows.Forms.TextBox();
            Label lbJogos = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            Label label4 = new System.Windows.Forms.Label();
            Label label5 = new System.Windows.Forms.Label();
            Label label6 = new System.Windows.Forms.Label();
            Label label7 = new System.Windows.Forms.Label();
            Label label8 = new System.Windows.Forms.Label();
            Label label9 = new System.Windows.Forms.Label();
            Label label10 = new System.Windows.Forms.Label();
            Label label11 = new System.Windows.Forms.Label();
            ListBox listbDezenas = new System.Windows.Forms.ListBox();

            LOG = LOG_tmp;

            // Verifica se a janela já está aberta.
            if (Janela != null)
            {
                Janela.Close();

                // Limpando a Lista de NUP
                ListaNUP.Clear();
            }

            // 
            // bTestar
            // 
            bTestar.Location = new System.Drawing.Point(59, 294);
            bTestar.Name = "bTestar";
            bTestar.Size = new System.Drawing.Size(170, 30);
            bTestar.TabIndex = 0;
            bTestar.Text = "Testar";
            bTestar.UseVisualStyleBackColor = true;
            bTestar.Click += new System.EventHandler(bTestar_Click);
            // 
            // nup11
            // 
            nup11.Location = new System.Drawing.Point(220, 147);
            nup11.Name = "nup11";
            nup11.Size = new System.Drawing.Size(60, 20);
            nup11.TabIndex = 1;
            nup11.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // lbJogos
            // 
            lbJogos.AutoSize = true;
            lbJogos.Location = new System.Drawing.Point(12, 15);
            lbJogos.Name = "lbJogos";
            lbJogos.Size = new System.Drawing.Size(49, 13);
            lbJogos.TabIndex = 6;
            lbJogos.Text = "Dezenas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(170, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 13);
            label1.TabIndex = 7;
            label1.Text = "Soltas";
            // 
            // nup12
            // 
            nup12.Location = new System.Drawing.Point(220, 173);
            nup12.Name = "nup12";
            nup12.Size = new System.Drawing.Size(60, 20);
            nup12.TabIndex = 8;
            nup12.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nup13
            // 
            nup13.Location = new System.Drawing.Point(220, 199);
            nup13.Name = "nup13";
            nup13.Size = new System.Drawing.Size(60, 20);
            nup13.TabIndex = 9;
            nup13.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nup14
            // 
            nup14.Location = new System.Drawing.Point(220, 225);
            nup14.Name = "nup14";
            nup14.Size = new System.Drawing.Size(60, 20);
            nup14.TabIndex = 10;
            nup14.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // nup15
            // 
            nup15.Location = new System.Drawing.Point(220, 251);
            nup15.Name = "nup15";
            nup15.Size = new System.Drawing.Size(60, 20);
            nup15.TabIndex = 11;
            nup15.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // tbListaFixes
            // 
            tbListaFixes.Location = new System.Drawing.Point(12, 62);
            tbListaFixes.Name = "tbListaFixes";
            tbListaFixes.Size = new System.Drawing.Size(268, 20);
            tbListaFixes.TabIndex = 12;
            // 
            // tbNFixas
            // 
            tbNFixas.Location = new System.Drawing.Point(46, 88);
            tbNFixas.Name = "tbNFixas";
            tbNFixas.Size = new System.Drawing.Size(68, 20);
            tbNFixas.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 13);
            label2.TabIndex = 15;
            label2.Text = "Fixas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(195, 149);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(19, 13);
            label3.TabIndex = 16;
            label3.Text = "11";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(195, 175);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(19, 13);
            label4.TabIndex = 17;
            label4.Text = "12";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(195, 201);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(19, 13);
            label5.TabIndex = 18;
            label5.Text = "13";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(195, 227);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(19, 13);
            label6.TabIndex = 19;
            label6.Text = "14";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(195, 253);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(19, 13);
            label7.TabIndex = 20;
            label7.Text = "15";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(180, 124);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(43, 13);
            label8.TabIndex = 21;
            label8.Text = "Acertos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(240, 124);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(15, 13);
            label9.TabIndex = 22;
            label9.Text = "%";
            // 
            // tbNSoltas
            // 
            tbNSoltas.Location = new System.Drawing.Point(212, 88);
            tbNSoltas.Name = "tbNSoltas";
            tbNSoltas.Size = new System.Drawing.Size(68, 20);
            tbNSoltas.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(179, 15);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(35, 13);
            label10.TabIndex = 25;
            label10.Text = "Jogos";
            // 
            // nupJogos
            // 
            nupJogos.Location = new System.Drawing.Point(220, 13);
            nupJogos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupJogos.Name = "nupJogos";
            nupJogos.Size = new System.Drawing.Size(60, 20);
            nupJogos.TabIndex = 26;
            nupJogos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(96, 46);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(101, 13);
            label11.TabIndex = 27;
            label11.Text = "Lista Dezenas Fixas";
            // 
            // listbDezenas
            // 
            listbDezenas.FormattingEnabled = true;
            listbDezenas.Location = new System.Drawing.Point(12, 147);
            listbDezenas.Name = "listbDezenas";
            listbDezenas.Size = new System.Drawing.Size(163, 121);
            listbDezenas.TabIndex = 28;
            // 
            // nupDezenas
            // 
            nupDezenas.Location = new System.Drawing.Point(67, 13);
            nupDezenas.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            nupDezenas.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            nupDezenas.Name = "nupDezenas";
            nupDezenas.Size = new System.Drawing.Size(60, 20);
            nupDezenas.TabIndex = 29;
            nupDezenas.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Janela
            //
            Janela = new Form();
            Janela.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            Janela.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Janela.ClientSize = new System.Drawing.Size(305, 340);
            Janela.Controls.Add(nupDezenas);
            Janela.Controls.Add(listbDezenas);
            Janela.Controls.Add(label11);
            Janela.Controls.Add(nupJogos);
            Janela.Controls.Add(label10);
            Janela.Controls.Add(tbNSoltas);
            Janela.Controls.Add(label9);
            Janela.Controls.Add(label8);
            Janela.Controls.Add(label7);
            Janela.Controls.Add(label6);
            Janela.Controls.Add(label5);
            Janela.Controls.Add(label4);
            Janela.Controls.Add(label3);
            Janela.Controls.Add(label2);
            Janela.Controls.Add(tbNFixas);
            Janela.Controls.Add(tbListaFixes);
            Janela.Controls.Add(nup15);
            Janela.Controls.Add(nup14);
            Janela.Controls.Add(nup13);
            Janela.Controls.Add(nup12);
            Janela.Controls.Add(label1);
            Janela.Controls.Add(lbJogos);
            Janela.Controls.Add(nup11);
            Janela.Controls.Add(bTestar);
            Janela.Name = "Janela";
            Janela.Text = MainWindow.APP_NAME + " - Testar LotoFácil";

            Janela.Show();

            System.Drawing.Size SizeMaxMin = new System.Drawing.Size(Janela.ClientSize.Width, Janela.ClientSize.Height + 40);

            // Impede que o user redefina as dimensoes da janela
            Janela.MaximumSize = Janela.MinimumSize = SizeMaxMin;

            Janela.Refresh();

        }

        private void bTestar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok");
        }

        private void bGerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok");
        }

        public void NewWindowMapear(RichTextBox LOG_tmp)
        {

            LOG = LOG_tmp;

            // Verifica se a janela já está aberta.
            if (Janela != null)
            {
                Janela.Close();

                // Limpando a Lista de NUP
                ListaNUP.Clear();
            }

            Button bMapear = new System.Windows.Forms.Button();
            NumericUpDown nupInicio = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nupFim = new System.Windows.Forms.NumericUpDown();
            Label label1 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            Button bMapearAddIntervalo = new System.Windows.Forms.Button();
            Button bMapearRemoveIntervalo = new System.Windows.Forms.Button();
            // 
            // bMapear
            // 
            bMapear.Location = new System.Drawing.Point(228, 23);
            bMapear.Name = "bMapear";
            bMapear.Size = new System.Drawing.Size(52, 45);
            bMapear.TabIndex = 0;
            bMapear.Text = "Mapear";
            bMapear.UseVisualStyleBackColor = true;
            bMapear.Click += new System.EventHandler(bMapear_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(116, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 13);
            label1.TabIndex = 1;
            label1.Text = "Intervalo (s)";
            // 
            // nupInicio
            // 
            nupInicio.Location = new System.Drawing.Point(58, 122);
            nupInicio.Maximum = new decimal(new int[] {
            MainWindow.dezena_final,
            0,
            0,
            0});
            nupInicio.Minimum = new decimal(new int[] {
            MainWindow.dezena_inicial,
            0,
            0,
            0});
            nupInicio.Name = "nupInicio";
            nupInicio.Size = new System.Drawing.Size(60, 20);
            nupInicio.TabIndex = 2;
            nupInicio.Value = new decimal(new int[] {
            MainWindow.dezena_inicial,
            0,
            0,
            0});
            // 
            // nupFim
            // 
            nupFim.Location = new System.Drawing.Point(172, 122);
            nupFim.Maximum = new decimal(new int[] {
            MainWindow.dezena_final,
            0,
            0,
            0});
            nupFim.Minimum = new decimal(new int[] {
            MainWindow.dezena_inicial,
            0,
            0,
            0});
            nupFim.Name = "nupFim";
            nupFim.Size = new System.Drawing.Size(60, 20);
            nupFim.TabIndex = 3;
            nupFim.Value = new decimal(new int[] {
            MainWindow.dezena_final,
            0,
            0,
            0});
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(72, 105);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 13);
            label2.TabIndex = 4;
            label2.Text = "Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(182, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(23, 13);
            label3.TabIndex = 5;
            label3.Text = "Fim";
            // 
            // BAdicionar
            // 
            bMapearAddIntervalo.Location = new System.Drawing.Point(12, 23);
            bMapearAddIntervalo.Name = "Adicionar";
            bMapearAddIntervalo.Size = new System.Drawing.Size(63, 45);
            bMapearAddIntervalo.TabIndex = 6;
            bMapearAddIntervalo.Text = "Adicionar";
            bMapearAddIntervalo.UseVisualStyleBackColor = true;
            bMapearAddIntervalo.Click += new System.EventHandler(bMapearAddIntervalo_Click);
            // 
            // bRemover
            // 
            bMapearRemoveIntervalo.Location = new System.Drawing.Point(93, 23);
            bMapearRemoveIntervalo.Name = "Remover";
            bMapearRemoveIntervalo.Size = new System.Drawing.Size(63, 45);
            bMapearRemoveIntervalo.TabIndex = 7;
            bMapearRemoveIntervalo.Text = "Remover";
            bMapearRemoveIntervalo.UseVisualStyleBackColor = true;
            bMapearRemoveIntervalo.Click += new System.EventHandler(bMapearRemoveIntervalo_Click);

            // Adicionando os NUP à Lista
            ListaNUP.Add(nupInicio);
            ListaNUP.Add(nupFim);

            // 
            // Janela
            //
            Janela = new Form();
            Janela.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            Janela.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Janela.ClientSize = new System.Drawing.Size(310, 147);
            Janela.Controls.Add(bMapearRemoveIntervalo);
            Janela.Controls.Add(bMapearAddIntervalo);
            Janela.Controls.Add(label3);
            Janela.Controls.Add(nupInicio);
            Janela.Controls.Add(label2);
            Janela.Controls.Add(label1);
            Janela.Controls.Add(nupFim);
            Janela.Controls.Add(bMapear);
            Janela.Name = "Janela";
            Janela.Text = MainWindow.APP_NAME + " - Mapear " + MainWindow.NomeLoteria;

            Janela.Show();

            System.Drawing.Size SizeMaxMin = new System.Drawing.Size(Janela.ClientSize.Width, Janela.ClientSize.Height + 40); 

            // Impede que o user redefina as dimensoes da janela
            Janela.MaximumSize = Janela.MinimumSize = SizeMaxMin;

            Janela.Refresh();
        }

        private void bMapearAddIntervalo_Click(object sender, EventArgs e)
        {
            if (ListaNUP.Count < 20)
            {
                MainWindow.total_dezenas = MainWindow.Resultados.Count * MainWindow.dezenas_sorteadas;
                MainWindow.total_jogos = MainWindow.Resultados.Count;
                GeraNovoIntervalo();
            }
            else MessageBox.Show("Máximo 10 Intervalos.");
        }

        private void GeraNovoIntervalo()
        {
            NumericUpDown nupInicio = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nupFim = new System.Windows.Forms.NumericUpDown();
            int index_ult = 0;

            // Acha o ultimo NUP adicionado à Lista
            index_ult = ListaNUP.Count - 1;

            // 
            // nupInicio
            // 
            nupInicio.Location = new System.Drawing.Point(58, ListaNUP[index_ult].Location.Y + 26);
            nupInicio.Maximum = new decimal(new int[] {
            MainWindow.dezena_final,
            0,
            0,
            0});
            nupInicio.Minimum = new decimal(new int[] {
            MainWindow.dezena_inicial,
            0,
            0,
            0});
            nupInicio.Name = "nupInicio";
            nupInicio.Size = new System.Drawing.Size(60, 20);
            nupInicio.TabIndex = index_ult + 7;
            nupInicio.Value = new decimal(new int[] {
            MainWindow.dezena_inicial,
            0,
            0,
            0});
            // 
            // nupFim
            // 
            nupFim.Location = new System.Drawing.Point(172, ListaNUP[index_ult].Location.Y + 26);
            nupFim.Maximum = new decimal(new int[] {
            MainWindow.dezena_final,
            0,
            0,
            0});
            nupFim.Minimum = new decimal(new int[] {
            MainWindow.dezena_inicial,
            0,
            0,
            0});
            nupFim.Name = "nupFim";
            nupFim.Size = new System.Drawing.Size(60, 20);
            nupFim.TabIndex = index_ult + 8;
            nupFim.Value = new decimal(new int[] {
            MainWindow.dezena_final,
            0,
            0,
            0});

            // Adicionando os NUP à Lista
            ListaNUP.Add(nupInicio);
            ListaNUP.Add(nupFim);

            Janela.Controls.Add(nupInicio);
            Janela.Controls.Add(nupFim);
            Janela.ClientSize = new System.Drawing.Size(310, nupFim.Location.Y + 25);

            System.Drawing.Size SizeMaxMin = new System.Drawing.Size(Janela.ClientSize.Width, Janela.ClientSize.Height + 40);

            // Impede que o user redefina as dimensoes da janela
            Janela.MaximumSize = Janela.MinimumSize = SizeMaxMin;

            Janela.Refresh();
        }

        private void bMapearRemoveIntervalo_Click(object sender, EventArgs e)
        {
            if (ListaNUP.Count > 2)
            {
                MainWindow.total_dezenas = MainWindow.Resultados.Count * MainWindow.dezenas_sorteadas;
                MainWindow.total_jogos = MainWindow.Resultados.Count;
                RemoveIntervalo();
            }
            else MessageBox.Show("Mínimo 1 Intervalo.");
        }

        public void RemoveIntervalo()
        {
            int index_ult = 0;

            // Acha o ultimo NUP adicionado à Lista
            index_ult = ListaNUP.Count - 1;

            // Remove os 2 ultimos NUPs da Janela e da Lista
            Janela.Controls.Remove(ListaNUP[index_ult]);
            Janela.Controls.Remove(ListaNUP[index_ult - 1]);
            Janela.ClientSize = new System.Drawing.Size(310, ListaNUP[index_ult - 2].Location.Y + 25);
            System.Drawing.Size SizeMaxMin = new System.Drawing.Size(Janela.ClientSize.Width, Janela.ClientSize.Height + 40);
            // Impede que o user redefina as dimensoes da janela
            Janela.MaximumSize = Janela.MinimumSize = SizeMaxMin;
            Janela.Refresh();

            ListaNUP.RemoveAt(index_ult);
            ListaNUP.RemoveAt(index_ult - 1);
        }

        private void bMapear_Click(object sender, EventArgs e)
        {
            if (ListaNUP.Count >= 2 && ListaNUP.Count <= 20)
            {
                MapearIntervalos();
            }
            else MessageBox.Show("Mín: 1, Máx: 10 - Intervalos.");
        }

        public void MapearIntervalos()
        {
            int Vindex = (ListaNUP.Count / 2);
            int k=0, i=0;
            decimal[] VRet;
            decimal total = 0;
            int[] VMin, VMax;
            bool ret = false;

            VMin = new int[Vindex];
            VMax = new int[Vindex];

            // Pega todos os Intervalos
            for (i=0; i<ListaNUP.Count;i++)
            {
                // Caso seja par = Inicio
                if (i % 2 == 0) VMin[k] = (int)ListaNUP[i].Value;
                // Caso seja impar = Inicio
                else
                {
                    VMax[k] = (int)ListaNUP[i].Value;
                    k++;
                }
            }

            Funcionalidades func = new Funcionalidades();
            ret = func.MapIntervalos(out VRet, VMin, VMax);

            LOG.Text = "Mapeando Intervalo(s)\n\n";
            LOG.Text += "Intervalo(s)\tAparições\t\t%\n";
            if (ret)
            {
                total = 0;
                for (i = 0; i < VRet.Length; i++)
                {
                    LOG.Text += "[" + VMin[i].ToString("00") + " - " + VMax[i].ToString("00") + "]\t\t" + VRet[i].ToString() + "\t\t" + ((VRet[i] * 100) / MainWindow.total_dezenas).ToString("0.000") + "\n";
                    // TOTAL
                    total += VRet[i];
                }

                LOG.Text += "\n[TOTAL]\t\t" + total.ToString() + "\t\t" + ((total * 100) / MainWindow.total_dezenas).ToString("0.000") + "\n";
            }
        }

        public void NewWindowCombinar(RichTextBox LOG_tmp)
        {
            double raiz = Math.Sqrt(MainWindow.num_dezenas);
            int aprox = 0, i = 0, k = 0;
            int linhas = 0, colunas = 0;
            int tab_ind = 0;
            int dezena = 0;

            aprox = (int)raiz;
            for (i = aprox; i > 0; i--)
            {
                if ((MainWindow.num_dezenas % i) == 0)
                {
                    linhas = i;
                    colunas = MainWindow.num_dezenas / i;
                    break;
                }
            }

            for (k = 0; k < linhas; k++)
            {
                for (i = 0; i < colunas; i++)
                {

                }
            }

            LOG = LOG_tmp;

            // Verifica se a janela já está aberta.
            if (Janela != null)
            {
                Janela.Close();

                // Limpando a Lista de CheckBox
                ListaCB.Clear();

                // Limpando a Lista de NumericUpDown
                ListaNUP.Clear();
            }

            Button bCombinar = new System.Windows.Forms.Button();
            Label label1;
            CheckBox checkBox1;
            NumericUpDown nupS;

            // Cria a nova janela pra já add os Labels e CheckBox nos loops a seguir
            Janela = new Form();

            tab_ind = 1;
            dezena = MainWindow.dezena_inicial;
            for (i = 0; i < linhas; i++)
            {
                for (k = 0; k < colunas; k++)
                {
                    // 
                    // label
                    //
                    label1 = new Label();
                    label1.AutoSize = true;
                    label1.Location = new System.Drawing.Point(35 + (55 * k), 70 + (20 * i));
                    label1.Name = "label1";
                    label1.Size = new System.Drawing.Size(19, 13);
                    label1.TabIndex = tab_ind;
                    label1.Text = dezena.ToString("00");
                    tab_ind++;
                    // 
                    // checkBox
                    //
                    checkBox1 = new CheckBox();
                    checkBox1.AutoSize = true;
                    checkBox1.Location = new System.Drawing.Point(60 + (55 * k), 70 + (20 * i));
                    checkBox1.Name = dezena.ToString("00");
                    checkBox1.Size = new System.Drawing.Size(15, 14);
                    checkBox1.TabIndex = tab_ind;
                    checkBox1.UseVisualStyleBackColor = true;
                    checkBox1.CheckedChanged += new System.EventHandler(checkBoxCombinar_CheckedChanged);
                    tab_ind++;

                    dezena++;

                    // Adicionando os NUP à Lista
                    ListaCB.Add(checkBox1);
                    Janela.Controls.Add(label1);
                    Janela.Controls.Add(checkBox1);
                }

            }
            // bCombinar
            // 
            bCombinar.Location = new System.Drawing.Point(35, 10);
            bCombinar.Name = "bCombinar";
            bCombinar.Size = new System.Drawing.Size((ListaCB[ListaCB.Count - 1].Location.X-25)/2, 45);
            bCombinar.TabIndex = 0;
            bCombinar.Text = "Combinar";
            bCombinar.UseVisualStyleBackColor = true;
            bCombinar.Click += new System.EventHandler(bCombinar_Click);

            // 
            // label
            //
            label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(((ListaCB[ListaCB.Count - 1].Location.X - 25) / 2)+40, 22);
            label1.Name = "S";
            label1.Size = new System.Drawing.Size(19, 13);
            label1.TabIndex = tab_ind;
            label1.Text = "Combinar em";
            tab_ind++;

            // 
            // nupS
            //
            nupS = new System.Windows.Forms.NumericUpDown();
            nupS.Location = new System.Drawing.Point(((ListaCB[ListaCB.Count - 1].Location.X - 25) / 2) + 115, 20);
            nupS.Maximum = new decimal(new int[] {
            contadorChecked,
            0,
            0,
            0});
            nupS.Minimum = new decimal(new int[] {
            MainWindow.dezena_inicial,
            0,
            0,
            0});
            nupS.Name = "nupS";
            nupS.Size = new System.Drawing.Size(60, 20);
            nupS.TabIndex = tab_ind;
            nupS.Value = new decimal(new int[] {
            MainWindow.dezena_inicial,
            0,
            0,
            0});
            nupS.ValueChanged += new System.EventHandler(nupCombinar_ValueChanged);
            ListaNUP.Add(nupS);

            // 
            // Janela
            //
            Janela.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            Janela.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Janela.ClientSize = new System.Drawing.Size(ListaCB[ListaCB.Count - 1].Location.X + 70, ListaCB[ListaCB.Count - 1].Location.Y + 20);
            Janela.Controls.Add(bCombinar);
            Janela.Controls.Add(label1);
            Janela.Controls.Add(nupS);
            Janela.Name = "Janela";
            Janela.Text = MainWindow.APP_NAME + " - Combinar " + MainWindow.NomeLoteria;

            Janela.Show();

            System.Drawing.Size SizeMaxMin = new System.Drawing.Size(Janela.ClientSize.Width, Janela.ClientSize.Height + 40);

            // Impede que o user redefina as dimensoes da janela
            Janela.MaximumSize = Janela.MinimumSize = SizeMaxMin;

            Janela.Refresh();
        }

        private void checkBoxCombinar_CheckedChanged(object sender, EventArgs e)
        {

            NumericUpDown nup_tmp;

            contadorChecked = 0;
            for (int i = 0; i < ListaCB.Count; i++)
            {
                if (ListaCB[i].Checked) contadorChecked++;
            }

            if (contadorChecked == 0) contadorChecked = 1;

            nup_tmp = (NumericUpDown)Janela.Controls[Janela.Controls.Count - 1];
            nup_tmp.Maximum = new decimal(new int[] {
            contadorChecked,
            0,
            0,
            0});
            nup_tmp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nup_tmp.Value = new decimal(new int[] {
            contadorChecked,
            0,
            0,
            0});
        }

        private void nupCombinar_ValueChanged(object sender, EventArgs e)
        {
        }

        private void bCombinar_Click(object sender, EventArgs e)
        {
            int i = 0, range = 0, inicio = 0, passo = 0;
            int[] VDezenas;
            List<Tuple<int, int>> ListaSorteios = new List<Tuple<int, int>>();
            decimal sorteios;
            bool ret = false, continua = true;

            try
            {

                MainWindow.total_dezenas = MainWindow.Resultados.Count * MainWindow.dezenas_sorteadas;
                MainWindow.total_jogos = MainWindow.Resultados.Count;

                foreach (CheckBox cb in ListaCB)
                {
                    if (cb.Checked) i++;
                }

                VDezenas = new int[i];

                i = 0;
                foreach (CheckBox cb in ListaCB)
                {
                    if (cb.Checked)
                    {
                        VDezenas[i] = Convert.ToInt32(cb.Name);
                        i++;
                    }
                }

                if (VDezenas.Length > 0)
                {
                    List<StructResultados> Matriz;
                    Funcionalidades func = new Funcionalidades();
                    ret = func.CombinarDezenas(out sorteios, out ListaSorteios, out Matriz, VDezenas, ListaNUP[0].Value);

                    if (ret)
                    {
                        LOG.Text = "Combinação:\n\n" + VDezenas.Length.ToString() + " Dezenas [";

                        for (i = 0; i < VDezenas.Length; i++)
                        {
                            LOG.Text += VDezenas[i].ToString("00");
                            if (i == VDezenas.Length - 1) break;
                            LOG.Text += ",";
                        }

                        LOG.Text += "],\n Combinadas";
                        LOG.Text += " " + ListaNUP[0].Value.ToString() + " a " + ListaNUP[0].Value.ToString() + "\n\n";
                        range = Matriz.Count;
                        decimal contador = 0;

                        LOG.Text += "Combinação = [%]\n";
                        while (continua)
                        {
                            passo = 0;
                            for (i = inicio; i < range; i++)
                            {
                                LOG.Text += "[";
                                for (int y = 0; y < Matriz[i].Dezenas.Count; y++)
                                {
                                    LOG.Text += Matriz[i].Dezenas[y].ToString("00");
                                    if (y == Matriz[i].Dezenas.Count - 1)
                                    {
                                        LOG.Text += "] = ";
                                        break;
                                    }
                                    LOG.Text += ",";
                                }

                                contador = 0;
                                for (int l = 0; l < ListaSorteios.Count; l++)
                                {
                                    if (i == ListaSorteios[l].Item1) contador++;
                                }
                                LOG.Text += ((contador * 100) / MainWindow.total_jogos).ToString("0.000") + " %\n";
                                passo++;
                            }

                            if (passo >= 100)
                            {
                                if (MessageBox.Show("Impressos " + (inicio + 100).ToString() + "/" + range.ToString() + " Sorteios. Continuar Imprimindo?", MainWindow.APP_NAME + " - Imprimir " + MainWindow.NomeLoteria, MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    continua = true;
                                    inicio += 100;
                                }
                                else continua = false;
                            }
                            else continua = false;
                        }
                    }
                }
                else LOG.Text = "Escolha pelo menos 1 dezena.";
            }
            catch { }
        }

        public void NewWindowSimular(RichTextBox LOG_tmp, TextBox tbJogosTmp)
        {
            Button bSimular = new System.Windows.Forms.Button();
            NumericUpDown numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            Label lbJogos = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();

            // Verifica se a janela já está aberta.
            if (Janela != null)
            {
                Janela.Close();
            }

            // 
            // bVerificar
            // 
            bSimular.Location = new System.Drawing.Point(57, 55);
            bSimular.Name = "bSimular";
            bSimular.Size = new System.Drawing.Size(170, 30);
            bSimular.TabIndex = 0;
            bSimular.Text = "Simular";
            bSimular.UseVisualStyleBackColor = true;
            bSimular.Click += new System.EventHandler(bSimular_Click);
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(118, 16);
            numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(60, 20);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbJogos
            // 
            lbJogos.AutoSize = true;
            lbJogos.Location = new System.Drawing.Point(71, 18);
            lbJogos.Name = "lbJogos";
            lbJogos.Size = new System.Drawing.Size(41, 13);
            lbJogos.TabIndex = 6;
            lbJogos.Text = "Simular";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(184, 18);
            label1.Name = "lbSorteios";
            label1.Size = new System.Drawing.Size(45, 13);
            label1.TabIndex = 7;
            label1.Text = "Sorteios";
            // 
            // Janela
            //
            Janela = new Form();
            Janela.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            Janela.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Janela.ClientSize = new System.Drawing.Size(292, 97);
            Janela.Controls.Add(label1);
            Janela.Controls.Add(lbJogos);
            Janela.Controls.Add(numericUpDown1);
            Janela.Controls.Add(bSimular);
            Janela.Name = "Janela";
            Janela.Text = MainWindow.APP_NAME + " - Simular " + MainWindow.NomeLoteria;

            nupTmp = numericUpDown1;
            LOG = LOG_tmp;
            tbTmp = tbJogosTmp;

            Janela.Show();

            System.Drawing.Size SizeMaxMin = new System.Drawing.Size(Janela.ClientSize.Width, Janela.ClientSize.Height + 40);

            // Impede que o user redefina as dimensoes da janela
            Janela.MaximumSize = Janela.MinimumSize = SizeMaxMin;

            Janela.Refresh();
        }

        private void bSimular_Click(object sender, EventArgs e)
        {
            bool ret = false;
            Funcionalidades func = new Funcionalidades();

            try
            {
                ret = func.SimularSorteios(nupTmp.Value);
                if(ret)
                {
                    tbTmp.Text = MainWindow.Resultados.Count.ToString();
                }
            }
            catch { }
        }

        public void NewWindowAnaliseCombinatoria(RichTextBox LOG_tmp, TextBox tb_tmp)
        {
            Button bCalcular = new System.Windows.Forms.Button();
            Button button2 = new System.Windows.Forms.Button();
            Button button1 = new System.Windows.Forms.Button();
            Label lbJogos = new System.Windows.Forms.Label();
            Label label10 = new System.Windows.Forms.Label();
            NumericUpDown nupS = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nupN = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nupCSN = new System.Windows.Forms.NumericUpDown();
            Label label11 = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();

            // Verifica se a janela já está aberta.
            if (Janela != null)
            {
                Janela.Close();

                // Limpando a Lista de NUP
                ListaNUP.Clear();
            }

            // 
            // bCalcular
            // 
            bCalcular.Location = new System.Drawing.Point(56, 77);
            bCalcular.Name = "bCalcular";
            bCalcular.Size = new System.Drawing.Size(170, 30);
            bCalcular.TabIndex = 0;
            bCalcular.Text = "Calcular";
            bCalcular.UseVisualStyleBackColor = true;
            bCalcular.Click += new System.EventHandler(bCalcularCombinacao_Click);
            // 
            // lbJogos
            // 
            lbJogos.AutoSize = true;
            lbJogos.Location = new System.Drawing.Point(96, 27);
            lbJogos.Name = "lbJogos";
            lbJogos.Size = new System.Drawing.Size(13, 13);
            lbJogos.TabIndex = 6;
            lbJogos.Text = "n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(97, 53);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(12, 13);
            label10.TabIndex = 25;
            label10.Text = "s";
            // 
            // numericUpDown7
            // 
            nupS.Location = new System.Drawing.Point(115, 51);
            nupS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            nupS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupS.Name = "nupS";
            nupS.Size = new System.Drawing.Size(60, 20);
            nupS.TabIndex = 26;
            nupS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(76, 9);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(138, 13);
            label11.TabIndex = 27;
            label11.Text = "Análise Combinatória C (n,s)";
            // 
            // numericUpDown1
            // 
            nupN.Location = new System.Drawing.Point(115, 25);
            nupN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            nupN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupN.Name = "numericUpDown1";
            nupN.Size = new System.Drawing.Size(60, 20);
            nupN.TabIndex = 29;
            nupN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 126);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(195, 13);
            label1.TabIndex = 30;
            label1.Text = "Número Sequencial Combinatório (CSN)";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(56, 157);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(170, 30);
            button1.TabIndex = 31;
            button1.Text = "Mapear CSNs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(bMapearCSN_Click);
            // 
            // numericUpDown2
            // 
            nupCSN.Location = new System.Drawing.Point(115, 204);
            nupCSN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            nupCSN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupCSN.Name = "numericUpDown2";
            nupCSN.Size = new System.Drawing.Size(60, 20);
            nupCSN.TabIndex = 32;
            nupCSN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(80, 206);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 13);
            label2.TabIndex = 33;
            label2.Text = "CSN";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(56, 239);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(170, 30);
            button2.TabIndex = 34;
            button2.Text = "Buscar CSN";
            button2.UseVisualStyleBackColor = true;

            ListaNUP.Add(nupN);
            ListaNUP.Add(nupS);
            ListaNUP.Add(nupCSN);

            // 
            // Janela
            //
            Janela = new Form();
            Janela.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            Janela.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Janela.ClientSize = new System.Drawing.Size(292, 288);
            Janela.Controls.Add(button2);
            Janela.Controls.Add(label2);
            Janela.Controls.Add(nupCSN);
            Janela.Controls.Add(button1);
            Janela.Controls.Add(label1);
            Janela.Controls.Add(nupN);
            Janela.Controls.Add(label11);
            Janela.Controls.Add(nupS);
            Janela.Controls.Add(label10);
            Janela.Controls.Add(lbJogos);
            Janela.Controls.Add(bCalcular);
            Janela.Name = "Janela";
            Janela.Text = MainWindow.APP_NAME + " - Combinatória " + MainWindow.NomeLoteria;

            LOG = LOG_tmp;

            Janela.Show();

            System.Drawing.Size SizeMaxMin = new System.Drawing.Size(Janela.ClientSize.Width, Janela.ClientSize.Height + 40);

            // Impede que o user redefina as dimensoes da janela
            Janela.MaximumSize = Janela.MinimumSize = SizeMaxMin;

            Janela.Refresh();
        }

        private void bCalcularCombinacao_Click(object sender, EventArgs e)
        {

            bool ret = false;
            ulong[] iret;
            AnaliseCombinatoria anComb = new AnaliseCombinatoria();

            try
            {
                ret = anComb.MainComb(1, (int)ListaNUP[0].Value, (int)ListaNUP[1].Value, 1, out iret);
                if (ret)
                {
                    LOG.Text = "Número de Combinações: " + iret[0].ToString();
                }
                else
                {
                    LOG.Text = "Erro no Cálculo do Número de Combinações.";
                }
            }
            catch { }
        }

        private void bMapearCSN_Click(object sender, EventArgs e)
        {

            bool ret = false;
            ulong[] iret;
            AnaliseCombinatoria anComb = new AnaliseCombinatoria();

            try
            {
                ret = anComb.MainComb(2, (int)ListaNUP[0].Value, (int)ListaNUP[1].Value, MainWindow.Resultados.Count, out iret);
                if (ret)
                {
                    LOG.Text = "Sorteio = CSN:\n";
                    for (int i = 0; i < iret.Length; i++)
                    {
                        LOG.Text += "[" + MainWindow.Resultados[i].Sorteio.ToString("0000") + "] = " + iret[i].ToString() + "\n";
                    }
                }
                else
                {
                    LOG.Text = "Erro no Cálculo do CSN.";
                }
            }
            catch { }
        }

        public void NewWindowAntPos(RichTextBox LOG_tmp)
        {
            NumericUpDown nupAnteriores = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nupSorteio = new System.Windows.Forms.NumericUpDown();
            NumericUpDown nupPosteriores = new System.Windows.Forms.NumericUpDown();
            Label lbSorteio = new System.Windows.Forms.Label();
            Label lbAnteriores = new System.Windows.Forms.Label();
            Label lbPosteriores = new System.Windows.Forms.Label();
            Button bCalcularAntPos = new System.Windows.Forms.Button();

            // Verifica se a janela já está aberta.
            if (Janela != null)
                Janela.Close();

            // 
            // nupAnteriores
            // 
            nupAnteriores.Location = new System.Drawing.Point(14, 36);
            nupAnteriores.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            nupAnteriores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupAnteriores.Name = "nupAnteriores";
            nupAnteriores.Size = new System.Drawing.Size(60, 20);
            nupAnteriores.TabIndex = 26;
            nupAnteriores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupSorteio
            // 
            nupSorteio.Location = new System.Drawing.Point(116, 36);
            nupSorteio.Maximum = new decimal(new int[] {
            MainWindow.total_jogos,
            0,
            0,
            0});
            nupSorteio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupSorteio.Name = "nupSorteio";
            nupSorteio.Size = new System.Drawing.Size(60, 20);
            nupSorteio.TabIndex = 29;
            nupSorteio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupPosteriores
            // 
            nupPosteriores.Location = new System.Drawing.Point(222, 36);
            nupPosteriores.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            nupPosteriores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupPosteriores.Name = "nupPosteriores";
            nupPosteriores.Size = new System.Drawing.Size(60, 20);
            nupPosteriores.TabIndex = 36;
            nupPosteriores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbSorteio
            // 
            lbSorteio.AutoSize = true;
            lbSorteio.Location = new System.Drawing.Point(126, 20);
            lbSorteio.Name = "lbSorteio";
            lbSorteio.Size = new System.Drawing.Size(40, 13);
            lbSorteio.TabIndex = 27;
            lbSorteio.Text = "Sorteio";
            // 
            // lbAnteriores
            // 
            lbAnteriores.AutoSize = true;
            lbAnteriores.Location = new System.Drawing.Point(14, 20);
            lbAnteriores.Name = "lbAnteriores";
            lbAnteriores.Size = new System.Drawing.Size(54, 13);
            lbAnteriores.TabIndex = 37;
            lbAnteriores.Text = "Anteriores";
            // 
            // lbPosteriores
            // 
            lbPosteriores.AutoSize = true;
            lbPosteriores.Location = new System.Drawing.Point(223, 20);
            lbPosteriores.Name = "lbPosteriores";
            lbPosteriores.Size = new System.Drawing.Size(59, 13);
            lbPosteriores.TabIndex = 38;
            lbPosteriores.Text = "Posteriores";
            // 
            // bCalcularAntPos
            // 
            bCalcularAntPos.Location = new System.Drawing.Point(64, 62);
            bCalcularAntPos.Name = "bCalcularAntPos";
            bCalcularAntPos.Size = new System.Drawing.Size(162, 32);
            bCalcularAntPos.TabIndex = 39;
            bCalcularAntPos.Text = "Calcular";
            bCalcularAntPos.UseVisualStyleBackColor = true;
            bCalcularAntPos.Click += new System.EventHandler(bCalcularAntPos_Click);
            // 
            // Janela
            //
            Janela = new Form();
            Janela.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            Janela.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Janela.ClientSize = new System.Drawing.Size(312, 107);
            Janela.Controls.Add(bCalcularAntPos);
            Janela.Controls.Add(lbPosteriores);
            Janela.Controls.Add(lbAnteriores);
            Janela.Controls.Add(lbSorteio);
            Janela.Controls.Add(nupAnteriores);
            Janela.Controls.Add(nupSorteio);
            Janela.Controls.Add(nupPosteriores);
            Janela.Name = "Janela";
            Janela.Text = MainWindow.APP_NAME + " - Ant/Pos " + MainWindow.NomeLoteria;

            LOG = LOG_tmp;

            Janela.Show();

            System.Drawing.Size SizeMaxMin = new System.Drawing.Size(Janela.ClientSize.Width, Janela.ClientSize.Height + 40);

            // Impede que o user redefina as dimensoes da janela
            Janela.MaximumSize = Janela.MinimumSize = SizeMaxMin;

            Janela.Refresh();

        }

        private void bCalcularAntPos_Click(object sender, EventArgs e)
        {
            bool ret = false;
            decimal[] vAnt, vPos;
            int i = 0, j = 0, k = 0;
            int sorteio;
            List<List<int>> VDezenas = new List<List<int>>();
            Funcionalidades func = new Funcionalidades();
            NumericUpDown nupAnt, nupSorteio, nupPos;
            nupAnt = (NumericUpDown)Janela.Controls[4];
            nupSorteio = (NumericUpDown)Janela.Controls[5];
            nupPos = (NumericUpDown)Janela.Controls[6];
            sorteio = (int)nupSorteio.Value - 1;

            try
            {
                ret = func.VerificaAntPos((int)nupAnt.Value, sorteio, (int)nupPos.Value, out vAnt, out vPos, out VDezenas);
                if (ret)
                {
                    LOG.Text = "Análise de Ocorrências Anteriores e Posteriores\n";
                    k = 0;
                    for (i = 0; i < vAnt.Length; i++)
                    {
                        LOG.Text += "[" + MainWindow.Resultados[sorteio-(vAnt.Length-i)].Sorteio.ToString("0000") + "] = ";
                        LOG.Text += vAnt[i].ToString("0.000") + "%\t= [";
                        for (j = 0; j < VDezenas[k].Count; j++)
                        {
                            LOG.Text += VDezenas[k][j].ToString("00");
                            if (j == VDezenas[k].Count - 1) break;
                            LOG.Text += ",";
                        }
                        k++;
                        LOG.Text += "]\n";

                    }

                    LOG.Text += "\n[" + MainWindow.Resultados[sorteio].Sorteio.ToString("0000") + "] = ALVO\t= [";
                    for (j = 0; j < MainWindow.dezenas_sorteadas; j++)
                    {
                        LOG.Text += MainWindow.Resultados[sorteio].Dezenas[j].ToString("00");
                        if (j == MainWindow.dezenas_sorteadas - 1) break;
                        LOG.Text += ",";
                    }
                    LOG.Text += "]\n\n";

                    for (i = 0; i < vPos.Length; i++)
                    {
                        LOG.Text += "[" + MainWindow.Resultados[sorteio + (i + 1)].Sorteio.ToString("0000") + "] = ";
                        LOG.Text += vPos[i].ToString("0.000") + "%\t= [";
                        for (j = 0; j < VDezenas[k].Count; j++)
                        {
                            LOG.Text += VDezenas[k][j].ToString("00");
                            if (j == VDezenas[k].Count - 1) break;
                            LOG.Text += ",";
                        }
                        k++;
                        LOG.Text += "]\n";
                    }
                }
            }
            catch { }
        }
    }
}
