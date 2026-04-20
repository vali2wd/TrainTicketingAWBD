# Train Ticketing 

## 🎓 Materie
- **Course:** `AWBD`
- **Instructor:** Iulia Teodora Banu Demergian
- **Student:** Valentin Nafornita (`toate contributiile`)
- **Date:** 2nd Semester FMI BDTS `Y1 2026`

## 📝 Project Overview
O aplicatie pentru rezervat bilete de tren, orientata pentru DDD si care tine cont de un numar mare de request-uri si care nu creeaza conflicte in baza de date.

## 🎓 Architecture
- **Gateways:** The Gatway project uses `YARP` to call on the `notification`, `reporting`, and `business` microservices. A rate limit is imposed of 10 per minute, hitting the Gateway.
- **CI:** GitHub Actions.
- **FrontEnd:** Angular and Angular Materials.
- **Deployment:** Docker Compose Desktop.
- **GenAi Usage:** Gemini 3 - code debugging, documentation. Idea brainstorming.
- **Results:** Http Responses of Pagination Responses.
- **Jobs:** A job seeds new train departures each 24 hours of API run as a `BackgroundService`.
- **Testing:** xUnit, Moq, EF InMemory, AspNetCore MVC Testing(E2E).
- **Logging:** `Serilog` and `Sinks.File` for Debug Errors.
- **Concurrency handling and Design Patterns:** The project makes use of DDD principles. Such the `DailyDeparture` is a Root Aggregate. Upon ticket reservation creation a `Domain Event` is added, such increasing the Version of the Daily Departure Aggregate. 2 Reservations done within the same time of the database population will clash on the version increase, and the latter will `fail`. Used Generic Endpoints to Map Entities to controllers.s

## 📊 Capturi de ecran

![FrontEnd][FrontEnd]
![Stations][Stations]
![LogIn][LogIn]
![Sortare][Sortare]
![404][404]


## 📊 Database Schema (ER Diagram)

![ER Diagram][ERD]

> *Nota: SSMS Generated.*

## 🛠 Tech Stack
- **Backend:** ASP.NET Core 9.0/10.0
- **ORM:** Entity Framework Core
- **Database:** SQL Server
- **Frontend:** Angular
- **Security:** Microsoft Identity
- **API Documentation:** Swagger (`https://localhost:5001/swagger/index.html`)



## ⚙️ Setup Instructions
1. Clone the repository.
2. Update the `ConnectionStrings` in `appsettings.json` to your database.
3. Open the **Package Manager Console** in Visual Studio.
4. Run `Update-Database` to apply migrations.
4.half . Run the `Manual Transactions` from the root directory. to seed your database.
5. Set up the Docker Compose as the starting project.
6. Press `F5` to run.
7. Checkout the `FrontEnd` Branch and run Angular project accordingly.

[ERD]: ./Project%20Deliverable%20Assets/ERD.jpg
[404]: ./Project%20Deliverable%20Assets/404.png
[FrontEnd]: <./Project Deliverable Assets/FrontEnd Landing Page.png>
[LogIn]: <./Project Deliverable Assets/LogIn Form.png>
[Sortare]: <./Project Deliverable Assets/Sortare dupa Criterii, Paginare.png>
[Stations]: <./Project Deliverable Assets/Stations Picker.png>
