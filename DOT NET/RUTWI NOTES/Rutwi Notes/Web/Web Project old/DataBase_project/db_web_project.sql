CREATE TABLE tbl_bus_details(
bus_id int primary key,
bus_rto_number varchar not null,
bus_model varchar,
depot_id int,
maintance_unit bit 
);

CREATE TABLE tbl_depot(
depot_id int primary key,
depot_name varchar not null,
depot_area varchar not null
);

CREATE TABLE tbl_staff(
staff_id int primary key,
staff_first_name varchar(20) not null,
staff_last_name varchar(30) not null,
staff_gender varchar(6),
staff_dob date not null,
Staff_Address varchar(MAX),
staff_area varchar(15),
staff_pin int not null,
staff_contact varchar(20),
staff_email varchar(100),
staff_roll varchar(25),
staff_aadhar_card varchar(16)
);

SELECT bus_id,bus_rto_number,bus_model,depot_id,maintance_unit
FROM tbl_bus_details

SELECT depot_id,depot_name,depot_area
FROM tbl_depot

SELECT staff_id,staff_first_name ,staff_last_name,staff_gender,staff_dob,Staff_Address,staff_area,staff_pin,staff_contact,staff_email,staff_roll,staff_aadhar_card
FROM tbl_staff