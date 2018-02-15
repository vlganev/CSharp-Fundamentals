public class StandartEmployee : BaseEmployee
{
    protected const int WorkHoursPerWeek = 40;
    public StandartEmployee(string name) : base(name, WorkHoursPerWeek)
    {
    }
}