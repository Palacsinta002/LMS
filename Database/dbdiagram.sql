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
  `bookID` int,
  `title` varchar(255) NOT NULL,
  `authorID` int,
  `ISBN` varchar(13),
  `publicationYear` year,
  `categoryID` int,
  `pusblisherID` int,
  PRIMARY KEY (`bookID`, `pusblisherID`)
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

ALTER TABLE `Books` ADD FOREIGN KEY (`authorID`) REFERENCES `Authors` (`id`);

ALTER TABLE `Books` ADD FOREIGN KEY (`categoryID`) REFERENCES `Categories` (`categoryID`);

ALTER TABLE `Books` ADD FOREIGN KEY (`pusblisherID`) REFERENCES `Publisher` (`publisherID`);

ALTER TABLE `Borrowings` ADD FOREIGN KEY (`memberID`) REFERENCES `Members` (`memberID`);

ALTER TABLE `Books` ADD FOREIGN KEY (`bookID`) REFERENCES `Borrowings` (`bookID`);
