using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidb;

    SpriteRenderer spriteRend;

    [SerializeField]
    Manager m;

    [SerializeField]
    Sprite standardSprite;

    [SerializeField]
    Sprite collectedSprite;

    [SerializeField]
    float speed;

    bool carryingGeschenk;

    private void Start()
    {
        rigidb = GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();

        spriteRend.sprite = standardSprite;

    }

   
    private void FixedUpdate()
    {
      
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal")* (speed/4));

        // Bewegung nach vorn und hinten
        rigidb.velocity = transform.rotation * new Vector2(0, Input.GetAxis("Vertical") * speed);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Womit wird collidiert
        if(collision.CompareTag("Tile"))
        {
            spriteRend.sprite = collectedSprite;
            Destroy(collision.gameObject);
            carryingGeschenk = true;
        }
        else if (collision.CompareTag("Droppoint") && carryingGeschenk)
        {
            spriteRend.sprite = standardSprite;
            m.SpawnTile();
            Manager.presentCounter++;
            carryingGeschenk = false;

        }
    }
}