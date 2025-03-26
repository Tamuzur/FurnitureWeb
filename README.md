# My REST API (ASP.NET Core)

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
In the future, I plan to integrate this API with a Blazor frontend to provide a real-world application
with an intuitive and modern user interface.

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

## ⚡ Running the API
### Find the correct local port:
When running the application, ASP.NET Core dynamically assigns a port. You can find it in the **console output** when starting the app:
```
Now listening on: https://localhost:xxxx
Now listening on: http://localhost:xxxx
```
Alternatively, check your **`launchSettings.json`** under:
```json
"applicationUrl": "https://localhost:xxxx;http://localhost:xxxx"
```
Replace `xxxx` in the endpoints below with the correct port.

---

## 📖 API Endpoints
| Method   | Endpoint                          | Description               |
|----------|----------------------------------|---------------------------|
| `GET`    | `http://localhost:xxxx/FTypes`   | Get all furniture types  |
| `GET`    | `http://localhost:xxxx/Furnitures` | Get all furniture        |
| `GET`    | `http://localhost:xxxx/Furnitures/{id}` | Get furniture by ID  |
| `POST`   | `http://localhost:xxxx/Furnitures` | Create new furniture  |
| `PUT`    | `http://localhost:xxxx/Furnitures/{id}` | Update a furniture  |
| `DELETE` | `http://localhost:xxxx/Furnitures/{id}` | Delete a furniture  |

---
