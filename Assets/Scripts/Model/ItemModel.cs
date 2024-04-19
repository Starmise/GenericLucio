using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemModel<T>
{
    public T itemEffect;

    public ItemModel(T effect)
    {
        itemEffect = effect;
    }
}
