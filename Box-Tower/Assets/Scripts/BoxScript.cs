using UnityEngine;

public class BoxScript : MonoBehaviour
{
    private float minX = -2.2f;
    private float maxX = 2.2f;

    private bool canMove;
    private float speed = 2f;

    private Rigidbody2D myBody;

    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0f;
    }

    void Start()
    {
        canMove = true;

        if (Random.Range(0, 2) > 0)
        {
            speed *= -1f;
        }

        GameplayController.instance.currentBox = this;
    }

    // Update is called once per frame
    void Update()
    {
        MoveBox();
    }

    private void MoveBox()
    {
        if (canMove)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;

            if (temp.x > maxX)
            {
                speed *= -1f;

            }
            else if (temp.x < minX)
            {
                speed *= -1f;
            }

            transform.position = temp;
        }
    }

    public void DropBox()
    {
        canMove = false;
        myBody.gravityScale = Random.Range(2, 4);
    }
}
