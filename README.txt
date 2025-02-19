*** Tools for build this Project:
1. Microsoft Visual Studio
-> Used for developing the program in C# Language.
2. Microsoft SQL Server 2018
-> Acts as the database backend for managing and storing data.



*** How to Run the Program
**(Login Username: Admin, Password: Admin123)**
1. Open project file on Microsoft Visual look for (Data Connection) and find file name(mystoresystem.mdf) right click select on properties and on the right side find connection string and "Copy" connection. 

2. Next go to fine file name (DBConnect.cs) open  private SqlConnection connection = new SqlConnection(@"(past part that copy from "connection string" )") and run the program



***Features
1. Login form: only for admin: Username(Admin), Password(Admin123)
2. Category form : Create category (ID, Name, Description) and have button(Update, Add, Delete)
3. Product form : Create product and select type if category that created in Category form (ID, Name, Price, Quantity, select type category) and have button(Update, Add, Delete)
4. Selling form: Selling products that created from Product form and can insert name of product to order and have sell list to show product that order by input id in bill



