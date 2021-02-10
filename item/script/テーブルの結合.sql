-- ©‘RŒ‹‡
select distinct deptno from emp natural join dept;

select * from emp;

select * from dept;

alter table dept rename column deptn to deptno;

alter table dept rename column deptno to deptn;

-- using‚ğg—p‚µ‚½Œ‹‡
select * from emp join dept using(deptno);

select rownum, avg(sal), deptno from emp group by deptno order by ;

create public synonym e for employees;
