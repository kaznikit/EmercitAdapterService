using System;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;
using Npgsql;
using System.Configuration;
using System.Xml;

namespace EmercitAdapterService
{
  // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
  // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
  public class EmercitAdapterService : IEmercitAdapterServiceSoapBinding
  {
    private string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
    private string Login = ConfigurationManager.AppSettings["Login"];
    private string Pass = ConfigurationManager.AppSettings["Pass"];

    [return: XmlElement("return", Form = XmlSchemaForm.Unqualified)]
    public bool newIER([XmlElement(Form = XmlSchemaForm.Unqualified)] ier ier)
    {
      //parse ier and write to database
      XmlDocument document = new XmlDocument();
      ier.ToString();
      return true;
    }
  }
}
