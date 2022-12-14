namespace SalesOrderAPI.Configurations.Interfaces;
public class CorrelationIdGenerator : ICorrelationIdGenerator
{
    private string _correlationId = Guid.NewGuid().ToString();
    
    public string Get() => _correlationId;

    public void Set(string CorrelationId) => _correlationId = CorrelationId;
}
