// See https://aka.ms/new-console-template for more information

using arbre;

class Program
{
    static void Main(string[] args)
    {
        string infixExpression = "523+*";
        string postfixExpression = ConvertInfixToPostfix(infixExpression);
        Console.WriteLine($"Expression infixée : {infixExpression}");
        Console.WriteLine($"Expression postfixée : {postfixExpression}");
        
        BinaryTree binaryTree = new BinaryTree();
        TreeNode root = binaryTree.ConstructTree(postfixExpression);
        
        Console.WriteLine($"Résultat de l'expression : {binaryTree.Evaluate(root)}");
    }

    static string ConvertInfixToPostfix(string infixExpression)
    {
        
        return "523+*"; // Expression postfixée résultante pour "5+2"
    }
}