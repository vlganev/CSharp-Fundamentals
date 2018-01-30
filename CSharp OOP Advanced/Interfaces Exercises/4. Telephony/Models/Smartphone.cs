using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Smartphone : ICallable, IBrowsable
{
    public Smartphone()
    {
    }

    public string Call(string phoneNumber)
    {
        if (Regex.IsMatch(phoneNumber, "[a-zA-Z]+"))
        {
            throw new ArgumentException("Invalid number!");
        }
        return $"Calling... {phoneNumber}";
    }

    public string Browse(string webSite)
    {
        if (Regex.IsMatch(webSite, "\\d+"))
        {
            throw new ArgumentException("Invalid URL!");
        }
        return $"Browsing: {webSite}!";
    }
}
