# 🚀 My REST API (ASP.NET Core)

A RESTful API built with **C# and ASP.NET Core**, designed to interact with a **SQLite** relational database using **Entity Framework Core**.

---

## 📜 Table of Contents
- [📌 About the Project](#about-the-project)
- [⚙️ Technologies Used](#technologies-used)
- [🛠 Features](#features)
- [📦 Installation](#installation)
- [⚡ Running the API](#running-the-api)
- [📖 API Endpoints](#api-endpoints)
---

## 📌 About the Project
This API follows **RESTful principles** and provides standard CRUD operations.  
It is optimized for **performance, security, and scalability**.

---

## ⚙️ Technologies Used
- **Backend:** ASP.NET Core 8  
- **Database:** SQLite 
- **ORM:** Entity Framework Core  
---

## 🛠 Features
✔️ CRUD operations  
✔️ RESTful architecture  
✔️ Entity Framework Core integration  
---

## 📦 Installation
```bash
git clone https://github.com/user/repository.git
cd project-folder
dotnet ef database update
dotnet restore
dotnet run
```
---
## 📖 API Endpoints
| Method   | Endpoint            | Description               |
|----------|---------------------|---------------------------|
| `GET`    | `http://localhost:5134/FTypes`   | Get all furnitures types          |
| `GET`    | `http://localhost:5134/Furnitures`        | Get all furnitures   |
| `GET`    | `http://localhost:5134/Furnitures{id}`   | Get furniture by ID   |
| `POST`   | `http://localhost:5134/furnitures`        | Create new furniture       |
| `PUT`    | `http://localhost:5134/furnitures{id}`   | Update a furniture      |
| `DELETE` | `http://localhost:5134/furnitures{id}`   | Delete a furniture          |


