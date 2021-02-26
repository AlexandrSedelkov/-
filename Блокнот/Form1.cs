using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Блокнот
{
    public partial class notebookForm : Form
    {
        public notebookForm()
        {
            InitializeComponent();
        }

        private void NotebookForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = "";
            mainTextBox.Text = "";
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Copy();
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Paste();
        }

        private void FontColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                mainTextBox.SelectionColor = dialog.Color;
        }

        private void FontFormatButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                mainTextBox.SelectionFont = dialog.Font;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                mainTextBox.Text = File.ReadAllText(dialog.FileName);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(dialog.FileName,mainTextBox.Text);
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это блокнот. \n\nГлавный разработчик: Седелков Александр Евгеньевич", "Блокнот: сведения", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void WordWrapButton_Click(object sender, EventArgs e)
        {
            if(wordWrapButton.Checked == true)
            {
                mainTextBox.WordWrap = false;
                wordWrapButton.Checked = false;
            }
            else if (wordWrapButton.Checked == false)
            {
                mainTextBox.WordWrap = true;
                wordWrapButton.Checked = true;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
