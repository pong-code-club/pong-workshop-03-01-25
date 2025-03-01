using UnityEngine;

//Types of words in programming
//Identifier - the name or label of the box for your information
//Data Types - what type of information something is
//Punctuation marks - gives structure to the code
//Reserved Keywords - public, void, using - they have special meaning in the programming language
//Operators - math functions or logical operator +,-,*,/,>,<,==,=
//Literal Values - just typing a value of a primitive - true/false, integer numbers, float numbers, string

public class PaddleScript : MonoBehaviour
{
    public Transform MyTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MyTransform.Translate(10 * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MyTransform.Translate(-10 * Time.deltaTime, 0, 0);
        }
    }
}
