--Verificar todas as proteínas mencionadas numa publicação. By Id
SELECT * FROM
PUBLICATION JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.P_ID
            JOIN PROTEIN_ENTRY ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
            WHERE PUBLICATION.ID = "0";

--Verificar todas as proteínas mencionadas numa publicação. By Sring (may the title be incompleted)
SELECT * FROM
PUBLICATION JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.P_ID
            JOIN PROTEIN_ENTRY ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
            WHERE PUBLICATION.Title LIKE CONCAT('%','publication','%');

--Verificar todas as proteinas mencionadas por um utilizador nas suas publicações.
SELECT * FROM
PUBLICATION JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
            JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.P_ID
            JOIN PROTEIN_ENTRY ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
            WHERE PUSER.ID = 1;

--Verificar todas as proteinas mencionadas por um utilizador nas suas publicações.
SELECT * FROM
PUBLICATION JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
            JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.P_ID
            JOIN PROTEIN_ENTRY ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
            WHERE PUSER.Name LIKE CONCAT('%','Diego','%');

--Verificar todas as proteinas mencionadas numa publicação que foram aprovadas por um curador
SELECT * FROM
PUBLICATION JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.P_ID
            JOIN PROTEIN_ENTRY ON PROTEIN_ENTRY.AccessionID = mention_protein.p_id
            LEFT OUTER JOIN APROVAL_MENTION_PROT ON APROVAL_MENTION_PROT.M_I_P_AccessionID = MENTION_PROTEIN.P_ID
            WHERE APROVAL_MENTION_PROT.Curator_ID IS NOT NULL;

--verificar todas as funções das proteina que foram mencionadas numa publicação, junto das proteinas.
SELECT * FROM
PUBLICATION JOIN MENTION_FUNCTION ON PUBLICATION.ID = MENTION_FUNCTION.Publication_ID
            JOIN PROTEIN_ENTRY ON MENTION_FUNCTION.P_AccessionID = PROTEIN_ENTRY.P_AccessionID
            WHERE PUBLICATION.ID = "0";

--verificar todas as funções das proteina que foram mencionadas numa publicação, junto das proteinas.
SELECT * FROM
PUBLICATION JOIN MENTION_FUNCTION ON PUBLICATION.ID = MENTION_FUNCTION.Publication_ID
            JOIN PROTEIN_ENTRY ON MENTION_FUNCTION.P_AccessionID = PROTEIN_ENTRY.P_AccessionID
            WHERE PUBLICATION.Title LIKE CONCAT('%','publication','%');


--Verificar todas as funções  mencionadas numa publicação que foram aprovadas por um curador  juntamente com a proteina
SELECT * FROM
PUBLICATION JOIN MENTION_FUNCTION ON PUBLICATION.ID = MENTION_FUNCTION.Publication_ID
            JOIN PROTEIN_ENTRY ON MENTION_FUNCTION.P_AccessionID = PROTEIN_ENTRY.P_AccessionID
            JOIN APROVAL_MENTION_FUNCTION ON APROVAL_MENTION_FUNCTION.M_F_P_AccessionID = MENTION_FUNCTION.P_AccessionID
            WHERE APROVAL_MENTION_PROT.Curator_ID IS NOT NULL;

--Selecionar id da publicação mais alta
SELECT * FROM PUBLICATION
WHERE id = (
  SELECT max(PUBLICATION.ID) FROM PUBLICATION
)

--Criar uma publicação
--TODO Veirfy if user is valis

CREATE PROCEDURE Create_Publication @link varchar(50), @id_user INT, @subdate date
AS
  DECLARE @tmpID AS INT
  SELECT @tmpID = max(PUBLICATION.ID) FROM PUBLICATION;
  INSERT INTO PUBLICATION(ID,Link,User_ID,SubmitionDate)
  VALUES(@tmpID + 1,@link,@id_user,@subdate);

