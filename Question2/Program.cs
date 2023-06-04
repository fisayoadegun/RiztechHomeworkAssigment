using Question2;
using System;

class Program
{
    static void Main(string[] args)
    {
        var branch = GenerateBranches();

        var result = GetDepth(branch);

        Console.WriteLine($"Depth of given structure is: {result}");

        int GetDepth(Branch branch)
        {
            var depth = new List<int>();

            if (!branch.Branches.Any())
                return 1;

            foreach (var item in branch.Branches)
            {
                depth.Add(GetDepth(item) + 1);
            }

            return depth.Max();
        }

        Branch GenerateBranches()
        {
            var branch = new Branch();

            //2
            branch.Branches.AddRange(Enumerable.Repeat(new Branch(), 2).Select(x => new Branch()));
            //3
            branch.Branches[0].Branches.Add(new Branch());
            branch.Branches[1].Branches.AddRange(Enumerable.Repeat(new Branch(), 3).Select(x => new Branch()));
            //4
            branch.Branches[1].Branches[0].Branches.Add(new Branch());
            branch.Branches[1].Branches[1].Branches.AddRange(Enumerable.Repeat(new Branch(), 2).Select(x => new Branch()));
            //5
            branch.Branches[1].Branches[1].Branches[0].Branches.Add(new Branch());

            return branch;
        }
    }
}