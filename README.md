# UserDetaisApp

In this project, I have included a script that creates a database, does a migration and seeds dummydata when running the program. The only modifications that needs to be done should be in the appsettings.json file, there is a DefaultConnections string which have been set as null, the below should replace the "null" with all the correct details inorder to connect to the server:

server=server name(localhost\\SQLEXPRESS);
user=your sql server username(usually root);
database=UsersDB;
password=your sqlserver password;
Trusted_Connection=True;
MultipleActiveResultSets=True

Then once saved, run the project and it should build, connect to server, create database and table, populate accordingly and dispaly on localhost.

You should then be able to edit, add and delete a user as desired.
