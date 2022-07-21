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
    public partial class AddAssetForm : Form
    {
        public event ParamsMessage AssetAdded;
        public event EmptyMessage NeedFilter;
        private string[] fieldsNoShow = { Properties.Resources.NameAssetNameType };

       /* private List<Field> _fields;*/

        private delegate void ParamsMessageAddHeader(ColumnHeader header);
        private delegate void ParamsMessageListViewItem(ListViewItem listViewItem);
        private delegate void ParamsEmpty();
        private delegate void ParamsEnableButton(Button button);
        private List<object> _assets { get; set; }

        public AddAssetForm()
        {
            InitializeComponent();
        }

        public void GetValueForShow(List<object> assets, List<Field> fields)
        {
            _assets = assets;
            displayMarket(_assets, fields);
            enableButton(addButton);
            enableButton(filterButton);
        }

        private void displayMarket(List<object> values, List<Field> fields)
        {
            clearListViewColumns();
            clearListView();
            foreach (Field field in fields)
            {
                if (!fieldsNoShow.Contains(field.NameType))
                {
                    ColumnHeader header = new ColumnHeader
                    {
                        Text = field.NameType
                    };
                    addHeader(header);
                }
            }

            foreach (Asset asset in values)
            {
                List<string> _values = new List<string>();
                foreach (Field field in fields)
                {
                    if (!fieldsNoShow.Contains(field.NameType))
                    {
                        _values.Add(field.GetValue(asset));
                    }
                }
                addListItem(new ListViewItem(_values.ToArray()));
            }
            resizeColumns();
        }
        
        private void clearListViewColumns()
        {
            if (selectAssetListView.InvokeRequired)
            {
                var d = new ParamsEmpty(clearListViewColumns);
                selectAssetListView.Invoke(d);
            }
            else
            {
                selectAssetListView.Columns.Clear();
            }
        }

        private void clearListView()
        {
            if (selectAssetListView.InvokeRequired)
            {
                var d = new ParamsEmpty(clearListView);
                selectAssetListView.Invoke(d);
            }
            else
            {
                selectAssetListView.Items.Clear();
            }
        }

        private void addListItem(ListViewItem listViewItem)
        {
            if (selectAssetListView.InvokeRequired)
            {
                var d = new ParamsMessageListViewItem(addListItem);
                selectAssetListView.Invoke(d, new object[] { listViewItem });
            }
            else
            {
                selectAssetListView.Items.Add(listViewItem);
            }
        }

        private void enableButton(Button button)
        {
            if (selectAssetListView.InvokeRequired)
            {
                var d = new ParamsEnableButton(enableButton);
                selectAssetListView.Invoke(d, new object[] { button });
            }
            else
            {
                button.Enabled = true;
            }
        }

        private void resizeColumns()
        {
            if (selectAssetListView.InvokeRequired)
            {
                var d = new ParamsEmpty(resizeColumns);
                selectAssetListView.Invoke(d);
            }
            else
            {
                selectAssetListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void addHeader(ColumnHeader header)
        {
            if (selectAssetListView.InvokeRequired)
            {
                var d = new ParamsMessageAddHeader(addHeader);
                selectAssetListView.Invoke(d, new object[] { header });
            }
            else
            {
                selectAssetListView.Columns.Add(header);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (selectAssetListView.SelectedIndices[0] == -1)
            {
                warningLabel.Visible = true;
            }
            else
            {
                AssetAdded?.Invoke(_assets[selectAssetListView.SelectedIndices[0]]);
                Close();
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            NeedFilter?.Invoke();
        }
    }
}
