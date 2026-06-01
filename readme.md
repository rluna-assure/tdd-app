### TDD APP
This repository demonstrate TDD principles applied from scratch to cover all test cases.
It features two functions to convert natural numbers to Roman numerals and vice versa.
It includes validations for edge cases, such as empty strings and negative numbers.

---

#### Getting Started
Clone the app to your local files and restore the app following steps.

##### Re-requisites
.net sdk(compatible with global.json)

1- run the command
``` bash
dotnet tool restore
dotnet build
dotnet test
```
Once the appciocations builds and tests pass, follow the next steps to generate the coverage report.

---

#### Generate covertura
1- run this command to generate covertura.xml file.
``` bash
dotnet test --collect:"XPlat Code Coverage"
```
2- generate the HTML report from xml file.
``` bash
dotnet reportgenerator -reports:"**/*/**/*.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```
Once generated, you can view the results by opening the index.html file inside the coveragereport folder.

---

#### Coverage
Actually the project has the next coverage

100% lines Coverage
95% branch Coverage


#### Usage Example
``` csharp
// Example usage of the core domain service
var converter = new RomanNumeralConverter();

// Natural to Roman
string roman = converter.ToRoman(2026); // Returns "MMXXVI"

// Roman to Natural
int natural = converter.ToRoman("XIV"); // Returns 14
```
