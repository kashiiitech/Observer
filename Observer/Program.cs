// client 

using Observer;

ConcreteSubject subject = new();

subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));
subject.Attach(new ConcreteObserver(subject));

subject.SetState("state 1");

await Task.Delay(1000);

subject.SetState("state 2");