using coursework.Controllers.Filter;
using coursework.Factories;
using coursework.Fields;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework.Forms
{
    public partial class FilterForm : Form
    {
        public event EmptyMessage NeedApplyFilteringEvent;
        private const int begPosY = 3;
        private const int begPosX = 4;
        private const int offsetY = 80;
        private int cntField = 0;
        List<Field> _fields;
        public FilterContr FilterController { get; private set; }
        public FilterForm(FilterContr filterContr, List<Field> fields)
        {
            InitializeComponent();
            FilterController = filterContr;
            _fields = new List<Field>();
            int i = 0;
            foreach (Field field in fields)
            {
                FormStringComp compStr = new FormStringComp(
                       begPosY + offsetY * i,
                       i + 1,
                       begPosX,
                       field.NameType);
                panel1.Controls.Add(compStr.Panel);
                _fields.Add(field);
                i++;
            }
            cntField = i;
        }

        private void CollectLogExp()
        {
            LogExpFactory factory = new LogExpFactory();
            for (int i = 0; i < cntField; i++)
            {
                if (!(GetElement(string.
                       Format(Properties.Resources.NameCheckboxFilter, i + 1)) as CheckBox).Checked)
                {
                    TextBox textBox = GetElement(string.
                    Format(Properties.Resources.NameTextboxFilter, i + 1)) as TextBox;
                    if (textBox.Text != "")
                    {
                        ILogExp logExp = factory.Create(GetRadioButton(i + 1));
                        FilterRule rule = _fields[i].CreateRule(logExp);
                        rule.FilterVal = textBox.Text;
                        FilterController.AddRule(rule);
                    }
                }
            }
        }

        private Control GetElement(string nameEl)
        {
            Control[] contrs = panel1.Controls.Find(nameEl, true);
            Control control = contrs[0];
            return control;
        }

        private string GetRadioButton(int i)
        {
            for (int j = 1; j <= 4; j++)
            {
                RadioButton control = GetElement(string.
                    Format(Properties.Resources.NameRadioButtonFilter, i, j)) as RadioButton;
                if (control.Checked)
                {
                    return control.Text;
                }
            }
            throw new Exception("Не один из кнопок не была нажата");
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            CollectLogExp();
            NeedApplyFilteringEvent?.Invoke();
            Close();
        }
    }
}