--Criar um projeto.
CREATE PROCEDURE Create_Production @description varchar(50)
AS
  DECLARE @tmpID AS INT
  SELECT @tmpID = max(PROJECT.ID) FROM PROJECT;
  INSERT INTO PROJECT VALUES (@tmpID,@description);

--Verificar as doenças das proteínas mencionada numa publicação.
SELECT * FROM
DISEASE JOIN CAUSES ON DISEASE.ICD10Code = CAUSES.Disease_ICD10Code
JOIN PROTEIN_ENTRY ON CAUSES.P_AccessionID = PROTEIN_ENTRY.AccessionID
JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
JOIN PUBLICATION ON MENTION_PROTEIN.Publication_ID = Publication.ID
WHERE PUBLICATION.Title LIKE CONCAT('%','publication','%');


SELECT * FROM
DISEASE JOIN CAUSES ON DISEASE.ICD10Code = CAUSES.Disease_ICD10Code
JOIN PROTEIN_ENTRY ON CAUSES.P_AccessionID = PROTEIN_ENTRY.AccessionID
JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
JOIN PUBLICATION ON MENTION_PROTEIN.Publication_ID = Publication.ID
WHERE PUBLICATION.ID = "0";

--Verificar as publicações onde as proteínas que causam uma dada doença é mencionado.Um ou mais
SELECT * FROM
DISEASE JOIN CAUSES ON DISEASE.ICD10Code = CAUSES.Disease_ICD10Code
JOIN PROTEIN_ENTRY ON CAUSES.P_AccessionID = PROTEIN_ENTRY.AccessionID
JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.ID = MENTION_PROTEIN.P_ID
JOIN PUBLICATION ON MENTION_PROTEIN.Publication_ID = Publication.ID
WHERE DISEASE.ICD10Code = "0";

--Verificar as publicações mais recentes onde é mencionada uma proteína. E as mais velhas. Tendo limites de contagem
SELECT * FROM
PROTEIN_ENTRY JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
JOIN PUBLICATION on MENTION_PROTEIN.Publication_ID
ORDER BY CONVERT(DateTime, PUBLICATION.SubmitionDate) DESC LIMIT 10; --limita o numero de resultados.

SELECT * FROM
PROTEIN_ENTRY JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
JOIN PUBLICATION on MENTION_PROTEIN.Publication_ID
ORDER BY CONVERT(DateTime, PUBLICATION.SubmitionDate) ASC LIMIT 10; --limita o numero de resultados.


--Verificar as publicações onde as proteinas que causam uma dada doença é mencionado.Um ou mais
SELECT * FROM
DISEASE JOIN CAUSES ON DISEASE.ICD10Code = CAUSES.Disease_ICD10Code
JOIN PROTEIN_ENTRY CAUSES.P_AccessionID = PROTEIN_ENTRY.AccessionID,
JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.Publication_ID
--WHERE DISEASE.ICD10Code = "0";
WHERE DISEASE.ICD10Code IN {"0", "2"};


--Verifica as publicações onde as proteínas de uma dada espécie é mencionado. Um ou mais


--Seleciona as proteinas de uma especie
SELECT PROTEIN_ENTRY.AccessionID FROM Species
JOIN PROTEIN_ENTRY ON Species.TaxID = protein_entry.S_TaxID
--WHERE Species.TaxID = 1;
WHERE ScientificName LIKE CONCAT('%','rato','%')

SELECT * FROM
PROTEIN_ENTRY JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
JOIN PUBLICATION on MENTION_PROTEIN.Publication_ID
WHERE PROTEIN_ENTRY IN (SELECT PROTEIN_ENTRY.AccessionID FROM Species
JOIN PROTEIN_ENTRY ON Species.TaxID = protein_entry.S_TaxID
--WHERE Species.TaxID = 1;
WHERE ScientificName LIKE CONCAT('%','rato','%'));


--Verificar todas as publicações onde sao mencionadas duas ou mais proteinas
SELECT * FROM
PROTEIN_ENTRY JOIN MENTION_PROTEIN ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_AccessionID
JOIN PUBLICATION ON MENTION_PROTEIN.Publication_ID = PUBLICATION.
WHERE PROTEIN_ENTRY.AccessionID IN {1,2,3};

