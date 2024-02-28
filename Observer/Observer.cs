using System;

public class Observer : IObserver
{
    public void Subscribe(IJobPublisher publisher)
    {
        publisher.AddObserver(this);
    }

    public void UnSubscribe(IJobPublisher publisher)
    {
        publisher.RemoveObserver(this);
    }

    public void Update(string jobStatus)
    {
        Console.WriteLine("Job available!!!");
    }
}
