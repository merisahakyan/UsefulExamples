CREATE TABLE [dbo].[Contact_MailingList]
(
	[ContactId] int not null foreign key references Contacts (ContactId),
	[ListId] int not null foreign key references MailList (ListId)
)
