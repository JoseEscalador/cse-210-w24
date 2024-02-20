public class Address {
    private string _streetLine;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address (string streetLine, string city, string stateProvince, string country) {
        _streetLine = streetLine;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string GetAddress() {
        string fullAddress = $"{_streetLine}\n{_city}, {_stateProvince}, {_country}";
        return fullAddress;
    }
}