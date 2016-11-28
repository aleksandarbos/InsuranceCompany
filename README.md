# InsuranceCompany
Students project at E-Business course, which has goal to implement insurance company information system (ICIS), and full payment sistem middle layer that mediates ICIS and banking e-services required to process e-payment.

## Team members:
  - [Violeta Novaković](https://github.com/Fireblume)
  - [Ivan Divljak](https://github.com/divljiboy)
  - [Ivana Živić](https://github.com/ivanazivi)
  - [Aleksandar Bošnjak](https://github.com/aleksandarbos)

## Project specification:

## Tools used:
### Backend:
  - .NET Core 1.0 Web API 2
  - Drools for .NET as Business Rules Management System (BRMS)
  
### Frontend:
  - JavaScript - Angular 1.5 (Material design)
  - HTML/CSS

### Database:
  - PowerDesigner for schema modeling
  - Microsoft SQL Server
  
## Deployment instructions:
  - 1. ```dotnet restore``` at InsuranceCompany folder to install dotnet core Web Api 2 dependencies
  - 2. ```dotnet run``` at InsuranceCompany folder to run the Web Api 2 server
  - [Note now backend Web API server is being ran]
  - 3. ```npm install``` at ```InsuranceCompany/wwwwroot``` folder to install dependencies for angular 
  - 4. ```grunt server``` run nodejs frontend server with angularjs app
  - [Note now frontend NodeJS server is being ran with AngularJS app deployed]

## Licence:
  - MIT
