using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
[SerializeField] private GameObject enemyPrefab;
private GameObject enemy;
    void Start()
    {
        
    }

    void Update()
    {
     if (enemy == null)
        {
          enemy = Instantiate(enemyPrefab) as GameObject;
         enemy.transform.position = new Vector3(0, 1, 0);
         float angle = Random.Range(0, 360);
          enemy.transform.Rotate(0, angle, 0);

          // Assign a random height between 2 and 3
          float height = Random.Range(2f, 3f);
          enemy.transform.localScale = new Vector3(1, height, 1);

         // Assign a random color
          Renderer renderer = enemy.GetComponent<Renderer>();
          if (renderer != null)
          {
            renderer.material.color = Random.ColorHSV();
          }
         }
    }
}
