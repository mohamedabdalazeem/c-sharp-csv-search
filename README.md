# c-sharp-csv-search
This is a C# command-line utility for searching CSV files. It takes three arguments: the file path, the column number to search, and the search key. The utility searches the CSV file for the specified search key in the specified column and returns the matching line.

## Requirements
.NET Framework 4.5 or later
A CSV file to search
## Usage
To use the utility, open a command prompt and navigate to the directory where the executable is located. Then, enter the following command:
```
 csv-search.exe [file path] [column number] [search key]
```

For example:
```
csv-search.exe ./my-csv-file.csv 2 Alberto
```
This would search the my-csv-file.csv file for the search key "Alberto" in column 2 and return any matching line.

## Notes
The utility will only search for exact matches of the search key. It is case-sensitive.

If multiple lines in the CSV file match the search criteria, only the first matching line will be returned.

If no matching lines are found, the utility will display a message saying so.