# _Eau Claire's Salon_

#### _Web application to demonstrate basic knowledge of MVC and Databases_

#### By _**Ash Porter (KirbyPaint)**_

## Description

_The purpose of this web application is to demonstrate knowledge of how MVC concepts tie in to databases, and creating a program that creates and uses this data effectively._  

## Setup/Installation Requirements

### Cloning with Git:
* Open Git Bash, or your preferred terminal
* Navigate to your directory for Git projects (not within an existing project)
* Type the following: `git clone https://github.com/KirbyPaint/HairSalon.Solution.git`

This program was built with and requires .NET version 5.0.102. You may install the 64-bit version for Windows [using this link](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer)  

Once the installation of .NET 5 is complete, you may check that the proper version was installed by opening up Git Bash and typing:  

`dotnet --version`  

Then, open your Git Bash terminal and navigate to:

`cd <filepath the files are installed at>\HairSalon.Solution\HairSalon`

where "filepath the files are installed at" will be the location you saved your copy of the project at, or alternatively:  

You may navigate to the folder in the project labeled "HairSalon", within the HairSalon.Solution folder.  
Hold the shift button on your keyboard and right-click inside the File Explorer window, and in the right-click menu, choose "Open Powershell Window Here" or "Open Git Bash Here"  
This will open a Powershell/Git Bash window that is already inside the proper directory.

[Click here for tips on navigating the terminal](https://docs.microsoft.com/en-us/powershell/scripting/samples/managing-current-location?view=powershell-7.1)

### Additional File Setup

This project relies on databases, and as such, requires additional setup.  
First, you will need to navigate to the `\HairSalon.Solution\HairSalon` directory. Create a file named `appsettings.json` and paste the following code into the new file:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=root;pwd=[YOUR PASSWORD];"
  }
}
```

You will need to make at least TWO changes to the appsettings.json file:  
Where the text says `database=[DATABASE_NAME]`, enter your own database's name, and remove the brackets. If your database was named `my_database` this code will look like `database=my_database`  
Where the text says `pwd=[YOUR PASSWORD]`, enter your own secure password, and remove the brackets. If your password is `SafePassword123` this code will look like `pwd=SafePassword123`  
This ensures that the program will be able to read and write to your own local database.

### Setting Up Local Database

This project's databases were made with the assistance of [MySQL Workbench 8.0.19](https://downloads.mysql.com/archives/workbench/).  

Below is the basic structure dump for the table. You may import the entire table structure file as well through the MySQL workbench by importing the file named "ashley_porter.sql"

```
--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `ContactInfo` varchar(255) DEFAULT NULL,
  `StylistId` int NOT NULL,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Table structure for table `stylists`
--

DROP TABLE IF EXISTS `stylists`;
CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(255) DEFAULT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```

### After everything is set up

Once you have properly navigated to the project directory (`<your directory>\HairSalon.Solution\HairSalon`), your appsettings.json file has been created, and your local server has been set up, type:

`dotnet restore`

followed by

`dotnet run`

This will run the web application on a local server. Look for terminal output containing these lines:  

```
Now listening on: http://localhost:5000
Now listening on: https://localhost:5001
Application started. Press Ctrl+C to shut down.
```

Once you see this in the terminal, you will be able to open the web page as a link in your browser. Copy either URL and paste it in the browser. If you choose the `https://localhost:5001` link, the browser will likely attempt to protect you by informing you this site has no certificates. That is true; simply bypass the site's warning, or use the unsecured hyperlink `http://localhost:5000` instead.

## How To Use The Program

The program will open up on a landing page, directing the user to either enter a new Stylist's information or a new Client's information. The user may navigate to either link and view data (if data exists) but if there are no current Stylists, the program will display a message in the Add Client area of the site.  
This is because a Client MUST be assigned a Stylist.  

Clicking `View Stylist List` will navigate to the `/Stylists` directory, where the user can view all Stylists. From this page, the user may add a new Stylist, or click on any existing Stylist's name to view their unique details.  
Once within a Stylist's details page, the user can view all this Stylist's Clients, edit a Stylist's info, delete the Stylist, or return to the Stylists' home page.

Clicking `View Client List` will navigate to the `/Clients` directory, where the user can view all Clients. This page will display the Clients, as well as their corresponding Stylist. It also contains a link to add a new Client, so long as there is already one Stylist in the `stylists` table. Clicking on a Client's name will display their details, including first name, last name, and their contact info. Each of these fields accept text input. The Contact Info field is a catch-all field, which can take the Client's best phone number, email address, text number, etc.  
From the Details page, the user can edit a Client, delete the current Client, or return back to the Clients' home page.

All pages will contain a link back to the Home page.

## Known Bugs/Issues

__

## Support and contact details

_Discord: @KirbyPaint#0751_

## Technologies Used

_C#, .NET 5, ASP.NET MVC, MySQL and MySQL Workbench_

### License Information

_GNU Public License_

Copyright (c) 2021 **_KirbyPaint_**