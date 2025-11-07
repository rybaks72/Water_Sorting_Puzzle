using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PotionMaster;

namespace WinFroms_Lab2
{
    public partial class MainWindow : Form
    {
        private ColorPreset LightPreset = new ColorPreset(
        background: Color.White,
        button: Color.FromKnownColor(KnownColor.Control),
        text: Color.Black
        );

        private ColorPreset DarkPreset = new ColorPreset(
            background: Color.FromArgb(60, 60, 60),
            button: Color.FromArgb(100, 100, 100),
            text: Color.White
        );

        private int undoLeft;
        private int score = 0;
        private int bestScore;
        private int mode;
        private int vialCount;
        private int maxSegments;
        private int[] colorCount;
        private Stack<(VialControl, VialControl, int)> undoMoves = new Stack<(VialControl, VialControl, int)>();
        private List<VialControl> vials = new List<VialControl>();
        public MainWindow()
        {
            InitializeComponent();
            ApplySettings();
        }
        private void SetEasyMode()
        {
            undoLeft = 3;
            colorCount = new int[vialCount - undoLeft];
            for (int i = 0; i < vialCount - 3; i++)
            {
                vials.Add(new VialControl(maxSegments, maxSegments, null, vialCount, 3, colorCount));
            }
            for (int i = 0; i < 3; i++)
            {
                vials.Add(new VialControl(maxSegments, 0, null, vialCount, 3, colorCount));
            }
        }
        private void SetMediumMode()
        {
            undoLeft = 2;
            colorCount = new int[vialCount - undoLeft];
            for (int i = 0; i < vialCount - 2; i++)
            {
                vials.Add(new VialControl(maxSegments, maxSegments, null, vialCount, 2, colorCount));
            }
            for (int i = 0; i < 2; i++)
            {
                vials.Add(new VialControl(maxSegments, 0, null, vialCount, 2, colorCount));
            }
        }
        private void SetHardMode()
        {
            undoLeft = 1;
            colorCount = new int[vialCount - undoLeft];
            for (int i = 0; i < vialCount - 1; i++)
            {
                vials.Add(new VialControl(maxSegments, maxSegments, null, vialCount, 1, colorCount));
            }
            vials.Add(new VialControl(maxSegments, 0, null, vialCount, 1, colorCount));
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
        private void Vial_OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            var src = sender as VialControl;

            if (src == null || src.CurrentSegments == 0) return;
            var data = new DataObject("source", src);
            src.DoDragDrop(data, DragDropEffects.Move);
        }
        private void Vial_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("source"))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        private void Vial_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("source"))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        private void Vial_DragDrop(object sender, DragEventArgs e)
        {
            var dst = sender as VialControl;
            var src = e.Data.GetData("source") as VialControl;
            if (dst == null | src == null) return;

            if (!ReferenceEquals(src, dst)
                && src.CurrentSegments > 0
                && dst.CurrentSegments < dst.MaxSegments)
            {
                int movedSegments = 0;
                Color removedColor = src.segments.Last();
                if (dst.segments.Count != 0 && removedColor != dst.segments.Last())
                    return;
                Color belowColor = src.segments.Last();
                while (removedColor == belowColor && src.segments.Count() > 0 && dst.segments.Count() < dst.MaxSegments)
                {
                    src.segments.RemoveAt(src.CurrentSegments - 1);
                    movedSegments++;
                    src.CurrentSegments--;
                    dst.segments.Add(belowColor);
                    dst.CurrentSegments++;
                    if (src.segments.Count() > 0)
                        belowColor = src.segments.Last();
                }
                undoMoves.Push((src, dst, movedSegments));

                var color = dst.segments.Last();
                if(dst.segments.Count == maxSegments && !dst.segments.Any(s => !s.Equals(color)))
                {
                    score += (mode + 1);
                    scoreLabel.Text = $"Score : {score}";
                }
            }

            if (isPuzzleSolved())
            {
                nextPuzzleButton.Enabled = true;
                score += (mode + 1) * (vialCount - (3 - mode));
                bestScore = Math.Max(bestScore, score);
                PotionMaster.Properties.Settings.Default.BestScore = bestScore;
                PotionMaster.Properties.Settings.Default.Save();

                scoreLabel.Text = $"Score : {score}";
                bestScoreLabel.Text = $"Best Score : {bestScore}";
                congratulationsLabel.Text = "Congratulations!";
            }
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new SettingsForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ApplySettings();
                }
            }
        }
        private void ApplySettings()
        {
            switch (PotionMaster.Properties.Settings.Default.Difficulty)
            {
                case "Easy": mode = 0; break;
                case "Medium": mode = 1; break;
                case "Hard": mode = 2; break;
                default: mode = 0; break;
            }

            maxSegments = PotionMaster.Properties.Settings.Default.MaxSegments;
            vialCount = PotionMaster.Properties.Settings.Default.VialsCount;
            bestScore = PotionMaster.Properties.Settings.Default.BestScore;

            //colour theme
            ApplyColorTheme(PotionMaster.Properties.Settings.Default.ColorTheme == "Dark" ? DarkPreset : LightPreset);

            vials.Clear();
            vialLayoutPanel.Controls.Clear();
            vialLayoutPanel.RowCount = 1;
            vialLayoutPanel.ColumnCount = 1;
            score = 0;
            NewGame();
        }
        private void ApplyColorTheme(ColorPreset preset)
        {
            BackColor = preset.Background;
            ForeColor = preset.Text;

            menuStrip1.BackColor = preset.Background;
            menuStrip1.ForeColor = preset.Text;
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = preset.Text;
                item.BackColor = preset.Background;

                foreach (ToolStripMenuItem drop in item.DropDownItems)
                {
                    drop.ForeColor = preset.Text;
                    drop.BackColor = preset.Background;
                }
            }

            ApplyColorThemeToControls(Controls, preset);

            foreach (var vial in vials)
            {
                vial.BackColor = preset.Background;
                vial.ForeColor = preset.Text;

                vial.Invalidate();
            }
        }
        private void ApplyColorThemeToControls(Control.ControlCollection controls, ColorPreset preset)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = preset.Button;
                    ctrl.ForeColor = preset.Text;
                }
                else
                {
                    ctrl.BackColor = preset.Background;
                    ctrl.ForeColor = preset.Text;
                }

                if (ctrl.HasChildren)
                    ApplyColorThemeToControls(ctrl.Controls, preset);
            }
        }

        private void NewGame()
        {
            undoMoves.Clear();
            undoButton.Enabled = true;
            switch (mode)
            {
                case 0:
                    SetEasyMode();
                    break;
                case 1:
                    SetMediumMode();
                    break;
                case 2:
                    SetHardMode();
                    break;
                default:
                    SetEasyMode();
                    break;
            }
            for (int i = 0; i < colorCount.Length; i++)
                colorCount[i] = 0;
            if (vialCount <= 7)
                vialLayoutPanel.ColumnCount = vialCount;
            else
            {
                vialLayoutPanel.ColumnCount = 7;
                int rows = vialCount / 7;
                vialLayoutPanel.RowCount = (vialCount % 7 != 0 ? rows + 1 : rows);
            }
            vialLayoutPanel.ColumnStyles.Clear();
            vialLayoutPanel.RowStyles.Clear();
            for (int i = 0; i < vialLayoutPanel.ColumnCount; i++)
                vialLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / vialLayoutPanel.ColumnCount));
            for (int i = 0; i < vialLayoutPanel.RowCount; i++)
                vialLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / vialLayoutPanel.RowCount));

            for (int i = 0; i < vialCount; i++)
            {
                vials[i].Margin = new Padding(8);
                vials[i].DragDrop += Vial_DragDrop;
                vials[i].DragEnter += Vial_DragEnter;
                vials[i].DragOver += Vial_DragOver;
                vials[i].MouseDown += Vial_OnMouseDown;
                vialLayoutPanel.Controls.Add(vials[i]);
            }

            undoLeftLabel.Text = $"Left : {undoLeft}";
            scoreLabel.Text = $"Score : {score}";
            bestScoreLabel.Text = $"Best Score : {bestScore}";
            congratulationsLabel.Text = "";
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vials.Clear();
            vialLayoutPanel.Controls.Clear();

            score = 0;
            NewGame();
        }

        private bool isPuzzleSolved()
        {
            foreach (var vial in vials)
            {
                if (vial.CurrentSegments == 0)
                    continue;
                if (vial.CurrentSegments != maxSegments)
                    return false;
                var first = vial.segments.First();
                if (vial.segments.Any(s => !s.Equals(first)))
                    return false;
            }
            return true;
        }

        private void nextPuzzleButton_Click(object sender, EventArgs e)
        {
            if (nextPuzzleButton.Enabled == true)
            {
                vials.Clear();
                vialLayoutPanel.Controls.Clear();

                NewGame();
                nextPuzzleButton.Enabled = false;
            }
        }

        private void surrenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (score > bestScore)
            {
                bestScore = score;
                PotionMaster.Properties.Settings.Default.BestScore = bestScore;
                PotionMaster.Properties.Settings.Default.Save();
            }

            //Either what's below or Close(); - it was not specified
            vials.Clear();
            vialLayoutPanel.Controls.Clear();
            score = 0;

            NewGame();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (undoMoves.Count == 0 || undoLeft <= 0) return;
            undoLeft--;
            if(undoLeft <= 0)
            {
                undoLeft = 0;
                undoButton.Enabled = false;
            }

            VialControl src, dst;
            int segCount;
            (src, dst, segCount) = undoMoves.Pop();
            for(int j = 0; j < segCount; j++)
            {
                var color = dst.segments.Last();
                dst.segments.RemoveAt(dst.CurrentSegments - 1);
                dst.CurrentSegments--;
                src.segments.Add(color);
                src.CurrentSegments++;
            }

            undoLeftLabel.Text = $"Left : {undoLeft}";
        }
    }
}
