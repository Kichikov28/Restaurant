# Restaurant
If you want to try this project follow these steps:

Download the project and load the solution then go to the AppDbContext and in the connection string replace the server name with the name of your own SSMS server.

Then you have to do some migrations (paste in the Package Manage Console the following command: "Add-Migration InitialMigration -OutputDir Data/Migrations -Project Restaurant.Data -StartupProject Restaurant.Data"). After successfully adding the migration, paste this command: "Update-Database -Project Restaurant.Data -StartupProject Restaurant.Data".

The next step is to start the seeder to fill the database...

Everything is done, now you can test the whole project: ConsoleApp, FormApp and WebApp.

Now you can make your order to make your stomach happy!
