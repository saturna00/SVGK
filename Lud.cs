using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp30
{
    class Lud
    {
        public int id { get; set; }
        public string Фио { get; set; }
        public string Номер_телефона { get; set; }
        public string Номер_карты { get; set; }
        public string Серия_Номер_паспорта { get; set; }
        public string Трудоустройство { get; set; }
        public string Задолженности_по_кредитам { get; set; }
        public Lud() { }
        public Lud(string Фио, string Номер_телефона, string Номер_карты, string Серия_Номер_паспорта, string Трудоустройство, string Задолженности_по_кредитам)
        {
            this.Фио = Фио;
            this.Номер_телефона = Номер_телефона;
            this.Номер_карты = Номер_карты;
            this.Серия_Номер_паспорта = Серия_Номер_паспорта;
            this.Трудоустройство = Трудоустройство;
            this.Задолженности_по_кредитам = Задолженности_по_кредитам;
        }

    }
}

