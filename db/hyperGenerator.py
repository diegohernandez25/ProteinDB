import requests, sys, json, re

proteinL=[]
speciesL=[]
geneL=[]
diseasesL=[]
functionsL=[]
publicationsL=[
    {
        'publication_id': 1,
        'link': "www.link.com",
        'title': "dummy pub",
        'date':"2019-05-30",
        'authors': ["rodrigo"],
        'user': 1
    }
]
function_mentionsL=[]
protein_mentionsL=[]
usersL=[
  {
    'id':1,
    'name': "Rodrigo",
    'university': "UA",
    'profession': "Student",
    'birth': "9-02-1996" ,
    'pic_link':"link",
    'is_curator': True,
  },
  {
    'id':2,
    'name': "Diego",
    'university': "UA",
    'profession': "Student",
    'birth': "9-03-1996" ,
    'pic_link':"link",
    'is_curator': False
  }
]
projectsL=[
  {
    'id':1,
    'name': "Criação de uma base de dados de proteinas"
  }
]

participationL=[
    {
        "userID":1,
        "projectID":1
    }
]

causesL=[

]

def newProtein(id,sequence,protein_type,gene_associated, specie_associated):
    global proteinL
    newProtein={'id':id,
    'sequence':sequence ,
    'protein_type':protein_type ,
    'gene_associated': gene_associated,
    'specie_associated': specie_associated
    }
    if not any(protein['id'] == id for protein in proteinL):
        proteinL.append(newProtein)
    return id

def newSpecies(id,sName,dominio,reino,filo,classe,ordem,familia,genero):
    global speciesL
    newSpecie={
        'scientific_name': sName,
        'tax_id':id,
        'dominio':dominio,            
        'reino':reino ,               
        'filo': filo,
        'classe': classe,
        'ordem': ordem,
        'familia': familia,
        'genero': genero
        }
    if not any(specie['tax_id'] == id for specie in speciesL):
        speciesL.append(newSpecie)
    return id   

def newGene(code,name,sequence):
    global geneL
    newGene= {
            'code': code ,
            'name': name,
            'sequence': sequence, 
            'gc_content':sequence.count('G')+sequence.count('C'),
            'at_content':sequence.count('A')+sequence.count('T'), 
            'size': len(sequence)
        }
    if not any(gene['code'] == code for gene in geneL):  
        geneL.append(newGene)

    return code 

def newDisease(code,description):
    global diseasesL
    newDisease={
    'code': code,
    'description': description,
    }
    if not any(disease['code'] == code for disease in diseasesL):
        diseasesL.append(newDisease)
    return code

def newFunction(id,description):
    global functionsL
    newFunction={
    'func_id': id,
    'description': description,
    }
    if not any(function['func_id'] == id for function in functionsL):
        functionsL.append(newFunction)
    return id

def newPublication(id,link,title,date,authors,user):
    global publicationsL
    newPublication= {
        'publication_id': id,
        'link': link,
        'title': title,
        'date':"2019-05-29",
        'authors': authors,
        'user':user
    }
    if not any(publication['publication_id'] == id for publication in publicationsL):
        publicationsL.append(newPublication)
    return id

def newFMention(protein_id,function_id, publication_id,approval_date, curator_id):
    global function_mentionsL
    newFMention= {
        'protein_id':protein_id,
        'function_id': function_id,
        'publication_id':publication_id,
        'approval_date': approval_date,
        'curator_id': curator_id
    }

    if not any(FM['protein_id'] == protein_id and FM['function_id'] == function_id and FM['publication_id'] == publication_id for FM in function_mentionsL):
        function_mentionsL.append(newFMention)
    

def newPMention(protein1_accenssion, publication_id,approval_date, curator_id):
    global protein_mentionsL
    newIMention= {
        'protein1_accenssion':protein1_accenssion,
        'publication_id':publication_id,
        'approval_date': approval_date,
        'curator_id': curator_id
    }
    if not any(PM['protein1_accenssion'] == protein1_accenssion and PM['publication_id'] == publication_id for PM in protein_mentionsL):
        protein_mentionsL.append(newIMention)
 
def newCause(protein_code,disease_code):
    global causesL
    newCause=  {
        "protein_code":protein_code,
        "disease_code":disease_code
    }
    if not any(cause['protein_code'] == protein_code and cause['disease_code'] == disease_code for cause in causesL):
        causesL.append(newCause)
   
#------------------------------------Processing----------------------------------------

