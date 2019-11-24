/* File 01.03 */

-- Problem 1
CREATE SCHEMA minions;

USE minions;

-- Problem 2
CREATE TABLE minions(
	id INT PRIMARY KEY NOT NULL,
    name VARCHAR(45),
    age INT
);
CREATE TABLE towns(
	id INT PRIMARY KEY NOT NULL,
    nam VARCHAR(45)
);

-- Problem 3
ALTER TABLE minions
ADD town_id INT;

ALTER TABLE minions
ADD CONSTRAINT fk_town_id
FOREIGN KEY (town_id) REFERENCES towns(id);

-- Problem 4
INSERT INTO towns
VALUES (1, 'Sofia'), (2, 'Plovdiv'), (3,'Varna');

INSERT INTO minions
VALUES (1, 'Kevin', 22, 1), (2, 'Bob', 15, 3), (3, 'Steward', NULL, 2);

-- Problem 5
DELETE FROM minions 
WHERE id > 0;

-- Problem 6
DROP TABLE minions;
DROP TABLE towns;

-- Problem 7
CREATE TABLE people(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    name VARCHAR(200) NOT NULL,
    picture MEDIUMBLOB,
    height FLOAT(2),
    weight FLOAT(2),
    gender CHAR NOT NULL,
    birthdate DATE NOT NULL,
    biography LONGTEXT
);

INSERT INTO people
VALUES  (DEFAULT, 'Alex', NULL, 1.85, 75.1, 'm', '2000-11-09', 'Just a dude having fun'),
		(DEFAULT, 'Chloe', NULL, 1.67, 62.6, 'f', '1998-01-24', 'Almost a student in university'),
		(DEFAULT, 'Max', NULL, 1.73, 67, 'm', '2001-05-13', 'Partying is my life'),
        (DEFAULT, 'Jeff', NULL, 1.80, 80, 'm', '1941-08-02', 'Teacher, 30+ years of exepreince in biology'),
        (DEFAULT, 'Emma', NULL, 1.60, 53, 'f', '1978-03-22', 'Mother and a scientist');

-- Problem 8
CREATE TABLE users(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    username VARCHAR(30) NOT NULL,
    password VARCHAR(26) NOT NULL,
    profile_picture MEDIUMBLOB,
    last_login_time DATETIME,
    is_deleted BOOLEAN NOT NULL
);

INSERT INTO users
VALUES  (DEFAULT, 'BobJefferson01', 'qwerty', NULL, '2019-10-21 18:25:38', false),
		(DEFAULT, 'TheLegend27', 'fh&364^S', NULL, '2018-03-01 09:34:11', true),
        (DEFAULT, 'JidJim', 'password!@#$', NULL, '2019-11-01 14:19:59', false),
        (DEFAULT, 'HappyOctopus', 'kAhTb55&9', NULL, '2016-11-29 23:11:25', false),
        (DEFAULT, 'world_escorter', 'hue*fhg334FhSBb+1$', NULL, '2019-09-03 01:43:53', true);

-- Problem 9

-- Left for now, requires special knowledge

-- Problem 10
ALTER TABLE users CHANGE last_login_time
last_login_time DATETIME DEFAULT CURRENT_TIMESTAMP;

-- Problem 11

-- Left for now, it kind of requires solve for problem 9

-- Problem 12
CREATE SCHEMA movies;

CREATE TABLE directors(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    director_name VARCHAR(45) NOT NULL,
    notes VARCHAR(100)
);
INSERT INTO directors
VALUES  (DEFAULT, 'Todd Phillips', 'Made the highest grossing R-Rated Movie'),
		(DEFAULT, 'Andy Muschietti', NULL),
        (DEFAULT, 'Robert Zemeckis', NULL),
        (DEFAULT, 'James Cameron', 'One of the most sought-after directors in Holywood'),
        (DEFAULT, 'David Fincher', NULL);

CREATE TABLE genres(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    genre_name VARCHAR(45) NOT NULL,
    notes VARCHAR(100)
);
INSERT INTO genres
VALUES  (DEFAULT, 'Horror', "This genre isn't suggested for kids"), -- generally ' ' are used instead of " ", but in this case, in "isn't" it's better to use " " 
		(DEFAULT, 'Comedy', NULL),
        (DEFAULT, 'Thriller', NULL),
        (DEFAULT, 'Drama', NULL),
        (DEFAULT, 'Romance', NULL);

CREATE TABLE categories(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    category_name VARCHAR(45) NOT NULL,
    notes VARCHAR(100)
);
INSERT INTO categories
VALUES  (DEFAULT, 'Action film', NULL),
		(DEFAULT, 'Horror film', NULL),
        (DEFAULT, 'Romantic comedy', NULL),
        (DEFAULT, 'Crime film', NULL),
        (DEFAULT, 'Adventure film', NULL);

CREATE TABLE movies(
	id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(45) NOT NULL,
    director_id INT REFERENCES directors.id,
    copyright_year YEAR,
    length TIME NOT NULL,
    genre_id INT REFERENCES genres.id,
    category_id INT REFERENCES categories.id,
    rating INT,
    notes VARCHAR(45)
);
INSERT INTO movies
VALUES  (DEFAULT, 'Joker (2019)', 1, '2019', '02:02:00', 4, 4, 8, NULL),
		(DEFAULT, 'Back to the Future (1985)', 3, '1985', '01:56:00', 2, 5, 8, NULL),
        (DEFAULT, 'Forrest Gump', 3, '1994', '02:22:00', 2, 3, 8, NULL),
        (DEFAULT, 'It (2017)', 2, '2017', '02:15:00', 1, 2, 7, NULL),
        (DEFAULT, 'Fight Club', 5, '1999', '02:19:00', 4, 1, 9, NULL);
        
-- The rest of the problems are very similar to predvious problems, for now I am leaving them and moving on