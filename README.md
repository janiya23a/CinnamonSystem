🗄️ Database Setup Guide (Local XAMPP)
To run the CGPS (Cinnamon Grading and Payout System) on your local machine, you must set up the MySQL database first. Follow these exact steps:

Step 1: Start XAMPP
Open your XAMPP Control Panel.

Click Start next to Apache.

Click Start next to MySQL.

Step 2: Open phpMyAdmin

Open your web browser (Chrome, Edge, etc.).

Type http://localhost/phpmyadmin into the search bar and hit Enter.

Step 3: Create the Database

On the left side panel, click New.

Under "Database name", type exactly: cinnamon_db

Click the Create button.

Step 4: Run the SQL Query to Create the Table
Instead of creating columns manually, just copy and paste this code!

Click on your new cinnamon_db database on the left.

Click the SQL tab at the top of the screen.

Copy and paste the following SQL code into the white box:

```sql
CREATE TABLE grading_records (
id INT AUTO_INCREMENT PRIMARY KEY,
worker_name VARCHAR(100) NOT NULL,
diameter DOUBLE NOT NULL,
weight DOUBLE NOT NULL,
moisture DOUBLE NOT NULL,
grade VARCHAR(50) NOT NULL,
payout DOUBLE NOT NULL
);
```


Click the Go button at the bottom right to execute it.

Step 5: Run the Application
Your database is now ready! You can open the project in Visual Studio and click Start. The C# application will now successfully connect and save records.
