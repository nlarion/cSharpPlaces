using Nancy;
using PlacesWeveBeen.Objects;
using System.Collections.Generic;
using PlacesWeveBeen.Images;

namespace PlacesWeveBeen
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/places"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };
      Get["/places/new"] = _ => {
        return View["place_form.cshtml"];
      };
      Post["/places"] = _ => {
        Image image  =  new Image(Request.Form["new-image"]);
        Place newPlace = new Place(Request.Form["new-place"], Request.Form["new-description"],image);
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };
      Get["/places/{id}"] = parameters => {
        Place place = Place.Find(parameters.id);
        return View["/place.cshtml", place];
      };
    }
  }
}
