/*
 Pre-Deployment Script Template                     
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.   
 Use SQLCMD syntax to include a file in the pre-deployment script.         
 Example:      :r .\myfile.sql                        
 Use SQLCMD syntax to reference a variable in the pre-deployment script.      
 Example:      :setvar TableName MyTable                     
               SELECT * FROM [$(TableName)]               
--------------------------------------------------------------------------------------
*/

USE [master]
GO

if (DB_ID(N'MonsterDB') is not null)
begin
   drop database MonsterDB;
end

CREATE DATABASE [MonsterDB]
GO

USE [MonsterDB]
GO

if (schema_id(N'Monster') is not null)
begin
   drop schema Monster
end




