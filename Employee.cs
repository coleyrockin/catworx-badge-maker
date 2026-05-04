namespace CatWorx.BadgeMaker
{
  class Employee
  {
    public Employee(string firstName, string lastName, int id, string photoUrl)
    {
      FirstName = firstName;
      LastName = lastName;
      Id = id;
      PhotoUrl = photoUrl;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public int Id { get; }
    public string PhotoUrl { get; }

    public string GetFullName()
    {
      return $"{FirstName} {LastName}";
    }
  }
}
