CREATE TABLE [dbo].[DogParkVisits]
(	
	[VisitID] INT Identity(1,1) PRIMARY KEY NOT NULL,
	[DogID] int REFERENCES dbo.Dogs ([DogID]) NOT NULL,
	[Park Name] VARCHAR(50) NOT NULL,
	[Day And Time] DATETIME NOT NULL,
		
       
)
