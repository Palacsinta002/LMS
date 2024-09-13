#Database kreáció

create database Konyvtarirendszer
default character set utf8
collate utf8_hungarian_ci;

#felhasználó tábla

CREATE TABLE felhasznalo( 
OMazonosito bigint(11) not null PRIMARY KEY,
Nev varchar(50) NOT null

);

#könyvek tábla

CREATE TABLE konyv(
  ISBN bigint(13) PRIMARY KEY not null,
  cim varchar(255) not null,
  nev varchar(255) not null,
  kiado varchar(255) not null,
  szerzo_neve varchar(255) not null
);

#kapcsolat tábla

CREATE TABLE kapcsolat(
    ID int not null PRIMARY KEY,
    OMazonosito bigint(11) not null,
    ISBN bigint(13) not null,
    FOREIGN KEY (OMazonosito) REFERENCES felhasznalo(OMazonosito),
    FOREIGN KEY (ISBN) REFERENCES konyv(ISBN)
);

#adatok feltöltése

INSERT INTO felhasznalo(OMazonosito,nev)
VALUES
(70863330626,"Kiss Erika"),
(77824486794,"Horváth István"),
(72473798005,"Molnár Katalin"),
(70636695447,"Farkas Dániel"),
(75950344555,"Balogh Zsófia"),
(72289227363,"Németh Attila"),
(74084295414,"Fekete Zoltán"),
(71356139105,"Papp János"),
(73072265432,"Simon Judit"),
(72155366113,"Takács Bence"),
(75901988878,"Juhász Viktória"),
(78319348186,"Szilágyi Tamás"),
(71541182428,"Rácz Gabriella"),
(73166688927,"Majoros András"),
(75923842643,"Bíró Ágnes"),
(74364319112,"Vörös Márk"),
(74967764085,"Sipos Alexandra"),
(74717464952,"Katona Balázs"),
(77645698255,"Fodor Lili"),
(76974596928,"Halász Levente"),
(73958651643,"Bognár Enikő"),
(74915299743,"Kocsis Máté"),
(72716440168,"Bodnár Réka"),
(78844522010,"Pál Gergely"),
(72591561476,"Veres Edit"),
(76202408616,"Vörös Márk"),
(75482880873,"Halász Levente"),
(76003509916,"Papp János"),
(77100819098,"Bognár Enikő"),
(71651723779,"Molnár Katalin"),
(76731674751,"Kiss Erika"),
(76031180323,"Majoros András"),
(72071734894,"Kocsis Máté"),
(78171652707,"Juhász Viktória"),
(76959871124,"Németh Attila"),
(77432688465,"Sipos Alexandra"),
(71044910430,"Horváth István"),
(74124193009,"Fekete Zoltán"),
(77462662364,"Katona Balázs"),
(79396256402,"Mészáros Csaba"),
(79423908275,"Papp János"),
(76256483049,"Lukács Nóra"),
(71450760694,"Hajdu Kristóf"),
(72596677758,"Sárközi Dorina"),
(71377682184,"Pataki Ádám");


