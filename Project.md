# Online Travel & Hospitality Booking System - Summary

## System Overview
- [ ] Develop a comprehensive platform for booking hotels, flights, and holiday packages.
- [ ] Provide management capabilities for hotel managers and travel agents.
- [ ] Support backend development using C# (.NET Core) and frontend development using Angular.

## Architecture
- [ ] **Frontend**: Use Angular.
- [ ] **Backend**: Implement REST API-based architecture using .NET Core.
- [ ] **Database**: Use a relational database (MySQL/PostgreSQL/SQL Server).
- [ ] **Component Interaction**: Ensure frontend communicates with backend via REST APIs.

## Modules

### 1. User & Role Management
- [ ] **Features**:
    - [ ] Implement user authentication using JWT tokens and OAuth2.
    - [ ] Enable role-based access control (Admin, Traveler, Hotel Manager, Travel Agent).
    - [ ] Provide secure profile management.
- [ ] **Data Flow**:
    - [ ] Allow users to register and log in.
    - [ ] Assign role-based permissions.
    - [ ] Enable admin to manage user accounts and permissions.
- [ ] **Entities**:
    - [ ] Define User (UserID, Name, Email, Password, Role, ContactNumber).

### 2. Hotel & Flight Booking
- [ ] **Features**:
    - [ ] Allow users to search and book hotels/flights based on location and dates.
    - [ ] Display availability, pricing, and customer reviews.
    - [ ] Generate booking confirmation and e-tickets.
- [ ] **Data Flow**:
    - [ ] Enable users to search for availability.
    - [ ] Fetch data from the database.
    - [ ] Allow users to confirm bookings and proceed to payment.
- [ ] **Entities**:
    - [ ] Define Hotel (HotelID, Name, Location, RoomsAvailable, Rating, PricePerNight).
    - [ ] Define Flight (FlightID, Airline, Departure, Arrival, Price, Availability).
    - [ ] Define Booking (BookingID, UserID, Type[Hotel/Flight], Status, PaymentID).

### 3. Package & Itinerary Management
- [ ] **Features**:
    - [ ] Allow travel agents to create/sell vacation packages.
    - [ ] Provide customizable itineraries for travelers.
- [ ] **Data Flow**:
    - [ ] Enable agents to define packages (hotels, flights, activities).
    - [ ] Allow travelers to browse and book packages.
    - [ ] Generate complete itineraries for travelers.
- [ ] **Entities**:
    - [ ] Define Package (PackageID, Name, IncludedHotels, IncludedFlights, Activities, Price).
    - [ ] Define Itinerary (ItineraryID, UserID, PackageID, CustomizationDetails).

### 4. Payment & Billing
- [ ] **Features**:
    - [ ] Implement secure online payments, invoices, and refunds.
    - [ ] Integrate with payment gateways (Stripe, PayPal, Razorpay).
    - [ ] Support multi-currency transactions and tax calculations.
- [ ] **Entities**:
    - [ ] Define Payment (PaymentID, UserID, BookingID, Amount, Status, PaymentMethod).
    - [ ] Define Invoice (InvoiceID, BookingID, UserID, TotalAmount, Timestamp).

### 5. Review & Customer Support
- [ ] **Features**:
    - [ ] Allow users to leave ratings and reviews.
    - [ ] Provide an integrated support system for complaints/queries.
- [ ] **Entities**:
    - [ ] Define Review (ReviewID, UserID, HotelID, Rating, Comment, Timestamp).
    - [ ] Define SupportTicket (TicketID, UserID, Issue, Status, AssignedAgent).

## Database Design
- [ ] Design tables for User, Hotel, Flight, Booking, Package, Itinerary, Payment, Invoice, Review, and SupportTicket.
- [ ] Define relationships between entities.

## User Interface
- [ ] Develop a Traveler Dashboard for searching/booking hotels, flights, and packages using Angular.
- [ ] Create a Hotel Manager Dashboard for managing rooms, pricing, and availability using Angular.
- [ ] Build a Travel Agent Dashboard for creating/selling travel packages using Angular.
- [ ] Implement an Admin Panel for managing users, bookings, and queries using Angular.

## Non-Functional Requirements
- [ ] **Performance**: Ensure support for 10,000+ concurrent users.
- [ ] **Security**: Achieve PCI-DSS compliance and implement JWT/OAuth2 authentication.
- [ ] **Usability**: Design a mobile-friendly UI with real-time updates.

## Assumptions & Constraints
- [ ] Ensure hotels update availability every 24 hours.
- [ ] Enforce booking cancellations to follow policy limits.
- [ ] Handle real-time transactions effectively.
- [ ] Retain user history data for 5 years.

## Sub Issues: Notifications, Stripe Integration, and Email E-Tickets/Bills

### 1. Notifications

#### Backend
- Implement a notification service in the backend using .NET Core.
- Define a `Notification` entity:
    - `NotificationID`, `UserID`, `Type` [Booking, Payment, Support], `Message`, `Timestamp`, `Status` [Read/Unread].
- Create APIs to manage notifications:
    - Create, fetch, mark as read/unread.
- Integrate event triggers for notifications:
    - Booking confirmation, payment success, support ticket updates.
- Ensure notifications are stored in the database for viewing history.

#### Frontend
- Display notifications in the Traveler Dashboard, Hotel Manager Dashboard, and Admin Panel.
- Add real-time notification support using SignalR or WebSocket in Angular.
- Implement a bell icon with a dropdown for unread notifications.
- Add a "View All Notifications" page for users to view their notification history.
- Provide visual and audio cues for new notifications.

---

### 2. Stripe Integration for Payment

#### Backend
- Integrate the Stripe SDK in the .NET Core backend.
- Configure API keys securely using environment variables.
- Create backend endpoints for:
    - Initiating payments, verifying payment status, and handling webhooks.
- Support transactions for multiple currencies.
- Ensure proper error handling for payment failures and retries.
- Store transaction details in the `Payment` entity.

#### Frontend
- Create a payment form using Angular to collect card details securely.
- Use Stripe Elements or Checkout for secure and PCI-compliant card inputs.
- Display payment success/failure messages to users.
- Add a loading spinner during payment processing.

---

### 3. Email E-Tickets and Bills

#### Backend
- Use a library like SendGrid or MailKit for email service in .NET Core.
- Define email templates for:
    - E-tickets, invoices, and booking confirmations.
- Generate PDF e-tickets and bills using a library like iTextSharp or DinkToPdf.
- Implement a service to send emails after successful booking/payment.
- Log email delivery status for auditing purposes.

#### Frontend
- Provide an option for users to resend e-tickets and bills from their dashboard.
- Display a confirmation message after an email is sent successfully.
- Allow users to download e-tickets and bills directly from their booking details page.


dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Newtonsoft.Json
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.AspNetCore.SignalR
dotnet add package Microsoft.AspNetCore.SignalR.Client
dotnet add package Stripe.net
dotnet add package SendGrid
dotnet add package DinkToPdf
dotnet add package Serilog
dotnet add package Serilog.AspNetCore