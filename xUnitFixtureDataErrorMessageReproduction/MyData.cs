namespace xUnitFixtureDataErrorMessageReproduction;

public class MyData
{
    public MyData()
    {
        throw new Exception("Whoops!");
    }

    public int Value => 1;
}