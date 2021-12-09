namespace Performance;

[MemoryDiagnoser]
public class JsonSourceGeneratorPerf
{
    public static readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    [Benchmark]
    public void SerializeDeserializerNormal()
    {
        PaymentEvent payment = new();

        var json = JsonSerializer.Serialize(payment, _options);
        var paymentEvent = JsonSerializer.Deserialize<PaymentEvent>(json, _options);
    }

    [Benchmark]
    public void SerializeDeserializerOtimizado()
    {
        PaymentEvent payment = new();

        var json = JsonSerializer.Serialize(payment, PaymentEventJsonContext.Default.PaymentEvent);
        var paymentEvent = JsonSerializer.Deserialize<PaymentEvent>(json, PaymentEventJsonContext.Default.PaymentEvent);
    }


}

[JsonSerializable(typeof(PaymentEvent))]
[JsonSourceGenerationOptions(
    GenerationMode = JsonSourceGenerationMode.Default,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
public partial class PaymentEventJsonContext : JsonSerializerContext
{

}

public class PaymentEvent
{
    public Guid TransactionId { get; set; } = Guid.NewGuid();
    public DateTime PaymentIn { get; set; } = DateTime.Now;
    public int Value { get; set; } = 23;
    public string PaymentType { get; set; } = "CARD";
}