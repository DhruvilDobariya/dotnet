Create Table Student(
	Id int Not Null Auto_Increment,
    Name Varchar(250) Not Null,
    DateOfBirth Date Not Null,
    ContactNo Varchar(25),
    Gender Varchar(1),
    Primary Key(Id) 
);
-- Create Table Student(
-- 	Id int Not Null Auto_Increment,
--     Name Varchar(250) Not Null,
--     DateOfBirth Date Not Null,
--     ContactNo Varchar(25),
--     Gender Varchar(1),
--     Constraint Pk_Student Primary Key(Id, Name)
-- );

Create Table Faculty(
	Id int Not Null Primary Key Auto_Increment,
    Name Varchar(250) Not Null,
    DateOfBirth Date Not Null,
    ContactNo Varchar(25),
    Gender Varchar(1)
);