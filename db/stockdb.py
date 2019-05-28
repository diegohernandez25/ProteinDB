import os

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
	_str = ""
	_str.join(str(e) + "," for e in params)[0:(len(_str) - 1)]
	query	= "INSERT INTO " + table + "(" + _str + ") VALUES("
	
	for i in list(range(init, init+qty, 1)):
		_query = query
		_l = list(map(lambda x:"\""+ x + str(i) + "\"", vals))
		for e in _l:
			_query += e + ","
		_query = _query[0:len(_query) - 1]
		_query = _query + ");\n"
		print(_query)
		sql_file.write(_query)

##
# Inserts 1 insert queries into a sql file.
# param> sql_file	file object. Most be open.
# param> table		name of the table.
# param> parmas		list of name of the table columns to insert. 
#					Must be according to order.
# param> vals		list of values to insert. Must be according to ther columns order.
##
def mono_insert_query(sql_file, table, params, vals, idx):
	poly_insert_query(sql_file, table, params, vals, idx, idx)

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
	_str.join(str(e) + "," for e in params)[0:(len(_str) - 1)]
	query	= "INSERT INTO " + table + "(" + _str + ") VALUES("
	l = list(map(lambda x:"\""+ x + "\"", vals))
	for e in l:
		query += e + ","
	query = query[0:len(query) - 1]
	query += ");\n"
	print(query)
	sql_file.write(query)

##
# Low case string elements of a list
# param> l	list of strings
# return> list with all string with lower case character.
##
def low_case_elements(l):
	return [e.lower() for e in l]

#If execute as an isolated file...
if __name__ == '__main__':
	#This is just an example
	path 	 = os.getcwd() + "/insert.sql"
	sql_file = open(path, 'w')
	l	= ["TaxID" , "ScientificName", "Life", "Domain", "Kingdom", "Filo", "Class", 
		"Order", "Family", "Genre", "Specie"]
	v	= low_case_elements(l)
	mono_insert_query(sql_file, "SPECIES",l,v,1)
	poly_insert_query(sql_file, "SPECIES",l,v,1,5)
	insert_query(sql_file, "SPECIES",l,v)
	sql_file.close()
		 

