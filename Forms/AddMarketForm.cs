using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coursework.Model;
using coursework.Fields;
using coursework.Controllers;
using coursework.Factories;

namespace coursework.Forms
{
    public partial class AddMarketForm : Form
    {
        public event EmptyMessage NeedToFilter;
        public event ParamsMessage MarketAdded;
        private string[] fieldsNoShow = { Properties.Resources.NameMarketNameType };
        private List<object> _markets;

        public AddMarketForm(List<Field> fields, List<object> markets)
        {
            InitializeComponent();
            DisplayMarket(fields, markets);
            _markets = markets;
        }

        public void DisplayMarket(List<Field> fields, List<object> markets)
        {
            _markets = markets;
            selectMarketListView.Columns.Clear();
            selectMarketListView.Items.Clear();
            foreach (Field field in fields)
            {
                if (!fieldsNoShow.Contains(field.NameType))
                {
                    ColumnHeader header = new ColumnHeader
                    {
                        Text = field.NameType
                    };
                    selectMarketListView.Columns.Add(header);
                }
            }

            foreach (Market market in markets)
            {
                List<string> values = new List<string>();
                foreach (Field field in fields)
                {
                    if (!fieldsNoShow.Contains(field.NameType))
                    {
                        values.Add(field.GetValue(market));
                    }
                }
                selectMarketListView.Items.Add(new ListViewItem(values.ToArray()));
            }
            selectMarketListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (selectMarketListView.SelectedItems.Count <= 0)
            {
                warningLabel.Visible = true;
            }
            else
            {
                Market market = _markets[selectMarketListView.SelectedIndices[0]] as Market;
                MarketAdded?.Invoke(market.Clone());
                Close();
            }
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            warningLabel.Visible = false;
        }

        private void selectMarketListView_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            NeedToFilter?.Invoke();
        }
    }
}
