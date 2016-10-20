SET ANSI_PADDING ON

CREATE NONCLUSTERED INDEX [L_SHIPMODE__L_RECEIPTDATE__L_RECEIPTDATE__L_SHIPDATE__L_COMMITDATE] ON [dbo].[LINEITEM]
(
	[L_SHIPMODE] ASC,
	[L_RECEIPTDATE] ASC,
	[L_SHIPDATE] ASC,
	[L_COMMITDATE] ASC
)WITH (SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]


