namespace LeetCodeTest.Algo.BinaryTree
{
    public class Solution1008
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            var node = BuildTreePreorder(preorder, 0, preorder.Length - 1);
            return node;
        }

        public TreeNode BstFromPreorderMethod1(int[] preorder)
        {
            var root = new TreeNode(preorder[0]);

            for (int i = 1; i < preorder.Length; i++)
            {
                InsertBTS(root, preorder[i]);
            }

            return root;
        }

        private TreeNode BuildTreePreorder(int[] preorder, int start, int end)
        {
            if (start >= preorder.Length || start > end)
            {
                return null;
            }

            var rootValue = preorder[start];

            var root = new TreeNode(rootValue);

            var lastOne = start;
            for (int i = start; i <= end; i++)
            {
                var current = preorder[i];
                if (current > rootValue) break;
                lastOne = i;
            }

            // Hack a solution in less than five minutes
            // if lastOne < start + 1, then there is no left child. 
            // There are more than one choices, find lastOne in the left child, or find the first one in right child
            // Left child may be missing, lastOne is set to start as default value. Fall through the first three lines of code to return null
            root.left = BuildTreePreorder(preorder, start + 1, lastOne);
            root.right = BuildTreePreorder(preorder, lastOne + 1, end);

            return root;
        }

        private void InsertBTS(TreeNode node, int val)
        {
            TreeNode current = node;
            TreeNode parent = null;
            while (current != null)
            {
                parent = current;
                current = current.val > val ? current.left : current.right;
            }

            if (parent.val > val)
                parent.left = new TreeNode(val);
            else
                parent.right = new TreeNode(val);
        }
    }
}