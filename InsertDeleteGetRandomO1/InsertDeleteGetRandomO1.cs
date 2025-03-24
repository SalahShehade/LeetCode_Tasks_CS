public class RandomizedSet
{

    private Dictionary<int, int> map;
    private List<int> list;
    private Random rand;

    public RandomizedSet()
    {
        map = new Dictionary<int, int>();
        list = new List<int>();
        rand = new Random();
    }

    public bool Insert(int val)
    {

        if (map.ContainsKey(val)) return false;

        map[val] = list.Count;
        list.Add(val);
        return true;


    }

    public bool Remove(int val)
    {
        if (!map.ContainsKey(val)) return false;

        int index = map[val];
        int lastOne = list[^1];

        list[index] = lastOne;
        map[lastOne] = index;

        list.RemoveAt(list.Count - 1);
        map.Remove(val);
        return true;


    }

    public int GetRandom()
    {
        int randomIndex = rand.Next(list.Count);
        return list[randomIndex];
    }
}
