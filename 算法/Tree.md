#### 基本概念

什么是树？

> 常用于各种决策中
> 从一个节点出发可以有多个决策，每一个决策都将影响之后的决策
> 比如，出地铁站，从不同的出口出去都将到达不同的地点

- 子树

- 父节点

- 子节点

- 叶子节点

- 拥有==N个节点==和==N-1条边==的一个有向无环图

#### 二叉树遍历

**递归树，深度优先**

```Java
// 前序，根左右
public void preorder(TreeNode root ...) {
    if (root == null) return;
    // 对当前节点的处理
    preorder(root.left ...);
    preorder(root.right ...);
}

// 中序，左根右
public void inorder(TreeNode root ...) {
    if (root == null) return;
    inorder(root.left ...);
    // 对当前节点的处理
    inorder(root.right ...);
}

// 后序，左右根
public void postorder(TreeNode root ...) {
    if (root == null) return;
    postorder(root.left ...);
    postorder(root.right ...);
    // 对当前节点的处理
}
```

==**迭代树，辅助栈，深度优先**==

```Java
// 前序，根左右
public void preorder(List<Integer> res, TreeNode root) {
    Stack<TreeNode> stack = new Stack<>();
    while (root != null || !stack.isEmpty()) {
        while (root != null) {
            res.add(root.val);
            stack.push(root);
            root = root.left;
        }
        TreeNode cur = stack.pop();
        root = cur.right;
    }
}

// 中序，左根右
public void preorder(List<Integer> res, TreeNode root) { 
    Stack<TreeNode> stack = new Stack<>();
    while (root != null || !stack.isEmpty()) {
        while (root != null) {
            stack.push(root);
            root = root.left;
        }
        root = stack.pop();
        res.add(root.val);
        roor = root.right;
    }
} 

// 后序，左右根
public void preorder(List<Integer> res, TreeNode root) { 
    Stack<TreeNode> stack = new Stack<>();
    while (root != null || !stack.isEmpty()) {
        while (root != null) {
          res.add(root.val);
          stack.push(root);
          root = root.right;
        }
        TreeNode cur = stack.pop();
        root = cur.left;
    }
    Collections.reverse(res);
} 
```

**层序递归树，广度优先**

```Java
// 层序递归树
public void levelOrder(List<List<Integer>> res, TreeNode root, int level) {
    if (root == null) return;
    if (level >= res.size()) 
        res.add(new ArrayList<Integer>());
    res.get(level).add(root.val);
    levelOrder(res, root.left, level + 1);
    levelOrder(res, root.right, level + 1);
} 
```

**层序迭代树，广度优先**

```Java
// 错误示例
public List<List<Integer>> levelOrder(TreeNode root) {
    if (root == null) return new ArrayList<>();
    Queue<TreeNode> queue = new LinkedList<>();
    List<List<Integer>> res = new ArrayList<>();
    queue.add(root);
    while (!queue.isEmpty()) {
        List<Integer> temp = new ArrayList<>();
        for (int i = 0; i < queue.size(); i++) { // 错误原因,queue.size(); size在变
            TreeNode cur = queue.poll();
            temp.add(cur.val);
            if (cur.left != null) queue.add(cur.left);
            if (cur.right != null) queue.add(cur.right);
        }
        res.add(temp);
    }
    return res;
}

// 层序迭代树，正确示例
public List<List<Integer>> levelOrder(TreeNode root) {
    if (root == null) return new ArrayList<>();
    Queue<TreeNode> queue = new LinkedList<>();
    List<List<Integer>> res = new ArrayList<>();
    queue.add(root);
    while (!queue.isEmpty()) {
        int size = queue.size();
        List<Integer> temp = new ArrayList<>();
        for (int i = 0; i < size; i++) {
            TreeNode cur = queue.poll();
            temp.add(cur.val);
            if (cur.left != null) queue.add(cur.left);
            if (cur.right != null) queue.add(cur.right);
        }
        res.add(temp);
    }
    return res;
}
```

#### 二叉树最大深度

**自顶向下**

```Java
// 当明确知道传入状态值时
public int DFS(TreeNode root, int deepth) {
    if (root == null) return deepth;
    return Math.max(DFS(root.left, deepth + 1), DFS(root.right, deepth + 1)); 
} 
```

**自底向上**

```Java
// 当明确知道子节点的结果时
public int maxDepth(TreeNode root) {
    if (root == null) return 0;
    return Math.max(maxDepth(root.left), maxDepth(root.right)) + 1;
}
```

**迭代**

```Java
public int maxDepth(TreeNode root) {
    if (root == null) return 0;
    int res = 0;
    Queue<TreeNode> queue = new LinkedList<>();
    queue.add(root);
    while (!queue.isEmpty()) {
        int size = queue.size();
        for (int i = 0; i < size; i++) {
            TreeNode cur = queue.poll();
            if (cur.left != null) queue.add(cur.left);
            if (cur.right != null) queue.add(cur.right);
        }
        res++;
    }
    return res;
}
```

#### 对称二叉树

```Java
// 迭代
public boolean isSymmetric(TreeNode root) {
    if (root == null) return true;
    Queue<TreeNode> queue = new LinkedList<>();
    queue.add(root.left);
    queue.add(root.right);
    while (!queue.isEmpty()) {
        TreeNode left = queue.poll();
        TreeNode right = queue.poll();
        if (left == right) continue;
        if (left == null || right == null || left.val != right.val)
            return false;
        queue.add(left.left);
        queue.add(right.right);
        queue.add(left.right);
        queue.add(right.left);
    }
    return true;
}

// 递归
public boolean isSymmetric(TreeNode root) {
    if (root == null) return true;
    return BFS(root.left, root.right);
}
public boolean BFS(TreeNode left, TreeNode right) {
    if (left == right) return true;
    if (left == null || right == null || left.val != right.val) 
        return false;
    return BFS(left.left, right.right) && BFS(left.right, right.left);
}
```

