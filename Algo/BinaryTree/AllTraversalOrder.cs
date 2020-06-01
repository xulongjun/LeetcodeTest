using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTest.Algo.BinaryTree
{
    public class AllTraversalOrder
    {
        private readonly List<int> result = new List<int>();

        //144. Binary Tree Preorder Traversal
        public IList<int> PreorderTraversalDfs(TreeNode root)
        {
            if (root == null) return result;

            result.Add(root.val);
            if (root.left != null)
            {
                PreorderTraversalDfs(root.left);
            }

            if (root.right != null)
            {
                PreorderTraversalDfs(root.right);
            }

            return result;
        }

        public IList<int> PreorderTraversalBfs(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            List<int> list = new List<int>();
            stack.Push(root);
            while (stack.Count() > 0)
            {
                TreeNode current = stack.Pop();
                if (current != null)
                {
                    list.Add(current.val);
                    stack.Push(current.right);
                    stack.Push(current.left);
                }
            }
            return list;
        }

        //94. Binary Tree Inorder Traversal
        public IList<int> InorderTraversalDfs(TreeNode root)
        {
            if (root == null) return result;

            if (root.left != null)
            {
                InorderTraversalDfs(root.left);
            }
            result.Add(root.val);

            if (root.right != null)
            {
                InorderTraversalDfs(root.right);
            }

            return result;
        }

        public IList<int> InorderTraversalBfs(TreeNode root)
        {
            var result = new List<int>();

            if (root == null) return result;

            var stack = new Stack<TreeNode>();
            var cur = root;

            while (cur != null)
            {
                stack.Push(cur);
                cur = cur.left;
            }

            while (stack.Count() > 0)
            {
                cur = stack.Pop();
                result.Add(cur.val);

                if (cur.right != null)
                {
                    cur = cur.right;

                    while (cur != null)
                    {
                        stack.Push(cur);
                        cur = cur.left;
                    }
                }
            }

            return result;
        }

        //145. Binary Tree Postorder Traversal
        public IList<int> PostorderTraversalDfs(TreeNode root)
        {
            if (root == null) return result;

            if (root.left != null)
            {
                InorderTraversalDfs(root.left);
            }

            if (root.right != null)
            {
                InorderTraversalDfs(root.right);
            }

            result.Add(root.val);

            return result;
        }

        public IList<int> PostorderTraversalBfs(TreeNode root)
        {
            var result = new List<int>();

            if (root == null) return result;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Any())
            {
                var cur = stack.Pop();
                result.Add(cur.val);

                if (cur.left != null)
                {
                    stack.Push(cur.left);
                }

                if (cur.right != null)
                {
                    stack.Push(cur.right);
                }
            }

            result.Reverse();

            return result;
        }

        //102. Binary Tree Level Order Traversal
        public IList<IList<int>> LevelOrderDfs(TreeNode root)
        {
            List<IList<int>> ans = new List<IList<int>>();
            if (root == null)
            {
                return ans;
            }
            LevelOrderDfsHelper(root, 0, ans);
            return ans;
        }

        private void LevelOrderDfsHelper(TreeNode cur, int curDepth, List<IList<int>> allLevels)
        {
            if (cur == null)
            {
                return;
            }
            if (curDepth < allLevels.Count && allLevels[curDepth] != null)
            {
                allLevels[curDepth].Add(cur.val);
            }
            else
            {
                List<int> curLevel = new List<int>();
                curLevel.Add(cur.val);
                allLevels.Add(curLevel);
            }
            LevelOrderDfsHelper(cur.left, curDepth + 1, allLevels);
            LevelOrderDfsHelper(cur.right, curDepth + 1, allLevels);
        }

        public IList<IList<int>> LevelOrderBfs(TreeNode root)
        {
            IList<IList<int>> order = new List<IList<int>>();
            if (root == null)
                return order;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                IList<int> values = new List<int>();
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode current = queue.Dequeue();
                    values.Add(current.val);
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                }

                order.Add(values);
            }

            return order;
        }
    }
}
