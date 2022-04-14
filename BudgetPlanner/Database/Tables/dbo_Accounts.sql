USE BudgetPlanner
GO
 DROP TABLE IF EXISTS dbo.Accounts

CREATE TABLE [dbo].[Accounts](
	[id] [INT] NOT NULL,
	[type] [VARCHAR] (60) NOT NULL,
	PRIMARY KEY CLUSTERED ([id])
)
	