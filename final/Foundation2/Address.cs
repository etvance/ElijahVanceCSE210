

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool _inUS;

    public Address(string street, string city, string state, string country, bool inUS)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
        _inUS = inUS;
    }

    public bool DetermineUS()
    {
        return _inUS;
    }

    public string String()
    {
        string addressString = $"{_street}, {_city}, {_stateProvince}, {_country}";
        return addressString;
    }
}