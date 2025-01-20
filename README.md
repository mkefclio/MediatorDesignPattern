# Mediator Design Pattern - Task Workflow Console App

Welcome to the Mediator Design Pattern example! This project demonstrates the implementation of the Mediator Design Pattern in .NET Core with a simple and practical example.

## **Overview**
This console application showcases how the **Mediator Design Pattern** can be used to coordinate communication between various components (Developer, Tester, and Designer) without them directly depending on each other.

The purpose of this project is to provide a clear and accessible explanation of the Mediator Design Pattern, making it easy for developers of all levels to understand and apply.

I have also explained this pattern in more detail in my LinkedIn article: [Let's Play With: Design Patterns - Mediator Design Pattern](https://www.linkedin.com/pulse/lets-play-design-patterns-manos-kefalas-a4zif/).

This project was created by **Manos Kefalas** to help developers learn and effectively use the Mediator Design Pattern.

## **How It Works**
The project is divided into the following components:
1. **Messages**: Represent the tasks communicated between components.
2. **Handlers**: Define how each component processes a message and optionally triggers the next step in the workflow.
3. **Mediator**: Coordinates the communication between components, ensuring loose coupling.

## **Code Structure**

### **Step 1: Define Messages**
The `DeveloperTaskCompletedMessage`, `TesterTaskCompletedMessage`, and `DesignerTaskCompletedMessage` classes define the tasks communicated between the components.

### **Step 2: Implement Handlers**
Each handler implements the `IRequestHandler` interface to process a specific type of message:
- `DeveloperHandler`: Handles the completion of development tasks and notifies the tester.
- `TesterHandler`: Handles the completion of testing tasks and notifies the designer.
- `DesignerHandler`: Handles the completion of design tasks.

### **Step 3: Use the Mediator in the Program**
The `Program` class demonstrates how to use the Mediator and Handlers to orchestrate the task workflow.

## **Getting Started**

### Prerequisites
1. **.NET Core SDK** installed on your system.
2. A code editor like **Visual Studio** or **Visual Studio Code**.
3. Install the following NuGet packages:
   - **MediatR**: The core library for the Mediator Design Pattern.
     dotnet add package MediatR
   - **MediatR.Extensions.Microsoft.DependencyInjection**: Provides integration with .NET Core's dependency injection.
    dotnet add package MediatR.Extensions.Microsoft.DependencyInjection
   - **Microsoft.Extensions.Hosting**: For creating a generic host in .NET Core applications.
    dotnet add package Microsoft.Extensions.Hosting
   - **Microsoft.Extensions.DependencyInjection**: For managing service registrations.
     dotnet add package Microsoft.Extensions.DependencyInjection

### Run the Application
1. Clone the repository:
   git clone https://github.com/mkefclio/MediatorDesignPattern.git
   cd MediatorDesignPattern

2. Build and run the project using the .NET CLI or Visual Studio:
   dotnet run

### Expected Output
Workflow started...
Developer completed: Coding
Tester completed: Start Testing
Designer completed: Update UI
Workflow completed.

## **Explanation**

### Key Components
- **Messages**: Define the data structure passed between components.
- **Handlers**: Process the messages and trigger subsequent actions if needed.
- **Mediator**: Acts as the central hub for communication, enabling components to interact indirectly.

This structure adheres to the Mediator Design Pattern, ensuring low coupling and better maintainability.

## **Article Link**
Read my detailed article on LinkedIn: [Let's Play With: Design Patterns - Mediator Design Pattern](https://www.linkedin.com/pulse/lets-play-design-patterns-manos-kefalas-a4zif/).

## **About the Author**
This project was created by **Manos Kefalas** as part of the series **"Let's Play With: Design Patterns"**, aiming to provide practical examples for developers to learn and apply design patterns effectively.

**Connect with me on LinkedIn:** [Manos Kefalas](https://www.linkedin.com/in/manos-kefalas-96b1a3121/)

## **License**
This project is licensed under the MIT License. Feel free to use and modify it for learning or other purposes.

Happy coding! 🎉
