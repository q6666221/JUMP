#### 基本概念

什么是树？

> 从一个节点出发可以有多个决策，每一个决策都将影响之后的决策
比如，出地铁站，从不同的出口出去都将到达不同的地点

- 子树

- 父节点

- 子节点

- 叶子节点

- 与图相比，没有环，可认为是没有环的图

#### 二叉树遍历

**递归树，深度优先**

```Java
// 前序，根左右
public void preorder(List<Integer> res, TreeNode root) {
    if (root == null) return;
    res.add(root.val);
    preorder(res, root.left);
    preorder(res, root.right);
}

// 中序，左根右
public void inorder(List<Integer> res, TreeNode root) {
    if (root == null) return;
    inorder(res, root.left);
    res.add(root.val);
    inorder(res, root.right);
}

// 后序，左右根
public void postorder(List<Integer> res, TreeNode root) {
    if (root == null) return;
    postorder(res, root.left);
    postorder(res, root.right);
    res.add(root.root);
}
```

**迭代树，辅助栈，深度优先**

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
        for (int i = 0; i < queue.size(); i++) { // 错误原因，queue.size(); size在变
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

自顶向下

```Java
// 当明确知道传入状态值时
public int DFS(TreeNode root, int deepth) {
    if (root == null) return deepth;
    return Math.max(DFS(root.left, deepth + 1), DFS(root.right, deepth + 1)); 
} 
```

迭代

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

自底向上

```Java
// 当明确知道子节点的结果时
public int maxDepth(TreeNode root) {
    if (root == null) return 0;
    return Math.max(maxDepth(root.left), maxDepth(root.right)) + 1;
}
```

## 对称二叉树

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
```

```Java
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

## 路径总和

```Java
// 自顶向下
public boolean hasPathSum(TreeNode root, int sum) {
    if (root == null) return false;
    if (root.left == null && root.right == null) 
        return sum == root.val;
    sum -= root.val;
    return hasPathSum(root.left, sum) || hasPathSum(root.right, sum);
}
```

```Java
// 自顶向下
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

### 二叉搜索树

- 别名：二叉排序树，有序二叉树，排序二叉树

- 左子树上所有节点的值均小于根结点的值

- 右子树上所有节点的值均大于它的根结点的值

- 以此类推：左、右子树也 分别为二叉搜索树（这就是重复性！）