--Mostrar as proteínas mencionadas na publicação e verificar os pares que interagem entre elas.

SELECT PROTEIN_ENTRY.AccessionID, INTERACTION.P2_AccessionID
FROM PUBLICATION JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.P_ID
JOIN PROTEIN_ENTRY ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
LEFT JOIN INTERACTION ON PROTEIN_ENTRY.AccessionID = INTERACTION.P_AccessionID
WHERE PUBLICATION.ID = "0";


--Contar para cada proteina de uma publicação o numero de iterações que esta tem com outras proteinas.
SELECT PROTEIN_ENTRY.AccessionID,
CASE WHEN INTERACTION.P2_AccessionID IS NULL THEN 0 ELSE count(INTERACTION.P2_AccessionID) END
FROM PUBLICATION JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.P_ID
JOIN PROTEIN_ENTRY ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
LEFT JOIN INTERACTION ON PROTEIN_ENTRY.AccessionID = INTERACTION.P_AccessionID
GROUP BY PROTEIN_ENTRY.AccessionID;

--Mostrar as proteínas mencionadas numa publicação e organizar por tipo de proteina
SELECT * FROM
PUBLICATION JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.P_ID
            JOIN PROTEIN_ENTRY ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
            WHERE PUBLICATION.ID = "0"
            PUBLICATION ORDER BY PROTEIN_ENTRY.ProteinType;
--Numero de familias de proteinas referenciadas diretamente ou nao na publicação.
SELECT PROTEIN_ENTRY.ProteinType, COUNT(PROTEIN_ENTRY) FROM
            PUBLICATION JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.P_ID
            JOIN PROTEIN_ENTRY ON PROTEIN_ENTRY.AccessionID = MENTION_PROTEIN.P_ID
            WHERE PUBLICATION.ID = "0"
            PUBLICATION ORDER BY PROTEIN_ENTRY.ProteinType
            GROUP BY PROTEIN_ENTRY.ProteinType;

--Verificar as publicações que um utilizador submeteU. Opção de pesquisar por data, mais recente ou mais antigo.
  --Numero de publicações submetidas pelo utilizador.
SELECT COUNT(PUBLICATION.User_ID) FROM
PUBLICATION JOIN User_ID ON PUBLICATION.User_ID = PUSER.ID
WHERE PUBLICATION.User_ID = 1
GROUP BY PUBLICATION.User_ID;

  --Publicações de um utilizador
SELECT * FROM
PUBLICATION JOIN User_ID ON PUBLICATION.User_ID = PUSER.ID
WHERE PUBLICATION.User_ID = 1;

  -- Organizar publicações por um range de datas.
SELECT * FROM
PUBLICATION JOIN User_ID ON PUBLICATION.User_ID = PUSER.ID
WHERE PUBLICATION.User_ID = 1 AND
      PUBLICATION.SubmitionDate BETWEEN DATE '2000-01-01' AND DATE '2000-12-31'
ORDER BY CONVERT(DateTime, PUBLICATION.SubmitionDate,101) DESC;

--Pesquisar por título a publicação. Filtrar publicacao por titulo, autores, utilizadores e data de submissão.
SELECT * FROM
PUBLICATION WHERE PUBLICATION.TITLE LIKE CONCAT('%','pub1','%')
PUBLICATION.SubmitionDate BETWEEN DATE '2000-01-01' AND DATE '2000-12-31'
ORDER BY CONVERT(DateTime, PUBLICATION.SubmitionDate,101) DESC;

--TODO: Criar um conjunto de nomes a partir de um input de nome incompleto!
SELECT * FROM
PUBLICATION JOIN PUB_AUTHOR ON PUBLICATION.ID = PUB_AUTHOR.PUBLICATION_ID
JOIN PUSER ON PUBLICATION.User_ID = PUSER.ID
WHERE PUBLICATION.TITLE LIKE CONCAT('%','pub1','%') AND
PUB_AUTHOR IN ('Diego', 'Rodrigo') AND
PUBLICATION.SubmitionDate BETWEEN DATE '2000-01-01' AND DATE '2000-12-31' AND
--PUSER.Name LIKE CONCAT('%','User1','%')
PUSER.ID = '1'
ORDER BY CONVERT(DateTime, PUBLICATION.SubmitionDate,101) DESC;

