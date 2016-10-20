CREATE NONCLUSTERED INDEX [O_ORDERKEY] ON [dbo].[ORDERS]
(
	[O_ORDERKEY] ASC
)
INCLUDE ( 	[O_ORDERDATE]) WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]


	--criado para a query 9 , pois e desejavel criar indice para foreign keys em uma tabela volumosa
