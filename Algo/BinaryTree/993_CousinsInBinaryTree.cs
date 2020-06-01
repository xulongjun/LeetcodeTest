using System;
using System.Collections.Generic;

namespace LeetCodeTest.Algo.BinaryTree
{
    public class Solution993
    {
        public bool IsCousinsDFS(TreeNode root, int x, int y)
        {
            var arr = new ValueTuple<int, int>[2];
            int depth = 0;

            IsCousinsDFSub(root, x, y, arr, depth);

            return arr[0].Item1 != arr[1].Item1 && arr[0].Item2 == arr[1].Item2;
        }

        public bool IsCousinsBFS(TreeNode root, int x, int y)
        {
            var matched = new List<TreeNode[]>();
            var queue = new Queue<TreeNode[]>();

            queue.Enqueue(new TreeNode[] { null, root });
            while (queue.Count > 0)
            {
                var count = queue.Count;
                for (var i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    var child = node[1];

                    if (child == null) continue;

                    if (child.val == x || child.val == y)
                    {
                        matched.Add(node);
                    }
                    else
                    {
                        queue.Enqueue(new TreeNode[] { child, child.left });
                        queue.Enqueue(new TreeNode[] { child, child.right });
                    }
                }

                if (matched.Count > 0)
                {
                    if (matched.Count == 2 && matched[0][0] != matched[1][0]) return true;
                    else return false;
                }
            }

            return false;
        }

        public void IsCousinsDFSub(TreeNode node, int x, int y, ValueTuple<int, int>[] arr, int depth)
        {
            if (node.left != null)
            {
                if (node.left.val == x)
                    arr[0] = (node.val, depth + 1);
                else if (node.left.val == y)
                    arr[1] = (node.val, depth + 1);
                IsCousinsDFSub(node.left, x, y, arr, depth + 1);
            }
            if (node.right != null)
            {
                if (node.right.val == x)
                    arr[0] = (node.val, depth + 1);
                else if (node.right.val == y)
                    arr[1] = (node.val, depth + 1);
                IsCousinsDFSub(node.right, x, y, arr, depth + 1);
            }
        }
    }
}

