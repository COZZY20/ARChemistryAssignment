using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemicalReaction : MonoBehaviour
{
    public ParticleSystem part;
    public List<ParticleCollisionEvent> collisionEvents;

    public Renderer chemicalRenderer;
    public float speed = 0.005f;
    public Color startColor, endColor;
    float startTime;
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.name == "Sodium")
        {
            other.GetComponent<Renderer>().material.color = Color.Lerp(other.GetComponent<Renderer>().material.color, Color.clear, 0.01f);          
        }
        Debug.Log("Collided with " + other.name);           
    }
}
