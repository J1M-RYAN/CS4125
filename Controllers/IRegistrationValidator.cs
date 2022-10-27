using System.Net.Mail;

namespace CS4125.Controllers;

public interface IRegistrationValidator
{
    public string EncryptPassword(string pw)
    {
        return pw;
    }

    public string DecryptPassword(string pw)
    {
        return pw;
    }

    public bool IsValidEmail(string e)
    {
        try
        {
            var m = new MailAddress(e);

            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    public bool IsValidPassword(string e)
    {
        return e.Length >= 6;
    }
}