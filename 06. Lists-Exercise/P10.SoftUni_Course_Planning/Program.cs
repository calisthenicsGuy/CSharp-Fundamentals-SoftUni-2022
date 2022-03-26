using System;
using System.Linq;

namespace P10.SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            var coursePlan = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] commandArgs = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string operation = commandArgs[0];
                string lessonTitle = commandArgs[1];

                if (operation == "Add")
                {
                    if (!coursePlan.Contains(lessonTitle))
                    {
                        coursePlan.Add(lessonTitle);
                    }
                }
                else if (operation == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);

                    if (!coursePlan.Contains(lessonTitle))
                    {
                        coursePlan.Insert(index, lessonTitle);
                    }
                }
                else if (operation == "Remove")
                {
                    if (coursePlan.Contains(lessonTitle))
                    {
                        coursePlan.Remove(lessonTitle);
                        if (coursePlan.Contains($"{lessonTitle}-Exercise"))
                        {
                            coursePlan.Remove($"{lessonTitle}-Exercise");
                        }
                    }
                }
                else if (operation == "Swap")
                {
                    string swapLessonTitle = commandArgs[2];

                    if (coursePlan.Contains(lessonTitle) && coursePlan.Contains(swapLessonTitle))
                    {
                        int index1 = coursePlan.IndexOf(lessonTitle);
                        int index2 = coursePlan.IndexOf(swapLessonTitle);

                        coursePlan[index1] = swapLessonTitle;
                        coursePlan[index2] = lessonTitle;

                        if (coursePlan.Contains($"{lessonTitle}-Exercise"))
                        {
                            coursePlan.Remove($"{lessonTitle}-Exercise");
                            coursePlan.Insert(index2 + 1, $"{lessonTitle}-Exercise");

                            if (coursePlan.Contains($"{swapLessonTitle}-Exercise"))
                            {
                                coursePlan.Remove($"{swapLessonTitle}-Exercise");
                                coursePlan.Insert(index1 + 1, $"{swapLessonTitle}-Exercise");
                            }
                        }
                        else if (coursePlan.Contains($"{swapLessonTitle}-Exercise"))
                        {
                            coursePlan.Remove($"{swapLessonTitle}-Exercise");
                            coursePlan.Insert(index1 + 1, $"{swapLessonTitle}-Exercise");

                            if (coursePlan.Contains($"{lessonTitle}-Exercise"))
                            {
                                coursePlan.Remove($"{lessonTitle}-Exercise");
                                coursePlan.Insert(index2 + 1, $"{lessonTitle}-Exercise");
                            }
                        }
                    }
                }
                else if (operation == "Exercise")
                {
                    if (coursePlan.Contains(lessonTitle) && !coursePlan.Contains($"{lessonTitle}-Exercise"))
                    {
                        coursePlan.Insert(coursePlan.IndexOf(lessonTitle) + 1, $"{lessonTitle}-Exercise");
                    }
                    else if (!coursePlan.Contains(lessonTitle))
                    {
                        coursePlan.Add(lessonTitle);
                        coursePlan.Add($"{lessonTitle}-Exercise");
                    }
                }
            }

            for (int i = 0; i < coursePlan.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{coursePlan[i]}");
            }
        }
    }
}
