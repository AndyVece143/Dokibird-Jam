using UnityEngine;

public class Dokibird : MonoBehaviour
{
    public bool isRed;

    [SerializeField] private AudioClip yay;
    [SerializeField] private AudioClip test;
    [SerializeField] private AudioClip whoisthat;
    [SerializeField] private AudioClip fingStupid;
    [SerializeField] private AudioClip hawkTuah;
    [SerializeField] private AudioClip dontCare;
    [SerializeField] private AudioClip jesus;
    [SerializeField] private AudioClip laugh;
    [SerializeField] private AudioClip likeAChain;
    [SerializeField] private AudioClip ohGod;
    [SerializeField] private AudioClip thatsAlright;
    [SerializeField] private AudioClip woahNo;
    [SerializeField] private AudioClip iAmSad;

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
            //Neutral
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Debug.Log("1");
                int i = Random.Range(0, 2);
                if (i == 0)
                {
                    SoundFXManager.instance.PlaySoundFXClip(likeAChain, transform, 1f);
                }
                else
                {
                    SoundFXManager.instance.PlaySoundFXClip(hawkTuah, transform, 1f);
                }
                animator.SetBool("neutral", true);
                ChangeStatus("neutral");
            }

            //Suprised
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Debug.Log("2");
                SoundFXManager.instance.PlaySoundFXClip(whoisthat, transform, 1f);
                animator.SetBool("suprised", true);
                ChangeStatus("suprised");
            }

            //Shocked
            if (Input.GetKey(KeyCode.Alpha3))
            {
                Debug.Log("3");
                int i = Random.Range(0, 2);
                if (i == 0)
                {
                    SoundFXManager.instance.PlaySoundFXClip(woahNo, transform, 1f);
                }
                else
                {
                    SoundFXManager.instance.PlaySoundFXClip(jesus, transform, 1f);
                }
                animator.SetBool("shocked", true);
                ChangeStatus("shocked");
            }

            //Angry
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                Debug.Log("4");
                SoundFXManager.instance.PlaySoundFXClip(ohGod, transform, 1f);
                animator.SetBool("angry", true);
                ChangeStatus("angry");
            }

            //Side Eye
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                Debug.Log("5");
                SoundFXManager.instance.PlaySoundFXClip(thatsAlright, transform, 1f);
                animator.SetBool("sideeye", true);
                ChangeStatus("sideeye");
            }

            //Crying
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                Debug.Log("6");
                SoundFXManager.instance.PlaySoundFXClip(iAmSad, transform, 1f);
                animator.SetBool("crying", true);
                ChangeStatus("crying");
            }

            //Disgusted
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                Debug.Log("7");
                int i = Random.Range(0, 2);
                if (i == 0)
                {
                    SoundFXManager.instance.PlaySoundFXClip(dontCare, transform, 1f);
                }
                else
                {
                    SoundFXManager.instance.PlaySoundFXClip(fingStupid, transform, 1f);
                }
                animator.SetBool("disgusted", true);
                ChangeStatus("disgusted");
            }

            //Excited
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                Debug.Log("8");
                SoundFXManager.instance.PlaySoundFXClip(yay, transform, 1f);
                animator.SetBool("excited", true);
                ChangeStatus("excited");
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
            animator.SetBool("sideeye", false);
            animator.SetBool("crying", false);
            animator.SetBool("shocked", false);
            animator.SetBool("disgusted", false);
            animator.SetBool("excited", false);
            ChangeStatus("idle");
        }
    }

    private void ChangeStatus(string emote)
    {
        status = emote;
    }
}
