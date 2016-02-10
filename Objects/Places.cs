using System.Collections.Generic;
using PlacesWeveBeen.Images;

namespace PlacesWeveBeen.Objects
{
  public class Place
  {
    // variables
    private string _city;
    private int _id;
    private string _description;
    private Image _image;//local instance of the object Image i.e. putting empty varibles to put something in
    private static List<Place> _places = new List<Place>{};
    // constructor
    public Place(string city, string description, Image image)
    {
      _city = city;
      _description = description;
      _places.Add(this);
      _id = _places.Count;
      _image = image;
    }
    // getters and setters
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string city)
    {
      _city = city;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string description)
    {
      _description = description;
    }

    public Image GetImage()
    {
      return _image;
    }
    public void SetImage(Image image)
    {
      _image = image;
    }
    public static List<Place> GetAll()
    {
      return _places;
    }
    public int GetId()
    {
      return _id;
    }
    public static Place Find(int id)
    {
      return _places[id-1];
    }

  }
}
