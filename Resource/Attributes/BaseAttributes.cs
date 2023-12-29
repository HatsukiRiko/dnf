using Resource.Attributes.枚举;

namespace Resource.Attributes;

public class BaseAttributes : IBaseAttributes
{
    public string Name { get; set; }

    public string Describe { get; set; }
    
    public int AttackValue { get; set; }

    public int BuffValue { get; set; }
    
    public Parts Parts { get; set; }
    
    public Data data { get; set; }
    
}