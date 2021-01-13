Insert into `basketbal`.`team` (Owner, Name)
Select FirstName, LastName
from `basketbal`.`speler`


Insert into speler_team (idPlayer, idTeam)
Select idPlayer, idTeam
from speler
where idPlayer = 5


INSERT INTO statistiek (Points, Rebounds, Assists, Blocks)
  VALUES(25,4,5,3);
INSERT INTO speler (LastName, FirstName, ActiveTeam, Games) 
  VALUES('Mout','Kevin','Bulls', 23);


Declare @

select speler_info.*
From speler
join speler_info
where speler.idPlayer = 2 and speler_info.idPlayer = 2



INSERT INTO speler(idPlayer, idTeam)
SELECT speler.idPlayer, team.idTeam
FROM speler, team
where speler.idPlayer = 2 and statistiek.idPlayer = 2;

insert into speler_info(idPlayer,Points)
select 3 ,25
From speler
join speler_info



Insert into speler Values(NULL, 'Mout', 'Kevin', 'Bulls');
Insert into speler_info Values(SELECT max(id) FROM table, 25,5,4,3, 'Dutch')
