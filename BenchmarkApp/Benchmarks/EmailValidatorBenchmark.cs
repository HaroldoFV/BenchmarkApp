using BenchmarkApp.Validators;
using BenchmarkDotNet.Attributes;

namespace BenchmarkApp.Benchmarks;

[MemoryDiagnoser]
public class EmailValidatorBenchmark
{
    private static readonly int _numberOfValidations = 100;

    [Benchmark(Baseline = true)]
    public void Regex()
    {
        var validator = new EmailValidatorRegex();

        for (int i = 0; i < _numberOfValidations; i++)
            validator.IsValid("teste@haroldo.com");
    }

    [Benchmark]
    public void RegexCompiled()
    {
        var validator = new EmailValidatorRegexCompiled();

        for (int i = 0; i < _numberOfValidations; i++)
            validator.IsValid("teste@haroldo.com");
    }

    [Benchmark]
    public void Simple()
    {
        var validator = new EmailValidatorSimple();

        for (int i = 0; i < _numberOfValidations; i++)
            validator.IsValid("teste@haroldo.com");
    }
}