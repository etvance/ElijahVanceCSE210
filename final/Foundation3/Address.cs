

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvinve;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvinve = stateProvince;
        _country = country;
    }

    public string AddressString()
    {
        return $"{_street}, {_city}, {_stateProvinve}, {_country}";
    }
}