using UnityEngine;
using Materials;


public class Material_Hander : MonoBehaviour,IMaterial
{
    // iV.Interface

    public float materialQuantity()
    {
        throw new System.NotImplementedException();
        float materialQuantity = 20.5f;
    }

    public void materialFinish()
    {
        Debug.Log("Done!");
    }



    private Material_Class concrete, bricks, timber;
    // Start is called before the first frame update
    void Start()
    {
        concrete = new Material_Class("Concrete", "R.C Framed Structure", 56.0f);
        bricks = new Material_Class("Bricks", "Masonry Structure", 77.0f);
        timber = new Material_Class("Timber","Wooden Framed Structure",14.0f);

        

    
}





    // Update is called once per frame
    void Update()
    {
        //Debug.Log(concrete.GetStructure());
        //Debug.Log(bricks.GetQuantity());
        //Debug.Log(timber.GetQuantity());

    }
}
