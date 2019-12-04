/* File 06.2 */

USE gringotts;

-- Problem 1
SELECT wd.deposit_group, MAX(wd.magic_wand_size) AS longest_magic_wand
FROM wizzard_deposits wd
GROUP BY wd.deposit_group
ORDER BY longest_magic_wand, wd.deposit_group;

-- Problem 2
SELECT deposit_group 
FROM wizzard_deposits
GROUP BY deposit_group
ORDER BY AVG(magic_wand_size) LIMIT 1;

-- Problem 3
SELECT deposit_group, SUM(deposit_amount) AS total_sum
FROM wizzard_deposits
GROUP BY deposit_group
ORDER BY total_sum;