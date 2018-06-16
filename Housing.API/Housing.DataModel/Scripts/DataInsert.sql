USE [Housing.DataModel.HousingContext]
GO
IF NOT EXISTS (Select * from CodePrefixes)
BEGIN
INSERT INTO [dbo].[CodePrefixes]
           ([UserCodePrefix]
           ,[UserCodeIncrementBy]
           ,[UserCodeNextNo]
           ,[AuditRecordCodePrefix]
           ,[AuditRecordCodeIncrementBy]
		   ,[AuditRecordCodeNextNo]
           ,[AgentCodePrefix]
           ,[AgentCodeIncrementBy]
           ,[AgentCodeNextNo]
           ,[BuyerCodePrefix]
           ,[BuyerCodeIncrementBy]
           ,[BuyerCodeNextNo]
           ,[PropertyCodePrefix]
           ,[PropertyCodeIncrementBy]
           ,[PropertyCodeNextNo]
           ,[PropertyImageCodePrefix]
           ,[PropertyImageCodeIncrementBy]
           ,[PropertyImageCodeNextNo]
           ,[VendorCodePrefix]
           ,[VendorCodeIncrementBy]
           ,[VendorCodeNextNo]
           )
		 VALUES
			   ('US'
			   ,1
			   ,'US00000002'
			   ,'AU'
			   ,1
			   ,'AU00000002'
			   ,'AG'
			   ,1
			   ,'AG00000002'
			   ,'BU'
			   ,1
			   ,'BU00000002'
			   ,'PR'
			   ,1
			   ,'PR00000002'
			   ,'PI'
			   ,1
			   ,'PI00000002'
			   ,'VC'
			   ,1
				,'VC00000002'
			   )
END
GO

IF NOT EXISTS  (SELECT * FROM dbo.SystemUsers)
	INSERT INTO [dbo].[SystemUsers]
			   ([SystemUserCode]
			   ,[SystemUserName]
			   ,[SystemUseType]
			   ,[SystemUserTitle]
			   ,[SystemUserFirstName]
			   ,[SystemUserLastName]
			   ,[SystemUserGender]
			   ,[SystemUserEmail]
			   ,[SystemUserMobile]
			   ,[SystemUserLandLine]
			   ,[SystemUserCreatedDate]
			   ,[SystemUserCreatedBy]
			   ,[SystemUserUpdatedDate]
			   ,[SystemUserUpdatedBy])
		 VALUES
			   ('US00000001'
			   ,'admin'
			   ,3
			   ,'MR'
			   ,'admin'
			   ,'administrator'
			   ,3
			   ,'ajanthan.kt@gmail.com'
			   ,'0406314133'
			   ,'0406314133'
			   ,GETDATE()
			   ,1
			   ,GETDATE()
			   ,1)
GO

IF NOT EXISTS (SELECT * FROM Vendors)
BEGIN
INSERT INTO [dbo].[Vendors]
           ([VendorCode]
           ,[SystemUser_ID]
           ,[VendorCreatedDate]
           ,[VendorCreatedBy]
           ,[VendorUpdatedDate]
           ,[VendorUpdatedBy])
     VALUES
           ('VC00000001'
           ,1
           ,GETDATE()
           ,1
           ,GETDATE()
           ,1)
END
GO

  IF NOT EXISTS(SELECT * FROM SystemSettings)
  BEGIN
  INSERT INTO SystemSettings
			(ExtraLargeDevicePageSize,
				LargeDevicePageSize,
					MediumDevicePageSize,
						SmallDevicePageSize,
							ExtraSmallDevicePageSize)
			   VALUES
				(5,10,20,30,40)
  END
  GO

 IF NOT EXISTS(SELECT * FROM Buyers)
  BEGIN
	INSERT INTO 
		Buyers(BuyerCode,SystemUser_ID,BuyerCreatedDate,BuyerCreatedBy,BuyerUpdatedDate,BuyerUpdatedBy)
	VALUES
		('BU00000001',1,GETDATE(),1,GETDATE(),1)		
  END
  GO

  IF NOT EXISTS(SELECT * FROM Agents)
  BEGIN
	INSERT INTO 
		Agents(AgentCode,SystemUser_ID,AgentCreatedDate,AgentCreatedBy,AgentUpdatedDate,AgentUpdatedBy)
	VALUES
		('AG00000001',1,GETDATE(),1,GETDATE(),1)		
  END
  GO

