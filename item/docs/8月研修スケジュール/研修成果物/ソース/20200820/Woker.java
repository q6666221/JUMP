package maintext;

import java.util.List;

public class Woker {
	public Woker(int id, String name, String phone, double money) {
		super();
		this.id = id;
		this.name = name;
		this.phone = phone;
		this.money = money;
	}
	public Woker(){}
	private int id;
	private String name;
	private String phone;
	private double money;
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}
	public double getMoney() {
		return money;
	}
	public void setMoney(double money) {
		this.money = money;
	}
	
	public void show(List<Woker> olist){
		int i=0;
		for (Woker woker : olist) {
			System.out.println(olist.get(i).getId()+"  "+olist.get(i).getMoney()+"  "+olist.get(i).getName()+"  "+olist.get(i).getPhone()+"  ");
			i++;
		}
		
	}
	
	
	
	
}