def processSpecies():
    global speciesL
    global fle
    for specie in speciesL:
        fle.write("INSERT INTO SPECIES VALUES (%d,\'%s\',\'%s\',\'%s\',\'%s\',\'%s\',\'%s\',\'%s\',\'%s\');\n" %
        (specie['tax_id'],
        specie['scientific_name'],
        specie['dominio'],
        specie['reino'],
        specie['filo'],
        specie['classe'],
        specie['ordem'],
        specie['familia'],
        specie['genero'])
        )


def processGenes():
    global geneL
    global fle
    for gene in geneL:
        print(type(gene['code']) )
        fle.write("INSERT INTO GENE VALUES (\'%s\',\'%s\',%d,\'%s\',%d,%d);\n" %
            (
            gene['code'],
            gene['name'],
            gene['size'],
            gene['sequence'],
            gene['gc_content'],
            gene['at_content']
            )
        )

def processProteins():
    global proteinL
    global fle
    for protein in proteinL:
        fle.write("INSERT INTO PROTEIN_ENTRY VALUES (\'%s\',\'%s\',\'%s\',\'%s\',%d);\n" %
            (
            protein['id'],
            protein['sequence'],
            protein['protein_type'],
            protein['gene_associated'],
            protein['specie_associated']
            )
        )


def processDiseases():
    global diseasesL
    global fle
    for disease in diseasesL:
        fle.write("INSERT INTO DISEASE VALUES (\'%s\',\'%s\');\n" %
            (
            disease['code'],
            disease['description']
            )
        )

def processCauses():
    global causesL
    global fle
    print(causesL)
    for cause in causesL:
        fle.write("INSERT INTO CAUSES VALUES (\'%s\',\'%s\');\n" %
            (
                cause['protein_code'],
                cause['disease_code']
            )
        )

def processUsers():
    global usersL
    global fle
    for user in usersL:
        fle.write("INSERT INTO PUSER VALUES (%d,\'%s\',\'%s\',\'%s\',\'%s\',\'%s\');\n" %
            (
                user['id'],
                user['name'],
                user['birth'],
                user['pic_link'],
                user['university'],
                user['profession']
            )
        )
        if user['is_curator']:
            fle.write("INSERT INTO CURATOR VALUES (%d,\'%s\');\n" % (user['id'],"2019-05-29"))

def processProjects():
    global projectsL
    global fle
    for project in projectsL:
        fle.write("INSERT INTO PROJECT VALUES (%d,\'%s\');\n" %
            (
                project['id'],
                project['name']
            )
        )
 

def processPublications():
    global publicationsL
    global fle
    for publication in publicationsL:
        print(publication)
        fle.write("INSERT INTO PUBLICATION VALUES (%d,\'%s\',\'%s\',%d,\'%s\');\n" %
            (
                publication['publication_id'],
                publication['link'],
                publication['title'].translate(str.maketrans({"'":  r""})),
                publication['user'],
                publication['date'],
            )
        )
        for author in  publication['authors']:
            auth=author.translate(str.maketrans({"'":  r""}))
            print(auth)    
            fle.write("INSERT INTO PUB_AUTHOR VALUES (%d,\'%s\');\n" %  (publication['publication_id'],auth))


def processParticipation():
    global participationL
    global fle
    for participation in participationL:
        fle.write("INSERT INTO PARTICIPATES VALUES (%d,%d);\n" %
            (
                participation['userID'],
                participation['projectID']
            )
        )

def processFunctions():
    global functionsL
    global fle
    for function in functionsL:
        fle.write("INSERT INTO PFUNCTION VALUES (%s,\'%s\');\n" %
            (
                function['func_id'][3:],
                function['description']
            )
        )

def processFMentions():
    global function_mentionsL
    global fle
    for FM in function_mentionsL:
        fle.write("INSERT INTO MENTION_FUNCTION VALUES (\'%s\',%s,%d);\n" %
            (
                FM['protein_id'],
                FM['function_id'][3:],
                FM['publication_id']
            )
        )

        fle.write("INSERT INTO APROVAL_MENTION_FUNCTION VALUES (%d,\'%s\',%s,%d,\'%s\');\n" %
         (
             1,
             FM['protein_id'],
             FM['function_id'][3:],
             FM['publication_id'],
             "2019-05-30"
         )
         )

def processPMentions():
    global protein_mentionsL
    global fle
    for PM in protein_mentionsL:
        fle.write("INSERT INTO MENTION_PROTEIN VALUES (\'%s\',\'%d\');\n" %
            (
                PM['protein1_accenssion'],
                PM['publication_id']
            )
        )

        fle.write("INSERT INTO APROVAL_MENTION_PROTEIN VALUES (%d,\'%s\',%d,\'%s\');\n" %
         (
             1,
             PM['protein1_accenssion'],
             PM['publication_id'],
             "2019-05-30"
         )
         )

 

 
        




