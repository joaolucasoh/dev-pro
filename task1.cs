using System;
using System.IO;

public static class Logger
{
    public static void LogMessage(string filename, string message, string level)
    {
        string timestamp = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]");
        string logEntry = $"{timestamp} [{level}] {message}\n";

        using (StreamWriter writer = File.AppendText(filename))
        {
            writer.Write(logEntry);
        }
    }
}

// Test scenarios for Logger
public static class LoggerTests
{
    public static void TestLogger()
    {
        string logFilename = "test.log";

        // Test 1: Log an INFO message
        Logger.LogMessage(logFilename, "User logged in", "INFO");

        // Test 2: Log a WARNING message
        Logger.LogMessage(logFilename, "Failed login attempt", "WARNING");

        // Read and verify the contents of the log file
        string logContents = File.ReadAllText(logFilename);

        string expectedOutput =
            "[2023-04-24 12:34:56] [INFO] User logged in\n" +
            "[2023-04-24 12:35:10] [WARNING] Failed login attempt\n";

        if (logContents == expectedOutput)
        {
            Console.WriteLine("All tests passed!");
        }
        else
        {
            Console.WriteLine("Test failed. Log contents:");
            Console.WriteLine(logContents);
        }
    }
}

// Run the Logger tests
LoggerTests.TestLogger();
