
# Insurance Calculator

Insurnace Calculator web application project is created using Blazor app in .Net Core 5.0. This project is mainly focused on the Web UI having two screens to get details of member and insurance to calculate total insurnace value.


## Assumptions and considerations

- The screens are user interactive to calculate insurance value therefore no database involved to collect static values like occupations, ratings and states, they are harded coded in the solution. 
- The calculations are not stored anywhere.
- No file logging is done.
- Fluent Validation library is used to perform validations on screens.
- The information is only retained within the process of calculation.  Once new calculation is started then the previous calculation details will be vanished.
- Bootstrap is used for styling.
- Protected Session Storage is used to store session data
## Run Locally

Clone the project

```powershell
  git clone https://github.com/alihaider007/InsuranceWebApp.git
```

Go to the project directory

```Open command prompt or powershell
  cd InsuranceWebApp\InsuranceWebApp
```

```powershell
  dotnet build
```

```powershell
  dotnet watch run
```

```powershell
  press Ctrl+C to stop
```
