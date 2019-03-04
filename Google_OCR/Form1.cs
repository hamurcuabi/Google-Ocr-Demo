using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Orc
{
    public partial class Form1 : Form
    {
        public string ImagePath { get; set; }
        private string ResultJsonString = "";
        private string ResultTextString = "";
        public Form1()
        {
            InitializeComponent();

            cmbLanguage.DataSource = GoogleLanguage.GetAll;
            cmbLanguage.ValueMember = "Code";
            cmbLanguage.DisplayMember = "Name";
            cmbLanguage.SelectedValue = "tr";

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            btnProcess.Enabled = false;
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Images(*.jpg,*.png,*.jpeg)|*.jpg;*.png;*.jpeg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(dlg.FileName);
                    if (fileInfo.Length > 1024 * 1024)
                    {
                        MessageBox.Show("jpeg file's size can not be larger than 1Mb");
                        return;
                    }
                    pxImage.Image = Image.FromFile(dlg.FileName);
                    ImagePath = dlg.FileName;
                    btnProcess.Enabled = true;
                }
            }
        }

        private void rbJson_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text = ResultJsonString.Replace("\\r", "").Replace("\\n", "");
        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        {
            txtResult.Text = ResultTextString;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ImagePath))
                return;


            txtResult.Text = "";
            GoogleAnnotate annotate = new GoogleAnnotate();
            annotate.GetText(ImagePath, cmbLanguage.SelectedValue + "");
            if (string.IsNullOrEmpty(annotate.Error) == false)
                MessageBox.Show("ERROR: " + annotate.Error);
            else
            {
                ResultJsonString = annotate.JsonResult;
                ResultTextString = txtResult.Text = annotate.TextResult;
                if (rbJson.Checked)
                    txtResult.Text = ResultJsonString.Replace("\\r", "").Replace("\\n", "");
                fillTexts(ResultTextString);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fillTexts(String result)
        {

            //For Tc Id
            Match matchTc = Regex.Match(result, @"([0-9]{11})");
            if (matchTc.Success) txt4d.Text = matchTc.Value;

            //For 4a
            Match match4a = Regex.Match(result, @"(([4][a][.] [0-3]{1}[0-9]{1}.[0-1]{1}[0-9]{1}.[12]{1}[0-9]{3}))");
            if (match4a.Success) txt4a.Text = match4a.Value.Substring(4);
            else
            {
                Match match4a2 = Regex.Match(result, @"(([4][a][.][0-3]{1}[0-9]{1}.[0-1]{1}[0-9]{1}.[12]{1}[0-9]{3}))");
                if (match4a2.Success) txt4a.Text = match4a2.Value.Substring(3);
            }

            //For 4b
            Match match4b = Regex.Match(result, @"(([4][b][.] [0-3]{1}[0-9]{1}.[0-1]{1}[0-9]{1}.[12]{1}[0-9]{3}))");
            if (match4b.Success) txt4b.Text = match4b.Value.Substring(4);
            else
            {
                Match match4b2 = Regex.Match(result, @"(([4][b][.][0-3]{1}[0-9]{1}.[0-1]{1}[0-9]{1}.[12]{1}[0-9]{3}))");
                if (match4b2.Success) txt4b.Text = match4b2.Value.Substring(3);

            }

            //For 4c
            Match match4c = Regex.Match(result, @"[4][c][.] ([0-9]{2} .*)");
            if (match4c.Success) txt4c.Text = match4c.Value.Substring(4);
            else
            {
                Match match4c2 = Regex.Match(result, @"[4][c][.]([0-9]{2} .*)");
                if (match4c2.Success) txt4c.Text = match4c2.Value.Substring(3);
                else
                {
                    Match match4c3 = Regex.Match(result, @"[4][c][.]([0-9]{2}.*)");
                    if (match4c3.Success) txt4c.Text = match4c3.Value.Substring(3);
                    else
                    {
                        Match match4c4 = Regex.Match(result, @"[4][c][.] ([0-9]{2}.*)");
                        if (match4c4.Success) txt4c.Text = match4c4.Value.Substring(4);
                    }

                }
            }

            //For 3.
            Match match3 = Regex.Match(result, @"(([3]{1}[.] [0-3]{1}[0-9]{1}.[0-1]{1}[0-9]{1}.[12]{1}[0-9]{3}) .*)");
            if (match3.Success) txtBornDate.Text = match3.Value.Substring(3);
            else
            {
                Match match32 = Regex.Match(result, @"(([3]{1}[.][0-3]{1}[0-9]{1}.[0-1]{1}[0-9]{1}.[12]{1}[0-9]{3}) .*)");
                if (match32.Success) txt4b.Text = match32.Value.Substring(2);
                else
                {
                    Match match33 = Regex.Match(result, @"(([3]{1}[.] [0-3]{1}[0-9]{1}.[0-1]{1}[0-9]{1}.[12]{1}[0-9]{3}).*)");
                    if (match33.Success) txtBornDate.Text = match33.Value.Substring(3);
                    else
                    {
                        Match match34 = Regex.Match(result, @"(([3]{1}[.][0-3]{1}[0-9]{1}.[0-1]{1}[0-9]{1}.[12]{1}[0-9]{3}).*)");
                        if (match34.Success) txtBornDate.Text = match34.Value.Substring(2);
                    }
                }

            }

            //for SurName
            Match matchSurname = Regex.Match(result, @"[1]{1}[.] [A-Z](.*)");
            if (matchSurname.Success) txtSurname.Text = matchSurname.Value.Substring(3);
            else
            {
                Match matchSurname2 = Regex.Match(result, @"[1]{1}[.][A-Z](.*)");
                if (matchSurname2.Success) txtSurname.Text = matchSurname2.Value.Substring(2);
            }

            //for Name
            Match matchName = Regex.Match(result, @"[2]{1}[.] [A-Z](.*)");
            if (matchName.Success) txtName.Text = matchName.Value.Substring(3);
            else
            {
                Match matchName2 = Regex.Match(result, @"[2]{1}[.][A-z](.*)");
                if (matchName2.Success) txtName.Text = matchName2.Value.Substring(2);
            }


            //for 5.
            Match match5 = Regex.Match(result, @"[5]{1}[.] [0-9]{6}");
            if (match5.Success) txt5.Text = match5.Value.Substring(3);
            else
            {
                Match match52 = Regex.Match(result, @"[5]{1}[.][0-9]{6}");
                if (match52.Success) txt5.Text = match52.Value.Substring(2);
            }

            //for 9.
            Match match9 = Regex.Match(result, @"[9]{1}[.] [A-Z0-9](.*)");
            if (match9.Success) txt9.Text = match9.Value.Substring(3);
            else
            {
                Match match92 = Regex.Match(result, @"[9]{1}[.][A-Z0-9](.*)");
                if (match92.Success) txt9.Text = match92.Value.Substring(2);
            }


        }
    }
}
