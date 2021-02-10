package Test;

public class Test0807 {
	
	public static void main(String[] args) {
		
		StringBuilder sb=new StringBuilder("123");
		StringBuilder sb2=sb.append("4");
		
		System.out.println(sb==sb2);
		
		System.out.println(1/0.0);
	}
	
	
	
	public boolean A(String str) {
		return "".equals(str);
	}
	
	
	public boolean C() {
		
		boolean flag=false;
		
		boolean resA=hanndann();
		boolean resB=hanndann();
		boolean resC=hanndann();
		if (resA&&resA&&resC) {
			flag=true;
		}
		
		return flag;
	}
	
	
	public boolean hanndann() {
		
		
		
		
		
		return true;
	}
	
}
