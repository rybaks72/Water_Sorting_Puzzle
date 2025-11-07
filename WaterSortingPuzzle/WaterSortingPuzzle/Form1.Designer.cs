namespace WinFroms_Lab2
{
    partial class MainWindow
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            surrenderToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            openSettingsToolStripMenuItem = new ToolStripMenuItem();
            gameLayoutPanel = new TableLayoutPanel();
            buttonLayoutPanel = new TableLayoutPanel();
            undoButton = new Button();
            nextPuzzleButton = new Button();
            undoLeftLabel = new Label();
            scoreLabel = new Label();
            bestScoreLabel = new Label();
            congratulationsLabel = new Label();
            vialLayoutPanel = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            gameLayoutPanel.SuspendLayout();
            buttonLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(978, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, surrenderToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(200, 34);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // surrenderToolStripMenuItem
            // 
            surrenderToolStripMenuItem.Name = "surrenderToolStripMenuItem";
            surrenderToolStripMenuItem.Size = new Size(200, 34);
            surrenderToolStripMenuItem.Text = "Surrender";
            surrenderToolStripMenuItem.Click += surrenderToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(200, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(92, 29);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // openSettingsToolStripMenuItem
            // 
            openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            openSettingsToolStripMenuItem.Size = new Size(239, 34);
            openSettingsToolStripMenuItem.Text = "Open Settings...";
            openSettingsToolStripMenuItem.Click += openSettingsToolStripMenuItem_Click;
            // 
            // gameLayoutPanel
            // 
            gameLayoutPanel.ColumnCount = 1;
            gameLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gameLayoutPanel.Controls.Add(buttonLayoutPanel, 0, 1);
            gameLayoutPanel.Controls.Add(vialLayoutPanel, 0, 0);
            gameLayoutPanel.Dock = DockStyle.Fill;
            gameLayoutPanel.Location = new Point(0, 33);
            gameLayoutPanel.Name = "gameLayoutPanel";
            gameLayoutPanel.RowCount = 2;
            gameLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gameLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            gameLayoutPanel.Size = new Size(978, 611);
            gameLayoutPanel.TabIndex = 1;
            // 
            // buttonLayoutPanel
            // 
            buttonLayoutPanel.ColumnCount = 4;
            buttonLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.18107F));
            buttonLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.9176941F));
            buttonLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2345676F));
            buttonLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5637856F));
            buttonLayoutPanel.Controls.Add(undoButton, 0, 0);
            buttonLayoutPanel.Controls.Add(nextPuzzleButton, 3, 0);
            buttonLayoutPanel.Controls.Add(undoLeftLabel, 0, 1);
            buttonLayoutPanel.Controls.Add(scoreLabel, 1, 0);
            buttonLayoutPanel.Controls.Add(bestScoreLabel, 1, 1);
            buttonLayoutPanel.Controls.Add(congratulationsLabel, 2, 0);
            buttonLayoutPanel.Dock = DockStyle.Fill;
            buttonLayoutPanel.Location = new Point(3, 514);
            buttonLayoutPanel.Name = "buttonLayoutPanel";
            buttonLayoutPanel.RowCount = 2;
            buttonLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonLayoutPanel.Size = new Size(972, 94);
            buttonLayoutPanel.TabIndex = 0;
            // 
            // undoButton
            // 
            undoButton.Anchor = AnchorStyles.Left;
            undoButton.Location = new Point(30, 6);
            undoButton.Margin = new Padding(30, 3, 3, 3);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(112, 34);
            undoButton.TabIndex = 0;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // nextPuzzleButton
            // 
            nextPuzzleButton.Anchor = AnchorStyles.Right;
            nextPuzzleButton.Enabled = false;
            nextPuzzleButton.Location = new Point(830, 6);
            nextPuzzleButton.Margin = new Padding(3, 3, 30, 3);
            nextPuzzleButton.Name = "nextPuzzleButton";
            nextPuzzleButton.Size = new Size(112, 34);
            nextPuzzleButton.TabIndex = 1;
            nextPuzzleButton.Text = "Next Puzzle";
            nextPuzzleButton.UseVisualStyleBackColor = true;
            nextPuzzleButton.Click += nextPuzzleButton_Click;
            // 
            // undoLeftLabel
            // 
            undoLeftLabel.AutoSize = true;
            undoLeftLabel.Location = new Point(55, 47);
            undoLeftLabel.Margin = new Padding(55, 0, 3, 0);
            undoLeftLabel.Name = "undoLeftLabel";
            undoLeftLabel.Size = new Size(59, 25);
            undoLeftLabel.TabIndex = 2;
            undoLeftLabel.Text = "label1";
            // 
            // scoreLabel
            // 
            scoreLabel.Anchor = AnchorStyles.Left;
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(170, 11);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(59, 25);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "label2";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Location = new Point(170, 47);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(59, 25);
            bestScoreLabel.TabIndex = 4;
            bestScoreLabel.Text = "label3";
            // 
            // congratulationsLabel
            // 
            congratulationsLabel.Anchor = AnchorStyles.Right;
            congratulationsLabel.AutoSize = true;
            congratulationsLabel.Location = new Point(748, 11);
            congratulationsLabel.Name = "congratulationsLabel";
            congratulationsLabel.Size = new Size(59, 25);
            congratulationsLabel.TabIndex = 5;
            congratulationsLabel.Text = "label1";
            // 
            // vialLayoutPanel
            // 
            vialLayoutPanel.ColumnCount = 1;
            vialLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            vialLayoutPanel.Dock = DockStyle.Fill;
            vialLayoutPanel.Location = new Point(3, 3);
            vialLayoutPanel.Name = "vialLayoutPanel";
            vialLayoutPanel.RowCount = 1;
            vialLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            vialLayoutPanel.Size = new Size(972, 505);
            vialLayoutPanel.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 644);
            Controls.Add(gameLayoutPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(700, 500);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potion Master";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gameLayoutPanel.ResumeLayout(false);
            buttonLayoutPanel.ResumeLayout(false);
            buttonLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem surrenderToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem openSettingsToolStripMenuItem;
        private TableLayoutPanel gameLayoutPanel;
        private TableLayoutPanel buttonLayoutPanel;
        private Button undoButton;
        private Button nextPuzzleButton;
        private Label undoLeftLabel;
        private Label scoreLabel;
        private Label bestScoreLabel;
        private TableLayoutPanel vialLayoutPanel;
        private Label congratulationsLabel;
    }
}
