using System;

namespace pz_3_4_5


{
    enum StatesOfCorrectInput
    {
        EMPTY = -1,
        RIGHT,
        ERROR_MONTH,
        ERROR_DAY,
        ERROR_YEAR
    }
    class Program
    {
        static void Main(string[] args)
        {
            Patient pat2 = new Patient("12.01.2002", "13.02.2010");
            Patient pats = new Patient("12.13.2435", "13.02.1956");
            Patient patss = new Patient("12.05.2456", "13.02.1956");
            Patient patsss = new Patient("59.02.34", "13.02.1956");
            Patient test = new Patient("12.12.2003", "17.02.2022");
            Patient ooo = new Patient("12.12.2000", "13.02.1956");
            Patient oooo = new Patient("12.12.2010", "13.02.1956");

            pat2.GetPatientInfo();
            pats.GetPatientInfo();
            patss.GetPatientInfo();
            patsss.GetPatientInfo();
            test.GetPatientInfo();

            ooo.GetPatientInfo();
            oooo.GetPatientInfo();
            pat2.GetCountPatients();
        }
    }



    class Patient
    {
        string full_name;
        DateTime dataBirth;
        DateTime receiptDate;
        string diagnos;
        static int count_patients = 0;
        static int count_Non_FullYear_Old = 0;
        bool isCorrectInputData = true;

        static public int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        //date format - dd.mm.yyyy
        public Patient(string dateOfBirth, string dateOfReceipt, string diagnos = "неизвестно", string name = "неизвестно")
        {
            if (name == "")
            {
                isCorrectInputData = false;
                Console.WriteLine("Не указано ФИО");
                return;
            }
            if (diagnos == "")
            {
                isCorrectInputData = false;
                Console.WriteLine("Не указан диагноз");
                return;
            }

            full_name = name;
            this.diagnos = diagnos;

            if (checkDate(dateOfBirth, ref dataBirth) != (int)StatesOfCorrectInput.RIGHT ||
               checkDate(dateOfReceipt, ref receiptDate) != (int)StatesOfCorrectInput.RIGHT)
            {
                Console.WriteLine("Ошибка ввода в дате");
                isCorrectInputData = false;
                return;
            }
            if (checkingTimeOfAdmission(receiptDate))
                Console.WriteLine("Пациент поступил менее чем неделю назад");

            count_patients++;
            if (isFullYearOldPatient(ref dataBirth))
                ++count_Non_FullYear_Old;

        }

        private bool isFullYearOldPatient(ref DateTime date)
        {
            TimeSpan dt = new TimeSpan();
            dt = DateTime.Now - date;
            if (dt.Days / 365 >= 18)
                return true;
            return false;
        }
        private bool checkingTimeOfAdmission(DateTime receiptDate)
        {
            if (DateTime.Now.Day - receiptDate.Day >= 7)
                return true;
            return false;
        }

        //Весокосный год не учитывается
        private int checkDate(string date, ref DateTime changeDate)
        {
            if (date == "")
                return (int)StatesOfCorrectInput.EMPTY;

            string[] lexems = date.Split('.');

            //check month
            if (int.Parse(lexems[1]) >= 1 && int.Parse(lexems[1]) <= 12)
            {
                int days = daysInMonth[int.Parse(lexems[1]) - 1];
                if (int.Parse(lexems[0]) >= 1 && int.Parse(lexems[0]) <= days)
                {
                    //Check Year
                    if (int.Parse(lexems[2]) >= 1940 && int.Parse(lexems[2]) <= 2022)
                    {
                        changeDate = new DateTime(int.Parse(lexems[2]), int.Parse(lexems[1]), int.Parse(lexems[0]));
                        return (int)StatesOfCorrectInput.RIGHT;
                    }
                    else
                        return (int)StatesOfCorrectInput.ERROR_YEAR;
                }
                else
                    return (int)StatesOfCorrectInput.ERROR_DAY;
            }
            else
                return (int)StatesOfCorrectInput.ERROR_MONTH;


        }
        public void GetPatientInfo()
        {
            if (isCorrectInputData)
                Console.WriteLine($"ФИО: {full_name}\nДата рождения: {dataBirth}\nДата поступления: {receiptDate}\nДиагноз: {diagnos}\n");
            else
                return;
        }
        public void GetCountPatients()
        {
            Console.WriteLine($"Число больных: {count_patients}\n Число несовершенно-летних больных: {count_Non_FullYear_Old} ");
        }
    }
}
