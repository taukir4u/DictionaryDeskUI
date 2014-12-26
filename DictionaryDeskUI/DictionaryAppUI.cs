using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryDeskUI
{
    public partial class DictionaryAppUI : Form
    {

        Dictionary<string, string> studentIfo = new Dictionary<string, string>();
        public DictionaryAppUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            studentIfo.Add(idTextBox.Text, detailsTextBox.Text);
            MessageBox.Show("Information saved");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool id = studentIfo.ContainsKey(searchIdTextBox.Text);
            if (id)
            {
                string details = studentIfo[searchIdTextBox.Text];
                MessageBox.Show(details,"Search Result: ");
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string info = "";
            foreach (KeyValuePair<string, string> item in studentIfo)
            {
                info += (item.Key + " " + item.Value +" \n");
            }
            MessageBox.Show(info);
            }
    }
}