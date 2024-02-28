using System;

public class Program
{
	public static void Main(string[] args)
	{
	
		JobPublisher publisher = new JobPublisher();

		Observer user1 = new Observer();
        Observer user2 = new Observer();
        Observer user3 = new Observer();

		user1.Subscribe(publisher);
		user2.Subscribe(publisher);
		user3.Subscribe(publisher);

		publisher.GetJobStatus();
		publisher.SetJobStatus("Job 1 available");
		user1.UnSubscribe(publisher);
        publisher.SetJobStatus("Job 2 available");
    }
	
}
