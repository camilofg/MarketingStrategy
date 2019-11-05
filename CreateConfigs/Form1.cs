using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Entities;
using Newtonsoft;
using Newtonsoft.Json;
using Services;

namespace CreateConfigs
{
    public partial class Form1 : Form
    {
        private readonly IServiceManager _serviceManager;
        private static readonly Dictionary<string, TypeField> wordsSearch = new Dictionary<string, TypeField>();
        private static List<PersonProfile> _listPersons;
        public Form1(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtRole.Text))
            {
                MessageBox.Show("The field can't be empty");
                return;
            }

            if (wordsSearch.Any(x => x.Key.Equals(TxtRole.Text)))
            {
                MessageBox.Show("The term is already added");
                TxtRole.Text = string.Empty;
                return;
            }
            wordsSearch.Add(TxtRole.Text, TypeField.Role);
            dataGridView1.Rows.Add(TxtRole.Text);
            TxtRole.Text = string.Empty;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Gb_Configs.Enabled = false;
            Gb_LoadFile.Enabled = false;
            MessageBox.Show("The profile file is being generated");
            var lang = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked)?.Text.Substring(0, 2).ToLower();
            
            var configObj = await _serviceManager.GetTermsAsync(lang, wordsSearch).ConfigureAwait(true);
            var recommendedProfiles = _serviceManager.GenerateProfile(configObj, _listPersons);
            var routeFile = _serviceManager.GenerateProfilesFile(recommendedProfiles);
            if (!string.IsNullOrEmpty(routeFile))
            {
                Lbl_Profiles_Created.Visible = true;
                Lnk_File_Created.Text = routeFile;
                Lnk_File_Created.Visible = true;
            }

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Gb_Configs.Enabled = true;
            Gb_LoadFile.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtIndustry.Text))
            {
                MessageBox.Show("The field can't be empty");
                return;
            }

            if (wordsSearch.Any(x => x.Key.Equals(TxtIndustry.Text)))
            {
                MessageBox.Show("The term is already added");
                TxtRole.Text = string.Empty;
                return;
            }
            wordsSearch.Add(TxtIndustry.Text, TypeField.Industry);
            dataGridView2.Rows.Add(TxtIndustry.Text);
            TxtIndustry.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {Filter = "Text files | *.in", Multiselect = false};
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                Txt_PathFile.Text = path;
                try
                {
                    _listPersons = _serviceManager.LoadFile(path);
                    if (_listPersons.Count > 0) { 
                        Gb_Configs.Visible = true;
                        MessageBox.Show($"Were loaded {_listPersons.Count.ToString()} profiles");
                    }
                    else
                        MessageBox.Show("The input file does not contains valid profiles");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void Lnk_File_Created_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("notepad.exe", ((System.Windows.Forms.LinkLabel)sender).Text);
        }
    }
}
