Console.WriteLine($"Компьютер: {Environment.MachineName}");
Console.WriteLine($"User: {Environment.UserName}");
Console.WriteLine($"Date and time: {DateTime.Now:dd.MM.yyyy HH:mm}");

Console.WriteLine($"OS: {Environment.OSVersion}");
Console.WriteLine($"64-bit OS: {Environment.Is64BitOperatingSystem}");

Console.WriteLine($"Logic Procces: {Environment.ProcessorCount}");

Console.WriteLine($"PID CPU: {Environment.ProcessId}");
long memory = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"ОЗУ: {memory} MB");
Console.ReadLine();