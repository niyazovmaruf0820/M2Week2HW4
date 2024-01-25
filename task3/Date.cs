namespace task3;

public class Date
{
    private int day;
    private int month;
    private int year;
    private int Day;
    private int Month;
    private int Year;
    public Date(){}
    public Date(int day)
    {
        this.day = day;
    }
    public Date(int day, int month)
    {
        this.day = day;
        this.month = month;
    }
    
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    public void SetDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    public int GetDate()
    {
        return day;
    }
    public int GetMonth()
    {
        return month;
    }
    public int GetYear()
    {
        return year;
    }
    public string ToString()
    {
        return $"{day}/{month}/{year}";
    }
}
