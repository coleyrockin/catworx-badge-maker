# CatWorx Badge Maker

A small C# console app that collects employee details and exports badge data to `data/employees.csv`.

## Features

- Prompts for employee first name, last name, ID, and photo URL
- Prints entered employees in a readable console table
- Writes a CSV file with badge-ready employee data
- Creates the `data/` folder automatically when needed

## Requirements

- .NET SDK 6.0 or newer

## Run locally

```bash
dotnet run
```

Enter employees when prompted. Leave first name blank to finish and generate the CSV.

## Output

The app writes:

```text
data/employees.csv
```

CSV columns:

```csv
ID,Name,PhotoUrl
```

## Project notes

This project started as a C# badge-maker exercise. The repo has been cleaned so generated build artifacts (`bin/`, `obj/`) are ignored and the source files are the main tracked project assets.
