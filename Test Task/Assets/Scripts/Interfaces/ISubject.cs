public interface ISubject
{
	public void AddObserver(IObserver observer);
	public void RemoveObserver(IObserver observer);
	public void Notify(object data);
}