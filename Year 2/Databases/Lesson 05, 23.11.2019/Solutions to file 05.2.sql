/* FIle 05.2 */

USE soft_uni;

-- Problem 1
SELECT e.first_name, e.last_name, t.name AS 'town', a.address_text
FROM employees e
JOIN addresses a
	ON a.address_id = e.address_id
JOIN towns t
	ON t.town_id = a.town_id
ORDER BY first_name, last_name LIMIT 5;

-- Problem 2
SELECT e.first_name, e.last_name, e.hire_date, d.name AS 'dept_name'
FROM employees e
JOIN departments d
	ON d.department_id = e.department_id
WHERE e.hire_date > '1999-1-1' 
	AND d.name IN ('Finance', 'Sales')
ORDER BY e.hire_date;

-- Problems 3
SELECT e.employee_id, e.first_name, p.name AS 'project_name'
FROM employees e
JOIN employees_projects ep
	ON ep.employee_id = e.employee_id
JOIN projects p
	ON p.project_id = ep.project_id
WHERE p.start_date > '2002-08-13'
	AND p.end_date IS NULL
ORDER BY e.first_name, project_name LIMIT 5;

-- Problem 4
SELECT e.employee_id, e.first_name, concat_ws(' ', m.first_name, m.last_name) AS 'manager_name', 
	d.name AS 'department_name'
FROM employees e
JOIN employees m
	ON m.employee_id = e.manager_id
JOIN departments d
	ON d.department_id = m.department_id
ORDER BY e.employee_id;

USE geography;

-- Problem 5
SELECT c.country_code, m.mountain_range, p.peak_name, p.elevation
FROM countries c
JOIN mountains_countries mc
	ON mc.country_code = c.country_code
JOIN mountains m
	ON m.id = mc.mountain_id
JOIN peaks p
	ON p.mountain_id = m.id
WHERE c.country_code = 'BG'
	AND p.elevation > 2835
ORDER BY p.elevation DESC;

-- Problem 6
SELECT c.country_code, c.country_name, m.mountain_range
FROM mountains m
JOIN mountains_countries mc
	ON mc.mountain_id = m.id
JOIN countries c
	ON c.country_code = mc.country_code
WHERE c.country_code IN ('BG', 'RU', 'US')
ORDER BY c.country_code, m.mountain_range;