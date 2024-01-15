using Telephony;

public class SmartPhone:IBrowser,ICaller
{
    public string Browse(string link)
    {
        if (ValidateBrowser(link))
        {
            throw new ArgumentException("Invalid URL!");
        }

        return $"Browsing: {link}!";
    }


    public string Call(string number)
    {
        if (!ValidatePhoneNumber(number))
        {
            throw new ArgumentException("Invalid number!");
        }
        return ($"Calling... {number}");
    }

    private bool ValidatePhoneNumber(string number) => number.All(char.IsDigit);
    private bool ValidateBrowser(string link) => link.Any(char.IsDigit);

}