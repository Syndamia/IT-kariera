/* File 03.03 */

USE soft_uni; -- it is in the very first archive from materials folder

-- Problem 2
SELECT * FROM departments;

-- Problem 3
SELECT name FROM departments;

-- Problem 4
SELECT first_name, last_name, salary FROM employees;

-- Problem 5
SELECT first_name, middle_name, last_name FROM employees;

-- Problem 6
SELECT concat(first_name, '.', last_name, '@softuni.bg') AS full_email_address FROM employees;

-- Problem 7
SELECT DISTINCT salary FROM employees;

-- Problem 8
SELECT * FROM employees
WHERE job_title = 'Sales Representative';

-- Problem 9
SELECT first_name, last_name, job_title FROM employees
WHERE salary BETWEEN 20000 AND 30000;

-- Problem 10
SELECT concat(first_name, ' ', 
			IF(middle_name IS NULL, '', concat(middle_name, ' ')), -- this is so people with null names would be just 'first_name last_name'
			last_name) AS full_name 
FROM employees
WHERE salary IN (12500, 14000, 23600, 25000);

-- Problem 11
SELECT first_name, last_name FROM employees
WHERE manager_id IS NULL;

-- Problem 12
SELECT first_name, last_name, salary FROM employees
WHERE salary > 50000
ORDER BY salary DESC;

-- Problem 13
SELECT first_name, last_name FROM employees
ORDER BY salary DESC LIMIT 5;

-- Problem 14
SELECT first_name, last_name FROM employees
WHERE NOT(department_id = 4);

-- Problem 15
SELECT DISTINCT job_title FROM employees
ORDER BY job_title;

-- Problem 16
SELECT * FROM projects
ORDER BY start_date LIMIT 10;

-- Problem 17
SELECT first_name, last_name, hire_date FROM employees
ORDER BY hire_date DESC LIMIT 7;

-- Problem 18
SELECT (IF(department_id IN (1, 2, 4, 11), salary * 1.12, salary)) As salary 
FROM employees;

USE geography;

-- Problem 19
SELECT peak_name FROM peaks
ORDER BY peak_name;

-- Problem 20
SELECT country_name, population FROM countries
WHERE continent_code = 'EU'
ORDER BY population DESC, country_name LIMIT 30;

-- Problem 21
SELECT country_name, country_code,
	(IF(currency_code = 'EUR', 'Euro', 'Not Euro')) AS currency
FROM countries
ORDER BY country_name;

USE diablo;

-- Problem 22
SELECT name FROM characters
ORDER BY name;














