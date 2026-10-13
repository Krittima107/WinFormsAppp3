namespace WinFormsApp1
{
    partial class MainMenu
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
            workshopMenu = new ToolStripMenuItem();
            workshop3 = new ToolStripMenuItem();
            workshop4 = new ToolStripMenuItem();
            workshop5ToolStripMenuItem = new ToolStripMenuItem();
            workshop6ToolStripMenuItem = new ToolStripMenuItem();
            workshop7ToolStripMenuItem = new ToolStripMenuItem();
            workshop8ToolStripMenuItem = new ToolStripMenuItem();
            workshop9ToolStripMenuItem = new ToolStripMenuItem();
            transactionLabToolStripMenuItem = new ToolStripMenuItem();
            transactionLab1ToolStripMenuItem = new ToolStripMenuItem();
            transactionLab2ToolStripMenuItem = new ToolStripMenuItem();
            exampleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { workshopMenu, transactionLabToolStripMenuItem, exampleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // workshopMenu
            // 
            workshopMenu.DropDownItems.AddRange(new ToolStripItem[] { workshop3, workshop4, workshop5ToolStripMenuItem, workshop6ToolStripMenuItem, workshop7ToolStripMenuItem, workshop8ToolStripMenuItem, workshop9ToolStripMenuItem });
            workshopMenu.Name = "workshopMenu";
            workshopMenu.Size = new Size(110, 29);
            workshopMenu.Text = "Workshop";
            // 
            // workshop3
            // 
            workshop3.Name = "workshop3";
            workshop3.Size = new Size(206, 34);
            workshop3.Text = "Workshop3";
            workshop3.Click += workshop3_Click;
            // 
            // workshop4
            // 
            workshop4.Name = "workshop4";
            workshop4.Size = new Size(206, 34);
            workshop4.Text = "Workshop4";
            workshop4.Click += workshop4_Click;
            // 
            // workshop5ToolStripMenuItem
            // 
            workshop5ToolStripMenuItem.Name = "workshop5ToolStripMenuItem";
            workshop5ToolStripMenuItem.Size = new Size(206, 34);
            workshop5ToolStripMenuItem.Text = "Workshop5";
            workshop5ToolStripMenuItem.Click += workshop5ToolStripMenuItem_Click;
            // 
            // workshop6ToolStripMenuItem
            // 
            workshop6ToolStripMenuItem.Name = "workshop6ToolStripMenuItem";
            workshop6ToolStripMenuItem.Size = new Size(206, 34);
            workshop6ToolStripMenuItem.Text = "Workshop6";
            workshop6ToolStripMenuItem.Click += workshop6ToolStripMenuItem_Click;
            // 
            // workshop7ToolStripMenuItem
            // 
            workshop7ToolStripMenuItem.Name = "workshop7ToolStripMenuItem";
            workshop7ToolStripMenuItem.Size = new Size(206, 34);
            workshop7ToolStripMenuItem.Text = "Workshop7";
            workshop7ToolStripMenuItem.Click += workshop7ToolStripMenuItem_Click;
            // 
            // workshop8ToolStripMenuItem
            // 
            workshop8ToolStripMenuItem.Name = "workshop8ToolStripMenuItem";
            workshop8ToolStripMenuItem.Size = new Size(206, 34);
            workshop8ToolStripMenuItem.Text = "Workshop8";
            workshop8ToolStripMenuItem.Click += workshop8ToolStripMenuItem_Click;
            // 
            // workshop9ToolStripMenuItem
            // 
            workshop9ToolStripMenuItem.Name = "workshop9ToolStripMenuItem";
            workshop9ToolStripMenuItem.Size = new Size(206, 34);
            workshop9ToolStripMenuItem.Text = "Workshop9";
            workshop9ToolStripMenuItem.Click += workshop9ToolStripMenuItem_Click;
            // 
            // transactionLabToolStripMenuItem
            // 
            transactionLabToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transactionLab1ToolStripMenuItem, transactionLab2ToolStripMenuItem });
            transactionLabToolStripMenuItem.Name = "transactionLabToolStripMenuItem";
            transactionLabToolStripMenuItem.Size = new Size(144, 29);
            transactionLabToolStripMenuItem.Text = "TransactionLab";
            // 
            // transactionLab1ToolStripMenuItem
            // 
            transactionLab1ToolStripMenuItem.Name = "transactionLab1ToolStripMenuItem";
            transactionLab1ToolStripMenuItem.Size = new Size(270, 34);
            transactionLab1ToolStripMenuItem.Text = "Transaction_Lab1";
            transactionLab1ToolStripMenuItem.Click += transactionLab1ToolStripMenuItem_Click;
            // 
            // transactionLab2ToolStripMenuItem
            // 
            transactionLab2ToolStripMenuItem.Name = "transactionLab2ToolStripMenuItem";
            transactionLab2ToolStripMenuItem.Size = new Size(270, 34);
            transactionLab2ToolStripMenuItem.Text = "Transaction_Lab2";
            transactionLab2ToolStripMenuItem.Click += transactionLab2ToolStripMenuItem_Click;
            // 
            // exampleToolStripMenuItem
            // 
            exampleToolStripMenuItem.Name = "exampleToolStripMenuItem";
            exampleToolStripMenuItem.Size = new Size(94, 29);
            exampleToolStripMenuItem.Text = "Example";
            exampleToolStripMenuItem.Click += exampleToolStripMenuItem_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "MainMenu";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem workshopMenu;
        private ToolStripMenuItem workshop3;
        private ToolStripMenuItem workshop4;
        private ToolStripMenuItem workshop5ToolStripMenuItem;
        private ToolStripMenuItem workshop6ToolStripMenuItem;
        private ToolStripMenuItem workshop7ToolStripMenuItem;
        private ToolStripMenuItem workshop8ToolStripMenuItem;
        private ToolStripMenuItem workshop9ToolStripMenuItem;
        private ToolStripMenuItem transactionLabToolStripMenuItem;
        private ToolStripMenuItem transactionLab1ToolStripMenuItem;
        private ToolStripMenuItem transactionLab2ToolStripMenuItem;
        private ToolStripMenuItem exampleToolStripMenuItem;
    }
}