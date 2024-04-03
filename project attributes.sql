-- DDL


create table department(
    dep_name varchar(20),
    dep_id varchar(20),
    primary key(dep_id)
);


create table item_details(
    item_id varchar(20),
    item_name varchar(50),
    mrp number(6,2),
    curr_cost number(6,2),
    primary key(item_id)
);


create table customer_details(
    first_name varchar(20),
    last_name varchar(20),
    customer_id varchar(20),
    phone_number varchar(10) unique,
    status varchar(20),
    primary key(customer_id)
);


create table transactions(
    customer_id varchar(20),
    order_id varchar(20),
    total_amount number(10,2),
    primary key(order_id),
    foreign key(customer_id) references customer_details
);


create table order_details(
    order_id varchar(20),
    item_id varchar(20),
    quantity int,
    foreign key(order_id) references transactions,
    foreign key(item_id) references item_details,
    primary key(order_id, item_id)
);


create table feedback(
    order_id varchar(20),
    customer_id varchar(20),
    rating number(2,1),
    foreign key(order_id) references transactions,
    foreign key(customer_id) references customer_details,
    primary key(order_id)
);


create table employee(
    emp_name varchar(20),
    emp_id varchar(20),
    emp_status varchar(10),
    salary int,
    dep_id varchar(20),
    primary key(emp_id),
    foreign key(dep_id) references department
);


create table employee_hours(
    emp_id varchar(20),
    hours int,
    w_date date,
    foreign key(emp_id) references employee,
    primary key(emp_id, w_date)
);


create table delivery(
    quantity int,
    item_id varchar(20),
    delivery_date date,
    primary key(quantity, item_id, delivery_date),
    foreign key(item_id) references item_details
);


create table stock(
    quantity int,
    item_id varchar(20),
    primary key(item_id),
    foreign key(item_id) references item_details
);


create table coupon(
    coupon_code varchar(20),
    discount number(3,2),
    primary key(coupon_code)
);


create table emp_phone(
    emp_id varchar(20),
    phone_number int,
    primary key(emp_id),
    foreign key(emp_id) references employee
);


create table places_order(
    order_id varchar(20),
    customer_id varchar(20),
    mode_of_payment varchar(20),
    primary key(order_id),
    foreign key(order_id) references transactions,
    foreign key(customer_id) references customer_details
);






-- DML


insert into department values('Electronics', 'E1');
insert into department values('Clothing', 'C1');
insert into department values('Grocery', 'G1');
insert into department values('Furniture', 'F1');
INSERT INTO department VALUES('Hardware', 'H1');
INSERT INTO department VALUES('Toys', 'T1');
INSERT INTO department VALUES('Books', 'B1');
INSERT INTO department VALUES('Sports', 'S1');
INSERT INTO department VALUES('Pharmacy', 'P1');
INSERT INTO department VALUES('Jewelry', 'J1');
INSERT INTO department VALUES('Gardening', 'G2');
INSERT INTO department VALUES('Footwear', 'F2');
INSERT INTO department VALUES('Cosmetics', 'C2');
INSERT INTO department VALUES('Bakery', 'B2');
INSERT INTO department VALUES('Produce', 'P2');




insert into employee values('david', '1001', 'manager', 50000, 'E1');
insert into employee values('john', '1002', 'employee', 20000, 'E1');
INSERT INTO employee VALUES('Emma', '1003', 'employee', 21000, 'B2');
INSERT INTO employee VALUES('Olivia', '1004', 'employee', 22000, 'C1');
INSERT INTO employee VALUES('Ava', '1005', 'employee', 23000, 'G1');
INSERT INTO employee VALUES('Isabella', '1006', 'employee', 24000, 'F1');
INSERT INTO employee VALUES('Sophia', '1007', 'employee', 25000, 'H1');
INSERT INTO employee VALUES('Mia', '1008', 'employee', 26000, 'T1');
INSERT INTO employee VALUES('Charlotte', '1009', 'employee', 27000, 'B1');
INSERT INTO employee VALUES('Amelia', '1010', 'employee', 28000, 'S1');
INSERT INTO employee VALUES('Harper', '1011', 'employee', 29000, 'P1');
INSERT INTO employee VALUES('Evelyn', '1012', 'employee', 30000, 'J1');
INSERT INTO employee VALUES('Abigail', '1013', 'employee', 31000, 'G2');
INSERT INTO employee VALUES('Emily', '1014', 'employee', 32000, 'F2');




