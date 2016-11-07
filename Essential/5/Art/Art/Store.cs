using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art
{
    class Store
    {
            private Article[] articls;

            public Store(int size)
            {
                articls = new Article[Math.Abs(size)];
            }

            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < articls.Length)
                        return articls[index].Info();
                    return "Попытка обращения за пределы массива.";
                }
            }

            public void AddArticle(Article value, int index)
            {
                if (index >= 0 && index < articls.Length)
                    articls[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }

            public string this[string index]
            {
                get
                {
                    for (int i = 0; i < articls.Length; i++)
                        if (articls[i].Name == index)
                            return articls[i].Info();

                    return string.Format("\"{0}\" нет в наличии.", index);
                }
            }

            public void Show()
            {
                for (int i = 0; i < articls.Length; i++)
                    Console.WriteLine(articls[i].Info());
            }

            public void Sort()
            {
                for (int i = 0; i <= articls.Length - 1; i++)
                {
                    for (int q = 0; q <= articls.Length - 1; q++)
                    {
                        if (articls[i].Cost <= articls[q].Cost)
                        {
                            Article g = articls[i];
                            articls[i] = articls[q];
                            articls[q] = g;
                        }
                    }


                }
            }

        }
    }