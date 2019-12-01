/* File 04.4 */

USE soft_uni;

-- Problem 1
SELECT e.first_name, e.last_name,
IF(
	(
		SELECT emp.manager_id FROM employees emp 
		WHERE emp.employee_id = e.employee_id
	) IS NULL, 
    '(no manager)',
    (
		SELECT concat_ws(' ', em.first_name, em.last_name) AS manager_full_name 
		FROM employees em
		WHERE e.manager_id = em.employee_id
	)
) AS manager_name
FROM employees e
ORDER BY manager_name;

-- Problem 2
(
	SELECT e.first_name, e.last_name, ('manager') AS position, e.salary
    FROM employees e
    WHERE e.employee_id IN (
		SELECT DISTINCT empl.manager_id FROM employees empl
    )
    ORDER BY e.salary DESC LIMIT 3
)
UNION
(
	SELECT em.first_name, em.last_name, ('employee') AS position, em.salary
    FROM employees em
    WHERE em.manager_id IS NOT NULL
    ORDER BY em.salary DESC LIMIT 3
)
ORDER BY salary DESC, first_name, last_name;

USE geography;

-- Problem 3
SELECT m.mountain_range,
IF(
	m.id NOT IN (
		SELECT pea.mountain_id FROM peaks pea
    ),
    'no info',
    (
		SELECT p.peak_name FROM peaks p
		WHERE p.mountain_id = m.id
		ORDER BY elevation DESC LIMIT 1
    )
) AS peak_name,
IF(
	m.id NOT IN (
		SELECT peak.mountain_id FROM peaks peak
    ),
    'no info',
    (
		SELECT pe.elevation FROM peaks pe
		WHERE pe.mountain_id = m.id
		ORDER BY elevation DESC LIMIT 1
    )
) AS elevation 
FROM mountains m
WHERE m.id IN (
	SELECT mc.mountain_id FROM mountains_countries mc
    WHERE mc.country_code = 'BG'
)
ORDER BY mountain_range;

-- Problem 4
(
	SELECT m.mountain_range AS name, 'mountain' AS type, 
    (
		SELECT p.elevation FROM peaks p
        WHERE p.mountain_id = m.id
        ORDER BY p.elevation DESC LIMIT 1	
    ) AS info 
    FROM mountains m
    WHERE m.id IN (
		SELECT mc.mountain_id FROM mountains_countries mc
        WHERE mc.country_code = 'BG'
    )
)
UNION
(
	SELECT pe.peak_name AS name, 'peak' AS type, pe.elevation AS info
    FROM peaks pe
    WHERE pe.mountain_id IN (
		SELECT mco.mountain_id FROM mountains_countries mco
        WHERE mco.country_code = 'BG'
    )
)
UNION
(
	SELECT r.river_name AS name, 'river' AS type, r.length AS info
    FROM rivers r
    WHERE r.id IN (
		SELECT cr.river_id FROM countries_rivers cr
        WHERE cr.country_code = 'BG'
    )
)
ORDER BY name;