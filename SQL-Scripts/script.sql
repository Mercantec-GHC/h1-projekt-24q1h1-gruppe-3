CREATE TABLE item (
    itemid SERIAL PRIMARY KEY,
    type VARCHAR(255),
    gamename VARCHAR(255),
    genre VARCHAR(255),
    price INTEGER,
    manufacture VARCHAR(255),
    condition VARCHAR(255),
    description TEXT
);