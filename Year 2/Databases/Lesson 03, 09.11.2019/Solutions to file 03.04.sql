/* File 03.04 */

USE soft_uni;

-- Problem 1: Skipped because task doesn't give enough information to insert properly into the tables + certain values lready exist

-- Problem 2
SELECT * FROM towns;
SELECT * FROM departments;
SELECT * FROM employees;

-- Problem 3
SELECT name FROM towns;
SELECT name FROM departments;
SELECT first_name, last_name, job_title, salary FROM employees;

-- Problem 4
UPDATE employees
SET salary = salary * 1.1
WHERE employee_id > 0;


-- Couldn't do exercises 5 and 6 because they require a data base that isn't provided anywhere in the materials