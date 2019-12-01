/* File 04.3 */

USE soft_uni;

-- Problem 1
SELECT DISTINCT e.job_title, e.salary FROM employees e 
WHERE e.salary = (
	SELECT em.salary FROM employees em
    WHERE em.job_title = e.job_title
    ORDER BY em.salary DESC LIMIT 1
)
ORDER BY e.salary DESC;

-- Problem 2
SELECT e.first_name, e.last_name, e.salary, 
(
	SELECT d.name FROM departments d
    WHERE d.department_id = e.department_id
) AS department 
FROM employees e
WHERE e.salary = (
	SELECT em.salary FROM employees em
    WHERE em.department_id = e.department_id
    ORDER BY em.salary LIMIT 1
)
ORDER BY salary, first_name, last_name;

-- Problem 3
SELECT e.first_name, e.last_name FROM employees e
WHERE e.employee_id IN (
	SELECT DISTINCT em.manager_id FROM employees em
) 
AND e.middle_name IN (
	SELECT emp.middle_name FROM employees emp
    WHERE emp.manager_id = e.employee_id
)
ORDER BY first_name, last_name;

-- Problem 4
SELECT e.first_name, e.last_name FROM employees e
WHERE e.employee_id IN (
	SELECT DISTINCT em.manager_id FROM employees em
) 
AND e.salary < ANY (
	SELECT emp.salary FROM employees emp 
    WHERE emp.manager_id = e.employee_id
);

-- Problem 5
SELECT e.first_name, e.last_name FROM employees e
WHERE e.employee_id IN (
	SELECT DISTINCT em.manager_id FROM employees em
) 
AND (
	SELECT COUNT(emp.employee_id) FROM employees emp
    WHERE emp.manager_id = e.employee_id
) = 5
ORDER BY e.first_name, e.last_name;

USE geography;

-- Problem 6
SELECT m.mountain_range, 
(
	SELECT p.peak_name FROM peaks p
    WHERE p.mountain_id = m.id
    ORDER BY p.elevation DESC LIMIT 1
) AS peak_name, 
(
	SELECT pe.elevation FROM peaks pe
    WHERE pe.mountain_id = m.id
    ORDER BY pe.elevation DESC LIMIT 1
)
AS elevation FROM mountains m
WHERE m.id IN (
	SELECT mc.mountain_id FROM mountains_countries mc
    WHERE mc.country_code = 'BG'
)
ORDER BY elevation DESC, m.mountain_range;

-- Problem 7
SELECT m.mountain_range FROM mountains m
WHERE m.id IN (
	SELECT mc.mountain_id FROM mountains_countries mc
    WHERE mc.country_code = 'BG'
) 
AND (
	SELECT COUNT(p.id) FROM peaks p
    WHERE p.mountain_id = m.id
) = 0;




