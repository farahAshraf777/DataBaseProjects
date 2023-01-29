select Branch.Branch_num from Branch,deal_with where Branch.Branch_num not in (select deal_with.Branch_num from deal_with )

select Branch.Branch_num from Branch where Branch.Branch_num not in (select Employee.Branch_num from Employee )

SELECT E_name ,E_ID FROM Employee WHERE E_ID IN (SELECT E_ID FROM Loan GROUP BY E_ID HAVING count(*) = (SELECT MAX(mycount) FROM (SELECT COUNT(*) mycount FROM Loan GROUP BY E_ID) a))

SELECT C_name ,C_SSN FROM Customer WHERE C_SSN IN (SELECT C_SSN FROM Loan GROUP BY C_SSN HAVING count(*) = (SELECT MAX (mycount) FROM (SELECT COUNT(*) mycount FROM Loan GROUP BY C_SSN) a))

select C_name,Customer.C_SSN from Customer where Customer.C_SSN not in (select Loan.C_SSN from Loan)

select Customer.C_SSN,C_name,C_addr,C_phone,count(DealWith.E_ID) as number from Customer ,DealWith where Customer.C_SSN=DealWith.C_SSN group by Customer.C_SSN ,C_name,C_addr,C_phone






