using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            DialogResult result = printDialog.ShowDialog();
        }
        public string OpenFileName;
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            OpenFileName = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    richTextBox1.SaveFile(myStream + ".txt", RichTextBoxStreamType.PlainText);
                    myStream.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFileName != null)
            {
                richTextBox1.SaveFile(OpenFileName, RichTextBoxStreamType.PlainText);
            }
            else
            {
                Stream myStream;
                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                OpenFileName = saveFileDialog1.FileName;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        richTextBox1.SaveFile(myStream+".txt", RichTextBoxStreamType.RichText);
                        myStream.Close();
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFileName = openFileDialog1.FileName;
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
       
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            Form1 form1 = this;         
            frm2.ShowDialog();
                      
            string newfileName = Form2.imputText;
            string filebegining = @"C:\Users\nicho\Documents\" ;
            string FileEnd = ".txt";
            string newfilepath = filebegining+ newfileName + FileEnd;
            if (File.Exists(newfilepath))
            { MessageBox.Show("File name allready extsts ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (File.Exists(OpenFileName))
            { MessageBox.Show("File name allready extsts ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {FileStream fs = File.Create(newfilepath);}

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void printPreveiwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1 =   new PrintPreviewDialog();
            DialogResult printPreviewDialog2 = printPreviewDialog1.ShowDialog();
        }

        private void rulerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gridlinesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            DialogResult colorDialogresult = colorDialog1.ShowDialog();
            colorDialog1.ShowHelp = false;
            if (colorDialogresult == DialogResult.OK)
            { richTextBox1.BackColor = colorDialog1.Color;}
            
        
        }

        private void forgroundColeourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            DialogResult colorDialogresult = colorDialog1.ShowDialog();
            colorDialog1.ShowHelp = false;
            if (colorDialogresult == DialogResult.OK)
            { richTextBox1.ForeColor = colorDialog1.Color; }
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();

        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }

        private void toolStripFontButton1_Click(object sender, EventArgs e)
        {
           
            fontDlg = new FontDialog();
            
             
            fontDlg.ShowColor = false;           
            fontDlg.ShowEffects = false;
            fontDlg.ShowHelp = false;
            DialogResult dialogResult = fontDlg.ShowDialog();
            if ( dialogResult == DialogResult.OK)
            {                              
                richTextBox1.Font  =new Font(fontDlg.Font.Name,fontDlg.Font.Size);
             

            }
        
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            float newfontsize = richTextBox1.Font.Size;
            newfontsize++;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, newfontsize);
        }

        private void toolStripSeparator8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            float newfontsize = richTextBox1.Font.Size;
            newfontsize--;
            richTextBox1.Font = new Font(richTextBox1.Font.Name, newfontsize);
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.Name,richTextBox1.Font.Size,FontStyle.Regular);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.Name, richTextBox1.Font.Size, FontStyle.Italic);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.Name, richTextBox1.Font.Size, FontStyle.Bold);
        }

        private void boldItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.Name, richTextBox1.Font.Size, FontStyle.Bold);
            richTextBox1.Font = new Font(richTextBox1.Font.Name, richTextBox1.Font.Size, FontStyle.Italic);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
    }   
}
