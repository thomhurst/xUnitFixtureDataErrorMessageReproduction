namespace xUnitFixtureDataErrorMessageReproduction;

public class UnitTest1 : IClassFixture<MyData>
{
    private readonly MyData _myData;

    public UnitTest1(MyData myData)
    {
        _myData = myData;
    }
    
    [Fact]
    public void Test1()
    {
        Assert.Equal(1, _myData.Value);
    }
}