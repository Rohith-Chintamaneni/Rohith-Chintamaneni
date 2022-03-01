using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    class SubtreeofAnotherTree572
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null) return false;

            if (IsSame(root, subRoot)) return true;

            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);

        }

        protected bool IsSame(TreeNode t, TreeNode s)
        {
            if (t == null && s == null) return true;
            if (t == null || s == null) return false;
            if (t.val != s.val) return false;

            return IsSame(t.left, s.left) && IsSame(t.right, s.right);
        }
    }
}
