USE Minions

SELECT * FROM Users

GO
ALTER TABLE Users DROP CONSTRAINT PK_Users;  
ALTER TABLE Users ADD CONSTRAINT PK_Users PRIMARY KEY(Id);
ALTER TABLE Users ADD CONSTRAINT UNQ_Username UNIQUE (Username);







