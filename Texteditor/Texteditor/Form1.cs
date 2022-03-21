using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Texteditor
{
    public partial class Form1 : Form
    {

        private const string dialogFilter = "Rich Text File(*.rtf)|*.rtf";
        private static string filePath;
        private static int version = 0;


        public Form1()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = dialogFilter;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.SaveFile(saveFileDialog.FileName);
                filePath = saveFileDialog.FileName;
                btnQuickSave.Enabled = true;
                MessageBox.Show("Gespeichert!");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = dialogFilter;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.LoadFile(openFileDialog.FileName);
            }
        }

        private void btnQuickSave_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            fileInfo.MoveTo(fileInfo.DirectoryName + "\\" + fileInfo.Name.Replace(".rtf", "") + "__V_" + version + ".rtf");
            version++;
            textBox.SaveFile(filePath);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            textBox.SelectionBackColor = Color.White;
            textBox.Select(0, 0);
            var searchText = textBoxSearch.Text.Trim();
            int start = textBox.Find(searchText, 0, RichTextBoxFinds.None);
            textBox.SelectionStart = start;
            textBox.SelectionLength = searchText.Length;
            textBox.SelectionBackColor = Color.Aqua;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            var searchText = textBoxSearch.Text.Trim();
            var replaceText = textBoxReplace.Text.Trim();
            int index = 0;
            int count = 0;
            int diff = replaceText.Length - searchText.Length;
            foreach (Match match in Regex.Matches(textBox.Text, searchText))
            {
                textBox.Select(match.Index + index, searchText.Length);
                index += diff;
                textBox.SelectedText = replaceText;
                count++;
            }
            MessageBox.Show("Replaced " + count + " matches!");
            textBox.SelectAll();
            textBox.SelectionBackColor = Color.White;
            textBox.Select(0, 0);

        }
    }
}
