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
    public partial class AuthForm : Form
    {
        public event ParamsMessage RegistrationEvent;
        public event ParamsMessage LoginEvent;
        
        public AuthForm()
        {
            InitializeComponent();
        }

        public void ShowErrorMessage(string msg)
        {
            errorWarnLabel.Visible = true;
            errorWarnLabel.Text = msg;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            errorWarnLabel.Visible = false;
            RegistrationEvent?.Invoke(loginRegistrationTextBox.Text, passwordRegistrationTextBox.Text);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            errorWarnLabel.Visible = false; 
             LoginEvent?.Invoke(loginLoginTextBox.Text, passwordLoginTextBox.Text);
        }
    }
}
