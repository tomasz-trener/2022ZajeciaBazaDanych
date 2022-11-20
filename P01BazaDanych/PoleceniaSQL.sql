

create table osoby  -- tworzenie tableki 
(
  id int primary key  identity(1,1),  -- pk to klucz glowny to jest wazne bo baza danych musi wiedziec jaka wartosc jednoznacznie identyfikuje rekord 
  imie varchar(255),
  nazwisko varchar(255),
  wzrost int,
  waga decimal(5,2), -- 102.34
  dataUr datetime2
)

select * from osoby

insert into osoby values ('jan','kowalski',190,90.3,'20221120')







