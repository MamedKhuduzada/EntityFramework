
using EntityFramework.DataContexs;
using EntityFramework.Models;

internal class Program
{
    static CityDbContext _dbContext = new CityDbContext();
    private static void Main(string[] args)
    {
        List<City> cities = GetAllStudents();
        foreach (City city in cities)
        {
            Console.WriteLine(city.Name);
        }
    }
    public static void AddCity(string name)
    {
        City city = new()
        {          
            Name = name 
        };
        _dbContext.Cities.Add(city);
        _dbContext.SaveChanges();   
    }
    public static List<City> GetAllStudents()
    {
        List<City> cities = _dbContext.Cities.ToList();
        return cities;
    }
}