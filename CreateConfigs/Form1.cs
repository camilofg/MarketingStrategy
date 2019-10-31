using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private IRequestTermsService _iRequestTermsService;
        private static readonly Dictionary<TypeField, string> wordsSearch = new Dictionary<TypeField, string>();
        public Form1(IRequestTermsService requestTermsService)
        {
            _iRequestTermsService = requestTermsService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtRole.Text))
            {
                MessageBox.Show("The field can't be empty");
                return;
            }

            if (wordsSearch.Any(x => x.Value.Equals(TxtRole.Text)))
            {
                MessageBox.Show("The term is already added");
                TxtRole.Text = string.Empty;
                return;
            }
            wordsSearch.Add(TypeField.Role, TxtRole.Text);
            dataGridView1.Rows.Add(TxtRole.Text);
            TxtRole.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lang = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked)?.Text.Substring(0, 2).ToLower();
            var configObj = _iRequestTermsService.GetTermsAsync(lang, wordsSearch, TypeField.Industry).ConfigureAwait(true);
            var confJson = JsonConvert.SerializeObject(configObj);
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtIndustry.Text))
            {
                MessageBox.Show("The field can't be empty");
                return;
            }

            if (wordsSearch.Any(x => x.Value.Equals(TxtIndustry.Text)))
            {
                MessageBox.Show("The term is already added");
                TxtRole.Text = string.Empty;
                return;
            }
            wordsSearch.Add(TypeField.Industry, TxtIndustry.Text);
            dataGridView2.Rows.Add(TxtIndustry.Text);
            TxtIndustry.Text = string.Empty;
        }
    }
}
