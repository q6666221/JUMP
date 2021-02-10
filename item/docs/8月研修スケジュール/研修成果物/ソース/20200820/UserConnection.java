package maintext;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;


public class UserConnection {
	
	public void getConnection(int i,Userinfo user){
		try {
			
			Class.forName("oracle.jdbc.driver.OracleDriver");		
		} catch (ClassNotFoundException e) {

			System.out.println("");
			e.printStackTrace();
		}

		try {
			String url="jdbc:oracle:thin:@localhost:1521:orcl";	
			Connection conn=DriverManager.getConnection(url, "scott", "root");
			System.out.println("......");
			
			
			if(i==0){
				
				addUser(conn,user);
			}else if(i==1){
				
				updataPass(conn,user);
				
			}else if(i==2){
				
				delUser(conn,user);
				
			}else if(i==3){
				
				showUserinfo(conn);
						
			}
					
		} catch (SQLException e) {
			
			System.out.println("");
			e.printStackTrace();
		}
	}
	
	public void addUser(Connection conn,Userinfo user){
		Statement sta;
		try {

			sta=conn.createStatement();
		
			String insert_alluser="insert into alluser values(uid_in.nextval,'"+user.getAdmin()+"','"+user.getPass()+"')";
			int alluserrow=sta.executeUpdate(insert_alluser);
			String insert_userinfo="insert into userinfo values(uid_in.currval,'"+user.getName()+"',"+user.getAge()+",'"+user.getSex()+"','"+user.getPhone()+"',sysdate,uid_in.currval )";
			int userinforow=sta.executeUpdate(insert_userinfo);
			if(alluserrow>0 && userinforow>0){
				System.out.println("...");
			}else if(alluserrow>0 || userinforow>0){
				System.out.println("...");
			}else{
				System.out.println("......");
			}
		} catch (SQLException e) {
			
			e.printStackTrace();
		}
	}
	
	public void updataPass(Connection conn,Userinfo user){
		Statement sta;
		try {
		
			sta=conn.createStatement();
			String updata_sql="update alluser set user_pass='"+user.getPass()+"' where user_admin='"+user.getAdmin()+"'";
			
			int row=sta.executeUpdate(updata_sql);
			if(row>0){
				System.out.println(row+"");
			}else{
				System.out.println("");
			}
		} catch (SQLException e) {
			
			e.printStackTrace();
		}
	}
	
	public void delUser(Connection conn,Userinfo user){
		Statement sta;
		try {
			
			sta=conn.createStatement();
			String del_sql="delete from alluser where user_id=(select user_id from alluser where user_admin='"+user.getAdmin()+"')";
						int row=sta.executeUpdate(del_sql);
			if(row>0){
				System.out.println("...");
			}else{
				System.out.println("...");
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
		public void showUserinfo(Connection conn){	
		try {
			List<Userinfo> list=new ArrayList<Userinfo>();
			Statement sta=conn.createStatement();
			int i=1;
			String select_sql="select rownum r,alluser.*,userinfo.* from alluser,userinfo where rownum between 1 and 10";
			
			ResultSet set =sta.executeQuery(select_sql);
			while (set.next()) {
				String admin=set.getString("user_admin");
				String pass=set.getString("user_pass");
				String name=set.getString("uinfo_name");
				String sex=set.getString("uinfo_sex");
				int age=set.getInt("uinfo_age");
				String phone=set.getString("uinfo_phonenum");
				Userinfo user=new Userinfo(admin,pass,name,sex,age,phone);
				list.add(user);
			}
			Userinfo user=new Userinfo();
			user.showinfo(list);
		} catch (SQLException e) {
			
			e.printStackTrace();
		}	
	}
	
	
	
	
	
	
	

}
