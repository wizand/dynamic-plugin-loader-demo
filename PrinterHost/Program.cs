


using PrinterHost.Plugins;

Console.WriteLine("Running the PrinterHost.");

if (args  == null || args.Length == 0)
{
    Console.WriteLine("No plugin path provided. Please specify the path to the plugin directory with --pluginPath argument.");
    throw new ArgumentException("No plugin path given!");
}

string? pluginPath = null;
foreach (var arg in args)
{
    Console.WriteLine($"Argument: {arg}");
    if (arg.StartsWith("--pluginPath="))
    {
        pluginPath = arg.Substring("--pluginPath=".Length);
        Console.WriteLine($"Plugin path set to: {pluginPath}");
    }
}

if (pluginPath == null)
{
    Console.WriteLine("No plugin path provided. Please specify the path to the plugin directory with --pluginPath argument.");
    throw new ArgumentException("No plugin path given!");
}

string pluginDir = Path.Combine(Directory.GetCurrentDirectory(), pluginPath);
var pluginFiles = Directory.GetFiles(pluginDir, "*.dll");

if (pluginFiles.Length == 0)
{
    Console.WriteLine("No plugins found.");
    return;
}

PluginManager pluginManager = new PluginManager();

Console.WriteLine("Available plugins:");
for (int i = 0; i < pluginFiles.Length; i++)
{
    Console.WriteLine($"{i + 1}) {Path.GetFileName(pluginFiles[i])}");
    pluginManager.PreLoadPlugin(pluginFiles[i]);
}