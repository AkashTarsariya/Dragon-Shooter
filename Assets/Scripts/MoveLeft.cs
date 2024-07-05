using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5f;

    private Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);

        if (transform.position.x < -15)
        {
            transform.position += new Vector3(30, 0, 0);
            ShowRandomSprite();
            enemy?.Respawn(); 
        }
        
    }

    private void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;

            child.gameObject.SetActive(shouldShow);
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
