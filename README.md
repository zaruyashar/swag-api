# Softito Backend Project 5: First RESTful Web API

Welcome to my 5th project developed during the **SoftITo Backend Face-to-Face Training**. This project marks a significant milestone in my learning journey as it is my very first time building a Web API and working with API controllers in ASP.NET Core!

## 🎯 Project Overview
The goal of this project was to understand the fundamentals of creating a Web API. I focused heavily on adopting **RESTful principles** and professional software development standards, moving beyond basic functionality to build a more fault-tolerant and standard-compliant application.

## ✨ Key Features & Learnings
- **First API Controllers:** Created and managed my first API controllers to handle HTTP requests.
- **RESTful Architecture:** Implemented standard HTTP verbs (`GET`, `POST`, `PUT`, `DELETE`) with appropriate routing.
- **Professional Standards:** - Used `Task<IActionResult>` with `async/await` to ensure asynchronous, non-blocking database operations.
  - Implemented proper HTTP Status Codes (e.g., `200 OK`, `201 Created` with `CreatedAtAction`, `204 No Content`, `400 BadRequest`, `404 Not Found`).
  - Added defensive programming techniques, including concurrency handling (`DbUpdateConcurrencyException`) and basic pagination with `.Take(20)` to prevent unbounded queries.
- **Swagger Integration:** First time using **Swagger (OpenAPI)** for testing and documenting endpoints. It made visualizing and testing CRUD operations incredibly intuitive!

## 📸 Screenshots

Here are some glimpses of the API in action using Swagger UI:

### API Endpoints Overview
<img width="3069" height="1917" alt="1" src="https://github.com/user-attachments/assets/ca051499-108a-4e24-a521-f579dbf8a77c" />


### Creating a Record (POST)
<img width="3069" height="1917" alt="2" src="https://github.com/user-attachments/assets/cc8d27ad-43b6-41ac-8995-83a115fd118b" />


### Updating a Record (PUT)
<img width="3069" height="1917" alt="3" src="https://github.com/user-attachments/assets/cc8602ec-75e8-42e1-b9c8-86b36a95aca3" />


## 🚀 What's Next?
While Swagger was a great introduction to API documentation, I plan to explore and integrate **Scalar** in my next API project to experience a more modern API reference interface.

## 🛠️ Technologies Used
- C# & .NET
- ASP.NET Core Web API
- Entity Framework Core
- Swagger / Swashbuckle
