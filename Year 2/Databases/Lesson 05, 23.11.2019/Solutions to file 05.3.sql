/* FIle 05.3 */

USE geography;

-- Problem 1
SELECT c.country_name, r.river_name
FROM countries c
INNER JOIN continents co
	ON co.continent_code = c.continent_code
LEFT OUTER JOIN countries_rivers cr
	ON cr.country_code = c.country_code
LEFT OUTER JOIN rivers r
	ON r.id = cr.river_id
WHERE c.continent_code = 'AF'
ORDER BY c.country_name LIMIT 5;

-- Problem 2
SELECT c.country_name FROM countries c
LEFT OUTER JOIN mountains_countries mc
	ON mc.country_code = c.country_code
WHERE mc.mountain_id IS NULL;

-- Problem 3
SELECT m.mountain_range, p.peak_name, p.elevation
FROM mountains m
LEFT OUTER JOIN peaks p
	ON p.mountain_id = m.id
		AND p.peak_name = (
				SELECT pe.peak_name FROM peaks pe
				WHERE pe.mountain_id = m.id
				ORDER BY pe.elevation DESC LIMIT 1
			)
INNER JOIN mountains_countries mc
	ON mc.mountain_id = m.id
WHERE mc.country_code = 'BG'
ORDER BY p.elevation DESC;

USE soft_uni;

-- Problem 4
SELECT e.employee_id, e.first_name, e.last_name
FROM employees e
LEFT OUTER JOIN employees_projects ep 
	ON ep.employee_id = e.employee_id
WHERE ep.project_id IS NULL
ORDER BY first_name, last_name LIMIT 3;