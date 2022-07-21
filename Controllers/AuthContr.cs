using coursework.Exceptions;
using coursework.Factories;
using coursework.Forms;
using coursework.Model;

namespace coursework.Controllers
{
    public class AuthContr
    {
        public event AttachedMessage<Account> Logined;
        public event AttachedMessage<Account> Registrated;
        private AuthForm form;
        private DBContr dBContr;
        public AuthContr()
        {
            form = new AuthForm();
            dBContr = new DBContr();
            form.RegistrationEvent += Form_RegistrationEvent;
            form.LoginEvent += Form_LoginEvent;
            form.Show();
        }

        private void Form_LoginEvent(params object[] values)
        {
            try
            {
                Account account = dBContr.GetAccountByLogin(values[0] as string);
                if(account.Password == (values[1] as string))
                {
                    Logined?.Invoke(account);
                    form.Close();
                }
                else
                {
                    form.ShowErrorMessage("Неверный пароль или логин");
                }
            }
            catch (GettedAccountException ex)
            {
                form.ShowErrorMessage(ex.Message);
            }
        }

        private void Form_RegistrationEvent(params object[] values)
        {
            try
            {
                dBContr.GetAccountByLogin(values[0] as string);
                form.ShowErrorMessage("Пользователь с таким логином уже есть");
            }
            catch (GettedAccountException)
            {
                AccountFactory factory = new AccountFactory();
                Account account = factory.Create(values[0] as string, values[1] as string);
                dBContr.AddAccount(account);
                Registrated?.Invoke(account);
                form.Close();
            }
           
        }
    }
}
