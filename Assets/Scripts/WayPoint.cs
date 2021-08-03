using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    [SerializeField] bool isPlacable;
    public bool IsPlaceable { get { return isPlacable; } }

    [SerializeField] Tower towerprefab;
    void OnMouseDown()
    {
        if (isPlacable)
        {
            bool isPlaced = towerprefab.CreateTower(towerprefab, transform.position);
            isPlacable = !isPlaced;

        }
    }

}
