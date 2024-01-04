The project includes creating restful api and integreting them with a web project and wfp application
Step 1: Open API Project.sln 
Step 2: Run package manager console on project DAL then run migrations to update database. Connection string is required for the database connection.
Step 3: Run project API to start the routes.
Step 4: Run package manager console on project WebProject then run migrations to update database. Connection string is required for the database connection.
Step 5: Run project WebProject for webview of api with login, registration. Step 6: Run project WPF to start the application and perform CRUD operations.
Note: The project database is code first basis. You will need to use entity framwork and migration commands to create database.

All features: 3 relational tables, 1 table for admin login. RESTful api of data view, search, create, update, delete. Webview of login, registration with views of own created api.
WPF application with CRUD operations and gridview of the entire table using own created api. The api project uses repository pattern and dependency injection.

Packages installed: Microsoft.aspnet.webapi.cors Microsoft.aspnet.webapi.client Entity.Framework
