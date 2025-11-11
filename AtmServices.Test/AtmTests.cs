namespace AtmServices.Test;

using System.Reflection;
using AtmServices;

public class AtmTests

{

    Atm testAtm;

    int initialBalance = 100;

    public AtmTests()
    {

        testAtm = new Atm(initialBalance);

    }



    [Fact]

    public void Test_Withdraw()

    {

        var result = testAtm.withdraw(25);

        Assert.True(result);

        Assert.Equal(75, testAtm.getBalance());

    }


    [Fact]
    public void Test_Deposit()

    {

        var result = testAtm.deposit(25);

        Assert.True(result);

        Assert.Equal(125, testAtm.getBalance());
    }

    [Fact]
    public void Test_Bad_Deposit()

    {

        var result = testAtm.deposit(-25);

        Assert.False(result);

        Assert.Equal(100, testAtm.getBalance());

    }


    [Fact]

    public void Test_Too_Much_Withdraw()

    {

        var result = testAtm.withdraw(125);
        
        Assert.False(result);

        Assert.Equal(100, testAtm.getBalance());

    }

}

    