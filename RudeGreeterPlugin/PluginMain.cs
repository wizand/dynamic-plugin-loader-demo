using PrinterContracts;

namespace RudeGreeterPlugin;

public class PluginMain : IGreeterContract
{
    public string PrintGreeting(string name)
    {
        return $"Piss off, {name}!\n\tBest wishes, Rude Greeter Plugin";
    }
}
