using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numSubjects = int.Parse(Console.ReadLine());

        Dictionary<string, int> subjects = new Dictionary<string, int>();

        for (int i = 0; i < numSubjects; i++)
        {
            string subject = Console.ReadLine();
            if (subjects.ContainsKey(subject))
            {
                subjects[subject] += 1;
            }
            else
            {
                subjects.Add(subject,1);
            }
        }

        foreach (KeyValuePair<string, int> subject in subjects)
        {
            Console.WriteLine(subject.Key + " -> " + subject.Value);
        }

        Console.WriteLine(numSubjects);
    }
}
