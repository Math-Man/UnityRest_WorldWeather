using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsHandler : MonoBehaviour
{
    public static PointsHandler Instance;

    public List<CityDataNode> nodes;

    [SerializeField] private GameObject PointPrefab;
    [SerializeField] private GameObject Holder;
    [SerializeField] public Text TextCityName;
    [SerializeField] public Text TextLonLat;
    [SerializeField] public Text TextWeather;

    private void Awake()
    {
        nodes = new List<CityDataNode>();
        Instance = this;
        new APIHandler();
        APIHandler.Instance.ReadCities();
    }

    void Start()
    {
        foreach (City c in APIHandler.Instance.cities) 
        {
            Vector2 v = new Vector2(c.coord.lat, c.coord.lon);
            Vector3 pointPosition = Quaternion.AngleAxis(c.coord.lon, -Vector3.up) * Quaternion.AngleAxis(c.coord.lat, -Vector3.right) * new Vector3(0, 0, 250);
            GameObject point = Instantiate(PointPrefab, pointPosition, Quaternion.identity, Holder.transform);
            CityDataNode pointData = point.GetComponentInChildren<CityDataNode>();
            pointData.data = c;
            Debug.Log(v.x + " " + v.y);
            nodes.Add(pointData);
        }
    }


    public void TogglePointsVisual() 
    {
        foreach (CityDataNode nd in nodes) 
        {
            nd.ToggleRenderer();
        }
    }



}
