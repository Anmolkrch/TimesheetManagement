# Timesheet Management

A web-based **Timesheet Management System** built with **ASP.NET MVC 5** and **SQL Server**.  
This project helps organizations manage employee timesheets, projects, roles, and approvals efficiently.

---

## 🚀 Features
- **User Registration & Roles**: Supports User, Admin, and SuperAdmin roles.
- **Project Management**: Create and assign projects to users.
- **Timesheet Tracking**: Submit, approve, or reject timesheets.
- **Expense Management**: Track expenses with approval workflows.
- **Audit & Notifications**: Log activities and send notifications.
- **Error Logging**: Integrated with ELMAH for error tracking.

---

## 🛠️ Technologies Used
- **ASP.NET MVC 5**
- **C#**
- **Entity Framework**
- **SQL Server 2008 R2 / later**
- **Bootstrap, jQuery, JavaScript**
- **OWIN & SignalR** (for authentication and real-time features)

---

## 📂 Project Structure
- `Controllers/` → MVC controllers for handling requests.
- `Models/` → Entity Framework models and database entities.
- `Views/` → Razor views for UI.
- `Scripts/` → jQuery, Bootstrap, and custom JS.
- `Content/` → CSS and static assets.
- `TimesheetDB.rar` → Database scripts for SQL Server.

---

## ⚙️ Setup Instructions
1. **Clone the repository**:
   
   git clone https://github.com/Anmolkrch/TimesheetManagement.git

2. Database Setup:

Extract TimesheetDB.rar.

Restore the .bak file or run the .sql scripts in SQL Server Management Studio (SSMS).

Update the connection string in Web.config:

xml
<connectionStrings>
  <add name="DefaultConnection" 
       connectionString="Data Source=YOUR_SERVER;Initial Catalog=TimesheetDB;Integrated Security=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
Run the Application:

Open the solution in Visual Studio.

Build and run the project.

Access via http://localhost:xxxx.

🔑 Demo Credentials
User → demouser / 1234567

Admin → demoadmin / 1234567

SuperAdmin → SuperAdmin / 1234567

📌 Notes
If you face OWIN Startup conflicts, ensure only one [assembly: OwinStartup] attribute is active, or specify the startup class in web.config:

xml
<appSettings>
  <add key="owin:AppStartup" value="WebTimeSheetManagement.Startup" />
</appSettings>
🤝 Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you’d like to change.

📜 License
This project is licensed under the MIT License.

Code

---

✅ This README gives a clear **overview, setup guide, technologies, and demo credentials**.  
Would you like me to also add a **diagram of the database schema** (tables and relationships) so new developers can understand the DB structure at a glance?