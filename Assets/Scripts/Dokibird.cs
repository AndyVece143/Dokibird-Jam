using UnityEngine;

public class Dokibird : MonoBehaviour
{
    public bool isRed;

    [SerializeField] private AudioClip yay;
    [SerializeField] private AudioClip test;
    [SerializeField] private AudioClip whoisthat;
    public Animator animator;
    public bool isThereASound;
    public string status;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isThereASound = false;
        status = "idle";

        isRed = StaticData.valueToKeep;

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
                ChangeStatus("neutral");
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("B");
                SoundFXManager.instance.PlaySoundFXClip(test, transform, 1f);
                animator.SetBool("angry", true);
                ChangeStatus("angry");
            }

            if (Input.GetKey(KeyCode.C))
            {
                SoundFXManager.instance.PlaySoundFXClip(whoisthat, transform, 1f);
                animator.SetBool("suprised", true);
                ChangeStatus("suprised");
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
            ChangeStatus("idle");
        }
    }

    private void ChangeStatus(string emote)
    {
        status = emote;
    }
}
