using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Texteditor
{
    public partial class Main : Form
    {
        private const string DialogFilter = "Rich Text File(*.rtf)|*.rtf";
        private string _filePath;
        private int _version;

        public Main()
        {
            InitializeComponent();
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = new Font(textBox.Font, textBox.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = new Font(textBox.Font, textBox.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            textBox.SelectionFont = new Font(textBox.Font, textBox.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void clearSelection()
        {
            textBox.SelectionStart = 0;
            textBox.SelectAll();
            textBox.SelectionBackColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Reset selection
            clearSelection();

            var wordsToSearch = textBoxSearch.Text.Split(',');
            foreach (var word in wordsToSearch)
            {
                var startIndex = 0;
                while (startIndex < textBox.TextLength)
                {
                    var wordStartIndex = textBox.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        textBox.SelectionStart = wordStartIndex;
                        textBox.SelectionLength = word.Length;
                        textBox.SelectionBackColor = Color.Yellow;
                    }
                    else
                        break;

                    startIndex += wordStartIndex + word.Length;
                }
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            var searchText = textBoxSearch.Text.Trim();
            var replaceText = textBoxReplace.Text.Trim();
            var index = 0;
            var count = 0;
            var diff = replaceText.Length - searchText.Length;
            foreach (Match match in Regex.Matches(textBox.Text, searchText))
            {
                textBox.Select(match.Index + index, searchText.Length);
                index += diff;
                textBox.SelectedText = replaceText;
                count++;
            }

            MessageBox.Show(count + "übereinstimmungen wurden ersetzt!");
            textBox.SelectAll();
            textBox.SelectionBackColor = Color.White;
            textBox.Select(0, 0);
            btnReplace.Enabled = false;
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileInfo = new FileInfo(_filePath);
            try
            {
                fileInfo.MoveTo(fileInfo.DirectoryName + "\\" + fileInfo.Name.Replace(".rtf", "") + "__V_" + _version +
                                ".rtf");
            }
            catch (IOException exception)
            {
                // Catch exceptions for IO errors
                MessageBox.Show(exception.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _version++;
            textBox.SaveFile(_filePath);
        }

        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = DialogFilter;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            try
            {
                textBox.SaveFile(saveFileDialog.FileName);
            }
            catch (IOException exception)
            {
                // Catch exceptions for IO errors
                MessageBox.Show(exception.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _filePath = saveFileDialog.FileName;
            speichernToolStripMenuItem.Enabled = true;
            MessageBox.Show("Gespeichert!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();

            // Reset selection
            clearSelection();
        }

        private void ladenStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = DialogFilter,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            
            try
            {
                textBox.LoadFile(openFileDialog.FileName);
            }
            catch (IOException exception)
            {
                // Catch exceptions for IO errors
                MessageBox.Show(exception.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _filePath = openFileDialog.FileName;
            _version = 0;
            speichernToolStripMenuItem.Enabled = false; // To prevent overwriting of existing files
        }
    }
}