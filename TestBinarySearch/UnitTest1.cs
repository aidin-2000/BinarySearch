using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BinarySearch;
using System.Windows.Forms;

namespace TestBinarySearch
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void emptyDataSet()
        {
            TextBox textbox=new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("");
            string searchValue="235";
            string expected = "Ошибка. Набор для поиска должен иметь 1 и более элемент. Введите набор для поиска.";
            try
            {
                BinarySearchClass BS = new BinarySearchClass();
                BS.main(textbox, searchValue);
            }    
            catch(Exception ex)
            {
                StringAssert.Contains(ex.Message, expected);
            }
        }

        [TestMethod]
        public void emptySearchElement()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("445"+ Environment.NewLine);
            textbox.AppendText("254" + Environment.NewLine);
            textbox.AppendText("256" + Environment.NewLine);
            textbox.AppendText("459" + Environment.NewLine);
            textbox.AppendText("245" + Environment.NewLine);
            textbox.AppendText("258" + Environment.NewLine);
            textbox.AppendText("652" + Environment.NewLine);
            textbox.AppendText("456" + Environment.NewLine);
            textbox.AppendText("652" + Environment.NewLine);
            string searchValue = "";
            string expected = "Ошибка. Введите искомое значение.";
            try
            {
                BinarySearchClass BS = new BinarySearchClass();
                BS.main(textbox, searchValue);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, expected);
            }
        }

        [TestMethod]
        public void maxSizeDataSet()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("111" + Environment.NewLine);
            textbox.AppendText("222" + Environment.NewLine);
            textbox.AppendText("333" + Environment.NewLine);
            textbox.AppendText("444" + Environment.NewLine);
            textbox.AppendText("555" + Environment.NewLine);
            textbox.AppendText("666" + Environment.NewLine);
            textbox.AppendText("777" + Environment.NewLine);
            textbox.AppendText("888" + Environment.NewLine);
            textbox.AppendText("999" + Environment.NewLine);
            textbox.AppendText("1000" + Environment.NewLine);
            textbox.AppendText("121" + Environment.NewLine);
            textbox.AppendText("232" + Environment.NewLine);
            textbox.AppendText("323" + Environment.NewLine);
            textbox.AppendText("424" + Environment.NewLine);
            textbox.AppendText("525" + Environment.NewLine);
            textbox.AppendText("626" + Environment.NewLine);
            textbox.AppendText("727" + Environment.NewLine);
            textbox.AppendText("828" + Environment.NewLine);
            textbox.AppendText("929" + Environment.NewLine);
            textbox.AppendText("1200" + Environment.NewLine);
            textbox.AppendText("131" + Environment.NewLine);
            textbox.AppendText("232" + Environment.NewLine);
            textbox.AppendText("343" + Environment.NewLine);
            textbox.AppendText("454" + Environment.NewLine);
            textbox.AppendText("545" + Environment.NewLine);
            textbox.AppendText("646" + Environment.NewLine);
            textbox.AppendText("747" + Environment.NewLine);
            textbox.AppendText("848" + Environment.NewLine);
            textbox.AppendText("949" + Environment.NewLine);
            textbox.AppendText("1400" + Environment.NewLine);
            textbox.AppendText("1600" + Environment.NewLine);
            // textbox.AppendText("UUU" + Environment.NewLine);
            string searchValue = "454";
            string expected = "Ошибка. Исходный набор имеет более 30 элементов.";
            try
            {
                BinarySearchClass BS = new BinarySearchClass();
                BS.main(textbox, searchValue);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, expected);
            }
        }

        [TestMethod]
        public void notFounded()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("445" + Environment.NewLine);
            textbox.AppendText("254" + Environment.NewLine);
            textbox.AppendText("256" + Environment.NewLine);
            textbox.AppendText("459" + Environment.NewLine);
            textbox.AppendText("245" + Environment.NewLine);
            textbox.AppendText("258" + Environment.NewLine);
            textbox.AppendText("652" + Environment.NewLine);
            textbox.AppendText("456" + Environment.NewLine);
            textbox.AppendText("652" + Environment.NewLine);
            string searchValue = "111";
            string expected = "В указанном наборе искомый элемент не был найден.";
            try
            {
                BinarySearchClass BS = new BinarySearchClass();
                BS.main(textbox, searchValue);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, expected);
            }
        }

        [TestMethod]
        public void SortedEvenCenter()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("111" + Environment.NewLine);
            textbox.AppendText("222" + Environment.NewLine);
            textbox.AppendText("333" + Environment.NewLine);
            textbox.AppendText("444" + Environment.NewLine);
            textbox.AppendText("555" + Environment.NewLine);
            textbox.AppendText("666" + Environment.NewLine);
            textbox.AppendText("777" + Environment.NewLine);
            textbox.AppendText("888" + Environment.NewLine);
            textbox.AppendText("999" + Environment.NewLine);
            textbox.AppendText("1000" + Environment.NewLine);
            string searchValue = "555";
            Element expected = new Element();
            expected.id = 5;
            expected.value ="555";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }
        [TestMethod]
        public void UnsortedOddCenter()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("222" + Environment.NewLine);
            textbox.AppendText("111" + Environment.NewLine);
            textbox.AppendText("666" + Environment.NewLine);
            textbox.AppendText("444" + Environment.NewLine);
            textbox.AppendText("555" + Environment.NewLine);
            textbox.AppendText("889" + Environment.NewLine);
            textbox.AppendText("778" + Environment.NewLine);
            textbox.AppendText("115" + Environment.NewLine);
            textbox.AppendText("665" + Environment.NewLine);
            textbox.AppendText("991" + Environment.NewLine);
            string searchValue = "889";
            Element expected = new Element();
            expected.id = 6;
            expected.value = "889";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }

        [TestMethod]
        public void SortedEvenRight()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("111" + Environment.NewLine);
            textbox.AppendText("222" + Environment.NewLine);
            textbox.AppendText("333" + Environment.NewLine);
            textbox.AppendText("444" + Environment.NewLine);
            textbox.AppendText("555" + Environment.NewLine);
            textbox.AppendText("666" + Environment.NewLine);
            textbox.AppendText("777" + Environment.NewLine);
            textbox.AppendText("888" + Environment.NewLine);
            textbox.AppendText("999" + Environment.NewLine);
            textbox.AppendText("1000" + Environment.NewLine);
            string searchValue = "1000";
            Element expected = new Element();
            expected.id = 10;
            expected.value = "1000";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }

        [TestMethod]
        public void SortedEvenLeft()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("111" + Environment.NewLine);
            textbox.AppendText("222" + Environment.NewLine);
            textbox.AppendText("333" + Environment.NewLine);
            textbox.AppendText("444" + Environment.NewLine);
            textbox.AppendText("555" + Environment.NewLine);
            textbox.AppendText("666" + Environment.NewLine);
            textbox.AppendText("777" + Environment.NewLine);
            textbox.AppendText("888" + Environment.NewLine);
            textbox.AppendText("999" + Environment.NewLine);
            textbox.AppendText("1000" + Environment.NewLine);
            string searchValue = "111";
            Element expected = new Element();
            expected.id = 1;
            expected.value = "111";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }

        [TestMethod]
        public void UnsortedOddRight()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("222" + Environment.NewLine);
            textbox.AppendText("111" + Environment.NewLine);
            textbox.AppendText("666" + Environment.NewLine);
            textbox.AppendText("444" + Environment.NewLine);
            textbox.AppendText("555" + Environment.NewLine);
            textbox.AppendText("889" + Environment.NewLine);
            textbox.AppendText("778" + Environment.NewLine);
            textbox.AppendText("115" + Environment.NewLine);
            textbox.AppendText("665" + Environment.NewLine);
            textbox.AppendText("991" + Environment.NewLine);
            string searchValue = "115";
            Element expected = new Element();
            expected.id = 8;
            expected.value = "115";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }

        [TestMethod]
        public void UnsortedLeft()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("222" + Environment.NewLine);
            textbox.AppendText("111" + Environment.NewLine);
            textbox.AppendText("666" + Environment.NewLine);
            textbox.AppendText("444" + Environment.NewLine);
            textbox.AppendText("555" + Environment.NewLine);
            textbox.AppendText("889" + Environment.NewLine);
            textbox.AppendText("778" + Environment.NewLine);
            textbox.AppendText("115" + Environment.NewLine);
            textbox.AppendText("665" + Environment.NewLine);
            textbox.AppendText("991" + Environment.NewLine);
            string searchValue = "111";
            Element expected = new Element();
            expected.id = 2;
            expected.value = "111";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }

        [TestMethod]
        public void UnsortedEvenCenter()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("222" + Environment.NewLine);
            textbox.AppendText("111" + Environment.NewLine);
            textbox.AppendText("444" + Environment.NewLine);
            textbox.AppendText("555" + Environment.NewLine);
            textbox.AppendText("889" + Environment.NewLine);
            textbox.AppendText("778" + Environment.NewLine);
            textbox.AppendText("115" + Environment.NewLine);
            textbox.AppendText("665" + Environment.NewLine);
            textbox.AppendText("991" + Environment.NewLine);
            string searchValue = "889";
            Element expected = new Element();
            expected.id = 5;
            expected.value = "889";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }

        [TestMethod]
        public void SortedLowerLetCenter()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("aaa" + Environment.NewLine);
            textbox.AppendText("bbb" + Environment.NewLine);
            textbox.AppendText("ccc" + Environment.NewLine);
            textbox.AppendText("ddd" + Environment.NewLine);
            textbox.AppendText("eee" + Environment.NewLine);
            textbox.AppendText("fff" + Environment.NewLine);
            textbox.AppendText("ggg" + Environment.NewLine);
            textbox.AppendText("hhh" + Environment.NewLine);
            textbox.AppendText("iii" + Environment.NewLine);
            textbox.AppendText("kkk" + Environment.NewLine);
            string searchValue = "eee";
            Element expected = new Element();
            expected.id = 5;
            expected.value = "eee";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }

        [TestMethod]
        public void UnsortedUpperLetersRight()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("BBC" + Environment.NewLine);
            textbox.AppendText("ACB" + Environment.NewLine);
            textbox.AppendText("HGT" + Environment.NewLine);
            textbox.AppendText("FTH" + Environment.NewLine);
            textbox.AppendText("CDB" + Environment.NewLine);
            textbox.AppendText("AAA" + Environment.NewLine);
            textbox.AppendText("CDF" + Environment.NewLine);
            textbox.AppendText("FFH" + Environment.NewLine);
            textbox.AppendText("CCC" + Environment.NewLine);
            textbox.AppendText("LDD" + Environment.NewLine);
            string searchValue = "HGT";
            Element expected = new Element();
            expected.id = 3;
            expected.value = "HGT";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }

        [TestMethod]
        public void SortedLowerLettersLeft()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("aaa" + Environment.NewLine);
            textbox.AppendText("bbb" + Environment.NewLine);
            textbox.AppendText("ccc" + Environment.NewLine);
            textbox.AppendText("ddd" + Environment.NewLine);
            textbox.AppendText("eee" + Environment.NewLine);
            textbox.AppendText("fff" + Environment.NewLine);
            textbox.AppendText("ggg" + Environment.NewLine);
            textbox.AppendText("hhh" + Environment.NewLine);
            textbox.AppendText("iii" + Environment.NewLine);
            textbox.AppendText("kkk" + Environment.NewLine);
            string searchValue = "aaa";
            Element expected = new Element();
            expected.id = 1;
            expected.value = "aaa";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }

        [TestMethod]
        public void SortedLowerLettersRight()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("aaa" + Environment.NewLine);
            textbox.AppendText("bbb" + Environment.NewLine);
            textbox.AppendText("ccc" + Environment.NewLine);
            textbox.AppendText("ddd" + Environment.NewLine);
            textbox.AppendText("eee" + Environment.NewLine);
            textbox.AppendText("fff" + Environment.NewLine);
            textbox.AppendText("ggg" + Environment.NewLine);
            textbox.AppendText("hhh" + Environment.NewLine);
            textbox.AppendText("iii" + Environment.NewLine);
            textbox.AppendText("kkk" + Environment.NewLine);
            string searchValue = "kkk";
            Element expected = new Element();
            expected.id = 10;
            expected.value = "kkk";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }


       
        [TestMethod]
        public void SeveralFounded()
        {
            TextBox textbox = new TextBox();
            textbox.Multiline = true;
            textbox.AppendText("222" + Environment.NewLine);
            textbox.AppendText("111" + Environment.NewLine);
            textbox.AppendText("455" + Environment.NewLine);
            textbox.AppendText("444" + Environment.NewLine);
            textbox.AppendText("111" + Environment.NewLine);
            textbox.AppendText("758" + Environment.NewLine);
            textbox.AppendText("555" + Environment.NewLine);
            textbox.AppendText("114" + Environment.NewLine);
            textbox.AppendText("211" + Environment.NewLine);
            textbox.AppendText("668" + Environment.NewLine);
            string searchValue = "111";
            Element expected = new Element();
            expected.id = 5;
            expected.value = "111";
            BinarySearchClass BS = new BinarySearchClass();
            Element actual = BS.main(textbox, searchValue);
            Assert.AreEqual(actual.value, expected.value);
            Assert.AreEqual(actual.id, expected.id);
        }
    }
}
