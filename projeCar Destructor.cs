using System;

namespace ConsoleApp10
{

        class Car
        {

            // ویژگی‌های کلاس
            private string make;   // برند خودرو
            private string model;  // مدل خودرو
            private int year;      // سال تولید خودرو

            // سازنده
            public Car(string make, string model, int year)
            {
                this.make = make;
                this.model = model;
                this.year = year;
                Console.WriteLine($"سیستم شروع به کار: {year} {make} {model} ایجاد شد.");
            }
            // تخریب‌کننده
            ~Car()
            {
                Console.WriteLine($"سیستم بسته شد: {year} {make} {model} تخریب شد.");
            }
        }
        class program
        {


            static void Main(string[] args)
            {
                // نمونه‌سازی از کلاس Car
                Car myCar = new Car("تويوتا", "کمری", 2020);

                // مقداری به کار می‌رود و سپس شی به طور خودکار وقتی که خارج از محدوده قرار می‌گیرد، تخریب می‌شود
                myCar = null; // حذف نمونه برای مشاهده پیام تخریب‌کننده 

                // درخواست جمع‌آوری زباله
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
