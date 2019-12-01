/* File 04.2 */

USE soft_uni;

-- Problem 1
SELECT e.first_name, e.last_name, e.salary FROM employees e
WHERE e.salary = (
	SELECT em.salary FROM employees em 
    ORDER BY em.salary ASC LIMIT 1
);

-- Problem 2
SELECT e.first_name, e.last_name, e.salary FROM employees e
WHERE e.salary <= 1.1 * (
	SELECT em.salary FROM employees em 
    ORDER BY em.salary ASC LIMIT 1
);

-- Problem 3
SELECT e.first_name, e.last_name, e.job_title FROM employees e
WHERE e.employee_id IN (
	SELECT DISTINCT em.manager_id FROM employees em
)
ORDER BY first_name, last_name;

-- Problem 4
SELECT e.employee_id, concat_ws(' ', e.first_name, e.last_name) AS employee_name 
FROM employees e
WHERE e.address_id IN (
	SELECT a.address_id FROM addresses a
    WHERE a.town_id = (
		SELECT t.town_id FROM towns t 
		WHERE t.name = 'San Francisco' LIMIT 1
    )
)
ORDER BY employee_name;