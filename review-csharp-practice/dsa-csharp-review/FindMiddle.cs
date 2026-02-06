class FindMiddle
{
    Node Head;
    static int count = 0;

    public FindMiddle()
    {
        Head = null;
    }
    
    public void AddNode(int data)
    {
        count++;
        Node newNode = new Node(data);
        if(Head == null)
        {
            Head = newNode;
            return;
        }
        
        Node temp = Head;
        while(temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    public void DisplayList()
    {
        if(Head == null)
        {
            throw new InvalidOperationException("List Is Empty");
        }
        Node curr = Head;
        while(curr != null)
        {
            System.Console.WriteLine(curr.data);
            curr = curr.next;
        }
    }

    public void FindMiddleNode(Node nn, int c)
    {
        if(nn == null)
        {
            return;
        }
        int mid = count / 2;
        if(count % 2 == 0)
        {
            mid = mid - 1;
        }
        if(c == mid)
        {
            System.Console.WriteLine("Middle Node Is: "+nn.data);
            return;
        }
        FindMiddleNode(nn.next,c+1);
    }

    public void Menu()
    {
        while (true)
        {
            System.Console.WriteLine("1. Add Node");
            System.Console.WriteLine("2. Find Middle");
            System.Console.WriteLine("3. Display List");
            System.Console.WriteLine("4. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                System.Console.WriteLine("Enter Data");
                int data = int.Parse(Console.ReadLine());;
                AddNode(data);
                break;
                case 2:
                if(count == 0)
                {
                    throw new InvalidOperationException("List Is Empty");
                }
                FindMiddleNode(Head,0);
                break;
                case 3:
                if(count == 0)
                {
                    throw new InvalidOperationException("List Is Empty");
                }
                DisplayList();
                break;
                case 4:
                System.Console.WriteLine("Exitting");
                return;
                default:
                System.Console.WriteLine("Invalid Choice");
                break;
            }
        }
    }

    static void Main(string[] args)
    {
        FindMiddle node = new FindMiddle();
        node.Menu();
        
    }


}