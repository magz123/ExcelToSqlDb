# ExcelToSqlDb
This project is created using **C#** via **Visual Studio 2023**
- Imports data from excel file to ms sql database

# Pre-requisites
- [Visual Studio](https://visualstudio.microsoft.com/vs/community/) 2019 up to latest (any edition)
> **NOTE:** .NET Desktop Development Workload should be installed
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)
> This is usually included in 2019 and latest version of visual studio
- [ExcelDataReader](https://www.nuget.org/packages/ExcelDataReader)
- [ExcelDataReader.DataSet](https://www.nuget.org/packages/ExcelDataReader.DataSet)

# Directions
- Open solution **ExcelToSql.sln** file
- Restore nuget packages first or
- Re/Build Solution
- Run `(F5)`
- Enter parameters on the textboxes
> **NOTE:** Currently **All Fields** are **required**

| Inputs | Description |
| ------ | ------ |
| Server | The name of the database server ex. `MyPC\MSSQL` |
| User | The Username to be used in connecting to the database server |
| Password | The Password to be used in connecting to the database server |
| Database | The Database name to be used in connecting to the database server ex. `master` |
| File Location | The folder location of the file to be imported ex. `C:\tmp\` |
| FileName | The file name ex. `file`.xlsx |
| Extension | The extension name of the file ex. file.`xlsx`  |
| Schema | The schema of the table ex. `dbo` - in **dbo.Person** |
| TableName | The table name ex. `Person` - in **dbo.Person** |

| CheckBoxes | Description |
| ------ | ------ |
| Is file name the same as table name? | If **checked**, this will automatically populate the input `TableName` based on `FileName` |
| Truncate table before import? | If **checked**, this will automatically truncate the table before the import process |
> **NOTE:** 
> There are no validations yet if table is applicable for `TRUNCATE TABLE` function.
> Tables with **foreign keys** are mostly prone with the issue of unable to truncate table

## Supported excel file formats and versions

| File Type | Container Format | File Format | Excel Version(s) |
| --------- | ---------------- | ----------- | ---------------- |
| .xlsx     | ZIP, CFB+ZIP     | OpenXml     | 2007 and newer |
| .xlsb     | ZIP, CFB         | OpenXml     | 2007 and newer |
| .xls      | CFB              | BIFF8       | 97, 2000, XP, 2003<br>98, 2001, v.X, 2004 (Mac) |
| .xls      | CFB              | BIFF5       | 5.0, 95 |
| .xls      | -                | BIFF4       | 4.0 |
| .xls      | -                | BIFF3       | 3.0 |
| .xls      | -                | BIFF2       | 2.0, 2.2 |

# Credits To
- [ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader) for the amazing `ExcelDataReader` and `ExcelDataReader.DataSet` libraries
