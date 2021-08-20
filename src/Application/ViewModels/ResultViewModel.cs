namespace Application.ViewModels
{
    public class ResultViewModel
    {
        public string Message { get; set; }

        public bool Success { get; set; }

        //dynamic, tipo de dado referente a entrada
        //no caso se a entrada for int, então se torna int
        public dynamic Data { get; set; }
    }
}
