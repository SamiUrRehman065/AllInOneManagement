## 🧾 AllInOne Management System
- **Developer**: Sami Ur Rehman 
- A modular, offline Windows Forms application built in C# with SQL Server backend designed for small-to-medium businesses to manage orders, customers, ledgers, raw materials, production, cash flow, and summary reports, all in one place. Every module is engineered for clarity, auditability, and real-world usability.

---

## 🎯 Features Overview

- **Offline-first architecture** with robust deployment
- **Modular interface** for core business areas
- **Custom CRUD controls** per module for clean separation
- **SQL-driven backend** with reusable query logic
- **Secure login and home view** for authenticated access
- **Dashboard and summary views** for instant insights
- **Custom licensing and professional documentation**

---

## 📐 Architecture Overview

| **Layer**      | **Details**                                                                 |
|----------------|------------------------------------------------------------------------------|
| **Frontend**   | Windows Forms with Guna UI — clean, responsive, and intuitive interface      |
| **Backend**    | C# (.NET 8) using ADO.NET with raw SQL for granular data control             |
| **Database**   | SQL Server with tightly coupled relationships, foreign keys, and indexing    |
| **Audit Trail**| SQL Triggers ensure tamper-proof logs on every transactional table           |
| **Security**   | Login-based access control, fully offline (no external calls or dependencies)|
| **Deployment** | EXE-based packaging with SQL Server integration; no internet required        |

---

## 🧩 Modules Included

| Module          | Description                                         |
|------------------|-----------------------------------------------------|
| Orders           | Manage sales orders with update/view functionality |
| Customers        | Add customers and view their ledgers               |
| Ledgers          | Track financial entries with audit support         |
| Raw Materials    | Manage inventories and procurement                 |
| Production       | Monitor production flows and outputs               |
| Cash Flow        | Record income/expenses and generate reports        |
| Summary View     | Aggregated overview of business metrics            |
| Dashboard        | Centralized, visual overview with utilities        |
| Authentication   | Login system with splash and popup functionality   |

---

## 📁 Project Structure

```plaintext
AllInOneManagement/
├── Dependencies/
├── Properties/
├── Guna/
├── Images/
├── UserControls/
│   ├── CashFlowControls/
│   │   └── CrudControlsCashFlow/
│   │       ├── AddCashFlowControl.cs
│   │       └── UpdateCashFlowControl.cs
│   │   └── CashFlow.cs
│   ├── LedgersControls/
│   │   └── CrudControlsLedger/
│   │       ├── AddLedgerControl.cs
│   │       └── UpdateLedgerControl.cs
│   │   └── Ledgers.cs
│   ├── OrdersControls/
│   │   └── CrudControlsOrder/
│   │       ├── AddOrderControl.cs
│   │       ├── UpdateOrderControl.cs
│   │       └── MethodDelegate.cs
│   │   └── Orders.cs
│   ├── ProdControls/
│   │   └── CrudCtrlProduct/
│   │       ├── AddProductionControl.cs
│   │       └── UpdateProductionControl.cs
│   │   └── Production.cs
│   ├── RMControls/
│   │   └── CrudCtrlRM/
│   │       ├── AddRawMaterialControl.cs
│   │       └── UpdateRawMaterialControl.cs
│   │   └── RawMaterial.cs
│   ├── SummaryControls/
│   │   └── Summary.cs
│   ├── DashboardControls/
│   │   ├── MainDashboard.cs
│   │   └── WeatherClockControl.cs
│   ├── CustomerControls/
│   │   ├── AddCustomerControl.cs
│   │   └── CustomerLedgerView.cs
├── DB/
│   ├── SqlConnection.cs
│   └── SqlCommands.cs
├── Models/
│   ├── Customer.cs
│   ├── Ledger.cs
│   └── RawMaterial.cs
├── Authentication/
│   ├── Login.cs
│   ├── Home.cs
│   └── Popup.cs
├── Program.cs
├── MainForm.cs
├── app.manifest
```
---

## 🧰 Deployment Details

- Fully offline installation using `Setup.exe` with bundled dependencies  
- Includes SQL Server instance setup preconfigured for seamless onboarding  
- No external DLLs or APIs ideal for air-gapped environments  
- Runs smoothly on Windows 10/11 with minimal RAM footprint  

---

## 🔐 Licensing & Ethics

This project is shared for educational and portfolio demonstration purposes only. Sensitive logic and full client code are intentionally abstracted to uphold professional integrity and protect client trust.

- ✅ **Custom License Included**
- 📄 **Reflection logs and README documentation**
- 🔒 **Ethical software sharing practices**

---

## 📁 Project Highlights

- Designed and delivered end-to-end: coding, packaging, deploying, and supporting  
- Architected modules like Ledger, Summary, Production, and Raw Material from scratch  
- Documented entire system workflow, UI navigation, and client deployment guide  
- Reflected on professional and ethical implications of software delivery  

---

## 👨‍💻 Author

Build with precision and passion by **Sami Ur Rehman**  
📍 Karachi, Pakistan  
🔗 [GitHub Profile](https://github.com/SamiUrRehman065)

---

## 🧠 Developer Reflection

This system was built, tested, and refined over 2.5 months of daily development. The design choices reflect my commitment to:

- Modular architecture for maintainability
- Ethical delivery practices
- Professional presentation and documentation
- Growth from academic learning to real-world systems


