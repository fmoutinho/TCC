
CREATE PROCEDURE Insert_Data_On_Tables(		
										@path VARCHAR(MAX)

)
AS


DECLARE @part		VARCHAR(MAX)
DECLARE @customer	VARCHAR(MAX)
DECLARE @orders		VARCHAR(MAX)
DECLARE @partsupp	VARCHAR(MAX)
DECLARE @supplier	VARCHAR(MAX)
DECLARE @nation		VARCHAR(MAX)
DECLARE @region		VARCHAR(MAX)
DECLARE @lineitem	VARCHAR(MAX)

DECLARE @config		VARCHAR(MAX)
DECLARE @command	VARCHAR(MAX)

SET @config = '.tbl'+' WITH (TABLOCK, DATAFILETYPE='+'char'+', CODEPAGE='+'raw'+', FIELDTERMINATOR = '+'|'+', ROWTERMINATOR = '+'\n'+')'
SET @command = 'BULK INSERT '


SET @part = @command +'PART FROM '+ @path +'part'+ @config
SET @customer = @command +'CUSTOMER FROM '+ @path +'customer'+ @config
SET @orders = @command +'ORDERS FROM '+ @path +'orders'+ @config
SET @partsupp = @command +'PARTSUPP FROM '+ @path +'partsupp'+ @config
SET @supplier = @command +'SUPPLIER FROM '+ @path +'supplier'+ @config
SET @nation = @command +'NATION FROM '+ @path +'nation'+ @config
SET @region = @command +'REGION FROM '+ @path +'region'+ @config
SET @lineitem = @command +'LINEITEM FROM '+ @path +'lineitem'+ @config

EXECUTE(@part)
EXECUTE(@customer)
EXECUTE(@orders)
EXECUTE(@partsupp)
EXECUTE(@supplier)
EXECUTE(@nation)
EXECUTE(@region)
EXECUTE(@lineitem)

