using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1

{
    internal class clasandobject
    {
    }
}
    /*
    // Move usage into a method (entry point) so we don't reference instance fields during initialization.
    // This fixes CS0236 which occurs when an instance field initializer references another instance member.
    public static void Main(string[] args)
    {
        // 1. Sınıftan bir yardımcı oluştur
        StudentManager manager = new StudentManager();

        // 2. Ortalamayı hesaplat ve bir değişkene kaydet
        int finalGrade = manager.CalculateAverage(45, 85);

        // 3. Kaydettiğin o sonucu ekrana yazdıran metoda gönder
        manager.ShowResult("Esra", finalGrade);
    }
}
}

    */

    /*
    // Örnek bir sınıf ve nesne kullanımı öğrenci not hesaplayıcı 

    public class StudentManager
    {
        public int CalculateAverage(int exam1, int exam2)
        {
            int average = (exam1 + exam2) / 2;
            return average;
        }

        public void ShowResult(string studentName, int Average)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Student Name:" + studentName);
            Console.WriteLine("Average: " + Average);

            if (Average >= 50)
            {
                Console.WriteLine("You passed the exam");
            }
            else
            {
                Console.WriteLine("You failed the exam");
            }
        }

    }
    class Program
    {
        static void Main()
        {
            StudentManager manager = new StudentManager();
            int finalGrade = manager.CalculateAverage(45, 85);
            manager.ShowResult("Esra", finalGrade);

            Console.ReadLine();
        }
    }
}

*/




