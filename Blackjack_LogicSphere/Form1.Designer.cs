namespace Blackjack_LogicSphere
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnNewRound = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblPlayerPoints = new System.Windows.Forms.Label();
            this.btnSetChips = new System.Windows.Forms.Button();
            this.lblDealerChips = new System.Windows.Forms.Label();
            this.lblPlayerChips = new System.Windows.Forms.Label();
            this.tmrDealerAI = new System.Windows.Forms.Timer(this.components);
            this.btnBet1 = new System.Windows.Forms.Button();
            this.btnBet2 = new System.Windows.Forms.Button();
            this.btnBet3 = new System.Windows.Forms.Button();
            this.btnBet4 = new System.Windows.Forms.Button();
            this.btnBet5 = new System.Windows.Forms.Button();
            this.lblPlaceBet = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnAllIn = new System.Windows.Forms.Button();
            this.pboYoutube = new System.Windows.Forms.PictureBox();
            this.pboInstagram = new System.Windows.Forms.PictureBox();
            this.pboFacebook = new System.Windows.Forms.PictureBox();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.pboDealerCard2 = new System.Windows.Forms.PictureBox();
            this.pboDealerCard1 = new System.Windows.Forms.PictureBox();
            this.pboPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.pboPlayerCard1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayerCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(790, 680);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "LogicSphere Studio";
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Gold;
            this.btnHit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHit.FlatAppearance.BorderSize = 2;
            this.btnHit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(861, 337);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(111, 40);
            this.btnHit.TabIndex = 3;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Gold;
            this.btnStand.FlatAppearance.BorderSize = 2;
            this.btnStand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStand.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(861, 383);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(111, 40);
            this.btnStand.TabIndex = 6;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Visible = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dealer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(868, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Player";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Gold;
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStartGame.FlatAppearance.BorderSize = 2;
            this.btnStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(861, 291);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(111, 40);
            this.btnStartGame.TabIndex = 12;
            this.btnStartGame.Text = "Start game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnNewRound
            // 
            this.btnNewRound.BackColor = System.Drawing.Color.Gold;
            this.btnNewRound.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewRound.FlatAppearance.BorderSize = 2;
            this.btnNewRound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRound.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRound.Location = new System.Drawing.Point(861, 291);
            this.btnNewRound.Name = "btnNewRound";
            this.btnNewRound.Size = new System.Drawing.Size(111, 40);
            this.btnNewRound.TabIndex = 13;
            this.btnNewRound.Text = "New round";
            this.btnNewRound.UseVisualStyleBackColor = false;
            this.btnNewRound.Visible = false;
            this.btnNewRound.Click += new System.EventHandler(this.btnNewRound_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblWinner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblWinner.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(29, 320);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 39);
            this.lblWinner.TabIndex = 14;
            // 
            // lblPlayerPoints
            // 
            this.lblPlayerPoints.AutoSize = true;
            this.lblPlayerPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPlayerPoints.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPlayerPoints.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPoints.ForeColor = System.Drawing.Color.White;
            this.lblPlayerPoints.Location = new System.Drawing.Point(125, 436);
            this.lblPlayerPoints.Name = "lblPlayerPoints";
            this.lblPlayerPoints.Size = new System.Drawing.Size(0, 39);
            this.lblPlayerPoints.TabIndex = 16;
            // 
            // btnSetChips
            // 
            this.btnSetChips.BackColor = System.Drawing.Color.Gold;
            this.btnSetChips.FlatAppearance.BorderSize = 2;
            this.btnSetChips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSetChips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetChips.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetChips.Location = new System.Drawing.Point(861, 337);
            this.btnSetChips.Name = "btnSetChips";
            this.btnSetChips.Size = new System.Drawing.Size(111, 40);
            this.btnSetChips.TabIndex = 17;
            this.btnSetChips.Text = "Set chips";
            this.btnSetChips.UseVisualStyleBackColor = false;
            this.btnSetChips.Click += new System.EventHandler(this.btnSetChips_Click);
            // 
            // lblDealerChips
            // 
            this.lblDealerChips.AutoSize = true;
            this.lblDealerChips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDealerChips.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDealerChips.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerChips.ForeColor = System.Drawing.Color.White;
            this.lblDealerChips.Location = new System.Drawing.Point(206, 196);
            this.lblDealerChips.Name = "lblDealerChips";
            this.lblDealerChips.Size = new System.Drawing.Size(130, 39);
            this.lblDealerChips.TabIndex = 18;
            this.lblDealerChips.Text = "0 chips";
            // 
            // lblPlayerChips
            // 
            this.lblPlayerChips.AutoSize = true;
            this.lblPlayerChips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPlayerChips.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPlayerChips.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChips.ForeColor = System.Drawing.Color.White;
            this.lblPlayerChips.Location = new System.Drawing.Point(206, 436);
            this.lblPlayerChips.Name = "lblPlayerChips";
            this.lblPlayerChips.Size = new System.Drawing.Size(130, 39);
            this.lblPlayerChips.TabIndex = 19;
            this.lblPlayerChips.Text = "0 chips";
            // 
            // tmrDealerAI
            // 
            this.tmrDealerAI.Interval = 1000;
            this.tmrDealerAI.Tick += new System.EventHandler(this.tmrDealerAI_Tick);
            // 
            // btnBet1
            // 
            this.btnBet1.BackColor = System.Drawing.Color.Red;
            this.btnBet1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBet1.FlatAppearance.BorderSize = 2;
            this.btnBet1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet1.Location = new System.Drawing.Point(260, 337);
            this.btnBet1.Name = "btnBet1";
            this.btnBet1.Size = new System.Drawing.Size(111, 40);
            this.btnBet1.TabIndex = 20;
            this.btnBet1.Text = "Bet1";
            this.btnBet1.UseVisualStyleBackColor = false;
            this.btnBet1.Visible = false;
            // 
            // btnBet2
            // 
            this.btnBet2.BackColor = System.Drawing.Color.Lime;
            this.btnBet2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBet2.FlatAppearance.BorderSize = 2;
            this.btnBet2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBet2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet2.Location = new System.Drawing.Point(377, 337);
            this.btnBet2.Name = "btnBet2";
            this.btnBet2.Size = new System.Drawing.Size(111, 40);
            this.btnBet2.TabIndex = 21;
            this.btnBet2.Text = "Bet2";
            this.btnBet2.UseVisualStyleBackColor = false;
            this.btnBet2.Visible = false;
            // 
            // btnBet3
            // 
            this.btnBet3.BackColor = System.Drawing.Color.Blue;
            this.btnBet3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBet3.FlatAppearance.BorderSize = 2;
            this.btnBet3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBet3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet3.Location = new System.Drawing.Point(494, 337);
            this.btnBet3.Name = "btnBet3";
            this.btnBet3.Size = new System.Drawing.Size(111, 40);
            this.btnBet3.TabIndex = 22;
            this.btnBet3.Text = "Bet3";
            this.btnBet3.UseVisualStyleBackColor = false;
            this.btnBet3.Visible = false;
            // 
            // btnBet4
            // 
            this.btnBet4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBet4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBet4.FlatAppearance.BorderSize = 2;
            this.btnBet4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBet4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet4.Location = new System.Drawing.Point(611, 337);
            this.btnBet4.Name = "btnBet4";
            this.btnBet4.Size = new System.Drawing.Size(111, 40);
            this.btnBet4.TabIndex = 23;
            this.btnBet4.Text = "Bet4";
            this.btnBet4.UseVisualStyleBackColor = false;
            this.btnBet4.Visible = false;
            // 
            // btnBet5
            // 
            this.btnBet5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBet5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBet5.FlatAppearance.BorderSize = 2;
            this.btnBet5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBet5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet5.Location = new System.Drawing.Point(728, 337);
            this.btnBet5.Name = "btnBet5";
            this.btnBet5.Size = new System.Drawing.Size(111, 40);
            this.btnBet5.TabIndex = 24;
            this.btnBet5.Text = "Bet5";
            this.btnBet5.UseVisualStyleBackColor = false;
            this.btnBet5.Visible = false;
            // 
            // lblPlaceBet
            // 
            this.lblPlaceBet.AutoSize = true;
            this.lblPlaceBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPlaceBet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPlaceBet.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceBet.ForeColor = System.Drawing.Color.White;
            this.lblPlaceBet.Location = new System.Drawing.Point(459, 295);
            this.lblPlaceBet.Name = "lblPlaceBet";
            this.lblPlaceBet.Size = new System.Drawing.Size(249, 39);
            this.lblPlaceBet.TabIndex = 25;
            this.lblPlaceBet.Text = "Place your bet";
            this.lblPlaceBet.Visible = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Gold;
            this.btnNewGame.FlatAppearance.BorderSize = 2;
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(861, 291);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(111, 40);
            this.btnNewGame.TabIndex = 26;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnAllIn
            // 
            this.btnAllIn.BackColor = System.Drawing.Color.Gold;
            this.btnAllIn.FlatAppearance.BorderSize = 2;
            this.btnAllIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAllIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllIn.Location = new System.Drawing.Point(494, 383);
            this.btnAllIn.Name = "btnAllIn";
            this.btnAllIn.Size = new System.Drawing.Size(111, 40);
            this.btnAllIn.TabIndex = 27;
            this.btnAllIn.Text = "All In";
            this.btnAllIn.UseVisualStyleBackColor = false;
            this.btnAllIn.Visible = false;
            this.btnAllIn.Click += new System.EventHandler(this.btnAllIn_Click);
            // 
            // pboYoutube
            // 
            this.pboYoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboYoutube.ErrorImage = global::Blackjack_LogicSphere.Properties.Resources.YoutubeLogo1;
            this.pboYoutube.Image = global::Blackjack_LogicSphere.Properties.Resources.YoutubeLogo;
            this.pboYoutube.Location = new System.Drawing.Point(148, 655);
            this.pboYoutube.Name = "pboYoutube";
            this.pboYoutube.Size = new System.Drawing.Size(50, 50);
            this.pboYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboYoutube.TabIndex = 31;
            this.pboYoutube.TabStop = false;
            this.pboYoutube.Click += new System.EventHandler(this.pboYoutube_Click);
            // 
            // pboInstagram
            // 
            this.pboInstagram.BackColor = System.Drawing.Color.Transparent;
            this.pboInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboInstagram.Image = global::Blackjack_LogicSphere.Properties.Resources.Instagram1;
            this.pboInstagram.Location = new System.Drawing.Point(92, 655);
            this.pboInstagram.Name = "pboInstagram";
            this.pboInstagram.Size = new System.Drawing.Size(50, 50);
            this.pboInstagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboInstagram.TabIndex = 30;
            this.pboInstagram.TabStop = false;
            this.pboInstagram.Click += new System.EventHandler(this.pboInstagram_Click);
            // 
            // pboFacebook
            // 
            this.pboFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboFacebook.Image = global::Blackjack_LogicSphere.Properties.Resources.Facebook1;
            this.pboFacebook.Location = new System.Drawing.Point(36, 655);
            this.pboFacebook.Name = "pboFacebook";
            this.pboFacebook.Size = new System.Drawing.Size(50, 50);
            this.pboFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFacebook.TabIndex = 29;
            this.pboFacebook.TabStop = false;
            this.pboFacebook.Click += new System.EventHandler(this.pboFacebook_Click);
            // 
            // pboLogo
            // 
            this.pboLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboLogo.Image = global::Blackjack_LogicSphere.Properties.Resources.LogicSphere_Studio_logo1;
            this.pboLogo.Location = new System.Drawing.Point(709, 655);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(75, 66);
            this.pboLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLogo.TabIndex = 28;
            this.pboLogo.TabStop = false;
            this.pboLogo.Click += new System.EventHandler(this.pboLogo_Click);
            // 
            // pboDealerCard2
            // 
            this.pboDealerCard2.Image = ((System.Drawing.Image)(resources.GetObject("pboDealerCard2.Image")));
            this.pboDealerCard2.InitialImage = global::Blackjack_LogicSphere.Properties.Resources.BehindACard;
            this.pboDealerCard2.Location = new System.Drawing.Point(158, 26);
            this.pboDealerCard2.Name = "pboDealerCard2";
            this.pboDealerCard2.Size = new System.Drawing.Size(116, 167);
            this.pboDealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboDealerCard2.TabIndex = 8;
            this.pboDealerCard2.TabStop = false;
            // 
            // pboDealerCard1
            // 
            this.pboDealerCard1.Image = ((System.Drawing.Image)(resources.GetObject("pboDealerCard1.Image")));
            this.pboDealerCard1.InitialImage = global::Blackjack_LogicSphere.Properties.Resources.BehindACard;
            this.pboDealerCard1.Location = new System.Drawing.Point(36, 26);
            this.pboDealerCard1.Name = "pboDealerCard1";
            this.pboDealerCard1.Size = new System.Drawing.Size(116, 167);
            this.pboDealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboDealerCard1.TabIndex = 7;
            this.pboDealerCard1.TabStop = false;
            // 
            // pboPlayerCard2
            // 
            this.pboPlayerCard2.Image = ((System.Drawing.Image)(resources.GetObject("pboPlayerCard2.Image")));
            this.pboPlayerCard2.InitialImage = global::Blackjack_LogicSphere.Properties.Resources.BehindACard;
            this.pboPlayerCard2.Location = new System.Drawing.Point(158, 478);
            this.pboPlayerCard2.Name = "pboPlayerCard2";
            this.pboPlayerCard2.Size = new System.Drawing.Size(116, 167);
            this.pboPlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboPlayerCard2.TabIndex = 2;
            this.pboPlayerCard2.TabStop = false;
            // 
            // pboPlayerCard1
            // 
            this.pboPlayerCard1.Image = ((System.Drawing.Image)(resources.GetObject("pboPlayerCard1.Image")));
            this.pboPlayerCard1.InitialImage = global::Blackjack_LogicSphere.Properties.Resources.BehindACard;
            this.pboPlayerCard1.Location = new System.Drawing.Point(36, 478);
            this.pboPlayerCard1.Name = "pboPlayerCard1";
            this.pboPlayerCard1.Size = new System.Drawing.Size(116, 167);
            this.pboPlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboPlayerCard1.TabIndex = 0;
            this.pboPlayerCard1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 713);
            this.Controls.Add(this.pboYoutube);
            this.Controls.Add(this.pboInstagram);
            this.Controls.Add(this.pboFacebook);
            this.Controls.Add(this.pboLogo);
            this.Controls.Add(this.btnAllIn);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblPlaceBet);
            this.Controls.Add(this.btnBet5);
            this.Controls.Add(this.btnBet4);
            this.Controls.Add(this.btnBet3);
            this.Controls.Add(this.btnBet2);
            this.Controls.Add(this.btnBet1);
            this.Controls.Add(this.lblPlayerChips);
            this.Controls.Add(this.lblDealerChips);
            this.Controls.Add(this.btnSetChips);
            this.Controls.Add(this.lblPlayerPoints);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnNewRound);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pboDealerCard2);
            this.Controls.Add(this.pboDealerCard1);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.pboPlayerCard2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboPlayerCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.pboYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboPlayerCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboPlayerCard2;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.PictureBox pboDealerCard1;
        private System.Windows.Forms.PictureBox pboDealerCard2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnNewRound;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblPlayerPoints;
        private System.Windows.Forms.Button btnSetChips;
        private System.Windows.Forms.Label lblDealerChips;
        private System.Windows.Forms.Label lblPlayerChips;
        private System.Windows.Forms.Timer tmrDealerAI;
        private System.Windows.Forms.Button btnBet1;
        private System.Windows.Forms.Button btnBet2;
        private System.Windows.Forms.Button btnBet3;
        private System.Windows.Forms.Button btnBet4;
        private System.Windows.Forms.Button btnBet5;
        private System.Windows.Forms.Label lblPlaceBet;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnAllIn;
        private System.Windows.Forms.PictureBox pboLogo;
        private System.Windows.Forms.PictureBox pboFacebook;
        private System.Windows.Forms.PictureBox pboInstagram;
        private System.Windows.Forms.PictureBox pboYoutube;
    }
}

