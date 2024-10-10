// Use DBML to define your database structure
// Docs: https://dbml.dbdiagram.io/docs

/*Table follows {
  following_user_id integer
  followed_user_id integer
  created_at timestamp 
}

Table users {
  id integer [primary key]
  username varchar
  role varchar
  created_at timestamp
}

Table posts {
  id integer [primary key]
  title varchar
  body text [note: 'Content of the post']
  user_id integer
  status varchar
  created_at timestamp
}

Ref: posts.user_id > users.id // many-to-one

Ref: users.id < follows.following_user_id

Ref: users.id < follows.followed_user_id*/

Table Authors{
  id int [primary key, increment]
  name varchar(255)
  nationality varchar(255)
}
Table Categories{
  categoryID int [primary key, increment]
  categoryName varchar(100) [not null]
}
Table Books {
  bookID int [primary key]
  title varchar(255) [not null]
  authorID int 
  ISBN varchar(13)
  publicationYear year
  categoryID int
  pusblisherID int [primary key]
}
Table Users{
  userID int [primary key, increment]
  firstName varchar(100) [not null]
  lastName varchar(100) [not null]
  email varchar(100) [not null]
  username varchar(100) [not null]
  password varchar(255) [not null]
  membershipType ENUM("Student", "Adult")
  role ENUM("Admin", "Staff", "Member")
}
Table Borrowings{
  borrowID int [primary key, increment]
  userID int
  bookID int
  borrowDate date [not null]
  returned enum("Yes", "No") [default: "no"]
}
table Publisher{
  publisherID int [primary key, increment]
  publisher varchar(100)
}


Ref: "Authors"."id" < "Books"."authorID"

Ref: "Categories"."categoryID" < "Books"."categoryID"

Ref: "Publisher"."publisherID" < "Books"."pusblisherID"

Ref: "Users"."userID" < "Borrowings"."userID"

Ref: "Borrowings"."bookID" < "Books"."bookID"