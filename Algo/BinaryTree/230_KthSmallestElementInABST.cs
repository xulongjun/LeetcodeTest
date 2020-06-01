namespace LeetCodeTest.Algo.BinaryTree
{
    public class Solution230
    {
        private int _item;

        public int KthSmallest(TreeNode root, int k)
        {
            if (root == null) return 0;

            var idx = 0;

            InOrder(root, k, ref idx);

            return _item;
        }

        private void InOrder(TreeNode root, int k, ref int idx)
        {
            if (root == null) return;

            InOrder(root.left, k, ref idx);

            idx++;

            if (k == idx)
            {
                _item = root.val;
                return;
            }

            InOrder(root.right, k, ref idx);
        }
    }
}

