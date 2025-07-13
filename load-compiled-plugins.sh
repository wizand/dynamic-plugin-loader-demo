echo Loading compiled modules.
dotnet clean PluginBuilder.sln
dotnet build PluginBuilder.sln
dotnet clean BuildPrinterHost.sln
dotnet build BuildPrinterHost.sln
rm -rf ./Plugins
mkdir ./Plugins
cp ./RudeGreeterPlugin/bin/Debug/net9.0/RudeGreeterPlugin.dll   ./Plugins
cp ./HelloWorldPlugin/bin/Debug/net9.0/HelloWorldPlugin.dll     ./Plugins
echo done.