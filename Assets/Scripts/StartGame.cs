using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Базовые типы
    [SerializeField] private int myInt = 100;
    [SerializeField] private float myFloat;
    [SerializeField] private string myString = "Hello";
    [SerializeField] private bool _isOnScene;
    [SerializeField] private Vector3 myVector;
    [SerializeField] private Color myColor;


    // Коллекция
    [SerializeField] private List<GameObject> objectsList;


    // Префаб для создания
    [SerializeField] private GameObject prefabToScene;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefabToScene);
        // 2. Включаем все объекты из списка
        foreach (var obj in objectsList)
        {
            if (obj != null)
                obj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
