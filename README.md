# Hair Salon

#### By William Rodriguez

## Technologies Used

* HTML
* Bootstrap
* .NET Core
* ASP.NET
* Entity Framework Core
* MySQL

## Description

A web-app that keeps track of stylists and their clients for a hair salon.

## Setup/Installation Requirements

### Setup Repository
* Clone this repository to your desktop or any directory of your choice
  * Run the command below in a bash terminal with [git](https://github.com/git-guides/install-git) installed
```
git clone https://github.com/WillRod42/currency.git
```
* Or download as a zip file
  * Click the green code button on the repository page
  * At the bottom of the popup window select `Download ZIP`
  * Extract the downloaded .zip folder
* Make sure you have the [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet) installed and setup correctly for your OS
* Open the `HairSalon` folder of the downloaded repsoitory
* Run these commands in a terminal
  * ```
    dotnet restore
    dotnet build
    dotnet run
    ```
* This will open a live instance of the web-app at [http://localhost:5000](http://localhost:5000)

### Setup MySQL Server
* Download and install the version of [MySQL](https://dev.mysql.com/downloads/mysql/) for your OS
* Using your terminal, login to MySQL
  * ```
    mysql -u<username here> -p<password here>
    ```
* Create a new database and tables with these commands
  * ```
    CREATE DATABASE <database name here>;

    USE <database name here>;

    CREATE TABLE `stylists` (
    `StylistId` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(255) NOT NULL,
    `Specialty` varchar(255) DEFAULT NULL,
    PRIMARY KEY (`StylistId`)
    ) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

    CREATE TABLE `clients` (
    `ClientId` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(255) NOT NULL,
    `StylistId` int NOT NULL,
    PRIMARY KEY (`ClientId`),
    KEY `StylistId_idx` (`StylistId`),
    CONSTRAINT `StylistId` FOREIGN KEY (`StylistId`) REFERENCES `stylists` (`StylistId`)
    ) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

    ```
* Inside the `HairSalon` folder, create a file named `appsettings.json`
  * Inside add these lines and save the file
  * ```
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=<database name here>;uid=<username here>;pwd=<password here>;"
      }
    }
    ```

## Known Bugs

* None

## License

MIT

Copyright (c) 2022 William Rodriguez