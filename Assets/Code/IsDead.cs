using UnityEngine;
using System.Collections;
using System;

public class IsDead : StateMachineBehaviour {
    int Playerdie = Animator.StringToHash("PlayerDie");
    Animator anim;
    void Start()
    {
       anim = GetComponent<Animator>();
    }

    private T GetComponent<T>()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    bool Update()
    {
        GameObject Text = GameObject.Find("Text");
        HealthScript targetScript = Text.GetComponent<HealthScript>();
        if (targetScript.Health <= 0)
        {
            anim.SetTrigger(Playerdie);
            return true;
        }
        else
        {
            return false;
        }
    }
}

