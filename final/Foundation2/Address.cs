public class Address {
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address (string street, string city, string statepProvince, string country){
        _street = street;
        _city = city;
        _stateProvince = statepProvince;
        _country = country;
    }
    public bool UsaAddress() {
        if (_country == "USA") {
            return true;
        }
        else {
            return false;
        }
    }
    public string FullAddress() {
        string fullAddress = $"{_street}\n{_city}, {_stateProvince}\n{_country}";
        return fullAddress;
    }
}