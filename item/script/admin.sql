drop table if exists students;
-- create table students (
-- 	id varchar(10) primary key,
-- 	sid varchar(32) unique,
-- 	sname varchar(20),
-- 	openid varchar(28) unique,
-- 	address varchar(50)
-- );

create table students (
	sid varchar(32) primary key,
	sname varchar(20),
	openid varchar(28) unique,
	address varchar(50)
);

insert into students values ('ss0001','张三','12314648','江西新余');
insert into students values ('ss0002','李四','12314649','江西南昌');
insert into students values ('ss0003','王五','12314650','江西抚州');
insert into students values ('ss0004','赵六','12314651','江西赣州');

insert into students values ('ss0005','张三','12314660','江西新余');
insert into students values ('ss0006','李四','12314661','江西南昌');
insert into students values ('ss0007','王五','12314662','江西抚州');
insert into students values ('ss0008','赵六','12314663','江西赣州');

insert into students values ('ss0009','张三','12314664','江西新余');
insert into students values ('ss00010','李四','12314665','江西南昌');
insert into students values ('ss00011','王五','12314666','江西抚州');
insert into students values ('ss00012','赵六','12314667','江西赣州');
-- 
-- insert into students values ('1','ss0001','张三','12314648','江西新余');
-- insert into students values ('2','ss0002','李四','12314649','江西南昌');
-- insert into students values ('3','ss0003','王五','12314650','江西抚州');
-- insert into students values ('4','ss0004''赵六','12314651','江西赣州');

drop table if exists classes;
create table classes (
	cid varchar(32) primary key,
	ccode varchar(8) unique,
	cname varchar(20) unique
);

insert into classes values ('sc0001','ss210104','尚首2101班');
insert into classes values ('sc0002','ss201201','尚首2012班');

drop table if exists parents;
create table parents (
	pid varchar(32) primary key,
	pname varchar(20),
	openid varchar(28) unique,
	address varchar(50)
);

insert into parents values ('sp0001','张三爹','12314652','江西新余');
insert into parents values ('sp0002','李四娘','12314653','江西南昌');
insert into parents values ('sp0003','王五娘','12314654','江西抚州');
insert into parents values ('sp0004','赵六爹','12314655','江西赣州');

drop table if exists emps;
create table emps (
	eid varchar(32) primary key,
	ename varchar(20),
	openid varchar(28) unique,
	address varchar(50)
);

insert into emps values ('se0001','徐明','12314656','江西新余');
insert into emps values ('se0002','柯善斌','12314657','江西南昌');
insert into emps values ('se0003','本田','12314658','江西抚州');
insert into emps values ('se0004','山田','12314659','江西赣州');
