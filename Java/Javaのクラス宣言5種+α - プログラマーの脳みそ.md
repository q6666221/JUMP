[Java](http://d.hatena.ne.jp/keyword/Java)のクラス宣言には5種類ある。  
トッ[プレベ](http://d.hatena.ne.jp/keyword/%A5%D7%A5%EC%A5%D9)ルクラス・ネストしたクラス・内部クラス・ローカル内部クラス・匿名クラス(無名クラスとも言われる)の5種類だ。  
今回はこの5種類のクラス宣言のおさらい。

#### トッ[プレベ](http://d.hatena.ne.jp/keyword/%A5%D7%A5%EC%A5%D9)ルクラス

これは普段使っているクラス。拡張子が.[java](http://d.hatena.ne.jp/keyword/java)のファイルを作り、そのファイル名とクラス名を合致させなくてはいけない。その[java](http://d.hatena.ne.jp/keyword/java)ファイルのトッ[プレベ](http://d.hatena.ne.jp/keyword/%A5%D7%A5%EC%A5%D9)ルに位置する。

#### ネストしたクラス

「ネストしたクラス」(Nested class)とはクラスの中にクラスがネストしている状態。トッ[プレベ](http://d.hatena.ne.jp/keyword/%A5%D7%A5%EC%A5%D9)ルクラスの内側にstaticキーワードをつけてクラス宣言を行う。

```
public class Outer {
	public static class Nested {
		
	}
}

```

このネストしたクラスは、トッ[プレベ](http://d.hatena.ne.jp/keyword/%A5%D7%A5%EC%A5%D9)ルクラスと同等の機能性を持つ。  
クラス名はOuter.Nestedという名前で扱われるが、import文の記載によってNestedという単体の識別子でも利用できる。

#### 内部クラス

内部クラス(Inner class)は外部クラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)に紐付く。外部クラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)1つに対して複数の内部クラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)が生成できる。そして、内部クラスからは外部クラスのフィールドなどを参照することができる。

トッ[プレベ](http://d.hatena.ne.jp/keyword/%A5%D7%A5%EC%A5%D9)ルクラスの内側にクラス宣言を行う。staticキーワードはつけない。

```
public class Outer {
	public class Inner {
		
	}
}

```

この内部クラス、喩えるならば、classと[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)の関係に近い。  
外部クラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)と内部クラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)の関係はclassと[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)の関係のようで、  
classに属するstaticフィールドはすべての[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)から参照できるように  
外部クラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)フィールドは紐付く内部クラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)から参照することができる。[\*1](#f-fc7d9430 "このクラス-インスタンス関係の類似性を高階インスタンスと捉えて応用したのが[http://d.hatena.ne.jp/Nagise/20110124/1295874192:title]")

そもそも紐付けとは何か。

内部クラスをnewする際、外部クラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)を用意して

```
Outer o = new Outer();
Inner i = o.new Inner();

```

というように記述する。  
このとき、コードがOuterクラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)メソッド内であればOuterの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)としてthisを利用できる。

```
public class Outer {
	public class Inner {}

	public void hoge() {
		Inner i = this.new Inner();
	}
}

```

そして、thisは省略可能なので以下のようなコードで書かれることが多い。

```
public class Outer {
	public class Inner {}

	public void hoge() {
		Inner i = new Inner();
	}
}

```

ところで、staticメソッドの場合、thisは利用できない。  
そのため、staticメソッド内で内部クラスを[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)化しようとした場合は先のように外部クラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)を作ってからnewすることになる。

```
public class Outer {
	public class Inner {}

	public static void main(String\[\] args) {
		Outer o = new Outer();
		Inner i = o.new Inner();
	}
}

```

まだ、InnerクラスはOuterクラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)1つにつき複数作ることができる。

```
Outer o = new Outer();
Inner i1 = o.new Inner();
Inner i2 = o.new Inner();
Inner i3 = o.new Inner();

```

これらi1-i3の[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)は、oの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)フィールドにアクセスできる。

```
Outer o2 = new Outer();
Inner ix = o2.new Inner();

```

というように別のOuterの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)を用意してInnerをnewした場合、このixの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)からはo2の[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)フィールドを参照する。  
なのでixからOuterのフィールドをいじった所でo2には影響を与えるがoには影響を与えない。

Inner型から見てOuter型のことをエンクロージング型(Enclosing type)と呼ぶ。  
Innerクラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)から見てOuterクラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)をエンクロージング[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)(Enclosing instance)と呼ぶ。あるいはエンクロージングオブジェクトという表現がされることもある。

#### エンクロージング[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)の操作

InnerクラスからはOuterの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)フィールドを参照することができる。また、[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)メソッドを呼び出すこともできる。  
このとき、記法としては以下のようになる。

