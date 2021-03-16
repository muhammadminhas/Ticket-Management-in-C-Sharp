# Railway Ticket Management Program

## What does The program do?
### This is a railway ticket managment program writen in C# which Basically takes the customer information and print them a ticket recipt.

## How is code written and the Concepts used?
### The main concepts used in the program are classes,arraylist and File handling.Classes are to give specific functionalities to different objects.
### Array list is used to store the informations like name,destination and ticket recipt number.
```csharp
ArrayList tnos = new ArrayList();
ArrayList names = new ArrayList();
ArrayList dest = new ArrayList();
```
### File handling is used to print the recipt of the Ticket which consist of the information about the Customer and the ticket no.
```csharp
FileStream fs = new FileStream("ticketRecipt.txt", FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            
```

### 

## Main Menu

Menu gives the user Four options
* Book Ticket
* Delete Ticket
* View Tickets
* Exit
### Book Ticket:
 When you Select Book ticket it intially asks for your Name and Destination and ticket is generated on that basis.

### Delete Ticket:
When Delete Ticket option is selected it displays all the tickets and ask you which ticket do you want to delete and deletes it accordingly.

### View Tickets:
This option displays all the tickets booked.

### Exit:
 You can exit the program by selecting this option otherwise the Program runs Till it is exited.