using UnityEngine;

public class Mensch : MonoBehaviour
{

    public string personenName;
    public string rollenKlasse;
    public Color augenfarbe;
    [SerializeField] private GameObject myPrefab;
    [SerializeField]
    private AudioSource myAudioSource;

    void Start()
    {
        Debug.Log("Mein Name: " + personenName);
        Debug.Log("Meine Rolle: " + rollenKlasse);
        Debug.Log("Meine Augenfarbe: " + augenfarbe);
        myAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Sobald die Leertaste gedrueckt wird
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Leertaste gedrueckt!");
            myAudioSource.Play();
        } else if(Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Leertaste nicht mehr gedrueckt!");
            myAudioSource.Pause();
        }
    }
}
