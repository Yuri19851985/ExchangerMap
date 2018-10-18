using MudulExchange.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MudulExchange.Context
{
    public class Initializer : DropCreateDatabaseAlways<ExchangeContext>
    {
        protected override void Seed(ExchangeContext context)
        {
            base.Seed(context);

            XDocument xmlDoc = XDocument.Load("banks.xml");
            foreach (XElement bankElement in xmlDoc.Elements("Banks").Elements("bank"))
            {
                Bank bankUnit = new Bank();
                bankUnit.BankInfos = new List<BankInfo>();
                XAttribute nameAttribute = bankElement.Attribute("name");
                if (nameAttribute != null)
                    bankUnit.Name = nameAttribute.Value;
                foreach (XElement bankInfoelement in bankElement.Elements("departmen"))
                {
                    
                    XElement addrElement = bankInfoelement.Element("address");
                    XElement latElement = bankInfoelement.Element("latitude");
                    XElement longElement = bankInfoelement.Element("longitude");
                    if (addrElement != null && latElement != null && longElement != null)
                    {
                        BankInfo bankInfoUnit = new BankInfo();
                        bankInfoUnit.Address = addrElement.Value;
                        bankInfoUnit.latitude = Convert.ToDouble(latElement.Value);
                        bankInfoUnit.longitude = Convert.ToDouble(longElement.Value);
                        bankUnit.BankInfos.Add(bankInfoUnit);
                    }
                }
                context.Banks.Add(bankUnit);
                context.SaveChanges();
            }

            ///// таблица курсов
            XDocument xmlDocRate = XDocument.Load("http://www.obmennik.by/xml/kurs.xml");

            NumberFormatInfo formatSepar = new NumberFormatInfo();
            formatSepar.NumberDecimalSeparator = ".";

            foreach (XElement bankRate in xmlDocRate.Elements("banks").Elements("bank-id"))
            {
                XElement idbank = bankRate.Element("idbank");
                XElement date = bankRate.Element("date");
                XElement timeSet = bankRate.Element("time");
                XElement usdsell = bankRate.Element("usd").Element("sell");
                XElement usdbuy = bankRate.Element("usd").Element("buy");
                XElement eursell = bankRate.Element("eur").Element("sell");
                XElement eurbuy = bankRate.Element("eur").Element("buy");
                XElement rursell = bankRate.Element("rur").Element("sell");
                XElement rurbuy = bankRate.Element("rur").Element("buy");
                //поиск имени банка в БД для текущего курса
                string nameOfBank;
                if (idbank != null && date != null && timeSet != null
                                       && usdsell != null && usdbuy != null && timeSet != null
                                       && timeSet != null && timeSet != null && timeSet != null)
                {
                    nameOfBank = nameSelect(Convert.ToInt32(idbank.Value));
                    if (nameOfBank != "")
                    {
                        foreach (var bank in context.Banks)
                        {
                            if (bank.Name == nameOfBank)
                            {
                                bank.date = (Convert.ToDateTime(date.Value)).Date.ToString();
                                bank.time = (Convert.ToDateTime(timeSet.Value)).TimeOfDay.ToString();
                                bank.usdSell = Double.Parse(usdsell.Value, formatSepar);
                                bank.usdBuy = Double.Parse(usdbuy.Value, formatSepar);
                                bank.eurSell = Double.Parse(eursell.Value, formatSepar);
                                bank.eurBuy = Double.Parse(eurbuy.Value, formatSepar);
                                bank.rurSell = Double.Parse(rursell.Value, formatSepar);
                                bank.rurBuy = Double.Parse(rurbuy.Value, formatSepar);
                                break;
                            }
                        }
                    }
                }
            }
            context.SaveChanges();
        }
        public string nameSelect(int id)
        {
            string name;
            if (id == 1) { name = "Абсолютбанк"; return name; }
            if (id == 2) { name = "Альфа-Банк"; return name; }
            if (id == 3) { name = "ВТБ Беларусь"; return name; }
            if (id == 4) { name = "БелАгроПромБанк"; return name; }
            if (id == 5) { name = "БелГазпромБанк"; return name; }
            if (id == 6) { name = "БелИнвестБанк"; return name; }
            if (id == 7) { name = "Белорусский Банк Малого Бизнеса"; return name; }
            if (id == 8) { name = "Белорусский Народный Банк"; return name; }
            if (id == 9) { name = "БПС-Сбербанк"; return name; }
            if (id == 10) { name = "Белросбанк"; return name; }
            if (id == 11) { name = "БСБ Банк (БелСвиссБанк)"; return name; }
            if (id == 12) { name = "БТА Банк"; return name; }
            if (id == 13) { name = "ЕвроТоргИнвестБанк"; return name; }
            if (id == 14) { name = "Международный резервный банк"; return name; }
            if (id == 15) { name = "МТБанк"; return name; }
            if (id == 16) { name = "Паритетбанк"; return name; }
            if (id == 17) { name = "ПриорБанк"; return name; }
            if (id == 18) { name = "БеларусБанк"; return name; }
            if (id == 19) { name = "Идея Банк"; return name; }
            if (id == 20) { name = "ТехноБанк"; return name; }
            if (id == 21) { name = "Хоум Кредит Банк"; return name; }
            if (id == 22) { name = "Цептер Банк"; return name; }
            if (id == 23) { name = "Москва-Минск Банк"; return name; }
            if (id == 24) { name = "ТрастБанк"; return name; }
            if (id == 25) { name = "Банк БелВЭБ"; return name; }
            if (id == 26) { name = "ФрансаБанк"; return name; }
            if (id == 27) { name = "Дельта Банк"; return name; }
            if (id == 28) { name = "РРБ-Банк"; return name; }
            if (id == 29) { name = "Кредэксбанк"; return name; }
            if (id == 30) { name = "ТК Банк"; return name; }
            if (id == 31) { name = "Онербанк"; return name; }
            if (id == 32) { name = "Бит-Банк"; return name; }
            return name = "";
        }
    }
}
