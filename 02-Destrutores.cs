namespace Performance;
 
[MemoryDiagnoser]
public class Destrutor
{ 
    [Benchmark]
    public void SemDestrutor()
        => new ClasseSemDestrutor();

    [Benchmark]
    public void ComDestrutor()
        => new ClasseComDestrutor();
} 

public class ClasseSemDestrutor : IDisposable
{
    public Guid Id { get; set; }
    public string Nome { get; set; }

    public void Dispose()
    {
       // throw new NotImplementedException();
    }
}

public class ClasseComDestrutor
{
    public Guid Id { get; set; }
    public string Nome { get; set; }

    ~ClasseComDestrutor()
    {
    }
}