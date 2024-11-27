PDP Deliveries Booking System

Overview
The PDP Deliveries Booking System is a C# application developed to streamline parcel delivery bookings for a new courier company, PDP. This project showcases my ability to design and implement robust software solutions using object-oriented programming, data validation, and file handling techniques. Initially developed as coursework, this project now serves as an example of my practical skills in creating functional, user-friendly applications.

The system enables customers to:

Enter personal details and choose delivery preferences.
View delivery options, parcel count, delivery costs, insurance options, and final pricing (including VAT).
Apply discounts for regular business customers using a promotional code.
Process bookings, creating and storing detailed customer booking records.
Additionally, the enhanced version introduces an admin section with restricted access, allowing authorized users to view and manage bookings efficiently.

Key Features

Core Functionality:

Welcome Screen: Displays an introductory screen to the user.

Booking Screen:
Prompts customers to input their details and select delivery preferences.
Reads delivery charges dynamically from a CSV file.
Validates all user input to ensure accuracy and completeness.

Booking Summary:
Displays a breakdown of the booking, including delivery costs and discounts.
Applies VAT and calculates the total cost of the delivery.

Enhancements:

Admin Section:
Protected by a password stored in a CSV file.
Allows admins to view all customer bookings and manage records.
Displays statistics, such as the total number of bookings on a given day.

Unique Customer Booking Numbers:
Automatically generated in the format: [First 4 letters of surname][8-digit unique ID], e.g., SMIT23347663.

Discount Management:
Applies discounts for business customers (5% off orders over £50 and 10% off orders over £100).

Data Persistence:
Saves all bookings for the day to a CSV file, ensuring records are available for future reference.
Programming Principles Demonstrated

Object-Oriented Programming (OOP):
Use of instantiable classes to encapsulate customer details, delivery options, and booking data.

Modular Programming:
Independent methods and functions ensure reusability and separation of concerns.

File Handling:
Reading and writing to CSV files for dynamic data retrieval and persistence.

Data Validation:
Ensures input meets predefined criteria to prevent errors or invalid entries.

Dynamic Calculations:
Delivery charges, VAT, and discounts are calculated in real-time based on user inputs.

Authentication:
Implements password protection for admin functionalities, emphasizing secure design practices.

This project highlights my ability to create a complete, real-world application that balances functionality, usability, and code maintainability. Explore the codebase to see these principles in action.
