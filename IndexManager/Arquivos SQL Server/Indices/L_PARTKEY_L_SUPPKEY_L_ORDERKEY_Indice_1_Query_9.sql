CREATE NONCLUSTERED INDEX [L_PARTKEY_L_SUPPKEY_L_ORDERKEY] ON [dbo].[LINEITEM]
(
	[L_PARTKEY] ASC,
	[L_SUPPKEY] ASC,
	[L_ORDERKEY] ASC
)
INCLUDE ( 	[L_QUANTITY],
	[L_EXTENDEDPRICE],
	[L_DISCOUNT]) WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]

	--criado para a query 9 , pois e desejavel criar indice para foreign keys em uma tabela volumosa
