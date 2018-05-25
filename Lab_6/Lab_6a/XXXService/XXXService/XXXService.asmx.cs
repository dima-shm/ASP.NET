using System.Web.Services;

namespace XXXService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class XXXService : WebService
    {
        [WebMethod(Description = "Возвращает x + y")]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod(Description = "Возвращает x - y")]
        public int Sub(int x, int y)
        {
            return x - y;
        }

        [WebMethod(Description = "Возвращает x * y")]
        public int Mul(int x, int y)
        {
            return x * y;
        }

        [WebMethod(Description = "Устанавливает значение переменной a", EnableSession = true)]
        public void SetA(int a)
        {
            Session["a"] = a;
        }

        [WebMethod(Description = "Получает значение переменной a", EnableSession = true)]
        public int GetA()
        {
            if (Session["a"] != null)
            {
                return (int)Session["a"];
            }
            else
            {
                return 0;
            }
        }

        [WebMethod(Description = "Увеличить значение счетчика на 1")]
        public void IncreaseСounter()
        {
            int count = 0;
            if (Application["Count"] != null)
            {
                count = (int)Application["Count"];
            }

            count++;
            Application["Count"] = count;
        }

        [WebMethod(Description = "Получить значение счетчика")]
        public int GetСounterValue()
        {
            if (Application["Count"] != null)
            {
                return (int)Application["Count"];
            }
            else
            {
                return 0;
            }
        }
    }
}
