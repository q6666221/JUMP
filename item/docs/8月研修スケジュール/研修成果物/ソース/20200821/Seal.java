package DaoText;


public class Seal {

	private int id;
	private String name;
	private String num;
	private String price;
	private String indate;
	private String outdate;
	private String add;
	private String fac;
	
	
	public Seal(int id, String name, String num, String price, String indate,
			String outdate, String add, String fac) {
		super();
		this.id = id;
		this.name = name;
		this.num = num;
		this.price = price;
		this.indate = indate;
		this.outdate = outdate;
		this.add = add;
		this.fac = fac;
	}
	
	public Seal(String name,String num){
		this.name = name;
		this.num=num;
	}
	public Seal(){}
	public Seal(String num){
		this.num=num;
	}
	
	
	
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
	public String getNum() {
		return num;
	}
	public void setNum(String num) {
		this.num = num;
	}
	public String getPrice() {
		return price;
	}
	public void setPrice(String price) {
		this.price = price;
	}
	public String getIndate() {
		return indate;
	}
	public void setIndate(String indate) {
		this.indate = indate;
	}
	public String getOutdate() {
		return outdate;
	}
	public void setOutdate(String outdate) {
		this.outdate = outdate;
	}
	public String getAdd() {
		return add;
	}
	public void setAdd(String add) {
		this.add = add;
	}
	public String getFac() {
		return fac;
	}
	public void setFac(String fac) {
		this.fac = fac;
	}



}
