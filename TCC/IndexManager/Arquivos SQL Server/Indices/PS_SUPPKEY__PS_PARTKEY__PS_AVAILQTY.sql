CREATE NONCLUSTERED INDEX [PS_SUPPKEY__PS_PARTKEY__PS_AVAILQTY] ON [dbo].[PARTSUPP]
(
	[PS_SUPPKEY] ASC,
	[PS_PARTKEY] ASC,
	[PS_AVAILQTY] ASC
)WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
