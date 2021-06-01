using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 direction;
    public float playerSpeed;
    public GameObject particleEffectsPrefab;
    public Text scoreText;
    public int score=0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (direction == Vector3.forward)
            {
                direction = Vector3.left;

            }
            else
            {
                direction = Vector3.forward;
            }
        }
        transform.Translate(direction * playerSpeed * Time.deltaTime);

        scoreText.text = "Score : " + score;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUpCoin")
        {
           
            other.gameObject.SetActive(false);
            score = score + 5;
            Instantiate(particleEffectsPrefab, transform.position, Quaternion.identity);
            
        }
    }

}
