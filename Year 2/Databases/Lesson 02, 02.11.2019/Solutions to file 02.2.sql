/* File 02.2 */

-- Problem 1
CREATE TABLE passports(
	passport_id INT NOT NULL PRIMARY KEY,
	passport_number VARCHAR(45) NOT NULL
);
INSERT INTO passports
VALUES (101, 'N34FG21B'), (102, 'K65LO4R7'), (103, 'K65LO4R7');

CREATE TABLE persons(
	person_id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(45) NOT NULL, 
    salary FLOAT,
    passport_id INT NOT NULL UNIQUE,
    CONSTRAINT fk_passport_id FOREIGN KEY (passport_id) REFERENCES passports(passport_id)
);
INSERT INTO persons
VALUES  (DEFAULT, 'Roberto', 43300.00, 102),
		(DEFAULT, 'Tom', 56100.00, 103),
        (DEFAULT, 'Yana', 60200.00, 101);
        
-- Problem 2
CREATE TABLE manufacturers(
	manufacturer_id INT NOT NULL PRIMARY KEY,
    name VARCHAR(45) NOT NULL, 
    established_on DATE
);
INSERT INTO manufacturers
VALUES (1, 'BMW', '1916-03-01'), (2, 'Tesla', '2003-01-01'), (3, 'Lada', '1966-05-01');

CREATE TABLE models(
	model_id INT NOT NULL PRIMARY KEY,
    name VARCHAR(45) NOT NULL,
    manufacturer_id INT NOT NULL,
    CONSTRAINT fk_manufacturer_id FOREIGN KEY (manufacturer_id) 
    REFERENCES manufacturers(manufacturer_id)
);
INSERT INTO models
VALUES  (101, 'X1', 1), (102, 'i6', 1), (103, 'Model S', 2),
		(104, 'Model X', 2), (105, 'Model 3', 2), (106, 'Nova', 3);

-- Problem 3
CREATE TABLE students(
	student_id INT NOT NULL PRIMARY KEY,
    name VARCHAR(45) NOT NULL
);
INSERT INTO students
VALUES (1, 'Mila'), (2, 'Toni'), (3, 'Ron');

CREATE TABLE exams(
	exam_id INT NOT NULL PRIMARY KEY,
    name VARCHAR(45) NOT NULL
);
INSERT INTO exams
VALUES (101, 'Spring MVC'), (102, 'Neo4j'), (103, 'Oracle 11g');

CREATE TABLE students_exams(
	students_id INT,
    exam_id INT,
    CONSTRAINT pk_studens_exams 
    PRIMARY KEY (students_id, exam_id),
    CONSTRAINT fk_students_id 
    FOREIGN KEY (students_id) REFERENCES students(student_id),
    CONSTRAINT fk_exam_id
    FOREIGN KEY (exam_id) REFERENCES exams(exam_id)
);
INSERT INTO students_exams
VALUES (1, 101), (1, 102), (2, 101), (3, 103), (2, 102), (2, 103);

-- Problem 4
CREATE TABLE managers(
	manager_id INT NOT NULL PRIMARY KEY,
    name VARCHAR(45) NOT NULL,
    teacher_id INT
);
INSERT INTO managers
VALUES  (101, 'Bob', 101), (102, 'Mylo', 101), (103, 'Mila', 101), 
		(104, 'Ron', 101), (105, 'John', 101), (106, 'Mike', 101);

CREATE TABLE teachers(
	teacher_id INT NOT NULL PRIMARY KEY,
    name VARCHAR(45) NOT NULL, 
    manager_id INT,
    CONSTRAINT fk_manager_id 
    FOREIGN KEY (manager_id) REFERENCES managers(manager_id)
);
INSERT INTO teachers
VALUES  (101, 'John', NULL), (102, 'Maya', 106), (103, 'Silvia', 106), 
		(104, 'Ted', 105), (105, 'Mark', 101), (106, 'Greta', 101);

ALTER TABLE managers
ADD CONSTRAINT fk_teacher_id 
FOREIGN KEY (teacher_id) 
REFERENCES teachers(teacher_id);