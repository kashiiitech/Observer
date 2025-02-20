namespace Observer;

public interface Subject
{
    void Attach(Observer observer);
    
    void Detach(Observer observer);
    
    void Notify();
}