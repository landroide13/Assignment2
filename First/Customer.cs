using System;

namespace First
{
  class Customer{

    private string name;
    private int rating;
    private string address;

    public Customer(string name, int rating, string address)
    {
      this.name = name;
      this.rating = rating;
      this.address = address;
    }

    public void SetName(string newName)
    {
      this.address = newName;
    }
     public void SetRating(int newRating)
    {
      this.rating = newRating;
    }
     public void SetAddress(string newAddress)
    {
      this.address = newAddress;
    }
    public string GetName()
    {
      return name;
    }
     public int GetRating()
    {
      return rating;
    }

     public string GetAddress()
    {
      return address;
    }


  }


}