#konyvtabla feltöltése
INSERT INTO konyv(ISBN,cim,szerzo_neve,kiado,ev)
VALUES
(4399556314643,"Történelem 8.","Horváth Péter","Nemzeti Tankönyvkiadó",2016),
(3173781553359,"Irodalom 7.","Arató László","Műszaki Kiadó",2015),
(9187570260646,"Matematika 9.","Dr. Csongor Győri","Mozaik Kiadó",2019),
(1045273053827,"Fizika 10.","Öveges József","Nemzeti Tankönyvkiadó",2007),
(8655816434390,"Kémia 8.","Kovács László","Apáczai Kiadó",2017),
(5997935303777,"Földrajz 7.","Kéri András","Mozaik Kiadó",2018),
(4733344986411,"Biológia 11.","Dr. Pongrácz Lajos","Mozaik Kiadó",2015),
(6802425232639,"Matematika 7.","Dr. Csongor Győri","Mozaik Kiadó",2017),
(6676353248970,"Irodalom 8.","Arató László, Pála Károly","Nemzeti Tankönyvkiadó",2015),
(8811362879559,"Történelem 9.","Száray Miklós","Nemzeti Tankönyvkiadó",2016),
(5437894209018,"Biológia 10.","Dr. Pénzesné Kónya Eszter","Apáczai Kiadó",2014),
(1207376306912,"Fizika 7.","Öveges József","Nemzeti Tankönyvkiadó",2009),
(5701073161042,"Kémia 9.","Dr. Csík Gyula","Mozaik Kiadó",2018),
(1336190541133,"Földrajz 8.","Láng László","Apáczai Kiadó",2017),
(1339412651871,"Angol nyelvkönyv - Solutions Intermediate","Tim Falla, Paul A. Davies","Oxford University Press",2016),
(3878762352644,"Francia nyelvkönyv - Tous Ensemble 1.","Birgitta Fröhlich, Marion Greiner","Klett Kiadó",2014),
(5882972339208,"Informatika 7.","Szerző: Benda József","Apáczai Kiadó",2016),
(8583352762471,"Matematika 5.","Dr. Hajdu Sándor","Mozaik Kiadó",2017),
(3847199226453,"Irodalom 6.","Arató László, Pála Károly","Nemzeti Tankönyvkiadó",2016),
(8122640717428,"Történelem 6.","Horváth Péter","Nemzeti Tankönyvkiadó",2018),
(4913721304848,"Biológia 7.","Dr. Bernáth József","Mozaik Kiadó",2019),
(8129019996727,"Fizika 8.","Öveges József","Nemzeti Tankönyvkiadó",2010),
(6221367707221,"Kémia 7.","Dr. Szalay László","Mozaik Kiadó",2017),
(3552977360435,"Földrajz 9.","Dr. Gábris Gyula","Nemzeti Tankönyvkiadó",2018),
(7340345548488,"Angol nyelvkönyv - English File Elementary","Christina Latham-Koenig, Clive Oxenden","Oxford University Press",2019),
(2128973397642,"Informatika 5.","Kovács Mihály","Apáczai Kiadó",2017),
(4829686317743,"Matematika 4.","Szerző: Dr. Hajdu Sándor","Kiadó: Mozaik Kiadó",2016),
(9101602260185,"Irodalom 5.","Arató László, Pála Károly","Nemzeti Tankönyvkiadó",2015),
(4225319271407,"Történelem 10.","Száray Miklós","Nemzeti Tankönyvkiadó",2017),
(7991870991066,"Biológia 8.","Dr. Mátrai Károly","Mozaik Kiadó",2016),
(3555244060176,"Fizika 9.","Tomcsányi Pál","Apáczai Kiadó",2014),
(9883701842224,"Kémia 10.","Dr. Irinyi Tamás","Mozaik Kiadó",2019),
(9937524687635,"Földrajz 10.","Dr. Láng László","Nemzeti Tankönyvkiadó",2017),
(5382087095146,"Informatika 8.","Dr. Benda József","Apáczai Kiadó",2018),
(9631985915708,"Matematika 6.","Dr. Csongor Győri","Mozaik Kiadó",2018),
(2717281182574,"Irodalom 9.","Arató László, Pála Károly","Nemzeti Tankönyvkiadó",2017),
(6831582129305,"Történelem 7.","Horváth Péter","Nemzeti Tankönyvkiadó",2015),
(5813291507819,"Biológia 9.","Dr. Mátrai Károly","Mozaik Kiadó",2016),
(5936077859637,"Fizika 10.","Tomcsányi Pál","Nemzeti Tankönyvkiadó",2015),
(7017735024645,"Kémia 11.","Dr. Irinyi Tamás","Mozaik Kiadó",2019),
(6230871687385,"Földrajz 6.","Kéri András","Apáczai Kiadó",2017),
(8146670100492,"Informatika 6.","Kovács Mihály","Apáczai Kiadó",2017),
(1228219412145,"Matematika 11.","Dr. Hajdu Sándor","Mozaik Kiadó",2018),
(6209641201264,"Irodalom 10.","Arató László, Pála Károly","Nemzeti Tankönyvkiadó",2018),
(6046735163240,"Történelem 12.","Száray Miklós","Nemzeti Tankönyvkiadó",2017),
(4173475481918,"Biológia 12.","Dr. Bernáth József","Mozaik Kiadó",2018),
(6193149994263,"Fizika 12.","Dr. Rácz András","Apáczai Kiadó",2019),
(9315075018212,"Kémia 12.","Dr. Csík Gyula","Mozaik Kiadó",2020),
(9093207450632,"Földrajz 12.","Láng László","Apáczai Kiadó",2019),
(5950841008870,"Informatika 12.","Dr. Fülöp Ferenc","Nemzeti Tankönyvkiadó",2018);

#kapcsolat feltöltés
INSERT INTO kapcsolat
VALUES
(4,70863330626,4399556314643),
(18,70863330626,8655816434390),
(13,70863330626,6676353248970),
(19,70863330626,1336190541133),
(5,77824486794,3173781553359),
(12,77824486794,5997935303777),
(11,77824486794,1207376306912),
(17,72473798005,1045273053827),
(16,70636695447,4733344986411),
(3,70636695447,7017735024645),
(15,70636695447,1228219412145),
(6,75950344555,8129019996727),
(14,72289227363,6802425232639),
(2,74084295414,8811362879559),
(10,74084295414,9187570260646),
(7,71356139105,5437894209018),
(8,73072265432,5701073161042),
(9,73072265432,3552977360435),
(1,72155366113,5882972339208);
