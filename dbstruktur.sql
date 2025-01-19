DROP DATABASE IF EXISTS Fahrradhandeldb;

create database Fahrradhandeldb;

use Fahrradhandeldb;

CREATE TABLE rahmen (
    rahmenID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    material VARCHAR(50),
    groesse VARCHAR(10),
    farbe VARCHAR(50)
);

CREATE TABLE laufraeder (
    laufraederID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    felgengroesse VARCHAR(10),
    nabenart VARCHAR(50),
    reifentyp VARCHAR(50)
);

CREATE TABLE reifen (
    reifenID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    reifentyp VARCHAR(50),
    groesse VARCHAR(10),
    profil VARCHAR(50)
);

CREATE TABLE gabel (
    gabelID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    gabeltyp VARCHAR(50),
    material VARCHAR(50),
    federweg INT
);

CREATE TABLE lenker (
    lenkerID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    lenkertyp VARCHAR(50),
    material VARCHAR(50),
    breite INT
);

CREATE TABLE vorbau (
    vorbauID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    laenge INT,
    winkel INT,
    material VARCHAR(50)
);

CREATE TABLE sattel (
    sattelID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    satteltyp VARCHAR(50),
    material VARCHAR(50),
    polsterung VARCHAR(50)
);

CREATE TABLE sattelstuetze (
    sattelstuetzeID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    durchmesser INT,
    material VARCHAR(50),
    federung BOOLEAN
);

CREATE TABLE pedale (
    pedaleID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    pedaltyp VARCHAR(50),
    material VARCHAR(50),
    reflektoren BOOLEAN
);

CREATE TABLE kettenblatt (
    kettenblattID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    zahnanzahl INT,
    material VARCHAR(50),
    lochkreis INT
);

CREATE TABLE kette (
    ketteID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    kettenart VARCHAR(50),
    material VARCHAR(50),
    laenge INT
);

CREATE TABLE schaltwerk (
    schaltwerkID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    schaltungstyp VARCHAR(50),
    material VARCHAR(50),
    schaltstufen INT
);

CREATE TABLE ritzel (
    ritzelID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    zahnanzahl INT,
    material VARCHAR(50),
    freilauf BOOLEAN
);

CREATE TABLE tretlager (
    tretlagerID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    achsendurchmesser INT,
    lagerart VARCHAR(50),
    material VARCHAR(50)
);

CREATE TABLE bremsen (
    bremsenID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    bremsart VARCHAR(50),
    bremsbelagmaterial VARCHAR(50),
    durchmesser INT
);

CREATE TABLE bremshebel (
    bremshebelID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    hebelmaterial VARCHAR(50),
    verstellbar BOOLEAN,
    ergonomie VARCHAR(50)
);

CREATE TABLE lichtanlage (
    lichtanlageID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    leuchtstaerke INT,
    stromversorgung VARCHAR(50),
    montagemoeglichkeit VARCHAR(50)
);

CREATE TABLE staender (
    staenderID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    typ VARCHAR(50),
    material VARCHAR(50),
    verstellbar BOOLEAN
);

CREATE TABLE klingel (
    klingelID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    klingeltyp VARCHAR(50),
    material VARCHAR(50),
    lautstaerke INT
);

CREATE TABLE fahrrad (
    fahrradID INT AUTO_INCREMENT PRIMARY KEY,
    marke VARCHAR(255),
    modell VARCHAR(255),
    preis DECIMAL(10, 2),
    stk_auf_lager INT,
    rahmenID INT,
    laufraederID INT,
    reifenID INT,
    gabelID INT,
    lenkerID INT,
    vorbauID INT,
    sattelID INT,
    sattelstuetzeID INT,
    pedaleID INT,
    kettenblattID INT,
    ketteID INT,
    schaltwerkID INT,
    ritzelID INT,
    tretlagerID INT,
    bremsenID INT,
    bremshebelID INT,
    lichtanlageID INT,
    staenderID INT,
    klingelID INT,
    bild_dateiname VARCHAR(255),
    FOREIGN KEY (rahmenID) REFERENCES rahmen(rahmenID),
    FOREIGN KEY (laufraederID) REFERENCES laufraeder(laufraederID),
    FOREIGN KEY (reifenID) REFERENCES reifen(reifenID),
    FOREIGN KEY (gabelID) REFERENCES gabel(gabelID),
    FOREIGN KEY (lenkerID) REFERENCES lenker(lenkerID),
    FOREIGN KEY (vorbauID) REFERENCES vorbau(vorbauID),
    FOREIGN KEY (sattelID) REFERENCES sattel(sattelID),
    FOREIGN KEY (sattelstuetzeID) REFERENCES sattelstuetze(sattelstuetzeID),
    FOREIGN KEY (pedaleID) REFERENCES pedale(pedaleID),
    FOREIGN KEY (kettenblattID) REFERENCES kettenblatt(kettenblattID),
    FOREIGN KEY (ketteID) REFERENCES kette(ketteID),
    FOREIGN KEY (schaltwerkID) REFERENCES schaltwerk(schaltwerkID),
    FOREIGN KEY (ritzelID) REFERENCES ritzel(ritzelID),
    FOREIGN KEY (tretlagerID) REFERENCES tretlager(tretlagerID),
    FOREIGN KEY (bremsenID) REFERENCES bremsen(bremsenID),
    FOREIGN KEY (bremshebelID) REFERENCES bremshebel(bremshebelID),
    FOREIGN KEY (lichtanlageID) REFERENCES lichtanlage(lichtanlageID),
    FOREIGN KEY (staenderID) REFERENCES staender(staenderID),
    FOREIGN KEY (klingelID) REFERENCES klingel(klingelID)
);

