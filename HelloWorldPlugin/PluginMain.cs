using PrinterContracts;

namespace HelloWorldPlugin;

public class PluginMain : IGreeterContract
{
    public string PrintGreeting(string name)
    {
        return $"Hello, {name} from HelloWorldPlugin!";
    }
}
