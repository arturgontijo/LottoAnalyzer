namespace LottoAnalyzer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAnalise = new System.Windows.Forms.TabPage();
            this.bSoma = new System.Windows.Forms.Button();
            this.bAntPos = new System.Windows.Forms.Button();
            this.bAnaliseCombinatoria = new System.Windows.Forms.Button();
            this.bSimular = new System.Windows.Forms.Button();
            this.lbLoteria = new System.Windows.Forms.Label();
            this.tbLoteria = new System.Windows.Forms.TextBox();
            this.lbDezenas = new System.Windows.Forms.Label();
            this.tbDezenasCarregadas = new System.Windows.Forms.TextBox();
            this.bCombinar = new System.Windows.Forms.Button();
            this.bDezenas = new System.Windows.Forms.Button();
            this.bMapear = new System.Windows.Forms.Button();
            this.bAtrasosMax = new System.Windows.Forms.Button();
            this.bAtrasos = new System.Windows.Forms.Button();
            this.bTestador = new System.Windows.Forms.Button();
            this.bParImpar = new System.Windows.Forms.Button();
            this.lbJogos = new System.Windows.Forms.Label();
            this.tbJogosCarregados = new System.Windows.Forms.TextBox();
            this.bAbrir = new System.Windows.Forms.Button();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.bQParImp = new System.Windows.Forms.Button();
            this.tbLOG = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabAnalise.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAnalise);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 386);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAnalise
            // 
            this.tabAnalise.Controls.Add(this.bSoma);
            this.tabAnalise.Controls.Add(this.bAntPos);
            this.tabAnalise.Controls.Add(this.bAnaliseCombinatoria);
            this.tabAnalise.Controls.Add(this.bSimular);
            this.tabAnalise.Controls.Add(this.lbLoteria);
            this.tabAnalise.Controls.Add(this.tbLoteria);
            this.tabAnalise.Controls.Add(this.lbDezenas);
            this.tabAnalise.Controls.Add(this.tbDezenasCarregadas);
            this.tabAnalise.Controls.Add(this.bCombinar);
            this.tabAnalise.Controls.Add(this.bDezenas);
            this.tabAnalise.Controls.Add(this.bMapear);
            this.tabAnalise.Controls.Add(this.bAtrasosMax);
            this.tabAnalise.Controls.Add(this.bAtrasos);
            this.tabAnalise.Controls.Add(this.bTestador);
            this.tabAnalise.Controls.Add(this.bParImpar);
            this.tabAnalise.Controls.Add(this.lbJogos);
            this.tabAnalise.Controls.Add(this.tbJogosCarregados);
            this.tabAnalise.Controls.Add(this.bAbrir);
            this.tabAnalise.Controls.Add(this.tbFile);
            this.tabAnalise.Controls.Add(this.bQParImp);
            this.tabAnalise.Controls.Add(this.tbLOG);
            this.tabAnalise.Location = new System.Drawing.Point(4, 22);
            this.tabAnalise.Name = "tabAnalise";
            this.tabAnalise.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalise.Size = new System.Drawing.Size(742, 360);
            this.tabAnalise.TabIndex = 1;
            this.tabAnalise.Text = "Análise";
            this.tabAnalise.UseVisualStyleBackColor = true;
            // 
            // bSoma
            // 
            this.bSoma.Location = new System.Drawing.Point(7, 158);
            this.bSoma.Name = "bSoma";
            this.bSoma.Size = new System.Drawing.Size(100, 23);
            this.bSoma.TabIndex = 146;
            this.bSoma.Text = "Soma";
            this.bSoma.UseVisualStyleBackColor = true;
            this.bSoma.Click += new System.EventHandler(this.bSoma_Click);
            // 
            // bAntPos
            // 
            this.bAntPos.Location = new System.Drawing.Point(7, 100);
            this.bAntPos.Name = "bAntPos";
            this.bAntPos.Size = new System.Drawing.Size(100, 23);
            this.bAntPos.TabIndex = 145;
            this.bAntPos.Text = "Jogos (Ant/Pos)";
            this.bAntPos.UseVisualStyleBackColor = true;
            this.bAntPos.Click += new System.EventHandler(this.bAntPos_Click);
            // 
            // bAnaliseCombinatoria
            // 
            this.bAnaliseCombinatoria.Location = new System.Drawing.Point(7, 215);
            this.bAnaliseCombinatoria.Name = "bAnaliseCombinatoria";
            this.bAnaliseCombinatoria.Size = new System.Drawing.Size(206, 23);
            this.bAnaliseCombinatoria.TabIndex = 144;
            this.bAnaliseCombinatoria.Text = "Análise Combinatória";
            this.bAnaliseCombinatoria.UseVisualStyleBackColor = true;
            this.bAnaliseCombinatoria.Click += new System.EventHandler(this.bAnaliseCombinatoria_Click);
            // 
            // bSimular
            // 
            this.bSimular.Location = new System.Drawing.Point(113, 186);
            this.bSimular.Name = "bSimular";
            this.bSimular.Size = new System.Drawing.Size(100, 23);
            this.bSimular.TabIndex = 143;
            this.bSimular.Text = "Simular";
            this.bSimular.UseVisualStyleBackColor = true;
            this.bSimular.Click += new System.EventHandler(this.bSimular_Click);
            // 
            // lbLoteria
            // 
            this.lbLoteria.AutoSize = true;
            this.lbLoteria.Location = new System.Drawing.Point(38, 40);
            this.lbLoteria.Name = "lbLoteria";
            this.lbLoteria.Size = new System.Drawing.Size(39, 13);
            this.lbLoteria.TabIndex = 142;
            this.lbLoteria.Text = "Loteria";
            // 
            // tbLoteria
            // 
            this.tbLoteria.Location = new System.Drawing.Point(6, 57);
            this.tbLoteria.Name = "tbLoteria";
            this.tbLoteria.ReadOnly = true;
            this.tbLoteria.Size = new System.Drawing.Size(100, 20);
            this.tbLoteria.TabIndex = 141;
            this.tbLoteria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbDezenas
            // 
            this.lbDezenas.AutoSize = true;
            this.lbDezenas.Location = new System.Drawing.Point(247, 41);
            this.lbDezenas.Name = "lbDezenas";
            this.lbDezenas.Size = new System.Drawing.Size(49, 13);
            this.lbDezenas.TabIndex = 139;
            this.lbDezenas.Text = "Dezenas";
            // 
            // tbDezenasCarregadas
            // 
            this.tbDezenasCarregadas.Location = new System.Drawing.Point(219, 57);
            this.tbDezenasCarregadas.Name = "tbDezenasCarregadas";
            this.tbDezenasCarregadas.ReadOnly = true;
            this.tbDezenasCarregadas.Size = new System.Drawing.Size(100, 20);
            this.tbDezenasCarregadas.TabIndex = 138;
            this.tbDezenasCarregadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bCombinar
            // 
            this.bCombinar.Location = new System.Drawing.Point(219, 158);
            this.bCombinar.Name = "bCombinar";
            this.bCombinar.Size = new System.Drawing.Size(100, 23);
            this.bCombinar.TabIndex = 137;
            this.bCombinar.Text = "Combinar";
            this.bCombinar.UseVisualStyleBackColor = true;
            this.bCombinar.Click += new System.EventHandler(this.bCombinar_Click);
            // 
            // bDezenas
            // 
            this.bDezenas.Location = new System.Drawing.Point(219, 100);
            this.bDezenas.Name = "bDezenas";
            this.bDezenas.Size = new System.Drawing.Size(100, 23);
            this.bDezenas.TabIndex = 136;
            this.bDezenas.Text = "Dezenas";
            this.bDezenas.UseVisualStyleBackColor = true;
            this.bDezenas.Click += new System.EventHandler(this.bDezenas_Click);
            // 
            // bMapear
            // 
            this.bMapear.Location = new System.Drawing.Point(113, 157);
            this.bMapear.Name = "bMapear";
            this.bMapear.Size = new System.Drawing.Size(100, 23);
            this.bMapear.TabIndex = 135;
            this.bMapear.Text = "Mapear";
            this.bMapear.UseVisualStyleBackColor = true;
            this.bMapear.Click += new System.EventHandler(this.bMapeamento_Click);
            // 
            // bAtrasosMax
            // 
            this.bAtrasosMax.Location = new System.Drawing.Point(219, 129);
            this.bAtrasosMax.Name = "bAtrasosMax";
            this.bAtrasosMax.Size = new System.Drawing.Size(100, 23);
            this.bAtrasosMax.TabIndex = 134;
            this.bAtrasosMax.Text = "Atrasos Máx";
            this.bAtrasosMax.UseVisualStyleBackColor = true;
            this.bAtrasosMax.Click += new System.EventHandler(this.bAtrasosMax_Click);
            // 
            // bAtrasos
            // 
            this.bAtrasos.Location = new System.Drawing.Point(113, 128);
            this.bAtrasos.Name = "bAtrasos";
            this.bAtrasos.Size = new System.Drawing.Size(100, 23);
            this.bAtrasos.TabIndex = 133;
            this.bAtrasos.Text = "Atrasos";
            this.bAtrasos.UseVisualStyleBackColor = true;
            this.bAtrasos.Click += new System.EventHandler(this.bAtrasos_Click);
            // 
            // bTestador
            // 
            this.bTestador.Location = new System.Drawing.Point(7, 186);
            this.bTestador.Name = "bTestador";
            this.bTestador.Size = new System.Drawing.Size(100, 23);
            this.bTestador.TabIndex = 132;
            this.bTestador.Text = "Testador";
            this.bTestador.UseVisualStyleBackColor = true;
            this.bTestador.Click += new System.EventHandler(this.bAnalisador_Click);
            // 
            // bParImpar
            // 
            this.bParImpar.Location = new System.Drawing.Point(113, 100);
            this.bParImpar.Name = "bParImpar";
            this.bParImpar.Size = new System.Drawing.Size(100, 23);
            this.bParImpar.TabIndex = 130;
            this.bParImpar.Text = "Pares-Impares";
            this.bParImpar.UseVisualStyleBackColor = true;
            this.bParImpar.Click += new System.EventHandler(this.bParImpar_Click);
            // 
            // lbJogos
            // 
            this.lbJogos.AutoSize = true;
            this.lbJogos.Location = new System.Drawing.Point(145, 40);
            this.lbJogos.Name = "lbJogos";
            this.lbJogos.Size = new System.Drawing.Size(35, 13);
            this.lbJogos.TabIndex = 129;
            this.lbJogos.Text = "Jogos";
            // 
            // tbJogosCarregados
            // 
            this.tbJogosCarregados.Location = new System.Drawing.Point(113, 57);
            this.tbJogosCarregados.Name = "tbJogosCarregados";
            this.tbJogosCarregados.ReadOnly = true;
            this.tbJogosCarregados.Size = new System.Drawing.Size(100, 20);
            this.tbJogosCarregados.TabIndex = 128;
            this.tbJogosCarregados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bAbrir
            // 
            this.bAbrir.Location = new System.Drawing.Point(274, 6);
            this.bAbrir.Name = "bAbrir";
            this.bAbrir.Size = new System.Drawing.Size(72, 23);
            this.bAbrir.TabIndex = 127;
            this.bAbrir.Text = "Abrir";
            this.bAbrir.UseVisualStyleBackColor = true;
            this.bAbrir.Click += new System.EventHandler(this.bAbrir_Click);
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(6, 6);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(262, 20);
            this.tbFile.TabIndex = 126;
            // 
            // bQParImp
            // 
            this.bQParImp.Location = new System.Drawing.Point(7, 129);
            this.bQParImp.Name = "bQParImp";
            this.bQParImp.Size = new System.Drawing.Size(100, 23);
            this.bQParImp.TabIndex = 125;
            this.bQParImp.Text = "Qtd Par/Impar";
            this.bQParImp.UseVisualStyleBackColor = true;
            this.bQParImp.Click += new System.EventHandler(this.bQParImp_Click);
            // 
            // tbLOG
            // 
            this.tbLOG.Location = new System.Drawing.Point(353, 6);
            this.tbLOG.Name = "tbLOG";
            this.tbLOG.ReadOnly = true;
            this.tbLOG.Size = new System.Drawing.Size(383, 351);
            this.tbLOG.TabIndex = 76;
            this.tbLOG.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu3ToolStripMenuItem
            // 
            this.menu3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
            this.menu3ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.menu3ToolStripMenuItem.Text = "Sobre";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.helpToolStripMenuItem.Text = "Ajuda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem.Text = "Versão";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 438);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "LottoAnalyzer v1";
            this.tabControl1.ResumeLayout(false);
            this.tabAnalise.ResumeLayout(false);
            this.tabAnalise.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAnalise;
        private System.Windows.Forms.RichTextBox tbLOG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button bQParImp;
        private System.Windows.Forms.Button bAbrir;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label lbJogos;
        private System.Windows.Forms.TextBox tbJogosCarregados;
        private System.Windows.Forms.Button bParImpar;
        private System.Windows.Forms.Button bTestador;
        private System.Windows.Forms.Button bMapear;
        private System.Windows.Forms.Button bAtrasosMax;
        private System.Windows.Forms.Button bAtrasos;
        private System.Windows.Forms.Button bDezenas;
        private System.Windows.Forms.Button bCombinar;
        private System.Windows.Forms.Label lbDezenas;
        private System.Windows.Forms.TextBox tbDezenasCarregadas;
        private System.Windows.Forms.Label lbLoteria;
        private System.Windows.Forms.TextBox tbLoteria;
        private System.Windows.Forms.Button bSimular;
        private System.Windows.Forms.Button bAnaliseCombinatoria;
        private System.Windows.Forms.Button bAntPos;
        private System.Windows.Forms.Button bSoma;
    }
}

