-- Create the database
CREATE DATABASE LMS default CHARACTER SET utf8 collate utf8_hungarian_ci;
USE LMS;

-- Create MembershipType table
CREATE TABLE MembershipType(
    MembershipTypeID INT AUTO_INCREMENT PRIMARY KEY,
    MembershipType VARCHAR(100) NOT NULL
);

-- Create Roles table
CREATE TABLE Roles(
    RoleID INT AUTO_INCREMENT PRIMARY KEY,
    Role VARCHAR(100) NOT NULL
);

-- Create Authors table
CREATE TABLE Authors (
    AuthorID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Nationality VARCHAR(100)
);

-- Create Categories table
CREATE TABLE Categories (
    CategoryID INT AUTO_INCREMENT PRIMARY KEY,
    Category VARCHAR(100) NOT NULL
);

-- Create Publisher table
CREATE TABLE Publishers (
    PublisherID INT AUTO_INCREMENT PRIMARY KEY,
    Publisher VARCHAR(255) NOT NULL
);


-- Create Users table (previously called Members)
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    Email Varchar(50) not Null,
    Username Varchar(25) not null,
    Password varchar(100) not null,
    MembershipTypeID INT NOT NULL,
    RoleID INT NOT NULL,
    FOREIGN KEY (MembershipTypeID) REFERENCES MembershipType(MembershipTypeID),
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

-- Create Books table
CREATE TABLE Books (
    BookID INT AUTO_INCREMENT PRIMARY KEY,
    PublisherID INT,
    AuthorID INT,
    CategoryID INT,
    Title VARCHAR(255) NOT NULL,
    PublicationYear YEAR,
    ISBN VARCHAR(13),
    CopiesAvailable INT DEFAULT 0,
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    FOREIGN KEY (PublisherID) REFERENCES Publishers(PublisherID)
);

-- Create Borrowings table
CREATE TABLE Borrowings (
    BorrowID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    BookID INT NOT NULL,
    BorrowDate DATE NOT NULL,
    ReturnDate Date,
    DueDate Date not null,
    IsReturned boolean,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (BookID) REFERENCES Books(BookID)
);
