USE BudgetPlanner
GO
 DROP TABLE IF EXISTS dbo.[Transactions]

CREATE TABLE [dbo].[Transactions](
	[id] [INT] NOT NULL,
	[amount] [DECIMAL] (18,2) NOT NULL,
	[account] [INT] FOREIGN KEY REFERENCES  [dbo].[Accounts](id),
	[categories] [INT] FOREIGN KEY REFERENCES  [dbo].[Categories](id),
	[user] [VARCHAR](200) FOREIGN KEY REFERENCES  [dbo].[Users](token)
	PRIMARY KEY CLUSTERED ([id])
)
	