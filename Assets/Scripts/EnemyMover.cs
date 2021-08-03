using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    [SerializeField] [Range(0f, 5f)] float speed = 1f;

    Enemy enemy;

    void OnEnable()
    {
        FindPath();
        ReturnToStart();
        StartCoroutine(PrintwaypointName());
    }

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }
    void FindPath()
    {
        path.Clear();
        GameObject parent = GameObject.FindGameObjectWithTag("Path");

        foreach (Transform child in parent.transform)
        {
            WayPoint waypoint = child.GetComponent<WayPoint>();

            if(waypoint != null)
            {
                path.Add(waypoint);
            }

        }
    }
    void ReturnToStart()
    {
        transform.position = path[0].transform.position;
    }
    void FinishPath()
    {
        enemy.StealGold();
        gameObject.SetActive(false);
    }
    IEnumerator PrintwaypointName()
    {
        foreach (WayPoint waypoint in path)
        {
            Vector3 Startposition = transform.position;
            Vector3 EndPosition = waypoint.transform.position;
            float Travelpercent = 0f;

            transform.LookAt(EndPosition);

            while (Travelpercent < 1f)
            {
                Travelpercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(Startposition, EndPosition, Travelpercent);
                yield return new WaitForEndOfFrame();
            }
        }
        FinishPath();
    }
}

