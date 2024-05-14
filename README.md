# Arquitetura Tres Camadas MVC

## VS Code

### Install entity framework package 
```
dotnet tool install --global dotnet-ef --version 7.0.18
```

### Run Migrations
1. Open the terminal pointing to the Data project
2. The Connection string must contain TrustServerCertificate=true
```
"DefaultConnection": "Server=localhost;Database=ApiTresCamadas;User ID=sa;Password=1q2w3e4r@#$;MultipleActiveResultSets=true;TrustServerCertificate=true"
```
4. Execute
```
dotnet ef migrations add InitialCreate --startup-project ../DevIO.Api
```
5. Execute
```
dotnet ef database update --startup-project ../DevIO.Api
```

### New MVC Project
1. Create new MVC App project
```
cd src
dotnet new mvc -n DevIO.App
```
2. Link new project to solution
```
cd src
dotnet sln ../ApiTresCamadas.sln add DevIO.App/DevIO.App.csproj
```

### Execute MVC Project
```
dotnet build
dotnet run
control + C
```