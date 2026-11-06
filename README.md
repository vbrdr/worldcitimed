# WorldCitiMed 🏥
### Medical Center Queue Management System

WorldCitiMed is a desktop-based queue management system developed using **C# Windows Forms and Microsoft SQL Server**. It was created to help organize patient queues, manage registrations, and make the queuing process easier for both patients and hospital staff.

The project was developed as part of our academic requirements. Before development, our group conducted interviews with staff from **World Citi Medical Center in Quezon City** to understand their existing queueing process and identify areas that could be improved.

Based on the information gathered, we developed a system that supports patient registration, priority queueing, queue number generation, and queue monitoring.

## Features

- **Patient Registration** — Allows staff to register patients and manage their information.
- **Queue Management** — Generates and organizes queue numbers.
- **Priority Queueing** — Supports priority patients during the queuing process.
- **Queue Display** — Displays queue numbers and updates for patients.
- **Admin Management** — Provides a separate interface for administrative functions.
- **Queue Slip Printing** — Generates printed queue slips for patients.
- **Database Integration** — Uses Microsoft SQL Server to store and manage system records.

## Technologies Used

- C#
- Windows Forms
- .NET Framework 4.7.2
- Microsoft SQL Server
- Visual Studio
- SQL Server Management Studio (SSMS)

## Project Structure

WorldCitiMed consists of four Windows Forms applications:

| Project | Description |
|---|---|
| `worldcitimed` | Main application for patient registration and queue processing |
| `worldcitimed_adm` | Administrative application |
| `worlcitimed_display` | Queue display application |
| `worlcitimed_show` | Queue monitoring interface |

The Visual Studio solution is located at `worldcitimed/worldcitimed.sln`.

## Screenshots

Screenshots of the system will be added here.

## Project Status

WorldCitiMed was completed and presented as an academic project.

The system was developed based on interviews with hospital staff, but it was not officially implemented or deployed at World Citi Medical Center.

The database and patient records are not included in this repository. Additional testing and security improvements would be needed before the system could be used in an actual hospital.

*WorldCitiMed is an independent academic project and is not an official system of World Citi Medical Center.*
