using System.Collections.Generic;

namespace PlacesWeveBeen.Images
{
  public class Image
  {
    private string _location;

    public Image(string location)
    {
      _location =  location;
    }

    public string GetImageLocation()
    {
      return _location;
    }
    public void SetImageLocation(string location)
    {
      _location = location;
    }
  }
}
