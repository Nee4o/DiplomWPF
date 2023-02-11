using System;
using System.Text;

namespace DiplomWPF
{
    public class ErrorHandler
    {
        public static StringBuilder Handler(Models.Request request)
        {
            DateTime dt;
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(request.Title))
                errors.AppendLine("Укажите название заявки");
            if (string.IsNullOrWhiteSpace(request.Post))
                errors.AppendLine("Укажите должность");
            if(!(DateTime.TryParse(request.DateOfCreation.ToString(), out dt)))
                errors.AppendLine("Укажите корректную дату");

            return errors;
        }
    }
}
