using System.Text.RegularExpressions;
using BenchmarkApp.interfaces;

namespace BenchmarkApp.Validators;

public class EmailValidatorRegexCompiled : IEmailValidator
{
    static readonly string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    static readonly Regex EmailRegex = new Regex(emailPattern, RegexOptions.Compiled);

    public bool IsValid(string email) => EmailRegex.Match(email).Success;
}