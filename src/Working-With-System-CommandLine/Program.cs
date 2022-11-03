using System.CommandLine;

Option<FileInfo?> fileOption = new (
    name: "--file",
    description: "The file to read and display on the console.");

RootCommand rootCommand = new("Sample app for System.CommandLine");
rootCommand.AddOption(fileOption);

rootCommand.SetHandler((file) => 
    { 
        ReadFile(file!); 
    },
    fileOption);

await rootCommand.InvokeAsync(args);

static void ReadFile(FileInfo file)
{
    File.ReadLines(file.FullName).ToList()
        .ForEach(line => Console.WriteLine(line));
}