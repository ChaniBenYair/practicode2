using System.CommandLine;

var bundleCommand = new Command("bundle", "nnn");
bundleCommand.SetHandler(() =>
{
    Console.WriteLine("bundle command");
});

var rootCommand = new RootCommand("root command");
rootCommand.AddCommand(bundleCommand);
rootCommand.InvokeAsync(args);