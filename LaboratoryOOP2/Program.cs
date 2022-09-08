using System;

namespace LaboratoryOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
class Address
{
    private int index;

    public int Index
    {
        get
        {
            return index;
        }
        set
        {
            index = value;
        }
    }

    private string _country;

    public string country
    {
        get
        {
            return _country;
        }

        set
        {

            _country = value;
        }
    }

    private string _city;

    public string city
    {
        get
        {
            return _city;
        }
        set
        {
            _city = value;
        }
    }

    private string _street;

    public string street
    {
        get
        {
            return _street;
        }

        set
        {
            _street = value;
        }
    }

    private string _house;

    public string house
    {
        get
        {
            return _house;
        }

        set
        {
            _house = value;
        }
    }

    private string _apartment;

    public string apartment
    {
        get
        {
            return _apartment;
        }

        set
        {
            _apartment = value;
        }
    }
}
class Postcode : Address//экземпляр
{
    public void DisplayName()
    {
        Console.WriteLine($"Index: {Index} Country : {country} City : {city} Street : {street} House : {house} Apartment : {apartment}");
    }

}