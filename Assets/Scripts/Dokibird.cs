using UnityEngine;

public class Dokibird : MonoBehaviour
{
    public bool isRed;

    [SerializeField] private AudioClip yay;
    [SerializeField] private AudioClip test;
    [SerializeField] private AudioClip whoisthat;
    public Animator animator;
    public bool isThereASound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isThereASound = false;

        if (isRed)
        {
            animator.SetBool("red", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckForSounds();

        if (isThereASound == false)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("A");
                SoundFXManager.instance.PlaySoundFXClip(yay, transform, 1f);
                animator.SetBool("neutral", true);
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("B");
                SoundFXManager.instance.PlaySoundFXClip(test, transform, 1f);
                animator.SetBool("angry", true);
            }

            if (Input.GetKey(KeyCode.C))
            {
                SoundFXManager.instance.PlaySoundFXClip(whoisthat, transform, 1f);
                animator.SetBool("suprised", true);
            }
        }

    }

    private void CheckForSounds()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("DokiSound");

        if (gameObjects.Length > 0)
        {
            isThereASound = true;
        }
        else
        {
            isThereASound = false;
            animator.SetBool("neutral", false);
            animator.SetBool("angry", false);
            animator.SetBool("suprised", false);
        }
    }
}
