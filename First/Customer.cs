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

    public void setName(string newName)
    {
      this.address = newName;
    }
     public void setRating(int newRating)
    {
      this.rating = newRating;
    }
     public void setAddress(string newAddress)
    {
      this.address = newAddress;
    }
    public string getName()
    {
      return name;
    }
     public int getRating()
    {
      return rating;
    }

     public string getAddress()
    {
      return address;
    }


  }


}