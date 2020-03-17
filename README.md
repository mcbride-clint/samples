# samples
Repository to test sample architectures.

## Simple Architecture
Sample Application using Razor Pages in the UI layer to utilize the services, models, and repositories in the other projects.  Will contain some basic UserID and Page Maintenance capabilities.

### SimpleArchitecture.Models
Contains the Models that will be used at all levels of the application.  No business logic here. 

### SimpleArchitecture.Services
Contains the Tasks that the Application can do. Contains the Business and Validation logic.

### SimpleArchitecture.DataAccess
Contains only the code needed for persistance of data.

## SimpleArchitecture.RazorPages
Simple Application to View and Edit Users.  Uses the Built in dependency Injection framework to inject the needed service and repository to each Page.

