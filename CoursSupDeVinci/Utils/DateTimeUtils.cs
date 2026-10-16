using System.Globalization;

namespace CoursSupDeVinci.Utils;

public class DateTimeUtils
{
    public static DateTime ConvertToDateTime(String date)
    {
        if (DateTime.TryParseExact(date,"dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime birthdate))
        {
            return DateTime.SpecifyKind(birthdate, DateTimeKind.Utc);
        }
        else
        {
            Console.WriteLine($"La date {date} est mal renseignée");
            return DateTime.Now;
        }
    }
}