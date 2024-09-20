Projekt név: LMS (Library Management System)

# Csapatfelosztás

| Tóth Zoltán András              | Zsömbörgi Soma István | Vágvölgyi Máté                           |
| ------------------------------- | --------------------- | ---------------------------------------- |
| Frontend                        | Backend               | Asztali alkalmazás                       |
| HTML, CSS, JavaScript           | MySQL, PHP            | C#                                       |
| Weboldal a felhasználók részére | Háttér adatbázis      | Könyvtárosok és adminisztrátorok részére |

# Adatbázis

## Books - Könyvek
##### Adatokat tárol a könyvekről

| BookID | Title       | AuthorID | PublisherID | ISBN | PublicationYear | CategoryID | CopiesAvailable |
| ------ | ----------- | -------- | ----------- | ---- | --------------- | ---------- | --------------- |
| 1      | Irodalom 9. | 1        | 1           | 1234 | 2020            | 1          | 5               |
# Authors - Szerzők
##### Információkat tárol az írókról.

| AuthorID | Name                | Nationality |
| -------- | ------------------- | ----------- |
| 1        | William Shakespeare | Angol       |
# Members - Tagok
##### Adatokat tárol a könyveket kölcsönző tagokról
##### A MembershipType lehet diák, tanár, felnőtt

| MemberID | FirstName | LastName | Email                  | MembershipType |
| -------- | --------- | -------- | ---------------------- | -------------- |
| 1        | Árpád     | Péter    | peterarpad@cicamail.hu | Felnőtt        |
# Borrowings - Kölcsönzések
##### Követi, hogy melyik könyvek vannak kikölcsönözve, és hogy kik kölcsönzik őket

| BorrowID | MemberID | BookID | BorrowDate  | ReturnDate  | DueDate     | IsReturned |
| -------- | -------- | ------ | ----------- | ----------- | ----------- | ---------- |
| 1        | 1        | 1      | 2023.12.07. | null        | 2024.12.07. | false      |
| 2        | 2        | 2      | 2024.03.22. | 2024.06.15. | 2025.03.22. | true       |
# Staff - Alkalmazottak
##### Információk a könyvtárosokról és az adminisztrátorokról

| StaffID | FirstName | LastName | Email                      | Role       |
| ------- | --------- | -------- | -------------------------- | ---------- |
| 1       | Nikolasz  | Székej   | szekejnikolasz@cicamail.hu | Könyvtáros |
# Categories - Kategóriák
##### Könyvkategóriák: Sci-fi, Tudományos, Tankönyv, Történelmi, stb.

| CategoryID | CategoryName |
| ---------- | ------------ |
| 1          | Tankönyv     |
# Publisher - Kiadó
##### Információk a kiadóról

| PublisherID | Publisher |
| ----------- | --------- |
| 1           | Mozaik    |
# Kapcsolatok

Több-több kapcsolat: Szerzők és könyvek, egy könyvnek lehet több szerzője, és egy szerzőnek lehet több könyve
Egy-több kapcsolat: Tagok és kölcsönzések, egy tag tud több könyvet is kikölcsönözni
Több-több: Könyvek és kölcsönzések, egy könyv többször ki lehet kölcsönözve, egy tag pedig több könyvet is ki tud kölcsönözni
Egy-több: Könyvek és kategóriák, egy könyvnek egy kategóriája van, de egy kategória több könyvé is lehet
Egy-több: Kiadó és könyvek, egy kiadó több könyvet is kiadhat

# Adatbázis fejlesztési lehetőségek
##### Megtekintések: Leggyakrabban megtekintett könyvek vagy leggyakrabban kölcsönzött könyvek. 