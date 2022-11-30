The main idea behind this project was to simply help me get better aquainted with creating an api with a few endpoint that can create, delete, update or view items from a database. This, much like project one, focuses on creating objects that contain a few fields and store them in a database. Technologies used:
- Microsoft SQL Express Server
- Microsoft Entity Framework Core
- ASP.Net Core Web API
- C#
- SwaggerUI
We will have a data context consisting of an Issue, that contains:
- Unique ID         -INT
- Title             -String
- Description       -String
- Severity          -String
- IssueType         -String
- Created Date
- Completed Date
The api will store the data into a local sql server database and we will be able to perform basic operations stated above using the SwaggerUI. 