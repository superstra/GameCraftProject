using System.Collections.Generic;

public class CheckList {
    static List<ListItem> items = new List<ListItem>();

    public static void add(ListItem item) {
        items.Add(item);
    }

    public static void remove(ListItem item) {
        if (items.Contains(item)) {
            items.Remove(item);
        }
    }

    public static void clear() {
        items.Clear();
    }

    public static ListItem get(string name) {
        ListItem i = null;
        items.ForEach(delegate (ListItem item) { 
            if (item.name.Equals(name)) {
                i = item;
            }
        });

        return i;
    }

    public static List<ListItem> GetAllItems() {
        List<ListItem> list = new List<ListItem>();
        foreach (ListItem item in items) {
            list.Add(item);
        }
        return list;
    }
}
