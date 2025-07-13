# dynamic-plugin-loader-demo
How to load .dlls in a dotnet project like OSGi in Java. Using Assembly Load Context

# Overview

This is a demo project to test how to dynamically load .dlls into a project. 

## PrinterContract

A common project to house the interface acting as the contract between the host application and the plugin dlls.

## Plugins
### HelloWorldPlugin

A class lib that implements the PrinterContract with it's custom printout

### RudeGreeterPlugin

A class lib that implements the PrinterContract with it's custom printout

## PrinterHost

Printer host is the main application where the PrinterContract inteface implementing dlls are to be loaded into.

## How to run

### Optional
First run the load-compiled-plugins.sh. It builds the plugins ( that are hardcoded for now ) and copies the PrinterContract implemnting .dlls to a directory ./Plugins. One can also manually copy the .dlls to a directory and pass the path via --pluginPath= parameter when running the host.

### Running the host
dotnet run --project PrinterHost\PrinterHost.csproj --pluginPath=./Plugins will run the application that demos how to load the dlls and run the interfacing functions in the plugins.

