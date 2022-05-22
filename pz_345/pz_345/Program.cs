using System;

namespace pz_3
{
    class Program
    {
        class PrivatePhone : Phone
        {
            public string Availability;
            public PrivatePhone(string prefix, int code, string number, string type, string Availability) : base(prefix, code, number, type)
            {
                this.Availability = Availability;
            }
            public override void GetPhoneNumber()
            {
                char[] num = Number.ToCharArray();
                Console.WriteLine(Prefix + $"({Code})" + num[0] + num[1] + num[2] + '-' + num[3] + num[4] + '-' + num[5] + num[6] + "  Список абонентов с доступом к этому номеру: " + Availability);
            }
        }
        static void Main(string[] args)
        {
            Phone ph = new Phone("+7");
            Phone ph1 = new Phone("+7", 898, "3572381", "личный");
            Phone ph2 = new Phone(345, "1234567");
            Phone ph3 = new Phone("+1");
            Phone ph4 = new Phone("+7", 898, "3572365", "корпоративный");
            Phone ph5 = new Phone("+7", 898, "3572318", "личный");
            PrivatePhone prf = new PrivatePhone("+7", 922, "9248712", "корпоративный", "Бенедикт Камбербэтч, Револьвер Оцелот, Гена Цидармян, Всеволод Борман");
            PrivatePhone prf1 = new PrivatePhone("+8", 951, "6723945", "корпоративный", "Кирилл, Мефодий");
            ph.GetPhoneNumber();
            ph1.GetPhoneNumber();
            ph2.GetPhoneNumber();
            ph3.GetPhoneNumber();
            prf.GetPhoneNumber();
            prf1.GetPhoneNumber();
            ph.GetPrivateNumCount();
            ph.GetCorporateNumCount();
        }
    }
    class Phone
    {
        string prefix;
        public string Prefix
        {
            get { return prefix; }
            set { if (value.Length == 2) prefix = value; }
        }
        int code;
        public int Code
        {
            get { return code; }
            set { if (value == 3) code = value; }
        }
        string number;
        public string Number
        {
            get { return number; }
            set { if (value.Length == 7) number = value; }
        }
        string type;
        public string Type
        {
            get { return type; }
            set { if (value != null) type = value; }
        }
        static int private_number;
        static int corporate_number;

        public Phone(string prefix)
        {
            this.prefix = prefix;
            code = 123;
            number = "0000000";
        }
        public Phone(string prefix, int code, string number, string type)
        {
            this.prefix = prefix;
            this.code = code;
            this.number = number;
            this.type = type;
            if (type == "личный") private_number++;
            else if (type == "корпоративный") corporate_number++;
        }
        public Phone(int code, string number)
        {
            prefix = "+7";
            this.code = code;
            this.number = number;

        }
        public virtual void GetPhoneNumber()
        {
            char[] num = number.ToCharArray();
            Console.WriteLine(prefix + "(" + code + ")" + num[0] + num[1] + num[2] + '-' + num[3] + num[4] + '-' + num[5] + num[6]);
        }
        public void GetPrivateNumCount()
        {
            Console.WriteLine($"Личных номеров: {private_number}");
        }
        public void GetCorporateNumCount()
        {
            Console.WriteLine($"Корпоративных номеров: {corporate_number}");
        }
    }
}
