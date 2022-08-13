using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_CS_study
{   //Lambda : 일회용 함수를 만드는데 사용하는 문법.
    enum ItemType // 아이템 타입
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity // 레어한 정도
    {
        Normal,
        Uncommon,
        Rare,
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }
    class Program
    {
        static List<Item> _items = new List<Item>();
        static Item FindItem(Func<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }
 

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            Func<Item, bool> selector = (Item i) => { return i.ItemType == ItemType.Weapon; };
            // 함수의 실행결과값(bool타입)을 sslector 개체에 집어넣는다.

            Item item = FindItem(selector);
            // FindItem함수에 객체 selector 를 인자로 넣어 값을 item 개체에 넣는다.
        }
    }
}
