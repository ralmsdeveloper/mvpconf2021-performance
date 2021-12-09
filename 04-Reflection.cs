using System.Reflection;

namespace Performance;
 
[MemoryDiagnoser]
public class ReflectionPerf
{
    [Benchmark]
    public string AcessoPublico()
    {
       var pessoa = new Pessoa();

       return pessoa.Nome;
    }

    [Benchmark]
    public string ReflectionNormal()
    {
        var pessoa = new Pessoa();
        
        var info = pessoa
            .GetType()
            .GetProperty("Endereco", BindingFlags.Instance | BindingFlags.NonPublic);

        return info.GetValue(pessoa).ToString();
    }

    private static readonly PropertyInfo _info = typeof(Pessoa)
         .GetProperty("Endereco", BindingFlags.Instance | BindingFlags.NonPublic);

    private static readonly Func<Pessoa, string> _delegate =
        (Func<Pessoa, string>)Delegate.CreateDelegate(typeof(Func<Pessoa, string>), _info.GetGetMethod(true));

    [Benchmark]
    public string ReflectionOtimizado()
    {
        var pessoa = new Pessoa();
         
        return _info.GetValue(pessoa).ToString();
    }

    [Benchmark]
    public string ReflectionOtimizadoDelegate()
    {
        var pessoa = new Pessoa();

        return _delegate(pessoa);
    }
} 

public class Pessoa
{
    public string Nome { get; set; } = "Rafael";
    private string Endereco { get; set; } = "Rua Teste";
}