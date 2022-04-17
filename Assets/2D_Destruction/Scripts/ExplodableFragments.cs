using UnityEngine;
using System.Collections.Generic;

public class ExplodableFragments : ExplodableAddon{
    public override void OnFragmentsGenerated(List<GameObject> fragments)
    {
        foreach (GameObject fragment in fragments)
        {
            Explodable fragExp = fragment.AddComponent<Explodable>();
			fragment.AddComponent<ExplodeOnClick>();

            fragExp.shatterType = explodable.shatterType;
            fragExp.fragmentLayer = explodable.fragmentLayer;
            fragExp.sortingLayerName = explodable.sortingLayerName;
            fragExp.orderInLayer = explodable.orderInLayer;
            fragExp.transform.parent = explodable.Parent;
            fragExp.Parent = explodable.Parent;
            fragment.layer = explodable.gameObject.layer;

            fragExp.fragmentInEditor();
        }
    }
}
