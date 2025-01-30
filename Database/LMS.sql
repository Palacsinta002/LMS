CREATE TABLE `Publishers` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `publisher` varchar(100) NOT NULL
);

CREATE TABLE `Authors` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `author` varchar(255) NOT NULL
);

CREATE TABLE `Categories` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `category` varchar(100) NOT NULL
);

CREATE TABLE `Roles` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `role` varchar(20) NOT NULL
);

CREATE TABLE `Users` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `firstName` varchar(100) NOT NULL,
  `lastName` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(128) NOT NULL,
  `roleID` int NOT NULL
);

CREATE TABLE `Books` (
  `ISBN` bigint(13) PRIMARY KEY,
  `pusblisherID` int NOT NULL,
  `title` varchar(255) NOT NULL,
  `publicationYear` int(4) NOT NULL
);

CREATE TABLE `Borrowings` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `ISBN` bigint NOT NULL,
  `userID` int NOT NULL,
  `borrowDate` date NOT NULL,
  `returnDate` date,
  `dueDate` date NOT NULL
);

CREATE TABLE `Books_Authors` (
  `Books_ISBN` int(13) NOT NULL,
  `Authors_id` int(13) NOT NULL,
  PRIMARY KEY (`Books_ISBN`, `Authors_id`)
);

CREATE TABLE `Books_Categories` (
  `Books_ISBN` int(13) NOT NULL,
  `Categories_id` int(13) NOT NULL,
  PRIMARY KEY (`Books_ISBN`, `Categories_id`)
);

ALTER TABLE `Borrowings` ADD FOREIGN KEY (`ISBN`) REFERENCES `Books` (`ISBN`);

ALTER TABLE `Borrowings` ADD FOREIGN KEY (`userID`) REFERENCES `Users` (`id`);

ALTER TABLE `Users` ADD FOREIGN KEY (`roleID`) REFERENCES `Roles` (`id`);

ALTER TABLE `Books` ADD FOREIGN KEY (`pusblisherID`) REFERENCES `Publishers` (`id`);

ALTER TABLE `Books` ADD FOREIGN KEY (`ISBN`) REFERENCES `Books_Authors` (`Books_ISBN`);

ALTER TABLE `Authors` ADD FOREIGN KEY (`id`) REFERENCES `Books_Authors` (`Authors_id`);

ALTER TABLE `Books` ADD FOREIGN KEY (`ISBN`) REFERENCES `Books_Categories` (`Books_ISBN`);

ALTER TABLE `Categories` ADD FOREIGN KEY (`id`) REFERENCES `Books_Categories` (`Categories_id`);
