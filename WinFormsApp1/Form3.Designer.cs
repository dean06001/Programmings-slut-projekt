namespace WinFormsApp1
{
    partial class Form3
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
            menuStrip1 = new MenuStrip();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            b1 = new Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, infoToolStripMenuItem, mainMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(77, 20);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // mainMenuToolStripMenuItem
            // 
            mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            mainMenuToolStripMenuItem.Size = new Size(80, 20);
            mainMenuToolStripMenuItem.Text = "Main Menu";
            mainMenuToolStripMenuItem.Click += mainMenuToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.44371F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.44371F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.1125832F));
            tableLayoutPanel1.Controls.Add(button9, 2, 2);
            tableLayoutPanel1.Controls.Add(button8, 1, 2);
            tableLayoutPanel1.Controls.Add(button7, 0, 2);
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(b1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(800, 426);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Click += button_click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button9.Location = new Point(537, 285);
            button9.Name = "button9";
            button9.Size = new Size(260, 135);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.Location = new Point(270, 285);
            button8.Name = "button8";
            button8.Size = new Size(261, 135);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.Location = new Point(3, 285);
            button7.Name = "button7";
            button7.Size = new Size(261, 135);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Location = new Point(537, 144);
            button6.Name = "button6";
            button6.Size = new Size(260, 135);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(270, 144);
            button5.Name = "button5";
            button5.Size = new Size(261, 135);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(3, 144);
            button4.Name = "button4";
            button4.Size = new Size(261, 135);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(537, 3);
            button3.Name = "button3";
            button3.Size = new Size(260, 135);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(270, 3);
            button2.Name = "button2";
            button2.Size = new Size(261, 135);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b1.Location = new Point(3, 3);
            b1.Name = "b1";
            b1.Size = new Size(261, 135);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            b1.Click += button_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button b1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
    }
}