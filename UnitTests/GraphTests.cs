namespace UnitTests;

public class Tests
{
    private OldGraph _oldGraph;
    private NewGraph _newGraph;
    
    [SetUp]
    public void Setup()
    {
        _oldGraph = new OldGraph(11);
        
        _oldGraph.AddEdge(0, 1);
        _oldGraph.AddEdge(0, 2);
        _oldGraph.AddEdge(1, 0);
        _oldGraph.AddEdge(1, 2);
        _oldGraph.AddEdge(1, 4);
        _oldGraph.AddEdge(2, 0);
        _oldGraph.AddEdge(2, 1);
        _oldGraph.AddEdge(2, 3);
        _oldGraph.AddEdge(3, 2);
        _oldGraph.AddEdge(3, 4);
        _oldGraph.AddEdge(4, 1);
        _oldGraph.AddEdge(4, 3);

        _newGraph = new NewGraph();
    }

    [Test]
    public void GivenGraph_WhenBreadthFirstSearchFromSpecificNode_ReturnsValidTraversePath()
    {
        var graphResult = _oldGraph.BreadthFirstSearch(3);
        Assert.AreEqual("32401", graphResult);
        
        var newGraphResult = _newGraph.BreadthSearch(3);
        Assert.AreEqual("32401", newGraphResult);
    }
    
    [Test]
    public void GivenGraph_WhenBreadthFirstSearchFromInvalidSpecificNode_ReturnsError()
    {
        var result = _newGraph.BreadthSearch(90);
        Assert.AreEqual(result, "invalid start node provided");
    }
}