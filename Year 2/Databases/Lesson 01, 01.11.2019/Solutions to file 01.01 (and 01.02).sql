/* File 01.01 and 01.02 */
/* NOTE: These tasks should be performed using a GUI, but for the sake of exercise I did them with queries*/

-- Problem 2
CREATE SCHEMA minions;

USE minions;

-- Problem 3
CREATE TABLE minions(
	id INT(11) PRIMARY KEY NOT NULL,
    name VARCHAR(50) NOT NULL,
    age INT(3)
);

-- Problem 4
INSERT INTO minions
VALUES(1, 'Kevin', 15), (2, 'Bob', 22), (3, 'Steward', NULL);

-- Problem 5
UPDATE minions
SET age = 10
WHERE id = 3;

-- Problem 6
UPDATE minions
SET age = age + 1
WHERE id > 0; -- this is to "bypass" safe mode

-- Problem 7
DELETE FROM minions
WHERE id = 2;

-- Problem 8
CREATE TABLE towns(
	id INT NOT NULL PRIMARY KEY,
    name VARCHAR(50)
);

-- Problem 9 **
ALTER TABLE minions
ADD city_id INT;

ALTER TABLE minions
ADD CONSTRAINT fk_city_id_town_id
FOREIGN KEY (city_id) REFERENCES towns(id);

-- Problem 10
CREATE SCHEMA school;

USE school;

CREATE TABLE students(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    name VARCHAR(45) NOT NULL,
    age INT,
    phone_number INT
);

CREATE TABLE classes(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    name VARCHAR(45),
    max_students INT NOT NULL
);

CREATE TABLE teachers(
	id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    name VARCHAR(45),
    class INT
);

INSERT INTO students (name, age, phone_number)
VALUES ('Alex', 16, 0897876), ('Bob', NULL, 0885652), ('Johnathan', 19, NULL);

UPDATE students
SET AGE = 16 WHERE id = 2;
UPDATE students
SET phone_number = 0894558 WHERE id = 3;

INSERT INTO classes (name, max_students)
VALUES ('A1', 20), (NULL, 20), ('A3', 20), ('B1', 12), (NULL, 12);

UPDATE classes
SET name = 'A2'
WHERE id = 2;
UPDATE classes
SET name = 'B2'
WHERE id = 5;

INSERT INTO teachers (name, class)
VALUES ('Jefferson', 1), ('Bill', NULL);

UPDATE teachers
SET class = 3
WHERE id = 2;