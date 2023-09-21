namespace Models
{
    public class Pagamento
        {
        public int  pagamento_id { get; set; }
        public string user_id_given { get; set; }
        public string user_id_reciven { get; set; }
        public DateTime date_trans { get; set; }
        public Boolean comprovante { get; set; }
    }
}