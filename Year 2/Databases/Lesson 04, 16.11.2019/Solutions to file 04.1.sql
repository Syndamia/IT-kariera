/* File 04.1 */

USE soft_uni;

-- Problem 1
SELECT first_name, last_name, salary FROM employees
WHERE salary > 50000
ORDER BY salary DESC;

-- Problem 2
SELECT first_name, last_name FROM employees
ORDER BY salary DESC LIMIT 5;

-- Problem 3
SELECT * FROM employees
ORDER BY salary DESC, first_name ASC, last_name DESC, middle_name ASC;

-- Problem 4
SELECT * FROM projects 
ORDER BY start_date ASC LIMIT 10;

-- Problem 5
SELECT first_name, last_name, hire_date FROM employees
ORDER BY hire_date DESC LIMIT 7;

USE geography;

-- Problem 6
SELECT peak_name FROM peaks
ORDER BY peak_name;

-- Problem 7
SELECT country_name, population FROM countries
WHERE continent_code = 'EU'
ORDER BY population DESC, country_name;

-- Problem 8
SELECT country_name, country_code, (IF(currency_code = 'EUR', 'Euro', 'Not Euro')) AS currency
FROM countries
ORDER BY country_name;