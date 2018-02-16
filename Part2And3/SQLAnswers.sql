-- REQ 9

-- Return the names of all salespeople that have an order with George
SELECT s.Name FROM ORDERS o
LEFT JOIN CUSTOMER c ON o.CustomerID = c.ID
LEFT JOIN SALESPERSON s ON o.SalespersonID = s.ID
WHERE
c.Name = 'George'


-- Return the names of all salespeople that do not have any order with George
SELECT Name FROM Salesperson
WHERE Id NOT IN (
SELECT s.Id FROM ORDERS o
LEFT JOIN CUSTOMER c ON o.CustomerID = c.ID
LEFT JOIN SALESPERSON s ON o.SalespersonID = s.ID
WHERE
c.Name = 'George')


-- Return the names of salespeople that have 2 or more orders.
SELECT s.Name FROM Salesperson s
INNER JOIN ORDERS o ON o.SalespersonID = s.Id
GROUP BY s.Name
Having COUNT(s.Name) > 1

-- REQ 10

-- Return the name of the salesperson with the 3rd highest salary.
WITH SalaryRank AS
(
    SELECT Name,Salary,
           RN = ROW_NUMBER() OVER (ORDER BY Salary DESC)
    FROM Salesperson
)
SELECT Name
FROM SalaryRank
WHERE RN = 3

-- Create a new roll­up table BigOrders
SELECT CustomerID, SUM(Quantity * UnitCost) AS TotalOrderValue 
FROM ORDERS
GROUP BY CustomerID WITH ROLLUP
HAVING SUM(Quantity * UnitCost) > 1000

-- Return the total Amount of orders for each month, ordered by year, then month (both in descending order)
SELECT CAST(YEAR(OrderDate) AS VARCHAR(4)) + '-' + CAST(MONTH(OrderDate) AS VARCHAR(2)) AS [Month], SUM(Quantity * UnitCost) AS TotalOrderValue 
FROM ORDERS
GROUP BY CAST(YEAR(OrderDate) AS VARCHAR(4)) + '-' + CAST(MONTH(OrderDate) AS VARCHAR(2))
ORDER BY CAST(YEAR(OrderDate) AS VARCHAR(4)) + '-' + CAST(MONTH(OrderDate) AS VARCHAR(2)) DESC