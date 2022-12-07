using System.Collections.Generic;

public class Subject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

	public void Attach(IObserver observer)
	{
		observers.Add(observer);
	}

	public void Detach(IObserver observer)
	{
		observers.Remove(observer);
	}

	public void Notify()
	{
        for(int a=0; a<observers.Count; a++)
        {
            observers[a].Refresh();
        }
	}

}