```
public class Outer {
	public String str;
	public void hoge() {}

	public class Inner {
		void piyo() {
			
			System.out.println(Outer.this.str);
			
			Outer.this.hoge();
		}
	}
}

```

Innerクラスのメソッド内でthis.[hoge](http://d.hatena.ne.jp/keyword/hoge)()と書いた場合、このthisはInnerクラス自身の[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)を指す。  
Outerクラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)、つまりエンクロージング[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)を参照したい場合、そのOuterクラスのクラス名.thisという表記になる。  
InnerクラスとOuterクラスでメソッド名やフィールド名が衝突しない場合、このOuter.thisは省略可能なので先の例は単に

```
public class Outer {
	public void hoge() {}

	public class Inner {
		void piyo() {
			
			System.out.println(str);
			
			hoge();
		}
	}
}

```

というように書かれることが多い。  
メソッド名やフィールド名が衝突した場合、Outer.thisを明記することで外部クラスのものを参照可能だ。  
Outer.thisが省略されている場合、メソッド名・フィールド名はInner側のものが優先となる。

もし、多段の内部クラスを作った場合、直接のエンクロージング[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)の他にもエンクロージング[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)のエンクロージング[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)といった存在が生まれる。  
これらにアクセスする場合、やはりクラス名.thisで参照できる。

```
public class Outer {
	class Inner {
	 class Inner2 {
			void hoge() {
				System.out.println(Outer.this);
				System.out.println(Inner.this);
			}
		}
	}
}

```

#### ローカル内部クラス

