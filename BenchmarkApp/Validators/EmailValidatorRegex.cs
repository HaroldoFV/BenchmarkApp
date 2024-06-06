using System.Text.RegularExpressions;
using BenchmarkApp.interfaces;

namespace BenchmarkApp.Validators;

public class EmailValidatorRegex : IEmailValidator
{
    public bool IsValid(string email)
    {
        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        Regex emailRegex = new Regex(emailPattern);
        return emailRegex.Match(email).Success;
    }
}