/* File 02.6 */

-- Problem 1
CREATE SCHEMA online_shop;
USE online_shop;

CREATE TABLE cities(
	city_id INT NOT NULL PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);
CREATE TABLE customers(
	customer_id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50) NOT NULL,
    birthday DATE NOT NULL,
    city_id INT,
    CONSTRAINT fk_city_id
    FOREIGN KEY (city_id) REFERENCES cities(city_id)
);
CREATE TABLE orders(
	order_id INT NOT NULL PRIMARY KEY,
    customer_id INT,
    CONSTRAINT fk_customer_order
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);

CREATE TABLE item_types(
	item_type_id INT NOT NULL PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);
CREATE TABLE items(
	item_id INT NOT NULL PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    item_type_id INT,
    CONSTRAINT fk_item_type_id
    FOREIGN KEY (item_type_id) REFERENCES item_types(item_type_id)
);

CREATE TABLE order_items(
	order_id INT NOT NULL,
    item_id INT NOT NULL,
    CONSTRAINT pk_order_items PRIMARY KEY (order_id, item_id),
    CONSTRAINT fk_order_id
    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    CONSTRAINT fk_item_id 
    FOREIGN KEY (item_id) REFERENCES items(item_id) 
);

-- Problem 2
CREATE SCHEMA university;
USE university;

CREATE TABLE majors(
	major_id INT NOT NULL PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);
CREATE TABLE students(
	student_id INT NOT NULL PRIMARY KEY,
    student_number VARCHAR(12) NOT NULL,
    student_name VARCHAR(50) NOT NULL,
    major_id INT,
    CONSTRAINT fk_major_id
    FOREIGN KEY (major_id) REFERENCES majors(major_id)
);
CREATE TABLE payments(
	payment_id INT NOT NULL PRIMARY KEY,
    payment_date DATE NOT NULL,
    payment_amount DECIMAL(8, 2) NOT NULL,
    student_id INT,
    CONSTRAINT fk_student_id
    FOREIGN KEY (student_id) REFERENCES students(student_id)
);

CREATE TABLE subjects(
	subject_id INT NOT NULL PRIMARY KEY,
    subject_name VARCHAR(50) NOT NULL
);
CREATE TABLE agenda(
	student_id INT NOT NULL,
    subject_id INT NOT NULL,
    CONSTRAINT pk_agenda PRIMARY KEY (student_id, subject_id),
    CONSTRAINT fk_agenda_student_id
    FOREIGN KEY (student_id) REFERENCES students(student_id),
    CONSTRAINT fk_agenda_subject_id
    FOREIGN KEY (subject_id) REFERENCES subjects(subject_id)
);