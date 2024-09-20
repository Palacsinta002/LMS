CREATE TABLE `Authors` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `name` varchar(255),
  `nationality` varchar(255)
);

CREATE TABLE `Categories` (
  `categoryID` int PRIMARY KEY AUTO_INCREMENT,
  `categoryName` varchar(100) NOT NULL
);

CREATE TABLE `Books` (
  `bookID` int PRIMARY KEY,
  `title` varchar(255) NOT NULL,
  `authorID` int,
  `ISBN` varchar(13),
  `publicationYear` year,
  `categoryID` int
);

CREATE TABLE `Members` (
  `memberID` int PRIMARY KEY AUTO_INCREMENT,
  `firstName` varchar(100) NOT NULL,
  `lastName` varchar(100) NOT NULL,
  `membershipType` ENUM(Student,Adult)
);

CREATE TABLE `Borrowings` (
  `borrowID` int PRIMARY KEY AUTO_INCREMENT,
  `memberID` int,
  `bookID` int,
  `borrowDate` date NOT NULL,
  `returned` enum(Yes,No) DEFAULT 'no'
);

CREATE TABLE `Publisher` (
  `publisherID` int PRIMARY KEY,
  `publisher` varchar(100)
);
