/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        PreOrderdfs(root);
            return root;
                }

    void PreOrderdfs(TreeNode node){
        // exit case
        if(node == null)
            return;
        // Swap
        var temp = node.left;
        node.left = node.right;
        node.right = temp;
        // left
        PreOrderdfs(node.left);
        // right;
        PreOrderdfs(node.right);
                }
}