
--SPECIES
INSERT INTO SPECIES(TaxID,ScientificName,Life,Domain,Kingdom,Filo,Class,Order,Family,Genre,Specie) VALUES(0,"scientificname0","life0","domain0","kingdom0","filo0","class0","order0","family0","genre0","specie0");
INSERT INTO SPECIES(TaxID,ScientificName,Life,Domain,Kingdom,Filo,Class,Order,Family,Genre,Specie) VALUES(1,"scientificname1","life1","domain1","kingdom1","filo1","class1","order1","family1","genre1","specie1");
INSERT INTO SPECIES(TaxID,ScientificName,Life,Domain,Kingdom,Filo,Class,Order,Family,Genre,Specie) VALUES(2,"scientificname2","life2","domain2","kingdom2","filo2","class2","order2","family2","genre2","specie2");
INSERT INTO SPECIES(TaxID,ScientificName,Life,Domain,Kingdom,Filo,Class,Order,Family,Genre,Specie) VALUES(3,"scientificname3","life3","domain3","kingdom3","filo3","class3","order3","family3","genre3","specie3");
INSERT INTO SPECIES(TaxID,ScientificName,Life,Domain,Kingdom,Filo,Class,Order,Family,Genre,Specie) VALUES(4,"scientificname4","life4","domain4","kingdom4","filo4","class4","order4","family4","genre4","specie4");

--GENE
INSERT INTO GENE(Name,Size,Sequence,GC_Content,AT_Content) VALUES(0,0,"sequence0","gc_content0","at_content0");
INSERT INTO GENE(Name,Size,Sequence,GC_Content,AT_Content) VALUES(1,1,"sequence1","gc_content1","at_content1");
INSERT INTO GENE(Name,Size,Sequence,GC_Content,AT_Content) VALUES(2,2,"sequence2","gc_content2","at_content2");
INSERT INTO GENE(Name,Size,Sequence,GC_Content,AT_Content) VALUES(3,3,"sequence3","gc_content3","at_content3");
INSERT INTO GENE(Name,Size,Sequence,GC_Content,AT_Content) VALUES(4,4,"sequence4","gc_content4","at_content4");

--PROTEIN_ENTRY
INSERT INTO PROTEIN_ENTRY(AccessionID,FullName,Sequence,ProteinType,GeneName,S_TaxID) VALUES(0,"fullname0","sequence0","proteintype0",3,3);
INSERT INTO PROTEIN_ENTRY(AccessionID,FullName,Sequence,ProteinType,GeneName,S_TaxID) VALUES(1,"fullname1","sequence1","proteintype1",4,1);
INSERT INTO PROTEIN_ENTRY(AccessionID,FullName,Sequence,ProteinType,GeneName,S_TaxID) VALUES(2,"fullname2","sequence2","proteintype2",3,4);
INSERT INTO PROTEIN_ENTRY(AccessionID,FullName,Sequence,ProteinType,GeneName,S_TaxID) VALUES(3,"fullname3","sequence3","proteintype3",0,0);
INSERT INTO PROTEIN_ENTRY(AccessionID,FullName,Sequence,ProteinType,GeneName,S_TaxID) VALUES(4,"fullname4","sequence4","proteintype4",3,4);

--DISEASE
INSERT INTO DISEASE(ICD10Code,Name,Description) VALUES(0,"name0","description0");
INSERT INTO DISEASE(ICD10Code,Name,Description) VALUES(1,"name1","description1");
INSERT INTO DISEASE(ICD10Code,Name,Description) VALUES(2,"name2","description2");
INSERT INTO DISEASE(ICD10Code,Name,Description) VALUES(3,"name3","description3");
INSERT INTO DISEASE(ICD10Code,Name,Description) VALUES(4,"name4","description4");

--PFUNCTION
INSERT INTO PFUNCTION(ID,Description) VALUES(0,"description0");
INSERT INTO PFUNCTION(ID,Description) VALUES(1,"description1");
INSERT INTO PFUNCTION(ID,Description) VALUES(2,"description2");
INSERT INTO PFUNCTION(ID,Description) VALUES(3,"description3");
INSERT INTO PFUNCTION(ID,Description) VALUES(4,"description4");

