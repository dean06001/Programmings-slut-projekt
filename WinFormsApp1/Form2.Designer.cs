namespace WinFormsApp1
{
    partial class Form2
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
            Dator = new Label();
            btnDeal = new Button();
            DatorText = new TextBox();
            btnHit = new Button();
            btnStand = new Button();
            btnReset = new Button();
            Player = new Label();
            PlayerText = new TextBox();
            Menu = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Dator
            // 
            Dator.AutoSize = true;
            Dator.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            Dator.Location = new Point(113, 84);
            Dator.Name = "Dator";
            Dator.Size = new Size(54, 20);
            Dator.TabIndex = 0;
            Dator.Text = "Dator:";
            Dator.Click += Dator_Click;
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(113, 279);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(75, 23);
            btnDeal.TabIndex = 1;
            btnDeal.Text = "Deal";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += btnDeal_Click;
            // 
            // DatorText
            // 
            DatorText.Location = new Point(228, 84);
            DatorText.Name = "DatorText";
            DatorText.Size = new Size(100, 23);
            DatorText.TabIndex = 2;
            // 
            // btnHit
            // 
            btnHit.Location = new Point(253, 279);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(75, 23);
            btnHit.TabIndex = 3;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.Location = new Point(404, 279);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(75, 23);
            btnStand.TabIndex = 4;
            btnStand.Text = "Stand";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += btnStand_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(548, 279);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Player
            // 
            Player.AutoSize = true;
            Player.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            Player.Location = new Point(113, 179);
            Player.Name = "Player";
            Player.Size = new Size(57, 20);
            Player.TabIndex = 6;
            Player.Text = "Player:";
            // 
            // PlayerText
            // 
            PlayerText.Location = new Point(228, 171);
            PlayerText.Name = "PlayerText";
            PlayerText.Size = new Size(100, 23);
            PlayerText.TabIndex = 7;
            // 
            // Menu
            // 
            Menu.Location = new Point(713, 12);
            Menu.Name = "Menu";
            Menu.Size = new Size(75, 23);
            Menu.TabIndex = 8;
            Menu.Text = "Menu";
            Menu.UseVisualStyleBackColor = true;
            Menu.Click += Menu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.challenge05_cards;
            pictureBox1.Location = new Point(456, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 226);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Menu);
            Controls.Add(PlayerText);
            Controls.Add(Player);
            Controls.Add(btnReset);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Controls.Add(DatorText);
            Controls.Add(btnDeal);
            Controls.Add(Dator);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Dator;
        private Button btnDeal;
        private TextBox DatorText;
        private Button btnHit;
        private Button btnStand;
        private Button btnReset;
        private Label Player;
        private TextBox PlayerText;
        private Button Menu;
        private PictureBox pictureBox1;
    }
}