using System;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace cryptolab2
{
    public partial class MainForm : Form
    {
        private readonly DESGenerator _generator;
        private readonly Statistics _statistics;
        public StatisticsFrom statForm;

        public MainForm()
        {
            InitializeComponent();
            _generator = new DESGenerator(outputTextBox);
            _statistics = new Statistics();
        }

        private void browseOutput_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFileBox.Text = openFileDialog1.FileName;
            }
        }

        private void browseInput_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFileBox.Text = openFileDialog1.FileName;
            }
        }

        private void pyschButton_Click(object sender, EventArgs e)
        {
            _generator.SetStartVector(inputFileBox.Text);

            if (inputFileBox.Text == "")
            {
                outputTextBox.AppendText("Please, select input file!\n");
                return;
            }

            if (outputFileBox.Text == "")
            {
                outputTextBox.AppendText(string.Format("Generating \"{0}\" bytes:\n", sequenceLengthDropdown.Value));
                outputTextBox.AppendText(
                    BitConverter.ToString(_generator.GenerateBytes((int) sequenceLengthDropdown.Value)));
                outputTextBox.AppendText("\n");
            }
            else
            {
                outputTextBox.AppendText(string.Format("Generating \"{0}\" bytes to file:\n", sequenceLengthDropdown.Value));
                _generator.GenerateBytesToFile((int)sequenceLengthDropdown.Value, outputFileBox.Text);
                outputTextBox.AppendText("Finished!\n");
            }
        }

        private void statButton_Click(object sender, EventArgs e)
        {
            if (outputFileBox.Text != "")
            {
                var stat = _statistics.collectStatArray(outputFileBox.Text);
                statForm = new StatisticsFrom();
                statForm.ShowStatistics(stat);
            }
            else
            {
                outputTextBox.AppendText("Please, select file to collect statistics!\n");
            }
        }
    }
}