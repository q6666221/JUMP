package maintext;

import java.util.List;

public class Userinfo {
	private String admin;
	private String pass;
	private String name;
	private String sex;//
	private int age;//
	private String phone;//
	
	public Userinfo(){}

	public Userinfo(String adinim,String pass){
		this.admin = admin;
		this.pass = pass;
	}
	public Userinfo(String admin){
		this.admin=admin;
	}
	public Userinfo(String admin, String pass, String name, String sex,
			int age, String phone) {
		super();
		this.admin = admin;
		this.pass = pass;
		this.name = name;
		this.sex = sex;
		this.age = age;
		this.phone = phone;
	}
	/**
	 * Geger and Setter
	 * @return
	 */
	public String getAdmin() {
		return admin;
	}
	public void setAdmin(String admin) {
		this.admin = admin;
	}
	public String getPass() {
		return pass;
	}
	public void setPass(String pass) {
		this.pass = pass;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getSex() {
		return sex;
	}
	public void setSex(String sex) {
		this.sex = sex;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
	}
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}
	
	
	
	
	
}
