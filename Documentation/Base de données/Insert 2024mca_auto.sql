-- Table Users
INSERT INTO Users (Email, Username, Password, Admin, Blocked) 
VALUES 
    ('utilisateur1@example.com', 'JohnDoe', 'motdepasse1', 0, 0),
    ('utilisateur2@example.com', 'AliceSmith', 'motdepasse2', 0, 0),
    ('utilisateur3@example.com', 'DavidBrown', 'motdepasse3', 0, 0),
    ('utilisateur4@example.com', 'EmilyJohnson', 'motdepasse4', 0, 0),
    ('utilisateur5@example.com', 'MichaelWilliams', 'motdepasse5', 0, 0),
    ('utilisateur6@example.com', 'SarahWilson', 'motdepasse6', 0, 0),
    ('utilisateur7@example.com', 'JamesTaylor', 'motdepasse7', 0, 0),
    ('utilisateur8@example.com', 'EmmaMartinez', 'motdepasse8', 0, 0),
    ('utilisateur9@example.com', 'DanielJones', 'motdepasse9', 0, 0),
    ('utilisateur10@example.com', 'OliviaBrown', 'motdepasse10', 0, 0),
    ('utilisateur11@example.com', 'MatthewThomas', 'motdepasse11', 0, 0),
    ('utilisateur12@example.com', 'AvaGarcia', 'motdepasse12', 0, 0),
    ('utilisateur13@example.com', 'WilliamRodriguez', 'motdepasse13', 0, 0),
    ('utilisateur14@example.com', 'SophiaLopez', 'motdepasse14', 0, 0),
    ('utilisateur15@example.com', 'JosephLee', 'motdepasse15', 0, 0),
    ('utilisateur16@example.com', 'Dragtsu', 'motdepasse16', 0, 0),
    ('admin@example.com', 'Admin', 'motdepasse17', 1, 0);

-- Table Brands
INSERT INTO Brands (Name) VALUES 
('Toyota'), ('Ford'), ('BMW'), ('Honda'), ('Volkswagen'),
('Mercedes-Benz'), ('Audi'), ('Chevrolet'), ('Hyundai'), ('Nissan'),
('Kia'), ('Volvo'), ('Subaru'), ('Mazda'), ('Jeep'),
('Lexus'), ('Tesla'), ('Fiat'), ('Peugeot'), ('Renault');

-- Table models
INSERT INTO Models (Name) VALUES 
('Corolla'), ('Camry'), ('Supra'), ('F-150'), ('Focus'),
('Série 3'), ('Série 5'), ('Accord'), ('Civic'), ('Golf'),
('Passat'), ('Classe C'), ('Classe E'), ('A4'), ('A6'),
('RS3'), ('Camaro'), ('Silverado'), ('Tucson'), ('Santa Fe'),
('Altima'), ('GTR R35'), ('Maxima'), ('Sorento'), ('Optima'),
('S60'), ('XC90'), ('Outback'), ('Forester'), ('CX-5'),
('Mazda3'), ('Wrangler'), ('Cherokee'), ('UX'), ('RX'),
('Model S'), ('Model 3'), ('500'), ('Panda'), ('208'),
('3008'), ('Clio'), ('Captur');

-- Table EngineTypes
INSERT INTO EngineTypes (Type) VALUES ('Essence'), ('Diesel'), ('Électrique');

