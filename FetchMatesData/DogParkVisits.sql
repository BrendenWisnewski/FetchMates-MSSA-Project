CREATE TABLE [dbo].[DogParkVisits]
(	
	[VisitID] INT Identity(1,1) PRIMARY KEY NOT NULL,
	[DogID] int  NOT NULL,
	[Park Name] VARCHAR(50) NOT NULL,
	[Day And Time] DATETIME NOT NULL,
		
       CONSTRAINT [FK_dbo.Dog] FOREIGN KEY ([DogID])
		REFERENCES [dbo].[Dogs] ([DogID])
)
