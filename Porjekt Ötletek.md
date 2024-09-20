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