ローカル内部クラス(Local inner class)はメソッドやコンスト[ラク](http://d.hatena.ne.jp/keyword/%A5%E9%A5%AF)タなどのブロック内で宣言されるクラス。  
これらのクラスはそのブロック内のみがスコープとなるので、ブロックの外側からはクラスの識別子を利用できない。

```
public class Outer {
	public static void main(String\[\] args) {
	 class LocalClass {}

		LocalClass l = new LocalClass(); 
	}

	LocalClass field; 
	static void hoge() {
		LocalClass l = new LocalClass(); 
	}
}

```

IF文などのブロック内で宣言した場合、フロックの外側では利用できない。

```
if (true) {
	class LocalClass {}
}
LocalClass l = new LocalClass(); 

```

ローカル内部クラスは2種類あり、staticメソッド内で宣言されたものと、[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)メソッド内で宣言されたものだ。[\*2](#f-18596d6f "本当はこの他にもコンストラクタや初期化ブロックでも宣言できる")  
[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)メソッド内で宣言された場合、内部クラス同様にOuterクラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)へアクセス可能でOuter.thisを利用できる。  
staticメソッド内で宣言されたものはこれができない。

#### 匿名クラス

匿名クラス(Anonymous class)は主に抽象クラスやinterfaceなどに対して名前を付けずにその場で実装を書くもの。

```
Runnable r = new Runnable() {
	@Override
	public void run() {
	}
};

```

例はRunnableインターフェースを実装する匿名クラスをnewしたところ。  
最後の[セミ](http://d.hatena.ne.jp/keyword/%A5%BB%A5%DF)コロンに注意。これはr = の部分に対しての[セミ](http://d.hatena.ne.jp/keyword/%A5%BB%A5%DF)コロンとなる。  
new Runnable()の後ろの{}までが匿名クラスの宣言なのだが、これは[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)を扱うどこにでも記述可能で  
通常の代入式の右辺の部分がnew Runnable(){...}に差し替わったと理解するといい。  
[ソースコード](http://d.hatena.ne.jp/keyword/%A5%BD%A1%BC%A5%B9%A5%B3%A1%BC%A5%C9)の見た目はいびつになるが、[構文解析](http://d.hatena.ne.jp/keyword/%B9%BD%CA%B8%B2%F2%C0%CF)としてはその部分をまるまるくくりだして落ち着いて考えれば大丈夫。

匿名クラスは抽象クラスやinterfaceに対して利用されることが多いが、具象型に対しても使うことはできる。

```
List<String> list = new ArrayList<String>(){{add("hoge")}};

```

これは自動テストなどでListなどの初期化が面倒くさい時とかに使われていることがある。  
構文的には、匿名クラスをつくり[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)初期化ブロックの中でaddメソッドを呼んでいるわけだ。  
[デバッグ](http://d.hatena.ne.jp/keyword/%A5%C7%A5%D0%A5%C3%A5%B0)用にtoString()だけオーバライドしたりなどいろいろやれるが、わりと邪道なテクニックなので多用するべきではないだろう。

この匿名クラスも2種類あり、ローカル内部クラス同様に[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)メソッド内で宣言されたものはOuter.thisにアクセス可能となる。  
匿名クラスはnewするその瞬間に実装を書くので、[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)を2つ以上つくりたいような場合はローカル内部クラスにするか内部クラスにするかしよう。

#### 外部メソッドのfinal変数の参照

ローカル内部クラスと匿名クラスでは宣言された箇所で参照可能なfinalなローカル変数をクラス内部で参照することができる。

```
public static void main(String\[\] args) {
	final int i = 0;
	class LocalClass {
		void hoge() {
			System.out.println(i);
		}
	}
}

```

これは匿名クラスなどで実装を書く時などによく利用される。見た目に外のメソッドにある変数が使えるように見えるわけだが、実際にはこのローカル内部クラスや匿名クラスの[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)はどこかに運ばれてそこで初めてメソッドが呼び出されたりするかもしれない。そのとき、外のメソッドにある変数が参照できるとはどういうことなのか？

端的に言えば、これらの情報はクラス生成時点でこっそり渡されているというカ[ラク](http://d.hatena.ne.jp/keyword/%A5%E9%A5%AF)リになっている。詳しく知りたければclassファイルの中を覗いてみるなり逆[コンパイル](http://d.hatena.ne.jp/keyword/%A5%B3%A5%F3%A5%D1%A5%A4%A5%EB)してみるなどするといい。

#### interfaceと列挙

interfaceと[enum](http://d.hatena.ne.jp/keyword/enum)もネストすることができる。  
ネストしたクラスと同様でトッ[プレベ](http://d.hatena.ne.jp/keyword/%A5%D7%A5%EC%A5%D9)ルのクラスの下にだけネスト可能。  
interfaceと[enum](http://d.hatena.ne.jp/keyword/enum)はstaticをつけて宣言しても、つけずに宣言しても、static扱いとなる。

#### トッ[プレベ](http://d.hatena.ne.jp/keyword/%A5%D7%A5%EC%A5%D9)ルクラスに併記

名称があるのかよく分からないのだけど、トッ[プレベ](http://d.hatena.ne.jp/keyword/%A5%D7%A5%EC%A5%D9)ルクラスと同じ[java](http://d.hatena.ne.jp/keyword/java)ファイル内にパッケージプライベートなクラスを併記することができる。  
例えば[Hoge](http://d.hatena.ne.jp/keyword/Hoge).[java](http://d.hatena.ne.jp/keyword/java)ファイルの中に

```
public class Hoge{
}
class Piyo {
}

```

と書くと[コンパイル](http://d.hatena.ne.jp/keyword/%A5%B3%A5%F3%A5%D1%A5%A4%A5%EB)することができる。

#### まとめ

5種類のクラス宣言についておさらいした。とくに内部クラスからエンクロージング[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)を参照するあたりは実際にコードを書いていじらないとしっくりこないかもしれない。

内部クラスの利用例としては[Iterator](http://d.hatena.ne.jp/keyword/Iterator)などが挙げられる。Listから取得される[Iterator](http://d.hatena.ne.jp/keyword/Iterator)はListとは別の型で別の[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)なわけだが、元となるList内のデータを参照することになる。[JDK](http://d.hatena.ne.jp/keyword/JDK)付属のソースを読むとわかるが、この[Iterator](http://d.hatena.ne.jp/keyword/Iterator)はList(の実装クラスの共通部にあたるAbstractList)の内部クラスとして作らている。

[Android](http://d.hatena.ne.jp/keyword/Android)のUI開発などをすると設計上、こうした[インスタンス](http://d.hatena.ne.jp/keyword/%A5%A4%A5%F3%A5%B9%A5%BF%A5%F3%A5%B9)間の紐付けを多用することになるので油断ならない。しっかり基礎を固めておこう。

#### 追記

Anonymous class に対しては訳語として「匿名クラス」と「無名クラス」がある。Anonymousに対する訳語としては一般に「匿名」とされるので「匿名クラス」が自然に思われる。

Sun([Java](http://d.hatena.ne.jp/keyword/Java)を開発した会社。現在は[Oracle](http://d.hatena.ne.jp/keyword/Oracle)に吸収されている)の公式本では

*   [プログラミング言語Java](http://www.amazon.co.jp/dp/4894717166) 柴田芳樹 訳 - 無名クラス
*   [Effective Java](http://www.amazon.co.jp/dp/4621066056) 柴田芳樹 訳 - 無名クラス
*   [Java言語仕様](http://www.amazon.co.jp/dp/4894717158) 村上雅章 訳 - 匿名クラス
*   [Java仮想マシン仕様](http://www.amazon.co.jp/dp/489471356X) 村上雅章 訳 - 匿名クラス

となっている。個人的には音節の関係か「無名クラス」の方が言いやすいのでつい言ってしまう。あまり目くじらを立てないでいただきたい :-P