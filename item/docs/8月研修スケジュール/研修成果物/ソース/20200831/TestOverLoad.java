package Test;

import Test1.Test0728;

class Super{
	String val="sup";
	
	public Super() {
		System.out.println("super");
	}
	
	void print() {
		System.out.println(val);
	}
	
//	static int i=3;
//	static void pr() {
//		System.out.println("super");
//	}
}

class Sub extends Super{
	String val="sub";
	
	public Sub() {
		System.out.println("sub");
	}
	
	int i;
}

public class TestOverLoad  {
	public static void main(String[] args) {
		Super sup=new Super();
		Sub sub=new Sub();
		Super super1=new Sub();
//		System.out.println(sup.val);
//		//System.out.println(sub.i);
//		System.out.println(sub.val);
//		sub.print();
//		sub.print();
		
		Object obj=(Object)new String();
		String str=(String)obj;
		
		
	}
}
