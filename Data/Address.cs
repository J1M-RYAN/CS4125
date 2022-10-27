namespace CS4125.Data;

public abstract class Address
{
    private string _firstLine;
    private string _secondLine;

    protected Address(string firstLine, string secondLine)
    {
        _firstLine = firstLine;
        _secondLine = secondLine;
    }

    public string FormatAddress(string firstLine, string secondLine)
    {
        var formattedAddress = (firstLine + ", " + secondLine);
        return formattedAddress;
    }
}
