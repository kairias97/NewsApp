# News App

Hi! This project consists in a client side app built using Angular.JS version 1.6.9 and connected to a backend API built with C# and ASP.NET Core, EF Code First and SQLite.


# Prerequisites
Before running the client application and the api, you need to have the following installed:

 - Node.JS
 - ASP.NetCore SDK 2.1
 - No previous DB engine installation is necessary since SQLite is being used.
 - Git
 - Visual Studio 2017

 Also is necessary to clone this repository with `git clone https://github.com/kairias97/NewsApp.git` and then `cd NewsApp` using the cmd, since this will be the starting point for both api and client side app setup.

## Setting and running up the .NET Core API
Run the following in cmd:
 1. `cd NewsApp`
 2. `dotnet ef database update`
 3. `cd ..`
 4. Open `NewsApp.sln` in visual studio
 5. Check that the **NewsApp** project is setup as startup project with right click into the project name, and if not then select **Setup as StartUp Project**
 6. Press F5 to run the API project.
 7. Test that the API is running correctly under **http://localhost:47441** and test with url **http://localhost:47441/api/news/featured**
 
 ## Setting and running up the client side Angular.JS app
Run the following in cmd:
 1. `cd NewsApp.Client`
 2. `npm install`
 3. `npm start`
 4. The app will be running under **http://localhost:1337/** so you can test it out in the browser.