#------------------------------------MAIN---------------------------------------
def main():
    requestURL = "https://www.ebi.ac.uk/proteins/api/proteins?offset=0&size=20&reviewed=true&gene=OXT,IDS&taxid=9606&isoform=0"

    r = requests.get(requestURL, headers={ "Accept" : "application/json"})

    if not r.ok:
        r.raise_for_status()
        sys.exit()

    responseBody = r.text

    jsn=json.loads(responseBody)
    
    for item in jsn:
        #print(item['accession'])
        requestURLD = "http://www.disgenet.org/api/gda/gene/uniprot/"+item['accession']+"?format=json"

        rD = requests.get(requestURLD, headers={ "Accept" : "application/json"})
 
        if rD.ok:
            responseBodyD = rD.text
            jsonDisease=json.loads(responseBodyD)
            
            for disease in jsonDisease:
                if disease['score'] >= 0.4:
                    newDisease(disease['diseaseid'],disease['disease_name'])
                    newCause(item['accession'],disease['diseaseid'])
                    #print("--Disease Found-- " + disease['disease_name'] +"; code:"+disease['diseaseid']) 
        else:
            print("no diseases acossiated with protein "+item['accession']) 

        org=item['organism']
       
        
        newSpecies(org['taxonomy'],org['names'][0]['value'],org['lineage'][0],org['lineage'][1],
                    org['lineage'][2], org['lineage'][6], org['lineage'][9], org['lineage'][12], 
                    org['lineage'][13])


        #Get Gene Sequence ---------------------------------------------------------------
        requestURL = "https://www.ebi.ac.uk/proteins/api/genecentric?offset=0&size=100&accession="+item['accession']

        r = requests.get(requestURL, headers={ "Accept" : "application/json"})
        ensembleID="1"
        geneName=item['gene'][0]['name']['value']
        if r.ok:
            responseBody = r.text
            respJson=json.loads(responseBody)
            for relGene in respJson[0]['relatedGene']:
                if relGene['geneNameType']== "Ensembl":
                    ensembleID=relGene['geneName']
                    break
            
        requestURL = "https://rest.ensembl.org/sequence/id/"+ensembleID
        r = requests.get(requestURL, headers={ "Accept" : "application/json"})
        if r.ok:
            responseBody = r.text
            geneJson=json.loads(responseBody)
            newGene(ensembleID,geneName,geneJson['seq']) 
        else:
            print ("something went wrong")


        newProtein(item['accession'],item['sequence']['sequence'],item['protein']['recommendedName']['fullName']['value'],ensembleID,org['taxonomy'])


        
        for reference in item['references']:
            try:
                pubID=hash(reference['citation']['title']) % (10**8)
                
                newPublication(pubID,"www.link.com",reference['citation']['title'],"2019-05-30",reference['citation']['authors'],2)
                newPMention(item['accession'],pubID,reference['citation']['publicationDate'], 1)
            except:
                print("No document")

        for dbreference in item['dbReferences']:
            if dbreference['type']=="GO":
                requestURL = "https://www.ebi.ac.uk/QuickGO/services/ontology/go/terms/"+dbreference['id']+"/complete"
                r = requests.get(requestURL, headers={ "Accept" : "application/json"})
                if r.ok:
                    responseBody = r.text
                    funcJson=json.loads(responseBody)
                    if funcJson['results'][0]['aspect']=="molecular_function":
                        newFunction(dbreference['id'],funcJson['results'][0]['name'])
                        newFMention(item['accession'],dbreference['id'], 1,"2019-05-29", 1)
                else:
                    print ("something went wrong in func")
                


    global diseasesL
    global causesL
    global speciesL
    global geneL
    global proteinL
    global publicationsL
    global functionsL
    global function_mentionsL
    global protein_mentionsL
   ### print(diseasesL)
    #print(causesL)
    #print(speciesL)
    #print(len(geneL))
    #print(proteinL)
   # print(publicationsL)
    #print(functionsL)
    #print(function_mentionsL)


    processSpecies()
    processGenes()
    processProteins()
    processDiseases()
    processCauses()
    processUsers()
    processProjects()
    processParticipation()
    processPublications()
    processFunctions()
    processPMentions()
    processFMentions()


    

  
if __name__== "__main__":
    fle=open("insertions.sql", "x")
    main()
