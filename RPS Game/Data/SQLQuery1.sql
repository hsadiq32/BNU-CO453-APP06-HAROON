
CREATE TABLE [dbo].[ScoreBoard] (
	[ID] int not null identity,
	[Name] nvarchar(255),
	[WinRate] float(4) not null,
	PRIMARY KEY( [ID] )
);