﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public delegate void JobDoneEventHandler(object sender, JobEventArgs e);
    static void Main(string[] args)
    {
        JobsList jobs = new JobsList();
        List<BaseEmployee> employees = new List<BaseEmployee>();

        string[] input = Console.ReadLine().Split();
        while(input[0] != "End")
        {
            switch (input[0])
            {
                case "Job":
                    Job realJob = new Job(input[1], int.Parse(input[2]), employees.FirstOrDefault(e => e.Name == input[3]));
                    realJob.JobDone += realJob.OnJobDone;
                    realJob.JobDone += jobs.OnJobDone;
                    jobs.Add(realJob);
                    break;
                case "StandartEmployee":
                    employees.Add(new StandartEmployee(input[1]));
                    break;
                case "PartTimeEmployee":
                    employees.Add(new PartTimeEmployee(input[1]));
                    break;
                case "Pass":
                    foreach (var job in jobs)
                    {
                        job.Update();
                    }
                    break;
                case "Status":
                    foreach (var job in jobs)
                    {
                        if (!job.IsDone)
                        {
                            Console.WriteLine(jobs.ToString());
                        }
                    }
                    break;
                default:
                    break;
            }

            input = Console.ReadLine().Split();
        }
    }
}