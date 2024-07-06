CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(MAX) NULL,
    password VARCHAR(MAX) NULL,
    date_create DATE NULL
);

CREATE TABLE categories (
    id INT PRIMARY KEY IDENTITY(1,1),
    category VARCHAR(MAX) NULL,
    type VARCHAR(MAX) NULL,
    status VARCHAR(MAX) NULL,
    date_insert DATE NULL,
    user_id INT,
    FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE income (
    id INT PRIMARY KEY IDENTITY(1,1),
    category VARCHAR(MAX) NULL,
    item VARCHAR(MAX) NULL,
    income FLOAT NULL,
    description TEXT NULL,
    date_income DATE NULL,
    date_insert DATE NULL,
    user_id INT,
    FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE expenses (
    id INT PRIMARY KEY IDENTITY(1,1),
    category VARCHAR(MAX) NULL,
    item VARCHAR(MAX) NULL,
    cost FLOAT NULL,
    description TEXT NULL,
    date_expense DATE NULL,
    date_insert DATE NULL,
    user_id INT,
    FOREIGN KEY (user_id) REFERENCES users(id)
);

SELECT * FROM categories