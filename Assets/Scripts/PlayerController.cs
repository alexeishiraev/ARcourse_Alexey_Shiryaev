using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 1000f;
    [SerializeField] private Camera mainCamera = null;

    private Renderer objRenderer;
    private Vector3 cameraOffset; // смещение камеры относительно объекта

    // Start is called before the first frame update
    void Start()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;
      
        objRenderer = GetComponent<Renderer>();

        // задаем начальное смещение камеры относительно объекта
        cameraOffset = mainCamera.transform.position - transform.position;

        // сразу направляем камеру на объект
        mainCamera.transform.LookAt(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleRotation();
        HandleColorChange();
        UpdateCamera();
    }

    void HandleMovement()
    {
        float move = 0f; // задаем направление движения
        if (Input.GetKey(KeyCode.W))
        {
            move = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            move = -1f;
        }
        transform.Translate(Vector3.forward * move * moveSpeed * Time.deltaTime);
    }

    void HandleRotation()
    {
        float rotation = 0f; // задаем направление вращения
        if (Input.GetKey(KeyCode.A))
        {
            rotation = 1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotation = -1f;
        }
        transform.Rotate(Vector3.right, rotation * rotationSpeed * Time.deltaTime);
    }

    void HandleColorChange()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            objRenderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }

    void UpdateCamera()
    {
        mainCamera.transform.LookAt(transform.position);
    }


}
