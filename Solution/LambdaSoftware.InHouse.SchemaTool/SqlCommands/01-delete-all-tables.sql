/*
Delete all tables in database.
Rafa Avila
*/

declare @statement varchar(max)
select @statement = coalesce(@statement, '') + 'drop table [dbo].' + QUOTENAME(TABLE_NAME) + ';' + char(13) where TABLE_SCHEMA = 'dbo'

-- print(@statement)
exec(@statement)
