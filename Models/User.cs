public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public User(){}
    public User(int id, string name, string lastName){
        this.Id = id;
        this.Name = name;
        this.LastName = lastName;
    }
    // Otras propiedades de usuario
}