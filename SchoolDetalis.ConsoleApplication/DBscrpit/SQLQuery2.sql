 Create Table [SchoolDetails]
(
Id bigint not null primary key identity(1,1),
    [SchoolName] [nvarchar] (50) NOT NULL,
    [Address] [nvarchar] (200) NOT NULL,
	[StortedDate] [datetime2](7) NOT NULL,
	PhoneNumber bigint not null ,
	Email_id nvarchar(50) not null
)
drop table SchoolDetails
drop procedure SchoolDetailsInsert
select * from SchoolDetails
create procedure SchoolDetailsInsert

(@SchoolName nvarchar (50),@Address nvarchar (200),@StortedDate datetime2(7) ,@PhoneNumber bigint ,@Email_id nvarchar(50))
as
begin
insert into SchoolDetails values (@SchoolName,@Address,@StortedDate,@PhoneNumber,@Email_id)
end

create procedure SchoolDetailsUpdate

(@Id bigint,@SchoolName nvarchar (50),@Address nvarchar (200),@StortedDate datetime2(7) ,@PhoneNumber bigint ,@Email_id nvarchar(50))
as
begin
update SchoolDetails set SchoolName=@SchoolName,Address=@Address,StortedDate=@StortedDate,PhoneNumber=@PhoneNumber,Email_id=@Email_id where Id=@Id
end

create procedure SchoolDetailstDelete
(@Id bigint)
as
begin
delete SchoolDetails  where id=@id
end


create procedure FindSchoolDetailsByNumber
(@Id bigint)
as
begin
select* from SchoolDetails  where Id=@Id
end

create procedure SchoolDetailsRead
as
begin
select* from SchoolDetails 
end


exec SchoolDetailsInsert 'BVBSchool','FF4V+8VC,Sivagiripatti,TamilNadu 624601','5/5/2023',9011467835,'bvb@email.com'
exec SchoolDetailsInsert'PonnuSchool','PGRP+23X,Hanumandapuram,Dharapuram,TamilNadu 638656','5/5/2023',9111467835,'ponnu@email.com'
exec SchoolDetailsUpdate 2,'PonnuSchool','PGRP+23X,Hanumandapuram,Dharapuram,TamilNadu 638656','5/5/2023',9911467835,'ponnu@email.com'
exec SchoolDetailstDelete 2
exec FindSchoolDetailsByNumber 1
exec SchoolDetailsRead