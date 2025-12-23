string content = File.ReadAllText(@"C:\Datasprints\InPutDataFileTask4V0.txt");
int count = content.Count(c => c == 'h');
Console.WriteLine(count);