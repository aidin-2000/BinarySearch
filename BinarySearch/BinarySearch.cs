using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    public class BinarySearchClass
    {
        public Element main(TextBox tb, string value)
        {
            checkErrors(tb, value);
            List<Element> element= new List<Element>();
            int i = 0;  
            for (i = 0; i < tb.Lines.Length; i++)
            {
                Element tempEl = new Element();
                tempEl.id = i+1;
                tempEl.value = tb.Lines[i];
                element.Add(tempEl);
            }
            element.Sort((el1, el2) => el1.value.CompareTo(el2.value));
            Element result = binarySearch(element, value);
            
            if (result.id == -1)
            {
                throw new Exception("В указанном наборе искомый элемент не был найден.");
            }
            return result;
        }

        public Element binarySearch(List<Element> element, string searchValue)
        {
            int left = 0;
            int right = element.Count() - 1;
            int mid;
            
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (searchValue.CompareTo(element[mid].value)<0)
                {
                    right = mid - 1;
                }
                else if(searchValue.CompareTo(element[mid].value) > 0)
                {
                    left = mid + 1;
                }
                else
                {
                    return element[mid];
                }
            }
            Element el = new Element();
            el.id = -1;
            return el;
        }

        public bool checkEmptyString(string str)
        {
            if (str == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkEmptyDataSet(TextBox TB)
        {
            if (TB.Lines.Length < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkMaxSizeDataSet(TextBox TB)
        {
            if (TB.Lines.Length > 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public void checkErrors(TextBox tb, string value)
        {
            if (checkEmptyString(value))
            {
                throw new Exception("Ошибка. Введите искомое значение.");
            }
            if (checkEmptyDataSet(tb))
            {
                throw new Exception("Ошибка. Набор для поиска должен иметь 1 и более элемент. Введите набор для поиска.");
            }
            if (checkMaxSizeDataSet(tb))
            {
                throw new Exception("Ошибка. Исходный набор имеет более 30 элементов.");
            }
        }
    }
}
