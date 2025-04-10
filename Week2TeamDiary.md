## Points: 76  
## April 9,2025
### Morning Session  

1. **SQL Views, Stored Procedures, and Index**  
    - Explored the creation and usage of SQL views for simplifying complex queries.  
    - Practiced writing stored procedures for reusable database operations.  
    - Learned about indexing strategies to optimize query performance.  

2. **SQL Server Management Studio**  
    - Continued exploring advanced tools and features for efficient database management.  
    - Discussed best practices for database maintenance and troubleshooting.  

3. **C# Daily Practice**  
    - Continued daily programming tasks to strengthen C# proficiency.  
    - Solved real-world problems to improve coding and debugging skills.  

4. **GitHub and Project Management**  
    - Collaborated on team projects with regular updates and version control.  
    - Reviewed pull requests and refined strategies for effective project management.  

---

### Afternoon Session  

1. **Udemy Course Progress**  
    - Advanced through selected Udemy courses to deepen technical expertise.  
    - Completed modules on advanced programming concepts and design patterns.  

2. **TecStak Learning**  
    - Utilized TecStak resources for skill enhancement and hands-on practice.  
    - Reinforced newly acquired skills through targeted exercises.  

3. **Doubt Clearing Session**  
    - Addressed team queries and clarified complex concepts for better understanding.  
    - Conducted peer discussions to collaboratively resolve challenging problems.  

4. **Blogging Project Exploration**  
    - Made significant progress on a blogging platform using **.NET** and **Angular**.  
    - Implemented new features, enhanced UI/UX design, and improved code quality.  

5. **Blazor Project Exploration**  
    - Developed and tested features for a project using **.NET** and **Blazor**.  
    - Focused on component-based architecture, state management, and performance optimization.  

---

### Useful Links for Today  

