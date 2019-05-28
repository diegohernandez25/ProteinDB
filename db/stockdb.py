import os
from random import randint


##
# Inserts 1 ore more insert queries into a sql file.
# param> sql_file	file object. Most be open.
# param> table		name of the table.
# param> parmas		list of name of the table columns to insert. 
#					Must be according to order.
# param> vals		list of values to insert. Must be according to ther columns order.
# param> init		initial value to concatenate to value.
# param> qty		quantity of insert operations
##
def poly_insert_query(sql_file, table, params, vals, init, qty):
	write_name(sql_file,table)
	_str = ""
	_str = _str.join((str(e) + ",") for e in params)[0:(len(_str) - 1)]
	query	= "INSERT INTO " + table + "(" + _str + ") VALUES("
	query_list = list()
	for i in list(range(init, init+qty, 1)):
		_query = query
		_l = list(map(lambda x:"\""+ x + str(i) + "\"", vals))
		query_list.append([ x + str(i) for x in vals])
		for e in _l:
			_query += e + ","
		_query = _query[0:len(_query) - 1]
		_query = _query + ");\n"
		sql_file.write(_query)
	return query_list

##
# Inserts 1 insert queries into a sql file.
# param> sql_file	file object. Most be open.
# param> table		name of the table.
# param> parmas		list of name of the table columns to insert. 
#					Must be according to order.
# param> vals		list of values to insert. Must be according to ther columns order.
##
def mono_insert_query(sql_file, table, params, vals, idx):
	return poly_insert_query(sql_file, table, params, vals, idx, idx)

##
# Inserts 1 insert queries into a sql file without id concatenation.
# param> sql_file	file object. Most be open.
# param> table		name of the table.
# param> parmas		list of name of the table columns to insert. 
#					Must be according to order.
# param> vals		list of values to insert. Must be according to ther columns order.
##
def insert_query(sql_file, table, params, vals):
	_str = ""
	_str = _str.join((str(e) + ",") for e in params)[0:(len(_str) - 1)]
	query	= "INSERT INTO " + table + "(" + _str + ") VALUES("
	l = list(map(lambda x:"\""+ x + "\"", vals))
	for e in l:
		query += e + ","
	query = query[0:len(query) - 1]
	query += ");\n"
	sql_file.write(query)

##
# Low case string elements of a list
# param> l	list of strings
# return> list with all string with lower case character.
##
def low_case_elements(l):
	return [e.lower() for e in l]


##
# Write comment name table
#
def write_name(sql_file,name):
	sql_file.write("\n--"+name+"\n")

