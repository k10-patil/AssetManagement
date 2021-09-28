High Level Design : Asset Management

Entities: 
UserInfo.cs 
CompanyInfo.cs
AssetInfoBase.c: Asset related generic fields, Status type Enum
ComputerInfo.cs : JSON/XML serializable
PrinterInfo.cs : JSON/XML serializable


Dtos: (To be exposed for REST APIs consumer apps (also part of SWAGGER documentation))
UserInfoDto.cs 
CompanyInfoDto.cs
ComputerInfoDto.cs
PrinterInfoDto.cs

Option 1: RESTFul APIs 
Controllers: (Client application will use these to interact with backend)
UserAuthController.cs : to handle user authentication
AssetsController.cs : to get list of assets, add/remove asset

Option 2: gRPC 
PROTO files	: will define common DTOS and RPC method signatures, 
			  which between client and server
Using protoc : grpc compiler we can generate below
Server side classes(skeleton) will be generated in C#/Java/C++  and used by server code
Client side  (stub) JAVAScript will be generated and used by client application

Services: (All the bussiness logic shall be part of these services, we can add new services as per new requirements)
UserAuthenticationService.cs
AssetAllocationService.cs
AssetPricingService.cs


Repository: (To enable de-coupling between database and backend application)
IDataRepository.cs
IAssetRepository.cs
IUserRepository.cs

<MONGO DB>
MongoAssetRepository.cs
MongoUserRepository.cs

<SQL DB>
SQLAssetRepository.cs
SQLUserRepository.cs

Database:
Table: User
Id, Username, Password, CompanyId

Table: Company
Id, Name, Location

Table: Asset (Assuming Asset can belong to only one company)
Id, Name, Type, CompanyId, Status, Value, AssetProperites <field : XML/JSON>

Table: UserAssetMappning
MapId, AssetId, UserId

Client Application:
IONIC Framework (supports Cross platform) with React can be used.
To reuse same code base for browser as well as mobile application.PWA
https://ionicframework.com/
This client will be calling REST APIs to get the desired data from backend.


