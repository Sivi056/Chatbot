Cybersecurity Awareness Chatbot
Description
This project is a Windows Forms application developed in C# that serves as a Cybersecurity Awareness Chatbot. It provides users with information on various cybersecurity topics, offers fun facts, and includes a simple quiz to test their knowledge. The chatbot is designed to be interactive, allowing users to ask questions, add tasks, view an activity log, and test their understanding of cybersecurity concepts.

Features
Interactive Chat: Ask questions about specific cybersecurity topics like Malware, Phishing, Ransomware, Network Security, etc.

Task Management: Add and manage tasks with titles, descriptions, 

Quiz Module: Test your cybersecurity knowledge with interactive quizzes.

Fun Facts: Learn interesting facts about cybersecurity.

Activity Log: View a log of interactions and activities within the chatbot.

Welcome Sound (Optional): Plays a welcome sound upon application launch (requires NAudio and a specified .wav file).

Technologies Used
C#: The primary programming language.

Windows Forms: For the graphical user interface.

NAudio: A .NET audio library used for playing sound files (specifically for the welcome sound).

Setup and Running the Project
Prerequisites
Visual Studio (2019 or later recommended) with the ".NET desktop development" workload installed.

.NET Framework (usually installed with Visual Studio).

Steps to Run
Clone or Download the Project: Obtain the project files (e.g., from a Git repository or by downloading the ZIP).

Open in Visual Studio:

Open Visual Studio.

Go to File > Open > Project/Solution...

Navigate to the directory where you saved the project and open the .sln file (e.g., Chatbot.sln).

Install NAudio (if not already installed):

In Visual Studio, go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution...

In the "Browse" tab, search for NAudio.

Select the NAudio package and install it for your Chatbot project.

Audio File for Welcome Sound (Optional):

If you intend to use the PlayWelcomeSound() feature in Chatbot.cs, you need to place a .wav audio file at the specified path.

Open Chatbot.cs.

Locate the PlayWelcomeSound() method.

Update the audioFilePath variable to the absolute path of your .wav file:

string audioFilePath = @"C:\Your\Actual\Path\To\Your\soundfile.wav"; // <--- UPDATE THIS LINE

If you don't want the welcome sound, you can remove the call to PlayWelcomeSound() or comment out the method.

Build the Project:

In Visual Studio, go to Build > Build Solution (or press Ctrl+Shift+B).

Ensure there are no build errors. (If you still encounter the CS0111 error, refer to the previous troubleshooting steps to ensure only one Form1() constructor exists across Form1.cs and Form1.Designer.cs, with the chatbot = new Chatbot() initialization correctly placed).

Run the Application:

Press F5 or click the "Start" button (green play icon) in the Visual Studio toolbar.

Usage
Once the application runs, you will see the main chatbot window.

To Chat: Type your questions into the "Enter your question" text box and click the "Send" button.

Add a Task: Enter the task title and description into the respective text boxes, select a reminder date/time, and click "Add Task."

Start Quiz: Click the "Start Quiz" button to begin a cybersecurity quiz. Follow the prompts in the response list.

Fun Facts: Click the "Fun Facts" button to get a random cybersecurity fun fact.

Show Activity Log: Click "Show Activity Log" to clear previous responses and display a placeholder for log entries.

Back: Click "Back" to clear the response list.

Exit: Click "Exit" to close the application.
