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

	-	[ ] BusinessLogic Class Library Project erstellt
	-	[ ] Vehicle Demo Klassen
	-	[ ] Interface als Contract extrahiert

## Modul 004 Routing

	-	[ ] Movie Database Api
	-	[ ] Controller mit CRUD Operationen
	-	[ ] Model constraints
	-	[ ] LAB: Movie DB erstellen

## Modul 005 EF Core

	-	[ ] Code First: VehicleFleet Datenbank
	-	[ ] Datenklasse mit Attriuten versetzt
	-	[ ] DbContext erzeugt
	-	[ ] Connection string erstellt
	-	[ ] Abhängigkeiten via DI registriert
	-	[ ] LAB: DB für Movie DB erstellen

```
dotnet tool install --global dotnet-ef
dotnet ef migrations add myInitialScript --project myProject
dotnet ef database update --project myProject
```

	-	[x] Db First: Northwind Datenbank
	-   [x] [Northwind DB](https://github.com/microsoft/sql-server-samples/blob/master/samples/databases/northwind-pubs/instnwnd.sql)
	-	[x] VS Extension [EF Core Power Tools](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools)
	-	[x] Controller erzeugen
	-	[ ] LAB: Daten von Northwind abfragen
			* Alle Bestellungen
			* Alle Bestellungen innerhalb eines Zeitraumes (Parameter: StartDate, EndDate)
			* Bestellungen pro Kunde (Parameter: CustomerID)
			* Kunden pro Land (Parameter: Country)

## Modul 006 Media Types

	-	[ ] ActionResults als XML zurück geben 

## Modul 007 HttpClient

	-	[ ] Console App welche Anfragen auf die Northwind API macht
	-	[ ] Response als JSON deserialisieren

## Modul 008 Authentication

	-	[ ] Middleware für Authentication konfigurieren
	-	[ ] IdentityDbContext verwenden
	-	[ ] JwtToken erstellen
	-	[ ] Authentication mit Microsoft Identity Platform via Azure AD