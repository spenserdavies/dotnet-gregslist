-- CREATE TABLE cars(
--  id INT NOT NULL AUTO_INCREMENT,
--  make VARCHAR(255) NOT NULL,
--  model VARCHAR(255) NOT NULL,
--  imgUrl VARCHAR(255) NOT NULL,
--  body VARCHAR(255) NOT NULL,
--  price INT NOT NULL,
--  year INT NOT NULL,
--  userId VARCHAR(255) NOT NULL,
--  PRIMARY KEY (id)
-- )

-- CREATE TABLE houses
-- (
--     id INT NOT NULL AUTO_INCREMENT,
--     userId VARCHAR(255) NOT NULL,
--     beds INT NOT NULL,
--     baths INT NOT NULL,
--     floors INT NOT NULL,
--     city VARCHAR(255) NOT NULL,
--     imgUrl VARCHAR(255) NOT NULL,
--     state VARCHAR(255) NOT NULL,
--     price INT NOT NULL,
--     PRIMARY KEY (id)
-- )

-- CREATE TABLE jobs
-- (
--     id INT NOT NULL AUTO_INCREMENT,
--     userId VARCHAR(255) NOT NULL,
--     company VARCHAR(255) NOT NULL,
--     position VARCHAR(255) NOT NULL,
--     description VARCHAR(255) NOT NULL,
--     pay INT NOT NULL,
--     hours INT NOT NULL,
--     PRIMARY KEY (id)
-- )

-- INSERT INTO jobs
-- (company, position, description, pay, hours)
-- VALUES
-- ("Pizza Hut", "Shift Leader", "Manage employees and close store", 10, 36);
-- SELECT LAST_INSERT_ID();

SELECT * FROM jobs

-- INSERT INTO houses
-- (beds, baths, floors, city, state, price, imgUrl)
-- VALUES
-- (4, 3, 2, "Star", "Idaho", 550000, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/suburban-house-royalty-free-image-1584972559.jpg?resize=768:*");
-- SELECT LAST_INSERT_ID();
-- SELECT * FROM houses

-- INSERT INTO cars
--             (make, model, year, price, body, imgUrl)
--             VALUES
--             ("Honda", "Prelude", 1990, 8900, "Skrt skrt", "https://3.bp.blogspot.com/--AEgjv0DnB8/TbGsSu1JDBI/AAAAAAAAADY/sB4-LTbsOVU/s1600/DSC_lude5.jpg");
--             SELECT LAST_INSERT_ID()


-- ALTER TABLE cars CHANGE productionYear year INT NOT NULL



-- CREATE TABLE carfavorites
-- (
--     id INT NOT NULL AUTO_INCREMENT,
--     carId INT NOT NULL,
--     user VARCHAR(255) NOT NULL,

--     PRIMARY KEY (id),

--     FOREIGN KEY (carId)
--         REFERENCES cars (id)
--         ON DELETE CASCADE
-- )
















































