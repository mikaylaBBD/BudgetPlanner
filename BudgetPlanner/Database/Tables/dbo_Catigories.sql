USE BudgetPlanner
GO
 DROP TABLE IF EXISTS dbo.Categories

CREATE TABLE [dbo].[Categories](
	[id] [INT] NOT NULL,
	[type] [VARCHAR] (60) NOT NULL,
	PRIMARY KEY CLUSTERED ([id])
)
	