use master 
go
if exists (select * from sys.databases where name = 'Chat') drop database Chat
go
create database Chat
go
use Chat
go
create table Message(
	MessageId int primary key not null Identity(1,1),
	Content nvarchar(max) not null,
	Time DateTime not null
)
alter table Message
add UserId nvarchar(128) not null
select * from Message
create index MessageId
on Message(MessageId)
alter table Message
add foreign key (UserId) references Users(Id)
