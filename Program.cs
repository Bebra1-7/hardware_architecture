// Console.WriteLine($"Компьютер: {Environment.MachineName}");
// Console.WriteLine($"User: {Environment.UserName}");
// Console.WriteLine($"Date and time: {DateTime.Now:dd.MM.yyyy HH:mm}");

// Console.WriteLine($"OS: {Environment.OSVersion}");
// Console.WriteLine($"64-bit OS: {Environment.Is64BitOperatingSystem}");

// Console.WriteLine($"Logic Procces: {Environment.ProcessorCount}");

// Console.WriteLine($"PID CPU: {Environment.ProcessId}");
// long memory = Environment.WorkingSet / 1024 / 1024;
// Console.WriteLine($"ОЗУ: {memory} MB");
// Console.ReadLine();


using System.Diagnostics;

Console.WriteLine($"Компьютер: {Environment.MachineName}");
Console.WriteLine($"User: {Environment.UserName}");
Console.WriteLine($"Date and time: {DateTime.Now:dd.MM.yyyy HH:mm}");

Console.WriteLine($"OS: {Environment.OSVersion}");
Console.WriteLine($"64-bit OS: {Environment.Is64BitOperatingSystem}");

Console.WriteLine($"Logic Procces: {Environment.ProcessorCount}");

Process currentProcess = Process.GetCurrentProcess();
Console.WriteLine($"PID CPU: {currentProcess.Id}\n");

Console.WriteLine($"ОЗУ process:");

for (int i = 1; i <= 3; i++)
{
    currentProcess.Refresh();
    long memory = currentProcess.WorkingSet64 / 1024 / 1024;
    Console.WriteLine($"{i} измерения: {memory} MB");
    if (i < 3)
    {
        Console.WriteLine($"Обновите окно через несколько секунд...");
        Console.ReadLine();
    }
}
Console.WriteLine("Исследование завершено.");