#### 路径总和

```Java
// 递归,自顶向下
public boolean hasPathSum(TreeNode root, int sum) {
    if (root == null) return false;
    if (root.left == null && root.right == null) 
        return sum == root.val;
    sum -= root.val;
    return hasPathSum(root.left, sum) || hasPathSum(root.right, sum);
}

// 迭代,自顶向下
public boolean hasPathSum(TreeNode root, int sum) {
    if (root == null) return false;
    Stack<TreeNode> stack = new Stack<>();
    stack.push(root);
    while (!stack.isEmpty()) {
        TreeNode cur = stack.pop();
        if (cur .left == null && cur .right == null && sum == cur.val) {
            return true;
        }
        if (cur.left != null) {
            cur.left.val += cur.val;
            stack.push(cur.left);
        }
        if (cur.right != null) {
            cur.right.val += cur.val;
            stack.push(cur.right);
        }
    }
    return false;
} 
```

#### 从中序与后序遍历序列构造二叉树

```java
// 递归法
Map<Integer,Integer> map = new HashMap<>();
int[] post;
public TreeNode buildTree(int[] inorder, int[] postorder) {
    if (inorder.length == 0) return null;
    int ilen = inorder.length;
    int plen = postorder.length;
    post = postorder;
    for (int i = 0; i < ilen; i++) map.put(inorder[i],i);
    return toBuildTree(0, ilen - 1, 0, plen - 1);
}

public TreeNode toBuildTree(int is, int ie, int ps, int pe) {
    if (is > ie) return null;
    int val = post[pe];
    int i = map.get(val);
    TreeNode root = new TreeNode(val);
    root.right = toBuildTree(i + 1, ie, ps + i - is, pe - 1);
    root.left = toBuildTree(is, i - 1, ps, ps + i - is - 1);
    return root;
}
```

#### 从前序与中序遍历序列构造二叉树

```java
Map<Integer, Integer> map = new HashMap<>();
int[] pre;
public TreeNode buildTree(int[] preorder, int[] inorder) {
    if (preorder.length == 0) return null;
    pre = preorder;
    int plen = preorder.length;
    int ilen = inorder.length;
    for (int i = 0; i < ilen; i++) {
        map.put(inorder[i], i);
    }
    return toBuildTree(0, plen - 1, 0, ilen - 1);
}

public TreeNode toBuildTree(int ps, int pe, int is, int ie) {
    if (is > ie || ps > pe) return null;
    int val = pre[ps];
    int i = map.get(val);
    TreeNode root = new TreeNode(val);
    root.left = toBuildTree(ps + 1, ps + i - is, is, i - 1);
    root.right = toBuildTree(ps + i - is + 1, pe, i + 1, ie);
    return root;
}
```

#### 填充每个节点的下一个右侧节点指针

```java
public Node connect(Node root) {
    if (root == null) return null;
    Queue<Node> queue = new LinkedList<>();
    queue.add(root);
    while (!queue.isEmpty()) {
        int len = queue.size();
        List<Node> list = new ArrayList<>();
        while (!queue.isEmpty()) {
            list.add(queue.poll());
        }
        for (int i = 0; i < len; i++) {
            Node temp = list.get(i);
            if (i + 1 < len) 
                temp.next = list.get(i + 1);
            if (temp.left != null)
                queue.add(temp.left);
            if (temp.right != null)
                queue.add(temp.right);
        }
    }
    return root;
}
```

#### 填充每个节点的下一个右侧节点指针 II

```java
public Node connect(Node root) {
    if (root == null) return null;
    Queue<Node> queue = new LinkedList<>();
    queue.add(root);
    while (!queue.isEmpty()) {
        int size = queue.size();
        for (int i = 0; i < size; i++) {
            Node cur = queue.poll();
            if (i < size - 1)
                cur.next = queue.peek();
            if (cur.left != null) 
                queue.add(cur.left);
            if (cur.right != null)
                queue.add(cur.right);
        }
    }
    return root;
}
```

#### 二叉树的最近公共祖先

```java
public TreeNode lowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
    if (root == null || root == p || root == q) 
        return root;
    TreeNode left = lowestCommonAncestor(root.left, p, q);
    TreeNode right = lowestCommonAncestor(root.right, p, q);
    if (left == null) return right;
    if (right == null) return left;
    return root;
}
```

#### 二叉树的序列化与反序列化

```java
// Encodes a tree to a single string.
public String serialize(TreeNode root) {
    if (root == null) return null;
    String cur = String.valueOf(root.val);
    cur += "," + serialize(root.left);
    cur += "," + serialize(root.right);
    return cur;
}

// Decodes your encoded data to tree.
public TreeNode deserialize(String data) {
    if (data == null) return null;
    String[] datas = data.split(",");
    return DFS(datas);
}

int i = 0;

public TreeNode DFS(String[] datas) {
    if (datas[i++].equals("null")) return null;
    TreeNode cur = new TreeNode(Integer.valueOf(datas[i - 1]));
    cur.left = DFS(datas);
    cur.right = DFS(datas);
    return cur;
}
```



#### 二叉搜索树

- 别名：二叉排序树，有序二叉树，排序二叉树

- 左子树上所有节点的值均小于根结点的值

- 右子树上所有节点的值均大于它的根结点的值

- 以此类推：左、右子树也 分别为二叉搜索树（这就是重复性！）

