using System;

namespace GenericsIntro
{
    class MyList<T>
    {

        T[] items;

        //constructor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            //geçici dizinin referansı, items'ın referansı demek.
            //new array tanımlamadan önce yapıyoruz ki önceki elemanlar uçmasın.

            items = new T[items.Length + 1];
            //ekle fonk. çalıştırırken eleman sayısını bir arttırmak.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //tempArray'in elemanlarını items'a geri aktarmak için.

            items[items.Length - 1] = item;
            //eklemek istediğimiz elemanı ekleme işlemi
        }
    }
}
