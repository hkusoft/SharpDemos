using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingSearch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var keyword = SearchTextBox.Text;
            if(!string.IsNullOrEmpty(keyword))
            {
                var results = BingWebSearcher.Search(keyword);

                ResultListBox.DataSource = results;
                ResultListBox.DisplayMember = "Name";
                ResultListBox.ValueMember = "Link";

            }

        }

        private void ResultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var link = ResultListBox.SelectedValue.ToString();
            if(!string.IsNullOrEmpty(link))
                ResultWebBrowser.Navigate(link);
        }
    }
}
