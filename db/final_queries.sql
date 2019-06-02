--SEARCH BY TITLE
GO
ALTER FUNCTION getPublicationByTitle(@title VARCHAR(300)) RETURNS Table
AS
	RETURN(SELECT PUBLICATION.ID AS PubID, PUBLICATION.Link, PUBLICATION.Title, PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate FROM PUBLICATION
	JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE PUBLICATION.TITLE LIKE CONCAT('%',@title,'%'));

GO
SELECT * FROM getPublicationByTitle('d');

GO

--SEARCH BY Publication by ID
GO
ALTER FUNCTION getPublicationByID(@id INT) RETURNS Table
AS
	RETURN(SELECT PUBLICATION.ID AS PubID, PUBLICATION.Link, PUBLICATION.Title, PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate FROM PUBLICATION
	JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE PUBLICATION.ID = @id);
GO
SELECT * FROM getPublicationByID(1108690);

--Selecionar Publicacoes por autor
GO
ALTER FUNCTION getPublicationByAuthor(@author VARCHAR(50)) RETURNS Table
AS
	RETURN(SELECT PUBLICATION.ID AS PubID, PUBLICATION.Link, PUBLICATION.Title, PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate FROM PUB_AUTHOR
	JOIN PUBLICATION ON PUB_AUTHOR.Publication_ID = PUBLICATION.ID
	JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE PUB_AUTHOR.AuthorName LIKE CONCAT('%',@author,'%'));
GO

--Conseguir publicações por autor

ALTER FUNCTION getPublicationByUserID(@usrId INT) RETURNS Table
AS
	RETURN(SELECT PUBLICATION.ID AS PubID, PUBLICATION.Link, PUBLICATION.Title, PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate  FROM
	PUBLICATION JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE PUBLICATION.User_ID = @usrId);
GO

ALTER FUNCTION getPublicationByUserName(@usrName VARCHAR(30)) RETURNS Table
AS
	RETURN(SELECT PUBLICATION.ID AS PubID, PUBLICATION.Link, PUBLICATION.Title, PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate  FROM
	PUBLICATION JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE PUSER.Name LIKE CONCAT('%',@usrName,'%'));
GO


-- Search publication by date
ALTER FUNCTION SearchPublicationBetweenDate(@initDate DATE, @finalDate DATE) RETURNS Table
AS
	RETURN(SELECT PUBLICATION.ID AS PubID, PUBLICATION.Link, PUBLICATION.Title, PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate
	FROM PUBLICATION JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE PUBLICATION.SubmitionDate BETWEEN  @initDate AND  @finalDate);
GO

ALTER FUNCTION SearchPublicationGreaterDate(@initDate DATE) RETURNS Table
AS
	RETURN(SELECT PUBLICATION.ID AS PubID, PUBLICATION.Link, PUBLICATION.Title, PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate FROM PUBLICATION
	JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE PUBLICATION.SubmitionDate >= CONVERT(datetime, @initDate));
GO

ALTER FUNCTION SearchPublicationLowerDate(@finalDate DATE) RETURNS Table
AS
	RETURN(SELECT PUBLICATION.ID AS PubID, PUBLICATION.Link, PUBLICATION.Title, PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate FROM PUBLICATION
	JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE PUBLICATION.SubmitionDate <= CONVERT(datetime, @finalDate));
GO



--Select publications by mentions of proteins
ALTER FUNCTION SearchPublicationByProteinID(@protId VARCHAR(20)) RETURNS Table
AS
	RETURN(SELECT DISTINCT PUBLICATION.ID AS PubID, PUBLICATION.Link, PUBLICATION.Title, PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate  FROM
	PROTEIN_ENTRY JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.I_P_AccessionID
	JOIN PUBLICATION ON MENTION_PROTEIN.Publication_ID = PUBLICATION.ID
	JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE MENTION_PROTEIN.I_P_AccessionID = @protId);
GO

SELECT * FROM SearchPublicationByProteinID('P01178');
GO
--Seleciona publicações a partir de Protein Types
ALTER FUNCTION SearchPublicationByProteinByType(@protType VARCHAR(20)) RETURNS Table
AS
	RETURN(SELECT DISTINCT PUBLICATION.ID AS PubID, PUBLICATION.Link,  PUBLICATION.Title,PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate  FROM
	PROTEIN_ENTRY JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.I_P_AccessionID
	JOIN PUBLICATION ON MENTION_PROTEIN.Publication_ID = PUBLICATION.ID
	JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE PROTEIN_ENTRY.ProteinType LIKE CONCAT('%',@protType,'%'));
