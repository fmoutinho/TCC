CREATE NONCLUSTERED INDEX [L_SUPPKEY__L_SHIPDATE__L_ORDERKEY] ON [dbo].[LINEITEM]
(
	[L_SUPPKEY] ASC,
	[L_SHIPDATE] ASC,
	[L_ORDERKEY] ASC
)
INCLUDE ( 	[L_EXTENDEDPRICE],
	[L_DISCOUNT]) WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]

	--Indice criado pois a query 7 usa as foreign keys nos joins e o campo shipdate é usado em um between , não toruxe prejuizo para as demais consultas