IF NOT EXISTS (SELECT * FROM PropertyTypes)
BEGIN
INSERT INTO PropertyTypes(PropertyTypeDescription,PropertyTypeCreatedDate,PropertyTypeCreatedBy,PropertyTypeUpdatedDate,PropertyTypeUpdatedBy)
	VALUES('Apartment',GETDATE(),1,GETDATE(),1)
INSERT INTO PropertyTypes(PropertyTypeDescription,PropertyTypeCreatedDate,PropertyTypeCreatedBy,PropertyTypeUpdatedDate,PropertyTypeUpdatedBy)
	VALUES('Townhouse',GETDATE(),1,GETDATE(),1)
INSERT INTO PropertyTypes(PropertyTypeDescription,PropertyTypeCreatedDate,PropertyTypeCreatedBy,PropertyTypeUpdatedDate,PropertyTypeUpdatedBy)
	VALUES('Villa',GETDATE(),1,GETDATE(),1)
INSERT INTO PropertyTypes(PropertyTypeDescription,PropertyTypeCreatedDate,PropertyTypeCreatedBy,PropertyTypeUpdatedDate,PropertyTypeUpdatedBy)
	VALUES('House',GETDATE(),1,GETDATE(),1)
END
GO

IF NOT EXISTS (SELECT * FROM Properties)
BEGIN
INSERT INTO [dbo].[Properties]
           ([PropertyCode]
           ,[PropertyShortDescription]
           ,[PropertyDescription]
           ,[PropertyFeatures]
           ,[PropertyLocation]
           ,[PropertyCreatedDate]
           ,[PropertyCreatedBy]
           ,[PropertyUpdatedDate]
           ,[PropertyUpdatedBy]
           ,[PropertyType_ID]
           ,[PropertyAdvertisementStartDate]
           ,[PropertyAdvertisementFinishDate]
           ,[IsActive]
           ,[AdvertisementType]
           ,[PropertyPrice]
           ,[Bedrooms]
           ,[Restrooms]
           ,[CarParks])          
     VALUES
           ('PR00000001'
           ,'House Sale in Chadstone'
           ,'A new house for sale in Chadstone'
           ,'The features are enless'
           ,'Chadstore'
           ,GetDate()
           ,1
           ,GetDate()
           ,1
           ,3
           ,GetDate()
           ,DATEADD(day,15, GetDate())
           ,0
           ,1
           ,4000
           ,2
           ,1
           ,1)
END
GO

IF NOT EXISTS (SELECT * FROM PropertyAgents)
BEGIN
INSERT INTO 
	PropertyAgents
		(PropertyAgentCreatedDate,PropertyAgentCreatedBy,PropertyAgentUpdatedDate,PropertyAgentUpdatedBy,Property_ID)
VALUES 
		(GETDATE(),1,GETDATE(),1,1)
END
GO

IF NOT EXISTS (SELECT * FROM PropertyBuyers)
BEGIN
INSERT INTO 
	PropertyBuyers
		(PropertyBuyerCreatedDate,PropertyBuyerCreatedBy,PropertyBuyerUpdatedDate,PropertyBuyerUpdatedBy,Property_ID)
VALUES 
		(GETDATE(),1,GETDATE(),1,1)
END
GO

IF NOT EXISTS (SELECT * FROM PropertyInterestedUsers)
BEGIN
INSERT INTO 
	PropertyInterestedUsers
		(PropertyInterestedUserCreatedDate,PropertyInterestedUserCreatedBy,PropertyInterestedUserUpdatedDate,PropertyInterestedUserUpdatedBy,Property_ID,SystemUser_ID)
VALUES 
		(GETDATE(),1,GETDATE(),1,1,1)
END
GO

IF NOT EXISTS (SELECT * FROM PropertyVendors)
BEGIN
INSERT INTO 
	PropertyVendors
		(PropertyVendorCreatedDate,PropertyVendorCreatedBy,PropertyVendorUpdatedDate,PropertyVendorUpdatedBy,Property_ID)
VALUES 
		(GETDATE(),1,GETDATE(),1,1)
END
GO

SELECT * FROM Agents
SELECT * FROM AuditRecords
SELECT * FROM Buyers
SELECT * FROM CodePrefixes
SELECT * FROM Properties
SELECT * FROM PropertyAgents
SELECT * FROM PropertyBuyers
SELECT * FROM PropertyImages
SELECT * FROM PropertyInterestedUsers
SELECT * FROM PropertyTypes
SELECT * FROM PropertyVendors
SELECT * FROM SystemSettings
SELECT * FROM SystemUsers
SELECT * FROM Vendors
