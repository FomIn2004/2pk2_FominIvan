using System;

namespace pz_3_4_5
{

    class Program
    {
        static void Main(string[] args)
        {
            Patient pat = new Patient("Иван", "Фомин", "Сергеевич");
            Patient pat1 = new Patient("Иван", "Фомин", "Сергеевич", "воспаление хитрости");
            Patient pat2 = new Patient(new DateTime(2002, 03, 03), new DateTime(2020, 07, 08));
            Patient pat3 = new Patient("Иван", "Иванов", "Иванович");
            pat.GetPatientInfo();
            Console.WriteLine();
            Console.WriteLine();
            pat1.GetPatientInfo();
            Console.WriteLine();
            Console.WriteLine();
            pat2.GetPatientInfo();
            Console.WriteLine();
            Console.WriteLine();
            pat3.GetPatientInfo();

        }
    }
    class Patient
    {
        string name;
        string fam;
        string otch;
        DateTime dataBirth;
        DateTime receiptDate;
        string diagnos;

        public Patient(string name, string fam, string otch)
        {
            this.name = name;
            this.fam = fam;
            this.otch = otch;
            dataBirth = new DateTime(2004, 09, 17);
            receiptDate = new DateTime(2022, 02, 10);
            diagnos = "здоров";
        }
        public Patient(DateTime dataBirth, DateTime receiptDate)
        {
            this.dataBirth = dataBirth;
            this.receiptDate = receiptDate;
            name = fam = otch = "неизвестно";
            diagnos = "здоров";
        }
        public Patient(string name, string fam, string otch, string diagnos)
        {
            this.name = name;
            this.fam = fam;
            this.otch = otch;
            this.diagnos = diagnos;
            dataBirth = new DateTime(2004, 09, 17);
            receiptDate = new DateTime(2022, 02, 10);
        }
        public void GetPatientInfo()
        {
            Console.WriteLine($"Имя: {name}\nФамилия: {fam}\nОтчество: {otch}\nДата рождения: {dataBirth}\nДата рецепта: {receiptDate}\nДиагноз: {diagnos}");
        }

    }

}
