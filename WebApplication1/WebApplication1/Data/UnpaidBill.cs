using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    public class UnpaidBill
    {
        //Прогноз поступления денежных средств на основе данных о неоплаченных счетах
        [Key]
        public int Id { get; set; }
        public  int kodBranch { get; set; }//Филиал код
        public int kodClient { get; set; } //Код клиента
        public double numberDoc { get; set; } //Номер документа
        public string? View { get; set; }//Вид
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }//Дата платежа/счета
        public int payCondition { get; set; }//Условие платежа, дней
        public double sum { get; set; } //Сумма

    }
}
