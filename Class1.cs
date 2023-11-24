using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotaSBDLib
{
    
    public class Class1
    {
        public ParsingEntity db = new ParsingEntity();


        public string GetByID(string ID_Date) //получение записи по айди
        {
            var s = db.Parsing.FirstOrDefault(u => u.ID_Parsing == ID_Date);
            string Date = s.Message_Parsing;
            return Date;
        }
        public List<Parsing> GetByName(string Name_Pars) //получение записей по заданному name
        {
            List<Parsing> Messages = db.Parsing.Where(u => u.Name_Parsing == Name_Pars).ToList();
            return Messages;

        }
        public string Add(string Name_Pars, string Message_Pars, string ID_Pars)// Добавление записи
        {
            Parsing pars = new Parsing();
            pars.ID_Parsing = ID_Pars;
            pars.Name_Parsing = Name_Pars;
            pars.Message_Parsing = Message_Pars;
            db.Parsing.Add(pars);
            db.SaveChanges();
            string Message_Info = "Данные добавлены";
            return Message_Info;

        }
        public string Update(string ID_Date, string Update_Message) //изменение сообщения
        {
            var s = db.Parsing.FirstOrDefault(u => u.ID_Parsing == ID_Date);
            s.Message_Parsing = Update_Message;
            db.SaveChanges();
            if (s.Message_Parsing == Update_Message)
            {
                string Message_Info = "Данные записи изменены";
                return Message_Info;
            }
            else
            {
                string Message_Info = "Данные записи не изменены";
                return Message_Info;
            }

        }
        public string Delete(string ID_Date) // Удаление записи
        {
            var s = db.Parsing.FirstOrDefault(u => u.ID_Parsing == ID_Date);
            db.Parsing.Remove(s);
            db.SaveChanges();
            string Message_Info = "Данные записи удалены";
            return Message_Info;
        }

    }

}