--Verificar todas as proteínas que são mencionadas nas publicações a qual um dado utilizador já mencionou.
--Retirar info de familias e genes, doencas etc.

  -- retorna todas as proteinas mencionadas nas publucaçoes do utilizador
CREATE VIEW mentionedUserProts AS
SELECT DISTINCT PROTEIN_ENTRY.AccessionID as AccessionID FROM
PUSER JOIN PUBLICATION ON PUSER.ID = PUBLICATION.ID
JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.Publication_ID
JOIN PROTEIN_ENTRY ON MENTION_PROTEIN.P_ID = PROTEIN_ENTRY.AccessionID
WHERE PUSER.ID = 1;

    --NUMBER OF MENTIONED PROTEINS
SELECT COUNT(MentionedUserProts) IN mentionedUserProts

CREATE VIEW referencedFamilies
SELECT PROTEIN_ENTRY.AccessionID as AccessionID, PROTEIN_ENTRY.ProteinType as ProteinType
FROM PROTEIN_ENTRY, mentionedUserProts
WHERE PROTEIN_ENTRY.AccessionID = mentionedUserProts.AccessionID;

--Numero de proteinas de um tipo de proteinas mencionados
SELECT referencedFamilies.ProteinType, COUNT(referencedFamilies.AccessionID)
FROM referencedFamilies
GROUP BY referencedFamilies.ProteinType;

--Numero de tipo de familias
SELECT COUNT(a)
FROM (SELECT DISTINCT referencedFamilies.ProteinType FROM referencedFamilies) AS a;

--verificar por utilizador que publicações mencionam: proteins ou tipo de proteinas.
--por proteinas
SELECT PUBLICATION.ID FROM
PUSER JOIN PUBLICATION ON PUSER.ID = PUBLICATION.User_ID
JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN-.Publication_ID
JOIN PROTEIN_ENTRY ON MENTION_PROTEIN.P_ID = PROTEIN_ENTRY.AccessionID
WHERE PUSER.ID = 1 AND (PROTEIN_ENTRY.AccessionID IN ('1','2')
OR PROTEIN_ENTRY.ProteinType IN ('proteinType1')) AND
PUBLICATION.SubmitionDate BETWEEN DATE '2000-01-01' AND DATE '2000-12-31' AND
ORDER BY CONVERT(DateTime, PUBLICATION.SubmitionDate,101) DESC;

 --Verificar os projetos que o utilizador participa.
SELECT * FROM
PUSER JOIN PARTICIPATES ON PUSER.ID = PARTICIPATES.PROJECT_ID
JOIN PROJECT ON PARTICIPATES.Project_ID = PROJECT.ID
WHERE PUSER.ID = '1';

--Verificar todos os membros de um projeto
SELECT PROJECT.ID AS Proj PUSER.ID AS Usr FROM
PROJECT JOIN PARTICIPATES ON PROJECT.ID = PARTICIPATES.Project_ID
JOIN PUSER ON PARTICIPATES.User_ID = PUSER.ID
WHERE PROJECT.ID = '1';

--numero de utilizadores num dado projeto.
SELECT count(PUSER.ID) AS NumberOfMembers FROM
PROJECT JOIN PARTICIPATES ON PROJECT.ID = PARTICIPATES.Project_ID
JOIN PUSER ON PARTICIPATES.User_ID = PUSER.ID
WHERE PROJECT.ID = '1';

--numero de utilizadores em cada um dos projetos do utilizador
SELECT PROJECT.ID as Proj COUNT(NumberOfMembers) FROM
PROJECT JOIN PARTICIPATES ON PROJECT.ID = PARTICIPATES.Project_ID
JOIN PUSER ON PARTICIPATES.User_ID = PUSER.ID
HAVING COUNT(NumberOfMembers)>0
GROUP BY PROJECT.ID;

