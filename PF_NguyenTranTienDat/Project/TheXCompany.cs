//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;

//public class CompanyGroups
//{
//    public class Member
//    {
//        public int ID { get; set; }
//        public string FullName { get; set; }
//        public int CompletedTasks { get; set; }
//    }

//    public static void Main(string[] args)
//    {
//        List<List<Member>> groups = InitializeGroups();

//        while (true)
//        {
//            Console.WriteLine("Choose an action:");
//            Console.WriteLine("1. Print all members");
//            Console.WriteLine("2. Print member by ID");
//            Console.WriteLine("3. Print member with most tasks");
//            Console.WriteLine("4. Exit");

//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    PrintAllMembers(groups);
//                    break;
//                case 2:
//                    PrintMemberByID(groups);
//                    break;
//                case 3:
//                    PrintMemberWithMostTasks(groups);
//                    break;
//                case 4:
//                    return; // Exit the program
//                default:
//                    Console.WriteLine("Invalid choice.");
//                    break;
//            }
//        }
//    }

//    static List<List<Member>> InitializeGroups()
//    {
//        // In a real application, you would likely get this data from a database or file
//        // This is simplified initialization for demonstration
//        return new List<List<Member>>
//        {
//            //group 1
//            new List<Member>
//            {
//                new Member { ID = 101, FullName = "Alice Smith", CompletedTasks = 5 },
//                new Member { ID = 102, FullName = "Bob Johnson", CompletedTasks = 3 },
//                new Member { ID = 103, FullName = "Dat dep trai", CompletedTasks = 4 },
//                new Member { ID = 104, FullName = "Dacien", CompletedTasks = 6 },
//                new Member { ID = 105, FullName = "Michel Jordan", CompletedTasks = 2 }
//            },
//            //group 2
//            new List<Member>
//            {
//                new Member { ID = 201, FullName = "James Smath", CompletedTasks = 7 },
//                new Member { ID = 202, FullName = "Luke Chagie", CompletedTasks = 8 },
//                new Member { ID = 203, FullName = "Thomas Manis", CompletedTasks = 6 }
//            },
//            //group 3
//            new List<Member>
//            {
//                new Member { ID = 301, FullName = "James abc", CompletedTasks = 7 },
//                new Member { ID = 302, FullName = "Luke xyz", CompletedTasks = 8 },
//                new Member { ID = 303, FullName = "Thomas Harris", CompletedTasks = 6 },
//                new Member { ID = 304, FullName = "James Smith", CompletedTasks = 7 },
//                new Member { ID = 305, FullName = "Luke Issa", CompletedTasks = 8 },
//                new Member { ID = 306, FullName = "Thomas Clear", CompletedTasks = 6 },
//            },
//        };
//    }

//    static void PrintAllMembers(List<List<Member>> groups)
//    {
//        for (int i = 0; i < groups.Count; i++)
//        {
//            Console.WriteLine($"Group {i + 1}:");
//            foreach (var member in groups[i])
//            {
//                Console.WriteLine($"- ID: {member.ID}, Name: {member.FullName}, Tasks: {member.CompletedTasks}");
//            }
//        }
//    }

//    static void PrintMemberByID(List<List<Member>> groups)
//    {
//        Console.Write("Enter member ID: ");
//        int id = int.Parse(Console.ReadLine());

//        Member foundMember = null;
//        foreach (var group in groups)
//        {
//            foundMember = group.Find(m => m.ID == id);
//            if (foundMember != null) break;
//        }

//        if (foundMember != null)
//        {
//            Console.WriteLine($"ID: {foundMember.ID}, Name: {foundMember.FullName}, Tasks: {foundMember.CompletedTasks}");
//        }
//        else
//        {
//            Console.WriteLine("Member not found.");
//        }
//    }


//    static void PrintMemberWithMostTasks(List<List<Member>> groups)
//    {
//        Member topMember = null;
//        int maxTasks = 0;

//        foreach (var group in groups)
//        {
//            foreach (var member in group)
//            {
//                if (member.CompletedTasks > maxTasks)
//                {
//                    maxTasks = member.CompletedTasks;
//                    topMember = member;
//                }
//            }
//        }

//        if (topMember != null)
//        {
//            Console.WriteLine($"Member with most tasks: ID: {topMember.ID}, Name: {topMember.FullName}, Tasks: {maxTasks}");
//        }
//        else
//        {
//            Console.WriteLine("No members found."); // Handle the case where there are no members
//        }
//    }
//}

using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

