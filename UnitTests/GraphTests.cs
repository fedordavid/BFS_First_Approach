namespace UnitTests;

public class Tests
{
    private Graph _graph;
    
    [SetUp]
    public void Setup()
    {
        _graph = new Graph(7);
        
        _graph.AddEdge(0, 1);
        _graph.AddEdge(0, 2);
        _graph.AddEdge(1, 2);
        _graph.AddEdge(1, 4);
        _graph.AddEdge(2, 0);
        _graph.AddEdge(2, 3);
        _graph.AddEdge(3, 4);
        _graph.AddEdge(4, 1);
    }

    [Test]
    public void GivenGraph_WhenBreadthFirstSearchFromSpecificNode_ReturnsValidTraversePath()
    {
        var result = _graph.BreadthFirstSearch(3);
        Assert.AreEqual(result, "34120");
    }
}