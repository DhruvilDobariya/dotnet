-- For Single Column
-- Add new column in table
Alter Table Faculty
Add Email Varchar(50);

-- Edit column in table
Alter Table Faculty
Modify Column Email Varchar(250);

-- Delete column in table
Alter Table Faculty
Drop Column Email;

-- For Multiple Column
-- Add new columns in table
Alter Table Faculty
Add Email Varchar(50),
Add Subject Varchar(50);

-- Edit columns in table
Alter Table Faculty
Modify Column Email Varchar(250),
Modify Column Subject Varchar (25);

-- Delete colomuns in table
Alter Table Faculty
Drop Column Email,
Drop Column Subject;

