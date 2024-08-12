# CMPG-323-Project-2_34933832
## Important message to the Lecturer
i have uploaded my pictures of my certificates/badges under dropbox on efundi together with the pictures of what i encounted when i was trying to submit on microsoft form proof of my certificates.
# Overview
The Telemetry Management API is a robust and scalable API designed to manage telemetry data, offering secure endpoints for data operations. The API is built with ASP.NET Core, integrated with JWT authentication for secure access, and is cloud-hosted on Azure.
## Table of Contents
  Features
  Getting Started
  API Documentation
  Endpoints
  Error Handling
  Security
  Deployment
  Contributing
  License
## Features
JWT Authentication for secure API access.
CRUD operations for telemetry data management.
Custom GET methods for specific calculations, such as savings based on telemetry data.
Swagger integration for interactive API documentation.
Cloud-hosted on Azure for scalability and reliability.
Getting Started
## Prerequisites
Make sure you have the following installed on your machine:

.NET SDK
Visual Studio or Visual Studio Code
SQL Server or any other compatible database.
## Endpoints
Authentication
## 1 POST /api/authenticate/login
Purpose: Authenticate users and return a JWT token.
Request Body:
json
Copy code
{ "username": "string", "password": "string" }
Response:
json
Copy code
{ "token": "string" }
Telemetry Data


## 2 GET /api/telemetry

Purpose: Retrieve all telemetry data.
Response: 200 OK with telemetry data list.


## 3 GET /api/telemetry/{id}

Purpose: Retrieve telemetry data by ID.
Response: 200 OK with telemetry data or 404 Not Found.


## 4 POST /api/telemetry

Purpose: Create a new telemetry record.
Request Body:
json
Copy code
{ "property1": "value", "property2": "value", ... }
Response: 201 Created with the created record.


## 5 PUT /api/telemetry/{id}

Purpose: Update a telemetry record by ID.
Request Body:
json
Copy code
{ "property1": "value", "property2": "value", ... }
Response: 204 No Content.


## 6 DELETE /api/telemetry/{id}

Purpose: Delete a telemetry record by ID.
Response: 204 No Content.
Custom Methods

## 7 GET /api/telemetry/savings

Purpose: Calculate and return savings based on telemetry data.
Response: 200 OK with savings data.
Error Handling
The API follows standard HTTP status codes:

200 OK: Request successful.
201 Created: Resource successfully created.
204 No Content: Update or deletion successful.
400 Bad Request: Invalid request parameters.
401 Unauthorized: Authentication failed.
404 Not Found: Resource not found.

All endpoints are protected with JWT authentication. 

# API URL 
https://localhost:7085/index.html

















# Referencing
Git Documentation:

Git SCM, 2024. Git - Documentation. [online] Available at: https://git-scm.com/doc [Accessed 11 August 2024].
Visual Studio Documentation:

Microsoft, 2024. Visual Studio Documentation. [online] Available at: https://learn.microsoft.com/en-us/visualstudio/?view=vs-2022 [Accessed 11 August 2024].
GitHub Documentation:

GitHub, 2024. GitHub Docs - Pushing to a remote. [online] Available at: https://docs.github.com/en/get-started/using-git/pushing-commits-to-a-remote-repository [Accessed 11 August 2024].

Microsoft Learn (2024a). Tutorial: Create a web API with ASP.NET Core. [online] Available at: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio [Accessed 11 August 2024].

Microsoft Learn (2024b). Build a web API with ASP.NET Core. [online] Available at: https://learn.microsoft.com/en-us/training/modules/build-web-api-aspnet-core/ [Accessed 11 August 2024].

Microsoft Learn (2024c). Tutorial: Get started with Swashbuckle and ASP.NET Core. [online] Available at: https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-3.1 [Accessed 11 August 2024].

Microsoft Learn (2024d). Create microservices with .NET. [online] Available at: https://learn.microsoft.com/en-us/training/paths/create-microservices-with-dotnet/ [Accessed 11 August 2024].

Pro Code Guide (2024). Entity Framework Core in ASP.NET Core. [online] Available at: https://procodeguide.com/programming/entity-framework-core-in-asp-net-core/ [Accessed 11 August 2024].

Microsoft Learn (2024e). Tutorial: Publish an ASP.NET Core web API to Azure API Management. [online] Available at: https://learn.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-api-management-using-vs?view=aspnetcore-6.0 [Accessed 11 August 2024].

JD Bots (2022). Join two entities in .NET Core using Lambda and Entity Framework Core. [online] Available at: https://jd-bots.com/2022/01/24/join-two-entities-in-net-core-using-lambda-and-entity-framework-core/ [Accessed 11 August 2024].

The J Panda (2020). Python automating ASP.NET Core web API creation that communicates with your database in 60 seconds or less. [online] Available at: https://thejpanda.com/2020/08/10/python-automating-asp-net-core-web-api-creation-that-communicates-with-your-database-in-60-seconds-or-less/ [Accessed 11 August 2024].

Microsoft Learn (2024f). CS1061: Compiler Error Message. [online] Available at: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1061?f1url=%3FappId%3Droslyn%26k%3Dk(CS1061) [Accessed 11 August 2024].

Microsoft Learn (2024g). CS0311: Compiler Error Message. [online] Available at: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0311?f1url=%3FappId%3Droslyn%26k%3Dk(CS0311) [Accessed 11 August 2024].

Git for Windows (2024). Git for Windows. [online] Available at: https://gitforwindows.org/ [Accessed 11 August 2024].

Microsoft Learn (2024h). Client vs. server evaluation. [online] Available at: https://learn.microsoft.com/en-us/ef/core/querying/client-eval [Accessed 11 August 2024].
