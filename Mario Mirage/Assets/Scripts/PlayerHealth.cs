using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;
    public bool hasDied;
    
    // Start is called before the first frame update
    void Start()
    {
        hasDied = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -7 && !hasDied)
        {
            hasDied = true;
            Debug.Log("Dead Inside!!");
            StartCoroutine("Die");
        }
    }

    IEnumerator Die ()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("TrialScene");
        yield return null;
    }
}
