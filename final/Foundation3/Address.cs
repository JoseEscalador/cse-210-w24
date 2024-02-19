public class Address {
    private string _streetLine;
    private string _city;
    private string _stateProvince;
    private string _country;

    public string GetAddress() {
        string fullAddress = $"{_streetLine}\n{_city}, {_stateProvince}\n{_country}";
        return fullAddress;
    }
}