-- Table Cars
INSERT INTO Cars (Year, Mileage, Images, Description, brand_id, model_id, engineType_id)
VALUES 
(2020, 150000, '1_1.jpg/1_2.jpg', 'La Toyota Corolla est une voiture compacte produite depuis 1966 par le constructeur automobile japonais Toyota.', 1, 1, 1),
(2019, 20000, '2_1.jpg/2_2.jpg', 'La Toyota Camry est une berline intermédiaire produite par Toyota, lancée pour la première fois en 1982.', 1, 2, 1),
(2000, 40000, '3_1.jpg/3_2.jpg', 'La Toyota Supra est une voiture de sport produite par le constructeur automobile japonais Toyota.', 1, 3, 1),
(2021, 10000, '4_1.jpg/4_2.jpg', 'Le Ford F-150 est un modèle de camionnette produit par le constructeur automobile américain Ford depuis 1948.', 2, 4, 1),
(2018, 30000, '5_1.jpg/5_2.jpg', 'La Ford Focus est une voiture compacte produite par le constructeur automobile américain Ford depuis 1998.', 2, 5, 1),
(2022, 5000, '6_1.jpg/6_2.jpg', 'La BMW Série 3 est une gamme de modèles de voitures compactes de luxe fabriquée par la filiale allemande du constructeur automobile BMW depuis mai 1975.', 3, 6, 1),
(2021, 120000, '7_1.jpg/7_2.jpg', 'La BMW Série 5 est une gamme de modèles de voitures de luxe produite par la filiale allemande du constructeur automobile BMW.', 3, 7, 1),
(2020, 18000, '8_1.jpg/8_2.jpg', 'La Honda Accord est une automobile produite par le constructeur automobile japonais Honda.', 4, 8, 1),
(2019, 220000, '9_1.jpg/9_2.jpg', 'La Honda Civic est un modèle d''automobile fabriqué par Honda.', 4, 9, 1),
(2021, 9000, '10_1.jpg/10_2.jpg', 'La Volkswagen Golf est une voiture familiale compacte produite par le constructeur automobile allemand Volkswagen depuis 1974.', 5, 10, 1),
(2022, 7000, '11_1.jpg/11_2.jpg', 'La Volkswagen Passat est une grande familiale fabriquée par Volkswagen AG depuis 1973.', 5, 11, 1),
(2022, 6000, '12_1.jpg/12_2.jpg', 'La Mercedes-Benz Classe C est une gamme de voitures compactes de luxe produites par le constructeur allemand Mercedes-Benz.', 6, 12, 1),
(2021, 10000, '13_1.jpg/13_2.jpg', 'La Mercedes-Benz Classe E est une gamme de voitures exécutives produites par le constructeur automobile allemand Mercedes-Benz.', 6, 13, 1),
(2020, 11000, '14_1.jpg/14_2.jpg', 'L''Audi A4 est une berline familiale du constructeur automobile allemand Audi.', 7, 14, 1),
(2021, 8000, '15_1.jpg/15_2.jpg', 'L''Audi A6 est une berline de luxe produite par Audi, filiale du groupe allemand Volkswagen AG.', 7, 15, 1),
(2019, 80000, '16_1.jpg/16_2.jpg/16_3.jpg', 'La Audi RS3 est une voiture compacte sportive produite par le constructeur automobile allemand Audi AG.', 7, 16, 1),
(2020, 14000, '17_1.jpg/17_2.jpg', 'La Chevrolet Camaro est une automobile de type pony car produite par General Motors Chevrolet.', 8, 17, 1),
(2021, 110000, '18_1.jpg/18_2.jpg', 'Le Chevrolet Silverado et son jumeau le GMC Sierra sont des pick-up de grande taille construits par General Motors.', 8, 18, 1),
(2021, 16000, '19_1.jpg/19_2.jpg', 'Le Hyundai Tucson est un SUV compact produit par le constructeur automobile sud-coréen Hyundai Motor Company depuis 2004.', 9, 19, 1),
(2020, 13000, '20_1.jpg/20_2.jpg', 'Le Hyundai Santa Fe est un SUV familial produit par le constructeur automobile sud-coréen Hyundai depuis 2000.', 9, 20, 1),
(2019, 19000, '21_1.jpg/21_2.jpg', 'La Nissan Altima est une automobile de taille moyenne produite par Nissan, constructeur automobile japonais.', 10, 21, 1),
(2020, 5000, '22_1.jpg/22_2.jpg', 'La Nissan GT-R est une voiture de sport 2+2 places produite par le constructeur automobile japonais Nissan.', 10, 22, 1),
(2020, 12000, '23_1.jpg/23_2.jpg', 'La Nissan Maxima est une voiture berline intermédiaire produite par Nissan.', 10, 23, 1),
(2021, 15000, '24_1.jpg/24_2.jpg', 'Le Kia Sorento est un SUV produit par le constructeur automobile sud-coréen Kia Motors.', 11, 24, 1),
(2020, 11000, '25_1.jpg/25_2.jpg', 'La Kia Optima est une berline familiale produite par Kia Motors.', 11, 25, 1),
(2021, 8000, '26_1.jpg/26_2.jpg', 'La Volvo S60 est une voiture berline produite par Volvo Cars depuis 2000.', 12, 26, 1),
(2022, 7000, '27_1.jpg/27_2.jpg', 'Le Volvo XC90 est un SUV de luxe fabriqué par le constructeur automobile suédois Volvo Cars.', 12, 27, 1),
(2021, 10000, '28_1.jpg/28_2.jpg', 'La Subaru Outback est une voiture familiale crossover / SUV fabriquée par Subaru depuis 1994.', 13, 28, 1),
(2022, 6000, '29_1.jpg/29_2.jpg', 'Le Subaru Forester est un véhicule utilitaire sportif (SUV) compact fabriqué par Subaru.', 13, 29, 1),
(2020, 13000, '30_1.jpg/30_2.jpg', 'Le Mazda CX-5 est un véhicule utilitaire sportif (SUV) compact fabriqué par Mazda.', 14, 30, 1),
(2021, 9000, '31_1.jpg/31_2.jpg', 'La Mazda3 est une berline compacte produite par le constructeur automobile japonais Mazda depuis 2003.', 14, 31, 1),
(2022, 4000, '32_1.jpg/32_2.jpg', 'La Jeep Wrangler est un véhicule utilitaire sportif compact, produit par le constructeur automobile américain Jeep.', 15, 32, 1),
(2020, 8000, '33_1.jpg/33_2.jpg', 'Le Jeep Cherokee est un SUV compact fabriqué par Jeep depuis 1974.', 15, 33, 1),
(2021, 7000, '34_1.jpg/34_2.jpg', 'Le Lexus UX est un crossover compact produit par Lexus, la division de luxe de Toyota.', 16, 34, 1),
(2020, 100000, '35_1.jpg/35_2.jpg', 'Le Lexus RX est un véhicule utilitaire sportif de luxe fabriqué par Lexus.', 16, 35, 1),
(2022, 3000, '36_1.jpg/36_2.jpg', 'La Tesla Model S est une berline électrique produite par Tesla, Inc.', 17, 36, 3),
(2021, 5000, '37_1.jpg/37_2.jpg', 'La Tesla Model 3 est une voiture électrique compacte de Tesla, Inc.', 17, 37, 3),
(2021, 8000, '38_1.jpg/38_2.jpg', 'La Fiat 500 est une petite voiture citadine fabriquée par le constructeur italien Fiat depuis 2007.', 18, 38, 1),
(2020, 9000, '39_1.jpg/39_2.jpg', 'La Fiat Panda est une petite voiture produite par le constructeur automobile italien Fiat.', 18, 39, 1),
(2022, 4000, '40_1.jpg/40_2.jpg', 'La Peugeot 208 est une citadine du constructeur automobile français Peugeot, commercialisée depuis 2019.', 19, 40, 1),
(2021, 60000, '41_1.jpg/41_2.jpg', 'La Peugeot 3008 est un crossover compact produit par le constructeur français Peugeot depuis 2008.', 19, 41, 1),
(2020, 11000, '42_1.jpg/42_2.jpg', 'La Renault Clio est une citadine polyvalente fabriquée par le constructeur français Renault.', 20, 42, 1),
(2021, 7000, '43_1.jpg/43_2.jpg', 'Le Renault Captur est un SUV urbain polyvalent produit par le constructeur français Renault.', 20, 43, 1);

