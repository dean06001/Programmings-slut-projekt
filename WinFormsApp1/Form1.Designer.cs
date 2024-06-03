namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Spelarknapp = new Button();
            BlackJack = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Spelarknapp
            // 
            Spelarknapp.Location = new Point(191, 130);
            Spelarknapp.Name = "Spelarknapp";
            Spelarknapp.Size = new Size(75, 43);
            Spelarknapp.TabIndex = 0;
            Spelarknapp.Text = "Black Jack";
            Spelarknapp.UseVisualStyleBackColor = true;
            Spelarknapp.Click += Spelarknapp_Click_1;
            // 
            // BlackJack
            // 
            BlackJack.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BlackJack.Location = new Point(286, 62);
            BlackJack.Name = "BlackJack";
            BlackJack.Size = new Size(211, 71);
            BlackJack.TabIndex = 1;
            BlackJack.Text = "Välj ett spel";
            BlackJack.TextAlign = ContentAlignment.MiddleCenter;
            BlackJack.Click += BlackJack_Click;
            // 
            // button1
            // 
            button1.Location = new Point(347, 130);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 2;
            button1.Text = "Tic tac toe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kort1;
            pictureBox1.Location = new Point(179, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 147);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images1;
            pictureBox2.Location = new Point(333, 204);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 115);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(503, 130);
            button2.Name = "button2";
            button2.Size = new Size(78, 43);
            button2.TabIndex = 5;
            button2.Text = "Snake";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Snake_OG_png2;
            pictureBox3.Location = new Point(475, 204);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(132, 76);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(805, 450);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(BlackJack);
            Controls.Add(Spelarknapp);
            Name = "Form1";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Spelarknapp;
        private Label BlackJack;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private PictureBox pictureBox3;
    }
}
