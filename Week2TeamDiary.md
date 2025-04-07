## Morning Session  
### April 7, 2025  

### Topics Covered:  
1. **SQL Queries Practice**  
    - Conducted hands-on exercises to improve SQL query writing skills.  
    - Focused on optimizing queries for better performance.  
2. **SQL Server Management Studio**  
    - Explored advanced tools and features for efficient database management.  
    - Discussed best practices for database maintenance.  
3. **C# Daily Practice**  
    - Continued daily programming tasks to strengthen C# proficiency.  
    - Solved real-world problems to enhance coding skills.  
4. **GitHub and Project Management**  
    - Collaborated on team projects and ensured regular updates.  
    - Reviewed pull requests and discussed version control strategies.  

---

## Afternoon Session  

### Activities:  
1. **Udemy Course Progress**  
    - Advanced through selected Udemy courses to expand technical knowledge.  
    - Completed modules on advanced programming concepts.  
2. **TecStak Learning**  
    - Leveraged TecStak resources for skill enhancement and learning.  
    - Practiced exercises to reinforce newly acquired skills.  
3. **Doubt Clearing Session**  
    - Addressed questions and clarified concepts for better understanding.  
    - Conducted peer discussions to resolve complex queries.  
4. **Blogging Project Exploration**  
    - Progressed on a blogging platform using **.NET** and **Angular**.  
    - Implemented new features and improved UI/UX design.  
5. **Blazor Project Exploration**  
    - Developed and tested features for a project using **.NET** and **Blazor**.  
    - Focused on component-based architecture and state management.  

---

## Useful Links for Today  

1. [Practice MS SQL Database with DC Comics Characters](https://vijayasimhabr.medium.com/practice-ms-sql-database-with-dc-comics-characters-d2d8c68025e1)  
    - Practice SQL with a fun DC Comics dataset.  
2. [BungieCord Blog](https://jay-study-nildana.github.io/BungieCordBlog/)  
    - Explore insights and tutorials on various tech topics.  
3. [SQL Fundamentals GitHub Repository](https://github.com/Jay-study-nildana/Azure-CSharp-Corp-Trainer-Syllabus/tree/main/SQLFundamentals)  
    - Access comprehensive SQL learning resources.  
4. [Blazor for Students GitHub Repository](https://github.com/Jay-study-nildana/BlazorForStudents)  
    - Learn Blazor development with beginner-friendly guides.  

---

## Additional Notes  

### SQL Credentials  
- **Username:** `admin`  
- **Password:** `sandeep`  

### Steps to Run the Project  

#### Backend Setup (Web API)  
1. Navigate to the WebAPI directory:  
    `M:\CTS-2401692\CTS-Training\April-07-2025\BungieCordBlogWebAPI`.  
2. Open the Web API project in Visual Studio.  
3. Update the `ConnectionString` in the configuration file to match your database setup.  
4. Run the following commands in the Package Manager Console to update the database:  
    - `Update-Database -Context ApplicationDbContext`  
    - `Update-Database -Context AuthDbContext`  
5. Update the `Key` in the configuration file with a 256-bit secret string.  
6. Start the Web API project in Visual Studio.  

#### Frontend Setup (Angular Project)  
1. Navigate to the Angular project directory.  
2. Install dependencies:  
    ```bash
    npm install
    ```  
3. Start the Angular project:  
    ```bash
    ng serve
    ```  
    Or alternatively:  
    ```bash
    npm run start
    ```  

#### Connecting Backend to Frontend  
1. Ensure the API URI of the Web API matches the `apiBaseUrl` in the frontend app's configuration.  

#### Testing and Usage  
1. Register a user via Swagger or Postman.  
2. Log in to the web app using the default admin credentials:  
    - **Email:** `admin@BungieCordBlog.com`  
    - **Password:** `Password@6969`  
3. Create a category in the web app.  
4. Proceed to create blog posts.  
### Connection String Examples  
- `Server=LTIN618032;Database=BungieCordBlogDB;TrustServerCertificate=True;User Id=admin;Password=<ENCRYPTED_PASSWORD>;`  
- `Server=(localdb)\\MSSQLLocalDB;Database=BungieCordBlogDBApril72025a;Trusted_Connection=True;User Id=admin;Password=<ENCRYPTED_PASSWORD>;`  
- `Server=(localdb)\\MSSQLLocalDB;Database=BungieCordBlogDBApril72025a;TrustServerCertificate=True;User Id=admin;Password=<ENCRYPTED_PASSWORD>;`  
- `Server=localhost\\SQLEXPRESS;Database=BungieCordBlogDBApril72025a;Trusted_Connection=True;User Id=admin;Password=<ENCRYPTED_PASSWORD>;`  
- `Server=localhost\\SQLEXPRESS;Database=BungieCordBlogDBApril72025b;TrustServerCertificate=True;User Id=admin;Password=<ENCRYPTED_PASSWORD>;`  

> **Note:** Replace `<ENCRYPTED_PASSWORD>` with the actual encrypted password or use a secure method to retrieve it at runtime.

### TODO  
- Add a "Register" feature to the web app for user registration.  
