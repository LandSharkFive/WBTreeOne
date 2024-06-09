namespace WBTreeOne
{
    public class Tree
    {
        public TreeNode Root;

        public Tree()
        {
            Root = null;
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

        public void Clear()
        {
            Clear(Root);
            Root = null;
        }

        public void Clear(TreeNode r)
        {
            if (r != null)
            {
                Clear(r.Left);
                Clear(r.Right);
                r.Left = null;
                r.Right = null;
            }
        }

        public void Insert(int value)
        {
            Root = Insert(value, Root);
            if (BalanceCount() > 10)
            {
                Balance(this);
            }
        }

        public TreeNode Insert(int value, TreeNode t)
        {
            if (t == null)
            {
                t = new TreeNode(value);
            }
            else if (value < t.Value)
            {
                t.Left = Insert(value, t.Left);
            }
            else if (value > t.Value)
            {
                t.Right = Insert(value, t.Right);
            }
            return t;
        }

        public void AddRange(List<int> list)
        {
            foreach (var x in list)
            {
                Insert(x);
            }      
        }

        public int Count()
        {
            return Count(Root);
        }

        public int Count(TreeNode r)
        {
            if (r == null)
            {
                return 0;
            }
            else
            {
                return Count(r.Left) + Count(r.Right) + 1;
            }
        }

        public void Remove(int value)
        {
            Root = Remove(value, Root);
            if (BalanceCount() > 10)
            {
                Balance(this);
            }
        }

        public TreeNode Remove(int value, TreeNode t)
        {
            if (t == null)
            {
                return null;
            }
            else if (value < t.Value)
            {
                t.Left = Remove(value, t.Left);
            }
            else if (value > t.Value)
            {
                t.Right = Remove(value, t.Right);
            }
            else 
            {
                // One child or zero.
                if (t.Left == null)
                    return t.Right;
                else if (t.Right == null)
                    return t.Left;

                t.Value = MinValue(t.Right);
                t.Right = Remove(t.Value, t.Right);
            }
            return t;
        }

        public int MinValue(TreeNode node)
        {
            int min = node.Value;
            while (node.Left != null)
            {
                min = node.Left.Value;
                node = node.Left;
            }
            return min;
        }

        public bool Search(int value)
        {
            return Search(Root, value);
        }

        public bool Search(TreeNode r, int value)
        {
            bool found = false;
            while ((r != null) && !found)
            {
                if (value < r.Value)
                    r = r.Left;
                else if (value > r.Value)
                    r = r.Right;
                else
                {
                    found = true;
                    break;
                }
                found = Search(r, value);
            }
            return found;
        }

        public void InOrder()
        {
            InOrder(Root);
            Console.WriteLine();
        }

        public void InOrder(TreeNode r)
        {
            if (r != null)
            {
                InOrder(r.Left);
                Console.Write(r.Value + " ");
                InOrder(r.Right);
            }
        }

        public void PreOrder()
        {
            PreOrder(Root);
            Console.WriteLine();
        }

        public void PreOrder(TreeNode r)
        {
            if (r != null)
            {
                Console.Write(r.Value + " ");
                PreOrder(r.Left);
                PreOrder(r.Right);
            }
        }

        public void PostOrder()
        {
            PostOrder(Root);
            Console.WriteLine();
        }

        public void PostOrder(TreeNode r)
        {
            if (r != null)
            {
                Console.Write(r.Value + " ");
                PostOrder(r.Left);
                PostOrder(r.Right);
            }
        }

        public int BalanceCount()
        {
            if (Root == null)
            {
                return 0;
            }

            return Math.Abs(Count(Root.Left) - Count(Root.Right));
        }

        public void Balance(Tree a)
        {
            if (a.Root == null)
            {
                return;
            }

            var b = a.GetList().OrderBy(x => x).ToList();
            a.Root = BuildTree(b, 0, b.Count - 1);
        }

        public List<int> GetList()
        {
            if (Root == null)
            {
                return new List<int>();
            }
            else
            {
                return GetList(Root, new List<int>());
            }
        }

        public List<int> GetList(TreeNode r, List<int> myList)
        {
            if (r != null)
            {
                GetList(r.Left, myList);
                myList.Add(r.Value);
                GetList(r.Right, myList);
            }

            return myList;
        }

        /// <summary>
        /// Build Tree
        /// </summary>
        /// <param name="">sorted array</param>
        /// <param name="">start index, 0</param>
        /// <param name="">end index, n-1</param>
        public TreeNode BuildTree(List<int> array, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;
            TreeNode a = new TreeNode(array[mid]);
            a.Left = BuildTree(array, start, mid - 1);
            a.Right = BuildTree(array, mid + 1, end);
            return a;
        }

        public int Height()
        {
            if (Root == null)
            {
                return 0;
            }
            else
            {
                return Height(Root);
            }
        }

        public int Height(TreeNode node)
        {
            if (node == null || IsLeaf(node))
            {
                return 0;
            }

            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        public bool IsLeaf(TreeNode node)
        {
            return node.Left == null && node.Right == null;
        }


    }
}
