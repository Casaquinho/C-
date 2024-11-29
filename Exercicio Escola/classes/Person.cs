public class Person
{
    public string name;
    public string address;

    public Person(string name, string address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName()
    {
        return name;
    }

    public string GetAddress()
    {
        return address;
    }
    public bool Equals(Person another)
    {
        if(another.Equals(this))
        {
            return true;
        }
        else{
            return false;
        
        }
    }
    
    // override object.GetHashCode
    public string hashCode()
    {
        return "nome: " + this.name + "endereço: " + this.address;
    }


}