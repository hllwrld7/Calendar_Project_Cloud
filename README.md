# Calendar Project Cloud
A calendar project for my IoT and Cloud Computing classes.

- [About](#about)
- [How to use](#how-to-use)
- [Calendar](#calendar)
	- [Adding appointment](#adding-appointment)
	- [Editing appointment](#editing-appointment)
	- [Deleting appointment](#deleting-appointment)
- [Contacts](#calendar)
	- [Adding a contact](#adding-a-contact)
	- [Editing a contact](#editing-a-contact)
	- [Deleting a contact](#deleting-a-contact)

## About
This is a project made with ASP .NET Web API as a backend deployed in Azure Cloud with a WinForms frontend. The data is saved in an SQLite database.

## How to use
Build the Client project OR download the latest frontend artifacts and run Client.exe, it is the frontend and you can use it to schedule appointments and make a contact list. Swagger is available at https://calendarapi20240211220716.azurewebsites.net/swagger/index.html.

## Calendar

### Adding appointment
Choose a date on the calendar and click "Add appointment". Fill in the information and click "Confirm".

### Editing appointment
Choose a date on the calendar and click on the existing appointment. Click "Edit" and then "Confirm".

### Deleting appointment
Choose a date on the calendar and click on the existing appointment. Click "Delete".

## Contacts

### Adding a contact
Click "Add", fill in the required information (note that the phone number and email should be in the correct format) and click "Save".

### Editing a contact
Choose an existing contact and click "Edit". After editing click "Confirm".

### Deleting a contact
Choose an existing contact and click "Delete".
