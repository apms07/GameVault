CREATE DATABASE gamevault_db;
USE gamevault_db;

CREATE TABLE games (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(150) NOT NULL,
    platform VARCHAR(30) NOT NULL,
    genre VARCHAR(50),
    game_condition VARCHAR(10) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    quantity INT NOT NULL DEFAULT 0,
    release_year INT,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    UNIQUE (title, platform, game_condition)
);

INSERT INTO games (title, platform, genre, game_condition, price, quantity, release_year) VALUES
('The Legend of Zelda: Tears of the Kingdom', 'Switch', 'Adventure', 'New', 59.99, 8, 2023),
('God of War Ragnarok', 'PS5', 'Action', 'Used', 34.99, 3, 2022),
('Forza Horizon 5', 'Xbox', 'Racing', 'New', 49.99, 5, 2021);
