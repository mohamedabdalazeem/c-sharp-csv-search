using System;
using System.IO;

class Program {
    static void Main(string[] args) {
        if (args.Length != 3) {
            Console.WriteLine("Usage: test.exe [file path] [column number] [search key]");
            return;
        }

        string csvFilePath = args[0];
        int columnNumber;
        string searchKey = args[2];

        if (!int.TryParse(args[1], out columnNumber)) {
            Console.WriteLine("Invalid column number specified.");
            return;
        }

        if (!File.Exists(csvFilePath)) {
            Console.WriteLine("The specified file does not exist.");
            return;
        }

        try {
            using (StreamReader reader = new StreamReader(csvFilePath)) {
                string line;
                bool found = false;
                while ((line = reader.ReadLine()) != null) {
                    string[] fields = line.Split(',');
                    if (fields.Length > columnNumber && fields[columnNumber] == searchKey) {
                        Console.WriteLine(line);
                        found = true;
                        break;
                    }
                }

                if (!found) {
                    Console.WriteLine("No matching result found.");
                }
            }
        } catch (Exception e) {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
