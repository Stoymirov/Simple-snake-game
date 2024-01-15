using Telephony;

public class StationaryPhone : ICaller
{
    public string Call(string number)
    {
        if (!ValidatePhoneNumber(number))
        {
            throw new ArgumentException("Invalid number!");
        }
        return ($"Dialing... {number}");
    }

    private bool ValidatePhoneNumber(string number) => number.All(char.IsDigit);
  
}