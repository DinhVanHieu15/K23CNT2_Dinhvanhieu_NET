CREATE DATABASE DinhVanHieu_lap11;
Go

CREATE TABLE DvhEmployee (
    dvhEmpId INT PRIMARY KEY,
    dvhEmpName NVARCHAR(100),
    dvhEmpLevel NVARCHAR(50),
    dvhEmpStartDate DATE,
    dvhEmpStatus BIT  
);

INSERT INTO DvhEmployee (dvhEmpId, dvhEmpName, dvhEmpLevel, dvhEmpStartDate, dvhEmpStatus)
VALUES
(1, N'Dinh Van Hieu', N'Intern', '2025-07-01', 1), 
(2, N'Nguyen Thi Hoa', N'Staff', '2023-03-15', 1),
(3, N'Tran Van B', N'Manager', '2021-08-20', 0);
