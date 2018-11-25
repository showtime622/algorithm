using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{
    public class Merge2BinaryTrees
    {
        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if(t1 == null && t2 == null)
            {
                return null;
            }

            if(t1 != null && t2 == null)
            {
                return t1;
            }

            if(t1 == null && t2 != null)
            {
                return t2;
            }
            t1.val = t1.val + t2.val;

            TreeNode newT = t1;
            BuildTree(t1, t2);
            return newT;
        }

        private static void BuildTree(TreeNode t1, TreeNode t2)
        {
            if(t1.left != null)
            {
                if(t2.left != null)
                {
                    t1.left.val = t1.left.val + t2.left.val;
                    BuildTree(t1.left, t2.left);
                }
            }
            else
            {
                if (t2.left != null)
                {
                    t1.left = new TreeNode(t2.left.val);
                    BuildTree(t1.left, t2.left);
                }
            }

            if(t1.right != null)
            {
                if (t2.right != null)
                {
                    t1.right.val = t1.right.val + t2.right.val;
                    BuildTree(t1.right, t2.right);
                }
            }
            else
            {
                if (t2.right != null)
                {
                    t1.right = new TreeNode(t2.right.val);
                    BuildTree(t1.right, t2.right);
                }
            }

        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            this.val = x;
        }
    }
}
