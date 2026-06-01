### TDD APP
---
#### Run app
This app applies the TDD principles from strach to complete all tests test cases.
1- run the command
``` bash
dotnet tool restore
```
---
#### Generate covertura
1- run this line to generate covertura.xml
``` bash
dotnet test --collect:"XPlat Code Coverage"
```
2- generate covertura report from covertura.xml
``` bash
dotnet reportgenerator -reports:"**/*/**/*.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```
once generated the coverate report is possible verify the file index.html in coveragereport folder
---
