using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace DataStructures.Trees
{
    class SumFromNodes
    {
        public int CalculateSum(TreeNode root)
        {
            if (root == null) return 0;
            return root.val + CalculateSum(root.left) + CalculateSum(root.right);
        }

      
    }
}
