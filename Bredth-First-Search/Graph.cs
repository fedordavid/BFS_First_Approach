public class Graph
{
    // No. of vertices / nodes   
    private readonly int _nodes;

    // Adjacency Lists // I tried with List and works just fine
    private readonly LinkedList<int>[] _adjacencyList;

    public Graph(int nodes)
    {
        _adjacencyList = new LinkedList<int>[nodes];
        
        for (var i = 0; i < _adjacencyList.Length; i++)
        {
            _adjacencyList[i] = new LinkedList<int>();
        }

        _nodes = nodes;
    }
    // Function to add an edge into the graph
    // edges are lines that connect any two nodes or vertices 
    public void AddEdge(int node, int anotherNode)
    {
        _adjacencyList[node].AddLast(anotherNode);
    }

    // collects BFS traversal from a given source s
    public string BreadthFirstSearch(int startNode)
    {
        var breadthFirstSearchTraversePath = string.Empty;
        var visitedNodes =  new bool[_nodes];

        var queue = new Queue<int>();

        // Mark the current node as  visited and enqueue it
        visitedNodes[startNode] = true;
        queue.Enqueue(startNode);

        while (queue.Any())
        {
            // Dequeue a node/vertex from queue and print it
            startNode = queue.First();
            
            // save the visited node
            breadthFirstSearchTraversePath = $"{breadthFirstSearchTraversePath}{startNode}";
            
            queue.Dequeue();

            // Get all adjacent vertices of the dequeued node/vertex
            var adjacencyList = _adjacencyList[startNode];

            // If an adjacent has not been visited, then mark it visited and enqueue it
            foreach (var adjacent in adjacencyList.Where(adjacent => !visitedNodes[adjacent]))
            {
                visitedNodes[adjacent] = true;
                queue.Enqueue(adjacent);
            }
        }

        return breadthFirstSearchTraversePath;
    }
}