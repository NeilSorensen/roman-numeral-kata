namespace roman_numeral_kata;

public class Tests
{
    [Test]
    public void RomanNumberOfOneIsI()
    {
        Assert.That(Roman.FromInt(1), Is.EqualTo("I"));
    }

    // 5 is v

    [Test]
    public void RomanNumberofFiveIsV()
    {
        Assert.That(Roman.FromInt(5), Is.EqualTo("V"));
    }
}