public class CompanyGroupsNoStruct
{
    static void Main3(string[] args)
    {
        // Parallel arrays to store member data
        int[][] ids = new int[][]
        {
            new int[] { 101, 102, 103, 104, 105 }, // IDs for group 1
            new int[] { 201, 202, 203 },      // IDs for group 2
            new int[] { 301, 302, 303, 304, 305, 306 } // IDs for group 3
        };

        string[][] names = new string[][]
        {
            new string[] { "Alice Smith", "Bob Johnson", "Eve Jackson","Paul Mick", "Jungle Yi" },
            new string[] { "Charlie Brown", "David Lee" ,"John Thomas"},
            new string[] { "Frank Miller", "Grace Wilson", "Helen Thomas", "Ivy Roberts" ,"Millet Sung","Grace Olivia"}
        };

        int[][] tasks = new int[][]
        {
            new int[] { 5, 3, 8, 6, 2 },
            new int[] { 7, 8, 9},
            new int[] { 4, 9, 3, 6,5,4 }
        };

        //Menu for selection
        while (true)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Print all members");
            Console.WriteLine("2. Print member by IDs");
            Console.WriteLine("3. Print member with most tasks");
            Console.WriteLine("4. Print member with fewest tasks by group");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintAllMembers(ids, names, tasks);
                    break;
                case 2:
                    Console.Write("Enter Member's IDs (seperated by blank space) to look up information: ");
                    string input = Console.ReadLine();

                    string[] values = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    int[] ids_lookup = new int[values.Length];

                    for(int  i = 0; i < values.Length; i++)
                    {
                        ids_lookup[i] = int.Parse(values[i]);
                    }

                    PrintMemberByIDs(ids, names, tasks, ids_lookup);
                    break;
                case 3:
                    PrintMemberWithMostTasks(ids, names, tasks);
                    break;
                case 4:
                    Console.Write("Enter the number of group: ");
                    int group = int.Parse(Console.ReadLine());
                    PrintMemberWithFewestTasksByGroup(ids, names, tasks,group);
                    break;
                case 5:
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void PrintAllMembers(int [][] ids,string [][] names, int [][] tasks)
    {
        for(int i = 0; i < ids.Length; i++)
        {
            Console.WriteLine($"Group {i+1}: ");
            for(int j = 0; j < ids[i].Length; j++)
            {
                Console.WriteLine($"- ID: {ids[i][j]}, Name: {names[i][j]}, Total task completed: {tasks[i][j]}");
            }
        }
    }

    static void PrintMemberByID(int[][] ids, string[][] names, int[][] tasks, int id_lookup)
    {
        for(int i = 0;i < ids.Length; i++)
        {
            for(int j = 0;j < ids[i].Length; j++)
            {
                if (ids[i][j] == id_lookup)
                {
                    Console.WriteLine($"- Name: {names[i][j]}, Total task completed: {tasks[i][j]}");
                    return;
                }
            }
        }
        Console.WriteLine("Member not found.");
    }

    static void PrintMemberByIDs(int[][] ids, string[][] names, int[][] tasks, int[] ids_lookup)
    {
        foreach (int idToFind in ids_lookup)
        {
            bool found = false;
            for (int i = 0; i < ids.Length; i++)
            {
                for (int j = 0; j < ids[i].Length; j++)
                {
                    if (ids[i][j] == idToFind)
                    {
                        Console.WriteLine($"- ID: {ids[i][j]}, Name: {names[i][j]}, Total task completed: {tasks[i][j]}");
                        found = true;
                        break; // Exit inner loop once found
                    }
                }
                if (found) break; // Exit outer loop once found
            }
            if (!found)
            {
                Console.WriteLine($"Member with ID {idToFind} not found.");
            }
        }
    }

    static void PrintMemberWithMostTasks(int[][] ids, string[][] names, int[][] tasks)
    {
        int maxTasks = -1;
        List<int> idsWithMaxTasks = new List<int>();

        for(int i = 0; i < tasks.Length; i++)
        {
            for(int j = 0; j < tasks[i].Length; j++)
            {
                if (tasks[i][j] > maxTasks)
                {
                    maxTasks = tasks[i][j];
                    // Clear previous IDs since we found a new max
                    idsWithMaxTasks.Clear();
                    idsWithMaxTasks.Add(ids[i][j]);
                }
                else if (tasks[i][j] == maxTasks)
                {
                    // Add ID if it also has the max tasks
                    idsWithMaxTasks.Add(ids[i][j]);
                }
            }
        }

        if(idsWithMaxTasks.Count > 0)
        {
            Console.WriteLine("Member(s) with the most tasks:");
            PrintMemberByIDs(ids, names, tasks, idsWithMaxTasks.ToArray());
        }

        else
        {
            Console.WriteLine("No members found.");
        }
    }

    //static void PrintMemberWithFewestTasksByGroup(int[][] ids, string[][] names, int[][] tasks, int group)
    //{
    //    int minTasks = -1;
    //    List<int> idsWithMinTasks = new List<int>();
    //    for (int i = group; i < tasks[group].Length; i++)
    //    {
    //        if(tasks[group][i] < minTasks)
    //        {
    //            minTasks = tasks[group][i];
    //            idsWithMinTasks.Add(ids[group][i]);
    //        }
    //    }
    //    if(idsWithMinTasks.Count > 0)
    //    {
    //        Console.WriteLine("Member(s) with the fewest tasks:");
    //        PrintMemberByIDs(ids, names, tasks, idsWithMinTasks.ToArray());
    //    }
    //    else
    //    {
    //        Console.WriteLine("No members found.");
    //    }
    //}

    static void PrintMemberWithFewestTasksByGroup(int[][] ids, string[][] names, int[][] tasks, int group)
    {
        group = group - 1;
        if (group < 0 || group >= tasks.Length)
        {
            Console.WriteLine("Invalid group number.");
            return;
        }

        int minTasks = 1000; // Initialize to maximum possible value
        List<int> idsWithMinTasks = new List<int>();

        for (int j = 0; j < tasks[group].Length; j++)
        {
            if (tasks[group][j] < minTasks)
            {
                minTasks = tasks[group][j];
                idsWithMinTasks.Clear(); // Clear the list because we found a new minimum
                idsWithMinTasks.Add(ids[group][j]);
            }
            else if (tasks[group][j] == minTasks)
            {
                idsWithMinTasks.Add(ids[group][j]); // Add to the list if it's also the minimum
            }
        }

        if (idsWithMinTasks.Count > 0)
        {
            Console.WriteLine($"Member(s) with the fewest tasks in group {group + 1}:");
            PrintMemberByIDs(ids, names, tasks, idsWithMinTasks.ToArray());
        }
        else
        {
            Console.WriteLine($"No members found in group {group + 1}."); // More specific message
        }
    }
}