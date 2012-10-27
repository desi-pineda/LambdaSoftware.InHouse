/*
Delete all FK in database.
Rafa Avila
*/
declare @statement varchar(MAX)
declare statements cursor for
SELECT ('ALTER TABLE ' + OBJECT_NAME(f.parent_object_id) + ' DROP ' + f.name) as [statement]
FROM sys.foreign_keys AS f
INNER JOIN sys.foreign_key_columns AS fc ON f.OBJECT_ID = fc.constraint_object_id
INNER JOIN sys.objects AS o ON o.OBJECT_ID = fc.referenced_object_id

open statements
	fetch next from statements into @statement
	while @@FETCH_STATUS = 0
	begin
		exec(@statement)
		fetch next from statements into @statement
	end
close statements
deallocate statements