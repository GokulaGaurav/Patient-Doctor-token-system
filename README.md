# Patient Doctor Token Queue System

## 📌 Project Overview

The Doctor Patient Token Queue System is a simple desktop application developed using C# and WPF (.NET).

The application helps a receptionist manage patient registrations and consultation tokens using the Queue data structure. It follows the FIFO (First In, First Out) principle, ensuring patients are called in the order they register.

## 🛠️ Technologies Used

* Programming Language: C#
* Framework: WPF (.NET)
* IDE: Visual Studio
* Collection: System.Collections.Queue
* Data Storage: In-Memory
* Database: Not Required

## ✨ Features

* Register patients by entering their names.
* Automatically generate sequential token numbers.
* Add registered patients to the queue.
* Start consultations using the Doctor Arrived button.
* Display the current patient's token number and name.
* Call the next patient using the Next Patient button.
* Display the total number of waiting patients.
* Show a message when the queue is empty.
* Prevent calling patients before the doctor arrives.

## ⚙️ Application Workflow

1. Receptionist enters the patient's name.
2. Clicking Create Token generates a unique sequential token.
3. The patient is added to the queue using Enqueue().
4. Clicking Doctor Arrived starts the consultation process and calls the first patient.
5. Clicking Next Patient removes and displays the next patient using Dequeue().
6. When the queue becomes empty, the application displays "No patients waiting".

## 🧠 Queue Implementation

This project uses the Queue collection from System.Collections.

**Creating a Queue:**

```csharp
Queue patientQueue = new Queue();
```

**Adding a Patient:**

```csharp
patientQueue.Enqueue(patient);
```

**Calling the Next Patient:**

```csharp
patientQueue.Dequeue();
```

**Checking Waiting Patients:**

```csharp
patientQueue.Count;
```

The Queue follows the FIFO principle, meaning the first registered patient is called first.

## 💻 Example Output

**Patient Registration:**

```text
Token 1 - Arun
Token 2 - Bala
Token 3 - Kumar

Waiting Patients: 3
```

**After Doctor Arrives:**

```text
Current Patient

Token No: 1
Patient Name: Arun

Waiting Patients: 2
```

**After Clicking Next Patient:**

```text
Current Patient

Token No: 2
Patient Name: Bala

Waiting Patients: 1
```

**When Queue Is Empty:**

```text
No patients waiting
```

## 🚀 How to Run the Project

1. Clone or download this repository.
2. Open the project solution (.sln) in Visual Studio.
3. Ensure the required .NET SDK is installed.
4. Build the solution.
5. Press F5 to run the application.

## 📂 Project Structure

```text
Paitent_queue_system/
│
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── App.xaml
├── App.xaml.cs
├── Paitent_queue_system.csproj
└── README.md
```

## 📝 Note

* This application does not require a database.
* Patient details are stored temporarily in memory.
* All registered patient information is cleared when the application closes.
* Token numbering starts from 1 whenever the application restarts.

## 🎯 Learning Outcomes

Through this project, I gained practical knowledge of:

* Implementing Queue data structures in C#.
* Understanding FIFO operations.
* Developing desktop applications using WPF.
* Handling button-click events.
* Using conditional statements.
* Managing temporary data without a database.
