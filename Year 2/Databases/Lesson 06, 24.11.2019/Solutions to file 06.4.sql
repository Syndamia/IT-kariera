/* File 06.4 */

USE gringotts;

-- Problem 1
SELECT DISTINCT wd.deposit_group, wd.magic_wand_creator, 
	(
		SELECT MIN(w.deposit_charge) FROM wizzard_deposits w
		WHERE w.magic_wand_creator = wd.magic_wand_creator
			AND w.deposit_group = wd.deposit_group
	) AS min_deposit_charge
FROM wizzard_deposits wd
LEFT OUTER JOIN wizzard_deposits wde
	ON wde.magic_wand_creator = wd.magic_wand_creator
ORDER BY magic_wand_creator, deposit_group;

-- Problem 2

-- Problem 3
SELECT SUBSTRING(first_name, 1, 1) AS first_letter
FROM wizzard_deposits
WHERE deposit_group = 'Troll Chest'
GROUP BY first_letter
ORDER BY first_letter;
    
-- Problem 4