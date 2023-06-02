from sql.controllers import generic_query as q
maxid = lambda p: q.query_db(f"call max_val('{p}')")[0][0]