Driver Vehicles License Department (DVLD)
Overview

Driver Vehicles License Department (DVLD) is a Windows desktop application designed to manage driver and vehicle licenses efficiently. It allows issuing local and international licenses, renewing expired licenses, and creating replacements for lost or damaged ones. It also manages users, drivers, and tracks the full history of issued licenses.

This project is built using C#, ADO.NET, and .NET Framework (Windows Forms) with a SQL Server backend.

Features

License Management

Issue Local & International licenses.

Complete testing flow: Vision Test → Written Test → Street Test.

Issue license for the first time upon successful tests.

Renew expired licenses.

Create replacement licenses (for lost or damaged licenses).

Person, Driver & User Management

Persons are the base entities.

Drivers are created upon issuing a license.

Users are created from persons with username & password.

License Detain & Release

Detain licenses with a defined fine.

Release detained licenses upon fine payment.

Manage detained licenses via dedicated interface.

History & Tracking

View license history per driver (local & international).

Track number of issued, renewed, detained, replaced, and released licenses.

Authentication & Security

Login screen with Remember Me feature.

Change user password.

Change current person information.

Tech Stack

Language: C#

Framework: .NET Framework (Windows Forms)

Database: SQL Server (connected via ADO.NET)

Architecture: Layered (Data Access Layer, Business Logic Layer, Presentation Layer)

Getting Started
Prerequisites

Visual Studio (recommended: 2019 or later)

SQL Server (with appropriate access rights)

.NET Framework (4.x)

Installation

Clone the repository:

git clone https://github.com/mohabayma/Driviers-Vehicles-License-Department-DVLD-.git

Open the solution file in Visual Studio.

Restore the database (if .bak file is provided) or connect to your SQL Server instance.

Update the database connection string in the configuration file if necessary.

Build and run the project.

Login

Use the default credentials (if provided) or create a new user from the Persons list.

Screenshots

(Add screenshots here: Login Screen, Main Dashboard, License Management)

Contribution

Contributions are welcome! Feel free to fork this repository, create a branch, and submit a pull request.

License

This project is open-source. Specify your license here (e.g., MIT, Apache 2.0).

Author

Developed by Mohab Ayman.

GitHub: mohabayma
