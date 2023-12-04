using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<Car> cars;

    private int numberCarList;

    private void Awake()
    {
        numberCarList = cars.Count;

    }
    public int GetNumberCarList()
    {
        return numberCarList;
    }

    public void DestroyCarById(int id)
    {
        for (int i = 0; i < cars.Count; i++)
        {
            if (cars[i].GetUniqueId() == id)
            {
                cars[i].DestroySelf();
                numberCarList -= 1;
            }
        }
    }

    public static List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
