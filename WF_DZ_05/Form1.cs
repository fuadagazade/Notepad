using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WF_DZ_05
{
    public partial class Form1 : Form
    {
        private int findStart;
        private FontStyle Style;
        private Object[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        private bool check;

        public Form1()
        {
            InitializeComponent();

            tsLabelCount.Margin = new Padding((ClientSize.Width - pbTextCount.Width - tsLabelCount.Width - 140), 3, 0, 2);

            check = false;

            findStart = 0;
            Style = 0;

            FontSelector.Items.AddRange(FontFamily.Families);
            FontSelector.ComboBox.DisplayMember = "Name";
            FontSelector.SelectedIndex = FontSelector.Items.IndexOf(rtbText.Font.FontFamily);

            FontSizeSelector.Items.AddRange(sizes);

            FontSizeSelector.Text = ((int)(rtbText.Font.Size + 0.5)).ToString();
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            if (rtbText.Text.Length != 0)
            {
                btnSelectAll.Enabled = true;

                if(rtbText.SelectionFont == null)
                {
                    FontSizeSelector.SelectedIndex = -1;
                    FontSelector.SelectedIndex = -1;
                }
                else
                {                  
                    FontSizeSelector.Text = ((int)(rtbText.SelectionFont.Size + 0.5)).ToString();
                    FontSelector.SelectedItem = rtbText.SelectionFont.FontFamily;
                }
            }
            else
            {
                btnSelectAll.Enabled = false;
            }

            if (rtbText.SelectedText.Length != 0)
            {
                btnCopy.Enabled = true;
                btnCut.Enabled = true;
                btnDelete.Enabled = true;
                btnUnselect.Enabled = true;
            }
            else
            {
                btnCopy.Enabled = false;
                btnCut.Enabled = false;
                btnDelete.Enabled = false;
                btnUnselect.Enabled = false;
            }

            if (tbFindText.Text.Length != 0 && rtbText.Text.Length >= tbFindText.Text.Length)
            {
                btnFind.Enabled = true;
            }
            else
            {
                btnFind.Enabled = false;
            }

            check = true;
            btnBold.Checked = rtbText.SelectionFont.Style.HasFlag(FontStyle.Bold) ? true : false;
            btnItalic.Checked = rtbText.SelectionFont.Style.HasFlag(FontStyle.Italic) ? true : false;
            btnUnderline.Checked = rtbText.SelectionFont.Style.HasFlag(FontStyle.Underline) ? true : false;
            btnStrikeout.Checked = rtbText.SelectionFont.Style.HasFlag(FontStyle.Strikeout) ? true : false;
            check = false;

            pbTextCount.Value = rtbText.TextLength;
            ssLinesCount.Text = rtbText.Lines.Count().ToString();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;

            if (btn == btnCopy)
            {
                rtbText.Copy();
                btnPaste.Enabled = true;
            }
            else if (btn == btnCut)
            {
                rtbText.Cut();
                btnPaste.Enabled = true;
            }
            else if (btn == btnPaste)
            {
                rtbText.Paste();
                btnPaste.Enabled = false;
            }
            else if (btn == btnDelete)
            {
                rtbText.SelectedText = "";
            }
            else if (btn == btnSelectAll)
            {
                rtbText.SelectAll();
                rtbText.Focus();
            }
            else if (btn == btnUnselect)
            {
                rtbText.DeselectAll();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (findStart + tbFindText.Text.Length >= rtbText.Text.Length)
            {
                findStart = 0;
            }

            findStart = rtbText.Find(tbFindText.Text, findStart, RichTextBoxFinds.None);

            if (findStart != -1)
            {
                rtbText.Select(findStart, tbFindText.Text.Length);
                rtbText.Focus();
            }

            ++findStart;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnFile.HideDropDown();

            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            OpenFileDialog OpenFile = new OpenFileDialog();
            if(btn == btnOpen)
            {
                OpenFile.Filter = "Text Files|*.txt;*.rtf";

                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(OpenFile.FileName) == ".txt")
                    {
                        FileStream fs = new FileStream(OpenFile.FileName, FileMode.Open);
                        StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                        string str = sr.ReadToEnd();
                        rtbText.Text = str;
                    }
                    else
                    {
                        rtbText.LoadFile(OpenFile.FileName, RichTextBoxStreamType.RichText);
                    }
                }
            }
            else if(btn == btnOpenTXT)
            {
                OpenFile.Filter = "Text File|*.txt";

                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(OpenFile.FileName, FileMode.Open);
                    StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                    string str = sr.ReadToEnd();
                    rtbText.Text = str;
                }
            }
            else if(btn == btnOpenRTF)
            {
                OpenFile.Filter = "Rich Text File|*.rtf";

                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    rtbText.LoadFile(OpenFile.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnFile.HideDropDown();

            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            SaveFileDialog SaveFile = new SaveFileDialog();
            if(btn == btnSave)
            {
                SaveFile.Filter = "Text File|*.txt|Rich Text File|*.rtf";
            }
            else if (btn == btnSaveTXT)
            {
                SaveFile.Filter = "Text File|*.txt";
            }
            else if (btn == btnSaveRTF)
            {
                SaveFile.Filter = "Rich Text File|*.rtf";
            }

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                rtbText.SaveFile(SaveFile.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор \r\nАвтор : Фуад Агазаде", "О программе", MessageBoxButtons.OK);
        }

        private void btnFontEdit_Click(object sender, EventArgs e)
        {
            FontDialog EditFont = new FontDialog();

            EditFont.Font = rtbText.Font;
            if (EditFont.ShowDialog() == DialogResult.OK)
            {
                if (rtbText.SelectedText.Length != 0)
                {
                    rtbText.SelectionFont = EditFont.Font;
                    FontSizeSelector.Text = ((int)(rtbText.SelectionFont.Size + 0.5)).ToString();
                    FontSelector.SelectedItem = rtbText.SelectionFont.FontFamily;
                }
                else
                {
                    rtbText.Font = EditFont.Font;
                    FontSizeSelector.Text = ((int)(rtbText.Font.Size + 0.5)).ToString();
                    FontSelector.SelectedItem = rtbText.Font.FontFamily;
                }

                btnItalic.Checked = EditFont.Font.Italic;
                btnBold.Checked = EditFont.Font.Bold;
                btnUnderline.Checked = EditFont.Font.Underline;
                btnStrikeout.Checked = EditFont.Font.Strikeout;
            }
        }

        private void btnColorEdit_Click(object sender, EventArgs e)
        {
            ColorDialog EditColor = new ColorDialog();
            if (EditColor.ShowDialog() == DialogResult.OK)
            {
                if (rtbText.SelectedText.Length != 0)
                {
                    rtbText.SelectionColor = EditColor.Color;
                }
                else
                {
                    rtbText.ForeColor = EditColor.Color;
                }
            }
        }

        private void Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FontSizeSelector.SelectedItem != null)
            {
                    rtbText.SelectionFont = new Font(FontSelector.Text, (int)FontSizeSelector.SelectedItem, Style);
            }
        }

        private void btnAlign_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;

            if(btn == btnAlignLeft)
            {
                btnAlignLeft.Enabled = false;
                btnAlignCenter.Enabled = btnAlignRight.Enabled = true;

                rtbText.SelectAll();
                rtbText.SelectionAlignment = HorizontalAlignment.Left;
                rtbText.DeselectAll();
            }
            else if (btn == btnAlignCenter)
            {
                btnAlignCenter.Enabled = false;
                btnAlignLeft.Enabled = btnAlignRight.Enabled = true;

                rtbText.SelectAll();
                rtbText.SelectionAlignment = HorizontalAlignment.Center;
                rtbText.DeselectAll();
            }
            else if (btn == btnAlignRight)
            {
                btnAlignRight.Enabled = false;
                btnAlignCenter.Enabled = btnAlignLeft.Enabled = true;

                rtbText.SelectAll();
                rtbText.SelectionAlignment = HorizontalAlignment.Right;
                rtbText.DeselectAll();
            }
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;

            if (btn == btnBig)
            {
                FontSizeSelector.SelectedIndex += FontSizeSelector.SelectedIndex < FontSizeSelector.Items.Count - 1 ? 1 : 0;
            }
            else if (btn == btnSmall)
            {
                FontSizeSelector.SelectedIndex -= FontSizeSelector.SelectedIndex > 0 ? 1 : 0;

            }

            if (rtbText.SelectionLength != 0)
            {
                if (btn == btnLower)
                {
                    rtbText.SelectedText = rtbText.SelectedText.ToLower();
                }
                else if (btn == btnUpper)
                {
                    rtbText.SelectedText = rtbText.SelectedText.ToUpper();
                }
            }
            else
            {
                if (btn == btnLower)
                {
                    rtbText.Text = rtbText.Text.ToLower();
                }
                else if (btn == btnUpper)
                {
                    rtbText.Text = rtbText.Text.ToUpper();
                }
            }
        }

        private void btnStyle_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;

            if(btn == btnBold && !check)
            {
                if (btnBold.Checked == true) Style |= FontStyle.Bold;
                else Style ^= FontStyle.Bold;
            }
            else if (btn == btnItalic && !check)
            {
                if (btnItalic.Checked == true) Style |= FontStyle.Italic;
                else Style ^= FontStyle.Italic;
            }
            else if (btn == btnUnderline && !check)
            {
                if (btnUnderline.Checked == true) Style |= FontStyle.Underline;
                else Style ^= FontStyle.Underline;
            }
            else if (btn == btnStrikeout && !check)
            {
                if (btnStrikeout.Checked == true) Style |= FontStyle.Strikeout;
                else Style ^= FontStyle.Strikeout;
            }

            if(FontSizeSelector.SelectedItem != null && !check)
            {
                if (rtbText.SelectedText.Length != 0)
                {
                    rtbText.SelectionFont = new Font(FontSelector.Text, (int)FontSizeSelector.SelectedItem, Style);
                }
                else
                {
                    rtbText.Font = new Font(FontSelector.Text, (int)FontSizeSelector.SelectedItem, Style);
                }
            }

        }

        private void btnBgColor_Click(object sender, EventArgs e)
        {
            ColorDialog EditColor = new ColorDialog();
            if (EditColor.ShowDialog() == DialogResult.OK)
            {
                BackColor = rtbText.BackColor = EditColor.Color;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            tsLabelCount.Margin = new Padding((ClientSize.Width - pbTextCount.Width - tsLabelCount.Width - 140), 3, 0, 2);
        }

    }
}
