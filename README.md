# ASP.NETCoreWebAPI-RESTfulWebservicesmitCSharp-242046
KursRepository zu Kurs ASP.NET Core Web API - RESTful Webservices mit C# der ppedv AG

## Modul 001 Einführung WebAPI

	-	[x] WheaterForecastAPI erstellt
	-	[x] Projektstruktur erklärt
	-	[x] [httpFiles](https://learn.microsoft.com/en-us/aspnet/core/test/http-files)

## Modul 002 Konfiguration

	-	[x] IOC mittels Dependency Injection
	-	[x] Logging in ASP.Net Core

## Modul 003 Controllers

	-	[x] BusinessLogic Class Library Project erstellt
	-	[x] Vehicle Demo Klassen
	-	[x] Interface als Contract extrahiert

## Modul 004 Routing, MediaTypes, Async/Await

	-	[x] Controller mit CRUD Operationen

	-	[x] Route constraints
	-	[x] [Model Binding](https://learn.microsoft.com/en-us/aspnet/web-api/overview/formats-and-model-binding/)

	-	[x] Content Negotiation
	-	[x] MediaTypes & [Formatters](https://learn.microsoft.com/en-us/aspnet/web-api/overview/formats-and-model-binding/media-formatters)
	-	[x] ActionResults als XML zurück geben 
	-	[x] ActionResults als CSV zurück geben 

	-	[x] Async/Await Pattern
	-	[x] LAB: Movie Store Api

## Modul 005 EF Core

	-	[x] Code First: VehicleFleet Datenbank
	-	[x] Datenklasse mit Attriuten versetzt
	-	[x] DbContext erzeugt
	-	[x] Connection string erstellt
	-	[x] Abhängigkeiten via DI registriert
	-	[x] Best Practices: DTOs, Mapper
	-	[x] Validierung in DTOs
	-	[x] LAB: DB für Movie Store erstellen

```
dotnet tool install --global dotnet-ef
dotnet ef migrations add myInitialScript --project myProject
dotnet ef database update --project myProject
```

	-	[x] Db First: Northwind Datenbank
	-   [x] [Northwind DB](https://github.com/microsoft/sql-server-samples/blob/master/samples/databases/northwind-pubs/instnwnd.sql)
	-	[x] VS Extension [EF Core Power Tools](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools)
	-	[x] Controller erzeugen
	-	[x] LAB: Daten von Northwind abfragen
			* Alle Bestellungen
			* Alle Bestellungen innerhalb eines Zeitraumes (Parameter: StartDate, EndDate)
			* Bestellungen pro Kunde (Parameter: CustomerID)
			* Kunden pro Land (Parameter: Country)

## Modul 006 Testing

	-	[x] [Überblick Strategien](https://learn.microsoft.com/de-de/ef/core/testing/)
	-	[x] [Unit Testing Controllers](https://learn.microsoft.com/en-us/aspnet/web-api/overview/testing-and-debugging/unit-testing-controllers-in-web-api)
	-	[x] Moq benutzen um Controller Dependencies zu mocken
	-	[x] LocalDB benutzen

## Modul 007 HttpClient

	-	[ ] Console App welche Anfragen auf die Northwind API macht
	-	[ ] Response als JSON deserialisieren

## Modul 008 Authentication

	-	[x] Middleware für Authentication konfigurieren
	-	[x] IdentityDbContext verwenden
	-	[x] JwtToken erstellen

	-	[x] Authentication mit Microsoft Identity Platform via Entra (ehem. Azure AD)
	-	[x] [Client Secrets](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets)
	-	[x] [Graph Explorer](https://developer.microsoft.com/en-us/graph/graph-explorer)

	
## Modul 009 OData

	-	[x] OData Abfragen auf Northwind
