SELECT *
FROM Project.Movie

SELECT *
FROM Project.Actor
ORDER BY Project.Actor.ActorID ASC

INSERT Project.MovieActor(MovieId, ActorId)
VALUES
(1, 4),
(1, 1),
(1, 19),
(2, 20),
(2, 2),
(2, 11),
(3, 12),
(3, 3),
(3, 21),
(4, 4),
(4,13),
(4, 22),
(5, 2),
(5, 11),
(5, 20),
(6, 6),
(6, 15),
(6, 23),
(7, 14),
(7, 16),
(7, 7),
(8, 8),
(8, 17),
(8, 10),
(9, 9),
(9, 18),
(9, 5)

Select *
FROM Project.MovieActor