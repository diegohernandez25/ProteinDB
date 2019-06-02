




/*
CREATE FUNCTION(@sp INT = null, @filter varchar(50) )
RETURNS @table 
*/
/*
CREATE TABLE begTable AS SELECT AccessionID FROM PROTEIN_ENTRY WHERE CONTAINS(AccessionID,@filter);
	DECLARE @MyTempTableVariable TABLE 

		INSERT INTO @MyTempTableVariable
		SELECT bleh
		FROM bleh

		SELECT AccessionID into tempTABLE FROM PROTEIN_ENTRY WHERE CONTAINS(AccessionID,@filter);


		CREATE TABLE begTable AS SELECT AccessionID FROM PROTEIN_ENTRY WHERE CONTAINS(AccessionID,@filter);

*/

INSERT INTO INTERACTION VALUES('P01178','P22304');
GO

ALTER FUNCTION filterProt (@sp INT, @filter varchar(50), @inter VARCHAR(20), @pub INT, @disease VARCHAR(20), @type VARCHAR(40)) RETURNS @table TABLE (NAccessionID VARCHAR(20), S_TaxID INT,ProteinType VARCHAR(40))
AS
	BEGIN
		INSERT @table (NAccessionID,S_TaxID,ProteinType)
			SELECT AccessionID, S_TaxID, ProteinType
			FROM PROTEIN_ENTRY
			WHERE AccessionID LIKE '%'+@filter+'%'

		DECLARE @tempTable table(
			NAccessionID VARCHAR(20),
			S_TaxID INT,
			ProteinType VARCHAR(40))
		
		--Filter by Species
		IF(@sp IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table

				INSERT @table (NAccessionID,S_TaxID, ProteinType)
					SELECT NAccessionID, S_TaxID, ProteinType
					FROM @tempTable JOIN SPECIES ON S_TaxID=TaxID
					WHERE TaxID = @sp;
				DELETE FROM @tempTable
			END
		
		--Filter by interaction    ver inverso
		IF(@inter IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table

				INSERT @table (NAccessionID,S_TaxID,ProteinType)
					SELECT NAccessionID, S_TaxID, ProteinType
					FROM @tempTable JOIN INTERACTION ON P_AccessionID=NAccessionID
					WHERE P2_AccessionID = @inter;
				DELETE FROM @tempTable
			END

		IF(@pub IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table

				INSERT @table (NAccessionID,S_TaxID,ProteinType)
					SELECT DISTINCT NAccessionID, S_TaxID,ProteinType
					FROM @tempTable 
						JOIN MENTION_PROTEIN ON I_P_AccessionID=NAccessionID 
						JOIN APROVAL_MENTION_PROTEIN ON M_I_P_AccessionID=I_P_AccessionID
					WHERE M_Publication_ID = @pub;
				DELETE FROM @tempTable
			END
		
		IF(@disease IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table

				INSERT @table (NAccessionID,S_TaxID, ProteinType)
					SELECT DISTINCT NAccessionID, S_TaxID,ProteinType
					FROM @tempTable 
						JOIN CAUSES ON NAccessionID=P_AccessionID 
					WHERE Disease_ICD10Code = @disease;
				DELETE FROM @tempTable
			END

		IF(@type IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table

				INSERT @table (NAccessionID,S_TaxID, ProteinType)
					SELECT DISTINCT NAccessionID, S_TaxID,ProteinType
					FROM @tempTable 
					WHERE ProteinType = @type;
				DELETE FROM @tempTable
			END

		RETURN
	END
GO 

SELECT * FROM PROTEIN_ENTRY JOIN INTERACTION ON P_AccessionID=AccessionID WHERE P2_AccessionID = 'P22304';

SELECT * FROM PUBLICATION;
select * from DISEASE;

SELECT * FROM filterProt(9606,'', NULL,null,'C0004352','Oxytocin-neurophysin 1');

go
ALTER FUNCTION filterSpecies (@filter varchar(50), @prot varchar(20), @type VARCHAR(40)) RETURNS @table TABLE (TaxID INT,  ScientificName VARCHAR(50))
AS
	BEGIN
		INSERT @table (TaxID,ScientificName)
			SELECT TaxID, ScientificName
			FROM SPECIES
			WHERE TaxID LIKE '%'+@filter+'%' OR ScientificName LIKE '%'+@filter+'%'


		DECLARE @tempTable table(
			TTaxID INT,  
			TScientificName VARCHAR(50))
		
		IF(@prot IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table

				INSERT @table (TaxID,ScientificName)
					SELECT TTaxID,TScientificName
					FROM @tempTable JOIN PROTEIN_ENTRY ON S_TaxID=TTaxID
					WHERE AccessionID = @prot;
				DELETE FROM @tempTable
			END

		IF(@type IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table

				INSERT @table (TaxID,ScientificName)
					SELECT TTaxID,TScientificName
					FROM @tempTable JOIN PROTEIN_ENTRY ON S_TaxID=TTaxID
					WHERE ProteinType = @type;
				DELETE FROM @tempTable
			END
		RETURN
	END
GO 





SELECT * FROM PROTEIN_ENTRY


SELECT * FROM filterSpecies('', 'P01178')



go




alter FUNCTION filterDisease (@filter varchar(50),  @prot varchar(20), @type VARCHAR(40)) RETURNS @table TABLE (ICD10Code VARCHAR(20),Name VARCHAR(60))
AS
	BEGIN
		INSERT @table (ICD10Code,Name)
			SELECT ICD10Code,Name
			FROM DISEASE
			WHERE ICD10Code LIKE '%'+@filter+'%' OR Name LIKE '%'+@filter+'%'


		DECLARE @tempTable table(
			TICD10Code VARCHAR(20),  
			TName VARCHAR(60))

		
		IF(@prot IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table

				INSERT @table (ICD10Code,Name)
					SELECT TICD10Code,TName
					FROM @tempTable JOIN CAUSES ON Disease_ICD10Code=TICD10Code
						JOIN PROTEIN_ENTRY ON P_AccessionID=AccessionID
					WHERE AccessionID = @prot;
				DELETE FROM @tempTable
			END


		IF(@type IS NOT NULL)
			BEGIN
				INSERT @tempTable SELECT * FROM @table;
				DELETE FROM @table

				INSERT @table (ICD10Code,Name)
					SELECT TICD10Code,TName
					FROM @tempTable JOIN CAUSES ON Disease_ICD10Code=TICD10Code
						JOIN PROTEIN_ENTRY ON P_AccessionID=AccessionID
					WHERE ProteinType = @type;
				DELETE FROM @tempTable
			END
		
		RETURN
	END
GO 

select * from DISEASE

select * from filterDisease('autist', )