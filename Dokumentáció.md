#### Projekt név: LMS (Library Management System)

# Csapatfelosztás

| Tóth Zoltán András              | Zsömbörgi Soma István | Vágvölgyi Máté                           |
| ------------------------------- | --------------------- | ---------------------------------------- |
| Frontend                        | Backend               | Asztali alkalmazás                       |
| HTML, CSS, JavaScript           | MySQL, PHP            | C#                                       |
| Weboldal a felhasználók részére | Háttér adatbázis      | Könyvtárosok és adminisztrátorok részére |

# Adatbázis

## Books - Könyvek

Adatokat tárol a könyvekről.

| BookID | Title       | AuthorID | PublisherID | ISBN | PublicationYear | CategoryID | CopiesAvailable |
| ------ | ----------- | -------- | ----------- | ---- | --------------- | ---------- | --------------- |
| 1      | Irodalom 9. | 1        | 1           | 1234 | 2020            | 1          | 5               |
## Authors - Szerzők

Információkat tárol az írókról.

| AuthorID | Name                | Nationality |
| -------- | ------------------- | ----------- |
| 1        | William Shakespeare | British     |
## Borrowings - Kölcsönzések

Követi, hogy melyik könyvek vannak kikölcsönözve, és hogy kik kölcsönzik őket.

| BorrowID | MemberID | BookID | BorrowDate | ReturnDate | DueDate    | IsReturned |
| -------- | -------- | ------ | ---------- | ---------- | ---------- | ---------- |
| 1        | 1        | 1      | 12/07/2023 | null       | 12/07/2024 | false      |
| 2        | 2        | 2      | 03/22/2024 | 06/15/2024 | 03/22/2025 | true       |
## Users - Felhasználók

Adatokat tárol a felhasználókról.

| MemberID | FirstName | LastName | Email                  | Username     | Password   | MembershipTypeID | RoleID |
| -------- | --------- | -------- | ---------------------- | ------------ | ---------- | ---------------- | ------ |
| 1        | Árpád     | Péter    | peterarpad@cicamail.hu | Peterarpad04 | !asdf123.. | 1                | 1      |
## MembershipType - Tagság típus

A tagság típusait tárolja el. 

| MembershipTypeID | MemebershipType |
| ---------------- | --------------- |
| 1                | Student         |
| 2                | Teacher         |
| 3                | Adult           |
| 4                | None            |
## Roles - Rangok

A rangokat tárolja el. 

| RoleID | Role      |
| ------ | --------- |
| 1      | Member    |
| 2      | Admin     |
| 3      | Librarian |
## Categories - Kategóriák

Könyvkategóriák: Sci-fi, Tudományos, Tankönyv, Történelmi, stb.

| CategoryID | CategoryName |
| ---------- | ------------ |
| 1          | Textbook     |
## Publisher - Kiadó

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

Megtekintések: Leggyakrabban megtekintett könyvek vagy leggyakrabban kölcsönzött könyvek. 




# Weboldal

A weboldal fog felelni a tagok kiszolgálásáért
## Frontend

#### Főoldal

Kereső, ahol a tagok tudnak keresni könyveket cím, szerző, műfaj vagy elérhetőség alapján. Elérhetőség alapján úgy lehet keresni, hogyha bejelöljük, megjelenik az összes elérhető könyv (ami nincs kikölcsönözve). 

#### Tagok oldal

Bejelentkezés/Regisztráció: A tagok be tudnak lépni a