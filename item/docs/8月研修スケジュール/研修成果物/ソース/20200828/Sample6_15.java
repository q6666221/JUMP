
interface A{}


class B{
	
	void m() {
		System.out.println("B");
	}
}

class C extends B {
	
	private String msg;
	
	C(String msg){
		msg=msg;
	}
	
	public C() {
		// TODO 自動生成されたコンストラクター・スタブ
	}

	@Override
	void m() {
		System.out.println("C");
	}
}

class D {}

interface E{}

class F extends D implements E {}


public class Sample6_15 {
	public static void main(String[] args) {
		
//		int i=0;
//		System.out.println(i instanceof Object); //　　　　オートボクシングできない
		
		Object obj=new Object();
		Double du=new Double(1);
		String str=new String();
		System.out.println(str);
		System.out.println(obj instanceof A);
		
		C c = new C();
		F f = new F();
		B b = new B();
		System.out.println(c instanceof A);//false
		System.out.println(c instanceof B);//true
		System.out.println(b instanceof C);//false
		System.out.println(c instanceof C);//true
		//System.out.println(obj instanceof D);//コンパイルエラー
		
		System.out.println(f instanceof E);//true
		System.out.println(f instanceof A);//false
		
		B b1=new C();
		b1.m(); 
		
		
		String str1="";

		
		
	}
}
