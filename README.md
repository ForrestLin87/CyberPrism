# CyberPrism 🏭

**CyberPrism** represents the next generation of smart industrial monitoring. It is a high-performance, modular WPF application designed to streamline factory operations through real-time data visualization, production tracking, and advanced analytics.

Built with **Prism** and **.NET**, backed by a robust **ASP.NET Core** and **PostgreSQL** backend, CyberPrism demonstrates a clean, scalable architecture suitable for enterprise-grade IoT and manufacturing solutions.

---

## ✨ Key Features

- **📊 Dynamic Dashboard**  
  Real-time visualization of key performance indicators (KPIs) including production rates, target benchmarks, and power consumption using interactive charts.

- **🏭 Production Management**  
  Comprehensive tracking of production jobs with status indicators (Running, Delayed, Completed), due dates, and progress monitoring.

- **📈 Advanced Analytics (OEE)**  
  Deep dive into Overall Equipment Effectiveness with detailed breakdowns of Availability, Performance, and Quality components. Includes real-time downtime analysis with alerting features.

- **🧩 Modular Architecture**  
  Features a fully decoupled design using the **Prism Library**. Modules (Dashboard, Production, Analytics, Settings) are loaded dynamically, promoting maintainability and testability.

- **⚙️ Centralized Configuration**  
  Robust settings management system that synchronizes client preferences (themes, notifications, connection settings) with the server.

- **🎨 Modern Dark UI**  
  A sleek, industrial-grade dark theme designed for low-light factory environments, ensuring operator focus and reduced eye strain.

---

## 🛠️ Technology Stack

### Client (Desktop)
- **Framework**: WPF (.NET 6/7/8)
- **Architecture**: MVVM (Model-View-ViewModel)
- **Library**: Prism (Dependency Injection, Event Aggregator, Modularity)
- **UI Components**: LiveCharts.Wpf, Material Design concepts
- **Communication**: HTTP Client (RESTful API consumption)

### Server (Backend)
- **Framework**: ASP.NET Core Web API
- **Database**: PostgreSQL
- **ORM**: Entity Framework Core
- **Features**: 
  - Automated Database Seeding (Schema & Initial Data)
  - Background Services (Data Simulation)
  - Repository Pattern

---

## 🚀 Getting Started

Follow these instructions to get a local copy of the project up and running.

### Prerequisites

- **[.NET SDK](https://dotnet.microsoft.com/download)** (Version 6.0 or later recommended)
- **[PostgreSQL](https://www.postgresql.org/download/)** (Running locally or accessible via network)
- **IDE**: [Visual Studio 2022](https://visualstudio.microsoft.com/) (Recommended) or Visual Studio Code

### 📥 Installation & Setup

1.  **Clone the Repository**
    ```bash
    git clone https://github.com/your-username/CyberPrism.git
    cd CyberPrism
    ```

2.  **Configure the Database**
    - Navigate to the server directory: `CyberPrism.Server`
    - Open `appsettings.json`.
    - Update the `DefaultConnection` string with your PostgreSQL credentials:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Host=localhost;Database=CyberPrismDb;Username=postgres;Password=your_password"
    }
    ```
    - *Note: The application includes a `DatabaseSeeder` that will automatically create the database and populate it with sample data on the first run.*

3.  ### 3. Run the Server
Simply run the server application.

**Option A: Using Visual Studio**
1. Right-click `CyberPrism.Server` project.
2. Select **debug** -> **Start New Instance** (or just run the project).

**Option B: Using CLI**
```bash
cd CyberPrism.Server
dotnet run
```
    - The API will launch (default: `http://localhost:5133`). Keep this terminal window open.

4.  **Launch the Client Application**
    - Open `CyberPrism.sln` in Visual Studio.
    - Right-click the **CyberPrism** (WPF) project and select **Set as Startup Project**.
    - Press **F5** or click **Start** to build and run.

---

## 📂 Project Structure

The solution is organized following clean architecture principles:

```
CyberPrism/
├── 📁 CyberPrism/                # Main WPF Shell, Bootstrapper, & Region Definitions
├── 📁 CyberPrism.Core/           # Shared Infrastructure (Models, Services, Events, Constants)
├── 📁 CyberPrism.Server/         # Backend Web API & Data Access Layer
├── 📁 Modules/                   # Feature Modules
│   ├── 📁 .Dashboard/            # Dashboard Widgets & Logic
│   ├── 📁 .Production/           # Job Scheduling & Tables
│   ├── 📁 .Analytics/            # Data Processing & Charts
│   └── 📁 .Settings/             # App Configuration
└── 📁 Tests/                     # Unit Tests
```

---

## 🤝 Contributing

Contributions make the open-source community an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.
