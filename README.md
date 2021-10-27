# About the project
Desktop and mobile application which can be used to sell and buy items  
Desktop part of application is supposed to be used by workers in shop, while mobile app is for clients

## eProdaja back-end REST API (ASP.NET Core 3.1)

Technical implementation of  [eProdajaApi](/eProdaja) :
* SQL Server database
* Service layer
* Content-Based Filtering 
* Automapper
* Basic auth


## eProdaja Desktop Client (Windows Forms)
* Preview of all sales
* Add new item
* Make a factura (electronic invoice)
* Add user
* Preview details of sale

## eProdaja Mobile (Xamarin)
* Customer registration and profile edit
* Buy items
* Preview item

# Getting started

1. Clone/Download project
2. Open Visual Studio, right click the solution and go to "Properties". Select "Common Properties", "Startup Project". Select "Multiple startup projects", and set  eProdaja.Mobile.UWP and eProdaja.WinUI values to "Start"
3. While In solution "Properties", select "Configuration Properties". Check "Build" and "Deploy" checkboxes next to eProdaja.Mobile.UWP
4. Start Docker Desktop
5. Open console, then open "eProdaja" root folder in console
6. Run "docker-compose build"
7. Run "docker-compose up"
8. After a console message that the application has started appears, open http://localhost:5010/swagger/index.html in browser NOTE: docker-compose build may take a few minutes