--PUSER
INSERT INTO PUSER(ID,Name,DateOfBirth,ProfilePicture,University,Profession) VALUES(0,"name0","dateofbirth0","profilepicture0","university0","profession0");
INSERT INTO PUSER(ID,Name,DateOfBirth,ProfilePicture,University,Profession) VALUES(1,"name1","dateofbirth1","profilepicture1","university1","profession1");
INSERT INTO PUSER(ID,Name,DateOfBirth,ProfilePicture,University,Profession) VALUES(2,"name2","dateofbirth2","profilepicture2","university2","profession2");
INSERT INTO PUSER(ID,Name,DateOfBirth,ProfilePicture,University,Profession) VALUES(3,"name3","dateofbirth3","profilepicture3","university3","profession3");
INSERT INTO PUSER(ID,Name,DateOfBirth,ProfilePicture,University,Profession) VALUES(4,"name4","dateofbirth4","profilepicture4","university4","profession4");

--PUBLICATION
INSERT INTO PUBLICATION(ID,Link,User_ID,SubmitionDate) VALUES(0,"link0",4,"submitiondate0");
INSERT INTO PUBLICATION(ID,Link,User_ID,SubmitionDate) VALUES(1,"link1",4,"submitiondate1");
INSERT INTO PUBLICATION(ID,Link,User_ID,SubmitionDate) VALUES(2,"link2",2,"submitiondate2");
INSERT INTO PUBLICATION(ID,Link,User_ID,SubmitionDate) VALUES(3,"link3",1,"submitiondate3");
INSERT INTO PUBLICATION(ID,Link,User_ID,SubmitionDate) VALUES(4,"link4",4,"submitiondate4");

--PUB_AUTHOR
INSERT INTO PUB_AUTHOR(Publication_ID,AuthorName) VALUES(3,"authorname0");
INSERT INTO PUB_AUTHOR(Publication_ID,AuthorName) VALUES(3,"authorname1");
INSERT INTO PUB_AUTHOR(Publication_ID,AuthorName) VALUES(1,"authorname2");
INSERT INTO PUB_AUTHOR(Publication_ID,AuthorName) VALUES(0,"authorname3");
INSERT INTO PUB_AUTHOR(Publication_ID,AuthorName) VALUES(4,"authorname4");

--CURATOR
INSERT INTO CURATOR(User_ID,DateOfContract) VALUES(1,"dateofcontract0");
INSERT INTO CURATOR(User_ID,DateOfContract) VALUES(3,"dateofcontract1");
INSERT INTO CURATOR(User_ID,DateOfContract) VALUES(0,"dateofcontract2");
INSERT INTO CURATOR(User_ID,DateOfContract) VALUES(3,"dateofcontract3");
INSERT INTO CURATOR(User_ID,DateOfContract) VALUES(3,"dateofcontract4");

--PROJECT
INSERT INTO PROJECT(ID,Description) VALUES(0,"description0");
INSERT INTO PROJECT(ID,Description) VALUES(1,"description1");
INSERT INTO PROJECT(ID,Description) VALUES(2,"description2");
INSERT INTO PROJECT(ID,Description) VALUES(3,"description3");
INSERT INTO PROJECT(ID,Description) VALUES(4,"description4");

--PARTICIPATES
INSERT INTO PARTICIPATES(User_ID,Project_ID) VALUES(3,4);
INSERT INTO PARTICIPATES(User_ID,Project_ID) VALUES(0,4);
INSERT INTO PARTICIPATES(User_ID,Project_ID) VALUES(4,0);
INSERT INTO PARTICIPATES(User_ID,Project_ID) VALUES(2,0);
INSERT INTO PARTICIPATES(User_ID,Project_ID) VALUES(1,1);

--CAUSES
INSERT INTO CAUSES(P_AcessionID,Disease_ICD10Code) VALUES(0,3);
INSERT INTO CAUSES(P_AcessionID,Disease_ICD10Code) VALUES(3,3);
INSERT INTO CAUSES(P_AcessionID,Disease_ICD10Code) VALUES(0,2);
INSERT INTO CAUSES(P_AcessionID,Disease_ICD10Code) VALUES(3,0);
INSERT INTO CAUSES(P_AcessionID,Disease_ICD10Code) VALUES(0,3);

--HAS_FUNCTION
INSERT INTO HAS_FUNCTION(P_AccessionID,Function_ID) VALUES(3,1);
INSERT INTO HAS_FUNCTION(P_AccessionID,Function_ID) VALUES(0,2);
INSERT INTO HAS_FUNCTION(P_AccessionID,Function_ID) VALUES(2,0);
INSERT INTO HAS_FUNCTION(P_AccessionID,Function_ID) VALUES(2,3);
INSERT INTO HAS_FUNCTION(P_AccessionID,Function_ID) VALUES(4,1);

