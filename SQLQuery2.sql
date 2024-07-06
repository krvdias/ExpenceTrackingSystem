CREATE TABLE income (
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	item VARCHAR(MAX) NULL,
	income FLOAT NULL,
	description TEXT NULL,
	date_income DATE NULL,
	date_insert DATE NULL
)

SELECT * FROM income

CREATE TABLE expenses (
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	item VARCHAR(MAX) NULL,
	cost FLOAT NULL,
	description TEXT NULL,
	date_expense DATE NULL,
	date_insert DATE NULL
)

SELECT * FROM expenses