-- Table Notices
INSERT INTO Notices (PublicationDate, BuyDate, Price, Active, Blocked, buyer_id, seller_id, car_id)
VALUES 
('2024-04-01', NULL, 15000, 1, 0, NULL, 13, 1), -- Toyota Corolla 2020
('2024-04-02', NULL, 20000, 1, 0, NULL, 5, 2), -- Toyota Camry 2019
('2024-04-03', NULL, 40000, 1, 0, NULL, 17, 3), -- Toyota Supra 2000
('2024-04-04', NULL, 35000, 1, 0, NULL, 14, 4), -- Ford F-150 2021
('2024-04-05', NULL, 25000, 1, 0, NULL, 10, 5), -- Ford Focus 2018
('2024-04-06', NULL, 40000, 1, 0, NULL, 12, 6), -- BMW Série 3 2022
('2024-04-07', NULL, 55000, 1, 0, NULL, 11, 7), -- BMW Série 5 2021
('2024-04-08', NULL, 30000, 1, 0, NULL, 8, 8), -- Honda Accord 2020
('2024-04-09', NULL, 25000, 1, 0, NULL, 4, 9), -- Honda Civic 2019
('2024-04-10', NULL, 35000, 1, 0, NULL, 13, 10), -- Volkswagen Golf 2021
('2024-04-11', NULL, 30000, 1, 0, NULL, 15, 11), -- Volkswagen Passat 2022
('2024-04-12', NULL, 45000, 1, 0, NULL, 2, 12), -- Mercedes-Benz Classe C 2022
('2024-04-13', NULL, 60000, 1, 0, NULL, 3, 13), -- Mercedes-Benz Classe E 2021
('2024-04-14', NULL, 40000, 1, 0, NULL, 7, 14), -- Audi A4 2020
('2024-04-15', NULL, 50000, 1, 0, NULL, 9, 15), -- Audi A6 2021
('2024-04-16', NULL, 60000, 1, 0, NULL, 16, 16), -- Audi RS3 2019
('2024-04-17', NULL, 35000, 1, 0, NULL, 1, 17), -- Chevrolet Camaro 2020
('2024-04-18', NULL, 40000, 1, 0, NULL, 4, 18), -- Chevrolet Silverado 2021
('2024-04-19', NULL, 30000, 1, 0, NULL, 6, 19), -- Hyundai Tucson 2021
('2024-04-20', NULL, 25000, 1, 0, NULL, 8, 20), -- Hyundai Santa Fe 2020
('2024-04-21', NULL, 35000, 1, 0, NULL, 11, 21), -- Nissan Altima 2019
('2024-04-22', NULL, 80000, 1, 0, NULL, 17, 22), -- Nissan GTR R35 2020
('2024-04-23', NULL, 40000, 1, 0, NULL, 15, 23), -- Nissan Maxima 2020
('2024-04-24', NULL, 30000, 1, 0, NULL, 1, 24), -- Kia Sorento 2021
('2024-04-25', NULL, 25000, 1, 0, NULL, 3, 25), -- Kia Optima 2020
('2024-04-26', NULL, 40000, 1, 0, NULL, 5, 26), -- Volvo S60 2021
('2024-04-27', NULL, 70000, 1, 0, NULL, 7, 27), -- Volvo XC90 2022
('2024-04-28', NULL, 45000, 1, 0, NULL, 9, 28), -- Subaru Outback 2021
('2024-04-29', NULL, 35000, 1, 0, NULL, 11, 29), -- Subaru Forester 2022
('2024-04-30', NULL, 30000, 1, 0, NULL, 13, 30), -- Mazda CX-5 2020
('2024-05-01', NULL, 25000, 1, 0, NULL, 15, 31), -- Mazda Mazda3 2021
('2024-05-02', NULL, 50000, 1, 0, NULL, 2, 32), -- Jeep Wrangler 2022
('2024-05-03', NULL, 40000, 1, 0, NULL, 4, 33), -- Jeep Cherokee 2020
('2024-05-04', NULL, 45000, 1, 0, NULL, 6, 34), -- Lexus UX 2021
('2024-05-05', NULL, 60000, 1, 0, NULL, 8, 35), -- Lexus RX 2020
('2024-05-06', NULL, 80000, 1, 0, NULL, 10, 36), -- Tesla Model S 2022
('2024-05-07', NULL, 70000, 1, 0, NULL, 12, 37), -- Tesla Model 3 2021
('2024-05-08', NULL, 35000, 1, 0, NULL, 14, 38), -- Fiat 500 2021
('2024-05-09', NULL, 25000, 1, 0, NULL, 2, 39), -- Fiat Panda 2020
('2024-05-10', NULL, 40000, 1, 0, NULL, 7, 40), -- Peugeot 208 2022
('2024-05-11', NULL, 55000, 1, 0, NULL, 14, 41), -- Peugeot 3008 2021
('2024-05-12', NULL, 30000, 1, 0, NULL, 1, 42), -- Renault Clio 2020
('2024-05-13', NULL, 35000, 1, 0, NULL, 11, 43); -- Renault Captur 2021

-- Table Users_Bookmark_Notice
INSERT INTO Users_Bookmark_Notice (user_id, notice_id)
VALUES 
(1, 1), -- Toyota Corolla
(1, 2), -- Toyota Camry
(1, 3), -- Toyota Supra
(2, 4), -- Ford F-150
(2, 5), -- Ford Focus
(2, 6), -- BMW Série 3
(3, 7), -- BMW Série 5
(3, 8), -- Honda Accord
(4, 9), -- Honda Civic
(4, 10), -- Volkswagen Golf
(5, 11), -- Volkswagen Passat
(5, 12), -- Mercedes-Benz Classe C
(16, 3), -- Toyota Supra
(16, 22); -- Nissan GTR R35