--INTERACTION
INSERT INTO INTERACTION(P_AccessionID,P2_AccessionID) VALUES(1,3);
INSERT INTO INTERACTION(P_AccessionID,P2_AccessionID) VALUES(3,2);
INSERT INTO INTERACTION(P_AccessionID,P2_AccessionID) VALUES(2,2);
INSERT INTO INTERACTION(P_AccessionID,P2_AccessionID) VALUES(0,2);
INSERT INTO INTERACTION(P_AccessionID,P2_AccessionID) VALUES(2,3);

--MENTION_INTERACTION
INSERT INTO MENTION_INTERACTION(I_P_AccessionID,I_P2_AccessionID,Publication_ID) VALUES(3,3,4);
INSERT INTO MENTION_INTERACTION(I_P_AccessionID,I_P2_AccessionID,Publication_ID) VALUES(1,2,2);
INSERT INTO MENTION_INTERACTION(I_P_AccessionID,I_P2_AccessionID,Publication_ID) VALUES(3,3,1);
INSERT INTO MENTION_INTERACTION(I_P_AccessionID,I_P2_AccessionID,Publication_ID) VALUES(1,3,1);
INSERT INTO MENTION_INTERACTION(I_P_AccessionID,I_P2_AccessionID,Publication_ID) VALUES(2,2,2);

--APROVAL_MENTION_INTERACTION
INSERT INTO APROVAL_MENTION_INTERACTION(Curator_ID,M_I_P_AccessionID,M_I_P2_AccessionID,M_Publication_ID,DateOfApproval) VALUES(3,3,3,1,"dateofapproval0");
INSERT INTO APROVAL_MENTION_INTERACTION(Curator_ID,M_I_P_AccessionID,M_I_P2_AccessionID,M_Publication_ID,DateOfApproval) VALUES(3,2,2,1,"dateofapproval1");
INSERT INTO APROVAL_MENTION_INTERACTION(Curator_ID,M_I_P_AccessionID,M_I_P2_AccessionID,M_Publication_ID,DateOfApproval) VALUES(3,3,3,2,"dateofapproval2");
INSERT INTO APROVAL_MENTION_INTERACTION(Curator_ID,M_I_P_AccessionID,M_I_P2_AccessionID,M_Publication_ID,DateOfApproval) VALUES(3,3,2,1,"dateofapproval3");
INSERT INTO APROVAL_MENTION_INTERACTION(Curator_ID,M_I_P_AccessionID,M_I_P2_AccessionID,M_Publication_ID,DateOfApproval) VALUES(3,1,2,2,"dateofapproval4");

--MENTION_FUNCTION
INSERT INTO MENTION_FUNCTION(P_AccessionID,F_ID,Publication_ID) VALUES(4,0,2);
INSERT INTO MENTION_FUNCTION(P_AccessionID,F_ID,Publication_ID) VALUES(3,1,2);
INSERT INTO MENTION_FUNCTION(P_AccessionID,F_ID,Publication_ID) VALUES(0,2,3);
INSERT INTO MENTION_FUNCTION(P_AccessionID,F_ID,Publication_ID) VALUES(2,3,4);
INSERT INTO MENTION_FUNCTION(P_AccessionID,F_ID,Publication_ID) VALUES(3,4,3);

--APROVAL_MENTION_FUNCTION
INSERT INTO APROVAL_MENTION_FUNCTION(Curator_ID,M_F_P_AccessionsID,M_I_F_ID,M_Publication_ID,DateOfApproval) VALUES(1,4,1,4,"dateofapproval0");
INSERT INTO APROVAL_MENTION_FUNCTION(Curator_ID,M_F_P_AccessionsID,M_I_F_ID,M_Publication_ID,DateOfApproval) VALUES(3,3,1,4,"dateofapproval1");
INSERT INTO APROVAL_MENTION_FUNCTION(Curator_ID,M_F_P_AccessionsID,M_I_F_ID,M_Publication_ID,DateOfApproval) VALUES(3,4,3,4,"dateofapproval2");
INSERT INTO APROVAL_MENTION_FUNCTION(Curator_ID,M_F_P_AccessionsID,M_I_F_ID,M_Publication_ID,DateOfApproval) VALUES(3,2,4,3,"dateofapproval3");
INSERT INTO APROVAL_MENTION_FUNCTION(Curator_ID,M_F_P_AccessionsID,M_I_F_ID,M_Publication_ID,DateOfApproval) VALUES(3,3,3,4,"dateofapproval4");
