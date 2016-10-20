CREATE NONCLUSTERED INDEX [PS_PARTKEY_PS_SUPPKEY] ON [dbo].[PARTSUPP]
(
	[PS_PARTKEY] ASC,
	[PS_SUPPKEY] ASC
)
INCLUDE ( 	[PS_SUPPLYCOST]) WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
	
	
	--criado para a query 9 , pois e desejavel criar indice para foreign keys em uma tabela volumosa