#If execute as an isolated file...
if __name__ == '__main__':
	#This is just an example
	path 	 = os.getcwd() + "/insert.sql"
	sql_file = open(path, 'w')
	
	#Species
	l	= ["TaxID" , "ScientificName", "Life", "Domain", "Kingdom", "Filo", "Class", 
		"Order", "Family", "Genre", "Specie"]
	v_species	= low_case_elements(l)
	v_species 	= poly_insert_query(sql_file, "SPECIES",l,v_species,0,5)
	
	#Gene
	l	= ["Name", "Size", "Sequence", "GC_Content", "AT_Coontent"]
	v_gene	= low_case_elements(l)
	v_gene	= poly_insert_query(sql_file, "GENE",l,v_gene,0,5)

	#ProteinEntry
	write_name(sql_file,"PROTEIN_ENTRY")
	l 	= ["AccessionID", "FullName", "Sequence", "ProteinType", "GeneName", "S_TaxID"]
	v = low_case_elements(l)
	v_prot_entry = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[4] = v_gene[randint(0,4)][0]
		tmp[5] = v_species[randint(0,4)][0]
		insert_query(sql_file, "PROTEIN_ENTRY", l, tmp)
		v_prot_entry.append(tmp)


	#Disease
	l = ["ICD10Code", "Name", "Description"]
	v_disease = poly_insert_query(sql_file,"DISEASE",l,low_case_elements(l),0,5)

	#PFunction
	l = ["ID", "Description"]
	v_pfunction = poly_insert_query(sql_file,"PFUNCTION",l,low_case_elements(l),0,5)
	

		#PUser
	l = ["ID", "Name", "DateOfBirth", "ProfilePicture", "University", "Profession"]
	v_puser = poly_insert_query(sql_file,"PUSER",l,low_case_elements(l),0,5)


	#Publication
	write_name(sql_file, "PUBLICATION")
	l = ["ID","Link","User_ID","SubmitionDate"]
	v = low_case_elements(l)
	v_publication = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[2] = v_puser[randint(0,4)][0]
		insert_query(sql_file, "PUBLICATION", l, tmp)
		v_publication.append(tmp)

	#Pub_Author
	write_name(sql_file, "PUB_AUTHOR")
	l = ["Publication_ID","AuthorName"]
	v = low_case_elements(l)
	v_pubauthor = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[0] = v_publication[randint(0,4)][0]
		insert_query(sql_file, "PUB_AUTHOR", l, tmp)
		v_pubauthor.append(tmp)




	#Curator
	write_name(sql_file, "CURATOR")
	l = ["User_ID", "DateOfContract"]
	v = low_case_elements(l)
	v_curator = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[0] = v_puser[randint(0,4)][0]
		insert_query(sql_file, "CURATOR", l, tmp)
		v_curator.append(tmp)

	#Project
	l = ["ID", "Description"]
	v_project = poly_insert_query(sql_file,"PROJECT",l,low_case_elements(l),0,5)

	#Participates
	write_name(sql_file, "PARTICIPATES")
	l = ["User_ID","Project_ID"]
	v = low_case_elements(l)
	v_participates = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[0] = v_puser[randint(0,4)][0]
		tmp[1] = v_project[randint(0,4)][0]
		insert_query(sql_file, "PARTICIPATES", l, tmp)
		v_participates.append(tmp)		

	#Causes	
	write_name(sql_file,"CAUSES")
	l = ["P_AcessionID", "Disease_ICD10Code"]
	v = low_case_elements(l)
	v_causes = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[0] = v_prot_entry[randint(0,4)][0]
		tmp[1] = v_disease[randint(0,5)][0]
		insert_query(sql_file, "CAUSES", l, tmp)
		v_disease.append(tmp)

	#Has_Function
	write_name(sql_file,"HAS_FUNCTION")
	l = ["P_AccessionID", "Function_ID"]
	v = low_case_elements(l)
	v_has_function = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[0] = v_prot_entry[randint(0,4)][0]
		tmp[1] = v_pfunction[randint(0,4)][0]
		insert_query(sql_file, "HAS_FUNCTION",l,tmp)
		v_has_function.append(tmp)


	#Interaction
	write_name(sql_file,"INTERACTION")
	l = ["P_AccessionID", "P2_AccessionID"]
	v = low_case_elements(l)
	v_interaction = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[0] = v_prot_entry[randint(0,4)][0]
		tmp[1] = v_prot_entry[randint(0,4)][0]
		insert_query(sql_file, "INTERACTION",l,tmp)
		v_interaction.append(tmp)

	#Mention_Interaction
	write_name(sql_file,"MENTION_INTERACTION")
	l = ["I_P_AccessionID","I_P2_AccessionID","Publication_ID"]
	v = low_case_elements(l)
	v_mention_interaction = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[0] = v_interaction[randint(0,4)][0]
		tmp[1] = v_interaction[randint(0,4)][1]
		tmp[2] = v_publication[randint(0,4)][0]
		insert_query(sql_file, "MENTION_INTERACTION",l,tmp)
		v_mention_interaction.append(tmp)

	#Aproval_Mention_Interaction
	write_name(sql_file,"APROVAL_MENTION_INTERACTION")
	l = ["Curator_ID","M_I_P_AccessionID","M_I_P2_AccessionID","M_Publication_ID",
			"DateOfApproval"]
	v = low_case_elements(l)
	v_aproval_mention_interaction = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[0] = v_curator[randint(0,4)][0]
		tmp[1] = v_mention_interaction[randint(0,4)][0]
		tmp[2] = v_mention_interaction[randint(0,4)][1]
		tmp[3] = v_mention_interaction[randint(0,4)][2]
		insert_query(sql_file, "APROVAL_MENTION_INTERACTION",l,tmp)
		v_aproval_mention_interaction.append(tmp)

	#Mention_Function
	write_name(sql_file,"MENTION_FUNCTION")
	l = ["P_AccessionID", "F_ID", "Publication_ID"]
	v = low_case_elements(l)
	v_mention_function = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[0] = v_prot_entry[randint(0,4)][0]
		tmp[2] = v_publication[randint(0,4)][0]
		insert_query(sql_file, "MENTION_FUNCTION",l,tmp)
		v_mention_function.append(tmp)

	#Aproval_Mention_Function
	write_name(sql_file, "APROVAL_MENTION_FUNCTION")
	l = ["Curator_ID","M_F_P_AccessionsID","M_I_F_ID","M_Publication_ID", "DateOfApproval"]
	v = low_case_elements(l)
	v_aproval_mention_function = list()
	for i in range(5):
		tmp = [e + str(i) for e in v]
		tmp[0] = v_curator[randint(0,4)][0]
		tmp[1] = v_mention_function[randint(0,4)][0]
		tmp[2] = v_mention_function[randint(0,4)][1]
		tmp[3] = v_mention_function[randint(0,4)][2]
		insert_query(sql_file, "APROVAL_MENTION_FUNCTION",l,tmp)
		v_aproval_mention_function.append(tmp)

	sql_file.close()

