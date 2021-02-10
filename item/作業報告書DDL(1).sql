-- Table: companys

-- DROP TABLE companys


--无问题
drop TABLE companys;
CREATE TABLE companys
(
    c_id int NOT NULL,   --会社ID  順序 主キ
    c_name varchar(50)  NOT NULL,  --会社名　not null 一意キ
    CONSTRAINT companys_pkey PRIMARY KEY (c_id)
)
commit;
	
create unique index  companys_c_name_un on companys(c_name);

DROP SEQUENCE companys_sequence;
CREATE SEQUENCE companys_sequence
    INCREMENT BY 1
    START WITH 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 2;



INSERT INTO companys(
	c_id, c_name)
	VALUES (NEXT VALUE FOR companys_sequence, 'ニューエリート株式会社');

INSERT INTO companys(
	c_id, c_name)
	VALUES (NEXT VALUE FOR companys_sequence, 'NE東京株式会社');

INSERT INTO companys(
	c_id, c_name)
	VALUES (NEXT VALUE FOR companys_sequence, 'ネックス株式会社');

select * from companys;


----------------------------------------------------------------------------------

-- Table: departments

-- DROP TABLE departments;

--无问题
CREATE TABLE departments
(
    d_id int NOT NULL,   --　部門ID  順序 主キ
    c_id int,	     --　会社番号
    d_name varchar(50)  NOT NULL,  --部門名　not null 一意キ
    CONSTRAINT departments_pkey PRIMARY KEY (d_id)
)
commit;

DROP SEQUENCE departments_sequence;
CREATE SEQUENCE departments_sequence
    INCREMENT BY 1
    START WITH 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 2;

INSERT INTO departments(
	d_id, c_id, d_name)
	VALUES (NEXT VALUE FOR  departments_sequence,1, '管理部');
	
INSERT INTO departments(
	d_id, c_id, d_name)
	VALUES (NEXT VALUE FOR  departments_sequence,1, '営業部');
	
INSERT INTO departments(
	d_id, c_id, d_name)
	VALUES (NEXT VALUE FOR  departments_sequence,1, 'システム開発部');
	
INSERT INTO departments(
	d_id, c_id, d_name)
	VALUES (NEXT VALUE FOR  departments_sequence,2, '管理部');
	
INSERT INTO departments(
	d_id, c_id, d_name)
	VALUES (NEXT VALUE FOR  departments_sequence,2, '営業部');
	
INSERT INTO departments(
	d_id, c_id, d_name)
	VALUES (NEXT VALUE FOR  departments_sequence,2, 'システム開発部');
	
INSERT INTO departments(
	d_id, c_id, d_name)
	VALUES (NEXT VALUE FOR  departments_sequence,3, '管理部');
	
INSERT INTO departments(
	d_id, c_id, d_name)
	VALUES (NEXT VALUE FOR  departments_sequence,3, '営業部');
	
INSERT INTO departments(
	d_id, c_id, d_name)
	VALUES (NEXT VALUE FOR  departments_sequence,3, 'システム開発部');

-----------------------------------------------------------------------------------------------------
--无问题
drop TABLE users;
CREATE TABLE users
(
    u_id int NOT NULL,　　--ユーザID　順序 主キ
    u_name varchar(50) ,　　--ユーザ名
    u_location varchar(150) ,--ユーザ連絡先
    CONSTRAINT users_pkey PRIMARY KEY (u_id)
)
commit;

CREATE SEQUENCE user_sequence
    INCREMENT BY 1
    START WITH 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 2;


INSERT INTO users(
	u_id, u_name, u_location)
	VALUES (NEXT VALUE FOR  user_sequence, 'チンホウイ', '東京');
	
INSERT INTO users(
	u_id, u_name, u_location)
	VALUES (NEXT VALUE FOR  user_sequence, 'ごらくらく', '東京');

INSERT INTO users(
	u_id, u_name, u_location)
	VALUES (NEXT VALUE FOR  user_sequence, 'おうかいえん', '東京');

------------------------------------------------------------------------------------------------------

--无问题 需要 填数据
drop table employees;
CREATE TABLE employees
(
    e_id int NOT NULL,     --　社員ID  順序 主キ
    d_id int,	       --  部門番号
    m_id int,	　　　 --  上司の社員番号
    e_name varchar(50)  NOT NULL,   -- 社員名
	u_id int,
	p_id int,
	e_password varchar(50),
	seal varchar(200),
	create_time varchar(50),
    CONSTRAINT employees_pkey PRIMARY KEY (e_id)
)
commit;

drop sequence employees_sequence;
CREATE SEQUENCE employees_sequence
    INCREMENT BY 1
    START WITH 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 2;

insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'胡正培',1);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'田中一郎',1);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'薄井信一',1);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'張敏',1);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'小幡麻衣',1);

insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'戸田昌宏',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'落合誠',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'季晨輝',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'郭淞愷',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'染谷圭祐',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'田中博之',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'山田彩花',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'宇田川達弥',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'阿曽真実',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'李志俊',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'喩琳',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'施発建',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'董宇航',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'唐宇',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'任桐',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'呉美冀',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'堤創太',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'李堅',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'劉芬',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'孫幸如',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'頼俊朋',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'張瑩',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'朱姍',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'徐文麗',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'唐琪博',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'楊棟',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'李航',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'周慧敏',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'崔子君',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'周新',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'邱文祥',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'余熊生',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'陳芳怡',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'李萌華',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'陽春燕',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'紀永嘉',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'叶彦求',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'頼碧優',3);
insert into employees(e_id,e_name,d_id)  values(NEXT VALUE FOR  employees_sequence,'張子祺',3);

---------------------------------------------------------------------------------------------------


-- Table: reports

-- DROP TABLE reports;

--有问题 需要数据
drop table reports;
CREATE TABLE reports
(
    r_id int NOT NULL,　　--　報告書ID  順序 主キ
    u_id int,	　　　--ユーザID
    e_id int,	　　　--社員ID
	sales_flag bit,
	com_flag bit,
    r_date varchar(10) ,　--報告書の年月日
    total_worktime varchar(10) ,--毎月の勤務時間の合計
    overtime varchar(10) ,　　　--残業時間の合計
    important_content varchar(300) ,--重要事項
    create_time datetime default getdate(),	--報告書作成時間
    CONSTRAINT reports_pkey PRIMARY KEY (r_id)
)
commit;

drop SEQUENCE reports_sequence;
CREATE SEQUENCE reports_sequence
    INCREMENT BY 1
    START WITH 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 2;


---------------------------------------------------------------------------------------------------

--有问题 确认中
drop table reports_detail;
CREATE TABLE reports_detail
(
    r_d_id int NOT NULL,	--作業報告書の詳細　ID　順序 主キ
    r_id int NOT NULL,	-- 報告書ID
    start_time varchar(50),	--毎日の勤務開始時間
    end_time varchar(50),	--毎日の勤務終了時間
    work_time varchar(10) ,	--毎日の勤務時間の合計
    work_content varchar(150) ,	--毎日の勤務内容
    CONSTRAINT reports_detail_pkey PRIMARY KEY (r_d_id)
)
commit;

drop SEQUENCE reports_detail_sequence;
CREATE SEQUENCE reports_detail_sequence
    INCREMENT BY 1
    START WITH 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 2;


--可能存在问题
drop table  halftime;
create table halftime(
	u_id int,
	h_name varchar(30),
	h_starttime varchar(50),
	h_endtime varchar(50)
)

--肯能需要填充 休日数据 
drop table holidays;
create table holidays(
	h_name varchar(50),
	h_dates varchar(50)
)