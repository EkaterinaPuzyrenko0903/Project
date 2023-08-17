using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class OutputTable
    {
        public List<Output> outputs {  get; set; }
    }
    public class Output

    {
        public string? Name { get; set; }//Филиал Название
        public int IdClient { get; set; }//Код клиента
        public double IdScore { get; set; }//Номер док счета
        [Column(TypeName = "date")]
        public DateTime DateScore { get; set; }//Дата док счета
        public string? ViewScore { get; set; }//Вид док счета

        public int payCondition { get; set; }//Условие платежа, дней
        public string? ViewPayment { get; set; }//Вид док платежа

        public int DayPay { get; set; }//Кол-во дней до оплаты
        public double SumScore { get; set; }//Сумма счета
        public double SumPayment { get; set; }//Сумма платежа
        public double Sum { get; set; }//Сумма платежа к счету
        public double dolya { get; set; }

    }
}
