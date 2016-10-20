CREATE NONCLUSTERED INDEX [L_COMMITDATE__L_ORDERKEY__L_RECEIPTDATE] ON [dbo].[LINEITEM]
(
	[L_COMMITDATE] ASC,
	[L_ORDERKEY] ASC,
	[L_RECEIPTDATE] ASC
)WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]

--Criado para a query 4, usando uma foreign key e campos date que se relacionam na clausula where. Não trouxe prejuízo para as demais consultas
