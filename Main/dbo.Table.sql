CREATE TABLE Student
(
	[StdId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StdFirstName] NCHAR(15) NULL, 
    [StdLastName] VARCHAR(15) NULL, 
    [Birthdate] DATE NULL, 
    [Phone] VARCHAR(15) NULL,  
    [Gender] VARCHAR(10) NULL, 
    [Email] VARCHAR(25) NULL, 
    [Photo] VARBINARY(MAX) NULL
)
