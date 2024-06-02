using UnityEngine;
using UnityEngine.EventSystems;

public class Clicker : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private int productivity = 1;
    [SerializeField] private int price = 20;

    private int count = 0;
    private int profit => productivity;

    public void TakeMoney(int profit)
    {
        count += profit;
        Debug.Log("Возьми печеньки!");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        TakeMoney(profit);
        Debug.Log(count);
    }
    /*   public static void BuyFactory(int price, int productivity)
       {
           count -= price;
           profit += productivity;
           Debug.Log("Купил завод!");
       }
    */
}
