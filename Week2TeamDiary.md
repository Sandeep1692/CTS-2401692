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
### Authentication and Security  

#### Copy Login Token from Swagger  
```plaintext
eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9lbWFpbGFkZHJlc3MiOiJhZG1pbkBzYW5kZWVwLmNvbSIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IlJlYWRlciIsImV4cCI6MTc0NDAyNjQxNSwiaXNzIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NzIyNiIsImF1ZCI6Imh0dHBzOi8vbG9jYWxob3N0OjQyMDAifQ.IBVTLy0dFHl3zmsrpbrO7yQPMYTmLcTZuSIabBjr4kE
```

#### Generate a HEX Key  
Use the following tool to generate a secure HEX key:  
[Generate HEX Key](https://asecuritysite.com/encryption/js01)  

### Example HEX Key  
```plaintext
B0DFA65367A758E0829C5F674A981C1CC992467EBC6801DE1007149EE83A8D3C
```

### Running the Angular Project  

#### Install Angular CLI Globally  
```bash
npm install -g @angular/cli
```

#### Install Project Dependencies  
```bash
npm install
```

#### Start the Angular Development Server  
```bash
ng serve
```

Alternatively, you can use:  
```bash
npm run start
```

---

### TODO  

1. **Add a "Register" Feature**  
    - Implement a user registration feature in the web app to allow new users to sign up.  
    - Ensure proper validation, secure password storage, and email verification.  

2. **Enhance Token Security**  
    - Use the generated HEX key to strengthen token encryption.  
    - Update the backend to validate tokens using the new key.  
    - Rotate keys periodically and implement a secure key management system.  

3. **Improve User Roles**  
    - Expand role-based access control to include additional roles like `Admin`, `Editor`, and `Viewer`.  
    - Ensure each role has appropriate permissions and access restrictions.  
    - Add a user interface for managing roles and permissions.  

4. **Audit Logs**  
    - Add logging to track user activities such as login attempts, data modifications, and API usage.  
    - Store logs securely for auditing purposes and ensure compliance with data protection regulations.  
    - Implement a log viewer in the admin dashboard for easy monitoring.  

5. **Enhance UI/UX**  
    - Improve the overall design and responsiveness of the web app.  
    - Add animations and transitions for a better user experience.  
    - Conduct usability testing to identify and address pain points.  

6. **Optimize Performance**  
    - Analyze and optimize API response times.  
    - Implement lazy loading for Angular modules to reduce initial load time.  
    - Use caching mechanisms to improve data retrieval efficiency.  

7. **Add Unit and Integration Tests**  
    - Write unit tests for critical components and services in the Angular app.  
    - Add integration tests to ensure seamless interaction between the frontend and backend.  
    - Use tools like Jasmine and Karma for testing Angular components.  

8. **Documentation**  
    - Create detailed documentation for the project, including setup instructions, API endpoints, and usage guidelines.  
    - Add inline comments in the codebase to improve maintainability.  

---

> **Note:** Regularly review and update the TODO list to align with project goals and timelines.

