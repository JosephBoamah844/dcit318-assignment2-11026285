# DCIT 318 – Programming II – Assignment 2

## Overview

This C# console application demonstrates three key object-oriented programming concepts:

1. **Inheritance & Method Overriding**
2. **Abstract Classes & Methods**
3. **Interfaces**

The program is menu-driven, allowing the user to select and run any of the three tasks from a single entry point.



## Project Structure


Assignment2App/
│
├── Program.cs                 # Main entry point, displays menu and runs tasks
├── Tasks/
│   ├── Animal.cs               # Base class for Task 1
│   ├── Dog.cs                   # Derived class overriding MakeSound()
│   ├── Cat.cs                   # Derived class overriding MakeSound()
│   ├── Shape.cs                 # Abstract base class for Task 2
│   ├── Circle.cs                # Implements GetArea() for a circle
│   ├── Rectangle.cs             # Implements GetArea() for a rectangle
│   ├── IMovable.cs              # Interface for Task 3
│   ├── Car.cs                   # Implements Move()
│   ├── Bicycle.cs               # Implements Move()
```


## Tasks

### 1. Inheritance & Method Overriding

* **Animal** (base class) defines `MakeSound()` → prints `"Some generic sound"`.
* **Dog** overrides `MakeSound()` → prints `"Bark"`.
* **Cat** overrides `MakeSound()` → prints `"Meow"`.

### 2. Abstract Classes & Methods

* **Shape** (abstract class) defines abstract method `GetArea()`.
* **Circle** implements `GetArea()` → calculates `π × r²`.
* **Rectangle** implements `GetArea()` → calculates `width × height`.

### 3. Interfaces

* **IMovable** (interface) defines `Move()` method.
* **Car** implements `Move()` → prints `"Car is moving"`.
* **Bicycle** implements `Move()` → prints `"Bicycle is moving"`.


## How to Run

1. Open a terminal in the project root (`Assignment2App`).
2. Run:

   ```bash
   dotnet run
   ```
3. Enter a menu option (1–3) to test a specific task.



## Notes

* The project is structured so each concept is in its own class file for clarity.
* Code follows C# naming conventions and OOP best practices.
* Compatible with .NET 6.0+.


