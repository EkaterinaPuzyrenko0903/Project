using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class DataInvoicesPay
    {
        [Key]
        //Таблица результат обработки данных
        public int Id { get; set; }
        public int Kod { get; set; }//Филиал код
        public string? Name { get; set; }//Филиал Название
        public int IdClient { get; set; }//Код клиента
        public double IdScore { get; set; }//Номер док счета
        [Column(TypeName = "date")]
        public DateTime DateScore { get; set; }//Дата док счета
        public string? ViewScore { get; set; }//Вид док счета
        public int payCondition { get; set; }//Условие платежа, дней

        public double IdPayment { get; set; }//Номер док платежа
        [Column(TypeName = "datetime")]
        public DateTime DatePayment { get; set; }//Дата док платежа
        public string? ViewPayment { get; set; }//Вид док платежа
        public int DayPay { get; set; }//Кол-во дней до оплаты
        public double SumScore { get; set; }//Сумма счета
        public double SumPayment { get; set; }//Сумма платежа
        public double Sum { get; set; }//Сумма платежа к счету

    }
}
