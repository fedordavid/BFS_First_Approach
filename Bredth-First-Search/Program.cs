public class Program
{
    private static void Main()
    {
        var graph = new Graph(7);

        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 0);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 1);

        var result = graph.BreadthFirstSearch(3);
        Console.WriteLine("result:" + result);
    }
}
