using System;


public interface IJobPublisher
{
    void AddObserver(IObserver observer);

    void RemoveObserver(IObserver observer);

    void NotifyObserver();
}

