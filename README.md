# AppControl

Scenario:
 
You are developing a web application to monitor target applications’ health. It takes a URL as input and periodically checks whether it’s up or not. It sends a notification message when a request to the URL returns a response code other than 2XX.
 
The user should be able to create/update target apps.
The user should be able to configure a name and URL for the target app.
The user should be able to configure a monitoring interval for the target app.
A notification should be sent if the target app is down. Currently an email notification will be enough, but it should be easy to add another notification types.
 
 
Objectives:
 
There should be a UI which needs to be developed with ASP.NET Core MVC and Bootstrap. (Minimal amount of UI is enough but good usability options(AJAX etc.) are bonus.)
Entities should be persisted to a database via Entity Framework
You are free to use any library you want for your needs.
All unexpected errors should be logged and easily accessible.
The application should support multiple user accounts, design it accordingly.
The application should be as stable as possible and well tested.
Create a repository for this project on github.com or bitbucket.com and send us the link when you are done.
