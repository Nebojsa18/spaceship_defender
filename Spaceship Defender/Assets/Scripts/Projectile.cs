using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    public GameObject explosionPrefab; 
    private PointManager pointManager;

    public AudioSource audioExplosion;
    
    private bool hasCollided = false;

    public static int enemyShips = 8;

    // Start is called before the first frame update
    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * -moveSpeed * Time.deltaTime);
    }


    //In next function, first of all we chechk if projectile has already colided, if not, it continues
    //It plays an audioClip, and after that it destroys enemy ship, updates score, disable rendering and distroy itself after
    //the sound has finished playing. It will not collide nor destroy any other object because it will check if condition only once. 
    
    private void OnTriggerEnter2D(Collider2D collision) {

        if (hasCollided)
            return;

        if(collision.gameObject.tag =="Enemy"){
            
            Instantiate(explosionPrefab,transform.position,Quaternion.identity);
            
            audioExplosion.Play();
            
            Destroy(collision.gameObject);
            pointManager.UpdateScore(50);
            
            Renderer renderer = GetComponent<Renderer>();
            renderer.enabled = false;

            Destroy(gameObject, audioExplosion.clip.length);
            hasCollided = true;
            
            enemyShips--;
            if(enemyShips==0){
                SceneManager.LoadScene("Winner");
            }
            
            
        }

        if(collision.gameObject.tag =="Border"){
            Destroy(gameObject);
        }

    }

}
