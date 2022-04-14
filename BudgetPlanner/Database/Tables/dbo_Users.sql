USE BudgetPlanner
GO
 DROP TABLE IF EXISTS [dbo].[Users]

CREATE TABLE [dbo].[Users](
	[username] [VARCHAR] (100) NOT NULL,
	[token] [VARCHAR] (200) NOT NULL
	PRIMARY KEY CLUSTERED ([token])
)
	