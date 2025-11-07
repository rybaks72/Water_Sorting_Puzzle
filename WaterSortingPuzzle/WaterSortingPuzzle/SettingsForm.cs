using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotionMaster
{
    public partial class SettingsForm : Form
    {
        private bool _settingsChanged = false;

        public SettingsForm()
        {
            InitializeComponent();

            comboBox1.SelectedIndexChanged += OnSettingsChanged;
            numericUpDown1.ValueChanged += OnSettingsChanged;
            numericUpDown2.ValueChanged += OnSettingsChanged;
            darkRadioButton.CheckedChanged += OnSettingsChanged;
            lightRadioButton.CheckedChanged += OnSettingsChanged;

            LoadCurrentSettings();
        }

        private void OnSettingsChanged(object sender, EventArgs e)
        {
            _settingsChanged = true;
        }
        private void LoadCurrentSettings()
        {
            comboBox1.SelectedItem = Properties.Settings.Default.Difficulty;
            numericUpDown2.Value = Properties.Settings.Default.MaxSegments;
            numericUpDown1.Value = Properties.Settings.Default.VialsCount;
            if (Properties.Settings.Default.ColorTheme == "Dark")
                darkRadioButton.Checked = true;
            else
                lightRadioButton.Checked = true;

            _settingsChanged = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (_settingsChanged)
            {
                Properties.Settings.Default.Difficulty = comboBox1.SelectedItem.ToString();
                Properties.Settings.Default.MaxSegments = (int)numericUpDown2.Value;
                Properties.Settings.Default.VialsCount = (int)numericUpDown1.Value;
                Properties.Settings.Default.ColorTheme = darkRadioButton.Checked ? "Dark" : "Light";

                Properties.Settings.Default.Save();
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
