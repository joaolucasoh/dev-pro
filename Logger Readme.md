# Logger

The Logger module provides a function to log messages to a text file with a timestamp. Each log entry includes a timestamp, message, and log level.

## Usage

To log a message, use the `LogMessage` method from the `Logger` class:

```csharp
Logger.LogMessage(filename, message, level);

- filename (string): The name of the log file.
- message (string): The message to be logged.
- level (string): The log level (e.g., "INFO", "WARNING", "ERROR").

#### Running Tests
To run the tests for the project:

Open a terminal or command prompt.

Navigate to the project's root directory.

Run the following command to execute the tests:

shell
Copy code
dotnet test