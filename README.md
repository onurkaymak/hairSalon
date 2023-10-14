# Eau Claire's Salon

#### An ASP.NET Core MVC hair salon application to track stylists with matching clients.

#### By [Onur Kaymak](https://onurkaymak.com)

## Technologies Used

- C#
- .NET 6
- Razor
- EF Core
- MySQL
- MySQL Workbench
- VS Code

## Description

An independent C# / ASP .NET project assignment for [Epicodus](https://www.epicodus.com/), project is about "Database Basics / MySQL".

## Important - This project requires

- [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

- [MySQL](https://dev.mysql.com/downloads/mysql)

- [MySQL WorkBench](https://dev.mysql.com/downloads/workbench)

## Setup/Installation Requirements

- Clone this project from the provided GitHub repository: [Repository Link](https://github.com/onurkaymak/hairSalon).

- Navigate into the project's folder in your terminal.

- Navigate into HairSalon directory in your terminal.

- Create a file called `appsettings.json`.

- Add the following code below in `appsettings.json` file.

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=onur_kaymak;uid=[USERNAME];pwd=[PASSWORD];"
  }
}

```

- Replace the `USERNAME` and `PASSWORD` values with your own username and password for MySQL.

### Importing the Database

- Open MySQL Workbench and navigate to the `"Administration"` tab in the Navigator, select `"Data Import/Restore"`.

- Select `"Import from Self Contained File"`, navigate to the top directory of the downloaded repository.

- Select to the file called `"onur_kaymak.sql"` found in the root directory.

- Under Default Schema to be Imported To, select the New button.

- Enter a database name of your choice.

- Enter a database name of your choice.

- Click OK and navigate to the tab called `"Import Progress"`, click `"Start Import"` at the bottom right corner of the window.

### IMPORTANT

- Update in your `appsettings.json` file `database=onur_kaymak;` to `database=[YOUR SELECTED DATABASE NAME];`

### Important - Complete the "Importing the Database" instructions before execute this application successfully.

- Type `$ dotnet run` in the terminal command line to compile and execute this application while in HairSalon directory (Not the root directory HairSalon.Solution).

- IMPORTANT: `$ dotnet run` compiles the project folders for you without needing `$ dotnet build` command, however you can still use `$ dotnet build` if you need to compile the folders without executing the application.

- You will have a new browser tab open to view the application, you can also navigate `https://localhost:5000` manually to view it.

## Known Bugs

There is no known bugs.

## License

MIT License

Copyright (c) [2023] [Onur Kaymak]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