GO

--Procura por publicação da universidade
ALTER FUNCTION SearchPublicationByUniversity(@uni VARCHAR(30)) RETURNS Table
	RETURN (SELECT DISTINCT PUBLICATION.ID AS PubID, PUBLICATION.Link, PUBLICATION.Title, PUBLICATION.User_ID, PUSER.Name, PUSER.University, PUBLICATION.SubmitionDate  FROM
	PROTEIN_ENTRY JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.I_P_AccessionID
	JOIN PUBLICATION ON MENTION_PROTEIN.Publication_ID = PUBLICATION.ID
	JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
	WHERE PUSER.University LIKE CONCAT('%',@uni,'%'));


	GO
	ALTER FUNCTION filterPublication (@pubId INT, @title VARCHAR(300), @author VARCHAR(20)
	, @userName varchar(20), @userId INT, @initDate DATE,@finalDate DATE, @proteinID VARCHAR(20), @proteinType VARCHAR(40), @university VARCHAR(30))
		RETURNS @table TABLE (PubID INT,Link VARCHAR(50),Title VARCHAR(300),User_ID INT,Name VARCHAR(30),University VARCHAR(30),SubmitionDate DATE)
	AS
		BEGIN
		INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
				SELECT PUBLICATION.ID AS PubID,Link,Title,User_ID,Name,University,SubmitionDate
				FROM PUBLICATION JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID;

			DECLARE @tempTable table(PubID INT,Link VARCHAR(50),Title VARCHAR(300),User_ID INT,Name VARCHAR(30),University VARCHAR(30),SubmitionDate DATE)

			IF(@title IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table;
				INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
						SELECT * FROM @tempTable
						INTERSECT
						SELECT * FROM getPublicationByTitle(@title);
				DELETE FROM @tempTable
			END
			IF(@author IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table;
				INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
						SELECT * FROM @tempTable
						INTERSECT
						SELECT * FROM getPublicationByAuthor(@author);
				DELETE FROM @tempTable

			END

			IF(@userName IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table;
				INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
				SELECT * FROM @tempTable
				INTERSECT
				SELECT * FROM getPublicationByUserName(@userName);
				DELETE FROM @tempTable
			END
			IF(@userId IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table;
				INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
				SELECT * FROM @tempTable
				INTERSECT
				SELECT * FROM getPublicationByUserId(@userId);
				DELETE FROM @tempTable
			END
			IF(@initDate IS NOT NULL)
			BEGIN
				IF(@finalDate IS NOT NULL)
				BEGIN
					INSERT @tempTable SELECT * FROM @table;
					DELETE FROM @table;
					INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
					SELECT * FROM @tempTable
					INTERSECT
					SELECT * FROM SearchPublicationBetweenDate(@initDate, @finalDate);
					DELETE FROM @tempTable
				END
				ELSE
				BEGIN
					INSERT @tempTable SELECT * FROM @table;
					DELETE FROM @table;
					INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
					SELECT * FROM @tempTable
					INTERSECT
					SELECT * FROM SearchPublicationGreaterDate(@initDate);
					DELETE FROM @tempTable
				END
			END
			IF(@finalDate IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table;
				INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
				SELECT * FROM @tempTable
				INTERSECT
				SELECT * FROM SearchPublicationLowerDate(@initDate);
				DELETE FROM @tempTable
			END
			IF(@proteinID IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table;
				INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
				SELECT * FROM @tempTable
				INTERSECT
				SELECT * FROM SearchPublicationByProteinID(@proteinID);
				DELETE FROM @tempTable
			END
			IF(@proteinType IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table;
				INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
				SELECT * FROM @tempTable
				INTERSECT
				SELECT * FROM SearchPublicationByProteinByType(@proteinType);
				DELETE FROM @tempTable
			END
			IF(@university IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table;
				INSERT @table (PubID,Link,Title,User_ID,Name,University,SubmitionDate)
				SELECT * FROM @tempTable
				INTERSECT
				SELECT * FROM SearchPublicationByUniversity(@university);
				DELETE FROM @tempTable
			END
			RETURN
		END
	GO
