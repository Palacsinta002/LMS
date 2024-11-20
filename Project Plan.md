<center><h1>LMS (Library Management System)</h1></center>
<center><h1>Csapatfelosztás</h1></center>

| Tóth Zoltán András              | Zsömbörgi Soma István | Vágvölgyi Máté                           |
| ------------------------------- | --------------------- | ---------------------------------------- |
| Frontend                        | Backend               | Asztali alkalmazás                       |
| HTML, CSS, JavaScript           | MySQL, PHP            | C#                                       |
| Weboldal a felhasználók részére | Háttér adatbázis      | Könyvtárosok és adminisztrátorok részére |
<center><h1>Projekt terv</h1></center>

##### A projekt tervezett ideje és időtartama: 2024. szeptember - 2025. május 13.

**A projekt célja**: Egy könyvtári rendszer megalkotása tagok webes felületével, könyvtárosok és adminisztrátorok saját asztali alkalmazásukkal. 
**A projektet megelőző tevékenységek**: 
- Könyvtárosok véleménye, hogy milyen funkciókat látnának szívesen / hiányolnak jelenlegi rendszerükből.
<div style="page-break-after: always;"></div>


<center><h1>Adatbázis</h1></center>

## Fogalmi terv

Az LMS egy könyvtári rendszer, aminek adatbázisa nyilván tartja a felhasználók, könyvek és kölcsönzések adatait. Az adatbázis 8 táblát tartalmaz, és MySQL-ben írjuk.

**Cél**: Egy könyvtári rendszer adatbázisának elkészítése, ami kiszolgálja a felhasználókat, könyvtárosokat és adminisztrátorokat. 

**Célcsoport**: Diákok, tanárok, egyéb felhasználók

**Funkciók**: A felhasználók megtekinteni, és kölcsönözni tudják a könyveket. A könyvtárosok tudják kezelni a kölcsönözhető könyveket. Az adminisztrátor hozzáfér a teljes adatbázishoz, és kezelni tudja a felhasználók adatait.

**Kihívás**: Az adatbázis 3. normálformába helyezése, és az adatok könnyű hozzáférhetősége.

## Books - Könyvek

Adatokat tárol a könyvekről.

| BookID | PublisherID | AuthorID | CategoryID | Title       | Publication<br>Year | ISBN | Copies<br>Available |
| ------ | ----------- | -------- | ---------- | ----------- | ------------------- | ---- | ------------------- |
| 1      | 1           | 1        | 1          | Irodalom 9. | 2020                | 1234 | 5                   |
## Users - Felhasználók

Adatokat tárol a felhasználókról.

| UserID | FirstName | LastName | Email                  | Username     | Password         |
| ------ | --------- | -------- | ---------------------- | ------------ | ---------------- |
| 1      | Árpád     | Péter    | peterarpad@cicamail.hu | Peterarpad04 | !asdf123(sha512) |

| MembershipTypeID | RoleID |
| ---------------- | ------ |
| 1                | 1      |
## Borrowings - Kölcsönzések

Követi, hogy melyik könyvek vannak kikölcsönözve, és hogy kik kölcsönzik őket.

| BorrowID | UserID | BookID | BorrowDate | ReturnDate | DueDate    | IsReturned |
| -------- | ------ | ------ | ---------- | ---------- | ---------- | ---------- |
| 1        | 1      | 1      | 12/07/2023 | null       | 12/07/2024 | false      |
| 2        | 2      | 2      | 03/22/2024 | 06/15/2024 | 03/22/2025 | true       |
## MembershipType - Tagság típus

A tagság típusait tárolja el. 

| MembershipTypeID | MemebershipType |
| ---------------- | --------------- |
| 1                | Student         |
| 2                | Teacher         |
| 3                | Other           |

## Roles - Rangok

A rangokat tárolja el. 

| RoleID | Role      |
| ------ | --------- |
| 1      | Member    |
| 2      | Admin     |
| 3      | Librarian |
## Authors - Szerzők

Információkat tárol az írókról.

| AuthorID | Name                | Nationality |
| -------- | ------------------- | ----------- |
| 1        | William Shakespeare | British     |
## Categories - Kategóriák

Könyvkategóriák: Sci-fi, Tudományos, Tankönyv, Történelmi, stb.

| CategoryID | Category |
| ---------- | -------- |
| 1          | Textbook |
## Publishers - Kiadó

Információk a kiadóról.