-- Rahmen
INSERT INTO rahmen (marke, modell, preis, stk_auf_lager, material, groesse, farbe)
VALUES 
('Cube', 'Reaction C:62', 599.99, 10, 'Carbon', 'M', 'Schwarz'),
('Trek', 'Marlin 7', 349.99, 15, 'Aluminium', 'L', 'Rot');

-- Laufräder
INSERT INTO laufraeder (marke, modell, preis, stk_auf_lager, felgengroesse, nabenart, reifentyp)
VALUES 
('Mavic', 'Crossmax', 259.99, 8, '29"', 'Scheiben-Nabe', 'Drahtreifen'),
('DT Swiss', 'XR 1501', 349.99, 6, '27.5"', 'Scheiben-Nabe', 'Tubeless');

-- Reifen
INSERT INTO reifen (marke, modell, preis, stk_auf_lager, reifentyp, groesse, profil)
VALUES 
('Schwalbe', 'Racing Ralph', 49.90, 20, 'All-Terrain', '29"', 'Grippy'),
('Continental', 'Mountain King', 39.90, 15, 'Trail', '27.5"', 'Aggressive');

-- Gabel
INSERT INTO gabel (marke, modell, preis, stk_auf_lager, gabeltyp, material, federweg)
VALUES 
('RockShox', 'Reba RL', 429.00, 5, 'Federgabel', 'Aluminium', 100),
('Fox', '34 Float', 699.99, 3, 'Federgabel', 'Carbon', 130);

-- Lenker
INSERT INTO lenker (marke, modell, preis, stk_auf_lager, lenkertyp, material, breite)
VALUES 
('RaceFace', 'Turbine R', 89.99, 10, 'Flatbar', 'Carbon', 760),
('Spank', 'Spike 800', 69.99, 8, 'Riser', 'Aluminium', 800);

-- Vorbau
INSERT INTO vorbau (marke, modell, preis, stk_auf_lager, laenge, winkel, material)
VALUES 
('RaceFace', 'Atlas', 74.99, 12, 50, 6, 'Aluminium'),
('Thomson', 'Elite X4', 99.99, 10, 70, 10, 'Carbon');

-- Sattel
INSERT INTO sattel (marke, modell, preis, stk_auf_lager, satteltyp, material, polsterung)
VALUES 
('Fizik', 'Antares R3', 119.99, 10, 'Rennrad', 'Kunstleder', 'Schaum'),
('Selle Italia', 'SLR Boost', 149.99, 5, 'MTB', 'Leder', 'Gel');

-- Sattelstütze
INSERT INTO sattelstuetze (marke, modell, preis, stk_auf_lager, durchmesser, material, federung)
VALUES 
('Crankbrothers', 'Highline', 249.99, 7, 31.6, 'Aluminium', TRUE),
('KS', 'Lev Integra', 199.99, 5, 30.9, 'Carbon', FALSE);

-- Pedale
INSERT INTO pedale (marke, modell, preis, stk_auf_lager, pedaltyp, material, reflektoren)
VALUES 
('Shimano', 'PD-M520', 49.90, 15, 'Klickpedale', 'Aluminium', TRUE),
('Crankbrothers', 'Eggbeater', 99.90, 12, 'Klickpedale', 'Stahl', FALSE);

