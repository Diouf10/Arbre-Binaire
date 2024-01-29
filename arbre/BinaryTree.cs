namespace arbre;

public class BinaryTree
{
    private TreeNode root;

    public BinaryTree()
    {
        root = null;
    }

    public TreeNode ConstructTree(string postfix)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        for (int i = 0; i < postfix.Length; i++)
        {
            TreeNode node = new TreeNode(postfix[i]);

            if (IsOperator(postfix[i]))
            {
                node.Right = stack.Pop();
                node.Left = stack.Pop();
            }

            stack.Push(node);
        }

        root = stack.Pop();
        return root;
    }

    private bool IsOperator(char c)
    {
        return (c == '+' || c == '-' || c == '*' || c == '/');
    }

    public int Evaluate(TreeNode root)
    {
        if (root == null)
            return 0;

        if (root.Left == null && root.Right == null)
            return int.Parse(root.Value.ToString());

        int leftValue = Evaluate(root.Left);
        int rightValue = Evaluate(root.Right);

        switch (root.Value)
        {
            case '+':
                return leftValue + rightValue;
            case '-':
                return leftValue - rightValue;
            case '*':
                return leftValue * rightValue;
            case '/':
                if (rightValue != 0)
                    return leftValue / rightValue;
                else
                    throw new DivideByZeroException("Division by zero encountered!");
            default:
                return 0;
        }
    }
}