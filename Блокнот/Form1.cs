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

        private void notebookForm_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = "";
            mainTextBox.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Copy();
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            mainTextBox.Paste();
        }

        private void fontColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                mainTextBox.SelectionColor = dialog.Color;
        }

        private void fontFormatButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                mainTextBox.SelectionFont = dialog.Font;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                mainTextBox.Text = File.ReadAllText(dialog.FileName);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(dialog.FileName,mainTextBox.Text);
        }

        private void aboutProgramButton_Click(object sender, EventArgs e)
        {

        }
    }
}
