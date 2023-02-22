public class Program
{
    private static void Main()
    {
        var graph = new OldGraph(11);
        
        // graph.AddEdge(0, 1);
        // graph.AddEdge(0, 2);
        // graph.AddEdge(1, 0);
        // graph.AddEdge(1, 2);
        // graph.AddEdge(1, 4);
        // graph.AddEdge(2, 0);
        // graph.AddEdge(2, 1);
        // graph.AddEdge(2, 3);
        // graph.AddEdge(3, 2);
        // graph.AddEdge(3, 4);
        // graph.AddEdge(4, 1);
        // graph.AddEdge(4, 3);
        
        // var resultGraph = graph.BreadthFirstSearch(3);
        // Console.WriteLine("resultGraph:" + resultGraph);

        var newGraph = new NewGraph();
        var result = newGraph.BreadthSearch(3);
        Console.WriteLine("result:" + result);
    }
}
