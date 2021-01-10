Insert into `basketbal`.`team` (Owner, Name)
Select FirstName, LastName
from `basketbal`.`speler`


Insert into speler_team (idPlayer, idTeam)
Select idPlayer, idTeam
from speler
where idPlayer = 5


INSERT INTO speler_team (idPlayer, idTeam)
SELECT speler.idPlayer, team.idTeam
FROM basketbal.speler, basketbal.team
INNER JOIN basketbal.speler ON speler.idPlayer = speler_team.idPlayer
INNER JOIN basketbal.team ON team.idTeam = speler_team.idTeam
where speler.idPlayer = 5 and team.idTeam = 2;