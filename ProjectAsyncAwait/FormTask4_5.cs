using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAsyncAwait
{
    public partial class FormTask4_5 : Form
    {
        private bool _keepCoping = false;
        private bool _shutCoping = false;
        private string _source = string.Empty;
        private string _dest = string.Empty;
        private int _total;
        private int _copied;
        public FormTask4_5()
        {
            InitializeComponent();
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;
            buttonContinue.Enabled = false;
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                _source = fbd.SelectedPath;
                labelSource.Text = _source;
            }
        }

        private void buttonDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                _dest = fbd.SelectedPath;
                labelDest.Text = _dest;
            }
        }
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_source) || string.IsNullOrEmpty(_dest))
            {
                MessageBox.Show("Select source and destination first");
                return;
            }
            buttonCopy.Enabled = false;
            buttonStop.Enabled = true;
            buttonPause.Enabled = true;
            _total = 0;
            _copied = 0;
            _keepCoping = true;
            _copy(_source, _dest);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _shutCoping = true;
            buttonCopy.Enabled = true;
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;
            buttonContinue.Enabled = false;
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _keepCoping = false;
            buttonContinue.Enabled = true;
            buttonPause.Enabled = false;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            _keepCoping = true;
            buttonContinue.Enabled = false;
            buttonPause.Enabled = true;
        }

        private async Task _copy(string source, string dest)
        {
            var files = Directory.GetFiles(source);
            _total += files.Length;
            _updateFiles();
            var directories = Directory.GetDirectories(source);
            string newDest;

            foreach (var file in files)
            {
                await Task.Delay(300);
                if (_shutCoping)
                {
                    return;
                }
                while (!_keepCoping)
                {
                    await Task.Delay(300);
                    if (_shutCoping)
                    {
                        return;
                    }
                }
                File.Copy(file, $"{dest}\\{file.Split('\\').Last()}");
                _copied++;
                _updateFiles();
            }

            foreach (var dir in directories)
            {
                newDest = $"{dest}\\{dir.Split('\\').Last()}";
                Directory.CreateDirectory(newDest);
                await Task.Delay(300);
                if (_shutCoping)
                {
                    return;
                }
                while (!_keepCoping)
                {
                    await Task.Delay(300);
                    if (_shutCoping)
                    {
                        return;
                    }
                }
                await _copy(dir, newDest);
            }

            if (_total == _copied)
            {
                _stopCopying();
            }
        }

        private async Task _updateFiles()
        {
            labelTotal.Text = _total.ToString();
            labelCopied.Text = _copied.ToString();
        }

        private void _stopCopying()
        {
            buttonCopy.Enabled = true;
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;
        }
    }
}