--numero de projetos em comum que tens com um utilizador
--TODO: Fazer mais do que dois utilizadores
CREATE FUNCTION dbo.GetCommonProjects(@user1 INT, @user2 INT) RETURNS Table
AS
    IF(@user1 <> @user2)
      BEGIN
        CREATE VIEW User1Projects AS
        SELECT PROJECT.ID AS Proj PUSER.ID AS Usr FROM
        PROJECT JOIN PARTICIPATES ON PROJECT.ID = PARTICIPATES.Project_ID
        JOIN PUSER ON PARTICIPATES.User_ID = @user1;

        CREATE VIEW User2Projects AS
        SELECT PROJECT.ID AS Proj PUSER.ID AS Usr FROM
        PROJECT JOIN PARTICIPATES ON PROJECT.ID = PARTICIPATES.Project_ID
        JOIN PUSER ON PARTICIPATES.User_ID = @user2;

        RETURN(SELECT DISTINCT User1Projects.Proj1 AS commonProj
        FROM User1Projects, User2Projects
        WHERE User1Projects.Usr = User2Projects.Usr);
      END
    RETURN NULL; --FIXME: Does this work???

--Numero de projetos em comum.
SELECT count(commonProj) FROM dbo.GetCommonProjects(1,2);

--Verificar todos os projetos dos utilizadores que submetem ou são autor de uma publicação.
--TODO : LATER.

--Verificar todas as publicações e as funções de uma proteinas de um utilizador que foram aprovadas.
--As mençoes de proteinas aprovadas. E aprovadas por quem
SELECT *
FROM PUSER JOIN PUBLICATION ON PUSER.ID = PUBLICATION.User_ID
JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.Publication_ID
JOIN APROVAL_MENTION_PROT ON MENTION_PROTEIN.Publication_ID = APROVAL_MENTION_PROT.M_Publication_ID
WHERE PUSER.ID = 1;

-- Verificar quem aprovou uma dada menção de uma proteina.
CREATE FUNCTION dbo.GetApprovalCurator(@prot_id INT, @pub_id INT) RETURNS Table
  BEGIN
    DECLARE @flag BOOLEAN
    SELECT @flag = count()>0
    FROM MENTION_PROTEIN
    WHERE MENTION_PROTEIN.P_ID = @prot_id AND MENTION_PROTEIN.Publication_ID;

    IF @flag
    BEGIN
      RETURN (SELECT MENTION_PROTEIN.Publication_ID, APROVAL_MENTION_PROT.Curator_ID, PUBLICATION.SubmitionDate, APROVAL_MENTION_PROT.Date_of_approval
      , DATEDIFF(day,PUBLICATION.SubmitionDate,APROVAL_MENTION_PROT.Date_of_approval) AS DateDiff
      FROM MENTION_PROTEIN
      JOIN APROVAL_MENTION_PROT ON (MENTION_PROTEIN.P_ID = APROVAL_MENTION_PROT. M_I_P_AccessionID
      AND MENTION_PROTEIN.Publication_ID = APROVAL_MENTION_PROT.M_Publication_ID)
      JOIN PUBLICATION ON MENTION_PROTEIN.Publication_ID = PUBLICATION.ID;)
    END;
    RETURN NULL;
  END;

--As mencoes das proteinas que ainda nao foram aprovadas.
SELECT *
FROM PUSER JOIN PUBLICATION ON PUSER.ID = PUBLICATION.User_ID
JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.Publication_ID
LEFT OUTER JOIN APROVAL_MENTION_PROT ON MENTION_PROTEIN.Publication_ID = APROVAL_MENTION_PROT.M_Publication_ID
WHERE APROVAL_MENTION_PROT.M_Publication_ID IS NULL;
WHERE PUSER.ID = 1;

