namespace Performance;
 
[MemoryDiagnoser]
public class RegexPerf
{
    private const string _data = "TestePerformance123TestePeformance";
    private readonly Regex _regexInterpretado = new(@"[0-9]");
    private readonly Regex _regexCompilado = new (@"[0-9]", RegexOptions.Compiled);

    [Benchmark]
    public bool RegexInterpretado()
        => _regexInterpretado.IsMatch(_data);

    [Benchmark]
    public bool RegexCompilado() 
        => _regexCompilado.IsMatch(_data);

    [Benchmark]
    public bool RegexInterpretadoTransient()
       => new Regex(@"[0-9]").IsMatch(_data);

    [Benchmark]
    public bool RegexCompiladoTransient()
       => new Regex(@"[0-9]", RegexOptions.Compiled).IsMatch(_data);

    [Benchmark]
    public bool MetodoCustomizado()
    {
        var span = _data.AsSpan();

        for (int i = 0; i < span.Length; i++)
        {
            if(span[i]>='0' && span[i]<='9')
            {
                return true;
            }
        }

        return false;
    }
} 