INSERT INTO employee_hours VALUES('1001', 8, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1002', 9, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1003', 7, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1004', 8, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1005', 6, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1006', 8, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1007', 9, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1008', 7, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1009', 8, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1010', 6, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1011', 8, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1012', 9, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1013', 7, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1014', 8, TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1001', 8, TO_DATE('2024-03-02', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1002', 9, TO_DATE('2024-03-02', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1003', 7, TO_DATE('2024-03-02', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1004', 8, TO_DATE('2024-03-02', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1005', 6, TO_DATE('2024-03-02', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1006', 8, TO_DATE('2024-03-02', 'YYYY-MM-DD'));
INSERT INTO employee_hours VALUES('1006', 8, TO_DATE('2024-04-02', 'YYYY-MM-DD'));










INSERT INTO item_details VALUES('1101', 'Kellogs Chocos 5kg', 500, 400);
INSERT INTO item_details VALUES('1102', 'Nutella 500g', 300, 250);
INSERT INTO item_details VALUES('1103', 'Maggi 8 Pack', 100, 80);
INSERT INTO item_details VALUES('1104', 'Dettol Handwash 500ml', 150, 120);
INSERT INTO item_details VALUES('1105', 'Dove Shampoo 1L', 200, 150);
INSERT INTO item_details VALUES('1106', 'Pampers Diapers 10 Pack', 300, 250);
INSERT INTO item_details VALUES('1107', 'Organic Honey 500g', 250, 200);
INSERT INTO item_details VALUES('1108', 'Almond Milk 1L', 150, 120);
INSERT INTO item_details VALUES('1109', 'Quinoa 1kg', 350, 320);
INSERT INTO item_details VALUES('1110', 'Olive Oil 500ml', 550, 500);
INSERT INTO item_details VALUES('1111', 'Brown Rice 2kg', 220, 180);
INSERT INTO item_details VALUES('1112', 'Whole Wheat Pasta 500g', 180, 150);
INSERT INTO item_details VALUES('1113', 'Green Tea 100 bags', 300, 270);
INSERT INTO item_details VALUES('1114', 'Dark Chocolate 150g', 120, 100);
INSERT INTO item_details VALUES('1115', 'Peanut Butter 500g', 200, 170);
INSERT INTO item_details VALUES('1116', 'Multigrain Bread 400g', 90, 70);
INSERT INTO item_details VALUES('1117', 'Oats 1kg', 110, 90);
INSERT INTO item_details VALUES('1118', 'Granola Bars pack of 10', 250, 230);
INSERT INTO item_details VALUES('1119', 'Sunflower Seeds 200g', 150, 130);
INSERT INTO item_details VALUES('1120', 'Chia Seeds 200g', 160, 140);






INSERT INTO customer_details VALUES ('John', 'Doe', 'CUST001', '1234567890', 'normal');
INSERT INTO customer_details VALUES ('Jane', 'Smith', 'CUST002', '2345678901', 'loyalty');
INSERT INTO customer_details VALUES ('Emily', 'Jones', 'CUST003', '3456789012', 'normal');
INSERT INTO customer_details VALUES ('Michael', 'Brown', 'CUST004', '4567890123', 'loyalty');
INSERT INTO customer_details VALUES ('Sarah', 'Davis', 'CUST005', '5678901234', 'normal');
INSERT INTO customer_details VALUES ('James', 'Smith', 'CUST006', '9876543210', 'normal');
INSERT INTO customer_details VALUES ('Maria', 'Garcia', 'CUST007', '8765432109', 'loyalty');
INSERT INTO customer_details VALUES ('William', 'Johnson', 'CUST008', '7654321098', 'normal');
INSERT INTO customer_details VALUES ('Patricia', 'Martinez', 'CUST009', '6543210987', 'loyalty');
INSERT INTO customer_details VALUES ('Robert', 'Brown', 'CUST010', '5432109876', 'normal');
INSERT INTO customer_details VALUES ('Linda', 'Davis', 'CUST011', '4321098765', 'loyalty');
INSERT INTO customer_details VALUES ('Michael', 'Miller', 'CUST012', '3210987654', 'normal');
INSERT INTO customer_details VALUES ('Barbara', 'Wilson', 'CUST013', '2109876543', 'loyalty');
INSERT INTO customer_details VALUES ('Charles', 'Moore', 'CUST014', '1098765432', 'normal');
INSERT INTO customer_details VALUES ('Susan', 'Taylor', 'CUST015', '0987654321', 'loyalty');
INSERT INTO customer_details VALUES ('Joseph', 'Anderson', 'CUST016', '1234509876', 'normal');
INSERT INTO customer_details VALUES ('Jessica', 'Thomas', 'CUST017', '2345609876', 'loyalty');
INSERT INTO customer_details VALUES ('Thomas', 'Jackson', 'CUST018', '3456709876', 'normal');
INSERT INTO customer_details VALUES ('Sarah', 'White', 'CUST019', '4567809876', 'loyalty');
INSERT INTO customer_details VALUES ('Karen', 'Harris', 'CUST020', '5678909876', 'normal');




INSERT INTO delivery VALUES(10, '1101', TO_DATE('2024-03-01', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(15, '1103', TO_DATE('2024-03-02', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(20, '1105', TO_DATE('2024-03-03', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(5, '1107', TO_DATE('2024-03-04', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(25, '1109', TO_DATE('2024-03-03', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(30, '1111', TO_DATE('2024-03-06', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(8, '1113', TO_DATE('2024-03-07', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(12, '1115', TO_DATE('2024-03-08', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(14, '1117', TO_DATE('2024-03-09', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(18, '1119', TO_DATE('2024-03-10', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(22, '1102', TO_DATE('2024-03-11', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(17, '1104', TO_DATE('2024-03-12', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(9, '1106', TO_DATE('2024-03-13', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(5, '1108', TO_DATE('2024-03-14', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(12, '1110', TO_DATE('2024-03-15', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(30, '1112', TO_DATE('2024-03-16', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(24, '1114', TO_DATE('2024-03-17', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(18, '1116', TO_DATE('2024-03-18', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(15, '1118', TO_DATE('2024-03-19', 'YYYY-MM-DD'));
INSERT INTO delivery VALUES(20, '1120', TO_DATE('2024-03-20', 'YYYY-MM-DD'));




INSERT INTO stock VALUES(5, '1101');
INSERT INTO stock VALUES(15, '1102');
INSERT INTO stock VALUES(20, '1103');
INSERT INTO stock VALUES(35, '1104');
INSERT INTO stock VALUES(10, '1105');
INSERT INTO stock VALUES(25, '1106');
INSERT INTO stock VALUES(40, '1107');
INSERT INTO stock VALUES(30, '1108');
INSERT INTO stock VALUES(45, '1109');
INSERT INTO stock VALUES(50, '1110');
INSERT INTO stock VALUES(0, '1111');
INSERT INTO stock VALUES(5, '1112');
INSERT INTO stock VALUES(15, '1113');
INSERT INTO stock VALUES(20, '1114');
INSERT INTO stock VALUES(35, '1115');
INSERT INTO stock VALUES(10, '1116');
INSERT INTO stock VALUES(25, '1117');
INSERT INTO stock VALUES(40, '1118');
INSERT INTO stock VALUES(30, '1119');
INSERT INTO stock VALUES(45, '1120');








INSERT INTO coupon VALUES('FLAT20', 0.8);
INSERT INTO coupon VALUES('FLAT40', 0.6);
INSERT INTO coupon VALUES('SAVE10', 0.9);
INSERT INTO coupon VALUES('OFFER05', 0.95);
INSERT INTO coupon VALUES('DISC15', 0.85);
INSERT INTO coupon VALUES('PROMO25', 0.75);
INSERT INTO coupon VALUES('DEAL30', 0.3);
INSERT INTO coupon VALUES('SALE35', 0.35);
INSERT INTO coupon VALUES('CASHBACK45', 0.55);
INSERT INTO coupon VALUES('SPECIAL50', 0.5);




INSERT INTO emp_phone VALUES('1001', 9876543210);
INSERT INTO emp_phone VALUES('1002', 9876543211);
INSERT INTO emp_phone VALUES('1003', 9876543212);
INSERT INTO emp_phone VALUES('1004', 9876543213);
INSERT INTO emp_phone VALUES('1005', 9876543214);
INSERT INTO emp_phone VALUES('1006', 9876543215);
INSERT INTO emp_phone VALUES('1007', 9876543216);
INSERT INTO emp_phone VALUES('1008', 9876543217);
INSERT INTO emp_phone VALUES('1009', 9876543218);
INSERT INTO emp_phone VALUES('1010', 9876543219);
INSERT INTO emp_phone VALUES('1011', 9876543220);
INSERT INTO emp_phone VALUES('1012', 9876543221);
INSERT INTO emp_phone VALUES('1013', 9876543222);
INSERT INTO emp_phone VALUES('1014', 9876543223);
