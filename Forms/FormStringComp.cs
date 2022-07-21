using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace coursework.Forms
{
    public class FormStringComp
    {
        Label label;
        TextBox textBox;
        CheckBox checkBox;
        List<RadioButton> radioButtons;
        string[] nameRadioButton = {
            Properties.Resources.WordEquallyFilter,
            Properties.Resources.WordNotEquallyFilter,
            Properties.Resources.WordContainFilter,
            Properties.Resources.WordNotContainFilter};

        Size[] sizesRadioButton = {
            new Size(49, 29), new Size(55, 29),
            new Size(135, 29), new Size(161, 29) };

        Point[] pointsRadioButton = {
            new Point(500, 15), new Point(550, 15),
            new Point(600, 15),new Point(700, 15)};

        bool[] boolsRadioButton = { true, false, false, false };
        public Panel Panel { get; private set; }

        public FormStringComp(int height, int index, int posX, string text)
        {
            radioButtons = new List<RadioButton>();
            label = createLabel(index, text);
            textBox = createTextBox(index);
            checkBox = createCheckBox(index);
            checkBox.CheckedChanged += RadioButton_CheckedChanged;
            for (int i = 0; i < nameRadioButton.Length; i++)
            {
                radioButtons.Add(createRadioButton(
                    index, i + 1, nameRadioButton[i], pointsRadioButton[i],
                    sizesRadioButton[i], boolsRadioButton[i]));
            }
            Panel = createPanel(height, index, posX);
            Panel.Controls.Add(label);
            Panel.Controls.Add(textBox);
            Panel.Controls.Add(checkBox);
            for (int i = 0; i < nameRadioButton.Length; i++)
            {
                Panel.Controls.Add(radioButtons[i]);
            }
        }

        private Panel createPanel(int height, int i, int posX)
        {
            Panel panel = new Panel();
            panel.Location = new Point(posX, height);
            panel.Name = string.Format(Properties.Resources.NamePanelFilter, i);
            panel.Size = new Size(850,55);
            return panel;
        }

        private Label createLabel(int i, string text)
        {
            Label label = new Label
            {
                AutoSize = true,
                Font = new Font(
                "Microsoft Sans Serif",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                204),
                Location = new Point(5, 16),
                Name = string.Format(Properties.Resources.NameLabelFilter, i),
                MaximumSize = new Size(160, 50),
                Text = text,
                Enabled = false
            };
            return label;
        }

        private TextBox createTextBox(int i)
        {
            TextBox textBox = new TextBox
            {
                Font = new Font(
                "Microsoft Sans Serif",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                204),
                Location = new Point(170, 13),
                Name = string.Format(Properties.Resources.NameTextboxFilter, i),
                Size = new Size(192, 30),
                Enabled = false
            };
            return textBox;
        }

        private CheckBox createCheckBox(int i)
        {
            CheckBox checkBox = new CheckBox
            {
                AutoSize = true,
                Font = new Font(
                "Microsoft Sans Serif",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                204),
                Location = new Point(380, 15),
                Name = string.Format(Properties.Resources.NameCheckboxFilter, i),
                Size = new Size(164, 29),
                Text = Properties.Resources.WordNoLookFilter,
                UseVisualStyleBackColor = true,
                Checked = true
            };
            return checkBox;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label.Enabled = !label.Enabled;
            textBox.Enabled = !textBox.Enabled;
            for (int i = 0; i < nameRadioButton.Length; i++)
            {
                radioButtons[i].Enabled = !radioButtons[i].Enabled;
            }
        }

        private RadioButton createRadioButton(int i, int numBut, string text,
            Point point, Size size, bool flagChecked)
        {
            RadioButton radioButton = new RadioButton
            {
                AutoSize = true,
                Font = new Font(
                "Microsoft Sans Serif",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point,
                204),
                Location = point,
                Name = string.Format(Properties.Resources.NameRadioButtonFilter, i, numBut),
                Size = size,
                Text = text,
                Enabled = false,
                UseVisualStyleBackColor = true,
                Checked = flagChecked
            };
            return radioButton;
        }
    }

}
