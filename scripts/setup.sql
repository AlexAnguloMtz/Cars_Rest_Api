CREATE DATABASE CarsDatabase;
GO

USE CarsDatabase;
GO

CREATE TABLE cars(
	id VARCHAR(50) PRIMARY KEY,
	brand VARCHAR(50) NOT NULL,
	model VARCHAR(50) NOT NULL,
	year INT NOT NULL
);
GO

INSERT INTO cars (id, brand, model, year) 
VALUES 
('1', 'Toyota', 'Corolla', 2020),
('2', 'Honda', 'Civic', 2019),
('3', 'Ford', 'Fusion', 2018),
('4', 'Chevrolet', 'Malibu', 2017),
('5', 'Nissan', 'Altima', 2016),
('6', 'Volkswagen', 'Jetta', 2015),
('7', 'BMW', '3 Series', 2014),
('8', 'Mercedes-Benz', 'C-Class', 2013),
('9', 'Audi', 'A4', 2012),
('10', 'Lexus', 'IS', 2011),
('11', 'Tesla', 'Model 3', 2021),
('12', 'Hyundai', 'Elantra', 2022),
('13', 'Kia', 'Optima', 2023),
('14', 'Mazda', 'Mazda3', 2024),
('15', 'Subaru', 'Impreza', 2025),
('16', 'Volvo', 'S60', 2026),
('17', 'Acura', 'TLX', 2027),
('18', 'Infiniti', 'Q50', 2028),
('19', 'Genesis', 'G70', 2029),
('20', 'Porsche', 'Panamera', 2030);