--Verificar as publicações ou funções das proteína que foram mencionadas em publicações que um curador já aprovou.
  --Menções de proteinas
  SELECT *
  FROM CURATOR
  JOIN APROVAL_MENTION_PROT ON  CURATOR.User_ID = APROVAL_MENTION_PROT.Curator_ID
  JOIN MENTION_PROTEIN ON (APROVAL_MENTION_PROT.M_I_P_AccessionID = MENTION_PROTEIN.P_ID AND APROVAL_MENTION_PROT.M_Publication_ID = MENTION_PROTEIN.Publication_ID);
  --Menções de funcoes de uma proteina.

  SELECT *
  FROM CURATOR
  JOIN APROVAL_MENTION_FUNCTION ON  CURATOR.User_ID = APROVAL_MENTION_FUNCTION.Curator_ID
  JOIN MENTION_FUNCTION ON (APROVAL_MENTION_FUNCTION.M_F_P_AccessionID = MENTION_FUNCTION.P_AccessionID
    AND APROVAL_MENTION_FUNCTION.M_I_F_ID = MENTION_FUNCTION.F_ID
    AND APROVAL_MENTION_FUNCTION.M_Publication_ID = MENTION_FUNCTION.Publication_ID);

--Verificar as publicações ou funções das proteína que foram mencionadas em publicações que um curador já aprovou.
-- Aprovação de menções de uma proteina em especifico
SELECT *
FROM CURATOR
JOIN APROVAL_MENTION_PROT ON  CURATOR.User_ID = APROVAL_MENTION_PROT.Curator_ID
JOIN MENTION_PROTEIN ON (APROVAL_MENTION_PROT.M_I_P_AccessionID = MENTION_PROTEIN.P_ID AND APROVAL_MENTION_PROT.M_Publication_ID = MENTION_PROTEIN.Publication_ID)
WHERE MENTION_PROTEIN.P_ID = '1';

-- Aprovação de funções de menções de uma proteina em especifico
SELECT *
FROM CURATOR
JOIN APROVAL_MENTION_FUNCTION ON  CURATOR.User_ID = APROVAL_MENTION_FUNCTION.Curator_ID
JOIN MENTION_FUNCTION ON (APROVAL_MENTION_FUNCTION.M_F_P_AccessionID = MENTION_FUNCTION.P_AccessionID
  AND APROVAL_MENTION_FUNCTION.M_I_F_ID = MENTION_FUNCTION.F_ID
  AND APROVAL_MENTION_FUNCTION.M_Publication_ID = MENTION_FUNCTION.Publication_ID);
WHERE MENTION_FUNCTION.P_AccessionID = '1';

--TODO Fazer as verificações possiveis.
CREATE PROC AprovePublication @Cur_id INT, @prot_id VARCHAR(20), @pub_id INT
AS
  BEGIN
  INSERT INTO APROVAL_MENTION_PROTEIN VALUES (@Cur_id,@prot_id,@pub_id,GETDATE());
  END

--numero de mencoes de uma determinada proteina em publicações de um utilizador
SELECT MENTION_PROTEIN.P_ID, count(MENTION_PROTEIN.P_ID) FROM PUSER
JOIN PUBLICATION ON PUSER.ID = PUBLICATION.User_ID
JOIN MENTION_PROTEIN ON PUBLICATION.ID = MENTION_PROTEIN.Publication_ID
GROUP BY MENTION_PROTEIN.P_ID
HAVING count(MENTION_PROTEIN.P_ID) > 0
WHERE PUSER.ID = 1;

--Verificar todas as funções de uma proteína. Filtrar por aprovadas e não aprovadas.ordem
--Data de submissão ou data de aprovação.


--Verificar que menções (proteinas/funcao proteinas) foram aprovadas e não aprovadas em uma publicação.

--Verificar que menções (proteinas/funcao proteinas) foram aprovadas e não aprovadas das publicações de um
--ou mais autores.

--Verificar que menções (proteinas/funcao proteinas) foram aprovadas e
--não aprovadas das publicações que foram submetidas por um utilizador.
