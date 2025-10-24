namespace Projeto_Jogo_Eco_Pong
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.pbBola = new System.Windows.Forms.PictureBox();
            this.pbComputador = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbCenario = new System.Windows.Forms.PictureBox();
            this.progressBarPlayer = new System.Windows.Forms.ProgressBar();
            this.progressBarComputador = new System.Windows.Forms.ProgressBar();
            this.tmrTempoJogo = new System.Windows.Forms.Timer(this.components);
            this.lblPlantobot = new System.Windows.Forms.Label();
            this.lblSucatobot = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTituloAjuda = new System.Windows.Forms.Label();
            this.lblTextoAjuda1 = new System.Windows.Forms.Label();
            this.lblInstrucoes = new System.Windows.Forms.Label();
            this.lblTextoAjuda2 = new System.Windows.Forms.Label();
            this.pbImagemCoracao = new System.Windows.Forms.PictureBox();
            this.pbAjuda = new System.Windows.Forms.PictureBox();
            this.pbParticula1 = new System.Windows.Forms.PictureBox();
            this.pbParticula2 = new System.Windows.Forms.PictureBox();
            this.pbParticula3 = new System.Windows.Forms.PictureBox();
            this.pbPSeguidor = new System.Windows.Forms.PictureBox();
            this.pbCSeguidor = new System.Windows.Forms.PictureBox();
            this.pbImagemCoracaoCorromp = new System.Windows.Forms.PictureBox();
            this.tmrIntro = new System.Windows.Forms.Timer(this.components);
            this.pnlFundoIntro = new System.Windows.Forms.Panel();
            this.pbLogoIntro = new System.Windows.Forms.PictureBox();
            this.pbLogoDS = new System.Windows.Forms.PictureBox();
            this.lblApresenta = new System.Windows.Forms.Label();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCenario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemCoracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParticula1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParticula2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParticula3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPSeguidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCSeguidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemCoracaoCorromp)).BeginInit();
            this.pnlFundoIntro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoIntro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 10;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimerEvent);
            // 
            // lblTempo
            // 
            this.lblTempo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.White;
            this.lblTempo.Location = new System.Drawing.Point(676, 9);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(158, 42);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "◄ 150 ►";
            // 
            // pbBola
            // 
            this.pbBola.BackColor = System.Drawing.Color.Transparent;
            this.pbBola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBola.BackgroundImage")));
            this.pbBola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBola.Location = new System.Drawing.Point(490, 238);
            this.pbBola.Name = "pbBola";
            this.pbBola.Size = new System.Drawing.Size(45, 45);
            this.pbBola.TabIndex = 2;
            this.pbBola.TabStop = false;
            // 
            // pbComputador
            // 
            this.pbComputador.BackColor = System.Drawing.Color.Transparent;
            this.pbComputador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbComputador.Location = new System.Drawing.Point(1405, 238);
            this.pbComputador.Name = "pbComputador";
            this.pbComputador.Size = new System.Drawing.Size(10, 130);
            this.pbComputador.TabIndex = 1;
            this.pbComputador.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer.Location = new System.Drawing.Point(-251, 215);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(10, 130);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbCenario
            // 
            this.pbCenario.BackColor = System.Drawing.Color.Transparent;
            this.pbCenario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCenario.BackgroundImage")));
            this.pbCenario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCenario.Location = new System.Drawing.Point(-145, 690);
            this.pbCenario.Name = "pbCenario";
            this.pbCenario.Size = new System.Drawing.Size(1919, 325);
            this.pbCenario.TabIndex = 4;
            this.pbCenario.TabStop = false;
            // 
            // progressBarPlayer
            // 
            this.progressBarPlayer.Location = new System.Drawing.Point(42, 68);
            this.progressBarPlayer.Name = "progressBarPlayer";
            this.progressBarPlayer.Size = new System.Drawing.Size(267, 37);
            this.progressBarPlayer.TabIndex = 6;
            // 
            // progressBarComputador
            // 
            this.progressBarComputador.Location = new System.Drawing.Point(1268, 68);
            this.progressBarComputador.Name = "progressBarComputador";
            this.progressBarComputador.Size = new System.Drawing.Size(267, 37);
            this.progressBarComputador.TabIndex = 7;
            // 
            // tmrTempoJogo
            // 
            this.tmrTempoJogo.Interval = 1000;
            this.tmrTempoJogo.Tick += new System.EventHandler(this.tmrTempoJogo_Tick);
            // 
            // lblPlantobot
            // 
            this.lblPlantobot.AutoSize = true;
            this.lblPlantobot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.lblPlantobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantobot.ForeColor = System.Drawing.Color.White;
            this.lblPlantobot.Location = new System.Drawing.Point(37, 21);
            this.lblPlantobot.Name = "lblPlantobot";
            this.lblPlantobot.Size = new System.Drawing.Size(172, 29);
            this.lblPlantobot.TabIndex = 8;
            this.lblPlantobot.Text = "◄ Plantobot ►";
            // 
            // lblSucatobot
            // 
            this.lblSucatobot.AutoSize = true;
            this.lblSucatobot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(3)))), ((int)(((byte)(33)))));
            this.lblSucatobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucatobot.ForeColor = System.Drawing.Color.White;
            this.lblSucatobot.Location = new System.Drawing.Point(1357, 21);
            this.lblSucatobot.Name = "lblSucatobot";
            this.lblSucatobot.Size = new System.Drawing.Size(178, 29);
            this.lblSucatobot.TabIndex = 9;
            this.lblSucatobot.Text = "◄ Sucatobot ►";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::Projeto_Jogo_Eco_Pong.Properties.Resources.ecopong_logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(372, 108);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(772, 465);
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(668, 537);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(166, 36);
            this.btnJogar.TabIndex = 14;
            this.btnJogar.Text = "◄ JOGAR ►";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(668, 579);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(166, 36);
            this.btnAjuda.TabIndex = 15;
            this.btnAjuda.Text = "◄ AJUDA ►";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.BtnAjuda_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(662, 556);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(178, 36);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.Text = "◄ VOLTAR ►";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblTituloAjuda
            // 
            this.lblTituloAjuda.AutoSize = true;
            this.lblTituloAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.lblTituloAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAjuda.ForeColor = System.Drawing.Color.White;
            this.lblTituloAjuda.Location = new System.Drawing.Point(500, 108);
            this.lblTituloAjuda.Name = "lblTituloAjuda";
            this.lblTituloAjuda.Size = new System.Drawing.Size(528, 37);
            this.lblTituloAjuda.TabIndex = 18;
            this.lblTituloAjuda.Text = "__________ AJUDA __________";
            // 
            // lblTextoAjuda1
            // 
            this.lblTextoAjuda1.AutoSize = true;
            this.lblTextoAjuda1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.lblTextoAjuda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoAjuda1.ForeColor = System.Drawing.Color.White;
            this.lblTextoAjuda1.Location = new System.Drawing.Point(466, 161);
            this.lblTextoAjuda1.Name = "lblTextoAjuda1";
            this.lblTextoAjuda1.Size = new System.Drawing.Size(587, 20);
            this.lblTextoAjuda1.TabIndex = 19;
            this.lblTextoAjuda1.Text = "Por favor, ajude-nos a vencer dos maléficos propagadores do lixo tóxico!";
            // 
            // lblInstrucoes
            // 
            this.lblInstrucoes.AutoSize = true;
            this.lblInstrucoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.lblInstrucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucoes.ForeColor = System.Drawing.Color.White;
            this.lblInstrucoes.Location = new System.Drawing.Point(416, 191);
            this.lblInstrucoes.Name = "lblInstrucoes";
            this.lblInstrucoes.Size = new System.Drawing.Size(672, 24);
            this.lblInstrucoes.TabIndex = 20;
            this.lblInstrucoes.Text = "Clique na tecla \"W\" ou \"↑\" para subir. E na tecla \"S\" ou \"↓\" para descer.";
            // 
            // lblTextoAjuda2
            // 
            this.lblTextoAjuda2.AutoSize = true;
            this.lblTextoAjuda2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.lblTextoAjuda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoAjuda2.ForeColor = System.Drawing.Color.White;
            this.lblTextoAjuda2.Location = new System.Drawing.Point(486, 310);
            this.lblTextoAjuda2.Name = "lblTextoAjuda2";
            this.lblTextoAjuda2.Size = new System.Drawing.Size(532, 20);
            this.lblTextoAjuda2.TabIndex = 21;
            this.lblTextoAjuda2.Text = "Por favor, proteja-se do lixo e derrote os maléficos propagadores!";
            // 
            // pbImagemCoracao
            // 
            this.pbImagemCoracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.pbImagemCoracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImagemCoracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImagemCoracao.Image = global::Projeto_Jogo_Eco_Pong.Properties.Resources.vidas_usuario_51;
            this.pbImagemCoracao.Location = new System.Drawing.Point(490, 401);
            this.pbImagemCoracao.Name = "pbImagemCoracao";
            this.pbImagemCoracao.Size = new System.Drawing.Size(515, 110);
            this.pbImagemCoracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagemCoracao.TabIndex = 22;
            this.pbImagemCoracao.TabStop = false;
            this.pbImagemCoracao.Click += new System.EventHandler(this.ClicarMouse);
            // 
            // pbAjuda
            // 
            this.pbAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.pbAjuda.Location = new System.Drawing.Point(372, 93);
            this.pbAjuda.Name = "pbAjuda";
            this.pbAjuda.Size = new System.Drawing.Size(772, 577);
            this.pbAjuda.TabIndex = 23;
            this.pbAjuda.TabStop = false;
            // 
            // pbParticula1
            // 
            this.pbParticula1.BackColor = System.Drawing.Color.Transparent;
            this.pbParticula1.BackgroundImage = global::Projeto_Jogo_Eco_Pong.Properties.Resources.particula3;
            this.pbParticula1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbParticula1.Location = new System.Drawing.Point(1411, 579);
            this.pbParticula1.Name = "pbParticula1";
            this.pbParticula1.Size = new System.Drawing.Size(12, 13);
            this.pbParticula1.TabIndex = 25;
            this.pbParticula1.TabStop = false;
            // 
            // pbParticula2
            // 
            this.pbParticula2.BackColor = System.Drawing.Color.Transparent;
            this.pbParticula2.BackgroundImage = global::Projeto_Jogo_Eco_Pong.Properties.Resources.particula4;
            this.pbParticula2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbParticula2.Location = new System.Drawing.Point(1382, 483);
            this.pbParticula2.Name = "pbParticula2";
            this.pbParticula2.Size = new System.Drawing.Size(13, 13);
            this.pbParticula2.TabIndex = 26;
            this.pbParticula2.TabStop = false;
            // 
            // pbParticula3
            // 
            this.pbParticula3.BackColor = System.Drawing.Color.Transparent;
            this.pbParticula3.BackgroundImage = global::Projeto_Jogo_Eco_Pong.Properties.Resources.particula3;
            this.pbParticula3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbParticula3.Location = new System.Drawing.Point(1304, 660);
            this.pbParticula3.Name = "pbParticula3";
            this.pbParticula3.Size = new System.Drawing.Size(10, 10);
            this.pbParticula3.TabIndex = 27;
            this.pbParticula3.TabStop = false;
            // 
            // pbPSeguidor
            // 
            this.pbPSeguidor.BackColor = System.Drawing.Color.Transparent;
            this.pbPSeguidor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPSeguidor.BackgroundImage")));
            this.pbPSeguidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPSeguidor.Location = new System.Drawing.Point(52, 238);
            this.pbPSeguidor.Name = "pbPSeguidor";
            this.pbPSeguidor.Size = new System.Drawing.Size(130, 130);
            this.pbPSeguidor.TabIndex = 28;
            this.pbPSeguidor.TabStop = false;
            // 
            // pbCSeguidor
            // 
            this.pbCSeguidor.BackColor = System.Drawing.Color.Transparent;
            this.pbCSeguidor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCSeguidor.BackgroundImage")));
            this.pbCSeguidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCSeguidor.Location = new System.Drawing.Point(1405, 238);
            this.pbCSeguidor.Name = "pbCSeguidor";
            this.pbCSeguidor.Size = new System.Drawing.Size(130, 130);
            this.pbCSeguidor.TabIndex = 29;
            this.pbCSeguidor.TabStop = false;
            // 
            // pbImagemCoracaoCorromp
            // 
            this.pbImagemCoracaoCorromp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.pbImagemCoracaoCorromp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImagemCoracaoCorromp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImagemCoracaoCorromp.Image = global::Projeto_Jogo_Eco_Pong.Properties.Resources.vidas_comp_51;
            this.pbImagemCoracaoCorromp.Location = new System.Drawing.Point(490, 401);
            this.pbImagemCoracaoCorromp.Name = "pbImagemCoracaoCorromp";
            this.pbImagemCoracaoCorromp.Size = new System.Drawing.Size(515, 110);
            this.pbImagemCoracaoCorromp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagemCoracaoCorromp.TabIndex = 30;
            this.pbImagemCoracaoCorromp.TabStop = false;
            this.pbImagemCoracaoCorromp.Click += new System.EventHandler(this.ClicarMouse2);
            // 
            // tmrIntro
            // 
            this.tmrIntro.Tick += new System.EventHandler(this.TmrIntro_Tick);
            // 
            // pnlFundoIntro
            // 
            this.pnlFundoIntro.BackColor = System.Drawing.Color.Black;
            this.pnlFundoIntro.Controls.Add(this.pbLogoIntro);
            this.pnlFundoIntro.Controls.Add(this.pbLogoDS);
            this.pnlFundoIntro.Controls.Add(this.lblApresenta);
            this.pnlFundoIntro.Location = new System.Drawing.Point(-5, -9);
            this.pnlFundoIntro.Name = "pnlFundoIntro";
            this.pnlFundoIntro.Size = new System.Drawing.Size(1749, 979);
            this.pnlFundoIntro.TabIndex = 31;
            // 
            // pbLogoIntro
            // 
            this.pbLogoIntro.BackColor = System.Drawing.Color.Black;
            this.pbLogoIntro.Image = global::Projeto_Jogo_Eco_Pong.Properties.Resources.Logo2;
            this.pbLogoIntro.Location = new System.Drawing.Point(471, 89);
            this.pbLogoIntro.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoIntro.Name = "pbLogoIntro";
            this.pbLogoIntro.Size = new System.Drawing.Size(539, 496);
            this.pbLogoIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoIntro.TabIndex = 33;
            this.pbLogoIntro.TabStop = false;
            // 
            // pbLogoDS
            // 
            this.pbLogoDS.Image = global::Projeto_Jogo_Eco_Pong.Properties.Resources.logoSala;
            this.pbLogoDS.Location = new System.Drawing.Point(471, 89);
            this.pbLogoDS.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoDS.Name = "pbLogoDS";
            this.pbLogoDS.Size = new System.Drawing.Size(539, 496);
            this.pbLogoDS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoDS.TabIndex = 1;
            this.pbLogoDS.TabStop = false;
            // 
            // lblApresenta
            // 
            this.lblApresenta.AutoSize = true;
            this.lblApresenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApresenta.ForeColor = System.Drawing.Color.White;
            this.lblApresenta.Location = new System.Drawing.Point(587, 606);
            this.lblApresenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApresenta.Name = "lblApresenta";
            this.lblApresenta.Size = new System.Drawing.Size(324, 55);
            this.lblApresenta.TabIndex = 0;
            this.lblApresenta.Text = "APRESENTA";
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayer2.Location = new System.Drawing.Point(172, 238);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(10, 130);
            this.pbPlayer2.TabIndex = 32;
            this.pbPlayer2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(4)))), ((int)(((byte)(33)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1588, 703);
            this.Controls.Add(this.pnlFundoIntro);
            this.Controls.Add(this.pbImagemCoracaoCorromp);
            this.Controls.Add(this.pbParticula3);
            this.Controls.Add(this.pbParticula2);
            this.Controls.Add(this.pbParticula1);
            this.Controls.Add(this.lblTituloAjuda);
            this.Controls.Add(this.lblTextoAjuda1);
            this.Controls.Add(this.lblInstrucoes);
            this.Controls.Add(this.lblTextoAjuda2);
            this.Controls.Add(this.pbImagemCoracao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSucatobot);
            this.Controls.Add(this.lblPlantobot);
            this.Controls.Add(this.progressBarComputador);
            this.Controls.Add(this.progressBarPlayer);
            this.Controls.Add(this.pbBola);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.pbCenario);
            this.Controls.Add(this.pbAjuda);
            this.Controls.Add(this.pbPSeguidor);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbCSeguidor);
            this.Controls.Add(this.pbComputador);
            this.Controls.Add(this.pbPlayer2);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ECO - PONG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyBaixo);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyCima);
            ((System.ComponentModel.ISupportInitialize)(this.pbBola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCenario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemCoracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParticula1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParticula2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParticula3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPSeguidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCSeguidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemCoracaoCorromp)).EndInit();
            this.pnlFundoIntro.ResumeLayout(false);
            this.pnlFundoIntro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoIntro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbComputador;
        private System.Windows.Forms.PictureBox pbBola;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.PictureBox pbCenario;
        private System.Windows.Forms.ProgressBar progressBarPlayer;
        private System.Windows.Forms.ProgressBar progressBarComputador;
        private System.Windows.Forms.Timer tmrTempoJogo;
        private System.Windows.Forms.Label lblPlantobot;
        private System.Windows.Forms.Label lblSucatobot;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTituloAjuda;
        private System.Windows.Forms.Label lblTextoAjuda1;
        private System.Windows.Forms.Label lblInstrucoes;
        private System.Windows.Forms.Label lblTextoAjuda2;
        private System.Windows.Forms.PictureBox pbImagemCoracao;
        private System.Windows.Forms.PictureBox pbAjuda;
        private System.Windows.Forms.PictureBox pbParticula1;
        private System.Windows.Forms.PictureBox pbParticula2;
        private System.Windows.Forms.PictureBox pbParticula3;
        private System.Windows.Forms.PictureBox pbPSeguidor;
        private System.Windows.Forms.PictureBox pbCSeguidor;
        private System.Windows.Forms.PictureBox pbImagemCoracaoCorromp;
        private System.Windows.Forms.Timer tmrIntro;
        private System.Windows.Forms.Panel pnlFundoIntro;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.PictureBox pbLogoIntro;
        private System.Windows.Forms.Label lblApresenta;
        private System.Windows.Forms.PictureBox pbLogoDS;
    }
}

