# School Enrollment System - Centro Educativo

### Overview
This professional software solution is designed to manage and automate the enrollment process for educational institutions. It provides a comprehensive toolset for student registration, academic record tracking, and data-driven decision-making through advanced reporting. 

### Technical Architecture
The project is built using a Layered Architecture (N-Tier) in .NET to ensure high scalability, separation of concerns, and ease of maintenance: 


* **Presentation Layer:** Windows Forms interface featuring dynamic DataGrids for real-time reporting. 


* **Business Logic Layer (Negocio):** Handles core validations for enrollment, course offerings, and user permissions. 


* **Data Access Layer (AccesoDatos):** Manages all database interactions using ADO.NET. 


* **Entities Layer:** Defines the core data models (Student, Teacher, Course, Schedule, etc.). 


* **Utility Layer:** Contains shared helper functions and system-wide constants. 

### Core Modules

* **Security:** Role-based access control (Staff vs. Student) to manage system permissions. 


* **Maintenance:** Administrative tools to manage schedules, subjects, student files, and faculty data. 


* **Process Management:** Functional workflows for course registration, enrollment freezing, and academic offer generation. 


* **Reporting System:** Real-time data visualization for active/inactive users, academic history, classroom status, and enrollment periods. 

### Database Integration
The system is powered by SQL Server. A complete database script is provided to replicate the environment, including tables, relationships, and specialized stored procedures for all CRUD operations. 


> **Note on Language:** While this documentation is in English, the source code, database schema, and stored procedures are written in Spanish (PA_AgregarEstudiante, ID_Materia, etc.) to align with the specific requirements of the local educational institution. 

### Technologies Used

* **Language:** C# (.NET) 

* **Database:** SQL Server (Transact-SQL) 

* **IDE:** Visual Studio 2022
