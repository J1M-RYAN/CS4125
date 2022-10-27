namespace CS4125.Data;

public class Address
{
    private string _firstLine;
    private string _secondLine;

    public Address(string firstLine, string secondLine)
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
