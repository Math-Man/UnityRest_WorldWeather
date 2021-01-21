using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Weather
{

    public int id;
    public string main;
    public string description;
}

[Serializable]
public class WeatherInfo
{

    public int id;
    public string name;
    public List<Weather> weather;
}

[Serializable]
public class City 
{
    public int id;
    public string name;
    public Coord coord;
}

[Serializable]
public class Coord
{
    public float lon;
    public float lat;
}



[Serializable]
public class CityCollection
{
    public City[] Cities;
}