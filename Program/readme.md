# Grade Management System

A C# console application that provides various calculators and identifiers including grade calculation, ticket pricing, and triangle type identification.

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Implementation Details](#implementation-details)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Grade Calculator**: Calculate letter grades based on numerical scores
- **Ticket Price Calculator**: Determine ticket prices based on age groups
- **Triangle Type Identifier**: Identify triangle types based on side lengths

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or Visual Studio Code
- Basic knowledge of C# programming

## Installation

1. Clone the repository:
```bash
git clone https://github.com/your-username/grade-management-system.git
```

2. Navigate to the project directory:
```bash
cd grade-management-system/Program
```

3. Build the project:
```bash
dotnet build
```

## Usage

1. Run the application:
```bash
dotnet run
```

2. Use the main menu to select desired functionality:
   - Press 1 for Grade Calculator
   - Press 2 for Ticket Price Calculator
   - Press 3 for Triangle Type Identifier
   - Press 4 to Exit
   - Press 0 to Return to Main Menu

### Grade Calculator
- Enter numerical grade (0-100)
- System displays corresponding letter grade (A, B, C, D, F)
- Color-coded output for different grades

### Ticket Price Calculator
- Enter age of the ticket buyer
- System calculates ticket price based on age brackets:
  - Under 5: Free
  - 5-12: $10
  - 13-59: $20
  - 60 and above: $15

### Triangle Type Identifier
- Enter three side lengths
- System identifies triangle type:
  - Equilateral: All sides equal
  - Isosceles: Two sides equal
  - Scalene: No sides equal

## Project Structure

```
Program/
├── Program.cs              # Main application entry point
├── Program.csproj          # Project configuration
├── TicketPriceCalculator.cs # Ticket pricing logic
└── TriangleTypeIdentifier.cs # Triangle identification logic
```

## Implementation Details

### Main Program (`Program.cs`)
- Implements the main menu interface
- Handles user input and navigation
- Contains grade calculation logic

### Ticket Price Calculator (`TicketPriceCalculator.cs`)
- Static class with age-based pricing logic
- Input validation and error handling
- Price calculation based on age brackets

### Triangle Type Identifier (`TriangleTypeIdentifier.cs`)
- Static class for triangle classification
- Side length validation
- Triangle type determination logic

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details