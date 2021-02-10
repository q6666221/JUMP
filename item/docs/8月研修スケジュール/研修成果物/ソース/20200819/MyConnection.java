package maintext;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class MyConnection {
	
	public static void main(String[] args) {
		getConnection();
		
	}
	
	
	public static void getConnection(){
		try {
			
			Class.forName("oracle.jdbc.driver.OracleDriver");
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			System.out.println("......");
			e.printStackTrace();
		}
		//通过
		try {
			String url="jdbc:oracle:thin:@localhost:1521:orcl";
			Connection conn=DriverManager.getConnection(url,"scott","root");
			System.out.println(">......");
			
			//addWoker(conn);
			//updateSchool(conn);
			//deleteSchool(conn);
			selectSchool(conn);
			
			
			
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			System.out.println("......");
			e.printStackTrace();
		}
	}
	
	
	public static void addWoker(Connection conn){
		Statement sta;
		try {
			
			sta=conn.createStatement();
			String insert_sql="insert into worker values(3,'','13800000003',5000)";
						int getrow= sta.executeUpdate(insert_sql);
			if (getrow>0) {
				System.out.println("成功");
			}else{
				System.out.println("失败");
			}
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	
	public static void updateSchool(Connection conn){
		try {
			Statement sta=conn.createStatement();
			String update_sql="update school set s_name='C大学' where s_name='YYYY大学'";
			int getrow=sta.executeUpdate(update_sql);
			if(getrow>0){
				System.out.println("成功"+getrow);
			}else{
				System.out.println("失败"+getrow);
			}
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	
	
	public static void deleteSchool(Connection conn){
		try {
			Statement sta=conn.createStatement();
			String delete_sql="delete from school where s_id=1";
			int getrow= sta.executeUpdate(delete_sql);
			if(getrow>0){
				System.out.println("成功");
			}else{
				System.out.println("失败");
			}
			
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
		
		
	}
	
	
	
	
	public static void selectSchool(Connection conn){
		try {
			List<Woker> olist=new ArrayList<Woker>();
			Statement sta=conn.createStatement();
			String sql="select * from worker";
				ResultSet set= sta.executeQuery(sql);
			while(set.next()){
				String name= set.getString("w_name");
				int id= set.getInt("w_id");
				String phone=set.getString("w_phone");
				double money=set.getDouble("w_money");
				Woker woker=new Woker(id,name,phone,money);
				olist.add(woker);
			}
			Woker woker=new Woker();
			woker.show(olist);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	
	
	
	
	
	
	

}
