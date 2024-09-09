# Csapatfelosztás

| Tóth Zoltán András    | Zsömbörgi Soma István | Vágvölgyi Máté     |
| --------------------- | --------------------- | ------------------ |
| Frontend              | Backend               | Asztali alkalmazás |
| HTML, CSS, JavaScript | MySQL, PHP            | C#                 |

# Alap Ötletek

- [ ] Könyvtári rendszer alapjai, dokumentáció elkérése

# Célok/Megvalósítás

- [ ] Adatok, adattípusok
	- [ ] ISBN szám
	- [ ] Könyv címe
	- [ ] Kiadás éve
	- [ ] Kiadó
	- [ ] Szerző neve
	- [ ] OM azonosító
- [ ] Képekkel való kilistázás (Web)
- [ ] Asztali alkalmazás
	- [ ] A fenti adatokkal könyvek feltöltése (hiányzó adat esetén ne engedje)
		- [ ] 
	- [ ] Könyvek eltávolítása
	- [ ] Könyvek adatainak módosítása
- [ ] Adatbázis (Lejjebb)

# Dizájn/Egyéb Ötletek

- [ ] Minecraft enchant nyelv
- [ ] Bejelentkezés

# Adatbázis

| ID  | ISBN | Cím         | Év   | Kiadó  | Szerző neve |
| --- | ---- | ----------- | ---- | ------ | ----------- |
| 1   | 123  | Matek 9.    | 2016 | Mozaik | Mohai Lajos |
| 2   | 456  | Matek 9.    | 2016 | Mozaik | Mohai Lajos |
| 3   | 789  | Irodalom 9. | 2020 | Mozaik | Mohai Lajos |
___

| ID  | Név    | OM azonosító |
| --- | ------ | ------------ |
| 1   | Mihály | 123456789    |
| 2   | Béla   | 987654321    |
___

| Felhasználó ID | Könyv ID |
| -------------- | -------- |
| 1              | 1        |
| 2              | 2        |
| 2              | 3        |
