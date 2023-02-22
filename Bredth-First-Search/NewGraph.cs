public class NewGraph
{
    private Node[] Nodes { get; }
    private Queue<Node> Queue { get; } = new();

    public NewGraph()
    {
        Nodes = new Node[]
        {
            new(0, new[] {1, 2}),
            new(1, new[] {0, 2, 4}),
            new(2, new[] {0, 1, 3}),
            new(3, new[] {2, 4}),
            new(4, new[] {1, 3})
        };
    }

    public string BreadthSearch(int startNode = 0)
    {
        if (!Nodes.Select(n => n.NodeNumber).Contains(startNode)) return "invalid start node provided";
        
        var breadthFirstSearchTraversePath = string.Empty;
        
        Queue.Enqueue(Nodes[startNode]);
        
        Nodes[startNode].Visited = true;

        while (Queue.Any())
        {
            var nextNode = Queue.First(); 
            
            Queue.Dequeue();
            
            breadthFirstSearchTraversePath = $"{breadthFirstSearchTraversePath}{nextNode.NodeNumber}";
            
            var nextValidNodesAdjacents = GetNextValidAdjacentNodes(nextNode);     
            
            foreach (var nextValidNodesAdjacent in nextValidNodesAdjacents)
            {
                var node = Nodes.Single(n => n.NodeNumber == nextValidNodesAdjacent);
                
                Queue.Enqueue(node);
                
                node.Visited = true;
            }
        }

        return breadthFirstSearchTraversePath;
    }

    private IEnumerable<int> GetNextValidAdjacentNodes(Node nextNode) 
        => nextNode.Adjacents.Select(adjacent => adjacent.AdjacentNode.NodeNumber)
            .Where(adjacent => Nodes
                .Where(node => node.Visited == false)
                .Select(node => node.NodeNumber)
                .Contains(adjacent));
}

public record Node(int NodeNumber, int[] AdjacentNodes)
{
    public readonly int NodeNumber = NodeNumber;
    
    public bool Visited;

    public readonly List<Adjacent> Adjacents = AdjacentNodes.Select(a => new Adjacent(a)).ToList();
}

public record Adjacent(int Node)
{
    public readonly Node AdjacentNode = new(Node, Array.Empty<int>());
}



