
public interface IMyInterface
{
    int Number{get;}
}

public class Class1:IMyInterface
{
    public int Number { get; set; }
}

public class Test{
    public void Run(){
        Class1 myInterface = new Class1();
        myInterface.Number =1;
    }
}