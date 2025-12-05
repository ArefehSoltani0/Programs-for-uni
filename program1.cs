using System;

class Program
{
    // متد بازگشتی برای محاسبه GCD دو عدد
    static int GCD(int a, int b)
    {
        // پایهٔ بازگشت: اگر b صفر شد، a جواب است
        if (b == 0)
            return Math.Abs(a); // برای پوشش اعداد منفی، از قدر مطلق استفاده می‌کنیم
        // فراخوانی بازگشتی
        return GCD(b, a % b);
    }

    static void Main()
    {
        Console.WriteLine("برنامه محاسبه بزرگ‌ترین مقسوم‌علیه مشترک (GCD) دو عدد");
        Console.Write("عدد اول را وارد کنید: ");
        if (!int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("ورودی نامعتبر است.");
            return;
        }

        Console.Write("عدد دوم را وارد کنید: ");
        if (!int.TryParse(Console.ReadLine(), out int num2))
        {
            Console.WriteLine("ورودی نامعتبر است.");
            return;
        }

        int result = GCD(num1, num2);
        Console.WriteLine($"بزرگ‌ترین مقسوم‌علیه مشترک {num1} و {num2} برابر است با: {result}");
    }
}