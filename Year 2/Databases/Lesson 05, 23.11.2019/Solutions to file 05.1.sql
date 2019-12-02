/* File 05.1 */

USE soft_uni;

-- Problem 1
SELECT e.employee_id, e.job_title, e.address_id, a.address_text 
FROM employees e
JOIN addresses a 
	ON a.address_id = e.address_id
ORDER BY e.address_id ASC LIMIT 5;

-- Problem 2
SELECT e.employee_id, e.first_name, e.last_name, d.name AS 'department_name'
FROM employees e
JOIN departments d
	ON d.department_id = e.department_id
HAVING department_name = 'Sales' -- having works as where, but only with aliases made in the beginning of the select
ORDER BY e.employee_id DESC;

-- Problem 3
SELECT e.employee_id, e.first_name, e.salary, d.name AS 'department_name'
FROM employees e
JOIN departments d 
	ON d.department_id = e.department_id
WHERE e.salary > 15000
ORDER BY e.department_id DESC LIMIT 5; 

-- Problem 4
SELECT e.employee_id, e.first_name
FROM employees e
WHERE e.employee_id NOT IN (
	SELECT ep.employee_id FROM employees_projects ep
)
ORDER BY e.employee_id DESC LIMIT 3;

-- Problem 5
SELECT e.employee_id, e.first_name, e.manager_id, m.first_name AS 'manager_name'
FROM employees e
JOIN employees m 
	ON e.manager_id = m.employee_id
WHERE e.manager_id IN (3, 7)
ORDER BY e.first_name;

-- Problem 6
SELECT e.salary, d.name
FROM employees e
JOIN departments d
	ON d.department_id = e.department_id
ORDER BY e.salary LIMIT 1;

USE geography;

-- Problem 7
SELECT c.country_name FROM countries c
WHERE c.country_code NOT IN (
	SELECT DISTINCT mc.country_code FROM mountains_countries mc
);