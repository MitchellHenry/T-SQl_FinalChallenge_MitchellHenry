
DELETE FROM Sale;
DELETE FROM Customer;
DELETE FROM Special_Interests;
DELETE FROM Record;

INSERT INTO Special_Interests(InterestCode,InterestDesc)
VALUES('RR','Rock and Roll'),
('JA','Jazz'),
('RB','Rhythm and Blues');

INSERT INTO Record(RecordID,Title,Performer)
VALUES('PF003','The Wall','Pink Floyed'),
('IX002','Kick','IXNS'),
('SP069','Never Mind The Bollocks','Sex Pistols'),
('PF002','Dark Side of the Moon','Pink Floyed'),
('IX005','Shabooh Shoobah','INXS'),
('SP070','Floggin a Dead Horse','Sex Pistols'),
('PF004','The Endless River','Pink Floyed'),
('PF006','Wish You Were Here','Pink Floyed'),
('SP075','Agents of Anarchy','Sex Pistols'),
('PF007','The Division Bell','Pink Floyed');

INSERT INTO Customer(CustNo,CustName,CustAddress,PostCode,InterestCode)
VALUES(123,'Jimmy Barnes','1 Sesame Street',3000,'RR'),
(456,'Ian Moss','10 Downing Street',4000,'JA'),
(789,'Don Walker','221B Baker Street',5000,'RB'),
(234,'Steve Prestwich','LG1 College Cres, Parkville',6000,'RR'),
(567,'Phil Small','1 Adelaide Avenue',7000,'RB');

INSERT INTO Sale(SaleDate,PricePaid,RecordID,CustNo)
VALUES('1-Dec-2015',30.00,'PF003',123),
('1-Dec-2015',29.95,'IX002',123),
('2-Dec-2015',12.45,'SP069',123),
('5-Dec-2015',30.00,'IX002',123),
('1-Dec-2015',31.00,'PF002',456),
('3-Dec-2015',28.95,'IX005',456),
('6-Dec-2015',13.45,'SP070',456),
('2-Dec-2015',29.00,'PF004',789),
('3-Dec-2015',29.95,'IX002',789),
('1-Dec-2015',45.00,'PF006',234),
('4-Dec-2015',5.67,'SP075',234),
('3-Dec-2015',9.95,'PF007',567);

