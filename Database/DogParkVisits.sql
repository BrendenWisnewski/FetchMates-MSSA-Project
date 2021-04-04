CREATE TABLE [dbo].[DogParkVisits]
(	
	[DogID] INT PRIMARY KEY NOT NULL,
	
	[Park Name] VARCHAR(50) NOT NULL,
	[Day And Time] DATETIME NOT NULL,
	
	CONSTRAINT [FK_dbo.Dog] FOREIGN KEY ([DogID])
		REFERENCES [dbo].[Dogs] ([DogID])
       
)
