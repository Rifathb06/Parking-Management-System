# Parking-Management-System
# 🚗 Parking Management System

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
![Security Focus](https://img.shields.io/badge/Security-RBAC%20Integrated-blue?style=for-the-badge)

## 📌 Overview
The Parking Management System is a robust desktop application built in C# designed to automate daily parking facility operations, track vehicle movements, and optimize workflow efficiency. A primary focus of this project is secure system architecture, featuring a custom Role-Based Access Control (RBAC) implementation to ensure strict data governance and user authorization.

## ✨ Key Features
* **Role-Based Access Control (RBAC):** Distinct, secure interfaces and permission tiers tailored for four specific user types:
  * **Admins:** Full system access, employee management, and financial oversight.
  * **Clerks:** Transaction processing and ticketing.
  * **Checkers:** Vehicle entry/exit verification and monitoring.
  * **Customers:** View parking status and personal history.
* **Automated Daily Operations:** Streamlined vehicle tracking, automated time-stamping, and dynamic fee calculation.
* **Secure Database Integration:** Reliable data storage, retrieval, and relational mapping using Microsoft SQL Server.
* **Workflow Efficiency:** Intuitive UI designed to reduce processing time at entry and exit points.

## 🛠️ Technology Stack
* **Language:** C# 
* **Database:** Microsoft SQL Server
* **Architecture:** Monolithic with RBAC security implementation
* **Framework:** [Specify WinForms, WPF, or ASP.NET depending on your exact build]

## 🗄️ Database Setup
1. Ensure Microsoft SQL Server and SQL Server Management Studio (SSMS) are installed.
2. Open SSMS and connect to your local server.
3. Execute the provided database script (`database_schema.sql`) to create the necessary tables, relationships, and default admin credentials.
4. Update the connection string in the C# project's `App.config` or `appsettings.json` file to match your local SQL Server instance:
   ```xml
   <connectionStrings>
       <add name="ParkingDB" connectionString="Server=YOUR_SERVER_NAME;Database=ParkingManagement;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>
   </connectionStrings>
