# samples
Repository to test sample architectures.

## Simple Architecture
Sample Application using several different technologies in the UI layer to utilize the services, models, and repositories in the other projects.  Will contain some basic UserID capabilities.

### SimpleArchitecture.Models
Contains the Models that will be used at all levels of the application.  No business logic here. 

### SimpleArchitecture.Services
Contains the Tasks that the Application can do. Contains the Business and Validation logic.

### SimpleArchitecture.DataAccess
Contains only the code needed for persistance of data.

## UI Projects

### SimpleArchitecture.RazorPages
Simple Application to View and Edit Users.  Uses the Built in dependency Injection framework to inject the needed service and repository to each Page.

### SimpleArchitecture.Mvc
Simple Application to View and Edit Users.  Uses the Built in dependency Injection framework to inject the needed service and repository to each Controller. 
Used the default View Scaffolding function to design each view.

### SimpleArchitecture.Api
Simple API to View and Edit Users.  Uses the Built in dependency Injection framework to inject the needed service and repository to each Controller. 
Used Swagger to add an easy to use/test frontend.

### SimpleArchitecture.Angular
Simple Angular App to View Users still trying to figure out the edit part.  Uses the Built in dependency Injection framework to inject the needed service and repository to each Controller. 
The default Microsoft Angular Template creates a built in API.
