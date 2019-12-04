/* File 06.1 */

USE gringotts;

-- Problem 1
SELECT COUNT(*) AS count 
FROM wizzard_deposits;

-- Problem 2
SELECT MAX(magic_wand_size) AS longest_magic_wand
FROM wizzard_deposits;