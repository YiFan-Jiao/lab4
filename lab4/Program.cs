//Question 1
using System.Diagnostics;

Console.WriteLine("Question 1");
Console.WriteLine("How many lists you want?");
int listNum = int.Parse(Console.ReadLine()); 
List<List<int>> lists = new List<List<int>>();

for (int i = 0; i < listNum; i++)
{
    Console.WriteLine($"Please enter list{i + 1}'number with comma.");
    string[] inputList = Console.ReadLine().Split(',');
    List<int> addList = new List<int>();
    foreach (string num in inputList)
    {
        addList.Add(int.Parse(num));
    }
    lists.Add(addList);
}

int GetHighestValueInList(List<int> list)
{
    int max = list.Max();
    return max;
}

List<int> MaxNumbersInLists(List<List<int>> lists)
{
    List<int> maxNums = new List<int>();

    for (int i = 0; i < lists.Count; i++)
    {
        maxNums.Add(GetHighestValueInList(lists[i]));
    }
    return maxNums;
}
List<int> maxNumsList = MaxNumbersInLists(lists);

for (int i = 0; i < maxNumsList.Count; i++)
{
    Console.WriteLine($"List {i + 1} has a maximum of {maxNumsList[i]}.");
}
Console.WriteLine("The time complexity of Question 1 is O(n).");

//Question 2
Console.WriteLine("\nQuestion 2");
Console.WriteLine("How many classes you want?");
int classesNum = int.Parse(Console.ReadLine());
List<List<int>> classes = new List<List<int>>();

for (int i = 0; i < classesNum; i++)
{
    Console.WriteLine($"Please enter classes{i + 1}'grade with comma.");
    string[] inputList = Console.ReadLine().Split(',');
    List<int> addList = new List<int>();
    foreach (string num in inputList)
    {
        addList.Add(int.Parse(num));
    }
    classes.Add(addList);
}
String HighestGrade(List<List<int>> lists)
{
    List<int> maxGrades = new List<int>();
    List<int> maxGradesClasses = new List<int>();
    for (int i = 0; i < lists.Count; i++)
    {
        maxGrades.Add(GetHighestValueInList(lists[i]));
    }
    int maxGrade = GetHighestValueInList(maxGrades);

    for (int i = 0;i < maxGrades.Count; i++)
    {
        if (maxGrades[i] == maxGrade)
        {
            maxGradesClasses.Add(i+1);
        }
    }
    string classes = string.Join(", ", maxGradesClasses);
    return $"The highest grade is {maxGrade}. This grade was found in class(es) {classes}.";
}
string result = HighestGrade(classes);
Console.WriteLine(result);
Console.WriteLine("The time complexity of Question 2 is O(n).");

//Question 3
Console.WriteLine("\nQuestion 3");
Console.WriteLine("Please enter a string of numbers with comma.");
string[] inputOrderList = Console.ReadLine().Split(',');
List<int> orderList = new List<int>();
foreach (string num in inputOrderList)
{
    orderList.Add(int.Parse(num));
}

for (int i = 0; i < orderList.Count - 1; i++)
{
    for (int j = 0; j < orderList.Count - 1 - i; j++)
    {
        if (orderList[j] > orderList[j + 1])
        {
            int temp = orderList[j + 1];
            orderList[j + 1] = orderList[j];
            orderList[j] = temp;
        }
    }
}
foreach (int i in orderList)
{
    Console.Write($"{i} ");
}
Console.WriteLine("\nThe time complexity of Question 3 is O(n^2).");