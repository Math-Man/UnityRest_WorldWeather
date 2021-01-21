using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityDataNode : MonoBehaviour
{
    public City data;

    private WeatherInfo info;

    public MeshRenderer rndr;

    private void Awake()
    {
        rndr = GetComponent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Yo: " + data.name + " " + data.id);
        PointsHandler.Instance.TextCityName.text = data.name;
        PointsHandler.Instance.TextLonLat.text = data.coord.lon + "/" + data.coord.lat;

        if (info == null) 
        {
            doAPICall();
        }

        PointsHandler.Instance.TextWeather.text = info.weather[0].description;
    }

    private void doAPICall() 
    {
        info = APIHandler.Instance.GetWeather(data.id);
    }


    public void ToggleRenderer() 
    {

        rndr.enabled = !rndr.enabled;
        if (rndr.enabled)
        {
            transform.localScale *= 0.5f;
        }
        else 
        {
            transform.localScale *= 2f;
        }
    }

}
