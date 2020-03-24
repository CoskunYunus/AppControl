# Scenario
You are developing a web application to monitor target applications’ health. It takes a URL as input and periodically checks whether it’s up or not. It sends a notification message when a request to the URL returns a response code other than 2XX.

=> The user should be able to create/update target apps.

=> The user should be able to configure a name and URL for the target app.

=> The user should be able to configure a monitoring interval for the target app.

=> A notification should be sent if the target app is down. Currently an email notification will be enough, but it should be easy to add another notification types.
