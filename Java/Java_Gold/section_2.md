## 継承とオーバーライト

### has-a,is-a関係

```java
// has-a
public class X {}
public class Y {
	private X x; // YはXを持っている
}

// is-a
public class Z extends X {}
```

### オーバーライトと隠蔽

**非staticのメソッド**はサブクラスに再定義することは、オーバーライトと呼びます

s**taticメソッド**及び**メンバ変数**をサブクラスで再定義することは、隠蔽と呼びます

### 可変長引数

**可変長引数の注意点**

- 可変長引数と普段な引数を併用できる
  可変長引数は最後に置くしかない

  ```java
  void method(String str, int... i) {} // OK
  void method(int... i, String str) {} // NG
  ```

- 可変長は一つしか使用できない

  ```java
  void method(String... s, int... i) {} // NG
  ```

- 引数リストを明確に定義したメソッドと、可変長引数を使用したメソッドが定義されている場合、明確に定義したものが優先して呼び出される

  ```java
  void method(int... i) {}
  void method(int a, int b) {} // こいつは優先して呼び出される
  ```

- データ型はおなじで、引数は配列のメソッドであり、可変長メソッドと併存できない

  ```java
  // コンパイルエラーが出てくる
  void method(int[] i) {}
  void method(int... i) {}
  ```

### オーバーロード

オーバーロードされたメソッドを呼び出す優先順位：

​	完全一致 ＞ 暗黙の型変換 ＞ Autoboxing ＞ 可変長引数

## 抽象クラスとインタフェース

### 抽象クラス

​	概念：

​	特徴：

### インタフェース

​	概念：インタフェースは公開必要な操作をまとめたクラスの仕様、つまり取り決めです。

​	特徴：

​	定数：変数を宣言すると、暗黙的に「public  static  final」修飾子が付与されるため、static定数となります。したがって、宣言時には初期化しておく必要があります。

​	抽象メソッド：

**継承の規則**：

![image-20201224191659806](C:\Users\zzq\AppData\Roaming\Typora\typora-user-images\image-20201224191659806.png)

## 型変換

### 基本データ型の変換ルール

#### 暗黙の型変換

​	左側に記載されている型の値は右側の型で扱える

#### キャストによる型変換

　右側に記載されている型の値を左側の型で扱うにはキャストを用いる

![image-20201227142052603](C:\Users\zzq\AppData\Roaming\Typora\typora-user-images\image-20201227142052603.png)

#### 基本データ型の変換注意

1. データ型で扱える範囲

   ```java
   byte b1 = 10; // OK
   byte b2 = 150; // NG, byteの範囲は-128 ~ 127
   ```

2. 算術演算子を使用している場合

   ```java
   short s1 = 10;
   s1 = ++s1; // OK
   s1 += 1; // OK
   s1 = s1 + 1; // NG
   ```

   算術演算子を使用する補充

   1. あるオペラントがdoubleの場合は、演算前に他のオペラントはdoubleに変換される
   2. あるオペラントがfloatの場合は、演算前に他のオペラントはfloatに変換される
   3. あるオペラントがlongの場合は、演算前に他のオペラントはlongに変換される
   4. double、float、longのいずれでもない場合、演算前にオペラントはintに変換される

### 参照型の変換ルール

#### 暗黙の型変換

　サブクラスのオブジェクトをスーパークラスで宣言した変数で扱える
　実装クラスのオブジェクトをインタフェースで宣言した変数で扱える

#### キャストによる型変換

　略

![image-20201227150245321](C:\Users\zzq\AppData\Roaming\Typora\typora-user-images\image-20201227150245321.png)

#### 参照型の変換注意

　略

## ネストクラス

![image-20201227152648109](C:\Users\zzq\AppData\Roaming\Typora\typora-user-images\image-20201227152648109.png)

### 匿名クラス

![image-20201227171010617](C:\Users\zzq\AppData\Roaming\Typora\typora-user-images\image-20201227171010617.png)

## 関数型インタフェース