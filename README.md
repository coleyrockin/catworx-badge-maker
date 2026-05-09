# CatWorx Badge Maker

A small C# console app that collects employee details and exports badge data to `data/employees.csv`.

## Why it exists

This is a cleaned-up C# badge-maker exercise focused on basic console input, validation, object modeling, and CSV export.

## Features

- Prompts for employee first name, last name, ID, and photo URL
- Validates required fields and positive numeric IDs
- Prints entered employees in a readable console table
- Writes CSV-safe badge data to `data/employees.csv`
- Creates the `data/` folder automatically when needed

## Requirements

- .NET SDK 6.0 or newer

## Run locally

Interactive mode:

```bash
dotnet run
```

Sample/demo mode:

```bash
dotnet run -- --sample
```

Enter employees when prompted. Leave first name blank to finish and generate the CSV.

## Example session

```text
Enter first name (leave empty to finish): Ada
Enter last name: Lovelace
Enter ID: 101
Enter photo URL: photo-url
Enter first name (leave empty to finish):
ID          Name                  Photo URL
------------------------------------------------------------
101         Ada Lovelace          photo-url
Badge data written to data/employees.csv
```

## Output

```text
data/employees.csv
```

CSV columns:

```csv
ID,Name,PhotoUrl
```

## Verify

```bash
dotnet build
dotnet run -- --sample
```

The GitHub Actions workflow runs restore, release build, sample export, and CSV existence checks on every push/PR.

## Project notes

Generated build artifacts (`bin/`, `obj/`) are ignored so the repo stays source-focused.
