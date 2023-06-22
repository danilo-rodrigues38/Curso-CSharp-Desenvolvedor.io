using System.Data.Common;

namespace Modulo11;

public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2022, 12, 02, 19, 22, 23 );
        var date2 = DateTime.Parse( "2022/12/22 19:25:23" );
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine("\n" + date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4 + "\n");

        Console.WriteLine(date1.ToString("yyyy_MM_dd_HH_mm_ss\n"));

        var dateOffSet1 = new DateTimeOffset( DateTime.Now, new TimeSpan(-3, 0, 0));

        Console.WriteLine("\n" + dateOffSet1.LocalDateTime);
        Console.WriteLine(dateOffSet1.UtcDateTime + "\n");
    }

    public void AulaSubtraindoDatas()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2023-06-01");

        // var diff = date1 - date2;
        var diff = date1.Subtract(date2);

        Console.WriteLine("\nTotal de dias: {0}", (int)diff.TotalDays);
        Console.WriteLine("Total de horas: {0}\n", (int)diff.TotalHours);
    }

    public void AulaAdicionandoDiasMesAno()
    {
        var date1 = DateTime.Now;

        Console.WriteLine("\n");
        Console.WriteLine("Data atual  : {0}", date1.ToString("dd/MM/yyyy HH:mm:ss"));
        Console.WriteLine("Data +3 dias: {0}", date1.AddDays(3).ToString("dd/MM/yyyy HH:mm:ss"));
        Console.WriteLine("Data +1 mês : {0}", date1.AddMonths(1).ToString("dd/MM/yyyy HH:mm:ss"));
        Console.WriteLine("Data +2 anos: {0}\n", date1.AddYears(2).ToString("dd/MM/yyyy HH:mm:ss"));
    }

    public void AulaAdicionandoHoraMinutoSegundos()
    {
        var date1 = DateTime.Now;

        Console.WriteLine("\n");
        Console.WriteLine("Hora atual : {0}\n", date1.ToString("HH:mm:ss"));
        Console.WriteLine("Hora +1    : {0}", date1.AddHours(1).ToString("HH:mm:ss"));
        Console.WriteLine("Minuto +10 : {0}", date1.AddMinutes(10).ToString("HH:mm:ss"));
        Console.WriteLine("Segundo +10: {0}\n", date1.AddSeconds(10).ToString("HH:mm:ss"));
    }

    public void AulaRecuperarDiaDaSemana()
    {
        var date1 = DateTime.Now;
        Console.WriteLine(date1.DayOfWeek);
    }

    public void AulaDateOnly()
    {
        // var somenteData = new DateOnly(2023, 06, 19);
        var somenteData = DateOnly.Parse("2023-06-19");
        Console.WriteLine(somenteData);
    }

    public void AulaTimeOnly()
    {
        // var somenteHora = new TimeOnly(19:40:30);
        var somenteHora = TimeOnly.Parse("19:40:30");
        Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
    }
}