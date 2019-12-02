/* File 05.4 */

USE soft_uni;

-- Problem 1
SELECT e.employee_id, e.first_name,
CASE 
	WHEN YEAR(p.start_date) >= '2005' THEN NULL
    ELSE p.name
END AS 'project_name'
FROM projects p
LEFT OUTER JOIN employees_projects ep
	ON ep.project_id = p.project_id
LEFT OUTER JOIN employees e
	ON e.employee_id = ep.employee_id
WHERE e.employee_id = 24
ORDER BY project_name;

USE geography;

-- Problem 2
SELECT c.continent_name AS 'FROM', co.continent_name AS 'TO'
FROM continents c
RIGHT OUTER JOIN continents co
	ON co.continent_code IS NOT NULL
ORDER BY c.continent_name, co.continent_name;

-- Problem 3
-- will do later