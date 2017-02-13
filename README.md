# InsuranceCompany
![logo](https://cloud.githubusercontent.com/assets/15141614/22893965/968c267e-f217-11e6-8aab-693e3a843dd6.png)

Students' project at E-Business course at Faculty of Technical Sciences in Novi Sad, which has goal to implement insurance company information system (ICIS), and full payment sistem middle layer that mediates ICIS and banking e-services required to process e-payment.

## Team members:
  - [Violeta Novaković](https://github.com/Fireblume)
  - [Ivan Divljak](https://github.com/divljiboy)
  - [Ivana Živić](https://github.com/ivanazivi)
  - [Aleksandar Bošnjak](https://github.com/aleksandarbos)

## Project specification:
## Project analysis
Project analysis has been done at our [Wiki page](https://github.com/aleksandarbos/InsuranceCompany/wiki). Analysis that has been conducted consists of the following modules:
  - [System architecture diagram](https://github.com/aleksandarbos/InsuranceCompany/wiki/System architecture)
  - [Use Case Diagram](https://github.com/aleksandarbos/InsuranceCompany/wiki/Use Case diagram)
  - [Data flow diagram](https://github.com/aleksandarbos/InsuranceCompany/wiki/Data flow diagram)
  - [OWASP Top 10 Analysis](https://github.com/aleksandarbos/InsuranceCompany/wiki/OWASP Top 10 Analysis)
  

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
