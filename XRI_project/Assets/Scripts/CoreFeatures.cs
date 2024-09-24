using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FeatureUsage
{
    Once, //use once
    Toggle //use features more than once
}

public class CoreFeatures : MonoBehaviour
{
    //Properties: work like variables, declared same way, but formatted different. Common way to access code outside of this script
    //You can create a public variable to access them in another script, or you can create properties.

    //OOP 4 pillars: Inheritance, Encapsulation, Polymorphism, Abstraction

    //Properties are encapulated & formatted as fields
    //Properties have 2 accessories: GET accessor (is a read only value) returns other encapsulated variable. SET accessor (Write only value) allocates values to a property
    //Property names are Pascal Case --> PropertyName

    //enum is a numeric value assigned to a word. More about making things more readable. SET UP ABOVE MONOBEHAVIOR

    public bool AudioSFXSourceCreated { get; set; }

    //Audio plays when door opens
    [field: SerializeField]
    public AudioClip AudioClipOnStart { get; set; }

    //Audio plays on close
    [field: SerializeField]
    public AudioClip AudioClipOnEnd { get; set; }

    private AudioSource audioSource;

    public FeatureUsage featureUsage = FeatureUsage.Once;

    protected virtual void Awake()
    {
        //MakeSFXAudioSource();
    }

    private void MakeSFXAudioSource()
    {
        //if this is equal to null, create it here

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }
}
