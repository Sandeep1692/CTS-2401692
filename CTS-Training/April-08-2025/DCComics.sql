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

