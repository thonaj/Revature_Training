/*
Post-Deployment Script Template                     
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.      
 Use SQLCMD syntax to include a file in the post-deployment script.         
 Example:      :r .\myfile.sql                        
 Use SQLCMD syntax to reference a variable in the post-deployment script.      
 Example:      :setvar TableName MyTable                     
               SELECT * FROM [$(TableName)]               
--------------------------------------------------------------------------------------
*/
use ToDoAppDB
go

insert into ToDoApp.Items(ItemName,Completed) values 
(N'item1', 1),
(N'item2',1),
(N'item3',0),
(N'item4', 0),
(N'item5',1),
(N'item6',1),
(N'item7', 0),
(N'item8',1),
(N'item9',1),
(N'item10', 1),
(N'item11',1),
(N'item12',0);

go