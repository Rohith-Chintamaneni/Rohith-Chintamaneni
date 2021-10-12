using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Trees;

namespace DataStructures.BinarySearch
{
  
    public class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            CustomInOrderTraversal(root, result);
            return result;
          
        }

        public void CustomInOrderTraversal(TreeNode root, IList<int> result)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    CustomInOrderTraversal(root.left, result);
                }

                result.Add(root.val);
                if (root.right != null)
                {
                    CustomInOrderTraversal(root.right, result);
                }

            }
        }
    }
}
