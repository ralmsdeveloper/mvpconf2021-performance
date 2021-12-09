using System.Buffers;

namespace Performance;
 
[MemoryDiagnoser]
public class ArrayPoolPerf
{
    [Benchmark]
    public void ArrayNomal()
    {
       var array = new char[1024 * 1024];
       using var stream = new StreamReader("arquivo.txt");
       stream.Read(array, 0, array.Length);
    }

    [Benchmark]
    public void ArrayUsandoPool()
    {
        var pool = ArrayPool<char>.Shared;
        var array = pool.Rent(1024 * 1024);
        using var stream = new StreamReader("arquivo.txt");
        stream.Read(array,0, array.Length);
        pool.Return(array);
    }
} 
