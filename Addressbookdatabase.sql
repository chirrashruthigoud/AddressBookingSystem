
--Create Address Book Service Database
create database AddressBookService;
use AddressBookService;


-- delete table
drop table AddressBook;


-- create a Address Book table
create Table AddressBook
(firstName varchar(100), lastName varchar(100), address varchar(300), city varchar(50), state varchar(300), zipcode int, phoneNumber bigint, email varchar(500), StartDate date);

-- Ability to insert new Contacts to Address Book

insert into Address_Book values
('siri', 'Roy', 'MurariNagar', 'Khurja', 'UP', 203131, 7805982523, 'anmol122@gmail.com'),
('shruthi', 'rao', 'PreetViharColony', 'Agra','UP', 784512, 9823659825, 'riya25@gmail.com'),
('sunny', 'Goud', 'VijayNagar', 'Noida', 'UP', 789456, 7502982523, 'piyus2504@gmail.com'),
('pooja', 'Singh', 'ShastriNagar', 'Meerut', 'UP', 258963, 9639026598, 'amit25@gmail.com'),
('Manisha', 'Gupta', 'KalindiKunj', 'Aligarh', 'UP', 357895, 7836152489, 'mahi258@gmail.com');


--View contacts in address book

select * from AddressBook

-- Ability to edit existing contact person using their name
update Address_Book set City='Khurja' where First_Name='riya'
update Address_Book set City='Noida' where First_Name='Manisha'



-- Ability to identify each Address Book with name and Type.
Update AddressBook set StartDate='2020-11-13' where firstName='siri';

-- Ability to understand the size of address book by City and State
select Count(*) as Size_Of_Address_Book_By_City from AddressBook  where City='Noida';
select Count(*) as Size_Of_Address_Book_By_State from AddressBook  where State='UP';

--Retrieve Contacts from the Database that were added in a particular period
select * from AddressBook where StartDate between cast('2018-01-01' as date ) AND GETDATE();

--Retrieve Contacts from the Database by city or state
select * from AddressBook  where City='Agra' 
select * from AddressBook  where state='UP' 

--delete contact details by firstName
delete  AddressBook where firstName='pooja';

