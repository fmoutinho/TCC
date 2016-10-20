CREATE NONCLUSTERED INDEX [L_SHIPDATE__L_ORDERKEY] ON [dbo].[LINEITEM]
(
	[L_SHIPDATE] ASC,
	[L_ORDERKEY] ASC
)
INCLUDE ( 	[L_EXTENDEDPRICE],
	[L_DISCOUNT]) WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]


--Indice criado para a tabela 3 por usar foreign keys de uma tabela grande
--Não trouxe prejuizo para as demais queries