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

| BookID | Title       | AuthorID | ISBN | PublicationYear | CategoryID | CopiesAvailable |
| ------ | ----------- | -------- | ---- | --------------- | ---------- | --------------- |
| 1      | Irodalom 9. | 1        | 1234 | 2020            | 1          | 5               |
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
