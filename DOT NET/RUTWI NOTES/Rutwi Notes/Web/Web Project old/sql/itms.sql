USE ITMS

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

CREATE TABLE tbl_schedule(
schedule_id int primary key,
bus_id int,
staff_id int,
route_id int,
starting_point varchar(30),
destination varchar(30),
schedule_date date,
departure_time time,
);

CREATE TABLE tbl_routes(
route_id int primary key,
route_name varchar(60),
destination varchar(30)
);

CREATE TABLE tbl_routes_stops(
stop_id int primary key,
stop_name varchar(30),

);

CREATE TABLE tbl_depots(
depot_id int primary key,
depot_name varchar(20),
depot_area varchar(40)
);

CREATE TABLE tbl_ticket(
ticket_num varchar(20),
schedule_id int,
ticket_date date,
ticket_time time,
head_num int,
amount decimal
);

CREATE TABLE tbl_shift(
shift_id varchar(10),
shift_date date,
shift_time time,
staff_id int
);