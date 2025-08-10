# EventEaseApp - Event Creation & Management

## 📌 Overview
**EventEaseApp** is a Blazor Server application that allows users to create, view, and manage events.  
It uses an `IEventService` backend to store and retrieve event data, supporting full form validation, dynamic UI updates, and interactive server-side rendering.

---

## ✨ Features
- **Create Events** – Add a new event with:
  - Name
  - Date
  - Location
  - Time
- **Form Validation** – Uses Data Annotations to validate user input.
- **List of Events** – Displays all created events in styled Bootstrap cards.
- **Delete Events** – Remove events instantly with a click.
- **Debug Info Section** – Displays live diagnostics for easier development and testing.

---

## 🖼️ Screenshots

<p align="center">
  <img src="https://github.com/user-attachments/assets/586fa7d6-f2c4-400c-a4d2-d93aa1cea5a8" alt="EventPic1" width="45%" style="border-radius: 15px; margin-right: 10px;" />
  <br>
  <img src="https://github.com/user-attachments/assets/ec183dcb-7334-4f81-af65-cdc71d7ad022" alt="EventPic2" width="45%" style="border-radius: 15px;" />
</p>

---

## 🚀 Technologies Used
- **.NET 8** / Blazor Server
- **C#** for backend logic
- **Razor Components** for UI
- **Bootstrap 5** for styling
- **Dependency Injection** for service access
- **System.Globalization** for date formatting

---



## ⚙️ How It Works
1. **Form Binding**
   - The `<EditForm>` component binds to a `NewEvent` object.
   - Validation is handled using `<DataAnnotationsValidator>` and `<ValidationMessage>`.

2. **Adding an Event**
   - When the user submits the form, `HandleSubmit()` calls `EventService.AddEventAsync()` to save the event.
   - The events list is refreshed via `GetEventsAsync()`.

3. **Deleting an Event**
   - The delete button triggers `DeleteEvent(evt.Id)`.
   - The event is removed from storage, and the UI updates in real time.

4. **UI Updates**
   - Uses `StateHasChanged()` to force the component to re-render after operations.

---

## 🛠️ Setup & Run
1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/EventEaseApp.git
   cd EventEaseApp

