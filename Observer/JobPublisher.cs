using System;
using System.Collections.Generic;

public class JobPublisher : IJobPublisher
{
    private List<IObserver> listOfObserver = new List<IObserver>();
    private string jobStatus = "No Jobs!!!";


    public void AddObserver(IObserver observer) 
    {
        listOfObserver.Add(observer);
        Console.WriteLine("User added.");
    }

    public void RemoveObserver(IObserver observer)
    {
        listOfObserver.Remove(observer);
        Console.WriteLine("User removed.");
    }

    public void NotifyObserver()
    {
        Console.WriteLine("Job Status Updated.");
        foreach (IObserver observer in listOfObserver)
        {
            observer.Update(jobStatus);
        }

    }

    public void GetJobStatus()
    {
        Console.WriteLine(jobStatus);
    }

    public void SetJobStatus(string jobStatus)
    {
        this.jobStatus=jobStatus;
        Console.WriteLine("Job Status changed!!!");
        NotifyObserver();
    }

}
