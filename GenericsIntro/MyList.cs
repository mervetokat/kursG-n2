using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
  class MyList<T>//istenilen veri tipi girilebilir
    {
        T[] items;
        public MyList()//ctor tap tap ile yapıldı bunun adı constructure dir otomatik çslısır
        {
                items = new T[0];
        }
        public void Add(T item)//item eleman demek
        {
            T[] tempArray= items;//elemanların adresini tutar
            items=new T[items.Length+1];//eleman sayısı +1
            for (int i = 0; i <tempArray.Length; i++) 
            {
                items[i] = tempArray[i];//ömceki dızıdeki elemanları üstüne yazdı ve gecmiş elemanlar ucmadı
            }
            items[items.Length-1] = item;//lengtht eleman sayısı oyuzden -1
        }
        public int Lenght
        { 
            get { return items.Length; } 
        }
        public T[] Items
        { get { return items; } }
    }
}