| PublisherID | Publisher |
| ----------- | --------- |
| 1           | Mozaik    |


## Kapcsolatok

Több-több kapcsolat: Szerzők és könyvek, egy könyvnek lehet több szerzője, és egy szerzőnek lehet több könyve
Egy-több kapcsolat: Tagok és kölcsönzések, egy tag tud több könyvet is kikölcsönözni
Több-több: Könyvek és kölcsönzések, egy könyv többször ki lehet kölcsönözve, egy tag pedig több könyvet is ki tud kölcsönözni
Egy-több: Könyvek és kategóriák, egy könyvnek egy kategóriája van, de egy kategória több könyvé is lehet
Egy-több: Kiadó és könyvek, egy kiadó több könyvet is kiadhat

## Adatbázis fejlesztési lehetőségek

- Megtekintések: Leggyakrabban megtekintett könyvek vagy leggyakrabban kölcsönzött könyvek. 

<div style="page-break-after: always;"></div>


<center><h1>Weboldal</h1></center>

A weboldal felel a tagok kiszolgálásáért. A webes felület HTML, CSS, JavaScript és React.js-ben íródott, hogy dinamikus, interaktív és reszponzív élményt nyújtson.
## Frontend

#### Főoldal

Kereső, ahol a tagok tudnak keresni könyveket cím, szerző, műfaj vagy elérhetőség alapján. Elérhetőség alapján úgy lehet keresni, hogyha bejelöljük, megjelenik az összes elérhető könyv (ami nincs kikölcsönözve). 

#### Tagok oldal

**Bejelentkezés/Regisztráció**: A tagok be tudnak lépni a felhasználónevük vagy email címük és a jelszavuk megadásával. A felhasználók tudnak regisztrálni, hogy tagokká váljanak.

**Kölcsönzés**: A tagok ki tudnak kölcsönözni könyveket.

**Kölcsönzéseim**: Kiírja, hogy milyen könyvek vannak kikölcsönözve a bejelentkezett felhasználó által. 

**Értesítések**: Közeli határidőről figyelmeztetés küldése (erről emailt is kap).

## Backend

A backend felelős a weboldal működéséért. Tartalmazza a korábban leírt adatbázist, ezenfelül az adatbázisból történő lekérdezéseket, ami később továbbításra kerül a weboldalnak és az asztali alkalmazásnak. A backend részt az adatbázison kívül PHP-ban írtuk, ezen felül a Laravel keretrendszert használtuk. 

## Weboldal fejlesztési lehetőségek:

- Algoritmus, ami ajánl a felhasználónak könyveket az eddigi kölcsönzések alapján.
- Szűrés legnépszerűbb könyvekre.
- Cookie-k kezelése, local storage-ben eltárolása. 


<div style="page-break-after: always;"></div>


<center><h1>Asztali alkalmazás</h1></center>

Az asztali alkalmazás a könyvtárosoknak és az adminisztrátoroknak van tervezve, akik nap mint nap hajtanak végre könyvtári feladatokat. Gyors elérést biztosít kritikus funkciókhoz. Az asztali alkalmazást C#-ban írjuk (WinForm)

## Fontos elemek

- **Könyvek kezelése**: Könyveket lehet hozzáadni, módosítani, vagy törölni. 
- **Könyvek kölcsönzése**: Könyveket tudnak kiadni tagok számára, vagy visszavenni azokat, amikor a tag visszahozza a könyveket. Valós idejű kommunikáció az adatbázissal.
- **Raktáron lévő könyvek kezelése**: 
	- Számon tartja a könyvtárban lévő könyvek számát.
	- Számon tartja a lejárt határidejű könyveket.
- **Tagok kezelése**: 
	- Hozzáad új tagokat, vagy kezeli a meglévőket. (Pl.: Személyes adatok módosítása).
	- Tagságok kezelése (Tagság megszüntetése és létrehozása).
- Folyamatos szinkronizálás az adatbázissal.

## Asztali alkalmazás fejlesztési lehetőségek:

- **Folyamatos szinkronizálás kibővítése**: Helyi adatbázis nyilvántartása, ami folyamatosan frissül a fő adatbázissal. Amikor az asztali alkalmazás elveszti a kapcsolatot a fő adatbázissal, továbbra is eléri az adatokat, és módosíthatja azokat. Amikora fő adatbázissal helyreáll a kapcsolat, a helyi adatbázisban történt módosítások érvényesülnek a fő adatbázisra is. 