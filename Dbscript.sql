
CREATE TABLE books
(id int NOT NULL  IDENTITY(1,1) PRIMARY KEY,
title varchar(250)  NULL,
year date NULL,
author varchar(250) NULL);


CREATE TABLE reviewers
(id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
name varchar(250) NULL);


CREATE TABLE ratings
(reviewer_id int NOT NULL,
book_id int NOT NULL,
rating int NOT NULL,
rating_date date  NULL);


select distinct  b.* from books b
INNER JOIN ratings rat on rat.book_id = b.id 
INNER JOIN  reviewers r on rat.reviewer_id = r.id
where rat.rating > 3  