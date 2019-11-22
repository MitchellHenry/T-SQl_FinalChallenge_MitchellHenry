CREATE TABLE [dbo].[Sale]
(
	[SaleDate] DATE NOT NULL , 
    [PricePaid] MONEY NOT NULL, 
    [RecordID] NVARCHAR(50) NOT NULL, 
    [CustNo] INT NOT NULL
	FOREIGN KEY (RecordID) REFERENCES Record,
	FOREIGN KEY (CustNo) REFERENCES Customer,
	PRIMARY KEY (SaleDate,RecordID,CustNo)
)