1. [Practice MS SQL Database with DC Comics Characters](https://vijayasimhabr.medium.com/practice-ms-sql-database-with-dc-comics-characters-d2d8c68025e1)  
    - Practice SQL with a fun and engaging DC Comics dataset.  

2. [BungieCord Blog](https://jay-study-nildana.github.io/BungieCordBlog/)  
    - Explore insightful tutorials and articles on various tech topics.  

3. [SQL Fundamentals GitHub Repository](https://github.com/Jay-study-nildana/Azure-CSharp-Corp-Trainer-Syllabus/tree/main/SQLFundamentals)  
    - Access comprehensive SQL learning resources and examples.  

4. [Blazor for Students GitHub Repository](https://github.com/Jay-study-nildana/BlazorForStudents)  
    - Learn Blazor development with beginner-friendly guides and projects.  
## Steps  

### Include Packages  
Add the following package references to your project file:  
```xml
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.12" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.12" />
```
### Install Packages from NuGet Package Manager  
1. Open the **NuGet Package Manager** in Visual Studio.  
2. Search for the required packages and select the correct version.  
3. Install the following packages:  
    - `Microsoft.EntityFrameworkCore.SqlServer`  
    - `Microsoft.EntityFrameworkCore.Tools`  

### Create a Class in Models >> Domain  
1. Navigate to the `Models` folder in your project.  
2. Create a new folder named `Domain`.  
3. Add a new class file to the `Domain` folder to define your domain model.  

### Create ApplicationDbContext for the Model  
1. Add a new class named `ApplicationDbContext` in your project.  
2. Inherit from `DbContext` and configure the model.  
    
3. Update the `Program.cs` file to register the `ApplicationDbContext` in the dependency injection container.  
    - Example:  
      ```csharp
      services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
      ```
### Define Connection String in `appsettings.json`

To configure the connection string for your database, add the following entry in the `appsettings.json` file:

```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=LTIN618032;Database=BungieCordBlogDB;TrustServerCertificate=True;User Id=admin;Password=<ENCRYPTED_PASSWORD>;"
    }
}
```

> **Note:** Replace `<ENCRYPTED_PASSWORD>` with the actual encrypted password or use a secure method to retrieve it at runtime.

```
### Connection String  
Use the following connection string to configure your database:  
```plaintext
Server=LTIN618032;Database=BungieCordBlogDB;TrustServerCertificate=True;User Id=admin;Password=<ENCRYPTED_PASSWORD>;
```

> **Note:** Replace `<ENCRYPTED_PASSWORD>` with the actual encrypted password or use a secure method to retrieve it at runtime.

```markdown
### Add Migration

In the **Package Manager Console**, type the following command to create the initial migration:

```bash
Add-Migration FirstMigration
```

> **Note:** Ensure that the `ApplicationDbContext` is correctly configured before running the migration command.
```
Run the following command in the **Package Manager Console** to apply the latest migrations to the database:

```bash
Update-Database
```

## April 8, 2025  

### Morning Session  

1. **SQL Queries Practice**  
    - Conducted hands-on exercises to enhance SQL query writing skills.  
    - Focused on query optimization techniques for improved performance.  

2. **SQL Server Management Studio**  
    - Explored advanced tools and features for efficient database management.  
    - Discussed best practices for database maintenance and troubleshooting.  

3. **C# Daily Practice**  
    - Continued daily programming tasks to strengthen C# proficiency.  
    - Solved real-world problems to improve coding and debugging skills.  

4. **GitHub and Project Management**  
    - Collaborated on team projects with regular updates and version control.  
    - Reviewed pull requests and refined strategies for effective project management.  

---

### Afternoon Session  

1. **Udemy Course Progress**  
    - Advanced through selected Udemy courses to deepen technical expertise.  
    - Completed modules on advanced programming concepts and design patterns.  

2. **TecStak Learning**  
    - Utilized TecStak resources for skill enhancement and hands-on practice.  
    - Reinforced newly acquired skills through targeted exercises.  

3. **Doubt Clearing Session**  
    - Addressed team queries and clarified complex concepts for better understanding.  
    - Conducted peer discussions to collaboratively resolve challenging problems.  

4. **Blogging Project Exploration**  
    - Made significant progress on a blogging platform using **.NET** and **Angular**.  
    - Implemented new features, enhanced UI/UX design, and improved code quality.  

5. **Blazor Project Exploration**  
    - Developed and tested features for a project using **.NET** and **Blazor**.  
    - Focused on component-based architecture, state management, and performance optimization.  

---
## Create Tables
--CREATE TABLE Superheroes (
--    SuperheroID INT PRIMARY KEY IDENTITY(1,1),
--    Name NVARCHAR(100) NOT NULL,
--    Alias NVARCHAR(100),
--    FirstAppearance DATE,
--    Publisher NVARCHAR(50) DEFAULT 'DC Comics'
--);

--CREATE TABLE Villains (
--    VillainID INT PRIMARY KEY IDENTITY(1,1),
--    Name NVARCHAR(100) NOT NULL,
--    Alias NVARCHAR(100),
--    FirstAppearance DATE,
--    Publisher NVARCHAR(50) DEFAULT 'DC Comics'
--);

--CREATE TABLE Teams (
--    TeamID INT PRIMARY KEY IDENTITY(1,1),
--    TeamName NVARCHAR(100) NOT NULL,
--    BaseOfOperations NVARCHAR(100)
--);

--CREATE TABLE VillainTeams (
--    VillainTeamID INT PRIMARY KEY IDENTITY(1,1),
--    TeamName NVARCHAR(100) NOT NULL,
--    BaseOfOperations NVARCHAR(100)
--);

--CREATE TABLE Comics (
--    ComicID INT PRIMARY KEY IDENTITY(1,1),
--    Title NVARCHAR(100) NOT NULL,
--    IssueNumber INT,
--    ReleaseDate DATE,
--    SuperheroID INT,
--    VillainID INT,
--    FOREIGN KEY (SuperheroID) REFERENCES Superheroes(SuperheroID),
--    FOREIGN KEY (VillainID) REFERENCES Villains(VillainID)
--);

--CREATE TABLE SuperheroTeams (
--    SuperheroID INT,
--    TeamID INT,
--    PRIMARY KEY (SuperheroID, TeamID),
--    FOREIGN KEY (SuperheroID) REFERENCES Superheroes(SuperheroID),
--    FOREIGN KEY (TeamID) REFERENCES Teams(TeamID)
--);

--CREATE TABLE VillainTeamMemberships (
--    VillainID INT,
--    VillainTeamID INT,
--    PRIMARY KEY (VillainID, VillainTeamID),
--    FOREIGN KEY (VillainID) REFERENCES Villains(VillainID),
--    FOREIGN KEY (VillainTeamID) REFERENCES VillainTeams(VillainTeamID)
--);

## Insert Tables
--INSERT INTO Superheroes (Name, Alias, FirstAppearance)
--VALUES
-- ('Clark Kent', 'Superman', '1938-06-01'),
--    ('Bruce Wayne', 'Batman', '1939-05-01'),
--    ('Diana Prince', 'Wonder Woman', '1941-12-01'),
--    ('Barry Allen', 'The Flash', '1956-10-01'),
--    ('Hal Jordan', 'Green Lantern', '1959-07-01'),
--    ('Arthur Curry', 'Aquaman', '1941-11-01'),
--    ('Victor Stone', 'Cyborg', '1980-10-01'),
--    ('John Constantine', 'Constantine', '1985-06-01'),
--    ('Billy Batson', 'Shazam', '1940-02-01'),
--    ('Oliver Queen', 'Green Arrow', '1941-11-01'),
--    ('Kara Zor-El', 'Supergirl', '1959-05-01'),
--    ('Jonn Jonzz', 'Martian Manhunter', '1955-11-01'),
--    ('John Stewart', 'Green Lantern', '1971-12-01'),
--    ('Zatanna Zatara', 'Zatanna', '1964-11-01'),
--    ('Dinah Lance', 'Black Canary', '1947-08-01');

--INSERT INTO Villains (Name, Alias, FirstAppearance)
--VALUES 
--    ('Lex Luthor', 'Lex Luthor', '1940-04-01'),
--    ('Joker', 'Joker', '1940-04-25'),
--    ('Harley Quinn', 'Harley Quinn', '1992-09-11'),
--    ('Cheetah', 'Cheetah', '1943-10-01'),
--    ('Black Manta', 'Black Manta', '1967-09-01'),
--    ('Reverse-Flash', 'Reverse-Flash', '1963-09-01'),
--    ('Sinestro', 'Sinestro', '1961-08-01'),
--    ('Deathstroke', 'Deathstroke', '1980-12-01'),
--    ('Darkseid', 'Darkseid', '1970-11-01'),
--    ('Brainiac', 'Brainiac', '1958-07-01');

--INSERT INTO Teams (TeamName, BaseOfOperations)
--VALUES 
--    ('Justice League', 'Hall of Justice'),
--    ('Teen Titans', 'Titans Tower'),
--    ('Suicide Squad', 'Belle Reve Penitentiary');

--INSERT INTO VillainTeams (TeamName, BaseOfOperations)
--VALUES 
--    ('Legion of Doom', 'Hall of Doom'),
--    ('Injustice League', 'Secret Base'),
--    ('Suicide Squad', 'Belle Reve Penitentiary');
--INSERT INTO Comics (Title, IssueNumber, ReleaseDate, SuperheroID, VillainID)
--VALUES 
--    ('Action Comics', 1, '1938-06-01', 1, 1), -- Superman vs Lex Luthor
--    ('Detective Comics', 27, '1939-05-01', 2, 2), -- Batman vs Joker
--    ('Wonder Woman', 1, '1941-12-01', 3, 4), -- Wonder Woman vs Cheetah
--    ('The Flash', 123, '1961-09-01', 4, 6), -- Flash vs Reverse-Flash
--    ('Green Lantern', 1, '1959-07-01', 5, 7), -- Green Lantern vs Sinestro
--    ('Aquaman', 35, '1967-09-01', 6, 5), -- Aquaman vs Black Manta
--    ('Teen Titans', 2, '1980-12-01', 7, 8); -- Cyborg vs Deathstroke
--INSERT INTO SuperheroTeams (SuperheroID, TeamID)
--VALUES 
--    (1, 1), -- Superman in Justice League
--    (2, 1), -- Batman in Justice League
--    (3, 1), -- Wonder Woman in Justice League
--    (4, 1), -- The Flash in Justice League
--    (5, 1), -- Green Lantern in Justice League
--    (6, 1), -- Aquaman in Justice League
--    (7, 1), -- Cyborg in Justice League
--    (8, 1), -- Constantine in Justice League
--    (9, 1), -- Shazam in Justice League
--    (10, 1), -- Green Arrow in Justice League
--    (11, 1), -- Supergirl in Justice League
--    (12, 1), -- Martian Manhunter in Justice League
--    (13, 1), -- John Stewart (Green Lantern) in Justice League
--    (14, 1), -- Zatanna in Justice League
--    (15, 1); -- Black Canary in Justice League
--INSERT INTO VillainTeamMemberships (VillainID, VillainTeamID)
--VALUES 
--    (1, 1), -- Lex Luthor in Legion of Doom
--    (2, 1), -- Joker in Legion of Doom
--    (3, 1), -- Harley Quinn in Legion of Doom
--    (4, 1), -- Cheetah in Legion of Doom
--    (5, 1), -- Black Manta in Legion of Doom
--    (6, 2), -- Reverse-Flash in Injustice League
--    (7, 2), -- Sinestro in Injustice League
--    (8, 2), -- Deathstroke in Injustice League
--    (9, 2), -- Darkseid in Injustice League
--    (10, 2); -- Brainiac in Injustice League
--INSERT INTO Comics (Title, IssueNumber, ReleaseDate, SuperheroID, VillainID)
--VALUES 
--    ('Superman', 75, '1992-11-18', 1, 1), -- Superman vs Lex Luthor
--    ('Batman', 251, '1973-09-01', 2, 2), -- Batman vs Joker
--    ('Wonder Woman', 200, '1972-05-01', 3, 4), -- Wonder Woman vs Cheetah
--    ('The Flash', 139, '1963-09-01', 4, 6), -- Flash vs Reverse-Flash
--    ('Green Lantern', 40, '1965-09-01', 5, 7), -- Green Lantern vs Sinestro
--    ('Aquaman', 57, '1977-03-01', 6, 5), -- Aquaman vs Black Manta
--    ('Teen Titans', 44, '1976-11-01', 7, 8), -- Cyborg vs Deathstroke
--    ('Justice League of America', 21, '1963-08-01', 1, 9), -- Justice League vs Darkseid
--    ('Justice League of America', 22, '1963-09-01', 2, 9), -- Justice League vs Darkseid
--    ('Action Comics', 252, '1959-05-01', 11, 10), -- Supergirl vs Brainiac
--    ('Detective Comics', 359, '1967-01-01', 2, 3), -- Batman vs Harley Quinn
--    ('Wonder Woman', 329, '1986-02-01', 3, 4), -- Wonder Woman vs Cheetah
--    ('The Flash', 110, '1959-12-01', 4, 6), -- Flash vs Reverse-Flash
--    ('Green Lantern', 87, '1971-12-01', 5, 7), -- Green Lantern vs Sinestro
--    ('Aquaman', 42, '1968-07-01', 6, 5), -- Aquaman vs Black Manta
--    ('Teen Titans', 44, '1976-11-01', 7, 8), -- Cyborg vs Deathstroke
--    ('Justice League of America', 29, '1964-08-01', 1, 9), -- Justice League vs Darkseid
--    ('Justice League of America', 30, '1964-09-01', 2, 9), -- Justice League vs Darkseid
--    ('Action Comics', 285, '1962-02-01', 11, 10), -- Supergirl vs Brainiac
--    ('Detective Comics', 474, '1977-12-01', 2, 3), -- Batman vs Harley Quinn
--    ('Wonder Woman', 300, '1983-02-01', 3, 4), -- Wonder Woman vs Cheetah
--    ('The Flash', 140, '1963-11-01', 4, 6), -- Flash vs Reverse-Flash
--    ('Green Lantern', 76, '1970-04-01', 5, 7), -- Green Lantern vs Sinestro
--    ('Aquaman', 48, '1970-02-01', 6, 5), -- Aquaman vs Black Manta
--    ('Teen Titans', 1, '1966-02-01', 7, 8), -- Cyborg vs Deathstroke
--    ('Justice League of America', 1, '1960-11-01', 1, 9), -- Justice League vs Darkseid
--    ('Justice League of America', 2, '1961-01-01', 2, 9), -- Justice League vs Darkseid
--    ('Action Comics', 500, '1979-10-01', 1, 1), -- Superman vs Lex Luthor
--    ('Detective Comics', 500, '1981-03-01', 2, 2), -- Batman vs Joker
--    ('Wonder Woman', 1, '1987-02-01', 3, 4), -- Wonder Woman vs Cheetah
--    ('The Flash', 1, '1987-06-01', 4, 6), -- Flash vs Reverse-Flash
--    ('Green Lantern', 1, '1990-06-01', 5, 7), -- Green Lantern vs Sinestro
--    ('Aquaman', 1, '1994-08-01', 6, 5), -- Aquaman vs Black Manta
--    ('Teen Titans', 1, '1996-10-01', 7, 8), -- Cyborg vs Deathstroke
--    ('Justice League', 1, '1987-05-01', 1, 9), -- Justice League vs Darkseid
--    ('Justice League', 2, '1987-06-01', 2, 9), -- Justice League vs Darkseid
--    ('Action Comics', 600, '1988-05-01', 1, 1), -- Superman vs Lex Luthor
--    ('Detective Comics', 600, '1989-05-01', 2, 2), -- Batman vs Joker
--    ('Wonder Woman', 2, '1987-03-01', 3, 4), -- Wonder Woman vs Cheetah
--    ('The Flash', 2, '1987-07-01', 4, 6), -- Flash vs Reverse-Flash
--    ('Green Lantern', 2, '1990-07-01', 5, 7), -- Green Lantern vs Sinestro
--    ('Aquaman', 2, '1994-09-01', 6, 5), -- Aquaman vs Black Manta
--    ('Teen Titans', 2, '1996-11-01', 7, 8), -- Cyborg vs Deathstroke
--    ('Justice League', 3, '1987-07-01', 1, 9), -- Justice League vs Darkseid
--    ('Justice League', 4, '1987-08-01', 2, 9), -- Justice League vs Darkseid
--    ('Action Comics', 700, '1994-06-01', 1, 1), -- Superman vs Lex Luthor
--    ('Detective Comics', 700, '1996-08-01', 2, 2), -- Batman vs Joker
--    ('Wonder Woman', 3, '1987-04-01', 3, 4), -- Wonder Woman vs Cheetah
--    ('The Flash', 3, '1987-08-01', 4, 6), -- Flash vs Reverse-Flash
--    ('Green Lantern', 3, '1990-08-01', 5, 7), -- Green Lantern vs Sinestro
--    ('Aquaman', 3, '1994-10-01', 6, 5), -- Aquaman vs Black Manta
--    ('Teen Titans', 3, '1996-12-01', 7, 8), -- Cyborg vs Deathstroke
--    ('Justice League', 5, '1987-09-01', 1, 9), -- Justice League vs Darkseid
--    ('Justice League', 6, '1987-10-01', 2, 9), -- Justice League vs Darkseid
--    ('Action Comics', 800, '2003-04-01', 1, 1), -- Superman vs Lex Luthor
--    ('Detective Comics', 800, '2005-05-01', 2, 2), -- Batman vs Joker
--    ('Wonder Woman', 4, '1987-05-01', 3, 4), -- Wonder Woman vs Cheetah
--    ('The Flash', 4, '1987-09-01', 4, 6), -- Flash vs Reverse-Flash
--    ('Green Lantern', 4, '1990-09-01', 5, 7), -- Green Lantern vs Sinestro
--    ('Aquaman', 4, '1994-11-01', 6, 5), -- Aquaman vs Black Manta
--    ('Teen Titans', 4, '1997-01-01', 7, 8), -- Cyborg vs Deathstroke
--    ('Justice League', 7, '1987-11-01', 1, 9), -- Justice League vs Darkseid
--    ('Justice League', 8, '1988-01-01', 2, 9), -- Justice League vs Darkseid
--    ('Action Comics', 900, '2011-06-01', 1, 1), -- Superman vs Lex Luthor
--    ('Detective Comics', 900, '2013-08-01', 2, 2), -- Batman vs Joker
--    ('Wonder Woman', 5, '1987-06-01', 3, 4), -- Wonder Woman vs Cheetah
--    ('The Flash', 5, '1987-10-01', 4, 6), -- Flash vs Reverse-Flash
--    ('Green Lantern', 5, '1990-10-01', 5, 7), -- Green Lantern vs Sinestro
--    ('Aquaman', 5, '1994-12-01', 6, 5), -- Aquaman vs Black Manta
--    ('Teen Titans', 5, '1997-02-01', 7, 8), -- Cyborg vs Deathstroke
--    ('Justice League', 9, '1988-02-01', 1, 9), -- Justice League vs Darkseid
--    ('Justice League', 10, '1988-04-01', 2, 9), -- Justice League vs Darkseid
--    ('Action Comics', 1000, '2018-04-01', 1, 1), -- Superman vs Lex Luthor
--    ('Detective Comics', 1000, '2019-03-01', 2, 2), -- Batman vs Joker
--    ('Wonder Woman', 6, '1987-07-01', 3, 4), -- Wonder Woman vs Cheetah
--    ('The Flash', 6, '1987-11-01', 4, 6), -- Flash vs Reverse-Flash
--    ('Green Lantern', 6, '1990-11-01', 5, 7), -- Green Lantern vs Sinestro
--    ('Aquaman', 6, '1995-01-01', 6, 5), -- Aquaman vs Black Manta
--    ('Teen Titans', 6, '1997-03-01', 7, 8), -- Cyborg vs Deathstroke
--    ('Justice League', 11, '1988-05-01', 1, 9), -- Justice League vs Darkseid
--    ('Justice League', 12, '1988-07-01', 2, 9); -- Justice League vs Darkseid
--	GO
--INSERT INTO Comics (Title, IssueNumber, ReleaseDate, SuperheroID, VillainID)
--VALUES 
--    ('Green Arrow', 1, '1983-11-01', 10, 2), -- Green Arrow vs Joker
--    ('Green Arrow', 2, '1983-12-01', 10, 4), -- Green Arrow vs Cheetah
--    ('Green Arrow', 3, '1984-01-01', 10, 7), -- Green Arrow vs Sinestro
--    ('Green Arrow', 4, '1984-02-01', 10, 1), -- Green Arrow vs Lex Luthor
--    ('Green Arrow', 5, '1984-03-01', 10, 6), -- Green Arrow vs Reverse-Flash
--    ('Green Arrow', 6, '1984-04-01', 10, 9), -- Green Arrow vs Darkseid
--    ('Green Arrow', 7, '1984-05-01', 10, 8), -- Green Arrow vs Deathstroke
--    ('Green Arrow', 8, '1984-06-01', 10, 5), -- Green Arrow vs Black Manta
--    ('Green Arrow', 9, '1984-07-01', 10, 10), -- Green Arrow vs Brainiac
--    ('Green Arrow', 10, '1984-08-01', 10, 3); -- Green Arrow vs Harley Quinn
--GO
--INSERT INTO Comics (Title, IssueNumber, ReleaseDate, SuperheroID, VillainID)
--VALUES 
--    ('Zatanna', 1, '1964-11-01', 14, 2), -- Zatanna vs Joker
--    ('Zatanna', 2, '1965-01-01', 14, 4), -- Zatanna vs Cheetah
--    ('Zatanna', 3, '1965-03-01', 14, 9), -- Zatanna vs Darkseid
--    ('Zatanna', 4, '1965-05-01', 14, 10); -- Zatanna vs Brainiac
--GO

--INSERT INTO Comics (Title, IssueNumber, ReleaseDate, SuperheroID, VillainID)
--VALUES 
--    ('Shazam!', 1, '1940-02-01', 9, 1), -- Shazam vs Lex Luthor
--    ('Shazam!', 2, '1940-04-01', 9, 2), -- Shazam vs Joker
--    ('Shazam!', 3, '1940-06-01', 9, 3), -- Shazam vs Harley Quinn
--    ('Shazam!', 4, '1940-08-01', 9, 4), -- Shazam vs Cheetah
--    ('Shazam!', 5, '1940-10-01', 9, 5), -- Shazam vs Black Manta
--    ('Shazam!', 6, '1940-12-01', 9, 6), -- Shazam vs Reverse-Flash
--    ('Shazam!', 7, '1941-02-01', 9, 7), -- Shazam vs Sinestro
--    ('Shazam!', 8, '1941-04-01', 9, 8), -- Shazam vs Deathstroke
--    ('Shazam!', 9, '1941-06-01', 9, 9), -- Shazam vs Darkseid
--    ('Shazam!', 10, '1941-08-01', 9, 10); -- Shazam vs Brainiac
--GO
--INSERT INTO Comics (Title, IssueNumber, ReleaseDate, SuperheroID, VillainID)
--VALUES 
--    ('Hellblazer', 1, '1985-06-01', 8, 1), -- Constantine vs Lex Luthor
--    ('Hellblazer', 2, '1985-07-01', 8, 2), -- Constantine vs Joker
--    ('Hellblazer', 3, '1985-08-01', 8, 3), -- Constantine vs Harley Quinn
--    ('Hellblazer', 4, '1985-09-01', 8, 4), -- Constantine vs Cheetah
--    ('Hellblazer', 5, '1985-10-01', 8, 5); -- Constantine vs Black Manta
--GO

---- Insert comic book entries for John Stewart
--INSERT INTO Comics (Title, IssueNumber, ReleaseDate, SuperheroID, VillainID)
--VALUES 
--    ('Green Lantern Corps', 1, '1971-12-01', 13, 7), -- John Stewart vs Sinestro
--    ('Green Lantern Corps', 2, '1972-01-01', 13, 6), -- John Stewart vs Reverse-Flash
--    ('Green Lantern Corps', 3, '1972-02-01', 13, 8), -- John Stewart vs Deathstroke
--    ('Green Lantern Corps', 4, '1972-03-01', 13, 9), -- John Stewart vs Darkseid
--    ('Green Lantern Corps', 5, '1972-04-01', 13, 10), -- John Stewart vs Brainiac
--    ('Green Lantern Corps', 6, '1972-05-01', 13, 1); -- John Stewart vs Lex Luthor
--GO

---- Insert comic book entries for J'onn J'onzz
--INSERT INTO Comics (Title, IssueNumber, ReleaseDate, SuperheroID, VillainID)
--VALUES 
--    ('Martian Manhunter', 1, '1955-11-01', 12, 2), -- Martian Manhunter vs Joker
--    ('Martian Manhunter', 2, '1955-12-01', 12, 4), -- Martian Manhunter vs Cheetah
--    ('Martian Manhunter', 3, '1956-01-01', 12, 8), -- Martian Manhunter vs Deathstroke
--    ('Martian Manhunter', 4, '1956-02-01', 12, 10); -- Martian Manhunter vs Brainiac
--GO

---- Insert comic book entries for Dinah Lance (Black Canary)
--INSERT INTO Comics (Title, IssueNumber, ReleaseDate, SuperheroID, VillainID)
--VALUES 
--    ('Black Canary', 1, '1947-08-01', 15, 1), -- Black Canary vs Lex Luthor
--    ('Black Canary', 2, '1947-09-01', 15, 3), -- Black Canary vs Harley Quinn
--    ('Black Canary', 3, '1947-10-01', 15, 7); -- Black Canary vs Sinestro
--GO

## Show Tables
---- Query to verify data
--SELECT * FROM Superheroes;
--SELECT * FROM Villains;
--SELECT * FROM Teams;
--SELECT * FROM VillainTeams;
--SELECT * FROM Comics;
--SELECT * FROM SuperheroTeams;
--SELECT * FROM VillainTeamMemberships;
--GO

### Useful Links for April 8, 2025  

1. [Practice MS SQL Database with DC Comics Characters](https://vijayasimhabr.medium.com/practice-ms-sql-database-with-dc-comics-characters-d2d8c68025e1)  
    - Practice SQL with a fun and engaging DC Comics dataset.  

2. [BungieCord Blog](https://jay-study-nildana.github.io/BungieCordBlog/)  
    - Explore insightful tutorials and articles on various tech topics.  

3. [SQL Fundamentals GitHub Repository](https://github.com/Jay-study-nildana/Azure-CSharp-Corp-Trainer-Syllabus/tree/main/SQLFundamentals)  
    - Access comprehensive SQL learning resources and examples.  

4. [Blazor for Students GitHub Repository](https://github.com/Jay-study-nildana/BlazorForStudents)  
    - Learn Blazor development with beginner-friendly guides and projects.  

---

### SQL Commands  

1. [DC Comics Database Setup Script](https://github.com/Jay-study-nildana/Azure-CSharp-Corp-Trainer-Syllabus/blob/main/SQLFundamentals/DCComics/dccomics-setupdb.sql)  
    - Set up the DC Comics database for SQL practice.  

2. [DC Comics SQL Queries](https://github.com/Jay-study-nildana/Azure-CSharp-Corp-Trainer-Syllabus/blob/main/SQLFundamentals/DCComics/dccomics-sqlqueries.sql)  
    - Explore pre-written SQL queries for the DC Comics dataset.  

---
### Dependency Injection or Dependency Inversion  

Dependency Injection (DI) is a design pattern that implements the Dependency Inversion Principle (DIP), one of the SOLID principles of object-oriented programming. It is a technique where an object receives its dependencies from an external source rather than creating them itself.  
*Constructor Takes care of Dependency Injection*
#### Key Concepts  

1. **Dependency Inversion Principle (DIP)**  
    - High-level modules should not depend on low-level modules. Both should depend on abstractions.  
    - Abstractions should not depend on details. Details should depend on abstractions.  

2. **Dependency Injection (DI)**  
    - A way to achieve DIP by providing dependencies to a class from an external source.  
    - Promotes loose coupling and enhances testability and maintainability.  

#### Types of Dependency Injection  

1. **Constructor Injection**  
    - Dependencies are provided through a class constructor.  
    - Example:  
      ```csharp
      public class Service
      {
          private readonly IRepository _repository;

          public Service(IRepository repository)
          {
              _repository = repository;
          }
      }
      ```

2. **Property Injection**  
    - Dependencies are set through public properties.  
    - Example:  
      ```csharp
      public class Service
      {
          public IRepository Repository { get; set; }
      }
      ```

3. **Method Injection**  
    - Dependencies are passed as parameters to a method.  
    - Example:  
      ```csharp
      public class Service
      {
          public void Execute(IRepository repository)
          {
              // Use repository
          }
      }
      ```

#### Benefits of Dependency Injection  

- **Improved Testability**: Makes it easier to mock dependencies for unit testing.  
- **Loose Coupling**: Reduces the dependency between classes, making the code more modular.  
- **Flexibility**: Allows swapping implementations without modifying the dependent class.  
- **Maintainability**: Simplifies code changes and reduces the risk of breaking existing functionality.  

#### Example in .NET  

Using a DI container like Microsoft.Extensions.DependencyInjection:  
```csharp
// Register services
var services = new ServiceCollection();
services.AddTransient<IRepository, Repository>();
services.AddTransient<Service>();

// Build service provider
var serviceProvider = services.BuildServiceProvider();

// Resolve dependencies
var service = serviceProvider.GetService<Service>();
```

#### Best Practices  

- Use interfaces to define dependencies.  
- Avoid overusing property injection as it can lead to unclear dependencies.  
- Prefer constructor injection for mandatory dependencies.  
- Use a DI container to manage dependencies in larger applications.  

For more information, refer to the [Microsoft Dependency Injection Documentation](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection).  
### Using Entity Framework Instead of SQL  

Entity Framework (EF) is an Object-Relational Mapper (ORM) that allows developers to work with a database using .NET objects, eliminating the need for most SQL queries. It simplifies data access by providing a higher-level abstraction over database operations.  

#### Key Features of Entity Framework  

1. **Code-First Approach**  
    - Define your database schema using C# classes.  
    - EF automatically generates the database based on your model.  

2. **Database-First Approach**  
    - Generate C# classes from an existing database schema.  
    - Useful for integrating with legacy databases.  

3. **Querying with LINQ**  
    - Use LINQ (Language Integrated Query) to query the database in a strongly-typed manner.  
    - Example:  
      ```csharp
      var superheroes = context.Superheroes
                               .Where(s => s.FirstAppearance.Year > 1950)
                               .ToList();
      ```

4. **Change Tracking**  
    - EF automatically tracks changes to entities and updates the database accordingly.  

5. **Migrations**  
    - Manage database schema changes using EF migrations.  
    - Example commands:  
      ```bash
      Add-Migration InitialCreate
      Update-Database
      ```

#### Example: Replacing SQL with Entity Framework  

Instead of writing raw SQL queries, you can use EF to perform CRUD operations.  

**Model Definition**  
```csharp
public class Superhero
{
    public int SuperheroID { get; set; }
    public string Name { get; set; }
    public string Alias { get; set; }
    public DateTime FirstAppearance { get; set; }
    public string Publisher { get; set; } = "DC Comics";
}
```

**DbContext Configuration**  
```csharp
public class ComicsContext : DbContext
{
    public DbSet<Superhero> Superheroes { get; set; }
    public DbSet<Villain> Villains { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("YourConnectionStringHere");
    }
}
```

**Adding Data**  
```csharp
using (var context = new ComicsContext())
{
    var superhero = new Superhero
    {
        Name = "Clark Kent",
        Alias = "Superman",
        FirstAppearance = new DateTime(1938, 6, 1)
    };

    context.Superheroes.Add(superhero);
    context.SaveChanges();
}
```

**Querying Data**  
```csharp
using (var context = new ComicsContext())
{
    var superheroes = context.Superheroes
                             .Where(s => s.Publisher == "DC Comics")
                             .ToList();

    foreach (var hero in superheroes)
    {
        Console.WriteLine($"{hero.Name} ({hero.Alias})");
    }
}
```

**Updating Data**  
```csharp
using (var context = new ComicsContext())
{
    var superhero = context.Superheroes.FirstOrDefault(s => s.Name == "Clark Kent");
    if (superhero != null)
    {
        superhero.Alias = "Man of Steel";
        context.SaveChanges();
    }
}
```

**Deleting Data**  
```csharp
using (var context = new ComicsContext())
{
    var superhero = context.Superheroes.FirstOrDefault(s => s.Name == "Clark Kent");
    if (superhero != null)
    {
        context.Superheroes.Remove(superhero);
        context.SaveChanges();
    }
}
```

#### Benefits of Using Entity Framework  

- **Productivity**: Reduces boilerplate code for database operations.  
- **Maintainability**: Centralized data access logic makes the code easier to maintain.  
- **Portability**: Abstracts database-specific details, making it easier to switch databases.  
- **Testability**: Simplifies mocking and testing of data access layers.  

For more information, refer to the [Microsoft Entity Framework Documentation](https://learn.microsoft.com/en-us/ef/).  
### Domain and DTO Usage  

#### Domain  
The **Domain** layer is primarily used for database-related operations. It represents the core business logic and entities of the application. This layer is responsible for defining the structure of the data and ensuring that it aligns with the database schema.  

#### DTO (Data Transfer Object)  
The **DTO** is used for **Swagger** and other API-related operations. It acts as a bridge between the API and the domain layer, ensuring that only the necessary data is exposed to the client. DTOs help in maintaining a clear separation of concerns and improve security by preventing over-posting or exposing sensitive data.  

---  

## April 7, 2025  

### Morning Session  

1. **SQL Queries Practice**  
    - Conducted hands-on exercises to enhance SQL query writing skills.  
    - Focused on query optimization techniques for improved performance.  

2. **SQL Server Management Studio**  
    - Explored advanced tools and features for efficient database management.  
    - Discussed best practices for database maintenance and troubleshooting.  

3. **C# Daily Practice**  
    - Continued daily programming tasks to strengthen C# proficiency.  
    - Solved real-world problems to improve coding and debugging skills.  

4. **GitHub and Project Management**  
    - Collaborated on team projects with regular updates and version control.  
    - Reviewed pull requests and refined strategies for effective project management.  

---

### Afternoon Session  

1. **Udemy Course Progress**  
    - Advanced through selected Udemy courses to deepen technical expertise.  
    - Completed modules on advanced programming concepts and design patterns.  

2. **TecStak Learning**  
    - Utilized TecStak resources for skill enhancement and hands-on practice.  
    - Reinforced newly acquired skills through targeted exercises.  

3. **Doubt Clearing Session**  
    - Addressed team queries and clarified complex concepts for better understanding.  
    - Conducted peer discussions to collaboratively resolve challenging problems.  

4. **Blogging Project Exploration**  
    - Made significant progress on a blogging platform using **.NET** and **Angular**.  
    - Implemented new features, enhanced UI/UX design, and improved code quality.  

5. **Blazor Project Exploration**  
    - Developed and tested features for a project using **.NET** and **Blazor**.  
    - Focused on component-based architecture, state management, and performance optimization.  

---

### Useful Links for April 7, 2025  

1. [Practice MS SQL Database with DC Comics Characters](https://vijayasimhabr.medium.com/practice-ms-sql-database-with-dc-comics-characters-d2d8c68025e1)  
    - Practice SQL with a fun and engaging DC Comics dataset.  

2. [BungieCord Blog](https://jay-study-nildana.github.io/BungieCordBlog/)  
    - Explore insightful tutorials and articles on various tech topics.  

3. [SQL Fundamentals GitHub Repository](https://github.com/Jay-study-nildana/Azure-CSharp-Corp-Trainer-Syllabus/tree/main/SQLFundamentals)  
    - Access comprehensive SQL learning resources and examples.  

4. [Blazor for Students GitHub Repository](https://github.com/Jay-study-nildana/BlazorForStudents)  
    - Learn Blazor development with beginner-friendly guides and projects.  

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


