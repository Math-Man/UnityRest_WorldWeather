using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class APIHandler
{

    public static APIHandler Instance;

    public City[] cities;

    public APIHandler() 
    {
        Instance = this;
    }

    private const string API_KEY = "";

    public WeatherInfo GetWeather(int cityId) 
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&forecastHours=0&APPID={1}", cityId, API_KEY));
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        WeatherInfo info = JsonUtility.FromJson<WeatherInfo>(jsonResponse);
        return info;
    }

    public void ReadCities()    
    {
        var filePath = Path.Combine(Application.streamingAssetsPath + "/", "current.city.list.json");

        StreamReader reader = new StreamReader(filePath);
        string jsonResponse = reader.ReadToEnd();

        var city = JsonUtility.FromJson<CityCollection>(jsonResponse);

        Debug.Log(city.Cities.Length);
        cities = city.Cities;
    }



}