-- Kettenblatt
INSERT INTO kettenblatt (marke, modell, preis, stk_auf_lager, zahnanzahl, material, lochkreis)
VALUES 
('Shimano', 'Deore XT', 24.90, 10, 36, 'Stahl', 96),
('SRAM', 'Eagle X-Sync', 34.90, 8, 38, 'Aluminium', 104);

-- Kette
INSERT INTO kette (marke, modell, preis, stk_auf_lager, kettenart, material, laenge)
VALUES 
('KMC', 'X11', 34.90, 30, '11-fach', 'Stahl', 114),
('SRAM', 'PC-XX1', 49.99, 25, '12-fach', 'Titan', 118);

-- Schaltwerk
INSERT INTO schaltwerk (marke, modell, preis, stk_auf_lager, schaltungstyp, material, schaltstufen)
VALUES 
('Shimano', 'XT RD-M8100', 119.99, 5, 'Kettenschaltung', 'Aluminium', 12),
('SRAM', 'GX Eagle', 139.99, 8, 'Kettenschaltung', 'Stahl', 12);

-- Ritzel
INSERT INTO ritzel (marke, modell, preis, stk_auf_lager, zahnanzahl, material, freilauf)
VALUES 
('Shimano', 'CS-M8100', 99.99, 20, 11, 'Stahl', TRUE),
('SRAM', 'XG-1275', 159.99, 15, 10, 'Aluminium', TRUE);

-- Tretlager
INSERT INTO tretlager (marke, modell, preis, stk_auf_lager, achsendurchmesser, lagerart, material)
VALUES 
('Shimano', 'BB52', 24.90, 8, 24, 'Kugellager', 'Stahl'),
('SRAM', 'DUB PressFit', 39.90, 10, 28.99, 'Kugellager', 'Aluminium');

-- Bremsen
INSERT INTO bremsen (marke, modell, preis, stk_auf_lager, bremsart, bremsbelagmaterial, durchmesser)
VALUES 
('Shimano', 'XT BR-M8100', 149.90, 10, 'Scheibenbremse', 'Harz', 180),
('SRAM', 'Code R', 189.99, 6, 'Scheibenbremse', 'Sinter', 200);

-- Bremshebel
INSERT INTO bremshebel (marke, modell, preis, stk_auf_lager, hebelmaterial, verstellbar, ergonomie)
VALUES 
('Shimano', 'BL-M8100', 49.99, 10, 'Aluminium', TRUE, 'Ergonomisch'),
('Magura', 'MT5', 79.99, 8, 'Carbon', TRUE, 'Komfort');

-- Lichtanlage
INSERT INTO lichtanlage (marke, modell, preis, stk_auf_lager, leuchtstaerke, stromversorgung, montagemoeglichkeit)
VALUES 
('Busch & Müller', 'IQ-X', 119.99, 10, 150, 'Dynamo', 'Lenker'),
('Supernova', 'E3 Pro', 149.99, 8, 200, 'Dynamo', 'Lenker');

-- Ständer
INSERT INTO staender (marke, modell, preis, stk_auf_lager, typ, material, verstellbar)
VALUES 
('Pletscher', 'Zoom', 24.99, 5, 'Mittelständer', 'Aluminium', TRUE),
('Hebie', 'Fix 40', 19.99, 7, 'Hinterbauständer', 'Stahl', FALSE);

-- Klingel
INSERT INTO klingel (marke, modell, preis, stk_auf_lager, klingeltyp, material, lautstaerke)
VALUES 
('Knog', 'Oi Classic', 15.99, 10, 'Minimalistisch', 'Aluminium', 80),
('Crane', 'E-NE', 24.99, 8, 'Klassisch', 'Messing', 75);


-- Beispiel-Fahrrad-Datensatz
INSERT INTO fahrrad (
    marke, modell, preis, stk_auf_lager, rahmenID, laufraederID, reifenID, gabelID,
    lenkerID, vorbauID, sattelID, sattelstuetzeID, pedaleID, kettenblattID, ketteID,
    schaltwerkID, ritzelID, tretlagerID, bremsenID, bremshebelID, lichtanlageID,
    staenderID, klingelID, bild_dateiname
)
VALUES (
    'Cube', 'Stereo 150 C:62', 3499.99, 2,
    1, 1, 1, 1,
    1, 1, 1, 1,
    1, 1, 1, 1,
    1, 1, 1, 1,
    1, 1, 1, 'cube_stereo_150.png'
);